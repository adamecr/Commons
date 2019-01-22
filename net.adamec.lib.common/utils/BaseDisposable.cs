using System;
using System.Diagnostics;
using System.Threading;

namespace net.adamec.lib.common.utils
{
    /// <inheritdoc />
    /// <summary>
    /// Helper class for implementation of <see cref="T:System.IDisposable" /> types
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.BaseDisposable</NuProp.Id>
    /// <NuProp.Description>Helper class for implementation of IDisposable types (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only disposable</NuProp.Tags>
    public abstract class BaseDisposable : IDisposable
    {
        /// <summary>
        /// Internal flag whether the object is fully disposed
        /// </summary>
        private const int DisposedFlag = 1;
        /// <summary>
        /// The object is disposed when equals to <see cref="DisposedFlag"/>
        /// </summary>
        private int isDisposed;

        /// <summary>
        /// Returns <code>true</code> when the object is fully disposed
        /// </summary>
        public bool Disposed
        {
            get
            {
                Interlocked.MemoryBarrier();
                return isDisposed == DisposedFlag;
            }
        }

        /// <summary>
        /// Returns <code>true</code> when the managed resources are disposed
        /// </summary>
        public bool DisposedManaged { get; private set; }
        /// <summary>
        /// Returns <code>true</code> when the native resources are disposed
        /// </summary>
        public bool DisposedNative { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Dispose the object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Internal implementation of dispose - free the managed and native resources using the respective methods
        /// </summary>
        /// <param name="disposing">True to dispose both managed and native resources, false to dispose the native resources only</param>
        protected virtual void Dispose(bool disposing)
        {
            if (Disposed) return; //already disposed

            if (disposing)
            {
                // Free any other managed objects here
                if (!DisposedManaged)
                {
                    try
                    {
                        DisposeManaged();
                    }
#pragma warning disable 168
                    catch (Exception exception)
#pragma warning restore 168
                    {
                        if (Debugger.IsAttached) Debugger.Break();
                    }
                    finally
                    {
                        DisposedManaged = true;
                    }
                }
            }
            // Free any unmanaged objects here.
            if (!DisposedNative)
            {
                try
                {
                    DisposeNative();
                }
#pragma warning disable 168
                catch (Exception exception)
#pragma warning restore 168
                {
                    if (Debugger.IsAttached) Debugger.Break();
                }
                finally
                {
                    DisposedNative = true;
                }
            }

            Interlocked.Exchange(ref isDisposed, DisposedFlag);
        }

        /// <summary>
        /// Dispose any disposable managed fields or properties.
        /// </summary>
        protected virtual void DisposeManaged() { }

        /// <summary>
        /// Dispose of COM objects, Handles, etc. Then set those objects to null.
        /// </summary>
        protected virtual void DisposeNative() { }

        ~BaseDisposable() => Dispose(false);

        /// <summary>
        ///  Throws an <see cref="ObjectDisposedException"/> when the current object is disposed
        /// </summary>
        /// <param name="message">Optional exception message</param>
        /// <exception cref="ObjectDisposedException">Current object is disposed</exception>
        protected void AssertNotDisposed(string message = null)
        {
            if (Disposed)
                throw new ObjectDisposedException(!string.IsNullOrWhiteSpace(message) ? message : "Object is disposed");
        }
    }
}
