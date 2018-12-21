using System;
using System.Threading;
using System.Threading.Tasks;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// Helper class allowing to execute periodic (or one time) scheduled action
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.PeriodicTask</NuProp.Id>
    /// <NuProp.Description>Periodic (or scheduled) async task runner (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class PeriodicTask
    {
        /// <summary>
        ///  Schedule and run the periodic <paramref name="action"/>
        /// </summary>
        /// <remarks>
        /// The <paramref name="cancellationToken"/> interrupts the period/waiting loop, but not the action itself.
        /// The method doesn't create any additional thread or worker, it's the responsibility of the caller is needed.</remarks>
        /// <param name="action">Action to be executed</param>
        /// <param name="period">Period between the individual runs (and even before the first run)</param>
        /// <param name="cancellationToken">Cancellation token used to cancel the (periodic) task execution.</param>
        /// <param name="oneTimeOnly">Flag whether the action should run one time only (after the given <paramref name="period"/>)</param>
        /// <returns>Async task</returns>
        public static async Task RunAsync(Action action, TimeSpan period, CancellationToken cancellationToken,bool oneTimeOnly=false)
        {
            var finished = false;
            while (!cancellationToken.IsCancellationRequested && !finished)
            {
                await Task.Delay(period, cancellationToken);

                if (!cancellationToken.IsCancellationRequested)
                    action();

                finished = oneTimeOnly;
            }
        }

        /// <summary>
        /// Schedule and run the periodic <paramref name="action"/>
        /// </summary>
        /// <param name="action">Action to be executed</param>
        /// <param name="period">Period between the individual runs (and even before the first run)</param>
        /// <param name="oneTimeOnly"></param>
        /// <returns></returns>
        public static Task RunAsync(Action action, TimeSpan period, bool oneTimeOnly = false)
        {
            return RunAsync(action, period, CancellationToken.None,oneTimeOnly);
        }
    }
}
