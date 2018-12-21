using System;
using System.Diagnostics;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// <see cref="Process"/> related utilities
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.ProcessUtils</NuProp.Id>
    /// <NuProp.Description>Process related utilities (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ProcessUtils
    {
        /// <summary>
        /// Synchronously runs a command (process) and returns the standard output or error text
        /// </summary>
        /// <param name="command">Command to run</param>
        /// <param name="args">Command line arguments</param>
        /// <param name="workingDirectory">Working directory</param>
        /// <param name="outputOrError">OUT: the standard output or error text</param>
        /// <returns>True is process runs OK (<paramref name="outputOrError"/> is standard output) or
        /// false in case of exception or command error (<paramref name="outputOrError"/> is the error output or exception message)</returns>
        public static bool RunCommand(string command, string args, string workingDirectory, out string outputOrError)
        {
            string output = null;
            string err = null;
            var startInfo = new ProcessStartInfo
            {
                FileName = command,
                Arguments = args ?? "",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = workingDirectory,
                CreateNoWindow = true
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            // ReSharper disable AccessToModifiedClosure
            process.OutputDataReceived += (s, ea) => output += (string.IsNullOrEmpty(output) ? "" : Environment.NewLine) + ea.Data;
            process.ErrorDataReceived += (s, ea) => err += (string.IsNullOrEmpty(err) ? "" : Environment.NewLine) + ea.Data;
            // ReSharper restore AccessToModifiedClosure

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                output = null;
                err = ex.Message;
            }

            //Get outputs
            var retVal = string.IsNullOrEmpty(err);
            outputOrError = retVal ? output : err;
            return retVal;
        }
    }

}
