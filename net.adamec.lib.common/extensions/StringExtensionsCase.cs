using System.Globalization;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="string"/> class extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.StringExtensions.Case</NuProp.Id>
    /// <NuProp.Description>String case manipulation helpers (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension string camel-case case</NuProp.Tags>
    internal static partial class StringExtensions
    {
        /// <summary>
        /// Simple CamelCase converter
        /// </summary>
        /// <param name="str">String to convert to Camel Case</param>
        /// <returns>Camel Case converted <paramref name="str">string</paramref></returns>
        public static string ToCamelCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;

            var txtInfo = new CultureInfo("en-us", false).TextInfo;
            str = txtInfo.ToLower(str);
            str = txtInfo.ToTitleCase(str);
            str = str.Replace(" ", string.Empty);
            str = str.Replace("_", string.Empty);
            str = char.ToLowerInvariant(str[0]) + str.Length>1?str.Substring(1):string.Empty;
            return str;
        }

        /// <summary>
        /// Converts the first letter of string to upper case
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <returns>String with the first letter in upper case</returns>
        public static string FirstLetterToUpper(this string str)
        {
            if (str == null) return null;
            return str.Length > 1 ? char.ToUpper(str[0]) + str.Substring(1) : str.ToUpper();
        }
    }
}
