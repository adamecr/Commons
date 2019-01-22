using System;
using System.Collections.Generic;
using System.ComponentModel;
using NLog;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Extended logger implementing <see cref="ILogger"/>
    /// </summary>
    internal partial class LoggerExt
    {
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
    }
}
