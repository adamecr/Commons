using System.IO;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="string"/> class extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.StringExtensions.Paths</NuProp.Id>
    /// <NuProp.Description>Path manipulation helpers for strings (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension string file-utilities</NuProp.Tags>
    internal static partial class StringExtensions
    {
        /// <summary>
        /// Adds next path segment to string representing path to the file system
        /// </summary>
        /// <param name="str">String representing path to the file system</param>
        /// <param name="nextSegment">Next path segment</param>
        /// <returns>String representing path to the file system</returns>
        public static string AddPath(this string str, string nextSegment)
        {
            return Path.Combine(str, nextSegment);
        }
    }
}
