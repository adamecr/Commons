using System;
using System.Collections.Generic;
using System.ComponentModel;
using NLog;

namespace net.adamec.lib.common.core.logging
{
    /// <summary>
    /// Extended logger implementing <see cref="ILogger"/>
    /// </summary>
    public partial class LoggerExt
    {
        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level with correlation ID
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public void TraceCorr(string correlationId, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Trace, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public void DebugCorr(string correlationId, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Debug, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public void InfoCorr(string correlationId, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Info, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public void WarnCorr(string correlationId, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Warn, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public void ErrorCorr(string correlationId, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Error, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public void FatalCorr(string correlationId, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Fatal, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public void WarnCorr(string correlationId, Exception exception, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Warn, correlationId, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public void ErrorCorr(string correlationId, Exception exception, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Error, correlationId, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public void FatalCorr(string correlationId, Exception exception, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Fatal, correlationId, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        public TException ErrorCorr<TException>(string correlationId, TException exception, string message = null) where TException : Exception
        {
            LogIt(LogLevel.Error, correlationId, string.IsNullOrWhiteSpace(message) ? exception.Message : message, exception);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        public TException FatalCorr<TException>(string correlationId, TException exception, string message = null) where TException : Exception
        {
            LogIt(LogLevel.Fatal, correlationId, string.IsNullOrWhiteSpace(message) ? exception.Message : message, exception);
            return exception;
        }


        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level with correlation ID. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        public TException ErrorCorr<TException>(string correlationId, string message, Exception innerException = null) where TException : Exception
        {
            var exception = CreateException<TException>(message, out var stackTrace, innerException);
            LogIt(LogLevel.Error, correlationId, message, exception, stackTrace);
            return exception;
        }


        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level with correlation ID. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        public TException FatalCorr<TException>(string correlationId, string message, Exception innerException = null) where TException : Exception
        {
            var exception = CreateException<TException>(message, out var stackTrace, innerException);
            LogIt(LogLevel.Fatal, correlationId, message, exception, stackTrace);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <remarks>
        /// This function is intended for catch exception filters.
        /// The parameter <paramref name="catchIt"/> defines whether the exception filter will be applied after logging.
        /// The exception will be catch when <paramref name="catchIt"/> is true, otherwise the filter is evaluated as false
        /// and it will continue with finding the catch clause (in both cases the log entry will be created)
        /// </remarks>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <param name="catchIt">Flag whether the <paramref name="exception"/> is to be catch by filter (default is false)</param>
        /// <seealso cref="ErrorFltr{TException}"/>
        /// <returns>Flag whether the exception is to be catch by exception filter</returns>
        public bool ErrorFltrCorr<TException>(string correlationId, TException exception, string message = null, bool catchIt = false) where TException : Exception
        {
            ErrorCorr(correlationId, exception, message);
            return catchIt;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level and returns <paramref name="catchIt"/> value.
        /// </summary>
        /// <remarks>
        /// This function is intended for catch exception filters.
        /// The parameter <paramref name="catchIt"/> defines whether the exception filter will be applied after logging.
        /// The exception will be catch when <paramref name="catchIt"/> is true, otherwise the filter is evaluated as false
        /// and it will continue with finding the catch clause (in both cases the log entry will be created)
        /// </remarks>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <param name="catchIt">Flag whether the <paramref name="exception"/> is to be catch by filter (default is false)</param>
        /// <seealso cref="ErrorFltr{TException}"/>
        /// <returns>Flag whether the exception is to be catch by exception filter</returns>
        public bool FatalFltrCorr<TException>(string correlationId, TException exception, string message = null, bool catchIt = false) where TException : Exception
        {
            FatalCorr(correlationId, exception, message);
            return catchIt;
        }

        /// <summary>
        ///  Writes the item (message with optional exception) with correlation Id into the log
        /// </summary>
        /// <param name="level"></param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        /// <param name="stackTrace">Optional stack trace to be logged in <c>StackTrace</c> event property when the <see cref="Exception.StackTrace"/> of <paramref name="exception"/> is empty</param>
        private void LogIt(LogLevel level, string correlationId, [Localizable(false)] string message, Exception exception = null, string stackTrace = null)
        {
            LogIt(level, new Dictionary<string, object> { { "CorrelationId", correlationId } }, message, exception, stackTrace);
        }
    }
}
