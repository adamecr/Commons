using System;

namespace net.adamec.lib.common.di.config
{
    /// <inheritdoc />
    /// <summary>
    /// Class attribute allowing the auto registration of options class into .NET Core configuration framework
    /// and optional direct registration of singleton instance into MS DI
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AutoOptionsAttribute: Attribute
    {
        /// <summary>
        /// Flag whether to create and registers the options class instance into MS DI
        /// </summary>
        public bool RegisterDirect { get; }
        /// <summary>
        /// Path to the section within appsettings.json
        /// </summary>
        public string ConfigSection { get; }

        /// <inheritdoc />
        /// <summary>Class attribute allowing the auto registration of options class into .NET Core configuration framework
        /// and optional direct registration of singleton instance into MS DI
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="configSection" /> is <see langword="null" /></exception>
        public AutoOptionsAttribute(string configSection,bool registerDirect = false)
        {
            if(string.IsNullOrEmpty(configSection)) throw new ArgumentNullException(nameof(configSection));

            ConfigSection = configSection;
            RegisterDirect = registerDirect;
        }
    }
}
