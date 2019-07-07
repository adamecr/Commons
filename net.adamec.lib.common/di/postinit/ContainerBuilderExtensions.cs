﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Autofac.Core.Lifetime;
using net.adamec.lib.common.di.component;

namespace net.adamec.lib.common.di.postinit
{
    /// <summary>
    /// Autofac <see cref="ContainerBuilder"/> extensions
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ContainerBuilderExtensions
    {
        /// <summary>
        /// Adds the support of <see cref="PostInitAttribute"/> to the Autofac container builder.
        /// </summary>
        /// <remarks>
        /// Registers the <see cref="ProcessComponentPostInit"/> method as a container-built-callback
        /// </remarks>
        /// <param name="builder"></param>
        /// <returns>Autofac container builder</returns>
        public static ContainerBuilder AddComponentPostInitSupport(this ContainerBuilder builder)
        {
            builder.RegisterBuildCallback(ProcessComponentPostInit);
            return builder;
        }

        /// <summary>
        /// Executes the components' post init methods
        /// </summary>
        /// <remarks>
        /// Checks Autofac registry for the services with <see cref="ComponentAttribute"/> that register themselves (so the interface registrations are excluded).
        /// For such components (services) it tries to find the methods marked with <see cref="PostInitAttribute"/> and execute them.
        /// When the method has the parameters, it will try to resolve the from the container
        /// </remarks>
        /// <param name="container"></param>
        /// <exception cref="Exception">Can't resolve the post init method parameter from container or can't get the component instance from container</exception>
        private static void ProcessComponentPostInit(IContainer container)
        {
            if (container == null) throw new ArgumentNullException(nameof(container));

            var processedComponents = new List<Type>();
            foreach (var componentRegistration in container.ComponentRegistry.Registrations)
            {
                var type = componentRegistration.Activator.LimitType;

                if (!(componentRegistration.Lifetime is RootScopeLifetime)) continue; //must be singleton


                var hasSelfRegistration = componentRegistration.Services.OfType<TypedService>()
                    .Any(typedService => typedService.ServiceType == type);
                if (!hasSelfRegistration) continue; //mush have self registration

                if (processedComponents.Contains(type)) continue; //already checked/processed
                processedComponents.Add(type);

                // componentRegistration.Services.ToArray()[0].
                var componentAttribute = type.GetTypeInfo().GetCustomAttribute<ComponentAttribute>(false);
                if (componentAttribute == null) continue; //must have component attribute

                //has Component attribute, check if has any method with PostInit attribute and get the first one
                foreach (var method in type.GetMethods())
                {
                    var postInitAttribute = method.GetCustomAttribute<PostInitAttribute>(false);
                    if (postInitAttribute == null) continue;

                    //has postinit attribute - try to inject parameters
                    var parameterValues = new List<object>();
                    foreach (var parameter in method.GetParameters())
                    {
                        var parameterType = parameter.ParameterType;
                        if (container.TryResolve(parameterType, out object valueToInject))
                        {
                            parameterValues.Add(valueToInject);
                        }
                        else
                        {
                            var msg = $"ProcessComponentPostInit - can't resolve parameter {parameter.Name} of type {parameterType.FullName} for post init method '{method.Name}' of type '{type.FullName}'";
                            throw new Exception(msg);
                        }
                    }

                    //invoke
                    if (container.TryResolve(type, out object componentInstance))
                    {
                        method.Invoke(componentInstance, parameterValues.ToArray());
                    }
                    else
                    {
                        var msg =$"ProcessComponentPostInit - can't resolve component of type '{type.FullName}' for invoking the post init method '{method.Name}' ";
                        throw new Exception(msg);
                    }

                    //finish scan of the type
                    break;
                }
            }
        }
    }
}
