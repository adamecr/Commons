using System;

namespace net.adamec.lib.common.core.logging
{
    /// <summary>
    /// Logger interface - wrapper around the <see cref="NLog.ILogger"/> with some additional methods
    /// </summary>
    public partial interface ILogger
    {
        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level and returns given <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        Exception ErrorPassThrough(Exception exception, string message = null);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level and returns given <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        Exception FatalPassThrough(Exception exception, string message = null);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        TException Error<TException>(string message, Exception innerException = null) where TException : Exception;

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        TException Fatal<TException>(string message, Exception innerException = null) where TException : Exception;
    }
}
