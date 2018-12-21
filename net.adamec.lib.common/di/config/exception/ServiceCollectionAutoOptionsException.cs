using System;

namespace net.adamec.lib.common.di.config.exception
{
    /// <inheritdoc />
    /// <summary>
    /// Exception thrown by <see cref="T:net.adamec.home.control.common.config.exception.ServiceCollectionAutoOptionsExtension" />
    /// </summary>
    public class ServiceCollectionAutoOptionsException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.di.config.exception.ServiceCollectionAutoOptionsException" />
        /// </summary>
        public ServiceCollectionAutoOptionsException() { }
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.di.config.exception.ServiceCollectionAutoOptionsException" />
        /// </summary>
        /// <param name="message">Error message</param>
        public ServiceCollectionAutoOptionsException(string message) : base(message) { }
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.di.config.exception.ServiceCollectionAutoOptionsException" />
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="inner">Inner exception</param>
        public ServiceCollectionAutoOptionsException(string message, Exception inner) : base(message, inner) { }
    }
}
