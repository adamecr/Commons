using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="IEnumerator{T}"/> class extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.EnumeratorExtensions.ToEnumerable</NuProp.Id>
    /// <NuProp.Description>Transforms the IEnumerator or IEnumerator&lt;T&gt; to IEnumerable&lt;T&gt; (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only extension enumerator</NuProp.Tags>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class EnumeratorExtensions
    {
        /// <summary>
        /// Transforms the <paramref name="enumerator"/> to <see cref="IEnumerable{T}"/>
        /// </summary>
        /// <typeparam name="T">Type  of objects held in enumerator/enumerable</typeparam>
        /// <param name="enumerator">Enumerator to transforms</param>
        /// <returns><see cref="IEnumerable{T}"/> based on given <paramref name="enumerator"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumerator"/> is null</exception>
        public static IEnumerable<T> ToEnumerable<T>(this IEnumerator<T> enumerator)
        {
            if(enumerator==null) throw new ArgumentNullException(nameof(enumerator));

            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }

        /// <summary>
        /// Transforms the <paramref name="enumerator"/> to <see cref="IEnumerable{T}"/>
        /// </summary>
        /// <typeparam name="T">Type of objects held in enumerator/enumerable</typeparam>
        /// <param name="enumerator">Enumerator to transforms</param>
        /// <returns><see cref="IEnumerable{T}"/> based on given <paramref name="enumerator"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumerator"/> is null</exception>
        public static IEnumerable<T> ToEnumerable<T>(this IEnumerator enumerator)
        {
            if (enumerator == null) throw new ArgumentNullException(nameof(enumerator));

            while (enumerator.MoveNext())
                yield return (T)enumerator.Current;
        }

        /// <summary>
        /// Transforms the <paramref name="enumerator"/> to <see cref="List{T}"/>
        /// </summary>
        /// <typeparam name="T">Type of objects held in enumerator/list</typeparam>
        /// <param name="enumerator">Enumerator to transforms</param>
        /// <returns><see cref="List{T}"/> based on given <paramref name="enumerator"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="enumerator"/> is null</exception>
        public static List<T> ToList<T>(this IEnumerator enumerator)
        {
            if (enumerator == null) throw new ArgumentNullException(nameof(enumerator));

            return enumerator.ToEnumerable<T>().ToList();
        }
    }
}
