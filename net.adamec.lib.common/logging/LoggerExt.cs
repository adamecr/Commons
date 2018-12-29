using System;
using System.Collections.Generic;
using System.ComponentModel;
using NLog;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// <see cref="ILogger"/> extensions
    /// </summary>
    internal class LoggerExt : Logger, ILogger
    {
        #region Log with Event properties
        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public void Trace(Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Trace, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public void Debug(Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Debug, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public void Info(Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Info, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public void Warn(Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Warn, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public void Error(Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Error, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public void Fatal(Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Fatal, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public void Warn(Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Warn, eventProperties, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public void Error(Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Error, eventProperties, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public void Fatal(Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message)
        {
            LogIt(LogLevel.Fatal, eventProperties, message, exception);
        }

        #endregion

        #region Log with Exception pass-through
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
            var exception = CreateException<TException>(message, innerException);
            LogIt(LogLevel.Error, message, exception);
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
            var exception = CreateException<TException>(message, innerException);
            LogIt(LogLevel.Fatal, message, exception);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <returns>Created exception</returns>
        private static TException CreateException<TException>(string message, Exception innerException = null)
            where TException : Exception
        {
            var exception = (TException)Activator.CreateInstance(typeof(TException), message, innerException);
            return exception;
        }
        #endregion

        #region Log in Exception filter

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <remarks>
        /// This function is intended for catch exception filters.
        /// The parameter <paramref name="catchIt"/> defines whether the exception filter will be applied after logging.
        /// The exception will be catch when <paramref name="catchIt"/> is true, otherwise the filter is evaluated as false
        /// and it will continue with finding the catch clause (in both cases the log entry will be created)
        /// </remarks>
        /// <example>
        /// The following code logs any exception without catching it (function returns false by default)
        /// <code>
        /// try
        /// {
        ///   ...
        /// }
        /// catch (Exception e) when (Logger.FatalFltr(e)) {}
        /// </code>
        /// The following code catch and log the ArgumentException and logs any other exception without catching it.
        /// <code>
        /// try
        /// {
        ///   ...
        /// }
        /// catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) {}
        /// catch (Exception e) when (Logger.FatalFltr(e)) {}
        /// </code>
        /// </example>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <param name="catchIt">Flag whether the <paramref name="exception"/> is to be catch by filter (default is false)</param>
        /// <returns>Flag whether the exception is to be catch by exception filter</returns>
        public bool ErrorFltr<TException>(TException exception, string message = null, bool catchIt = false) where TException : Exception
        {
            Error(exception, message);
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
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <param name="catchIt">Flag whether the <paramref name="exception"/> is to be catch by filter (default is false)</param>
        /// <seealso cref="ErrorFltr{TException}"/>
        /// <returns>Flag whether the exception is to be catch by exception filter</returns>
        public bool FatalFltr<TException>(TException exception, string message = null, bool catchIt = false) where TException : Exception
        {
            Fatal(exception, message);
            return catchIt;
        }
        #endregion

        #region Log with CorrelationId

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
            base.Debug("a", "a");
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
            LogIt(LogLevel.Error, string.IsNullOrWhiteSpace(message) ? exception.Message : message, exception);
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
            LogIt(LogLevel.Fatal, string.IsNullOrWhiteSpace(message) ? exception.Message : message, exception);
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
            var exception = CreateException<TException>(message, innerException);
            LogIt(LogLevel.Error, correlationId, message, exception);
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
            var exception = CreateException<TException>(message, innerException);
            LogIt(LogLevel.Fatal, correlationId, message, exception);
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

        #endregion

        #region Private LogIt

        /// <summary>
        ///  Writes the item (message with optional exception)  into the log
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        private void LogIt(LogLevel level, [Localizable(false)] string message, Exception exception = null)
        {
            LogIt(level, (Dictionary<string, object>)null, message, exception);
        }

        /// <summary>
        ///  Writes the item (message with optional exception) with correlation Id into the log
        /// </summary>
        /// <param name="level"></param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        private void LogIt(LogLevel level, string correlationId, [Localizable(false)] string message, Exception exception = null)
        {
            LogIt(level, new Dictionary<string, object> { { "CorrelationId", correlationId } }, message, exception);
        }

        /// <summary>
        ///  Writes the item (message with optional event properties and exception)  into the log
        /// </summary>
        /// <param name="level"></param>
        /// <param name="eventProperties">Event properties (null when no properties are provided)</param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        private void LogIt(LogLevel level, Dictionary<string, object> eventProperties, [Localizable(false)] string message, Exception exception = null)
        {
            var logEvent = new LogEventInfo(level, Name, message) { Exception = exception };
            if (eventProperties != null)
            {
                foreach (var eventProperty in eventProperties)
                {
                    logEvent.Properties.Add(eventProperty.Key, eventProperty.Value);
                }
            }
            Log(logEvent);
        }

        #endregion
    }
}
