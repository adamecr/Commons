using System;

namespace net.adamec.lib.common.extensions
{
    /// <summary>
    /// <see cref="Type"/> extensions
    /// </summary>
    /// <NuProp.Id>RadCommons.extensions.TypeExtensions.DefaultValue</NuProp.Id>
    /// <NuProp.Description>Provides default value for types (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons</NuProp.Tags> 
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class TypeExtensions
    {
        /// <summary>
        /// Gets the default value of given <paramref name="type"/>
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Default value of given <paramref name="type"/>. Null for non-value types, new instance for value types.</returns>
        public static object GetDefaultValue(this Type type)
        {
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }
    }
}
