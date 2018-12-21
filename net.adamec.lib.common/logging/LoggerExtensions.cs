using System;
using System.Collections.Generic;
using System.ComponentModel;
using NLog;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// <see cref="ILogger"/> extensions
    /// </summary>
    internal static class LoggerExtensions
    {
        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public static void Debug(this ILogger logger, string correlationId, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Debug, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public static void Info(this ILogger logger, string correlationId, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Info, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public static void Warn(this ILogger logger, string correlationId, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Warn, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public static void Error(this ILogger logger, string correlationId, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Error, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        public static void Fatal(this ILogger logger, string correlationId, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Fatal, correlationId, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static void Warn(this ILogger logger, string correlationId, Exception exception, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Warn, correlationId, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static void Error(this ILogger logger, string correlationId, Exception exception, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Error, correlationId, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static void Fatal(this ILogger logger, string correlationId, Exception exception, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Fatal, correlationId, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static TException Fatal<TException>(this ILogger logger, string message, Exception innerException = null) where TException : Exception
        {
            return Fatal<TException>(logger, null, message, innerException);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static TException Fatal<TException>(this ILogger logger, string correlationId, string message, Exception innerException = null) where TException : Exception
        {
            var exception = (TException)Activator.CreateInstance(typeof(TException), message, innerException);
            LogIt(logger, LogLevel.Fatal, correlationId, message, innerException);
            return exception;
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static TException Error<TException>(this ILogger logger, string message, Exception innerException = null) where TException : Exception
        {
            return Error<TException>(logger, null, message, innerException);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static TException Error<TException>(this ILogger logger, string correlationId, string message, Exception innerException = null) where TException : Exception
        {
            var exception = (TException)Activator.CreateInstance(typeof(TException), message, innerException);
            LogIt(logger, LogLevel.Error, correlationId, message, innerException);
            return exception;
        }
        //---------------------------------------------
        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public static void Debug(this ILogger logger, Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Debug, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public static void Info(this ILogger logger, Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Info, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public static void Warn(this ILogger logger, Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Warn, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public static void Error(this ILogger logger, Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Error, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        public static void Fatal(this ILogger logger, Dictionary<string, object> eventProperties, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Fatal, eventProperties, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static void Warn(this ILogger logger, Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Warn, eventProperties, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static void Error(this ILogger logger, Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Error, eventProperties, message, exception);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        public static void Fatal(this ILogger logger, Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message)
        {
            LogIt(logger, LogLevel.Fatal, eventProperties, message, exception);
        }
        
        /// <summary>
        ///  Writes the item (message with optional exception)  into the log
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="level"></param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        private static void LogIt(ILogger logger, LogLevel level, string correlationId, [Localizable(false)] string message, Exception exception = null)
        {
            LogIt(logger, level, new Dictionary<string, object>() { { "CorrelationId", correlationId } }, message, exception);
        }

        /// <summary>
        ///  Writes the item (message with optional event properties and exception)  into the log
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="level"></param>
        /// <param name="eventProperties">Event properties (null when no properties are provided)</param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        private static void LogIt(ILogger logger, LogLevel level, Dictionary<string, object> eventProperties, [Localizable(false)] string message, Exception exception = null)
        {
            var logEvent = new LogEventInfo(level, logger.Name, message) { Exception = exception };
            if (eventProperties != null)
            {
                foreach (var eventProperty in eventProperties)
                {
                    logEvent.Properties.Add(eventProperty.Key, eventProperty.Value);
                }
            }
            logger.Log(logEvent);
        }
    }
}
