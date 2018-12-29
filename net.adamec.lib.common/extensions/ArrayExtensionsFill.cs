namespace net.adamec.lib.common.extensions
{

    /// <summary>
    /// Array extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.ArrayExtensions.Fill</NuProp.Id>
    /// <NuProp.Description>Fills the array with given value (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension array</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ArrayExtensions
    {
        /// <summary>
        /// Fills the <paramref name="array"/> or <typeparamref name="T"/> with <paramref name="defaultValue"/>
        /// </summary>
        /// <typeparam name="T"><paramref name="array"/> item type</typeparam>
        /// <param name="array">Array to fill</param>
        /// <param name="defaultValue">Value to fill the array with</param>
        public static void Fill<T>(this T[] array, T defaultValue)
        {
            if (array == null)
                return;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = defaultValue;
            }
        }

    }
}
