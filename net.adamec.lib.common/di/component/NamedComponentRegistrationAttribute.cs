using System;

namespace net.adamec.lib.common.di.component
{
    /// <summary>
    /// Defines the registration name and type for named registration (component type will be used if null)
    /// </summary>
    // ReSharper disable once RedundantAttributeUsageProperty
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class NamedComponentRegistrationAttribute : Attribute
    {
        /// <summary>
        /// Registration name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Registrations type for named registration. Component type will be used if null
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Named registration with component type used
        /// </summary>
        /// <param name="name">Registration name</param>
        public NamedComponentRegistrationAttribute(string name) : this(name, null)
        {
        }

        /// <summary>
        /// Defines the registration name and type for named registration (component type will be used if null)
        /// </summary>
        /// <param name="name">Registration name</param>
        /// <param name="type">Registrations type for named registration. Component type will be used if null</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is null or empty</exception>
        public NamedComponentRegistrationAttribute(string name, Type type)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            Name = name;
            Type = type;
        }

    }
}

