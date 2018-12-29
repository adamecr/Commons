using System;
using System.Diagnostics;

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
        /// Flag whether the object is fully disposed
        /// </summary>
        public bool Disposed { get; private set; }
        /// <summary>
        /// Flag whether the managed resources are disposed
        /// </summary>
        public bool DisposedManaged { get; private set; }
        /// <summary>
        /// Flag whether the native resources are disposed
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
        /// <param name="disposing">Flag whether the object is disposing (called from <see cref="Dispose"/> method). False if called from destructor</param>
        protected virtual void Dispose(bool disposing)
        {
            if (Disposed)
            {
                return;
            }

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

            Disposed = true;
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
    }
}
