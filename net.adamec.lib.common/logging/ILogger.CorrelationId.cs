using System;
using System.ComponentModel;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Logger interface - wrapper around the <see cref="NLog.ILogger"/> with some additional methods
    /// </summary>
    internal partial interface ILogger 
    {
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
    }
}
