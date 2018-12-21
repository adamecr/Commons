using System;
using System.IO;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// Console output helpers
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.ConsoleUtils</NuProp.Id>
    /// <NuProp.Description>Console output utilities (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ConsoleUtils
    {
        /// <summary>
        /// Warning text color (yellow)
        /// </summary>
        public static ConsoleColor ColorWarn = ConsoleColor.Yellow;
        /// <summary>
        /// Error text color (red)
        /// </summary>
        public static ConsoleColor ColorErr = ConsoleColor.Red;

        /// <summary>
        /// Writes a <paramref name="line"/> to (console's) <paramref name="writer"/> with given text <paramref name="color"/>
        /// </summary>
        /// <param name="writer">Console's writer (standard or error output)</param>
        /// <param name="line">Line to write to console</param>
        /// <param name="color">Text color to use</param>
        private static void WriteLine(TextWriter writer, string line, ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            writer.WriteLine(line);
            Console.ForegroundColor = currentColor;
        }

        /// <summary>
        /// Writes colored <paramref name="line"/> to console standard output
        /// </summary>
        /// <param name="line">Line to write to console</param>
        /// <param name="color">Text color to use</param>
        public static void WriteLine(string line, ConsoleColor color)
        {
            WriteLine(Console.Out, line, color);
        }

        /// <summary>
        /// Writes warning <paramref name="line"/> to console standard output
        /// </summary>
        /// <param name="line">Line to write to console</param>
        public static void WriteWarn(string line)
        {
            WriteLine(line, ColorWarn);
        }

        /// <summary>
        /// Writes error <paramref name="line"/> to console error output
        /// </summary>
        /// <param name="line">Line to write to console</param>
        public static void WriteErr(string line)
        {
            WriteLine(Console.Error, line, ColorErr);
        }

        /// <summary>
        /// Writes warning <paramref name="line"/> to console error output
        /// </summary>
        /// <param name="line">Line to write to console</param>
        public static void WriteErrWarn(string line)
        {
            WriteLine(Console.Error, line, ColorWarn);
        }

        /// <summary>
        /// Writes info <paramref name="line"/> to console standard output
        /// </summary>
        /// <param name="line">Line to write to console</param>
        public static void WriteInfo(string line)
        {
            Console.WriteLine(line);
        }
    }
}
