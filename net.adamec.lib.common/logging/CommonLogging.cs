using System;
using NLog;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// <see cref="ILogger"/> factory
    /// </summary>
    internal static class CommonLogging
    {
        /// <summary>
        /// Creates the logger with given <paramref name="categoryName"/>
        /// </summary>
        /// <param name="categoryName">Name of the logger</param>
        /// <returns>Logger instance</returns>
        public static ILogger CreateLogger(string categoryName)
        {
            return LogManager.LogFactory.GetLogger<LoggerExt>(categoryName);
        }

        /// <summary>
        /// Creates the logger for given type. The name of the logger will be <see cref="Type.FullName"/>
        /// </summary>
        /// <param name="type">Type to create the logger for</param>
        /// <returns>Logger instance</returns>
        public static ILogger CreateLogger(Type type)
        {
            return CreateLogger(type.FullName);
        }

        /// <summary>
        /// Creates the logger for given type. The name of the logger will be <see cref="Type.FullName"/>
        /// </summary>
        /// <typeparam name="T">Type to create the logger for</typeparam>
        /// <returns>Logger instance</returns>
        public static ILogger CreateLogger<T>()
        {
            // ReSharper disable once SuspiciousTypeConversion.Global
            return CreateLogger(typeof(T).FullName);
        }
    }
}
