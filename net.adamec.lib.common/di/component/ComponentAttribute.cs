using System;

namespace net.adamec.lib.common.di.component
{
    /// <summary>
    /// Marks the decorated class as a component that will be available from 
    /// the service locator / component container.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ComponentAttribute : Attribute
    {
        /// <summary>
        /// Component scope
        /// </summary>
        public enum ScopeEnum
        {
            /// <summary>
            /// Transient scope (instance per dependency)
            /// </summary>
            InstancePerDependency,
            /// <summary>
            /// Transient scope (instance per dependency)
            /// </summary>
            Transient=InstancePerDependency,

            /// <summary>
            /// Singleton
            /// </summary>
            SingleInstance,
            /// <summary>
            /// Singleton
            /// </summary>
            Singleton=SingleInstance,
            
            /// <summary>
            /// Instance per lifetime scope
            /// </summary>
            InstancePerLifetimeScope,

            /// <summary>
            /// Instance per request (scoped)
            /// </summary>
            InstancePerRequest,
            /// <summary>
            /// Instance per request (scoped)
            /// </summary>
            Scoped=InstancePerRequest
        }

        /// <summary>
        /// Kind of the implicit component registration
        /// </summary>
        public enum ImplicitRegistrationTypeEnum
        {
            /// <summary>
            /// Register as self (type) only
            /// </summary>
            Self,
            /// <summary>
            /// Register as all implemented interfaces
            /// </summary>
            ImplementedInterfaces,
            /// <summary>
            /// Register as self (type) and all implemented interfaces
            /// </summary>
            SelfAndImplementedInterfaces
        }

        /// <summary>
        /// Type to use for the component registration.
        /// </summary>
        public Type[] RegisterAs { get; }

        /// <summary>
        /// Flag how to do the implicit registration when no types are explicitly defined 
        /// </summary>
        public ImplicitRegistrationTypeEnum? ImplicitRegistrationType { get; }

        /// <summary>
        /// Defines the instance scope
        /// </summary>
        public ScopeEnum Scope { get; }

       
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAttribute"/> class, 
        /// marking the decorated class as a component that will be available from 
        /// the component container, registered as the concrete type or with all 
        /// implemented interfaces as well if specified.
        /// </summary>
        /// <param name="implicitRegistrationType">Flag how to do the implicit registration when no types are explicitly defined</param>
        /// <param name="scope">The instance scope</param>
        public ComponentAttribute(
            ImplicitRegistrationTypeEnum implicitRegistrationType= ImplicitRegistrationTypeEnum.Self,
            ScopeEnum scope = ScopeEnum.Transient)
            : this(null, implicitRegistrationType, scope) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAttribute"/> class, 
        /// marking the decorated class as a component that will be available from 
        /// the component container using the specified <paramref name="registerAs" /> type.
        /// </summary>
        /// <param name="registerAs">The type to use to register the decorated component.</param>;
        /// <param name="scope">The instance scope</param>
        public ComponentAttribute(Type registerAs, ScopeEnum scope = ScopeEnum.Transient): this(new[] { registerAs },null, scope) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAttribute"/> class, 
        /// marking the decorated class as a component that will be available from 
        /// the component container using the specified <paramref name="registerAs" /> types.
        /// </summary>
        /// <param name="registerAs">The type to use to register the decorated component.</param>;
        /// <param name="scope">The instance scope</param>
        public ComponentAttribute(Type[] registerAs, ScopeEnum scope = ScopeEnum.Transient): this(registerAs, null, scope) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAttribute"/> class, 
        /// marking the decorated class as a component that will be available from 
        /// the component container using the specified <paramref name="registerAs" /> types.
        /// </summary>
        /// <param name="registerAs">The type to use to register the decorated component.</param>;
        /// <param name="implicitRegistrationType">Flag how to do the implicit registration when no types are explicitly defined</param>
        /// <param name="scope">The instance scope</param>
        private ComponentAttribute(
            Type[] registerAs = null,
            ImplicitRegistrationTypeEnum? implicitRegistrationType = ImplicitRegistrationTypeEnum.SelfAndImplementedInterfaces,
            ScopeEnum scope = ScopeEnum.Transient)
        {
            RegisterAs = registerAs;
            ImplicitRegistrationType = implicitRegistrationType;
            Scope = scope;
        }
    }
}
