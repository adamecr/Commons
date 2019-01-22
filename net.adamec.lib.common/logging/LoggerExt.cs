using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using NLog;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Extended logger implementing <see cref="ILogger"/>
    /// </summary>
    internal partial class LoggerExt : Logger, ILogger
    {
        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="stackTrace">Stack trace to be logged in <c>StackTrace</c> event property</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <returns>Created exception</returns>
        private static TException CreateException<TException>(string message, out string stackTrace, Exception innerException = null)
            where TException : Exception
        {
            var exception = (TException)Activator.CreateInstance(typeof(TException), message, innerException);
            stackTrace = new StackTrace(2, true).ToString(); //skip 2 - CreateException+Logger method
            return exception;
        }

        #region Private LogIt

        /// <summary>
        ///  Writes the item (message with optional exception)  into the log
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        /// <param name="stackTrace">Optional stack trace to be logged in <c>StackTrace</c> event property when the <see cref="Exception.StackTrace"/> of <paramref name="exception"/> is empty</param>
        private void LogIt(LogLevel level, [Localizable(false)] string message, Exception exception = null, string stackTrace = null)
        {
            LogIt(level, (Dictionary<string, object>)null, message, exception, stackTrace);
        }

        
        /// <summary>
        ///  Writes the item (message with optional event properties and exception)  into the log
        /// </summary>
        /// <param name="level"></param>
        /// <param name="eventProperties">Event properties (null when no properties are provided)</param>
        /// <param name="message">Log message</param>
        /// <param name="exception">Optional exception to be logged</param>
        /// <param name="stackTrace">Optional stack trace to be logged in <c>StackTrace</c> event property when the <see cref="Exception.StackTrace"/> of <paramref name="exception"/> is empty</param>
        private void LogIt(LogLevel level, Dictionary<string, object> eventProperties, [Localizable(false)] string message, Exception exception = null, string stackTrace = null)
        {
            var logEvent = new LogEventInfo(level, Name, message) { Exception = exception };
            if (exception != null)
            {
                if (!string.IsNullOrWhiteSpace(exception.StackTrace)) stackTrace = exception.StackTrace;
                //fall back - not sure how many frames to skip here for different calls, so the full stack trace will be used
                if (string.IsNullOrWhiteSpace(stackTrace)) stackTrace = new StackTrace(true).ToString();
                logEvent.Properties.Add("StackTrace", stackTrace);
            }
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
