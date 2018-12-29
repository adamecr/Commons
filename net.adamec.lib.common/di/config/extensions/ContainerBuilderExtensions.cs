using System;
using System.Linq;
using System.Reflection;
using Autofac;
using Microsoft.Extensions.Configuration;

namespace net.adamec.lib.common.di.config.extensions
{
    /// <summary>
    /// Autofac <see cref="ContainerBuilder"/> extensions
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ContainerBuilderExtensions
    {
        
        /// <summary>
        /// Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect.
        /// This is to be used if not registered via MS ServiceCollection extensions
        /// </summary>
        /// <param name="builder">AutoFac container builder</param>
        /// <param name="configuration">Configuration container</param>
        /// <param name="assemblies">Assemblies to check</param>
        /// <exception cref="ArgumentNullException"><paramref name="configuration"/> or <paramref name="assemblies"/> is null</exception>
        public static void AddAutoOptions(this ContainerBuilder builder, IConfigurationRoot configuration, params Assembly[] assemblies)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (assemblies == null) throw new ArgumentNullException(nameof(assemblies));

            var types = from assembly in assemblies
                        from type in assembly.GetTypes()
                        select type;

            builder.AddAutoOptions(configuration, types.ToArray());
        }

        /// <summary>
        /// Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect.
        /// This is to be used if not registered via MS ServiceCollection extensions
        /// </summary>
        /// <param name="builder">AutoFac container builder</param>
        /// <param name="configuration">Configuration container</param>
        /// <param name="types">Types to check</param>
        /// <exception cref="ArgumentNullException"><paramref name="configuration"/> or <paramref name="types"/> is null</exception>
        public static void AddAutoOptions(this ContainerBuilder builder, IConfigurationRoot configuration, params Type[] types)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (types == null) throw new ArgumentNullException(nameof(types));

            foreach (var type in types)
            {
                var autoOptionsAttribute = type.GetTypeInfo().GetCustomAttribute<AutoOptionsAttribute>(false);
                if (autoOptionsAttribute == null || autoOptionsAttribute.RegisterDirect == false) continue;


                var config = Activator.CreateInstance(type);
                configuration.Bind(autoOptionsAttribute.ConfigSection, config);
                builder.Register(c => config).As(type).SingleInstance();
            }
        }

        /// <summary>
        /// Creates and registers the singleton of configuration (options) class of <typeparamref  name="TOptions">given type</typeparamref>
        /// This is to be used if not registered using the <see cref="AutoOptionsAttribute"/>
        /// </summary>
        /// <param name="builder">AutoFac container builder</param>
        /// <param name="configuration">Configuration container</param>
        ///<param name="configSection">Name of the configuration section to bind to</param>
        /// <typeparam name="TOptions">Configuration class type</typeparam>
        /// <exception cref="ArgumentNullException"><paramref name="configuration"/> is null</exception>
        /// <exception cref="ArgumentException"><paramref name="configSection"/> is null  or empty</exception>
        public static void AddOptions<TOptions>(this ContainerBuilder builder, IConfigurationRoot configuration, string configSection) where TOptions : new()
        {
            if (string.IsNullOrEmpty(configSection)) throw new ArgumentException(nameof(configSection));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            var config = new TOptions();
            configuration.Bind(configSection, config);
            builder.Register(c => config).As(typeof(TOptions)).SingleInstance();
        }
    }
}
