using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.async
{
    /// <summary>
    /// Helpers for running the actions in sync or async mode
    /// </summary>
    /// <NuProp.Id>RadCommons.async.AsyncManager</NuProp.Id>
    /// <NuProp.Description>Helpers for running the actions in sync or async mode (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags>
    /// <NuProp.Using id = "RadCommons.logging.CommonLogging" />
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class AsyncManager
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILogger Logger = CommonLogging.CreateLogger(typeof(AsyncManager));

        /// <summary>
        /// Default exception handler for <see cref="RunAsync"/>. Catches and logs all exceptions during the task execution.
        /// </summary>
        private static readonly Action<Task> DefaultExceptionHandler = task =>
        {
            try { task.Wait(); }
            catch (Exception e) { Logger.Fatal(e, $"Async call finished with expception {e}"); }
        };

        /// <summary>
        /// Runs the given <paramref name="action"/> asynchronously.
        /// </summary>
        /// <param name="action">Action to by run asynchronously</param>
        /// <param name="exceptionHandler">Exception handler. If not provided, <see cref="DefaultExceptionHandler"/> will be used</param>
        /// <returns>Async <see cref="Task"/></returns>
        public static Task RunAsync(Action action, Action<Exception> exceptionHandler = null)
        {
            if (action == null) throw Logger.Fatal<ArgumentNullException>(nameof(action));

            var task = new Task(action);

            var handler =
                exceptionHandler != null ?
                tsk => exceptionHandler(tsk.Exception?.GetBaseException()) :
                DefaultExceptionHandler;

            var continuation = task.ContinueWith(
                handler,
                TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.OnlyOnFaulted);

            task.Start();

            return continuation;
        }

        /// <summary>
        /// Executes synchronously an async <see cref="Task"/> method which has a void return value
        /// </summary>
        /// <param name="task"><see cref="Task"/> method to execute</param>
        public static void RunSync(Func<Task> task)
        {
            var oldContext = SynchronizationContext.Current;
            var synch = new ExclusiveSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(synch);
            synch.Post(async _ =>
            {
                try
                {
                    await task().ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    synch.InnerException = e;
                    throw;
                }
                finally
                {
                    synch.EndMessageLoop();
                }
            }, null);
            synch.BeginMessageLoop();

            SynchronizationContext.SetSynchronizationContext(oldContext);
        }

        /// <summary>
        /// Executes synchronously an async <see cref="Task{T}"/> method which has a <typeparamref name="T"/> return type 
        /// </summary>
        /// <typeparam name="T">Return Type</typeparam>
        /// <param name="task"><see cref="Task{T}"/> method to execute</param>
        /// <returns></returns>
        public static T RunSync<T>(Func<Task<T>> task)
        {
            var oldContext = SynchronizationContext.Current;
            var synch = new ExclusiveSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(synch);
            var ret = default(T);
            synch.Post(async _ =>
            {
                try
                {
                    ret = await task().ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    synch.InnerException = e;
                    throw;
                }
                finally
                {
                    synch.EndMessageLoop();
                }
            }, null);
            synch.BeginMessageLoop();
            SynchronizationContext.SetSynchronizationContext(oldContext);
            return ret;
        }

        /// <inheritdoc />
        /// <summary>
        /// "Private" synchronization context used to run the async method
        /// </summary>
        private class ExclusiveSynchronizationContext : SynchronizationContext
        {
            private bool done;
            public Exception InnerException { get; set; }

            private readonly AutoResetEvent workItemsWaiting = new AutoResetEvent(false);
            private readonly Queue<Tuple<SendOrPostCallback, object>> items = new Queue<Tuple<SendOrPostCallback, object>>();

            /// <inheritdoc />
            /// <summary>
            /// Dispatches a synchronous message to a synchronization context.
            /// Always throws <see cref="T:System.NotSupportedException" /> as it's not supported in <see cref="ExclusiveSynchronizationContext"/>
            /// </summary>
            /// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
            /// <param name="state">The object passed to the delegate. </param>
            /// <exception cref="T:System.NotSupportedException">The implementation of <see cref="T:System.Threading.SynchronizationContext" /> does not support the <see cref="M:System.Threading.SynchronizationContext.Send(System.Threading.SendOrPostCallback,System.Object)" /> method. </exception>
            public override void Send(SendOrPostCallback d, object state)
            {
                throw new NotSupportedException("We cannot send to our same thread");
            }

            /// <inheritdoc />
            /// <summary>Dispatches an asynchronous message to a synchronization context.</summary>
            /// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
            /// <param name="state">The object passed to the delegate.</param>
            public override void Post(SendOrPostCallback d, object state)
            {
                lock (items)
                {
                    items.Enqueue(Tuple.Create(d, state));
                }
                workItemsWaiting.Set();
            }


            /// <summary>
            /// Finish the message loop 
            /// </summary>
            public void EndMessageLoop()
            {
                Post(_ => done = true, null);
            }

            /// <summary>
            /// Starts the message loop
            /// </summary>
            public void BeginMessageLoop()
            {
                while (!done)
                {
                    Tuple<SendOrPostCallback, object> task = null;
                    lock (items)
                    {
                        if (items.Count > 0)
                        {
                            task = items.Dequeue();
                        }
                    }
                    if (task != null)
                    {
                        task.Item1(task.Item2);
                        if (InnerException != null) // the method threw an exception
                        {
                            throw new AggregateException("AsyncHelpers.Run method threw an exception.", InnerException);
                        }
                    }
                    else
                    {
                        workItemsWaiting.WaitOne();
                    }
                }
            }

            /// <inheritdoc />
            /// <summary>Creates a "copy" of the synchronization context.</summary>
            /// <returns>Current <see cref="T:System.Threading.SynchronizationContext" /> object.</returns>
            public override SynchronizationContext CreateCopy()
            {
                return this;
            }
        }
    }
}
