using System;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Extended logger implementing <see cref="ILogger"/>
    /// </summary>
    internal partial class LoggerExt
    {
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
    }
}
