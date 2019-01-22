using System;

namespace net.adamec.lib.common.extensions
{

    /// <summary>
    /// Array extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.ArrayExtensions.ConcatenateBytes</NuProp.Id>
    /// <NuProp.Description>Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one) (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension array</NuProp.Tags>
    internal static partial class ArrayExtensions
    {
        /// <summary>
        /// Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one)
        /// </summary>
        /// <param name="original">Original byte array</param>
        /// <param name="addedBytes">Bytes to add</param>
        /// <returns>New concatenated byte array (<paramref name="original"/> + <paramref name="addedBytes"/>)</returns>
        public static byte[] AppendBytes(this byte[] original, byte[] addedBytes)
        {
            if(original is null) throw new ArgumentNullException(nameof(original));

            if (addedBytes is null || addedBytes.Length == 0) return original;

            var retVal = new byte[original.Length + addedBytes.Length];
            Buffer.BlockCopy(original, 0, retVal, 0, original.Length);
            Buffer.BlockCopy(addedBytes, 0, retVal, original.Length, addedBytes.Length);
            return retVal;
        }

    }
}
