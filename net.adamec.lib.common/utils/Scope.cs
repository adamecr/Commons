using System;
using net.adamec.lib.common.core.utils;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    ///  Scope interface.
    /// </summary>
    /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
    /// <NuProp.Id>RadCommons.utils.Scope</NuProp.Id>
    /// <NuProp.Description>The runtime "container" for scoped operations.  The scope can be both state-less and state-full and it's valid until it's disposed.
    /// The scopes can be nested (when the scope is disposed, the children are disposed as well) and there can be multiple child scopes (siblings) living in parallel.
    /// The base implementation just manages the life time, child scopes and keeps the state (when provided).
    /// Inherit from the Scope&lt;TState&gt; (and IScope&lt;TState&gt;)
    /// to add the scope related operations (inherited classes have the access to state).
    /// (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only disposable scope</NuProp.Tags>
    /// <NuProp.Using id="RadCommons.utils.Disposer" />
    /// <NuProp.Needs id="RadCommons.core" />
    /// <NuProp.Remarks cref="T:net.adamec.lib.common.utils.Scope`1" />
    internal interface IScope<in TState> : IDisposable where TState: class,new()
    {
        /// <summary>
        /// Gets the parent scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        IScope<TState> Parent { get; }

        /// <summary>
        ///  Creates a child scope of the current scope.
        /// </summary>
        /// <param name="state">State managed by the child scope.</param>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        /// <returns>Child scope owned by the current scope.</returns>
        IScope<TState> BeginScope(TState state);
    }

    /// <summary>
    ///  Base scope implementation.
    /// </summary>
    /// <remarks>
    /// The scope can be both state-less and state-full and it's valid until it's disposed.
    /// The scopes can be nested, when the scope is disposed, the children are disposed as well.
    /// There can be multiple child scopes (siblings) living in parallel.
    /// The <see cref="AddToDisposer"/> method is to be used in inherited classes whenever
    /// they manage any disposable resource to ensure the proper life time
    /// (when the <see cref="State"/> is <see cref="IDisposable"/>, it's added to disposer automatically).
    /// <para>
    /// The base implementation just manages the life time, child scopes and keeps the state (when provided).
    /// Inherit from the <see cref="Scope{TState}"/> (and <see cref="IScope{TState}"/>)
    /// to add the scope related operations (inherited classes have the access to <see cref="State"/>).
    /// </para>
    /// </remarks>
    /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
    internal class Scope<TState> : BaseDisposable, IScope<TState> where TState : class, new()
    {
        /// <summary>
        /// Error message that will be put into the exception when there will be any operation on the disposed scope.
        /// </summary>
        private const string ScopeDisposedMessage = "The scope has been disposed";

        #region Root scope
        /// <summary>
        /// Instance of the <see cref="Scope{TState}"/> created when the singleton is first touched - root scope with default <see cref="State"/>
        /// </summary>
        /// <remarks>
        /// Not using the auto-property to have better control, when the instance is created
        /// </remarks>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        private static readonly Scope<TState> RootInternal = new Scope<TState>(new TState());

        /// <summary>
        /// Gets the root scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        // ReSharper disable once ConvertToAutoProperty
        public static Scope<TState> Root => RootInternal;

        /// <summary>
        /// Static constructor
        /// </summary>
        /// <remarks>Explicit static constructor to tell C# compiler not to mark type as beforefieldinit </remarks>
        static Scope(){}
        #endregion

        /// <summary>
        /// Gets the disposer associated with this container.
        /// </summary>
        private Disposer Disposer { get; }

        /// <summary>
        /// Parent scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        private readonly IScope<TState> parentScope;

        /// <summary>
        /// Gets the parent scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        /// <exception cref="ObjectDisposedException">The current scope has been disposed.</exception>
        public IScope<TState> Parent
        {
            get
            {
                AssertNotDisposed(ScopeDisposedMessage);
                return parentScope;
            }
        }

        /// <summary>
        ///  State managed by the scope.
        /// </summary>
        private readonly TState scopeState;

        /// <summary>
        ///  Gets the state managed by the scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        /// <exception cref="ObjectDisposedException">The current scope has been disposed.</exception>
        protected TState State
        {
            get
            {
                AssertNotDisposed(ScopeDisposedMessage);
                return scopeState;
            }
        }

        /// <summary>
        /// Creates an instance of <see cref="Scope{TState}"/> and initialize its <see cref="Disposer"/>.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        /// <param name="state">Optional state managed by the scope.</param>
        private Scope( TState state = null)
        {
            Disposer = new Disposer();

            scopeState = state;
            if (scopeState is IDisposable disposableState) AddToDisposer(disposableState);
        }

        /// <summary>
        ///  Creates an instance of child <see cref="Scope{TState}"/>.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        /// <param name="parent">Parent scope</param>
        /// <param name="state">Optional state managed by the scope.</param>
        protected Scope(IScope<TState> parent, TState state = null) : this(state)
        {
            parentScope = parent ?? throw new ArgumentNullException(nameof(parent));
         }

        /// <summary>
        ///  Creates a child scope of the current scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the scope</typeparam>
        /// <param name="state">Optional state managed by the child scope..</param>
        /// <returns>Child scope owned by the current scope.</returns>
        /// <exception cref="ObjectDisposedException">The current scope has been disposed.</exception>
        public IScope<TState> BeginScope(TState state = null)
        {
            AssertNotDisposed(ScopeDisposedMessage);
            var scope = new Scope<TState>(this, state);
            AddToDisposer(scope);
            return scope;
        }

        /// <summary>
        /// Adds the <paramref name="disposable"/> object to the scope disposer, so it will be disposed with the scope
        /// </summary>
        /// <param name="disposable"><see cref="IDisposable"/> object to be added to the disposer.</param>
        /// <exception cref="ArgumentNullException"><paramref name="disposable"/> is null.</exception>
        /// <exception cref="ObjectDisposedException">The current scope has been disposed.</exception>
        protected void AddToDisposer(IDisposable disposable)
        {
            if(disposable is null) throw new ArgumentNullException(nameof(disposable));
            AssertNotDisposed(ScopeDisposedMessage);

            Disposer.Add(disposable);
        }

        /// <summary>
        /// Dispose any disposable managed objects - all disposables kept in <see cref="Disposer"/> stack are pop and disposed.
        /// </summary>
        protected override void DisposeManaged()
        {
            Disposer.Dispose();
        }
    }
}
