using System;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;

namespace net.adamec.lib.common.di.component
{
    /// <summary>
    /// Autofac <see cref="ContainerBuilder"/> extensions
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    internal static partial class ContainerBuilderExtensions
    {
        /// <summary>
        /// Adds classes from the <paramref name="assemblies"/> having the <see cref="ComponentAttribute"/> into Autofac container <paramref name="builder"/>
        /// </summary>
        /// <param name="builder">Autofac container builder</param>
        /// <param name="assemblies">Assemblies to check the classes for the <see cref="ComponentAttribute"/></param>
        public static void AddServicesWithComponentAttribute(this ContainerBuilder builder, params Assembly[] assemblies)
        {
            var types = from assembly in assemblies
                        from type in assembly.GetTypes()
                        select type;

            builder.AddServicesWithComponentAttribute(types.ToArray());
        }

        /// <summary>
        /// Adds classes from array of <paramref name="types"/> having the <see cref="ComponentAttribute"/> into Autofac container <paramref name="builder"/>
        /// </summary>
        /// <param name="builder">Autofac container builder</param>
        /// <param name="types">Array of types to check the classes for the <see cref="ComponentAttribute"/></param>
        public static void AddServicesWithComponentAttribute(this ContainerBuilder builder, params Type[] types)
        {
            foreach (var type in types)
            {
                var componentAttribute = type.GetTypeInfo().GetCustomAttribute<ComponentAttribute>(false);
                if (componentAttribute == null) continue;

                if (type.GetTypeInfo().IsGenericType)
                {
                    var registrationBuilder = builder.RegisterGeneric(type);
                    Register(registrationBuilder, type, componentAttribute);
                }
                else
                {
                    var registrationBuilder = builder.RegisterType(type);
                    Register(registrationBuilder, type, componentAttribute);
                }
            }
        }

        /// <summary>
        /// Registers the <paramref name="type"/> with <paramref name="componentAttribute"/> using the Autofac container <paramref name="builder"/>
        /// </summary>
        /// <typeparam name="TLimit">Registration limit type.</typeparam>
        /// <typeparam name="TActivatorData">Activator data type.</typeparam>
        /// <typeparam name="TRegistrationStyle">Registration style.</typeparam>
        /// <param name="builder">Autofac container builder</param>
        /// <param name="type">Type to register</param>
        /// <param name="componentAttribute"><see cref="ComponentAttribute"/> of given <paramref name="type"/></param>
        /// <exception cref="ArgumentNullException"><paramref name="builder"/>, <paramref name="type"/> or <paramref name="componentAttribute"/> is <see langword="null"/></exception>
        private static void Register<TLimit, TActivatorData, TRegistrationStyle>(
                IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> builder,
                Type type,
                ComponentAttribute componentAttribute)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (type == null) throw new ArgumentNullException(nameof(type));
            if (componentAttribute == null) throw new ArgumentNullException(nameof(componentAttribute));

            var asTypes = componentAttribute.RegisterAs;
            if (componentAttribute.RegisterAs != null && componentAttribute.RegisterAs.Length > 0)
            {
                //explicit registration
                builder = builder.As(asTypes);
            }
            else
            {
                //implicit registration
                var implicitRegistrationType = componentAttribute.ImplicitRegistrationType ?? ComponentAttribute.ImplicitRegistrationTypeEnum.Self;
                switch (implicitRegistrationType)
                {
                    case ComponentAttribute.ImplicitRegistrationTypeEnum.Self:
                        builder = builder.As(type);
                        break;
                    case ComponentAttribute.ImplicitRegistrationTypeEnum.ImplementedInterfaces:
                        builder = builder.As(GetImplementedInterfaces(type));
                        break;
                    case ComponentAttribute.ImplicitRegistrationTypeEnum.SelfAndImplementedInterfaces:
                        builder = builder.As(type).As(GetImplementedInterfaces(type));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            switch (componentAttribute.Scope)
            {
                case ComponentAttribute.ScopeEnum.InstancePerDependency:
                    builder.InstancePerDependency();
                    break;
                case ComponentAttribute.ScopeEnum.SingleInstance:
                    builder.SingleInstance();
                    break;
                case ComponentAttribute.ScopeEnum.InstancePerLifetimeScope:
                    builder.InstancePerLifetimeScope();
                    break;
                case ComponentAttribute.ScopeEnum.InstancePerRequest:
                    builder.InstancePerRequest();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var namedRegistrationAttribute = type.GetTypeInfo()
                .GetCustomAttribute<NamedComponentRegistrationAttribute>();
            if (namedRegistrationAttribute != null)
            {
                builder.Named(namedRegistrationAttribute.Name, namedRegistrationAttribute.Type ?? type);
            }
        }

        /// <summary>
        /// Gets the array of interfaces implemented by given <paramref name="type"/> except the <see cref="IDisposable"/> interface
        /// </summary>
        /// <remarks>When the <paramref name="type"/> itself is an interface, it's added to the returned list.</remarks>
        /// <param name="type">Type to check</param>
        /// <returns>Array of interfaces implemented by given <paramref name="type"/> except the <see cref="IDisposable"/> interface</returns>
        private static Type[] GetImplementedInterfaces(Type type)
        {
            var types = type.GetTypeInfo().ImplementedInterfaces.Where(i => i as object != (object)typeof(IDisposable));
            return !type.GetTypeInfo().IsInterface ? types.ToArray() : types.Append(type).ToArray();
        }

       }
}
