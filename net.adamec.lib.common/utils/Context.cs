using System;
using System.Threading;
using net.adamec.lib.common.core.utils;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    ///  Base context implementation.
    /// </summary>
    /// <remarks>
    /// The context can be both state-less and state-full and it's valid until it's disposed.
    /// The current context is accessible via <see cref="Current"/>.
    /// The contexts are chained, when a new context is created using <see cref="BeginContext"/>,
    /// the <see cref="Current"/> context became the <see cref="Parent"/> of the new one and
    /// the newly created context will be set as the <see cref="Current"/> one.
    /// When the context is disposed, the <see cref="Current"/> context is set to <see cref="Parent"/> of disposing context.
    /// Context's children are disposed as well during the context disposal.
    /// The <see cref="AddToDisposer"/> method is to be used in inherited classes whenever
    /// they manage any disposable resource to ensure their proper life time
    /// (when the <see cref="State"/> is <see cref="IDisposable"/>, it's added to disposer automatically).
    /// <para>
    /// The base implementation just manages the life time, context chain and keeps the state (when provided).
    /// Inherit from the <see cref="Context{TState}"/> to add the context related operations
    /// (inherited classes have the access to <see cref="State"/>).
    /// </para>
    /// <para>Based on the implementation of Guard Scopes by  https://github.com/safakgur
    /// at https://github.com/safakgur/guard/blob/v1.7.0/src/Guard.Scopes.cs </para>
    /// </remarks>
    /// <typeparam name="TState">Type of the state object managed by the context</typeparam>
    /// <NuProp.Id>RadCommons.utils.Context</NuProp.Id>
    /// <NuProp.Description>The runtime "container" for context operations.  The context can be both state-less and state-full and it's valid until it's disposed.
    /// The current context is accessible via static property Current.
    /// The contexts are chained, when a new context is created using static method BeginContext(),
    /// the Current context became the Parent of the new one and
    /// the newly created context will be set as the Current one.
    /// When the context is disposed, the Current context is set to Parent of disposing context.
    /// The base implementation just manages the life time, context chain and keeps the state (when provided).
    /// Inherit from the Context&lt;TState&gt; to add the context related operations (inherited classes have the access to state).
    /// Based on the implementation of Guard Scopes by  https://github.com/safakgur.
    /// (Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only disposable context</NuProp.Tags>
    /// <NuProp.Using id="RadCommons.utils.Disposer" />
    /// <NuProp.Needs id="RadCommons.core" />
    /// <NuProp.Remarks cref="T:net.adamec.lib.common.utils.Context`1" />
    internal class Context<TState> : BaseDisposable where TState : class, new()
    {
        /// <summary>
        /// Error message that will be put into the exception when there will be any operation on the disposed context.
        /// </summary>
        private const string ContextDisposedMessage = "Current context has been disposed";

        /// <summary>
        ///  The context holder that is local to the calling asynchronous control flow.
        /// </summary>
        private static readonly AsyncLocal<Context<TState>> Local = new AsyncLocal<Context<TState>>();

        /// <summary>
        /// Gets the current context.
        /// </summary>
        public static Context<TState> Current
        {
            get => Local.Value;
            private set => Local.Value = value;
        }

        /// <summary>
        /// Gets the disposer associated with this container.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the context.</typeparam>
        private Disposer Disposer { get; }

        /// <summary>
        /// Parent context.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the context.</typeparam>
        private readonly Context<TState> parentContext;

        /// <summary>
        /// Gets the parent scope.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the context.</typeparam>
        /// <exception cref="ObjectDisposedException">The current context has been disposed.</exception>
        public Context<TState> Parent
        {
            get
            {
                AssertNotDisposed(ContextDisposedMessage);
                return parentContext;
            }
        }

        /// <summary>
        ///  State managed by the context.
        /// </summary>
        private readonly TState contextState;

        /// <summary>
        ///  Gets the state managed by the context.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the context.</typeparam>
        /// <exception cref="ObjectDisposedException">The current context has been disposed.</exception>
        protected TState State
        {
            get
            {
                AssertNotDisposed(ContextDisposedMessage);
                return contextState;
            }
        }

        /// <summary>
        /// Creates an instance of <see cref="Context{TState}"/> and initialize its <see cref="Disposer"/>.
        /// The new context will become <see cref="Current"/> and the previous one its <see cref="Parent"/>.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the context.</typeparam>
        /// <param name="state">Optional state managed by the context.</param>
        protected Context(TState state = null)
        {
            Disposer = new Disposer();
            parentContext = Current;
            Current = this;

            contextState = state;
            if (contextState is IDisposable disposableState) AddToDisposer(disposableState);
        }

        /// <summary>
        /// Creates a new <see cref="Context{TState}"/> within the context chain.
        /// The new context will become <see cref="Current"/> and the previous one its <see cref="Parent"/>.
        /// </summary>
        /// <typeparam name="TState">Type of the state object managed by the context.</typeparam>
        /// <param name="state">Optional state managed by the context.</param>
        public static IDisposable BeginContext(TState state = null)
        {
            return new Context<TState>(state);
        }

        /// <summary>
        /// Adds the <paramref name="disposable"/> object to the context disposer, so it will be disposed with the context
        /// </summary>
        /// <param name="disposable"><see cref="IDisposable"/> object to be added to the disposer.</param>
        /// <exception cref="ArgumentNullException"><paramref name="disposable"/> is null.</exception>
        /// <exception cref="ObjectDisposedException">The current context has been disposed.</exception>
        protected void AddToDisposer(IDisposable disposable)
        {
            if (disposable is null) throw new ArgumentNullException(nameof(disposable));
            AssertNotDisposed(ContextDisposedMessage);

            Disposer.Add(disposable);
        }

        /// <summary>
        /// Dispose any disposable managed objects - all disposables kept in <see cref="Disposer"/> stack are pop and disposed.
        /// <para>The <see cref="Parent"/> context of the disposing one will become the new <see cref="Current"/> context.</para>
        /// </summary>
        protected override void DisposeManaged()
        {
            Disposer.Dispose();
            Current = Parent;
        }
    }

}
