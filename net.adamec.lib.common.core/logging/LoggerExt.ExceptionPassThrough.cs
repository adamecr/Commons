using System;
using NLog;

namespace net.adamec.lib.common.core.logging
{
    /// <summary>
    /// Extended logger implementing <see cref="ILogger"/>
    /// </summary>
    public partial class LoggerExt
    {
        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level and returns given <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        public Exception ErrorPassThrough(Exception exception, string message = null)
        {
            LogIt(LogLevel.Error, string.IsNullOrWhiteSpace(message) ? exception.Message : message, exception);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level and returns given <paramref name="exception"/>>
        /// </summary>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        public Exception FatalPassThrough(Exception exception, string message = null)
        {
            LogIt(LogLevel.Fatal, string.IsNullOrWhiteSpace(message) ? exception.Message : message, exception);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        public TException Error<TException>(string message, Exception innerException = null) where TException : Exception
        {
            var exception = CreateException<TException>(message, out var stackTrace, innerException);
            LogIt(LogLevel.Error, message, exception, stackTrace);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        public TException Fatal<TException>(string message, Exception innerException = null) where TException : Exception
        {
            var exception = CreateException<TException>(message, out var stackTrace, innerException);
            LogIt(LogLevel.Fatal, message, exception, stackTrace);
            return exception;
        }
    }
}
