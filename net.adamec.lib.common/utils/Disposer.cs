using System;
using System.Collections.Generic;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// Keeps the stack of disposable objects, and disposes them when the disposer is being disposed.
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.Disposer</NuProp.Id>
    /// <NuProp.Description>Keeps the stack of disposable objects, and disposes them when the disposer is being disposed. (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only disposable</NuProp.Tags>
    /// <NuProp.Using id="RadCommons.utils.BaseDisposable" />
    internal class Disposer : BaseDisposable
    {
        /// <summary>
        /// Stack of disposables kept by the <see cref="Disposer"/>.
        /// </summary>
        private Stack<IDisposable> disposables = new Stack<IDisposable>();
        /// <summary>
        /// Lock object
        /// </summary>
        private readonly object lockObj = new object();

        /// <summary>
        /// Internal implementation of dispose - free the managed and native resources.
        /// </summary>
        /// <remarks>
        /// When disposing the managed objects (<paramref name="disposing"/> is true),
        /// all disposables kept in <see cref="disposables"/> stack are pop and disposed.
        /// </remarks>
        /// <param name="disposing">True to dispose both managed and native resources, false to dispose the native resources only.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                lock (lockObj)
                {
                    while (disposables.Count > 0)
                    {
                        var item = disposables.Pop();
                        item?.Dispose();
                    }
                    disposables = null;
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Adds the <paramref name="disposable"/> object to the disposer.
        /// </summary>
        /// <param name="disposable"><see cref="IDisposable"/> object to be added to the disposer.</param>
        /// <exception cref="ArgumentNullException"><paramref name="disposable"/> is null.</exception>
        public void Add(IDisposable disposable)
        {
            if (disposable == null)
                throw new ArgumentNullException(nameof(disposable));

            lock (lockObj)
            {
                disposables.Push(disposable);
            }
        }
    }
}
