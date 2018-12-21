using System;
using System.Runtime.InteropServices;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// Marshaling helper methods
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.MarshalExt</NuProp.Id>
    /// <NuProp.Description>Marshaling helpers (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class MarshalExt
    {
        /// <summary>
        /// Get's the structure data byte array
        /// </summary>
        /// <param name="sourceStructure">Source structure</param>
        /// <returns>Structure data as byte array</returns>
        public static byte[] GetStructureAsData(object sourceStructure)
        {
            if (sourceStructure == null) return null;

            var retVal = new byte[Marshal.SizeOf(sourceStructure)];

            var ptrS2A = IntPtr.Zero;
            try
            {
                ptrS2A = Marshal.AllocHGlobal(Marshal.SizeOf(sourceStructure));
                Marshal.StructureToPtr(sourceStructure, ptrS2A, false);
                Marshal.Copy(ptrS2A, retVal, 0, retVal.Length);
            }
            finally
            {
                if (ptrS2A != IntPtr.Zero) Marshal.FreeHGlobal(ptrS2A);
            }
            return retVal;
        }

        /// <summary>
        /// Converts the byte array <paramref name="data"/> into the structure of given <paramref name="structureType"/>
        /// </summary>
        /// <param name="structureType"></param>
        /// <param name="data"></param>
        /// <returns>The structure build from the <paramref name="data"/> or null when the conversion was not successful.</returns>
        public static object GetDataAsStructure(Type structureType, byte[] data)
        {
            if (data == null) return null;

            var sizeStructure = Marshal.SizeOf(structureType);
            var sizeData = data.Length;
            if (sizeData != sizeStructure) return null; //TODO Exception

            object retVal;
            var ptrA2S = IntPtr.Zero;
            try
            {
                ptrA2S = Marshal.AllocHGlobal(sizeData);
                Marshal.Copy(data, 0, ptrA2S, sizeData);

                retVal = Marshal.PtrToStructure(ptrA2S, structureType);
            }
            finally
            {
                if (ptrA2S != IntPtr.Zero) Marshal.FreeHGlobal(ptrA2S);
            }
            return retVal;
        }
    }
}
