using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using net.adamec.lib.common.di.config.exception;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.di.config.extensions
{
    /// <summary>
    /// Extensions for options (configuration) class automatic binding to appsettings.json
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ServiceCollectionAutoOptionsExtension
    {
        private static readonly ILogger Logger = CommonLogging.CreateLogger(typeof(ServiceCollectionAutoOptionsExtension));

        /// <summary>
        /// Scans given assemblies for classes marked with <see cref="AutoOptionsAttribute"/> and binds them to appsettings.json configuration section defined in attribute.
        /// Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI
        /// </summary>
        /// <param name="services">Service collection</param>
        /// <param name="configuration">Configuration root</param>
        /// <param name="assemblies">Assemblies to scan</param>
        /// <returns>Service collection</returns>
        /// <exception cref="ArgumentNullException"><paramref name="services"/> or <paramref name="assemblies"/> is <see langword="null"/></exception>
        /// <exception cref="ServiceCollectionAutoOptionsException">Can get 'services.Configure' method</exception>
        /// <exception cref="ServiceCollectionAutoOptionsException">Can't invoke 'services.Configure&lt;type&gt;(section)'</exception>
        /// <exception cref="ServiceCollectionConfigureDirectException">Can't create the instance of options (configuration) class</exception>
        public static IServiceCollection ConfigureAutoOptions(this IServiceCollection services, IConfigurationRoot configuration, Assembly[] assemblies)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (assemblies == null) throw new ArgumentNullException(nameof(assemblies));

            var configureMethod = typeof(OptionsConfigurationServiceCollectionExtensions).GetMethod(
                "Configure",
                new[] { typeof(IServiceCollection), typeof(IConfiguration) });
            if (configureMethod == null) throw new ServiceCollectionAutoOptionsException("Can't get the Configure method");

            foreach (var assembly in assemblies)
            {
                foreach (var type in assembly.ExportedTypes)
                {
                    AutoOptionsAttribute attr = null;
                    try
                    {
                        attr = type.GetTypeInfo().GetCustomAttribute<AutoOptionsAttribute>();
                    }
                    catch (Exception ex) when (ex is AmbiguousMatchException || ex is TypeLoadException)
                    {
                        //do nothing
                        Logger.Warn(ex, $"Can't get the AutoOptionsAttribute. {ex.Message}");
                    }


                    if (attr == null) continue;

                    //type = Type of options (configuration) class with AutoOptionsAttribute
                    var section = configuration.GetSection(attr.ConfigSection);
                    var configureRef = configureMethod.MakeGenericMethod(type);

                    try
                    {
                        //apply configuration: services.Configure<type>(section);
                        configureRef.Invoke(null, new object[] { services, section });
                    }
                    catch (Exception ex) when (
                        ex is TargetException ||
                        ex is TargetInvocationException ||
                        ex is TargetParameterCountException ||
                        ex is MethodAccessException ||
                        ex is ArgumentException ||
                        ex is InvalidOperationException ||
                        ex is NotSupportedException)
                    {
                        //log and rethrow
                        var msg = $"Can't invoke 'services.Configure<{type.Name}>({section})'. {ex.Message}";
                        Logger.Warn(ex, msg);
                        throw new ServiceCollectionAutoOptionsException(msg, ex);
                    }


                    if (attr.RegisterDirect)
                    {
                        //register options class as singleton in DI
                        services.ConfigureDirect(type, section);
                    }
                }
            }

            return services;
        }

        /// <summary>
        /// Scans given assemblies for classes marked with <see cref="AutoOptionsAttribute"/> and binds them to appsettings.json configuration section defined in attribute.
        /// Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI
        /// </summary>
        /// <param name="services">Service collection</param>
        /// <param name="configuration">Configuration</param>
        /// <param name="assemblies">Assemblies to scan</param>
        /// <returns>Service collection</returns>
        /// <exception cref="ArgumentNullException"><paramref name="services"/> or <paramref name="assemblies"/> is <see langword="null"/></exception>
        /// <exception cref="ServiceCollectionAutoOptionsException">Can get 'services.Configure' method</exception>
        /// <exception cref="ServiceCollectionAutoOptionsException">Can't invoke 'services.Configure&lt;type&gt;(section)'</exception>
        /// <exception cref="ServiceCollectionConfigureDirectException">Can't create the instance of options (configuration) class</exception>
        public static IServiceCollection ConfigureAutoOptions(this IServiceCollection services, IConfiguration configuration, Assembly[] assemblies)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (assemblies == null) throw new ArgumentNullException(nameof(assemblies));

            var configureMethod = typeof(OptionsConfigurationServiceCollectionExtensions).GetMethod(
                "Configure",
                new[] { typeof(IServiceCollection), typeof(IConfiguration) });
            if (configureMethod == null) throw new ServiceCollectionAutoOptionsException("Can't get the Configure method");

            foreach (var assembly in assemblies)
            {
                foreach (var type in assembly.ExportedTypes)
                {
                    AutoOptionsAttribute attr = null;
                    try
                    {
                        attr = type.GetTypeInfo().GetCustomAttribute<AutoOptionsAttribute>();
                    }
                    catch (Exception ex) when (ex is AmbiguousMatchException || ex is TypeLoadException)
                    {
                        //do nothing
                        Logger.Warn(ex, $"Can't get the AutoOptionsAttribute. {ex.Message}");
                    }


                    if (attr == null) continue;

                    //type = Type of options (configuration) class with AutoOptionsAttribute
                    var section = configuration.GetSection(attr.ConfigSection);
                    var configureRef = configureMethod.MakeGenericMethod(type);

                    try
                    {
                        //apply configuration: services.Configure<type>(section);
                        configureRef.Invoke(null, new object[] { services, section });
                    }
                    catch (Exception ex) when (
                        ex is TargetException ||
                        ex is TargetInvocationException ||
                        ex is TargetParameterCountException ||
                        ex is MethodAccessException ||
                        ex is ArgumentException ||
                        ex is InvalidOperationException ||
                        ex is NotSupportedException)
                    {
                        //log and rethrow
                        var msg = $"Can't invoke 'services.Configure<{type.Name}>({section})'. {ex.Message}";
                        Logger.Warn(ex, msg);
                        throw new ServiceCollectionAutoOptionsException(msg, ex);
                    }


                    if (attr.RegisterDirect)
                    {
                        //register options class as singleton in DI
                        services.ConfigureDirect(type, section);
                    }
                }
            }

            return services;
        }

    }
}
