using System;

namespace net.adamec.lib.common.di.config.exception
{
    /// <inheritdoc />
    /// <summary>
    /// Exception thrown by <see cref="T:net.adamec.home.control.common.config.exception.ServiceCollectionConfigureDirectExtensions" />
    /// </summary>
    public class ServiceCollectionConfigureDirectException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.di.config.exception.ServiceCollectionConfigureDirectException" />
        /// </summary>
        public ServiceCollectionConfigureDirectException() { }
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.di.config.exception.ServiceCollectionConfigureDirectException" />
        /// </summary>
        /// <param name="message">Error message</param>
        public ServiceCollectionConfigureDirectException(string message) : base(message) { }
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.di.config.exception.ServiceCollectionConfigureDirectException" />
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="inner">Inner exception</param>
        public ServiceCollectionConfigureDirectException(string message, Exception inner) : base(message, inner) { }
    }
}
