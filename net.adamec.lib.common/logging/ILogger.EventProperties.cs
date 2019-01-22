using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Logger interface - wrapper around the <see cref="NLog.ILogger"/> with some additional methods
    /// </summary>
    internal partial interface ILogger
    {
        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        void Trace(Dictionary<string, object> eventProperties, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        void Debug(Dictionary<string, object> eventProperties, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        void Info(Dictionary<string, object> eventProperties, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        void Warn(Dictionary<string, object> eventProperties, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        void Error(Dictionary<string, object> eventProperties, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="message">Log message.</param>
        void Fatal(Dictionary<string, object> eventProperties, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        void Warn(Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        void Error(Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="eventProperties">Event properties</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        void Fatal(Dictionary<string, object> eventProperties, Exception exception, [Localizable(false)] string message);
    }
}
