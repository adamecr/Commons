using System.Linq;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="string"/> class extensions
    /// </summary>
    ///<NuProp.Id>RadCommons.extensions.StringExtensions.Whitespace</NuProp.Id>
    ///<NuProp.Description>Whitespace manipulation helpers for strings (Source only package).</NuProp.Description>
    ///<NuProp.Tags>RadCommons</NuProp.Tags>
    internal static partial class StringExtensions
    {
        /// <summary>
        /// "Full" trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break)
        /// </summary>
        /// <param name="str">String to full trim</param>
        /// <returns>"Fully" trimmed string</returns>
        public static string TrimAndMergeLines(this string str)
        {
            if (str == null) return null;
            str = str.Replace("\r\n", "\r").Replace("\n", "\r");
            var lines = str.Split('\r');
            str = string.Join(" ", lines.Select(l => l.Trim())).Trim();
            return str;
        }
    }
}
