using System.ComponentModel;
using System.Threading;

namespace net.adamec.lib.common.utils
{
    /// <inheritdoc />
    /// <summary>
    /// Executes an operation on a separate thread with possibility of sync cancel.
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.BackgroundWorkerWithSyncCancel</NuProp.Id>
    /// <NuProp.Description>Executes an operation on a separate thread with possibility of sync cancel (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags>
    public class BackgroundWorkerWithSyncCancel : BackgroundWorker
    {
        /// <summary>
        /// Reset event used to ensure that the work is finished
        /// </summary>
        private readonly AutoResetEvent resetEvent = new AutoResetEvent(false);
        /// <summary>
        /// Lock object
        /// </summary>
        private readonly object lockObject = new object();
        /// <summary>
        /// Internal flag whether the worker is running its DoWork action
        /// </summary>
        private bool isRunningInternal;
        /// <summary>
        /// Backing field for <see cref="IsCancelling"/>
        /// </summary>
        private bool isCancelling;
        /// <summary>
        /// Flag whether the worker is cancelling
        /// </summary>
        public bool IsCancelling
        {
            get
            {
                lock (lockObject)
                {
                    return isCancelling;
                }
            }
        }

        /// <summary>
        /// Requests cancellation of a pending background operation and wait for cancel to complete
        /// </summary>
        public void Cancel()
        {
            var doCancel = false;
            lock (lockObject)
            {
                if (isRunningInternal && !isCancelling)
                {
                    isCancelling = true;
                    doCancel = true;
                }
            }
            if (!doCancel) return;

            CancelAsync();
            resetEvent.WaitOne(); //wait for DoWork to finish (sets the resetEvent)
            lock (lockObject)
            {
                isCancelling = false;
                isRunningInternal = false;
            }
        }

        /// <inheritdoc />
        /// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event. </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnDoWork(DoWorkEventArgs e)
        {
            lock (lockObject)
            {
                isCancelling = false;
                isRunningInternal = true;
                resetEvent.Reset();
            }
            try
            {
                base.OnDoWork(e);
            }
            finally
            {
                lock (lockObject)
                {
                    isRunningInternal = false;
                    resetEvent.Set(); //ensure the set is called whatever happens in DoWork handler
                }
            }
        }
    }

}
