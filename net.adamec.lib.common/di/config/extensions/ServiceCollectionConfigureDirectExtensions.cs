using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using net.adamec.lib.common.di.config.exception;

namespace net.adamec.lib.common.di.config.extensions
{

    /// <summary>
    /// Extensions for options (configuration) class registration into MS DI
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ServiceCollectionConfigureDirectExtensions
    {
        /// <summary>
        /// Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI.
        /// </summary>
        /// <param name="services">MS DI Service collection</param>
        /// <param name="type">Type of options (configuration) class to register as singleton</param>
        /// <param name="configuration"></param>
        /// <returns>Options (configuration) class instance registered as singleton</returns>
        /// <exception cref="ArgumentNullException"><paramref name="services"/> or <paramref name="configuration"/> is <see langword="null"/></exception>
        /// <exception cref="ServiceCollectionConfigureDirectException">Can't create the instance of options (configuration) class</exception>
        public static object ConfigureDirect(this IServiceCollection services, Type type, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            object config;
            try
            {
                config = Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                throw new ServiceCollectionConfigureDirectException("Can't create the instance of options (configuration) class", ex);
            }
            configuration.Bind(config);
            services.AddSingleton(type, config);
            return config;
        }

        /// <summary>
        /// Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI.
        /// </summary>
        /// <typeparam name="TConfig">Type of options (configuration) class to register as singleton</typeparam>
        /// <param name="services">MS DI Service collection</param>
        /// <param name="configuration">Configuration (data) to be filled into the options class instance</param>
        /// <returns>Options (configuration) class instance registered as singleton</returns>
        /// <exception cref="ArgumentNullException"><paramref name="services"/> or <paramref name="configuration"/> is <see langword="null"/></exception>
        public static TConfig ConfigureDirect<TConfig>(this IServiceCollection services, IConfiguration configuration) where TConfig : class, new()
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            var config = new TConfig();
            configuration.Bind(config);
            services.AddSingleton(config);
            return config;
        }

        /// <summary>
        /// Gets the instance of the options (configuration) class from <paramref name="pocoProvider"/>, binds (fills) it to the configuration
        /// and registers is as singleton into MS DI.
        /// </summary>
        /// <typeparam name="TConfig">Type of options (configuration) class to register as singleton</typeparam>
        /// <param name="services">MS DI Service collection</param>
        /// <param name="configuration">Configuration (data) to be filled into the options class instance</param>
        /// <param name="pocoProvider">Delegate of function that will provide the options (configuration) class instance</param>
        /// <returns>Options (configuration) class instance registered as singleton</returns>
        /// <exception cref="ArgumentNullException">One of the parameters is <see langword="null"/></exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        public static TConfig ConfigureDirect<TConfig>(this IServiceCollection services, IConfiguration configuration, Func<TConfig> pocoProvider) where TConfig : class
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (pocoProvider == null) throw new ArgumentNullException(nameof(pocoProvider));

            var config = pocoProvider();
            configuration.Bind(config);
            services.AddSingleton(config);
            return config;
        }

        /// <summary>
        /// Binds (fills) given instance of the options (configuration) class to configuration and registers is as singleton into MS DI.
        /// </summary>
        /// <typeparam name="TConfig">Type of options (configuration) class to register as singleton</typeparam>
        /// <param name="services">MS DI Service collection</param>
        /// <param name="configuration">Configuration (data) to be filled into the options class instance</param>
        /// <param name="config"></param>
        /// <returns>Options (configuration) class instance registered as singleton</returns>
        /// <exception cref="ArgumentNullException">One of the parameters is <see langword="null"/></exception>
        public static TConfig ConfigureDirect<TConfig>(this IServiceCollection services, IConfiguration configuration, TConfig config) where TConfig : class
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (config == null) throw new ArgumentNullException(nameof(config));

            configuration.Bind(config);
            services.AddSingleton(config);
            return config;
        }
    }
}
