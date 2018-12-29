using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace net.adamec.lib.common.utils
{
    //Based on code of https://github.com/dwmkerr/consolecontrol

    /// <summary>
    /// A class the wraps a process, allowing programmatic input and output.
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.ProcessWrapper</NuProp.Id>
    /// <NuProp.Description>A class the wraps a process, allowing programmatic input and output (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only process</NuProp.Tags> 
    public class ProcessWrapper
    {
        private const int OutputWorkerPeriodMs = 100;

        /// <summary>
        /// The internal process.
        /// </summary>
        public Process Process { get; private set; }
        /// <summary>
        /// The command starting the process
        /// </summary>
        public string Command { get; private set; }
        /// <summary>
        /// The command arguments.
        /// </summary>
        public string CommandArguments { get; private set; }
        /// <summary>
        /// The command working directory.
        /// </summary>
        public string WorkingDirectory { get; private set; }
        /// <summary>
        /// Returns true when the process is running
        /// </summary>
        public bool IsProcessRunning
        {
            get
            {
                try
                {
                    return !Process?.HasExited ?? false;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// The input writer.
        /// </summary>
        private StreamWriter inputWriter;
        /// <summary>
        /// The output reader.
        /// </summary>
        private TextReader outputReader;
        /// <summary>
        /// The error reader.
        /// </summary>
        private TextReader errorReader;

        /// <summary>
        /// The standard output worker.
        /// </summary>
        private readonly BackgroundWorkerWithSyncCancel stdOutputWorker = new BackgroundWorkerWithSyncCancel();
        /// <summary>
        /// The error output worker.
        /// </summary>
        private readonly BackgroundWorkerWithSyncCancel errorOutputWorker = new BackgroundWorkerWithSyncCancel();

        /// <summary>
        /// Occurs when process output (incl. error stream) is produced.
        /// </summary>
        public event ProcessEventHandler OnProcessOutput;

        /// <summary>
        /// Occurs when the process ends.
        /// </summary>
        public event ProcessEventHandler OnProcessExit;

        /// <summary>
        /// CTOR
        /// </summary>
        public ProcessWrapper()
        {
            stdOutputWorker.WorkerReportsProgress = true;
            stdOutputWorker.WorkerSupportsCancellation = true;
            stdOutputWorker.DoWork += StdOutputWorkerDoWorkHandler;
            stdOutputWorker.ProgressChanged += OutputWorkerProgressChangedHandler;

            errorOutputWorker.WorkerReportsProgress = true;
            errorOutputWorker.WorkerSupportsCancellation = true;
            errorOutputWorker.DoWork += ErrorOutputWorkerDoWorkHandler;
            errorOutputWorker.ProgressChanged += OutputWorkerProgressChangedHandler;
        }

        /// <summary>
        /// Runs a process with given <paramref name="command"/>
        /// </summary>
        /// <param name="command">Name of the file to run</param>
        /// <param name="arguments">Optional command line arguments</param>
        /// <param name="workingDirectory">Optional working directory</param>
        /// <exception cref="ArgumentException"><paramref name="command"/> is null or empty</exception>
        public bool StartProcess(string command, string arguments = null, string workingDirectory = null)
        {
            if (string.IsNullOrWhiteSpace(command)) throw new ArgumentException($"{nameof(command)} is null or empty");
            if (IsProcessRunning) return false;

            Command = command;
            CommandArguments = arguments;
            WorkingDirectory = workingDirectory ?? Environment.CurrentDirectory;

            //Configure the process
            var processStartInfo = new ProcessStartInfo(command, arguments)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                WorkingDirectory = WorkingDirectory
            };

            //Create the process
            Process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            };
            Process.Exited += ProcessExitedHandler;
            //Start the process
            Process.Start();

            //Create readers and writers
            inputWriter = Process.StandardInput;
            outputReader = TextReader.Synchronized(Process.StandardOutput);
            errorReader = TextReader.Synchronized(Process.StandardError);

            // Run the workers that read output and error
            stdOutputWorker.RunWorkerAsync();
            errorOutputWorker.RunWorkerAsync();
            return true;
        }

        /// <summary>
        /// Stops the process.
        /// </summary>
        public void StopProcess()
        {
            if (!IsProcessRunning) return;

            //Kill the process.

            Process.Kill();
            stdOutputWorker.Cancel();
            errorOutputWorker.Cancel();
        }

        /// <summary>
        /// Writes the input into the process
        /// </summary>
        /// <param name="input">The process input</param>
        public void WriteInput(string input)
        {
            if (!IsProcessRunning) return;

            inputWriter.WriteLine(input);
            inputWriter.Flush();
        }

        /// <summary>
        /// Internal class to hold the output chunk within the output worker
        /// </summary>
        protected class OutputChunk
        {
            public bool IsError { get; }
            public string Output { get; }

            public OutputChunk(bool isError, string output)
            {
                IsError = isError;
                Output = output;
            }
        }

        /// <summary>
        /// Handles the ProgressChanged event of the output worker
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data.</param>
        private void OutputWorkerProgressChangedHandler(object sender, ProgressChangedEventArgs e)
        {
            if (!(e.UserState is OutputChunk chunk)) return;
            RaiseProcessOutputEvent(chunk);
        }

        /// <summary>
        /// Handles the DoWork event of the standard output worker
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void StdOutputWorkerDoWorkHandler(object sender, DoWorkEventArgs e)
        {
            while (!stdOutputWorker.CancellationPending && !stdOutputWorker.IsCancelling)
            {
                ProcessOutput(stdOutputWorker, outputReader, false);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the error output worker
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event data</param>
        private void ErrorOutputWorkerDoWorkHandler(object sender, DoWorkEventArgs e)
        {
            while (!errorOutputWorker.CancellationPending && !errorOutputWorker.IsCancelling)
            {
                ProcessOutput(errorOutputWorker, errorReader, true);
            }
        }

        /// <summary>
        /// Processes the output from standard output or error output stream <paramref name="reader"/>
        /// </summary>
        /// <param name="worker">Worker providing the output</param>
        /// <param name="reader">Standard output or error output stream reader to process </param>
        /// <param name="isError">Flag whether the output is to be marked as error</param>
        private void ProcessOutput(BackgroundWorkerWithSyncCancel worker, TextReader reader, bool isError)
        {
            if (reader == null) return;
            int count;
            var buffer = new char[1024];
            do
            {
                var sb = new StringBuilder();
                count = reader.Read(buffer, 0, 1024);
                sb.Append(buffer, 0, count);
                worker.ReportProgress(0, new OutputChunk(isError, sb.ToString()));
            } while (count > 0 && !worker.CancellationPending && !worker.IsCancelling);
            Thread.Sleep(OutputWorkerPeriodMs); //not to overload event recipients with a lot of events with small part of output
        }

        /// <summary>
        /// Handles the Exited event of the currentProcess control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ProcessExitedHandler(object sender, EventArgs e)
        {
            var exitCode = 0;
            try
            {
                exitCode = Process.ExitCode;
            }
            catch (Exception)
            {
                //just ignore - process has been probably killed
            }

            //Cleanup
            var tmpCommand = Command;
            stdOutputWorker.Cancel();
            errorOutputWorker.Cancel();
            inputWriter = null;
            outputReader = null;
            errorReader = null;
            Process = null;
            Command = null;
            CommandArguments = null;

            //Raise process exited.
            RaiseProcessExitEvent(exitCode, tmpCommand);
        }

        /// <summary>
        /// Raises OnProcessOutput event
        /// </summary>
        /// <param name="outputChunk">The output from process</param>
        private void RaiseProcessOutputEvent(OutputChunk outputChunk)
        {
            OnProcessOutput?.Invoke(this, new ProcessEventArgs(outputChunk.Output, outputChunk.IsError));
        }

        /// <summary>
        /// Raises OnProcessExit event
        /// </summary>
        /// <param name="code">The exit code</param>
        /// <param name="command">Command name to be set to the args Content</param>
        private void RaiseProcessExitEvent(int code, string command)
        {
            OnProcessExit?.Invoke(this, new ProcessEventArgs(code, command));
        }
    }

    /// <summary>
    /// A ProcessEventHandler is a delegate for process output events.
    /// </summary>
    /// <param name="sender">The event sender</param>
    /// <param name="args">The <see cref="ProcessEventArgs"/> instance containing the event data</param>
    public delegate void ProcessEventHandler(object sender, ProcessEventArgs args);

    /// <inheritdoc />
    /// <summary>
    /// The ProcessEventArgs are arguments for a console event.
    /// </summary>
    public class ProcessEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the process input/output content.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Flag whether the <see cref="Content"/> is from error stream (true)
        /// </summary>
        public bool IsError { get; }

        /// <summary>
        /// Gets the process exit code.
        /// </summary>
        public int Code { get; }

        /// <inheritdoc />
        /// <summary>
        /// CTOR with content
        /// </summary>
        /// <param name="content">The content output from or input to process</param>
        /// <param name="isError"> Flag whether the <see cref="Content"/> is from error stream (true)</param>
        public ProcessEventArgs(string content, bool isError = false)
        {
            Content = content;
            IsError = isError;
        }

        /// <inheritdoc />
        /// <summary>
        /// CTOR with code
        /// </summary>
        /// <param name="code">Process exit code</param>
        /// <param name="command">Command name to be set to the args <see cref="Content"/></param>
        public ProcessEventArgs(int code, string command)
        {
            Code = code;
            Content = command;
        }
    }
}
