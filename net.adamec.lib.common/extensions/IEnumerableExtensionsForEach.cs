using System;
using System.Collections.Generic;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="IEnumerable{T}"/> extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.IEnumerableExtensions.ForEach</NuProp.Id>
    /// <NuProp.Description>Invokes the action for each item if IEnumerable&lt;T&gt; (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension enumerable</NuProp.Tags> 
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class IEnumerableExtensions
    {
        /// <summary>
        /// Invokes <paramref name="action"/> for each item of <paramref name="enumerable"/>
        /// </summary>
        /// <typeparam name="T">Enumerable item type</typeparam>
        /// <param name="enumerable">Enumerable</param>
        /// <param name="action">Action to invoke for each item of <paramref name="enumerable"/></param>
        /// <exception cref="ArgumentNullException"><paramref name="action"/> is null</exception>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if(action==null) throw new ArgumentNullException(nameof(action));
            if (enumerable==null) return;

            foreach (var item in enumerable)
            {
                action(item);
            }
        }
    }
}
