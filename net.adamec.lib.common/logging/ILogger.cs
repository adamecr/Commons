﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Logger interface - wrapper around the <see cref="NLog.ILogger"/> with some additional methods
    /// </summary>
    internal interface ILogger : NLog.ILogger
    {
        #region Log with Event properties
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


        #endregion

        #region Log with Exception pass-through

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
        Exception FatalPassThrough(Exception exception, string message = null) ;

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
        bool ErrorFltr<TException>(TException exception, string message = null, bool catchIt = false) where TException : Exception;

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
        bool FatalFltr<TException>(TException exception, string message = null, bool catchIt = false) where TException : Exception;

        #endregion

        #region Log with CorrelationId

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        void TraceCorr(string correlationId, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        void DebugCorr(string correlationId, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        void InfoCorr(string correlationId, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        void WarnCorr(string correlationId, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        void ErrorCorr(string correlationId, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="message">Log message.</param>
        void FatalCorr(string correlationId, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        void WarnCorr(string correlationId, Exception exception, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        void ErrorCorr(string correlationId, Exception exception, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level with correlation ID.
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        void FatalCorr(string correlationId, Exception exception, [Localizable(false)] string message);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        TException ErrorCorr<TException>(string correlationId, TException exception, string message = null) where TException : Exception;

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="exception">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Pass-through exception</returns>
        TException FatalCorr<TException>(string correlationId, TException exception, string message = null) where TException : Exception;

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level with correlation ID. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        TException ErrorCorr<TException>(string correlationId, string message, Exception innerException = null) where TException : Exception;

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level with correlation ID. Creates and returns the exception of <typeparamref name="TException">given type</typeparamref>
        /// </summary>
        /// <param name="correlationId">Correlation ID</param>
        /// <param name="innerException">Exception to be logged</param>
        /// <param name="message">Log message.</param>
        /// <returns>Created exception</returns>
        TException FatalCorr<TException>(string correlationId, string message, Exception innerException = null) where TException : Exception;

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
        bool ErrorFltrCorr<TException>(string correlationId, TException exception, string message = null, bool catchIt = false) where TException : Exception;

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
        bool FatalFltrCorr<TException>(string correlationId, TException exception, string message = null, bool catchIt = false) where TException : Exception;


        #endregion
    }
}
