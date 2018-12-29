using System.Net;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="string"/> class extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.StringExtensions.Html</NuProp.Id>
    /// <NuProp.Description>HTML related string manipulation helpers (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension string html</NuProp.Tags>
    internal static partial class StringExtensions
    {
        /// <summary>
        /// HTML encodes the string
        /// </summary>
        /// <param name="str">String to encode</param>
        /// <returns>HTML encoded string</returns>
        public static string HtmlEncode(this string str)
        {
            return str == null ? null : WebUtility.HtmlEncode(str);
        }

        /// <summary>
        /// HTML decodes the string
        /// </summary>
        /// <param name="str">String to decode</param>
        /// <returns>HTML decoded string</returns>
        public static string HtmlDecode(this string str)
        {
            return str == null ? null : WebUtility.HtmlDecode(str);
        }
    }
}
