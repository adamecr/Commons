#  Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10) |  | 
 | [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu) |  | 
 | [net.adamec.lib.common.di.config](#n-net.adamec.lib.common.di.config__3709lb) |  | 
 | [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q) |  | 
 | [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v) |  | 
 | [net.adamec.lib.common.di.postinit](#n-net.adamec.lib.common.di.postinit__ylne5f) |  | 
 | [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq) |  | 
 | [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [ArrayExtensions](#t-net.adamec.lib.common.extensions.arrayextensions__icw7wf) | internal static | Class | Array extensions | 
 | [AsyncManager](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9) | internal static | Class | Helpers for running the actions in sync or async mode | 
 | [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu) | private | Class | &quot;Private&quot; synchronization context used to run the async method | 
 | [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) | public | Class | Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI | 
 | [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo) | public | Class | Executes an operation on a separate thread with possibility of sync cancel. | 
 | [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) | public | Class | Marks the decorated class as a component that will be available from the service locator / component container. | 
 | [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415) | internal static | Class | Console output helpers | 
 | [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y) | internal static | Class | Autofac <em>Autofac.ContainerBuilder</em> extensions | 
 | [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7) | internal static | Class | Autofac <em>Autofac.ContainerBuilder</em> extensions | 
 | [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.postinit.containerbuilderextensions__7mjuw3) | internal static | Class | Autofac <em>Autofac.ContainerBuilder</em> extensions | 
 | [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) | internal | Class | Base context implementation. | 
 | [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q) | internal | Class | Keeps the stack of disposable objects, and disposes them when the disposer is being disposed. | 
 | [EnumeratorExtensions](#t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1" target="_blank" >System.Collections.Generic.IEnumerator`1</a> class extensions | 
 | [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu) | internal static | Class | Asynchronous text/lines file read methods https://stackoverflow.com/a/13168006 | 
 | [FileUtils](#t-net.adamec.lib.common.utils.fileutils__1bi9r8y) | internal static | Class | File copy utilities | 
 | [IEnumerableExtensions](#t-net.adamec.lib.common.extensions.ienumerableextensions__1a6urvh) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> extensions | 
 | [MarshalExt](#t-net.adamec.lib.common.utils.marshalext__7jyavy) | internal static | Class | Marshaling helper methods | 
 | [NamedComponentRegistrationAttribute](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr) | public | Class | Defines the registration name and type for named registration (component type will be used if null) | 
 | [PeriodicTask](#t-net.adamec.lib.common.utils.periodictask__1xfynj) | internal static | Class | Helper class allowing to execute periodic (or one time) scheduled action | 
 | [PostInitAttribute](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl) | public | Class | Allows to run post init method of component. Component must be registered using the Component attribute as singleton in root scope and must register self Parameters of &quot;marked&quot; post init method are resolved from container (throws an exception on failure) | 
 | [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix) | public | Class | The ProcessEventArgs are arguments for a console event. | 
 | [ProcessUtils](#t-net.adamec.lib.common.utils.processutils__tzt3e1) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process" target="_blank" >System.Diagnostics.Process</a> related utilities | 
 | [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p) | public | Class | A class the wraps a process, allowing programmatic input and output. | 
 | [ProcessWrapper.OutputChunk](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan) | protected | Class | Internal class to hold the output chunk within the output worker | 
 | [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) | internal | Class | Base scope implementation. | 
 | [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh) | public | Class | Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionAutoOptionsExtension</em> | 
 | [ServiceCollectionAutoOptionsExtension](#t-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension__1p9fgao) | internal static | Class | Extensions for options (configuration) class automatic binding to appsettings.json | 
 | [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj) | public | Class | Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionConfigureDirectExtensions</em> | 
 | [ServiceCollectionConfigureDirectExtensions](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv) | internal static | Class | Extensions for options (configuration) class registration into MS DI | 
 | [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions | 
 | [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) | public | Class | Text builder | 
 | [TypeExtensions](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 
 | [IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf) | internal abstract | Interface | Scope interface. | 
 | [ProcessEventHandler](#t-net.adamec.lib.common.utils.processeventhandler__8h5v6w) | public | Delegate | A ProcessEventHandler is a delegate for process output events. | 
 | [ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo) | public | Enum | Kind of the implicit component registration | 
 | [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps) | public | Enum | Component scope | 

Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="package-list" />  Source-only packages ##

 | Name | Summary | 
 | ------ | --------- | 
 | [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager) | Helpers for running the async tasks in sync mode and executing sync actions in async mode (Source only package). | 
 | [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync) | Helpers for reading text files in async mode (Source only package). | 
 | [RadCommons.di.Component](#src-only-package--RadCommons.di.Component) | RadCommons DI Component - allows to mark and inject the component using the class attributes (Source only package). | 
 | [RadCommons.di.Config](#src-only-package--RadCommons.di.Config) | RadCommons DI helpers for application configuration (Source only package). | 
 | [RadCommons.di.PostInit](#src-only-package--RadCommons.di.PostInit) | RadCommons DI PostInit - allows to run post init method of component (Source only package). | 
 | [RadCommons.extensions.ArrayExtensions.ConcatenateBytes](#src-only-package--RadCommons.extensions.ArrayExtensions.ConcatenateBytes) | Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one) (Source only package). | 
 | [RadCommons.extensions.ArrayExtensions.Fill](#src-only-package--RadCommons.extensions.ArrayExtensions.Fill) | Fills the array with given value (Source only package). | 
 | [RadCommons.extensions.EnumeratorExtensions.ToEnumerable](#src-only-package--RadCommons.extensions.EnumeratorExtensions.ToEnumerable) | Transforms the IEnumerator or IEnumerator<T> to IEnumerable<T> (Source only package). | 
 | [RadCommons.extensions.IEnumerableExtensions.ForEach](#src-only-package--RadCommons.extensions.IEnumerableExtensions.ForEach) | Invokes the action for each item if IEnumerable<T> (Source only package). | 
 | [RadCommons.extensions.StringExtensions.Case](#src-only-package--RadCommons.extensions.StringExtensions.Case) | String case manipulation helpers (Source only package). | 
 | [RadCommons.extensions.StringExtensions.Html](#src-only-package--RadCommons.extensions.StringExtensions.Html) | HTML related string manipulation helpers (Source only package). | 
 | [RadCommons.extensions.StringExtensions.Parts](#src-only-package--RadCommons.extensions.StringExtensions.Parts) | String splitting and parts manipulation helpers (Source only package). | 
 | [RadCommons.extensions.StringExtensions.Paths](#src-only-package--RadCommons.extensions.StringExtensions.Paths) | Path manipulation helpers for strings (Source only package). | 
 | [RadCommons.extensions.StringExtensions.Whitespace](#src-only-package--RadCommons.extensions.StringExtensions.Whitespace) | Whitespace manipulation helpers for strings (Source only package). | 
 | [RadCommons.extensions.TypeExtensions.DefaultValue](#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue) | Provides default value for types (Source only package). | 
 | [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel) | Executes an operation on a separate thread with possibility of sync cancel (Source only package). | 
 | [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils) | Console output utilities (Source only package). | 
 | [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context) | The runtime "container" for context operations.  The context can be both state-less and state-full and it's valid until it's disposed. The current context is accessible via static property Current. The contexts are chained, when a new context is created using static method BeginContext(), the Current context became the Parent of the new one and the newly created context will be set as the Current one. When the context is disposed, the Current context is set to Parent of disposing context. The base implementation just manages the life time, context chain and keeps the state (when provided). Inherit from the Context<TState> to add the context related operations (inherited classes have the access to state). Based on the implementation of Guard Scopes by  https://github.com/safakgur. (Source only package). | 
 | [RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer) | Keeps the stack of disposable objects, and disposes them when the disposer is being disposed. (Source only package). | 
 | [RadCommons.utils.FileUtils.Copy](#src-only-package--RadCommons.utils.FileUtils.Copy) | File copy utilities (Source only package). | 
 | [RadCommons.utils.MarshalExt](#src-only-package--RadCommons.utils.MarshalExt) | Marshaling helpers (Source only package). | 
 | [RadCommons.utils.PeriodicTask](#src-only-package--RadCommons.utils.PeriodicTask) | Periodic (or scheduled) async task runner (Source only package). | 
 | [RadCommons.utils.ProcessUtils](#src-only-package--RadCommons.utils.ProcessUtils) | Process related utilities (Source only package). | 
 | [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper) | A class the wraps a process, allowing programmatic input and output (Source only package). | 
 | [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope) | The runtime "container" for scoped operations.  The scope can be both state-less and state-full and it's valid until it's disposed. The scopes can be nested (when the scope is disposed, the children are disposed as well) and there can be multiple child scopes (siblings) living in parallel. The base implementation just manages the life time, child scopes and keeps the state (when provided). Inherit from the Scope<TState> (and IScope<TState>) to add the scope related operations (inherited classes have the access to state). (Source only package). | 
 | [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt) | Text builder allowing to build strings from parts, supporting conditions, enumerations, etc.(Source only package). | 

Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.async__17zxv10" />  net.adamec.lib.common.async Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AsyncManager](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9) | internal static | Helpers for running the actions in sync or async mode | 
 | [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu) | private | &quot;Private&quot; synchronization context used to run the async method | 
 | [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu) | internal static | Asynchronous text/lines file read methods https://stackoverflow.com/a/13168006 | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.async.asyncmanager__16s0tm9" />  AsyncManager Class ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Helpers for running the actions in sync or async mode



```csharp
internal static class AsyncManager
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DefaultExceptionHandler](#f-net.adamec.lib.common.async.asyncmanager.defaultexceptionhandler__1ltk17x) | private static | Default exception handler for [RunAsync(Action, Action&lt;System.Exception&gt;)](#m-net.adamec.lib.common.async.asyncmanager.runasync_system.action-system.action_system.exception____s187qk) . Catches all exceptions during the task execution. | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RunAsync(Action, Action&lt;System.Exception&gt;)](#m-net.adamec.lib.common.async.asyncmanager.runasync_system.action-system.action_system.exception____s187qk) | public static | Runs the given <strong>action</strong> asynchronously. | 
 | [RunSync(Func&lt;System.Threading.Tasks.Task&gt;)](#m-net.adamec.lib.common.async.asyncmanager.runsync_system.func_system.threading.tasks.task____10vlbqi) | public static | Executes synchronously an async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a> method which has a void return value | 
 | [RunSync&lt;T&gt;(Func&lt;System.Threading.Tasks.Task&lt;T&gt;&gt;)](#m-net.adamec.lib.common.async.asyncmanager.runsync--1_system.func_system.threading.tasks.task_--0_____jg6lmv) | public static | Executes synchronously an async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task`1</a> method which has a <strong>T</strong> return type | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.async.asyncmanager.defaultexceptionhandler__1ltk17x" />  AsyncManager.DefaultExceptionHandler Field ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Default exception handler for [RunAsync(Action, Action&lt;System.Exception&gt;)](#m-net.adamec.lib.common.async.asyncmanager.runasync_system.action-system.action_system.exception____s187qk) . Catches all exceptions during the task execution.



```csharp
private static readonly Action<System.Threading.Tasks.Task> DefaultExceptionHandler
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;System.Threading.Tasks.Task&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.runasync_system.action-system.action_system.exception____s187qk" />  AsyncManager.RunAsync(Action, Action&lt;System.Exception&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Runs the given <strong>action</strong> asynchronously.



```csharp
public static Task RunAsync(Action action, Action<System.Exception> exceptionHandler = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action" target="_blank" >System.Action</a> <strong>action</strong></dt><dd>Action to by run asynchronously</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;System.Exception&gt;</a> <strong>exceptionHandler</strong></dt><dd>Exception handler. If not provided, [DefaultExceptionHandler](#f-net.adamec.lib.common.async.asyncmanager.defaultexceptionhandler__1ltk17x) will be used</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>action</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.runsync_system.func_system.threading.tasks.task____10vlbqi" />  AsyncManager.RunSync(Func&lt;System.Threading.Tasks.Task&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Executes synchronously an async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a> method which has a void return value



```csharp
public static void RunSync(Func<System.Threading.Tasks.Task> task)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;System.Threading.Tasks.Task&gt;</a> <strong>task</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a> method to execute</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>task</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.runsync--1_system.func_system.threading.tasks.task_--0_____jg6lmv" />  AsyncManager.RunSync&lt;T&gt;(Func&lt;System.Threading.Tasks.Task&lt;T&gt;&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Executes synchronously an async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task`1</a> method which has a <strong>T</strong> return type



```csharp
public static AsyncManager.T RunSync<T>(Func<System.Threading.Tasks.Task<T>> task)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Return Type</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;System.Threading.Tasks.Task&lt;T&gt;&gt;</a> <strong>task</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task`1</a> method to execute</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.async.AsyncManager.T</dt><dd>Return value ot the task</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>task</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu" />  AsyncManager.ExclusiveSynchronizationContext Class ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


&quot;Private&quot; synchronization context used to run the async method



```csharp
private class AsyncManager.ExclusiveSynchronizationContext : SynchronizationContext
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext" target="_blank" >System.Threading.SynchronizationContext</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [done](#f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.done__1ogbce6) | private |  | 
 | [items](#f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.items__f5et9q) | private |  | 
 | [workItemsWaiting](#f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.workitemswaiting__9nlexs) | private |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [InnerException](#p-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.innerexception__1hzeemf) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BeginMessageLoop()](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.beginmessageloop__xkfq9n) | public | Starts the message loop | 
 | [CreateCopy()](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.createcopy__1vp2evu) | public | Creates a &quot;copy&quot; of the synchronization context. | 
 | [EndMessageLoop()](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.endmessageloop__oqnlxn) | public | Finish the message loop | 
 | [Post(SendOrPostCallback, object)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.post_system.threading.sendorpostcallback-system.object___850uof) | public | Dispatches an asynchronous message to a synchronization context. | 
 | [Send(SendOrPostCallback, object)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.send_system.threading.sendorpostcallback-system.object___b8nnwz) | public | Dispatches a synchronous message to a synchronization context. Always throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a> as it&#39;s not supported in [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.done__1ogbce6" />  AsyncManager.ExclusiveSynchronizationContext.done Field ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>



```csharp
private bool done
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.items__f5et9q" />  AsyncManager.ExclusiveSynchronizationContext.items Field ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>



```csharp
private readonly Queue<System.Tuple<System.Threading.SendOrPostCallback,object>> items
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1" target="_blank" >Queue&lt;System.Tuple&lt;System.Threading.SendOrPostCallback,object&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.workitemswaiting__9nlexs" />  AsyncManager.ExclusiveSynchronizationContext.workItemsWaiting Field ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>



```csharp
private readonly AutoResetEvent workItemsWaiting
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent" target="_blank" >System.Threading.AutoResetEvent</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.innerexception__1hzeemf" />  AsyncManager.ExclusiveSynchronizationContext.InnerException Property ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>



```csharp
public Exception InnerException { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.beginmessageloop__xkfq9n" />  AsyncManager.ExclusiveSynchronizationContext.BeginMessageLoop() Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Starts the message loop



```csharp
public void BeginMessageLoop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.createcopy__1vp2evu" />  AsyncManager.ExclusiveSynchronizationContext.CreateCopy() Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Creates a &quot;copy&quot; of the synchronization context.



```csharp
public override SynchronizationContext CreateCopy()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext" target="_blank" >System.Threading.SynchronizationContext</a></dt><dd>Current <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext" target="_blank" >System.Threading.SynchronizationContext</a> object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext.createcopy#System_Threading_SynchronizationContext_CreateCopy" target="_blank" >Threading.SynchronizationContext.CreateCopy</a>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.endmessageloop__oqnlxn" />  AsyncManager.ExclusiveSynchronizationContext.EndMessageLoop() Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Finish the message loop



```csharp
public void EndMessageLoop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.post_system.threading.sendorpostcallback-system.object___850uof" />  AsyncManager.ExclusiveSynchronizationContext.Post(SendOrPostCallback, object) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Dispatches an asynchronous message to a synchronization context.



```csharp
public override void Post(SendOrPostCallback d, object state)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.sendorpostcallback" target="_blank" >System.Threading.SendOrPostCallback</a> <strong>d</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.sendorpostcallback" target="_blank" >System.Threading.SendOrPostCallback</a> delegate to call.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>state</strong></dt><dd>The object passed to the delegate.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext.post#System_Threading_SynchronizationContext_Post_System_Threading_SendOrPostCallback_System_Object_" target="_blank" >Threading.SynchronizationContext.Post</a>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.send_system.threading.sendorpostcallback-system.object___b8nnwz" />  AsyncManager.ExclusiveSynchronizationContext.Send(SendOrPostCallback, object) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)           
Sources: async\AsyncManager.cs           
Source-only packages: [RadCommons.async.AsyncManager](#src-only-package--RadCommons.async.AsyncManager)</small>


Dispatches a synchronous message to a synchronization context. Always throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a> as it&#39;s not supported in [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)



```csharp
public override void Send(SendOrPostCallback d, object state)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.sendorpostcallback" target="_blank" >System.Threading.SendOrPostCallback</a> <strong>d</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.sendorpostcallback" target="_blank" >System.Threading.SendOrPostCallback</a> delegate to call.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>state</strong></dt><dd>The object passed to the delegate.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext.send#System_Threading_SynchronizationContext_Send_System_Threading_SendOrPostCallback_System_Object_" target="_blank" >Threading.SynchronizationContext.Send</a>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a></dt><dd>The implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext" target="_blank" >System.Threading.SynchronizationContext</a> does not support the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext.send#System_Threading_SynchronizationContext_Send_System_Threading_SendOrPostCallback_System_Object_" target="_blank" >System.Threading.SynchronizationContext.Send(System.Threading.SendOrPostCallback,System.Object)</a> method.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.async.fileasync__158f1hu" />  FileAsync Class ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


Asynchronous text/lines file read methods https://stackoverflow.com/a/13168006



```csharp
internal static class FileAsync
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [DefaultBufferSize](#f-net.adamec.lib.common.async.fileasync.defaultbuffersize__1n8kkos) | 4096 | This is the same default buffer size as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader" target="_blank" >System.IO.StreamReader</a> and <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream" target="_blank" >System.IO.FileStream</a> . | 
 | [DefaultOptions](#f-net.adamec.lib.common.async.fileasync.defaultoptions__bsw6k3) | 1207959552 | Indicates that 1. The file is to be used for asynchronous reading. 2. The file is to be accessed sequentially from beginning to end. | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ReadAllLinesAsync(string)](#m-net.adamec.lib.common.async.fileasync.readalllinesasync_system.string___lhe54c) | public static | Opens a text file, reads all lines of the file, and then closes the file. | 
 | [ReadAllLinesAsync(string, Encoding)](#m-net.adamec.lib.common.async.fileasync.readalllinesasync_system.string-system.text.encoding___ktl1mr) | public static | Opens a file, reads all lines of the file with the specified encoding, and then closes the file. | 
 | [ReadAllTextAsync(string)](#m-net.adamec.lib.common.async.fileasync.readalltextasync_system.string___1piiha4) | public static | Opens a text file, reads all lines of the file, and then closes the file. | 
 | [ReadAllTextAsync(string, Encoding)](#m-net.adamec.lib.common.async.fileasync.readalltextasync_system.string-system.text.encoding___yqlzqn) | public static | Opens a file, reads all lines of the file with the specified encoding, and then closes the file. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.async.fileasync.defaultbuffersize__1n8kkos" />  FileAsync.DefaultBufferSize Constant ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu)           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


This is the same default buffer size as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader" target="_blank" >System.IO.StreamReader</a> and <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream" target="_blank" >System.IO.FileStream</a> .



```csharp
private const int DefaultBufferSize = 4096
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.async.fileasync.defaultoptions__bsw6k3" />  FileAsync.DefaultOptions Constant ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu)           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


Indicates that 1. The file is to be used for asynchronous reading. 2. The file is to be accessed sequentially from beginning to end.



```csharp
private const FileOptions DefaultOptions = 1207959552
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.fileoptions" target="_blank" >System.IO.FileOptions</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.fileasync.readalllinesasync_system.string___lhe54c" />  FileAsync.ReadAllLinesAsync(string) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu)           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


Opens a text file, reads all lines of the file, and then closes the file.



```csharp
public static Task<string[]> ReadAllLinesAsync(string path)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>path</strong></dt><dd>The file to open for reading.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;string[]&gt;</a></dt><dd>A string array containing all lines of the file.</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception" target="_blank" >System.IO.FileNotFoundException</a></dt><dd>The file cannot be found, such as when mode is FileMode.Truncate or FileMode.Open, and the file specified by <strong>path</strong> does not exist. The file must already exist in these modes.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.ioexception" target="_blank" >System.IO.IOException</a></dt><dd>An I/O error, such as specifying FileMode.CreateNew when the file specified by <strong>path</strong> already exists, occurred.-or-The stream has been closed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.security.securityexception" target="_blank" >System.Security.SecurityException</a></dt><dd>The caller does not have the required permission.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.directorynotfoundexception" target="_blank" >System.IO.DirectoryNotFoundException</a></dt><dd>The specified path is invalid, such as being on an unmapped drive.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception" target="_blank" >System.UnauthorizedAccessException</a></dt><dd>The access requested is not permitted by the operating system for the specified <strong>path</strong> , such as when access is Write or ReadWrite and the file or directory is set for read-only access. -or- <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.fileoptions.encrypted#System_IO_FileOptions_Encrypted" target="_blank" >System.IO.FileOptions.Encrypted</a> is specified for options, but file encryption is not supported on the current platform.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>path</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>path</strong> is an empty string (&quot;&quot;), contains only white space, or contains one or more invalid characters. -or- <strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in an NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a></dt><dd><strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in a non-NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception" target="_blank" >System.ArgumentOutOfRangeException</a></dt><dd>bufferSize is negative or zero.-or- mode, access, or share contain an invalid value.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.pathtoolongexception" target="_blank" >System.IO.PathTooLongException</a></dt><dd>The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The stream has been disposed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>The reader is currently in use by a previous read operation.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.fileasync.readalllinesasync_system.string-system.text.encoding___ktl1mr" />  FileAsync.ReadAllLinesAsync(string, Encoding) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu)           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


Opens a file, reads all lines of the file with the specified encoding, and then closes the file.



```csharp
public static async Task<string[]> ReadAllLinesAsync(string path, Encoding encoding)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>path</strong></dt><dd>The file to open for reading.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding" target="_blank" >System.Text.Encoding</a> <strong>encoding</strong></dt><dd>The encoding applied to the contents of the file.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;string[]&gt;</a></dt><dd>A string array containing all lines of the file.</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception" target="_blank" >System.IO.FileNotFoundException</a></dt><dd>The file cannot be found, such as when mode is FileMode.Truncate or FileMode.Open, and the file specified by <strong>path</strong> does not exist. The file must already exist in these modes.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.ioexception" target="_blank" >System.IO.IOException</a></dt><dd>An I/O error, such as specifying FileMode.CreateNew when the file specified by <strong>path</strong> already exists, occurred.-or-The stream has been closed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.security.securityexception" target="_blank" >System.Security.SecurityException</a></dt><dd>The caller does not have the required permission.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.directorynotfoundexception" target="_blank" >System.IO.DirectoryNotFoundException</a></dt><dd>The specified path is invalid, such as being on an unmapped drive.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception" target="_blank" >System.UnauthorizedAccessException</a></dt><dd>The access requested is not permitted by the operating system for the specified <strong>path</strong> , such as when access is Write or ReadWrite and the file or directory is set for read-only access. -or- <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.fileoptions.encrypted#System_IO_FileOptions_Encrypted" target="_blank" >System.IO.FileOptions.Encrypted</a> is specified for options, but file encryption is not supported on the current platform.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>path</strong> or <strong>encoding</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>path</strong> is an empty string (&quot;&quot;), contains only white space, or contains one or more invalid characters. -or- <strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in an NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a></dt><dd><strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in a non-NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception" target="_blank" >System.ArgumentOutOfRangeException</a></dt><dd>bufferSize is negative or zero.-or- mode, access, or share contain an invalid value.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.pathtoolongexception" target="_blank" >System.IO.PathTooLongException</a></dt><dd>The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The stream has been disposed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>The reader is currently in use by a previous read operation.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.fileasync.readalltextasync_system.string___1piiha4" />  FileAsync.ReadAllTextAsync(string) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu)           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


Opens a text file, reads all lines of the file, and then closes the file.



```csharp
public static Task<string> ReadAllTextAsync(string path)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>path</strong></dt><dd>The file to open for reading.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;string&gt;</a></dt><dd>A string containing all lines of the file.</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception" target="_blank" >System.IO.FileNotFoundException</a></dt><dd>The file cannot be found, such as when mode is FileMode.Truncate or FileMode.Open, and the file specified by <strong>path</strong> does not exist. The file must already exist in these modes.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.ioexception" target="_blank" >System.IO.IOException</a></dt><dd>An I/O error, such as specifying FileMode.CreateNew when the file specified by <strong>path</strong> already exists, occurred.-or-The stream has been closed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.security.securityexception" target="_blank" >System.Security.SecurityException</a></dt><dd>The caller does not have the required permission.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.directorynotfoundexception" target="_blank" >System.IO.DirectoryNotFoundException</a></dt><dd>The specified path is invalid, such as being on an unmapped drive.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception" target="_blank" >System.UnauthorizedAccessException</a></dt><dd>The access requested is not permitted by the operating system for the specified <strong>path</strong> , such as when access is Write or ReadWrite and the file or directory is set for read-only access. -or- <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.fileoptions.encrypted#System_IO_FileOptions_Encrypted" target="_blank" >System.IO.FileOptions.Encrypted</a> is specified for options, but file encryption is not supported on the current platform.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>path</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>path</strong> is an empty string (&quot;&quot;), contains only white space, or contains one or more invalid characters. -or- <strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in an NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a></dt><dd><strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in a non-NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception" target="_blank" >System.ArgumentOutOfRangeException</a></dt><dd>bufferSize is negative or zero.-or- mode, access, or share contain an invalid value.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.pathtoolongexception" target="_blank" >System.IO.PathTooLongException</a></dt><dd>The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The stream has been disposed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>The reader is currently in use by a previous read operation.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.async.fileasync.readalltextasync_system.string-system.text.encoding___yqlzqn" />  FileAsync.ReadAllTextAsync(string, Encoding) Method ##
<small>Namespace: [net.adamec.lib.common.async](#n-net.adamec.lib.common.async__17zxv10)           
Assembly: net.adamec.lib.common           
Type: [FileAsync](#t-net.adamec.lib.common.async.fileasync__158f1hu)           
Sources: async\FileAsync.cs           
Source-only packages: [RadCommons.async.FileAsync](#src-only-package--RadCommons.async.FileAsync)</small>


Opens a file, reads all lines of the file with the specified encoding, and then closes the file.



```csharp
public static async Task<string> ReadAllTextAsync(string path, Encoding encoding)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>path</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding" target="_blank" >System.Text.Encoding</a> <strong>encoding</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;string&gt;</a></dt><dd>A string containing all lines of the file.</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception" target="_blank" >System.IO.FileNotFoundException</a></dt><dd>The file cannot be found, such as when mode is FileMode.Truncate or FileMode.Open, and the file specified by <strong>path</strong> does not exist. The file must already exist in these modes.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.ioexception" target="_blank" >System.IO.IOException</a></dt><dd>An I/O error, such as specifying FileMode.CreateNew when the file specified by <strong>path</strong> already exists, occurred.-or-The stream has been closed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.security.securityexception" target="_blank" >System.Security.SecurityException</a></dt><dd>The caller does not have the required permission.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.directorynotfoundexception" target="_blank" >System.IO.DirectoryNotFoundException</a></dt><dd>The specified path is invalid, such as being on an unmapped drive.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception" target="_blank" >System.UnauthorizedAccessException</a></dt><dd>The access requested is not permitted by the operating system for the specified <strong>path</strong> , such as when access is Write or ReadWrite and the file or directory is set for read-only access. -or- <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.fileoptions.encrypted#System_IO_FileOptions_Encrypted" target="_blank" >System.IO.FileOptions.Encrypted</a> is specified for options, but file encryption is not supported on the current platform.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>path</strong> or <strong>encoding</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>path</strong> is an empty string (&quot;&quot;), contains only white space, or contains one or more invalid characters. -or- <strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in an NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a></dt><dd><strong>path</strong> refers to a non-file device, such as &quot;con:&quot;, &quot;com1:&quot;, &quot;lpt1:&quot;, etc. in a non-NTFS environment.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception" target="_blank" >System.ArgumentOutOfRangeException</a></dt><dd>bufferSize is negative or zero.-or- mode, access, or share contain an invalid value.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.pathtoolongexception" target="_blank" >System.IO.PathTooLongException</a></dt><dd>The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The stream has been disposed.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>The reader is currently in use by a previous read operation.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.di.component__9w6ndu" />  net.adamec.lib.common.di.component Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) | public | Marks the decorated class as a component that will be available from the service locator / component container. | 
 | [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y) | internal static | Autofac <em>Autofac.ContainerBuilder</em> extensions | 
 | [NamedComponentRegistrationAttribute](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr) | public | Defines the registration name and type for named registration (component type will be used if null) | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo) | public | Kind of the implicit component registration | 
 | [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps) | public | Component scope | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.component.componentattribute__170qqzl" />  ComponentAttribute Class ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Marks the decorated class as a component that will be available from the service locator / component container.



```csharp
[AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
public class ComponentAttribute : Attribute
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attribute" target="_blank" >Attribute</a>           
Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attributeusageattribute" target="_blank" >System.AttributeUsageAttribute</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ImplicitRegistrationType](#p-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtype__1mysue9) | public | Flag how to do the implicit registration when no types are explicitly defined | 
 | [RegisterAs](#p-net.adamec.lib.common.di.component.componentattribute.registeras__1m8nlcq) | public | Type to use for the component registration. | 
 | [Scope](#p-net.adamec.lib.common.di.component.componentattribute.scope__1h6i43p) | public | Defines the instance scope | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ComponentAttribute(ComponentAttribute.ImplicitRegistrationTypeEnum, ComponentAttribute.ScopeEnum)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum-net.adamec.lib.common.di.component.componentattribute.scopeenum___ex53ua) | public | Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container, registered as the concrete type or with all implemented interfaces as well if specified. | 
 | [ComponentAttribute(Type, ComponentAttribute.ScopeEnum)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type-net.adamec.lib.common.di.component.componentattribute.scopeenum___1ubqgal) | public | Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> type. | 
 | [ComponentAttribute(Type[], ComponentAttribute.ScopeEnum)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type__-net.adamec.lib.common.di.component.componentattribute.scopeenum___1rdjiuf) | public | Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> types. | 
 | [ComponentAttribute(Type[], net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum?, ComponentAttribute.ScopeEnum)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type__-system.nullable_net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum_-net.adamec.lib.common.di.component.componentattribute.scopeenum___1h4ujev) | private | Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> types. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtype__1mysue9" />  ComponentAttribute.ImplicitRegistrationType Property ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Flag how to do the implicit registration when no types are explicitly defined



```csharp
public net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum? ImplicitRegistrationType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1" target="_blank" >net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum?</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.component.componentattribute.registeras__1m8nlcq" />  ComponentAttribute.RegisterAs Property ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Type to use for the component registration.



```csharp
public Type[] RegisterAs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type[]</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.component.componentattribute.scope__1h6i43p" />  ComponentAttribute.Scope Property ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Defines the instance scope



```csharp
public ComponentAttribute.ScopeEnum Scope { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.componentattribute.-ctor_net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum-net.adamec.lib.common.di.component.componentattribute.scopeenum___ex53ua" />  ComponentAttribute.ComponentAttribute(ComponentAttribute.ImplicitRegistrationTypeEnum, ComponentAttribute.ScopeEnum) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container, registered as the concrete type or with all implemented interfaces as well if specified.



```csharp
public ComponentAttribute(ComponentAttribute.ImplicitRegistrationTypeEnum implicitRegistrationType = 0, ComponentAttribute.ScopeEnum scope = 0)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo) <strong>implicitRegistrationType</strong></dt><dd>Flag how to do the implicit registration when no types are explicitly defined</dd><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps) <strong>scope</strong></dt><dd>The instance scope</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type-net.adamec.lib.common.di.component.componentattribute.scopeenum___1ubqgal" />  ComponentAttribute.ComponentAttribute(Type, ComponentAttribute.ScopeEnum) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> type.



```csharp
public ComponentAttribute(Type registerAs, ComponentAttribute.ScopeEnum scope = 0)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>registerAs</strong></dt><dd>The type to use to register the decorated component.</dd><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps) <strong>scope</strong></dt><dd>The instance scope</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type__-net.adamec.lib.common.di.component.componentattribute.scopeenum___1rdjiuf" />  ComponentAttribute.ComponentAttribute(Type[], ComponentAttribute.ScopeEnum) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> types.



```csharp
public ComponentAttribute(Type[] registerAs, ComponentAttribute.ScopeEnum scope = 0)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type[]</a> <strong>registerAs</strong></dt><dd>The type to use to register the decorated component.</dd><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps) <strong>scope</strong></dt><dd>The instance scope</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type__-system.nullable_net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum_-net.adamec.lib.common.di.component.componentattribute.scopeenum___1h4ujev" />  ComponentAttribute.ComponentAttribute(Type[], net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum?, ComponentAttribute.ScopeEnum) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> types.



```csharp
private ComponentAttribute(Type[] registerAs = null, net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum? implicitRegistrationType = 2, ComponentAttribute.ScopeEnum scope = 0)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type[]</a> <strong>registerAs</strong></dt><dd>The type to use to register the decorated component.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1" target="_blank" >net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum?</a> <strong>implicitRegistrationType</strong></dt><dd>Flag how to do the implicit registration when no types are explicitly defined</dd><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps) <strong>scope</strong></dt><dd>The instance scope</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y" />  ContainerBuilderExtensions Class ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Sources: di\component\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Autofac <em>Autofac.ContainerBuilder</em> extensions



```csharp
internal static class ContainerBuilderExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddServicesWithComponentAttribute(ContainerBuilder, Assembly[])](#m-net.adamec.lib.common.di.component.containerbuilderextensions.addserviceswithcomponentattribute_autofac.containerbuilder-system.reflection.assembly_____5belzz) | public static | Adds classes from the <strong>assemblies</strong> having the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) into Autofac container <strong>builder</strong> | 
 | [AddServicesWithComponentAttribute(ContainerBuilder, Type[])](#m-net.adamec.lib.common.di.component.containerbuilderextensions.addserviceswithcomponentattribute_autofac.containerbuilder-system.type_____zsnrga) | public static | Adds classes from array of <strong>types</strong> having the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) into Autofac container <strong>builder</strong> | 
 | [GetImplementedInterfaces(Type)](#m-net.adamec.lib.common.di.component.containerbuilderextensions.getimplementedinterfaces_system.type___vb1m0d) | private static | Gets the array of interfaces implemented by given <strong>type</strong> except the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> interface | 
 | [Register&lt;TLimit,TActivatorData,TRegistrationStyle&gt;(IRegistrationBuilder&lt;TLimit,TActivatorData,TRegistrationStyle&gt;, Type, ComponentAttribute)](#m-net.adamec.lib.common.di.component.containerbuilderextensions.register--3_autofac.builder.iregistrationbuilder_--0---1---2_-system.type-net.adamec.lib.common.di.component.componentattribute___9sj1q8) | private static | Registers the <strong>type</strong> with <strong>componentAttribute</strong> using the Autofac container <strong>builder</strong> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.containerbuilderextensions.addserviceswithcomponentattribute_autofac.containerbuilder-system.reflection.assembly_____5belzz" />  ContainerBuilderExtensions.AddServicesWithComponentAttribute(ContainerBuilder, Assembly[]) Method ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y)           
Sources: di\component\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Adds classes from the <strong>assemblies</strong> having the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) into Autofac container <strong>builder</strong>



```csharp
public static void AddServicesWithComponentAttribute(this ContainerBuilder builder, params Assembly[] assemblies)
```

<strong>Method parameters</strong><dl><dt>Autofac.ContainerBuilder <strong>builder</strong></dt><dd>Autofac container builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly" target="_blank" >System.Reflection.Assembly[]</a> <strong>assemblies</strong></dt><dd>Assemblies to check the classes for the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>builder</strong> or <strong>assemblies</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.containerbuilderextensions.addserviceswithcomponentattribute_autofac.containerbuilder-system.type_____zsnrga" />  ContainerBuilderExtensions.AddServicesWithComponentAttribute(ContainerBuilder, Type[]) Method ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y)           
Sources: di\component\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Adds classes from array of <strong>types</strong> having the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) into Autofac container <strong>builder</strong>



```csharp
public static void AddServicesWithComponentAttribute(this ContainerBuilder builder, params Type[] types)
```

<strong>Method parameters</strong><dl><dt>Autofac.ContainerBuilder <strong>builder</strong></dt><dd>Autofac container builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type[]</a> <strong>types</strong></dt><dd>Array of types to check the classes for the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>builder</strong> or <strong>types</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.containerbuilderextensions.getimplementedinterfaces_system.type___vb1m0d" />  ContainerBuilderExtensions.GetImplementedInterfaces(Type) Method ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y)           
Sources: di\component\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Gets the array of interfaces implemented by given <strong>type</strong> except the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> interface



```csharp
private static Type[] GetImplementedInterfaces(Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to check</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type[]</a></dt><dd>Array of interfaces implemented by given <strong>type</strong> except the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> interface</dd></dl>


###  Remarks ###
When the <strong>type</strong> itself is an interface, it&#39;s added to the returned list.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>type</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.containerbuilderextensions.register--3_autofac.builder.iregistrationbuilder_--0---1---2_-system.type-net.adamec.lib.common.di.component.componentattribute___9sj1q8" />  ContainerBuilderExtensions.Register&lt;TLimit,TActivatorData,TRegistrationStyle&gt;(IRegistrationBuilder&lt;TLimit,TActivatorData,TRegistrationStyle&gt;, Type, ComponentAttribute) Method ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y)           
Sources: di\component\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Registers the <strong>type</strong> with <strong>componentAttribute</strong> using the Autofac container <strong>builder</strong>



```csharp
private static void Register<TLimit, TActivatorData, TRegistrationStyle>(IRegistrationBuilder<TLimit,TActivatorData,TRegistrationStyle> builder, Type type, ComponentAttribute componentAttribute)
```

<strong>Type parameters</strong><dl><dt><strong>TLimit</strong></dt><dd>Registration limit type.</dd><dt><strong>TActivatorData</strong></dt><dd>Activator data type.</dd><dt><strong>TRegistrationStyle</strong></dt><dd>Registration style.</dd></dl>
<strong>Method parameters</strong><dl><dt>Autofac.Builder.IRegistrationBuilder&lt;TLimit,TActivatorData,TRegistrationStyle&gt; <strong>builder</strong></dt><dd>Autofac container builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to register</dd><dt>[net.adamec.lib.common.di.component.ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) <strong>componentAttribute</strong></dt><dd>[ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) of given <strong>type</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>builder</strong> , <strong>type</strong> or <strong>componentAttribute</strong> is `null`</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr" />  NamedComponentRegistrationAttribute Class ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Sources: di\component\NamedComponentRegistrationAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Defines the registration name and type for named registration (component type will be used if null)



```csharp
[AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
public class NamedComponentRegistrationAttribute : Attribute
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attribute" target="_blank" >Attribute</a>           
Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attributeusageattribute" target="_blank" >System.AttributeUsageAttribute</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](#p-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.name__12kb1kq) | public | Registration name | 
 | [Type](#p-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.type__1egg26x) | public | Registrations type for named registration. Component type will be used if null | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NamedComponentRegistrationAttribute(string)](#m-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.-ctor_system.string___15ni23w) | public | Named registration with component type used | 
 | [NamedComponentRegistrationAttribute(string, Type)](#m-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.-ctor_system.string-system.type___1m420ct) | public | Defines the registration name and type for named registration (component type will be used if null) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.name__12kb1kq" />  NamedComponentRegistrationAttribute.Name Property ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [NamedComponentRegistrationAttribute](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr)           
Sources: di\component\NamedComponentRegistrationAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Registration name



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.type__1egg26x" />  NamedComponentRegistrationAttribute.Type Property ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [NamedComponentRegistrationAttribute](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr)           
Sources: di\component\NamedComponentRegistrationAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Registrations type for named registration. Component type will be used if null



```csharp
public Type Type { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.-ctor_system.string___15ni23w" />  NamedComponentRegistrationAttribute.NamedComponentRegistrationAttribute(string) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [NamedComponentRegistrationAttribute](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr)           
Sources: di\component\NamedComponentRegistrationAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Named registration with component type used



```csharp
public NamedComponentRegistrationAttribute(string name)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Registration name</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.-ctor_system.string-system.type___1m420ct" />  NamedComponentRegistrationAttribute.NamedComponentRegistrationAttribute(string, Type) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [NamedComponentRegistrationAttribute](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr)           
Sources: di\component\NamedComponentRegistrationAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Defines the registration name and type for named registration (component type will be used if null)



```csharp
public NamedComponentRegistrationAttribute(string name, Type type)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Registration name</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Registrations type for named registration. Component type will be used if null</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo" />  ComponentAttribute.ImplicitRegistrationTypeEnum Enum ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Kind of the implicit component registration



```csharp
public enum ComponentAttribute.ImplicitRegistrationTypeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Self](#f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.self__qkcsxq) | 0 | Register as self (type) only | 
 | [ImplementedInterfaces](#f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.implementedinterfaces__n5lxu0) | 1 | Register as all implemented interfaces | 
 | [SelfAndImplementedInterfaces](#f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.selfandimplementedinterfaces__1135ahd) | 2 | Register as self (type) and all implemented interfaces | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.implementedinterfaces__n5lxu0" />  ComponentAttribute.ImplicitRegistrationTypeEnum.ImplementedInterfaces Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Register as all implemented interfaces



```csharp
 ImplementedInterfaces = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.self__qkcsxq" />  ComponentAttribute.ImplicitRegistrationTypeEnum.Self Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Register as self (type) only



```csharp
 Self = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.selfandimplementedinterfaces__1135ahd" />  ComponentAttribute.ImplicitRegistrationTypeEnum.SelfAndImplementedInterfaces Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Register as self (type) and all implemented interfaces



```csharp
 SelfAndImplementedInterfaces = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps" />  ComponentAttribute.ScopeEnum Enum ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Component scope



```csharp
public enum ComponentAttribute.ScopeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [InstancePerDependency](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperdependency__1efcen7) | 0 | Transient scope (instance per dependency) | 
 | [Transient](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.transient__1f6925u) | 0 | Transient scope (instance per dependency) | 
 | [SingleInstance](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.singleinstance__st19r1) | 1 | Singleton | 
 | [Singleton](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.singleton__1p12io5) | 1 | Singleton | 
 | [InstancePerLifetimeScope](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperlifetimescope__17fxlux) | 2 | Instance per lifetime scope | 
 | [InstancePerRequest](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperrequest__12s64w1) | 3 | Instance per request (scoped) | 
 | [Scoped](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.scoped__1356nu4) | 3 | Instance per request (scoped) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperdependency__1efcen7" />  ComponentAttribute.ScopeEnum.InstancePerDependency Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Transient scope (instance per dependency)



```csharp
 InstancePerDependency = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperlifetimescope__17fxlux" />  ComponentAttribute.ScopeEnum.InstancePerLifetimeScope Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Instance per lifetime scope



```csharp
 InstancePerLifetimeScope = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperrequest__12s64w1" />  ComponentAttribute.ScopeEnum.InstancePerRequest Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Instance per request (scoped)



```csharp
 InstancePerRequest = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.scoped__1356nu4" />  ComponentAttribute.ScopeEnum.Scoped Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Instance per request (scoped)



```csharp
 Scoped = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.singleinstance__st19r1" />  ComponentAttribute.ScopeEnum.SingleInstance Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Singleton



```csharp
 SingleInstance = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.singleton__1p12io5" />  ComponentAttribute.ScopeEnum.Singleton Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Singleton



```csharp
 Singleton = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.di.component.componentattribute.scopeenum.transient__1f6925u" />  ComponentAttribute.ScopeEnum.Transient Constant ##
<small>Namespace: [net.adamec.lib.common.di.component](#n-net.adamec.lib.common.di.component__9w6ndu)           
Assembly: net.adamec.lib.common           
Type: [ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)           
Sources: di\component\ComponentAttribute.cs           
Source-only packages: [RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</small>


Transient scope (instance per dependency)



```csharp
 Transient = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.di.component.ComponentAttribute.ScopeEnum](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.di.config__3709lb" />  net.adamec.lib.common.di.config Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) | public | Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2" />  AutoOptionsAttribute Class ##
<small>Namespace: [net.adamec.lib.common.di.config](#n-net.adamec.lib.common.di.config__3709lb)           
Assembly: net.adamec.lib.common           
Sources: di\config\AutoOptionsAttribute.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI



```csharp
[AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
public class AutoOptionsAttribute : Attribute
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attribute" target="_blank" >Attribute</a>           
Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attributeusageattribute" target="_blank" >System.AttributeUsageAttribute</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConfigSection](#p-net.adamec.lib.common.di.config.autooptionsattribute.configsection__zo6f6l) | public | Path to the section within appsettings.json | 
 | [RegisterDirect](#p-net.adamec.lib.common.di.config.autooptionsattribute.registerdirect__1s9s1yk) | public | Flag whether to create and registers the options class instance into MS DI | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AutoOptionsAttribute(string, bool)](#m-net.adamec.lib.common.di.config.autooptionsattribute.-ctor_system.string-system.boolean___1nw898o) | public | Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.config.autooptionsattribute.configsection__zo6f6l" />  AutoOptionsAttribute.ConfigSection Property ##
<small>Namespace: [net.adamec.lib.common.di.config](#n-net.adamec.lib.common.di.config__3709lb)           
Assembly: net.adamec.lib.common           
Type: [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2)           
Sources: di\config\AutoOptionsAttribute.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Path to the section within appsettings.json



```csharp
public string ConfigSection { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.di.config.autooptionsattribute.registerdirect__1s9s1yk" />  AutoOptionsAttribute.RegisterDirect Property ##
<small>Namespace: [net.adamec.lib.common.di.config](#n-net.adamec.lib.common.di.config__3709lb)           
Assembly: net.adamec.lib.common           
Type: [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2)           
Sources: di\config\AutoOptionsAttribute.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Flag whether to create and registers the options class instance into MS DI



```csharp
public bool RegisterDirect { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.autooptionsattribute.-ctor_system.string-system.boolean___1nw898o" />  AutoOptionsAttribute.AutoOptionsAttribute(string, bool) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config](#n-net.adamec.lib.common.di.config__3709lb)           
Assembly: net.adamec.lib.common           
Type: [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2)           
Sources: di\config\AutoOptionsAttribute.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI



```csharp
public AutoOptionsAttribute(string configSection, bool registerDirect = false)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>configSection</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>registerDirect</strong></dt><dd></dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>configSection</strong> is `null`</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.di.config.exception__15nr03q" />  net.adamec.lib.common.di.config.exception Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh) | public | Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionAutoOptionsExtension</em> | 
 | [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj) | public | Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionConfigureDirectExtensions</em> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh" />  ServiceCollectionAutoOptionsException Class ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Sources: di\config\exception\ServiceCollectionAutoOptionsException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionAutoOptionsExtension</em>



```csharp
public class ServiceCollectionAutoOptionsException : Exception
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ServiceCollectionAutoOptionsException()](#m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor__o6ojyb) | public | Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh) | 
 | [ServiceCollectionAutoOptionsException(string)](#m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor_system.string___1kcodie) | public | Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh) | 
 | [ServiceCollectionAutoOptionsException(string, Exception)](#m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor_system.string-system.exception___r0rfi6) | public | Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor__o6ojyb" />  ServiceCollectionAutoOptionsException.ServiceCollectionAutoOptionsException() Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)           
Sources: di\config\exception\ServiceCollectionAutoOptionsException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)



```csharp
public ServiceCollectionAutoOptionsException()
```

Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor_system.string___1kcodie" />  ServiceCollectionAutoOptionsException.ServiceCollectionAutoOptionsException(string) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)           
Sources: di\config\exception\ServiceCollectionAutoOptionsException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)



```csharp
public ServiceCollectionAutoOptionsException(string message)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor_system.string-system.exception___r0rfi6" />  ServiceCollectionAutoOptionsException.ServiceCollectionAutoOptionsException(string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)           
Sources: di\config\exception\ServiceCollectionAutoOptionsException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)



```csharp
public ServiceCollectionAutoOptionsException(string message, Exception inner)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>inner</strong></dt><dd>Inner exception</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj" />  ServiceCollectionConfigureDirectException Class ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Sources: di\config\exception\ServiceCollectionConfigureDirectException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionConfigureDirectExtensions</em>



```csharp
public class ServiceCollectionConfigureDirectException : Exception
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ServiceCollectionConfigureDirectException()](#m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor__1n8hr1d) | public | Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj) | 
 | [ServiceCollectionConfigureDirectException(string)](#m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor_system.string___1dp1v34) | public | Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj) | 
 | [ServiceCollectionConfigureDirectException(string, Exception)](#m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor_system.string-system.exception___1uv85c8) | public | Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor__1n8hr1d" />  ServiceCollectionConfigureDirectException.ServiceCollectionConfigureDirectException() Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)           
Sources: di\config\exception\ServiceCollectionConfigureDirectException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)



```csharp
public ServiceCollectionConfigureDirectException()
```

Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor_system.string___1dp1v34" />  ServiceCollectionConfigureDirectException.ServiceCollectionConfigureDirectException(string) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)           
Sources: di\config\exception\ServiceCollectionConfigureDirectException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)



```csharp
public ServiceCollectionConfigureDirectException(string message)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor_system.string-system.exception___1uv85c8" />  ServiceCollectionConfigureDirectException.ServiceCollectionConfigureDirectException(string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.di.config.exception](#n-net.adamec.lib.common.di.config.exception__15nr03q)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)           
Sources: di\config\exception\ServiceCollectionConfigureDirectException.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)



```csharp
public ServiceCollectionConfigureDirectException(string message, Exception inner)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>inner</strong></dt><dd>Inner exception</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.di.config.extensions__1bjxl1v" />  net.adamec.lib.common.di.config.extensions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7) | internal static | Autofac <em>Autofac.ContainerBuilder</em> extensions | 
 | [ServiceCollectionAutoOptionsExtension](#t-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension__1p9fgao) | internal static | Extensions for options (configuration) class automatic binding to appsettings.json | 
 | [ServiceCollectionConfigureDirectExtensions](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv) | internal static | Extensions for options (configuration) class registration into MS DI | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7" />  ContainerBuilderExtensions Class ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Sources: di\config\extensions\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Autofac <em>Autofac.ContainerBuilder</em> extensions



```csharp
internal static class ContainerBuilderExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddAutoOptions(ContainerBuilder, IConfigurationRoot, Assembly[])](#m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addautooptions_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.reflection.assembly_____pfqod1) | public static | Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect. This is to be used if not registered via MS ServiceCollection extensions | 
 | [AddAutoOptions(ContainerBuilder, IConfigurationRoot, Type[])](#m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addautooptions_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.type_____1fbl63e) | public static | Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect. This is to be used if not registered via MS ServiceCollection extensions | 
 | [AddOptions&lt;TOptions&gt;(ContainerBuilder, IConfigurationRoot, string)](#m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addoptions--1_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.string___1b2rpkf) | public static | Creates and registers the singleton of configuration (options) class of given type This is to be used if not registered using the [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addautooptions_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.reflection.assembly_____pfqod1" />  ContainerBuilderExtensions.AddAutoOptions(ContainerBuilder, IConfigurationRoot, Assembly[]) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7)           
Sources: di\config\extensions\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect. This is to be used if not registered via MS ServiceCollection extensions



```csharp
public static void AddAutoOptions(this ContainerBuilder builder, IConfigurationRoot configuration, params Assembly[] assemblies)
```

<strong>Method parameters</strong><dl><dt>Autofac.ContainerBuilder <strong>builder</strong></dt><dd>AutoFac container builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfigurationroot" target="_blank" >Microsoft.Extensions.Configuration.IConfigurationRoot</a> <strong>configuration</strong></dt><dd>Configuration container</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly" target="_blank" >System.Reflection.Assembly[]</a> <strong>assemblies</strong></dt><dd>Assemblies to check</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>configuration</strong> or <strong>assemblies</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addautooptions_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.type_____1fbl63e" />  ContainerBuilderExtensions.AddAutoOptions(ContainerBuilder, IConfigurationRoot, Type[]) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7)           
Sources: di\config\extensions\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect. This is to be used if not registered via MS ServiceCollection extensions



```csharp
public static void AddAutoOptions(this ContainerBuilder builder, IConfigurationRoot configuration, params Type[] types)
```

<strong>Method parameters</strong><dl><dt>Autofac.ContainerBuilder <strong>builder</strong></dt><dd>AutoFac container builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfigurationroot" target="_blank" >Microsoft.Extensions.Configuration.IConfigurationRoot</a> <strong>configuration</strong></dt><dd>Configuration container</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type[]</a> <strong>types</strong></dt><dd>Types to check</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>configuration</strong> or <strong>types</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addoptions--1_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.string___1b2rpkf" />  ContainerBuilderExtensions.AddOptions&lt;TOptions&gt;(ContainerBuilder, IConfigurationRoot, string) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7)           
Sources: di\config\extensions\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates and registers the singleton of configuration (options) class of given type This is to be used if not registered using the [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2)



```csharp
public static void AddOptions<TOptions>(this ContainerBuilder builder, IConfigurationRoot configuration, string configSection) where TOptions: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptions</strong></dt><dd>Configuration class type</dd></dl>
<strong>Method parameters</strong><dl><dt>Autofac.ContainerBuilder <strong>builder</strong></dt><dd>AutoFac container builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfigurationroot" target="_blank" >Microsoft.Extensions.Configuration.IConfigurationRoot</a> <strong>configuration</strong></dt><dd>Configuration container</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>configSection</strong></dt><dd>Name of the configuration section to bind to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>configuration</strong> is null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>configSection</strong> is null  or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension__1p9fgao" />  ServiceCollectionAutoOptionsExtension Class ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Sources: di\config\extensions\ServiceCollectionAutoOptionsExtension.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Extensions for options (configuration) class automatic binding to appsettings.json



```csharp
internal static class ServiceCollectionAutoOptionsExtension
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConfigureAutoOptions(IServiceCollection, IConfiguration, Assembly[])](#m-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension.configureautooptions_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration-system.reflection.assembly_____bfjrc2) | public static | Scans given assemblies for classes marked with [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) and binds them to appsettings.json configuration section defined in attribute. Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI | 
 | [ConfigureAutoOptions(IServiceCollection, IConfigurationRoot, Assembly[])](#m-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension.configureautooptions_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfigurationroot-system.reflection.assembly_____1kc5g1y) | public static | Scans given assemblies for classes marked with [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) and binds them to appsettings.json configuration section defined in attribute. Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension.configureautooptions_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration-system.reflection.assembly_____bfjrc2" />  ServiceCollectionAutoOptionsExtension.ConfigureAutoOptions(IServiceCollection, IConfiguration, Assembly[]) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionAutoOptionsExtension](#t-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension__1p9fgao)           
Sources: di\config\extensions\ServiceCollectionAutoOptionsExtension.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Scans given assemblies for classes marked with [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) and binds them to appsettings.json configuration section defined in attribute. Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI



```csharp
public static IServiceCollection ConfigureAutoOptions(this IServiceCollection services, IConfiguration configuration, Assembly[] assemblies)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a> <strong>services</strong></dt><dd>Service collection</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfiguration" target="_blank" >Microsoft.Extensions.Configuration.IConfiguration</a> <strong>configuration</strong></dt><dd>Configuration</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly" target="_blank" >System.Reflection.Assembly[]</a> <strong>assemblies</strong></dt><dd>Assemblies to scan</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a></dt><dd>Service collection</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>services</strong> or <strong>assemblies</strong> is `null`</dd><dt>[ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dt><dd>Can get &#39;services.Configure&#39; method</dd><dt>[ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dt><dd>Can&#39;t invoke &#39;services.Configure&lt;type&gt;(section)&#39;</dd><dt>[ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dt><dd>Can&#39;t create the instance of options (configuration) class</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension.configureautooptions_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfigurationroot-system.reflection.assembly_____1kc5g1y" />  ServiceCollectionAutoOptionsExtension.ConfigureAutoOptions(IServiceCollection, IConfigurationRoot, Assembly[]) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionAutoOptionsExtension](#t-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension__1p9fgao)           
Sources: di\config\extensions\ServiceCollectionAutoOptionsExtension.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Scans given assemblies for classes marked with [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) and binds them to appsettings.json configuration section defined in attribute. Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI



```csharp
public static IServiceCollection ConfigureAutoOptions(this IServiceCollection services, IConfigurationRoot configuration, Assembly[] assemblies)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a> <strong>services</strong></dt><dd>Service collection</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfigurationroot" target="_blank" >Microsoft.Extensions.Configuration.IConfigurationRoot</a> <strong>configuration</strong></dt><dd>Configuration root</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly" target="_blank" >System.Reflection.Assembly[]</a> <strong>assemblies</strong></dt><dd>Assemblies to scan</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a></dt><dd>Service collection</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>services</strong> or <strong>assemblies</strong> is `null`</dd><dt>[ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dt><dd>Can get &#39;services.Configure&#39; method</dd><dt>[ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dt><dd>Can&#39;t invoke &#39;services.Configure&lt;type&gt;(section)&#39;</dd><dt>[ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dt><dd>Can&#39;t create the instance of options (configuration) class</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv" />  ServiceCollectionConfigureDirectExtensions Class ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Sources: di\config\extensions\ServiceCollectionConfigureDirectExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Extensions for options (configuration) class registration into MS DI



```csharp
internal static class ServiceCollectionConfigureDirectExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConfigureDirect(IServiceCollection, Type, IConfiguration)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect_microsoft.extensions.dependencyinjection.iservicecollection-system.type-microsoft.extensions.configuration.iconfiguration___1lbalbi) | public static | Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI. | 
 | [ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration___1049ily) | public static | Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI. | 
 | [ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration, Func&lt;TConfig&gt;)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration-system.func_--0____1uka1kl) | public static | Gets the instance of the options (configuration) class from <strong>pocoProvider</strong> , binds (fills) it to the configuration and registers is as singleton into MS DI. | 
 | [ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration, ServiceCollectionConfigureDirectExtensions.TConfig)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration---0___18sq65m) | public static | Binds (fills) given instance of the options (configuration) class to configuration and registers is as singleton into MS DI. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect_microsoft.extensions.dependencyinjection.iservicecollection-system.type-microsoft.extensions.configuration.iconfiguration___1lbalbi" />  ServiceCollectionConfigureDirectExtensions.ConfigureDirect(IServiceCollection, Type, IConfiguration) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectExtensions](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv)           
Sources: di\config\extensions\ServiceCollectionConfigureDirectExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI.



```csharp
public static object ConfigureDirect(this IServiceCollection services, Type type, IConfiguration configuration)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a> <strong>services</strong></dt><dd>MS DI Service collection</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type of options (configuration) class to register as singleton</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfiguration" target="_blank" >Microsoft.Extensions.Configuration.IConfiguration</a> <strong>configuration</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Options (configuration) class instance registered as singleton</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>services</strong> or <strong>configuration</strong> is `null`</dd><dt>[ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dt><dd>Can&#39;t create the instance of options (configuration) class</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration___1049ily" />  ServiceCollectionConfigureDirectExtensions.ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectExtensions](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv)           
Sources: di\config\extensions\ServiceCollectionConfigureDirectExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI.



```csharp
public static ServiceCollectionConfigureDirectExtensions.TConfig ConfigureDirect<TConfig>(this IServiceCollection services, IConfiguration configuration) where TConfig: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>TConfig</strong></dt><dd>Type of options (configuration) class to register as singleton</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a> <strong>services</strong></dt><dd>MS DI Service collection</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfiguration" target="_blank" >Microsoft.Extensions.Configuration.IConfiguration</a> <strong>configuration</strong></dt><dd>Configuration (data) to be filled into the options class instance</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.di.config.extensions.ServiceCollectionConfigureDirectExtensions.TConfig</dt><dd>Options (configuration) class instance registered as singleton</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>services</strong> or <strong>configuration</strong> is `null`</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration-system.func_--0____1uka1kl" />  ServiceCollectionConfigureDirectExtensions.ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration, Func&lt;TConfig&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectExtensions](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv)           
Sources: di\config\extensions\ServiceCollectionConfigureDirectExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Gets the instance of the options (configuration) class from <strong>pocoProvider</strong> , binds (fills) it to the configuration and registers is as singleton into MS DI.



```csharp
public static ServiceCollectionConfigureDirectExtensions.TConfig ConfigureDirect<TConfig>(this IServiceCollection services, IConfiguration configuration, Func<TConfig> pocoProvider) where TConfig: class
```

<strong>Type parameters</strong><dl><dt><strong>TConfig</strong></dt><dd>Type of options (configuration) class to register as singleton</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a> <strong>services</strong></dt><dd>MS DI Service collection</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfiguration" target="_blank" >Microsoft.Extensions.Configuration.IConfiguration</a> <strong>configuration</strong></dt><dd>Configuration (data) to be filled into the options class instance</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;TConfig&gt;</a> <strong>pocoProvider</strong></dt><dd>Delegate of function that will provide the options (configuration) class instance</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.di.config.extensions.ServiceCollectionConfigureDirectExtensions.TConfig</dt><dd>Options (configuration) class instance registered as singleton</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>One of the parameters is `null`</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>A delegate callback throws an exception.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration---0___18sq65m" />  ServiceCollectionConfigureDirectExtensions.ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration, ServiceCollectionConfigureDirectExtensions.TConfig) Method ##
<small>Namespace: [net.adamec.lib.common.di.config.extensions](#n-net.adamec.lib.common.di.config.extensions__1bjxl1v)           
Assembly: net.adamec.lib.common           
Type: [ServiceCollectionConfigureDirectExtensions](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv)           
Sources: di\config\extensions\ServiceCollectionConfigureDirectExtensions.cs           
Source-only packages: [RadCommons.di.Config](#src-only-package--RadCommons.di.Config)</small>


Binds (fills) given instance of the options (configuration) class to configuration and registers is as singleton into MS DI.



```csharp
public static ServiceCollectionConfigureDirectExtensions.TConfig ConfigureDirect<TConfig>(this IServiceCollection services, IConfiguration configuration, ServiceCollectionConfigureDirectExtensions.TConfig config) where TConfig: class
```

<strong>Type parameters</strong><dl><dt><strong>TConfig</strong></dt><dd>Type of options (configuration) class to register as singleton</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection" target="_blank" >Microsoft.Extensions.DependencyInjection.IServiceCollection</a> <strong>services</strong></dt><dd>MS DI Service collection</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.iconfiguration" target="_blank" >Microsoft.Extensions.Configuration.IConfiguration</a> <strong>configuration</strong></dt><dd>Configuration (data) to be filled into the options class instance</dd><dt>net.adamec.lib.common.di.config.extensions.ServiceCollectionConfigureDirectExtensions.TConfig <strong>config</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.di.config.extensions.ServiceCollectionConfigureDirectExtensions.TConfig</dt><dd>Options (configuration) class instance registered as singleton</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>One of the parameters is `null`</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.di.postinit__ylne5f" />  net.adamec.lib.common.di.postinit Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.postinit.containerbuilderextensions__7mjuw3) | internal static | Autofac <em>Autofac.ContainerBuilder</em> extensions | 
 | [PostInitAttribute](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl) | public | Allows to run post init method of component. Component must be registered using the Component attribute as singleton in root scope and must register self Parameters of &quot;marked&quot; post init method are resolved from container (throws an exception on failure) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.postinit.containerbuilderextensions__7mjuw3" />  ContainerBuilderExtensions Class ##
<small>Namespace: [net.adamec.lib.common.di.postinit](#n-net.adamec.lib.common.di.postinit__ylne5f)           
Assembly: net.adamec.lib.common           
Sources: di\postinit\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.PostInit](#src-only-package--RadCommons.di.PostInit)</small>


Autofac <em>Autofac.ContainerBuilder</em> extensions



```csharp
internal static class ContainerBuilderExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddComponentPostInitSupport(ContainerBuilder)](#m-net.adamec.lib.common.di.postinit.containerbuilderextensions.addcomponentpostinitsupport_autofac.containerbuilder___nsekfd) | public static | Adds the support of [PostInitAttribute](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl) to the Autofac container builder. | 
 | [ProcessComponentPostInit(IContainer)](#m-net.adamec.lib.common.di.postinit.containerbuilderextensions.processcomponentpostinit_autofac.icontainer___uo3mji) | private static | Executes the components&#39; post init methods | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.postinit.containerbuilderextensions.addcomponentpostinitsupport_autofac.containerbuilder___nsekfd" />  ContainerBuilderExtensions.AddComponentPostInitSupport(ContainerBuilder) Method ##
<small>Namespace: [net.adamec.lib.common.di.postinit](#n-net.adamec.lib.common.di.postinit__ylne5f)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.postinit.containerbuilderextensions__7mjuw3)           
Sources: di\postinit\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.PostInit](#src-only-package--RadCommons.di.PostInit)</small>


Adds the support of [PostInitAttribute](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl) to the Autofac container builder.



```csharp
public static ContainerBuilder AddComponentPostInitSupport(this ContainerBuilder builder)
```

<strong>Method parameters</strong><dl><dt>Autofac.ContainerBuilder <strong>builder</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>Autofac.ContainerBuilder</dt><dd>Autofac container builder</dd></dl>


###  Remarks ###
Registers the [ProcessComponentPostInit(IContainer)](#m-net.adamec.lib.common.di.postinit.containerbuilderextensions.processcomponentpostinit_autofac.icontainer___uo3mji) method as a container-built-callback


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.di.postinit.containerbuilderextensions.processcomponentpostinit_autofac.icontainer___uo3mji" />  ContainerBuilderExtensions.ProcessComponentPostInit(IContainer) Method ##
<small>Namespace: [net.adamec.lib.common.di.postinit](#n-net.adamec.lib.common.di.postinit__ylne5f)           
Assembly: net.adamec.lib.common           
Type: [ContainerBuilderExtensions](#t-net.adamec.lib.common.di.postinit.containerbuilderextensions__7mjuw3)           
Sources: di\postinit\ContainerBuilderExtensions.cs           
Source-only packages: [RadCommons.di.PostInit](#src-only-package--RadCommons.di.PostInit)</small>


Executes the components&#39; post init methods



```csharp
private static void ProcessComponentPostInit(IContainer container)
```

<strong>Method parameters</strong><dl><dt>Autofac.IContainer <strong>container</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
Checks Autofac registry for the services with [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) that register themselves (so the interface registrations are excluded). For such components (services) it tries to find the methods marked with [PostInitAttribute](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl) and execute them. When the method has the parameters, it will try to resolve the from the container


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Can&#39;t resolve the post init method parameter from container or can&#39;t get the component instance from container</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl" />  PostInitAttribute Class ##
<small>Namespace: [net.adamec.lib.common.di.postinit](#n-net.adamec.lib.common.di.postinit__ylne5f)           
Assembly: net.adamec.lib.common           
Sources: di\postinit\PostInitAttribute.cs           
Source-only packages: [RadCommons.di.PostInit](#src-only-package--RadCommons.di.PostInit)</small>


Allows to run post init method of component. Component must be registered using the Component attribute as singleton in root scope and must register self Parameters of &quot;marked&quot; post init method are resolved from container (throws an exception on failure)



```csharp
[AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
public class PostInitAttribute : Attribute
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attribute" target="_blank" >Attribute</a>           
Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.attributeusageattribute" target="_blank" >System.AttributeUsageAttribute</a>           



Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.extensions__1vwuhoq" />  net.adamec.lib.common.extensions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ArrayExtensions](#t-net.adamec.lib.common.extensions.arrayextensions__icw7wf) | internal static | Array extensions | 
 | [EnumeratorExtensions](#t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1" target="_blank" >System.Collections.Generic.IEnumerator`1</a> class extensions | 
 | [IEnumerableExtensions](#t-net.adamec.lib.common.extensions.ienumerableextensions__1a6urvh) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> extensions | 
 | [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions | 
 | [TypeExtensions](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.arrayextensions__icw7wf" />  ArrayExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Sources: extensions\ArrayExtensionsAppendBytes.cs, extensions\ArrayExtensionsFill.cs           
Source-only packages: [RadCommons.extensions.ArrayExtensions.ConcatenateBytes](#src-only-package--RadCommons.extensions.ArrayExtensions.ConcatenateBytes), [RadCommons.extensions.ArrayExtensions.Fill](#src-only-package--RadCommons.extensions.ArrayExtensions.Fill)</small>


Array extensions



```csharp
internal static class ArrayExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AppendBytes(byte[], byte[])](#m-net.adamec.lib.common.extensions.arrayextensions.appendbytes_system.byte__-system.byte_____1lkijjg) | public static | Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one) | 
 | [Fill&lt;T&gt;(ArrayExtensions.T[], ArrayExtensions.T)](#m-net.adamec.lib.common.extensions.arrayextensions.fill--1_--0__---0___6j19g1) | public static | Fills the <strong>array</strong> or <strong>T</strong> with <strong>defaultValue</strong> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.arrayextensions.appendbytes_system.byte__-system.byte_____1lkijjg" />  ArrayExtensions.AppendBytes(byte[], byte[]) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [ArrayExtensions](#t-net.adamec.lib.common.extensions.arrayextensions__icw7wf)           
Sources: extensions\ArrayExtensionsAppendBytes.cs           
Source-only packages: [RadCommons.extensions.ArrayExtensions.ConcatenateBytes](#src-only-package--RadCommons.extensions.ArrayExtensions.ConcatenateBytes)</small>


Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one)



```csharp
public static byte[] AppendBytes(this byte[] original, byte[] addedBytes)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.byte" target="_blank" >byte[]</a> <strong>original</strong></dt><dd>Original byte array</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.byte" target="_blank" >byte[]</a> <strong>addedBytes</strong></dt><dd>Bytes to add</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.byte" target="_blank" >byte[]</a></dt><dd>New concatenated byte array ( <strong>original</strong> + <strong>addedBytes</strong> )</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.arrayextensions.fill--1_--0__---0___6j19g1" />  ArrayExtensions.Fill&lt;T&gt;(ArrayExtensions.T[], ArrayExtensions.T) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [ArrayExtensions](#t-net.adamec.lib.common.extensions.arrayextensions__icw7wf)           
Sources: extensions\ArrayExtensionsFill.cs           
Source-only packages: [RadCommons.extensions.ArrayExtensions.Fill](#src-only-package--RadCommons.extensions.ArrayExtensions.Fill)</small>


Fills the <strong>array</strong> or <strong>T</strong> with <strong>defaultValue</strong>



```csharp
public static void Fill<T>(this ArrayExtensions.T[] array, ArrayExtensions.T defaultValue)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd><strong>array</strong> item type</dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.extensions.ArrayExtensions.T[] <strong>array</strong></dt><dd>Array to fill</dd><dt>net.adamec.lib.common.extensions.ArrayExtensions.T <strong>defaultValue</strong></dt><dd>Value to fill the array with</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2" />  EnumeratorExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Sources: extensions\EnumeratorExtensionsToEnumerable.cs           
Source-only packages: [RadCommons.extensions.EnumeratorExtensions.ToEnumerable](#src-only-package--RadCommons.extensions.EnumeratorExtensions.ToEnumerable)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1" target="_blank" >System.Collections.Generic.IEnumerator`1</a> class extensions



```csharp
internal static class EnumeratorExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToEnumerable&lt;T&gt;(IEnumerator)](#m-net.adamec.lib.common.extensions.enumeratorextensions.toenumerable--1_system.collections.ienumerator___fs1sul) | public static | Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> | 
 | [ToEnumerable&lt;T&gt;(IEnumerator&lt;T&gt;)](#m-net.adamec.lib.common.extensions.enumeratorextensions.toenumerable--1_system.collections.generic.ienumerator_--0____1e4iyhs) | public static | Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> | 
 | [ToList&lt;T&gt;(IEnumerator)](#m-net.adamec.lib.common.extensions.enumeratorextensions.tolist--1_system.collections.ienumerator___lgcqeh) | public static | Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.enumeratorextensions.toenumerable--1_system.collections.ienumerator___fs1sul" />  EnumeratorExtensions.ToEnumerable&lt;T&gt;(IEnumerator) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [EnumeratorExtensions](#t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2)           
Sources: extensions\EnumeratorExtensionsToEnumerable.cs           
Source-only packages: [RadCommons.extensions.EnumeratorExtensions.ToEnumerable](#src-only-package--RadCommons.extensions.EnumeratorExtensions.ToEnumerable)</small>


Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a>



```csharp
public static IEnumerable<T> ToEnumerable<T>(this IEnumerator enumerator)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type of objects held in enumerator/enumerable</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator" target="_blank" >IEnumerator</a> <strong>enumerator</strong></dt><dd>Enumerator to transforms</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;T&gt;</a></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> based on given <strong>enumerator</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>enumerator</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.enumeratorextensions.toenumerable--1_system.collections.generic.ienumerator_--0____1e4iyhs" />  EnumeratorExtensions.ToEnumerable&lt;T&gt;(IEnumerator&lt;T&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [EnumeratorExtensions](#t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2)           
Sources: extensions\EnumeratorExtensionsToEnumerable.cs           
Source-only packages: [RadCommons.extensions.EnumeratorExtensions.ToEnumerable](#src-only-package--RadCommons.extensions.EnumeratorExtensions.ToEnumerable)</small>


Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a>



```csharp
public static IEnumerable<T> ToEnumerable<T>(this IEnumerator<T> enumerator)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type  of objects held in enumerator/enumerable</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1" target="_blank" >IEnumerator&lt;T&gt;</a> <strong>enumerator</strong></dt><dd>Enumerator to transforms</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;T&gt;</a></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> based on given <strong>enumerator</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>enumerator</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.enumeratorextensions.tolist--1_system.collections.ienumerator___lgcqeh" />  EnumeratorExtensions.ToList&lt;T&gt;(IEnumerator) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [EnumeratorExtensions](#t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2)           
Sources: extensions\EnumeratorExtensionsToEnumerable.cs           
Source-only packages: [RadCommons.extensions.EnumeratorExtensions.ToEnumerable](#src-only-package--RadCommons.extensions.EnumeratorExtensions.ToEnumerable)</small>


Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a>



```csharp
public static List<T> ToList<T>(this IEnumerator enumerator)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type of objects held in enumerator/list</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator" target="_blank" >IEnumerator</a> <strong>enumerator</strong></dt><dd>Enumerator to transforms</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;T&gt;</a></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a> based on given <strong>enumerator</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>enumerator</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.ienumerableextensions__1a6urvh" />  IEnumerableExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Sources: extensions\IEnumerableExtensionsForEach.cs           
Source-only packages: [RadCommons.extensions.IEnumerableExtensions.ForEach](#src-only-package--RadCommons.extensions.IEnumerableExtensions.ForEach)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> extensions



```csharp
internal static class IEnumerableExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ForEach&lt;T&gt;(IEnumerable&lt;T&gt;, Action&lt;T&gt;)](#m-net.adamec.lib.common.extensions.ienumerableextensions.foreach--1_system.collections.generic.ienumerable_--0_-system.action_--0____nwdpsf) | public static | Invokes <strong>action</strong> for each item of <strong>enumerable</strong> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.ienumerableextensions.foreach--1_system.collections.generic.ienumerable_--0_-system.action_--0____nwdpsf" />  IEnumerableExtensions.ForEach&lt;T&gt;(IEnumerable&lt;T&gt;, Action&lt;T&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [IEnumerableExtensions](#t-net.adamec.lib.common.extensions.ienumerableextensions__1a6urvh)           
Sources: extensions\IEnumerableExtensionsForEach.cs           
Source-only packages: [RadCommons.extensions.IEnumerableExtensions.ForEach](#src-only-package--RadCommons.extensions.IEnumerableExtensions.ForEach)</small>


Invokes <strong>action</strong> for each item of <strong>enumerable</strong>



```csharp
public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Enumerable item type</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;T&gt;</a> <strong>enumerable</strong></dt><dd>Enumerable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;T&gt;</a> <strong>action</strong></dt><dd>Action to invoke for each item of <strong>enumerable</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>action</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.stringextensions__y7rgbb" />  StringExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Sources: extensions\StringExtensionsCase.cs, extensions\StringExtensionsHtml.cs, extensions\StringExtensionsParts.cs, extensions\StringExtensionsPaths.cs, extensions\StringExtensionsWhitespace.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Case](#src-only-package--RadCommons.extensions.StringExtensions.Case), [RadCommons.extensions.StringExtensions.Html](#src-only-package--RadCommons.extensions.StringExtensions.Html), [RadCommons.extensions.StringExtensions.Parts](#src-only-package--RadCommons.extensions.StringExtensions.Parts), [RadCommons.extensions.StringExtensions.Paths](#src-only-package--RadCommons.extensions.StringExtensions.Paths), [RadCommons.extensions.StringExtensions.Whitespace](#src-only-package--RadCommons.extensions.StringExtensions.Whitespace)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions



```csharp
internal static class StringExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddPath(string, string)](#m-net.adamec.lib.common.extensions.stringextensions.addpath_system.string-system.string___1m9wwnx) | public static | Adds next path segment to string representing path to the file system | 
 | [FirstLetterToUpper(string)](#m-net.adamec.lib.common.extensions.stringextensions.firstlettertoupper_system.string___12nwwlc) | public static | Converts the first letter of string to upper case | 
 | [HtmlDecode(string)](#m-net.adamec.lib.common.extensions.stringextensions.htmldecode_system.string___kajpem) | public static | HTML decodes the string | 
 | [HtmlEncode(string)](#m-net.adamec.lib.common.extensions.stringextensions.htmlencode_system.string___1ozzgea) | public static | HTML encodes the string | 
 | [LastPart(string, string)](#m-net.adamec.lib.common.extensions.stringextensions.lastpart_system.string-system.string___t4lkjk) | public static | Returns the part of the string after the last occurence of the <strong>separator</strong> The result is always trimmed | 
 | [SplitByFirstSpace(string, string)](#m-net.adamec.lib.common.extensions.stringextensions.splitbyfirstspace_system.string-system.string-___d5xnpu) | public static | Splits the string by first space and returns the &quot;before&quot; part. The &quot;after&quot; part is provided in output parameter <strong>rest</strong> Both result and <strong>rest</strong> are trimmed | 
 | [ToCamelCase(string)](#m-net.adamec.lib.common.extensions.stringextensions.tocamelcase_system.string___xq94l0) | public static | Simple CamelCase converter | 
 | [TrimAndMergeLines(string)](#m-net.adamec.lib.common.extensions.stringextensions.trimandmergelines_system.string___1371ffr) | public static | &quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.addpath_system.string-system.string___1m9wwnx" />  StringExtensions.AddPath(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsPaths.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Paths](#src-only-package--RadCommons.extensions.StringExtensions.Paths)</small>


Adds next path segment to string representing path to the file system



```csharp
public static string AddPath(this string str, string nextSegment)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String representing path to the file system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>nextSegment</strong></dt><dd>Next path segment</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String representing path to the file system</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.firstlettertoupper_system.string___12nwwlc" />  StringExtensions.FirstLetterToUpper(string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsCase.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Case](#src-only-package--RadCommons.extensions.StringExtensions.Case)</small>


Converts the first letter of string to upper case



```csharp
public static string FirstLetterToUpper(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to convert</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String with the first letter in upper case</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.htmldecode_system.string___kajpem" />  StringExtensions.HtmlDecode(string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsHtml.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Html](#src-only-package--RadCommons.extensions.StringExtensions.Html)</small>


HTML decodes the string



```csharp
public static string HtmlDecode(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to decode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>HTML decoded string</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.htmlencode_system.string___1ozzgea" />  StringExtensions.HtmlEncode(string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsHtml.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Html](#src-only-package--RadCommons.extensions.StringExtensions.Html)</small>


HTML encodes the string



```csharp
public static string HtmlEncode(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to encode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>HTML encoded string</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.lastpart_system.string-system.string___t4lkjk" />  StringExtensions.LastPart(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsParts.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Parts](#src-only-package--RadCommons.extensions.StringExtensions.Parts)</small>


Returns the part of the string after the last occurence of the <strong>separator</strong> The result is always trimmed



```csharp
public static string LastPart(this string input, string separator)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>input</strong></dt><dd>Input string</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Part separator</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Part of the string after the last occurence of the <strong>separator</strong> or the input string when no separator detected</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.splitbyfirstspace_system.string-system.string-___d5xnpu" />  StringExtensions.SplitByFirstSpace(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsParts.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Parts](#src-only-package--RadCommons.extensions.StringExtensions.Parts)</small>


Splits the string by first space and returns the &quot;before&quot; part. The &quot;after&quot; part is provided in output parameter <strong>rest</strong> Both result and <strong>rest</strong> are trimmed



```csharp
public static string SplitByFirstSpace(this string input, out string rest)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>input</strong></dt><dd>Input string</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>rest</strong></dt><dd>The part of string after the first space or null if there is no space</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Part of the string before the first space or the whole string if no space detected</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.tocamelcase_system.string___xq94l0" />  StringExtensions.ToCamelCase(string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsCase.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Case](#src-only-package--RadCommons.extensions.StringExtensions.Case)</small>


Simple CamelCase converter



```csharp
public static string ToCamelCase(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to convert to Camel Case</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Camel Case converted string</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.stringextensions.trimandmergelines_system.string___1371ffr" />  StringExtensions.TrimAndMergeLines(string) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [StringExtensions](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)           
Sources: extensions\StringExtensionsWhitespace.cs           
Source-only packages: [RadCommons.extensions.StringExtensions.Whitespace](#src-only-package--RadCommons.extensions.StringExtensions.Whitespace)</small>


&quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break)



```csharp
public static string TrimAndMergeLines(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to full trim</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>&quot;Fully&quot; trimmed string</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.typeextensions__63ezc8" />  TypeExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Sources: extensions\TypeExtensionsDefaultValue.cs           
Source-only packages: [RadCommons.extensions.TypeExtensions.DefaultValue](#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions



```csharp
internal static class TypeExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetDefaultValue(Type)](#m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69) | public static | Gets the default value of given <strong>type</strong> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69" />  TypeExtensions.GetDefaultValue(Type) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common           
Type: [TypeExtensions](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8)           
Sources: extensions\TypeExtensionsDefaultValue.cs           
Source-only packages: [RadCommons.extensions.TypeExtensions.DefaultValue](#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue)</small>


Gets the default value of given <strong>type</strong>



```csharp
public static object GetDefaultValue(this Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Default value of given <strong>type</strong> . Null for non-value types, new instance for value types.</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>type</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="n-net.adamec.lib.common.utils__7vdji9" />  net.adamec.lib.common.utils Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo) | public | Executes an operation on a separate thread with possibility of sync cancel. | 
 | [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415) | internal static | Console output helpers | 
 | [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) | internal | Base context implementation. | 
 | [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q) | internal | Keeps the stack of disposable objects, and disposes them when the disposer is being disposed. | 
 | [FileUtils](#t-net.adamec.lib.common.utils.fileutils__1bi9r8y) | internal static | File copy utilities | 
 | [MarshalExt](#t-net.adamec.lib.common.utils.marshalext__7jyavy) | internal static | Marshaling helper methods | 
 | [PeriodicTask](#t-net.adamec.lib.common.utils.periodictask__1xfynj) | internal static | Helper class allowing to execute periodic (or one time) scheduled action | 
 | [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix) | public | The ProcessEventArgs are arguments for a console event. | 
 | [ProcessUtils](#t-net.adamec.lib.common.utils.processutils__tzt3e1) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process" target="_blank" >System.Diagnostics.Process</a> related utilities | 
 | [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p) | public | A class the wraps a process, allowing programmatic input and output. | 
 | [ProcessWrapper.OutputChunk](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan) | protected | Internal class to hold the output chunk within the output worker | 
 | [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) | internal | Base scope implementation. | 
 | [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) | public | Text builder | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf) | internal abstract | Scope interface. | 

 


###  Delegates ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ProcessEventHandler](#t-net.adamec.lib.common.utils.processeventhandler__8h5v6w) | public | A ProcessEventHandler is a delegate for process output events. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo" />  BackgroundWorkerWithSyncCancel Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Executes an operation on a separate thread with possibility of sync cancel.



```csharp
public class BackgroundWorkerWithSyncCancel : BackgroundWorker
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject" target="_blank" >System.MarshalByRefObject</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.component" target="_blank" >System.ComponentModel.Component</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker" target="_blank" >System.ComponentModel.BackgroundWorker</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.icomponent" target="_blank" >System.ComponentModel.IComponent</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [isCancelling](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__14bxgje) | private | Backing field for [IsCancelling](#p-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__1krty8c) | 
 | [isRunningInternal](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.isrunninginternal__np6hee) | private | Internal flag whether the worker is running its DoWork action | 
 | [lockObject](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.lockobject__slen4g) | private | Lock object | 
 | [resetEvent](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.resetevent__7jv5b7) | private | Reset event used to ensure that the work is finished | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsCancelling](#p-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__1krty8c) | public | Flag whether the worker is cancelling | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Cancel()](#m-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.cancel__1p5og1v) | public | Requests cancellation of a pending background operation and wait for cancel to complete | 
 | [OnDoWork(DoWorkEventArgs)](#m-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.ondowork_system.componentmodel.doworkeventargs___1euewn7) | protected | Raises the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker.dowork#System_ComponentModel_BackgroundWorker_DoWork" target="_blank" >System.ComponentModel.BackgroundWorker.DoWork</a> event. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__14bxgje" />  BackgroundWorkerWithSyncCancel.isCancelling Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Backing field for [IsCancelling](#p-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__1krty8c)



```csharp
private bool isCancelling
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.isrunninginternal__np6hee" />  BackgroundWorkerWithSyncCancel.isRunningInternal Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Internal flag whether the worker is running its DoWork action



```csharp
private bool isRunningInternal
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.lockobject__slen4g" />  BackgroundWorkerWithSyncCancel.lockObject Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Lock object



```csharp
private readonly object lockObject
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.resetevent__7jv5b7" />  BackgroundWorkerWithSyncCancel.resetEvent Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Reset event used to ensure that the work is finished



```csharp
private readonly AutoResetEvent resetEvent
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent" target="_blank" >System.Threading.AutoResetEvent</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__1krty8c" />  BackgroundWorkerWithSyncCancel.IsCancelling Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Flag whether the worker is cancelling



```csharp
public bool IsCancelling { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.cancel__1p5og1v" />  BackgroundWorkerWithSyncCancel.Cancel() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Requests cancellation of a pending background operation and wait for cancel to complete



```csharp
public void Cancel()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.ondowork_system.componentmodel.doworkeventargs___1euewn7" />  BackgroundWorkerWithSyncCancel.OnDoWork(DoWorkEventArgs) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)           
Sources: utils\BackgroundWorkerWithSyncCancel.cs           
Source-only packages: [RadCommons.utils.BackgroundWorkerWithSyncCancel](#src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel)</small>


Raises the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker.dowork#System_ComponentModel_BackgroundWorker_DoWork" target="_blank" >System.ComponentModel.BackgroundWorker.DoWork</a> event.



```csharp
protected override void OnDoWork(DoWorkEventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.doworkeventargs" target="_blank" >System.ComponentModel.DoWorkEventArgs</a> <strong>e</strong></dt><dd>An <a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventargs" target="_blank" >System.EventArgs</a> that contains the event data.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker.ondowork#System_ComponentModel_BackgroundWorker_OnDoWork_System_ComponentModel_DoWorkEventArgs_" target="_blank" >ComponentModel.BackgroundWorker.OnDoWork</a>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.consoleutils__8nc415" />  ConsoleUtils Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Console output helpers



```csharp
internal static class ConsoleUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ColorErr](#f-net.adamec.lib.common.utils.consoleutils.colorerr__1pfz831) | public static | Error text color (red) | 
 | [ColorWarn](#f-net.adamec.lib.common.utils.consoleutils.colorwarn__1ewdf3q) | public static | Warning text color (yellow) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [WriteErr(string)](#m-net.adamec.lib.common.utils.consoleutils.writeerr_system.string___p914w1) | public static | Writes error <strong>line</strong> to console error output | 
 | [WriteErrWarn(string)](#m-net.adamec.lib.common.utils.consoleutils.writeerrwarn_system.string___1p5ryw7) | public static | Writes warning <strong>line</strong> to console error output | 
 | [WriteInfo(string)](#m-net.adamec.lib.common.utils.consoleutils.writeinfo_system.string___16eewm4) | public static | Writes info <strong>line</strong> to console standard output | 
 | [WriteLine(string, ConsoleColor)](#m-net.adamec.lib.common.utils.consoleutils.writeline_system.string-system.consolecolor___k0vd2z) | public static | Writes colored <strong>line</strong> to console standard output | 
 | [WriteLine(TextWriter, string, ConsoleColor)](#m-net.adamec.lib.common.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___1s54eb8) | private static | Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong> | 
 | [WriteWarn(string)](#m-net.adamec.lib.common.utils.consoleutils.writewarn_system.string___1g2atmo) | public static | Writes warning <strong>line</strong> to console standard output | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.consoleutils.colorerr__1pfz831" />  ConsoleUtils.ColorErr Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Error text color (red)



```csharp
public static ConsoleColor ColorErr
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.consoleutils.colorwarn__1ewdf3q" />  ConsoleUtils.ColorWarn Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Warning text color (yellow)



```csharp
public static ConsoleColor ColorWarn
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.consoleutils.writeerr_system.string___p914w1" />  ConsoleUtils.WriteErr(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Writes error <strong>line</strong> to console error output



```csharp
public static void WriteErr(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.consoleutils.writeerrwarn_system.string___1p5ryw7" />  ConsoleUtils.WriteErrWarn(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Writes warning <strong>line</strong> to console error output



```csharp
public static void WriteErrWarn(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.consoleutils.writeinfo_system.string___16eewm4" />  ConsoleUtils.WriteInfo(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Writes info <strong>line</strong> to console standard output



```csharp
public static void WriteInfo(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.consoleutils.writeline_system.string-system.consolecolor___k0vd2z" />  ConsoleUtils.WriteLine(string, ConsoleColor) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Writes colored <strong>line</strong> to console standard output



```csharp
public static void WriteLine(string line, ConsoleColor color)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a> <strong>color</strong></dt><dd>Text color to use</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___1s54eb8" />  ConsoleUtils.WriteLine(TextWriter, string, ConsoleColor) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong>



```csharp
private static void WriteLine(TextWriter writer, string line, ConsoleColor color)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter" target="_blank" >System.IO.TextWriter</a> <strong>writer</strong></dt><dd>Console&#39;s writer (standard or error output)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a> <strong>color</strong></dt><dd>Text color to use</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.consoleutils.writewarn_system.string___1g2atmo" />  ConsoleUtils.WriteWarn(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ConsoleUtils](#t-net.adamec.lib.common.utils.consoleutils__8nc415)           
Sources: utils\ConsoleUtils.cs           
Source-only packages: [RadCommons.utils.ConsoleUtils](#src-only-package--RadCommons.utils.ConsoleUtils)</small>


Writes warning <strong>line</strong> to console standard output



```csharp
public static void WriteWarn(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.context-1__15rsz3v" />  Context&lt;TState&gt; Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Base context implementation.



```csharp
internal class Context<TState> : BaseDisposable where TState: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>TState</strong></dt><dd>Type of the state object managed by the context</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; net.adamec.lib.common.core.utils.BaseDisposable           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Remarks ###
The context can be both state-less and state-full and it&#39;s valid until it&#39;s disposed. The current context is accessible via [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) . The contexts are chained, when a new context is created using [BeginContext(Context&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.context-1.begincontext_-0___mkgdox) , the [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context became the [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) of the new one and the newly created context will be set as the [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) one. When the context is disposed, the [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context is set to [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) of disposing context. Context&#39;s children are disposed as well during the context disposal. The [AddToDisposer(IDisposable)](#m-net.adamec.lib.common.utils.context-1.addtodisposer_system.idisposable___1y4aua6) method is to be used in inherited classes whenever they manage any disposable resource to ensure their proper life time (when the [State](#p-net.adamec.lib.common.utils.context-1.state__1qgilfy) is <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> , it&#39;s added to disposer automatically). The base implementation just manages the life time, context chain and keeps the state (when provided). Inherit from the [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) to add the context related operations (inherited classes have the access to [State](#p-net.adamec.lib.common.utils.context-1.state__1qgilfy) ).

 Based on the implementation of Guard Scopes by  https://github.com/safakgur at https://github.com/safakgur/guard/blob/v1.7.0/src/Guard.Scopes.cs




###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [ContextDisposedMessage](#f-net.adamec.lib.common.utils.context-1.contextdisposedmessage__161hgfs) | Current context has been disposed | Error message that will be put into the exception when there will be any operation on the disposed context. | 

 


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [contextState](#f-net.adamec.lib.common.utils.context-1.contextstate__5jvaxj) | private | State managed by the context. | 
 | [Local](#f-net.adamec.lib.common.utils.context-1.local__17b69oq) | private static | The context holder that is local to the calling asynchronous control flow. | 
 | [parentContext](#f-net.adamec.lib.common.utils.context-1.parentcontext__1an2htq) | private | Parent context. | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) | public static | Gets the current context. | 
 | [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) | private | Gets the disposer associated with this container. | 
 | [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) | public | Gets the parent scope. | 
 | [State](#p-net.adamec.lib.common.utils.context-1.state__1qgilfy) | protected | Gets the state managed by the context. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Context&lt;TState&gt;(Context&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.context-1.-ctor_-0___7zfvl8) | protected | Creates an instance of [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) and initialize its [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) . The new context will become [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) and the previous one its [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) . | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddToDisposer(IDisposable)](#m-net.adamec.lib.common.utils.context-1.addtodisposer_system.idisposable___1y4aua6) | protected | Adds the <strong>disposable</strong> object to the context disposer, so it will be disposed with the context | 
 | [BeginContext(Context&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.context-1.begincontext_-0___mkgdox) | public static | Creates a new [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) within the context chain. The new context will become [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) and the previous one its [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) . | 
 | [DisposeManaged()](#m-net.adamec.lib.common.utils.context-1.disposemanaged__1ueqxf2) | protected | Dispose any disposable managed objects - all disposables kept in [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) stack are pop and disposed. The [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) context of the disposing one will become the new [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.context-1.contextdisposedmessage__161hgfs" />  Context&lt;TState&gt;.ContextDisposedMessage Constant ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Error message that will be put into the exception when there will be any operation on the disposed context.



```csharp
private const string ContextDisposedMessage = "Current context has been disposed"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.context-1.contextstate__5jvaxj" />  Context&lt;TState&gt;.contextState Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


State managed by the context.



```csharp
private readonly Context<TState>.TState contextState
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.utils.Context&lt;TState&gt;.TState</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.context-1.local__17b69oq" />  Context&lt;TState&gt;.Local Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


The context holder that is local to the calling asynchronous control flow.



```csharp
private static readonly AsyncLocal<net.adamec.lib.common.utils.Context<TState>> Local
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.asynclocal-1" target="_blank" >System.Threading.AsyncLocal&lt;net.adamec.lib.common.utils.Context&lt;TState&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.context-1.parentcontext__1an2htq" />  Context&lt;TState&gt;.parentContext Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Parent context.



```csharp
private readonly Context<TState> parentContext
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.utils.Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.context-1.current__14ss4su" />  Context&lt;TState&gt;.Current Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Gets the current context.



```csharp
public static Context<TState> Current { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c" />  Context&lt;TState&gt;.Disposer Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Gets the disposer associated with this container.



```csharp
private Disposer Disposer { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.context-1.parent__18v621x" />  Context&lt;TState&gt;.Parent Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Gets the parent scope.



```csharp
public Context<TState> Parent { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current context has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.context-1.state__1qgilfy" />  Context&lt;TState&gt;.State Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Gets the state managed by the context.



```csharp
protected Context<TState>.TState State { get; }
```

<strong>Property value</strong><dl><dt>net.adamec.lib.common.utils.Context&lt;TState&gt;.TState</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current context has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.context-1.-ctor_-0___7zfvl8" />  Context&lt;TState&gt;.Context&lt;TState&gt;(Context&lt;TState&gt;.TState) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Creates an instance of [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) and initialize its [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) . The new context will become [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) and the previous one its [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) .



```csharp
protected Context<TState>(Context<TState>.TState state = null)
```

<strong>Constructor parameters</strong><dl><dt>net.adamec.lib.common.utils.Context&lt;TState&gt;.TState <strong>state</strong></dt><dd>Optional state managed by the context.</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.context-1.addtodisposer_system.idisposable___1y4aua6" />  Context&lt;TState&gt;.AddToDisposer(IDisposable) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Adds the <strong>disposable</strong> object to the context disposer, so it will be disposed with the context



```csharp
protected void AddToDisposer(IDisposable disposable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a> <strong>disposable</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> object to be added to the disposer.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>disposable</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current context has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.context-1.begincontext_-0___mkgdox" />  Context&lt;TState&gt;.BeginContext(Context&lt;TState&gt;.TState) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Creates a new [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) within the context chain. The new context will become [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) and the previous one its [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) .



```csharp
public static IDisposable BeginContext(Context<TState>.TState state = null)
```

<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.utils.Context&lt;TState&gt;.TState <strong>state</strong></dt><dd>Optional state managed by the context.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.context-1.disposemanaged__1ueqxf2" />  Context&lt;TState&gt;.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v)           
Sources: utils\Context.cs           
Source-only packages: [RadCommons.utils.Context](#src-only-package--RadCommons.utils.Context)</small>


Dispose any disposable managed objects - all disposables kept in [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) stack are pop and disposed. The [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) context of the disposing one will become the new [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context.





```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: utils.BaseDisposable.DisposeManaged


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.disposer__1ejr99q" />  Disposer Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\Disposer.cs           
Source-only packages: [RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</small>


Keeps the stack of disposable objects, and disposes them when the disposer is being disposed.



```csharp
internal class Disposer : BaseDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; net.adamec.lib.common.core.utils.BaseDisposable           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [disposables](#f-net.adamec.lib.common.utils.disposer.disposables__5cwehn) | private | Stack of disposables kept by the [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q) . | 
 | [lockObj](#f-net.adamec.lib.common.utils.disposer.lockobj__1oj1wh6) | private | Lock object | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(IDisposable)](#m-net.adamec.lib.common.utils.disposer.add_system.idisposable___1c4uk8l) | public | Adds the <strong>disposable</strong> object to the disposer. | 
 | [Dispose(bool)](#m-net.adamec.lib.common.utils.disposer.dispose_system.boolean___32o7wm) | protected | Internal implementation of dispose - free the managed and native resources. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.disposer.disposables__5cwehn" />  Disposer.disposables Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q)           
Sources: utils\Disposer.cs           
Source-only packages: [RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</small>


Stack of disposables kept by the [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q) .



```csharp
private Stack<IDisposable> disposables
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >Stack&lt;IDisposable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.disposer.lockobj__1oj1wh6" />  Disposer.lockObj Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q)           
Sources: utils\Disposer.cs           
Source-only packages: [RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</small>


Lock object



```csharp
private readonly object lockObj
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.disposer.add_system.idisposable___1c4uk8l" />  Disposer.Add(IDisposable) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q)           
Sources: utils\Disposer.cs           
Source-only packages: [RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</small>


Adds the <strong>disposable</strong> object to the disposer.



```csharp
public void Add(IDisposable disposable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a> <strong>disposable</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> object to be added to the disposer.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>disposable</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.disposer.dispose_system.boolean___32o7wm" />  Disposer.Dispose(bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q)           
Sources: utils\Disposer.cs           
Source-only packages: [RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</small>


Internal implementation of dispose - free the managed and native resources.



```csharp
protected override void Dispose(bool disposing)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>disposing</strong></dt><dd>True to dispose both managed and native resources, false to dispose the native resources only.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: utils.BaseDisposable.Dispose


###  Remarks ###
When disposing the managed objects ( <strong>disposing</strong> is true), all disposables kept in [disposables](#f-net.adamec.lib.common.utils.disposer.disposables__5cwehn) stack are pop and disposed.


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.fileutils__1bi9r8y" />  FileUtils Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\FileUtilsCopy.cs           
Source-only packages: [RadCommons.utils.FileUtils.Copy](#src-only-package--RadCommons.utils.FileUtils.Copy)</small>


File copy utilities



```csharp
internal static class FileUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DirectoryCopy(string, string, bool, bool, List&lt;string&gt;)](#m-net.adamec.lib.common.utils.fileutils.directorycopy_system.string-system.string-system.boolean-system.boolean-system.collections.generic.list_system.string____14t7efj) | public static | Copies the source directory to destination directory All files from source directory are copied to the destination directory. The destination directory is created when doesn&#39;t exist. <strong>recursive</strong> parameter set to true let also subdirectories to be copied To overwrite the existing destination files, <strong>overwrite</strong> must be set to true, otherwise the exception is thrown. When <strong>overwrite</strong> is set, it&#39;s possible to exclude the files by adding the file names (without path, so applicable to all directories) to <strong>doNotOverwriteFileNames</strong> list. The listed files are being &quot;silently&quot; skipped (no exception thrown) | 
 | [FileCopy(string, string, bool, List&lt;string&gt;)](#m-net.adamec.lib.common.utils.fileutils.filecopy_system.string-system.string-system.boolean-system.collections.generic.list_system.string____1j72c9b) | public static | Copies the source file to destination file To overwrite the existing destination file, <strong>overwrite</strong> must be set to true, otherwise the exception is thrown. When <strong>overwrite</strong> is set, it&#39;s possible to exclude the files by adding the file names (without path) to <strong>doNotOverwriteFileNames</strong> list. The listed files are being &quot;silently&quot; skipped (no exception thrown) | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.fileutils.directorycopy_system.string-system.string-system.boolean-system.boolean-system.collections.generic.list_system.string____14t7efj" />  FileUtils.DirectoryCopy(string, string, bool, bool, List&lt;string&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [FileUtils](#t-net.adamec.lib.common.utils.fileutils__1bi9r8y)           
Sources: utils\FileUtilsCopy.cs           
Source-only packages: [RadCommons.utils.FileUtils.Copy](#src-only-package--RadCommons.utils.FileUtils.Copy)</small>


Copies the source directory to destination directory All files from source directory are copied to the destination directory. The destination directory is created when doesn&#39;t exist. <strong>recursive</strong> parameter set to true let also subdirectories to be copied To overwrite the existing destination files, <strong>overwrite</strong> must be set to true, otherwise the exception is thrown. When <strong>overwrite</strong> is set, it&#39;s possible to exclude the files by adding the file names (without path, so applicable to all directories) to <strong>doNotOverwriteFileNames</strong> list. The listed files are being &quot;silently&quot; skipped (no exception thrown)



```csharp
public static void DirectoryCopy(string sourceDirectoryName, string destDirectoryName, bool recursive, bool overwrite, List<string> doNotOverwriteFileNames = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sourceDirectoryName</strong></dt><dd>Full path to the source directory</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>destDirectoryName</strong></dt><dd>Full path to the destination directory</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>recursive</strong></dt><dd>True if the subdirectories are to be copied as well</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>overwrite</strong></dt><dd>True to allow overwriting the existing destination files</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a> <strong>doNotOverwriteFileNames</strong></dt><dd>Optional list of file names not to be overwritten</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDirectoryName</strong> or <strong>destDirectoryName</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.directorynotfoundexception" target="_blank" >System.IO.DirectoryNotFoundException</a></dt><dd><strong>sourceDirectoryName</strong> doesn&#39;t exist.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.fileutils.filecopy_system.string-system.string-system.boolean-system.collections.generic.list_system.string____1j72c9b" />  FileUtils.FileCopy(string, string, bool, List&lt;string&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [FileUtils](#t-net.adamec.lib.common.utils.fileutils__1bi9r8y)           
Sources: utils\FileUtilsCopy.cs           
Source-only packages: [RadCommons.utils.FileUtils.Copy](#src-only-package--RadCommons.utils.FileUtils.Copy)</small>


Copies the source file to destination file To overwrite the existing destination file, <strong>overwrite</strong> must be set to true, otherwise the exception is thrown. When <strong>overwrite</strong> is set, it&#39;s possible to exclude the files by adding the file names (without path) to <strong>doNotOverwriteFileNames</strong> list. The listed files are being &quot;silently&quot; skipped (no exception thrown)



```csharp
public static void FileCopy(string sourceFileName, string destFileName, bool overwrite, List<string> doNotOverwriteFileNames = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sourceFileName</strong></dt><dd>Full path to the source file</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>destFileName</strong></dt><dd>Full path to the destination file</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>overwrite</strong></dt><dd>True to allow overwriting the existing destination file</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a> <strong>doNotOverwriteFileNames</strong></dt><dd>Optional list of file names not to be overwritten</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceFileName</strong> or <strong>destFileName</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.marshalext__7jyavy" />  MarshalExt Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\MarshalExt.cs           
Source-only packages: [RadCommons.utils.MarshalExt](#src-only-package--RadCommons.utils.MarshalExt)</small>


Marshaling helper methods



```csharp
internal static class MarshalExt
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetDataAsStructure(Type, byte[])](#m-net.adamec.lib.common.utils.marshalext.getdataasstructure_system.type-system.byte_____3ecs3) | public static | Converts the byte array <strong>data</strong> into the structure of given <strong>structureType</strong> | 
 | [GetStructureAsData(object)](#m-net.adamec.lib.common.utils.marshalext.getstructureasdata_system.object___1emo3ax) | public static | Get&#39;s the structure data byte array | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.marshalext.getdataasstructure_system.type-system.byte_____3ecs3" />  MarshalExt.GetDataAsStructure(Type, byte[]) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [MarshalExt](#t-net.adamec.lib.common.utils.marshalext__7jyavy)           
Sources: utils\MarshalExt.cs           
Source-only packages: [RadCommons.utils.MarshalExt](#src-only-package--RadCommons.utils.MarshalExt)</small>


Converts the byte array <strong>data</strong> into the structure of given <strong>structureType</strong>



```csharp
public static object GetDataAsStructure(Type structureType, byte[] data)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>structureType</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.byte" target="_blank" >byte[]</a> <strong>data</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The structure build from the <strong>data</strong> or null when the conversion was not successful.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.marshalext.getstructureasdata_system.object___1emo3ax" />  MarshalExt.GetStructureAsData(object) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [MarshalExt](#t-net.adamec.lib.common.utils.marshalext__7jyavy)           
Sources: utils\MarshalExt.cs           
Source-only packages: [RadCommons.utils.MarshalExt](#src-only-package--RadCommons.utils.MarshalExt)</small>


Get&#39;s the structure data byte array



```csharp
public static byte[] GetStructureAsData(object sourceStructure)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sourceStructure</strong></dt><dd>Source structure</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.byte" target="_blank" >byte[]</a></dt><dd>Structure data as byte array</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.periodictask__1xfynj" />  PeriodicTask Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\PeriodicTask.cs           
Source-only packages: [RadCommons.utils.PeriodicTask](#src-only-package--RadCommons.utils.PeriodicTask)</small>


Helper class allowing to execute periodic (or one time) scheduled action



```csharp
internal static class PeriodicTask
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RunAsync(Action, TimeSpan, bool)](#m-net.adamec.lib.common.utils.periodictask.runasync_system.action-system.timespan-system.boolean___9mkw46) | public static | Schedule and run the periodic <strong>action</strong> | 
 | [RunAsync(Action, TimeSpan, CancellationToken, bool)](#m-net.adamec.lib.common.utils.periodictask.runasync_system.action-system.timespan-system.threading.cancellationtoken-system.boolean___uw465x) | public static | Schedule and run the periodic <strong>action</strong> | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.periodictask.runasync_system.action-system.timespan-system.boolean___9mkw46" />  PeriodicTask.RunAsync(Action, TimeSpan, bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [PeriodicTask](#t-net.adamec.lib.common.utils.periodictask__1xfynj)           
Sources: utils\PeriodicTask.cs           
Source-only packages: [RadCommons.utils.PeriodicTask](#src-only-package--RadCommons.utils.PeriodicTask)</small>


Schedule and run the periodic <strong>action</strong>



```csharp
public static Task RunAsync(Action action, TimeSpan period, bool oneTimeOnly = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action" target="_blank" >System.Action</a> <strong>action</strong></dt><dd>Action to be executed</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period between the individual runs (and even before the first run)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>oneTimeOnly</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.periodictask.runasync_system.action-system.timespan-system.threading.cancellationtoken-system.boolean___uw465x" />  PeriodicTask.RunAsync(Action, TimeSpan, CancellationToken, bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [PeriodicTask](#t-net.adamec.lib.common.utils.periodictask__1xfynj)           
Sources: utils\PeriodicTask.cs           
Source-only packages: [RadCommons.utils.PeriodicTask](#src-only-package--RadCommons.utils.PeriodicTask)</small>


Schedule and run the periodic <strong>action</strong>



```csharp
public static async Task RunAsync(Action action, TimeSpan period, CancellationToken cancellationToken, bool oneTimeOnly = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action" target="_blank" >System.Action</a> <strong>action</strong></dt><dd>Action to be executed</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period between the individual runs (and even before the first run)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken" target="_blank" >System.Threading.CancellationToken</a> <strong>cancellationToken</strong></dt><dd>Cancellation token used to cancel the (periodic) task execution.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>oneTimeOnly</strong></dt><dd>Flag whether the action should run one time only (after the given <strong>period</strong> )</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
The <strong>cancellationToken</strong> interrupts the period/waiting loop, but not the action itself. The method doesn&#39;t create any additional thread or worker, it&#39;s the responsibility of the caller is needed.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>action</strong> , <strong>period</strong> or <strong>cancellationToken</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.processeventargs__1gw60ix" />  ProcessEventArgs Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The ProcessEventArgs are arguments for a console event.



```csharp
public class ProcessEventArgs : EventArgs
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventargs" target="_blank" >System.EventArgs</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Code](#p-net.adamec.lib.common.utils.processeventargs.code__q4uuts) | public | Gets the process exit code. | 
 | [Content](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m) | public | Gets the process input/output content. | 
 | [IsError](#p-net.adamec.lib.common.utils.processeventargs.iserror__1dgcqs1) | public | Flag whether the [Content](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m) is from error stream (true) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ProcessEventArgs(int, string)](#m-net.adamec.lib.common.utils.processeventargs.-ctor_system.int32-system.string___12x7loh) | public | CTOR with code | 
 | [ProcessEventArgs(string, bool)](#m-net.adamec.lib.common.utils.processeventargs.-ctor_system.string-system.boolean___1ey6l7b) | public | CTOR with content | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processeventargs.code__q4uuts" />  ProcessEventArgs.Code Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Gets the process exit code.



```csharp
public int Code { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processeventargs.content__dgou0m" />  ProcessEventArgs.Content Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Gets the process input/output content.



```csharp
public string Content { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processeventargs.iserror__1dgcqs1" />  ProcessEventArgs.IsError Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Flag whether the [Content](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m) is from error stream (true)



```csharp
public bool IsError { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processeventargs.-ctor_system.int32-system.string___12x7loh" />  ProcessEventArgs.ProcessEventArgs(int, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


CTOR with code



```csharp
public ProcessEventArgs(int code, string command)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>code</strong></dt><dd>Process exit code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>command</strong></dt><dd>Command name to be set to the args [Content](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m)</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processeventargs.-ctor_system.string-system.boolean___1ey6l7b" />  ProcessEventArgs.ProcessEventArgs(string, bool) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


CTOR with content



```csharp
public ProcessEventArgs(string content, bool isError = false)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>content</strong></dt><dd>The content output from or input to process</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isError</strong></dt><dd>Flag whether the [Content](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m) is from error stream (true)</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.processutils__tzt3e1" />  ProcessUtils Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\ProcessUtils.cs           
Source-only packages: [RadCommons.utils.ProcessUtils](#src-only-package--RadCommons.utils.ProcessUtils)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process" target="_blank" >System.Diagnostics.Process</a> related utilities



```csharp
internal static class ProcessUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RunCommand(string, string, string, string)](#m-net.adamec.lib.common.utils.processutils.runcommand_system.string-system.string-system.string-system.string-___vsf405) | public static | Synchronously runs a command (process) and returns the standard output or error text | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processutils.runcommand_system.string-system.string-system.string-system.string-___vsf405" />  ProcessUtils.RunCommand(string, string, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessUtils](#t-net.adamec.lib.common.utils.processutils__tzt3e1)           
Sources: utils\ProcessUtils.cs           
Source-only packages: [RadCommons.utils.ProcessUtils](#src-only-package--RadCommons.utils.ProcessUtils)</small>


Synchronously runs a command (process) and returns the standard output or error text



```csharp
public static bool RunCommand(string command, string args, string workingDirectory, out string outputOrError)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>command</strong></dt><dd>Command to run</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>args</strong></dt><dd>Command line arguments</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>workingDirectory</strong></dt><dd>Working directory</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>outputOrError</strong></dt><dd>OUT: the standard output or error text</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True is process runs OK ( <strong>outputOrError</strong> is standard output) or false in case of exception or command error ( <strong>outputOrError</strong> is the error output or exception message)</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>command</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.processwrapper__1oqe83p" />  ProcessWrapper Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


A class the wraps a process, allowing programmatic input and output.



```csharp
public class ProcessWrapper
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [OutputWorkerPeriodMs](#f-net.adamec.lib.common.utils.processwrapper.outputworkerperiodms__vrr0db) | 100 |  | 

 


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [errorOutputWorker](#f-net.adamec.lib.common.utils.processwrapper.erroroutputworker__16ni2qe) | private | The error output worker. | 
 | [errorReader](#f-net.adamec.lib.common.utils.processwrapper.errorreader__q0q33e) | private | The error reader. | 
 | [inputWriter](#f-net.adamec.lib.common.utils.processwrapper.inputwriter__1vy4110) | private | The input writer. | 
 | [outputReader](#f-net.adamec.lib.common.utils.processwrapper.outputreader__1x6fvbr) | private | The output reader. | 
 | [stdOutputWorker](#f-net.adamec.lib.common.utils.processwrapper.stdoutputworker__cmgjmf) | private | The standard output worker. | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Command](#p-net.adamec.lib.common.utils.processwrapper.command__fluecw) | public | The command starting the process | 
 | [CommandArguments](#p-net.adamec.lib.common.utils.processwrapper.commandarguments__jgk6sk) | public | The command arguments. | 
 | [IsProcessRunning](#p-net.adamec.lib.common.utils.processwrapper.isprocessrunning__g9exf9) | public | Returns true when the process is running | 
 | [Process](#p-net.adamec.lib.common.utils.processwrapper.process__16lml00) | public | The internal process. | 
 | [WorkingDirectory](#p-net.adamec.lib.common.utils.processwrapper.workingdirectory__kyrfvj) | public | The command working directory. | 

 


###  Events ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [OnProcessExit](#e-net.adamec.lib.common.utils.processwrapper.onprocessexit__qmichq) | public | Occurs when the process ends. | 
 | [OnProcessOutput](#e-net.adamec.lib.common.utils.processwrapper.onprocessoutput__m4qoan) | public | Occurs when process output (incl. error stream) is produced. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ProcessWrapper()](#m-net.adamec.lib.common.utils.processwrapper.-ctor__32xh8z) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ErrorOutputWorkerDoWorkHandler(object, DoWorkEventArgs)](#m-net.adamec.lib.common.utils.processwrapper.erroroutputworkerdoworkhandler_system.object-system.componentmodel.doworkeventargs___16qj4ty) | private | Handles the DoWork event of the error output worker | 
 | [OutputWorkerProgressChangedHandler(object, ProgressChangedEventArgs)](#m-net.adamec.lib.common.utils.processwrapper.outputworkerprogresschangedhandler_system.object-system.componentmodel.progresschangedeventargs___2syz2c) | private | Handles the ProgressChanged event of the output worker | 
 | [ProcessExitedHandler(object, EventArgs)](#m-net.adamec.lib.common.utils.processwrapper.processexitedhandler_system.object-system.eventargs___u7crnb) | private | Handles the Exited event of the currentProcess control. | 
 | [ProcessOutput(BackgroundWorkerWithSyncCancel, TextReader, bool)](#m-net.adamec.lib.common.utils.processwrapper.processoutput_net.adamec.lib.common.utils.backgroundworkerwithsynccancel-system.io.textreader-system.boolean___132jrkz) | private | Processes the output from standard output or error output stream <strong>reader</strong> | 
 | [RaiseProcessExitEvent(int, string)](#m-net.adamec.lib.common.utils.processwrapper.raiseprocessexitevent_system.int32-system.string___1j8vxlz) | private | Raises OnProcessExit event | 
 | [RaiseProcessOutputEvent(ProcessWrapper.OutputChunk)](#m-net.adamec.lib.common.utils.processwrapper.raiseprocessoutputevent_net.adamec.lib.common.utils.processwrapper.outputchunk___11yhou) | private | Raises OnProcessOutput event | 
 | [StartProcess(string, string, string)](#m-net.adamec.lib.common.utils.processwrapper.startprocess_system.string-system.string-system.string___nt2z9o) | public | Runs a process with given <strong>command</strong> | 
 | [StdOutputWorkerDoWorkHandler(object, DoWorkEventArgs)](#m-net.adamec.lib.common.utils.processwrapper.stdoutputworkerdoworkhandler_system.object-system.componentmodel.doworkeventargs___1dqbwkp) | private | Handles the DoWork event of the standard output worker | 
 | [StopProcess()](#m-net.adamec.lib.common.utils.processwrapper.stopprocess__moyfm5) | public | Stops the process. | 
 | [WriteInput(string)](#m-net.adamec.lib.common.utils.processwrapper.writeinput_system.string___1vjk4n0) | public | Writes the input into the process | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.processwrapper.erroroutputworker__16ni2qe" />  ProcessWrapper.errorOutputWorker Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The error output worker.



```csharp
private readonly BackgroundWorkerWithSyncCancel errorOutputWorker
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.utils.BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.processwrapper.errorreader__q0q33e" />  ProcessWrapper.errorReader Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The error reader.



```csharp
private TextReader errorReader
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader" target="_blank" >System.IO.TextReader</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.processwrapper.inputwriter__1vy4110" />  ProcessWrapper.inputWriter Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The input writer.



```csharp
private StreamWriter inputWriter
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter" target="_blank" >System.IO.StreamWriter</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.processwrapper.outputreader__1x6fvbr" />  ProcessWrapper.outputReader Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The output reader.



```csharp
private TextReader outputReader
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader" target="_blank" >System.IO.TextReader</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.processwrapper.outputworkerperiodms__vrr0db" />  ProcessWrapper.OutputWorkerPeriodMs Constant ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>



```csharp
private const int OutputWorkerPeriodMs = 100
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.processwrapper.stdoutputworker__cmgjmf" />  ProcessWrapper.stdOutputWorker Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The standard output worker.



```csharp
private readonly BackgroundWorkerWithSyncCancel stdOutputWorker
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.utils.BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.command__fluecw" />  ProcessWrapper.Command Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The command starting the process



```csharp
public string Command { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.commandarguments__jgk6sk" />  ProcessWrapper.CommandArguments Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The command arguments.



```csharp
public string CommandArguments { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.isprocessrunning__g9exf9" />  ProcessWrapper.IsProcessRunning Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Returns true when the process is running



```csharp
public bool IsProcessRunning { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.process__16lml00" />  ProcessWrapper.Process Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The internal process.



```csharp
public Process Process { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process" target="_blank" >System.Diagnostics.Process</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.workingdirectory__kyrfvj" />  ProcessWrapper.WorkingDirectory Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


The command working directory.



```csharp
public string WorkingDirectory { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="e-net.adamec.lib.common.utils.processwrapper.onprocessexit__qmichq" />  ProcessWrapper.OnProcessExit Event ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Occurs when the process ends.



```csharp
public ProcessEventHandler OnProcessExit
```

<strong>Event handler</strong><dl><dt>[net.adamec.lib.common.utils.ProcessEventHandler](#t-net.adamec.lib.common.utils.processeventhandler__8h5v6w)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="e-net.adamec.lib.common.utils.processwrapper.onprocessoutput__m4qoan" />  ProcessWrapper.OnProcessOutput Event ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Occurs when process output (incl. error stream) is produced.



```csharp
public ProcessEventHandler OnProcessOutput
```

<strong>Event handler</strong><dl><dt>[net.adamec.lib.common.utils.ProcessEventHandler](#t-net.adamec.lib.common.utils.processeventhandler__8h5v6w)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.-ctor__32xh8z" />  ProcessWrapper.ProcessWrapper() Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


CTOR



```csharp
public ProcessWrapper()
```

Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.erroroutputworkerdoworkhandler_system.object-system.componentmodel.doworkeventargs___16qj4ty" />  ProcessWrapper.ErrorOutputWorkerDoWorkHandler(object, DoWorkEventArgs) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Handles the DoWork event of the error output worker



```csharp
private void ErrorOutputWorkerDoWorkHandler(object sender, DoWorkEventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd>The source of the event</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.doworkeventargs" target="_blank" >System.ComponentModel.DoWorkEventArgs</a> <strong>e</strong></dt><dd>Event data</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.outputworkerprogresschangedhandler_system.object-system.componentmodel.progresschangedeventargs___2syz2c" />  ProcessWrapper.OutputWorkerProgressChangedHandler(object, ProgressChangedEventArgs) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Handles the ProgressChanged event of the output worker



```csharp
private void OutputWorkerProgressChangedHandler(object sender, ProgressChangedEventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd>The source of the event</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.progresschangedeventargs" target="_blank" >System.ComponentModel.ProgressChangedEventArgs</a> <strong>e</strong></dt><dd>Event data.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.processexitedhandler_system.object-system.eventargs___u7crnb" />  ProcessWrapper.ProcessExitedHandler(object, EventArgs) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Handles the Exited event of the currentProcess control.



```csharp
private void ProcessExitedHandler(object sender, EventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd>The source of the event.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventargs" target="_blank" >System.EventArgs</a> <strong>e</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventargs" target="_blank" >System.EventArgs</a> instance containing the event data.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.processoutput_net.adamec.lib.common.utils.backgroundworkerwithsynccancel-system.io.textreader-system.boolean___132jrkz" />  ProcessWrapper.ProcessOutput(BackgroundWorkerWithSyncCancel, TextReader, bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Processes the output from standard output or error output stream <strong>reader</strong>



```csharp
private void ProcessOutput(BackgroundWorkerWithSyncCancel worker, TextReader reader, bool isError)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.utils.BackgroundWorkerWithSyncCancel](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo) <strong>worker</strong></dt><dd>Worker providing the output</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader" target="_blank" >System.IO.TextReader</a> <strong>reader</strong></dt><dd>Standard output or error output stream reader to process</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isError</strong></dt><dd>Flag whether the output is to be marked as error</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.raiseprocessexitevent_system.int32-system.string___1j8vxlz" />  ProcessWrapper.RaiseProcessExitEvent(int, string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Raises OnProcessExit event



```csharp
private void RaiseProcessExitEvent(int code, string command)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>code</strong></dt><dd>The exit code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>command</strong></dt><dd>Command name to be set to the args Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.raiseprocessoutputevent_net.adamec.lib.common.utils.processwrapper.outputchunk___11yhou" />  ProcessWrapper.RaiseProcessOutputEvent(ProcessWrapper.OutputChunk) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Raises OnProcessOutput event



```csharp
private void RaiseProcessOutputEvent(ProcessWrapper.OutputChunk outputChunk)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.utils.ProcessWrapper.OutputChunk](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan) <strong>outputChunk</strong></dt><dd>The output from process</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.startprocess_system.string-system.string-system.string___nt2z9o" />  ProcessWrapper.StartProcess(string, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Runs a process with given <strong>command</strong>



```csharp
public bool StartProcess(string command, string arguments = null, string workingDirectory = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>command</strong></dt><dd>Name of the file to run</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>arguments</strong></dt><dd>Optional command line arguments</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>workingDirectory</strong></dt><dd>Optional working directory</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>command</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.stdoutputworkerdoworkhandler_system.object-system.componentmodel.doworkeventargs___1dqbwkp" />  ProcessWrapper.StdOutputWorkerDoWorkHandler(object, DoWorkEventArgs) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Handles the DoWork event of the standard output worker



```csharp
private void StdOutputWorkerDoWorkHandler(object sender, DoWorkEventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd>The source of the event</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.doworkeventargs" target="_blank" >System.ComponentModel.DoWorkEventArgs</a> <strong>e</strong></dt><dd>Event data</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.stopprocess__moyfm5" />  ProcessWrapper.StopProcess() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Stops the process.



```csharp
public void StopProcess()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.writeinput_system.string___1vjk4n0" />  ProcessWrapper.WriteInput(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Writes the input into the process



```csharp
public void WriteInput(string input)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>input</strong></dt><dd>The process input</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan" />  ProcessWrapper.OutputChunk Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


Internal class to hold the output chunk within the output worker



```csharp
protected class ProcessWrapper.OutputChunk
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsError](#p-net.adamec.lib.common.utils.processwrapper.outputchunk.iserror__1d9rwlz) | public |  | 
 | [Output](#p-net.adamec.lib.common.utils.processwrapper.outputchunk.output__1v5g27m) | public |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ProcessWrapper.OutputChunk(bool, string)](#m-net.adamec.lib.common.utils.processwrapper.outputchunk.-ctor_system.boolean-system.string___edttbd) | public |  | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.outputchunk.iserror__1d9rwlz" />  ProcessWrapper.OutputChunk.IsError Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper.OutputChunk](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>



```csharp
public bool IsError { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.processwrapper.outputchunk.output__1v5g27m" />  ProcessWrapper.OutputChunk.Output Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper.OutputChunk](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>



```csharp
public string Output { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.processwrapper.outputchunk.-ctor_system.boolean-system.string___edttbd" />  ProcessWrapper.OutputChunk.ProcessWrapper.OutputChunk(bool, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [ProcessWrapper.OutputChunk](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan)           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>



```csharp
public ProcessWrapper.OutputChunk(bool isError, string output)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isError</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>output</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.scope-1__eepqvi" />  Scope&lt;TState&gt; Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Base scope implementation.



```csharp
internal class Scope<TState> : BaseDisposable, IScope<TState> where TState: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>TState</strong></dt><dd>Type of the state object managed by the scope</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; net.adamec.lib.common.core.utils.BaseDisposable           
Implements: [net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf), <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Remarks ###
The scope can be both state-less and state-full and it&#39;s valid until it&#39;s disposed. The scopes can be nested, when the scope is disposed, the children are disposed as well. There can be multiple child scopes (siblings) living in parallel. The [AddToDisposer(IDisposable)](#m-net.adamec.lib.common.utils.scope-1.addtodisposer_system.idisposable___154ejbt) method is to be used in inherited classes whenever they manage any disposable resource to ensure the proper life time (when the [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar) is <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> , it&#39;s added to disposer automatically). The base implementation just manages the life time, child scopes and keeps the state (when provided). Inherit from the [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) (and [IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf) ) to add the scope related operations (inherited classes have the access to [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar) ).




###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [ScopeDisposedMessage](#f-net.adamec.lib.common.utils.scope-1.scopedisposedmessage__12oxry0) | The scope has been disposed | Error message that will be put into the exception when there will be any operation on the disposed scope. | 

 


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [parentScope](#f-net.adamec.lib.common.utils.scope-1.parentscope__h8qyu6) | private | Parent scope. | 
 | [RootInternal](#f-net.adamec.lib.common.utils.scope-1.rootinternal__coycy3) | private static | Instance of the [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) created when the singleton is first touched - root scope with default [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar) | 
 | [scopeState](#f-net.adamec.lib.common.utils.scope-1.scopestate__16lomdz) | private | State managed by the scope. | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) | private | Gets the disposer associated with this container. | 
 | [Parent](#p-net.adamec.lib.common.utils.scope-1.parent__1hk8ypk) | public | Gets the parent scope. | 
 | [Root](#p-net.adamec.lib.common.utils.scope-1.root__17hnd9c) | public static | Gets the root scope. | 
 | [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar) | protected | Gets the state managed by the scope. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Scope&lt;TState&gt;()](#m-net.adamec.lib.common.utils.scope-1.-cctor__1t7jr8v) | private static | Static constructor | 
 | [Scope&lt;TState&gt;(IScope&lt;TState&gt;, Scope&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.scope-1.-ctor_net.adamec.lib.common.utils.iscope_-0_--0___a63u7z) | protected | Creates an instance of child [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) . | 
 | [Scope&lt;TState&gt;(Scope&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.scope-1.-ctor_-0___17usleh) | private | Creates an instance of [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) and initialize its [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) . | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddToDisposer(IDisposable)](#m-net.adamec.lib.common.utils.scope-1.addtodisposer_system.idisposable___154ejbt) | protected | Adds the <strong>disposable</strong> object to the scope disposer, so it will be disposed with the scope | 
 | [BeginScope(Scope&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.scope-1.beginscope_-0___1bcz3lp) | public | Creates a child scope of the current scope. | 
 | [DisposeManaged()](#m-net.adamec.lib.common.utils.scope-1.disposemanaged__19g6lc3) | protected | Dispose any disposable managed objects - all disposables kept in [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) stack are pop and disposed. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.scope-1.parentscope__h8qyu6" />  Scope&lt;TState&gt;.parentScope Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Parent scope.



```csharp
private readonly IScope<TState> parentScope
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.scope-1.rootinternal__coycy3" />  Scope&lt;TState&gt;.RootInternal Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Instance of the [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) created when the singleton is first touched - root scope with default [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar)



```csharp
private static readonly Scope<TState> RootInternal
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.utils.Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)</dt><dd></dd></dl>


###  Remarks ###
Not using the auto-property to have better control, when the instance is created


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.scope-1.scopedisposedmessage__12oxry0" />  Scope&lt;TState&gt;.ScopeDisposedMessage Constant ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Error message that will be put into the exception when there will be any operation on the disposed scope.



```csharp
private const string ScopeDisposedMessage = "The scope has been disposed"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.scope-1.scopestate__16lomdz" />  Scope&lt;TState&gt;.scopeState Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


State managed by the scope.



```csharp
private readonly Scope<TState>.TState scopeState
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.utils.Scope&lt;TState&gt;.TState</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt" />  Scope&lt;TState&gt;.Disposer Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Gets the disposer associated with this container.



```csharp
private Disposer Disposer { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.scope-1.parent__1hk8ypk" />  Scope&lt;TState&gt;.Parent Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Gets the parent scope.



```csharp
public IScope<TState> Parent { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)</dt><dd></dd></dl>Implements: [IScope&lt;TState&gt;.Parent](#p-net.adamec.lib.common.utils.iscope-1.parent__iyc99h)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current scope has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.scope-1.root__17hnd9c" />  Scope&lt;TState&gt;.Root Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Gets the root scope.



```csharp
public static Scope<TState> Root { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.scope-1.state__78jkar" />  Scope&lt;TState&gt;.State Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Gets the state managed by the scope.



```csharp
protected Scope<TState>.TState State { get; }
```

<strong>Property value</strong><dl><dt>net.adamec.lib.common.utils.Scope&lt;TState&gt;.TState</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current scope has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.scope-1.-cctor__1t7jr8v" />  Scope&lt;TState&gt;.Scope&lt;TState&gt;() Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Static constructor



```csharp
private static Scope<TState>()
```

###  Remarks ###
Explicit static constructor to tell C# compiler not to mark type as beforefieldinit


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.scope-1.-ctor_net.adamec.lib.common.utils.iscope_-0_--0___a63u7z" />  Scope&lt;TState&gt;.Scope&lt;TState&gt;(IScope&lt;TState&gt;, Scope&lt;TState&gt;.TState) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Creates an instance of child [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) .



```csharp
protected Scope<TState>(IScope<TState> parent, Scope<TState>.TState state = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf) <strong>parent</strong></dt><dd>Parent scope</dd><dt>net.adamec.lib.common.utils.Scope&lt;TState&gt;.TState <strong>state</strong></dt><dd>Optional state managed by the scope.</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.scope-1.-ctor_-0___17usleh" />  Scope&lt;TState&gt;.Scope&lt;TState&gt;(Scope&lt;TState&gt;.TState) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Creates an instance of [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) and initialize its [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) .



```csharp
private Scope<TState>(Scope<TState>.TState state = null)
```

<strong>Constructor parameters</strong><dl><dt>net.adamec.lib.common.utils.Scope&lt;TState&gt;.TState <strong>state</strong></dt><dd>Optional state managed by the scope.</dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.scope-1.addtodisposer_system.idisposable___154ejbt" />  Scope&lt;TState&gt;.AddToDisposer(IDisposable) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Adds the <strong>disposable</strong> object to the scope disposer, so it will be disposed with the scope



```csharp
protected void AddToDisposer(IDisposable disposable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a> <strong>disposable</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> object to be added to the disposer.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>disposable</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current scope has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.scope-1.beginscope_-0___1bcz3lp" />  Scope&lt;TState&gt;.BeginScope(Scope&lt;TState&gt;.TState) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Creates a child scope of the current scope.



```csharp
public IScope<TState> BeginScope(Scope<TState>.TState state = null)
```

<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.utils.Scope&lt;TState&gt;.TState <strong>state</strong></dt><dd>Optional state managed by the child scope..</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)</dt><dd>Child scope owned by the current scope.</dd></dl>Implements: [IScope&lt;TState&gt;.BeginScope(IScope&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.iscope-1.beginscope_-0___1d7nxoa)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>The current scope has been disposed.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.scope-1.disposemanaged__19g6lc3" />  Scope&lt;TState&gt;.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Dispose any disposable managed objects - all disposables kept in [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) stack are pop and disposed.



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: utils.BaseDisposable.DisposeManaged


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.txt__1fch6k9" />  Txt Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Text builder



```csharp
public class Txt
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [builder](#f-net.adamec.lib.common.utils.txt.builder__137g30a) | private | Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a> | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Txt()](#m-net.adamec.lib.common.utils.txt.-ctor__41ctkn) | public | Creates a new empty text builder | 
 | [Txt(string)](#m-net.adamec.lib.common.utils.txt.-ctor_system.string___zqpefu) | public | Creates a new text builder with initial <strong>text</strong> | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(Func&lt;string&gt;)](#m-net.adamec.lib.common.utils.txt.add_system.func_system.string____xzdmt3) | public | Adds the text returned from <strong>textFunc</strong> to the text builder | 
 | [Add(string)](#m-net.adamec.lib.common.utils.txt.add_system.string___lgx7f6) | public | Adds the <strong>text</strong> to the text builder | 
 | [AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string)](#m-net.adamec.lib.common.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1pfl3rh) | public | Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder. | 
 | [AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string)](#m-net.adamec.lib.common.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___kykhox) | public | Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [AddIf(Func&lt;string&gt;, bool)](#m-net.adamec.lib.common.utils.txt.addif_system.func_system.string_-system.boolean___ogucu7) | public | Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [AddIf(string, bool)](#m-net.adamec.lib.common.utils.txt.addif_system.string-system.boolean___1qmz3e2) | public | Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [Clear()](#m-net.adamec.lib.common.utils.txt.clear__11a2n7) | public | Clear the text builder | 
 | [Start(string)](#m-net.adamec.lib.common.utils.txt.start_system.string___og05dp) | public static | Creates a new instance ot [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder with optional initial <strong>text</strong> | 
 | [ToString()](#m-net.adamec.lib.common.utils.txt.tostring__17wjkjc) | public | Returns the text content of the text builder | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(Txt, Txt)](#m-net.adamec.lib.common.utils.txt.op_addition_net.adamec.lib.common.utils.txt-net.adamec.lib.common.utils.txt___14gnt2r) | public static | Concatenates the contents of two text builders | 
 | [BitwiseOr(Txt, Txt)](#m-net.adamec.lib.common.utils.txt.op_bitwiseor_net.adamec.lib.common.utils.txt-net.adamec.lib.common.utils.txt___84qns5) | public static | Concatenates the contents of two text builders | 
 | [From(string)](#m-net.adamec.lib.common.utils.txt.op_implicit_system.string_dtornet.adamec.lib.common.utils.txt__15d874r) | public static | Creates a new instance ot [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder with optional initial <strong>text</strong> | 
 | [ToString(Txt)](#m-net.adamec.lib.common.utils.txt.op_implicit_net.adamec.lib.common.utils.txt_dtorsystem.string__1e7zirr) | public static | Converts the text builder to string containing its content | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="f-net.adamec.lib.common.utils.txt.builder__137g30a" />  Txt.builder Field ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a>



```csharp
private readonly StringBuilder builder
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.-ctor__41ctkn" />  Txt.Txt() Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Creates a new empty text builder



```csharp
public Txt()
```

Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.-ctor_system.string___zqpefu" />  Txt.Txt(string) Constructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Creates a new text builder with initial <strong>text</strong>



```csharp
public Txt(string text)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.add_system.func_system.string____xzdmt3" />  Txt.Add(Func&lt;string&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Adds the text returned from <strong>textFunc</strong> to the text builder



```csharp
public Txt Add(Func<string> textFunc)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.add_system.string___lgx7f6" />  Txt.Add(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Adds the <strong>text</strong> to the text builder



```csharp
public Txt Add(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1pfl3rh" />  Txt.AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder.



```csharp
public Txt AddEach<TItemType>(Func<TItemType,string> textFunc, IEnumerable<TItemType> items, string separator = null)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Items to generate the output for via <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Optional separator</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___kykhox" />  Txt.AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddEachIf<TItemType>(Func<TItemType,string> textFunc, IEnumerable<TItemType> items, bool condition, string separator = null)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Items to generate the output for via <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Optional separator</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


###  Remarks ###
The <strong>condition</strong> is evaluated once at the beginning of method execution, not for each item.


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.addif_system.func_system.string_-system.boolean___ogucu7" />  Txt.AddIf(Func&lt;string&gt;, bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddIf(Func<string> textFunc, bool condition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>textFunc</strong></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.addif_system.string-system.boolean___1qmz3e2" />  Txt.AddIf(string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddIf(string text, bool condition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>text</strong></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


###  Remarks ###
If using some code/variable to generate the <strong>text</strong> (for example `AddIf(obj.Container.Text, obj.Container != null)` , the parameter will be evaluated even if the condition is not true ! So the example here will throw NPE when the `obj.Container` is null. Use [AddIf(Func&lt;string&gt;, bool)](#m-net.adamec.lib.common.utils.txt.addif_system.func_system.string_-system.boolean___ogucu7) ( `AddIf(()=>obj.Container.Text, obj.Container != null)` ) when the function should not be evaluated. Of course `AddIf(obj?.Container?.Text, obj?.Container != null)` null checks are also valid solution.


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.clear__11a2n7" />  Txt.Clear() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Clear the text builder



```csharp
public Txt Clear()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Itself</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.start_system.string___og05dp" />  Txt.Start(string) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Creates a new instance ot [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder with optional initial <strong>text</strong>



```csharp
public static Txt Start(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Optional initial text</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>A new instance of [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.tostring__17wjkjc" />  Txt.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Returns the text content of the text builder



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The text content of the text builder</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.op_addition_net.adamec.lib.common.utils.txt-net.adamec.lib.common.utils.txt___14gnt2r" />  Txt.Add(Txt, Txt) Operator ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Concatenates the contents of two text builders



```csharp
public static Txt operator +(Txt txt1, Txt txt2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) <strong>txt1</strong></dt><dd></dd><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) <strong>txt2</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>The first text builder ( <strong>txt1</strong> ) with added text when <strong>txt1</strong> is not null. The second text builder ( <strong>txt2</strong> ) when <strong>txt1</strong> is null. New empty text builder instance when both operands are null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.op_bitwiseor_net.adamec.lib.common.utils.txt-net.adamec.lib.common.utils.txt___84qns5" />  Txt.BitwiseOr(Txt, Txt) Operator ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Concatenates the contents of two text builders



```csharp
public static Txt operator |(Txt txt1, Txt txt2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) <strong>txt1</strong></dt><dd></dd><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) <strong>txt2</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>The first text builder ( <strong>txt1</strong> ) with added text when <strong>txt1</strong> is not null. The second text builder ( <strong>txt2</strong> ) when <strong>txt1</strong> is null. New empty text builder instance when both operands are null</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.op_implicit_system.string_dtornet.adamec.lib.common.utils.txt__15d874r" />  Txt.From(string) Conversion ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Creates a new instance ot [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder with optional initial <strong>text</strong>



```csharp
public static Txt op_Implicit(string text)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Optional initial text</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>A new instance of [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.txt.op_implicit_net.adamec.lib.common.utils.txt_dtorsystem.string__1e7zirr" />  Txt.ToString(Txt) Conversion ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9)           
Sources: utils\Txt.cs           
Source-only packages: [RadCommons.utils.Txt](#src-only-package--RadCommons.utils.Txt)</small>


Converts the text builder to string containing its content



```csharp
public static string op_Implicit(Txt txt)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.lib.common.utils.Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) <strong>txt</strong></dt><dd>Text builder</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.iscope-1__88aydf" />  IScope&lt;TState&gt; Interface ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Scope interface.



```csharp
internal interface IScope<in TState> : IDisposable where TState: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>TState</strong></dt><dd>Type of the state object managed by the scope</dd></dl>
Implemented by: [net.adamec.lib.common.utils.Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Parent](#p-net.adamec.lib.common.utils.iscope-1.parent__iyc99h) | public abstract | Gets the parent scope. | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BeginScope(IScope&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.iscope-1.beginscope_-0___1d7nxoa) | public abstract | Creates a child scope of the current scope. | 

 


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.iscope-1.parent__iyc99h" />  IScope&lt;TState&gt;.Parent Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Gets the parent scope.



```csharp
public abstract IScope<TState> Parent { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.iscope-1.beginscope_-0___1d7nxoa" />  IScope&lt;TState&gt;.BeginScope(IScope&lt;TState&gt;.TState) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Type: [IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)           
Sources: utils\Scope.cs           
Source-only packages: [RadCommons.utils.Scope](#src-only-package--RadCommons.utils.Scope)</small>


Creates a child scope of the current scope.



```csharp
public abstract IScope<TState> BeginScope(IScope<TState>.TState state)
```

<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.utils.IScope&lt;TState&gt;.TState <strong>state</strong></dt><dd>State managed by the child scope.</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.utils.IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf)</dt><dd>Child scope owned by the current scope.</dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.processeventhandler__8h5v6w" />  ProcessEventHandler Delegate ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common           
Sources: utils\ProcessWrapper.cs           
Source-only packages: [RadCommons.utils.ProcessWrapper](#src-only-package--RadCommons.utils.ProcessWrapper)</small>


A ProcessEventHandler is a delegate for process output events.



```csharp
public delegate void ProcessEventHandler(object sender, ProcessEventArgs args)
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


<strong>Delegate parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd>The event sender</dd><dt>[net.adamec.lib.common.utils.ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix) <strong>args</strong></dt><dd>The [ProcessEventArgs](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix) instance containing the event data</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.async.AsyncManager" />  RadCommons.async.AsyncManager Source only package ##
<small>Tags: RadCommons source-only async           
Includes: None           
Declaring file: async\AsyncManager.cs</small>


Helpers for running the async tasks in sync mode and executing sync actions in async mode (Source only package).


<strong>Package members</strong><dl><dt>[AsyncManager (Type)](#t-net.adamec.lib.common.async.asyncmanager__16s0tm9)</dt><dd>Helpers for running the actions in sync or async mode</dd><dt>[DefaultExceptionHandler (Field)](#f-net.adamec.lib.common.async.asyncmanager.defaultexceptionhandler__1ltk17x)</dt><dd>Default exception handler for [RunAsync(Action, Action&lt;System.Exception&gt;)](#m-net.adamec.lib.common.async.asyncmanager.runasync_system.action-system.action_system.exception____s187qk) . Catches all exceptions during the task execution.</dd><dt>[RunAsync(Action, Action&lt;System.Exception&gt;) (Method)](#m-net.adamec.lib.common.async.asyncmanager.runasync_system.action-system.action_system.exception____s187qk)</dt><dd>Runs the given <strong>action</strong> asynchronously.</dd><dt>[RunSync(Func&lt;System.Threading.Tasks.Task&gt;) (Method)](#m-net.adamec.lib.common.async.asyncmanager.runsync_system.func_system.threading.tasks.task____10vlbqi)</dt><dd>Executes synchronously an async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a> method which has a void return value</dd><dt>[RunSync&lt;T&gt;(Func&lt;System.Threading.Tasks.Task&lt;T&gt;&gt;) (Method)](#m-net.adamec.lib.common.async.asyncmanager.runsync--1_system.func_system.threading.tasks.task_--0_____jg6lmv)</dt><dd>Executes synchronously an async <a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task`1</a> method which has a <strong>T</strong> return type</dd><dt>[AsyncManager.ExclusiveSynchronizationContext (Type)](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)</dt><dd>&quot;Private&quot; synchronization context used to run the async method</dd><dt>[done (Field)](#f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.done__1ogbce6)</dt><dd></dd><dt>[InnerException (Property)](#p-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.innerexception__1hzeemf)</dt><dd></dd><dt>[workItemsWaiting (Field)](#f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.workitemswaiting__9nlexs)</dt><dd></dd><dt>[items (Field)](#f-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.items__f5et9q)</dt><dd></dd><dt>[Send(SendOrPostCallback, object) (Method)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.send_system.threading.sendorpostcallback-system.object___b8nnwz)</dt><dd>Dispatches a synchronous message to a synchronization context. Always throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.notsupportedexception" target="_blank" >System.NotSupportedException</a> as it&#39;s not supported in [AsyncManager.ExclusiveSynchronizationContext](#t-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext__jzepyu)</dd><dt>[Post(SendOrPostCallback, object) (Method)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.post_system.threading.sendorpostcallback-system.object___850uof)</dt><dd>Dispatches an asynchronous message to a synchronization context.</dd><dt>[EndMessageLoop() (Method)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.endmessageloop__oqnlxn)</dt><dd>Finish the message loop</dd><dt>[BeginMessageLoop() (Method)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.beginmessageloop__xkfq9n)</dt><dd>Starts the message loop</dd><dt>[CreateCopy() (Method)](#m-net.adamec.lib.common.async.asyncmanager.exclusivesynchronizationcontext.createcopy__1vp2evu)</dt><dd>Creates a &quot;copy&quot; of the synchronization context.</dd></dl>


<strong>Sources</strong><dl><dt>async\AsyncManager.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.async.FileAsync" />  RadCommons.async.FileAsync Source only package ##
<small>Tags: RadCommons source-only async text-files           
Includes: None           
Declaring file: async\FileAsync.cs</small>


Helpers for reading text files in async mode (Source only package).


<strong>Package members</strong><dl><dt>[FileAsync (Type)](#t-net.adamec.lib.common.async.fileasync__158f1hu)</dt><dd>Asynchronous text/lines file read methods https://stackoverflow.com/a/13168006</dd><dt>[DefaultBufferSize (Field)](#f-net.adamec.lib.common.async.fileasync.defaultbuffersize__1n8kkos)</dt><dd>This is the same default buffer size as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader" target="_blank" >System.IO.StreamReader</a> and <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream" target="_blank" >System.IO.FileStream</a> .</dd><dt>[DefaultOptions (Field)](#f-net.adamec.lib.common.async.fileasync.defaultoptions__bsw6k3)</dt><dd>Indicates that 1. The file is to be used for asynchronous reading. 2. The file is to be accessed sequentially from beginning to end.</dd><dt>[ReadAllLinesAsync(string) (Method)](#m-net.adamec.lib.common.async.fileasync.readalllinesasync_system.string___lhe54c)</dt><dd>Opens a text file, reads all lines of the file, and then closes the file.</dd><dt>[ReadAllLinesAsync(string, Encoding) (Method)](#m-net.adamec.lib.common.async.fileasync.readalllinesasync_system.string-system.text.encoding___ktl1mr)</dt><dd>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</dd><dt>[ReadAllTextAsync(string) (Method)](#m-net.adamec.lib.common.async.fileasync.readalltextasync_system.string___1piiha4)</dt><dd>Opens a text file, reads all lines of the file, and then closes the file.</dd><dt>[ReadAllTextAsync(string, Encoding) (Method)](#m-net.adamec.lib.common.async.fileasync.readalltextasync_system.string-system.text.encoding___yqlzqn)</dt><dd>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</dd></dl>


<strong>Sources</strong><dl><dt>async\FileAsync.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.di.Component" />  RadCommons.di.Component Source only package ##
<small>Tags: RadCommons source-only RadCommons-DI dependency-injection components           
Includes: Folder           
Declaring file: di\component\_SourceOnlyPackage.cs</small>


RadCommons DI Component - allows to mark and inject the component using the class attributes (Source only package).


<strong>References needed</strong><dl><dt>Autofac</dt><dd></dd></dl>


<strong>Package members</strong><dl><dt>[ComponentAttribute (Type)](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl)</dt><dd>Marks the decorated class as a component that will be available from the service locator / component container.</dd><dt>[RegisterAs (Property)](#p-net.adamec.lib.common.di.component.componentattribute.registeras__1m8nlcq)</dt><dd>Type to use for the component registration.</dd><dt>[ImplicitRegistrationType (Property)](#p-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtype__1mysue9)</dt><dd>Flag how to do the implicit registration when no types are explicitly defined</dd><dt>[Scope (Property)](#p-net.adamec.lib.common.di.component.componentattribute.scope__1h6i43p)</dt><dd>Defines the instance scope</dd><dt>[ComponentAttribute(ComponentAttribute.ImplicitRegistrationTypeEnum, ComponentAttribute.ScopeEnum) (Method)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum-net.adamec.lib.common.di.component.componentattribute.scopeenum___ex53ua)</dt><dd>Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container, registered as the concrete type or with all implemented interfaces as well if specified.</dd><dt>[ComponentAttribute(Type, ComponentAttribute.ScopeEnum) (Method)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type-net.adamec.lib.common.di.component.componentattribute.scopeenum___1ubqgal)</dt><dd>Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> type.</dd><dt>[ComponentAttribute(Type[], ComponentAttribute.ScopeEnum) (Method)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type__-net.adamec.lib.common.di.component.componentattribute.scopeenum___1rdjiuf)</dt><dd>Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> types.</dd><dt>[ComponentAttribute(Type[], net.adamec.lib.common.di.component.ComponentAttribute.ImplicitRegistrationTypeEnum?, ComponentAttribute.ScopeEnum) (Method)](#m-net.adamec.lib.common.di.component.componentattribute.-ctor_system.type__-system.nullable_net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum_-net.adamec.lib.common.di.component.componentattribute.scopeenum___1h4ujev)</dt><dd>Initializes a new instance of the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) class, marking the decorated class as a component that will be available from the component container using the specified <strong>registerAs</strong> types.</dd><dt>[ComponentAttribute.ScopeEnum (Type)](#t-net.adamec.lib.common.di.component.componentattribute.scopeenum__r7ahps)</dt><dd>Component scope</dd><dt>[InstancePerDependency (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperdependency__1efcen7)</dt><dd>Transient scope (instance per dependency)</dd><dt>[Transient (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.transient__1f6925u)</dt><dd>Transient scope (instance per dependency)</dd><dt>[SingleInstance (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.singleinstance__st19r1)</dt><dd>Singleton</dd><dt>[Singleton (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.singleton__1p12io5)</dt><dd>Singleton</dd><dt>[InstancePerLifetimeScope (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperlifetimescope__17fxlux)</dt><dd>Instance per lifetime scope</dd><dt>[InstancePerRequest (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.instanceperrequest__12s64w1)</dt><dd>Instance per request (scoped)</dd><dt>[Scoped (Field)](#f-net.adamec.lib.common.di.component.componentattribute.scopeenum.scoped__1356nu4)</dt><dd>Instance per request (scoped)</dd><dt>[ComponentAttribute.ImplicitRegistrationTypeEnum (Type)](#t-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum__10jaypo)</dt><dd>Kind of the implicit component registration</dd><dt>[Self (Field)](#f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.self__qkcsxq)</dt><dd>Register as self (type) only</dd><dt>[ImplementedInterfaces (Field)](#f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.implementedinterfaces__n5lxu0)</dt><dd>Register as all implemented interfaces</dd><dt>[SelfAndImplementedInterfaces (Field)](#f-net.adamec.lib.common.di.component.componentattribute.implicitregistrationtypeenum.selfandimplementedinterfaces__1135ahd)</dt><dd>Register as self (type) and all implemented interfaces</dd><dt>[ContainerBuilderExtensions (Type)](#t-net.adamec.lib.common.di.component.containerbuilderextensions__lgbl4y)</dt><dd>Autofac <em>Autofac.ContainerBuilder</em> extensions</dd><dt>[AddServicesWithComponentAttribute(ContainerBuilder, Assembly[]) (Method)](#m-net.adamec.lib.common.di.component.containerbuilderextensions.addserviceswithcomponentattribute_autofac.containerbuilder-system.reflection.assembly_____5belzz)</dt><dd>Adds classes from the <strong>assemblies</strong> having the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) into Autofac container <strong>builder</strong></dd><dt>[AddServicesWithComponentAttribute(ContainerBuilder, Type[]) (Method)](#m-net.adamec.lib.common.di.component.containerbuilderextensions.addserviceswithcomponentattribute_autofac.containerbuilder-system.type_____zsnrga)</dt><dd>Adds classes from array of <strong>types</strong> having the [ComponentAttribute](#t-net.adamec.lib.common.di.component.componentattribute__170qqzl) into Autofac container <strong>builder</strong></dd><dt>[Register&lt;TLimit,TActivatorData,TRegistrationStyle&gt;(IRegistrationBuilder&lt;TLimit,TActivatorData,TRegistrationStyle&gt;, Type, ComponentAttribute) (Method)](#m-net.adamec.lib.common.di.component.containerbuilderextensions.register--3_autofac.builder.iregistrationbuilder_--0---1---2_-system.type-net.adamec.lib.common.di.component.componentattribute___9sj1q8)</dt><dd>Registers the <strong>type</strong> with <strong>componentAttribute</strong> using the Autofac container <strong>builder</strong></dd><dt>[GetImplementedInterfaces(Type) (Method)](#m-net.adamec.lib.common.di.component.containerbuilderextensions.getimplementedinterfaces_system.type___vb1m0d)</dt><dd>Gets the array of interfaces implemented by given <strong>type</strong> except the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> interface</dd><dt>[NamedComponentRegistrationAttribute (Type)](#t-net.adamec.lib.common.di.component.namedcomponentregistrationattribute__158ujcr)</dt><dd>Defines the registration name and type for named registration (component type will be used if null)</dd><dt>[Name (Property)](#p-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.name__12kb1kq)</dt><dd>Registration name</dd><dt>[Type (Property)](#p-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.type__1egg26x)</dt><dd>Registrations type for named registration. Component type will be used if null</dd><dt>[NamedComponentRegistrationAttribute(string) (Method)](#m-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.-ctor_system.string___15ni23w)</dt><dd>Named registration with component type used</dd><dt>[NamedComponentRegistrationAttribute(string, Type) (Method)](#m-net.adamec.lib.common.di.component.namedcomponentregistrationattribute.-ctor_system.string-system.type___1m420ct)</dt><dd>Defines the registration name and type for named registration (component type will be used if null)</dd></dl>


<strong>Sources</strong><dl><dt>di\component\_SourceOnlyPackage.cs</dt><dd></dd><dt>di\component\ComponentAttribute.cs</dt><dd></dd><dt>di\component\ContainerBuilderExtensions.cs</dt><dd></dd><dt>di\component\NamedComponentRegistrationAttribute.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.di.Config" />  RadCommons.di.Config Source only package ##
<small>Tags: RadCommons source-only RadCommons-DI dependency-injection configuration           
Includes: FolderRecursive           
Declaring file: di\config\_SourceOnlyPackage.cs</small>


RadCommons DI helpers for application configuration (Source only package).


<strong>Usings</strong><dl><dt>RadCommons.logging.CommonLogging</dt><dd></dd></dl>


<strong>References needed</strong><dl><dt>Autofac</dt><dd></dd><dt>Microsoft.Extensions.Configuration</dt><dd></dd><dt>Microsoft.Extensions.DependencyInjection</dt><dd></dd></dl>


<strong>Package members</strong><dl><dt>[AutoOptionsAttribute (Type)](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2)</dt><dd>Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI</dd><dt>[RegisterDirect (Property)](#p-net.adamec.lib.common.di.config.autooptionsattribute.registerdirect__1s9s1yk)</dt><dd>Flag whether to create and registers the options class instance into MS DI</dd><dt>[ConfigSection (Property)](#p-net.adamec.lib.common.di.config.autooptionsattribute.configsection__zo6f6l)</dt><dd>Path to the section within appsettings.json</dd><dt>[AutoOptionsAttribute(string, bool) (Method)](#m-net.adamec.lib.common.di.config.autooptionsattribute.-ctor_system.string-system.boolean___1nw898o)</dt><dd>Class attribute allowing the auto registration of options class into .NET Core configuration framework and optional direct registration of singleton instance into MS DI</dd><dt>[ServiceCollectionAutoOptionsException (Type)](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dt><dd>Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionAutoOptionsExtension</em></dd><dt>[ServiceCollectionAutoOptionsException() (Method)](#m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor__o6ojyb)</dt><dd>Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dd><dt>[ServiceCollectionAutoOptionsException(string) (Method)](#m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor_system.string___1kcodie)</dt><dd>Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dd><dt>[ServiceCollectionAutoOptionsException(string, Exception) (Method)](#m-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception.-ctor_system.string-system.exception___r0rfi6)</dt><dd>Creates [ServiceCollectionAutoOptionsException](#t-net.adamec.lib.common.di.config.exception.servicecollectionautooptionsexception__1bgevbh)</dd><dt>[ServiceCollectionConfigureDirectException (Type)](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dt><dd>Exception thrown by <em>net.adamec.home.control.common.config.exception.ServiceCollectionConfigureDirectExtensions</em></dd><dt>[ServiceCollectionConfigureDirectException() (Method)](#m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor__1n8hr1d)</dt><dd>Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dd><dt>[ServiceCollectionConfigureDirectException(string) (Method)](#m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor_system.string___1dp1v34)</dt><dd>Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dd><dt>[ServiceCollectionConfigureDirectException(string, Exception) (Method)](#m-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception.-ctor_system.string-system.exception___1uv85c8)</dt><dd>Creates [ServiceCollectionConfigureDirectException](#t-net.adamec.lib.common.di.config.exception.servicecollectionconfiguredirectexception__1q7o5xj)</dd><dt>[ContainerBuilderExtensions (Type)](#t-net.adamec.lib.common.di.config.extensions.containerbuilderextensions__tpisv7)</dt><dd>Autofac <em>Autofac.ContainerBuilder</em> extensions</dd><dt>[AddAutoOptions(ContainerBuilder, IConfigurationRoot, Assembly[]) (Method)](#m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addautooptions_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.reflection.assembly_____pfqod1)</dt><dd>Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect. This is to be used if not registered via MS ServiceCollection extensions</dd><dt>[AddAutoOptions(ContainerBuilder, IConfigurationRoot, Type[]) (Method)](#m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addautooptions_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.type_____1fbl63e)</dt><dd>Creates and registers the singletons of configuration (options) classes with AutoOptions attribute marked for RegisteredDirect. This is to be used if not registered via MS ServiceCollection extensions</dd><dt>[AddOptions&lt;TOptions&gt;(ContainerBuilder, IConfigurationRoot, string) (Method)](#m-net.adamec.lib.common.di.config.extensions.containerbuilderextensions.addoptions--1_autofac.containerbuilder-microsoft.extensions.configuration.iconfigurationroot-system.string___1b2rpkf)</dt><dd>Creates and registers the singleton of configuration (options) class of given type This is to be used if not registered using the [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2)</dd><dt>[ServiceCollectionAutoOptionsExtension (Type)](#t-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension__1p9fgao)</dt><dd>Extensions for options (configuration) class automatic binding to appsettings.json</dd><dt>[ConfigureAutoOptions(IServiceCollection, IConfigurationRoot, Assembly[]) (Method)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension.configureautooptions_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfigurationroot-system.reflection.assembly_____1kc5g1y)</dt><dd>Scans given assemblies for classes marked with [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) and binds them to appsettings.json configuration section defined in attribute. Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI</dd><dt>[ConfigureAutoOptions(IServiceCollection, IConfiguration, Assembly[]) (Method)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionautooptionsextension.configureautooptions_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration-system.reflection.assembly_____bfjrc2)</dt><dd>Scans given assemblies for classes marked with [AutoOptionsAttribute](#t-net.adamec.lib.common.di.config.autooptionsattribute__19ezdz2) and binds them to appsettings.json configuration section defined in attribute. Optionally (if defined in attribute), an instance or the configuration class can be created and registered as singleton into MS DI</dd><dt>[ServiceCollectionConfigureDirectExtensions (Type)](#t-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions__wdwckv)</dt><dd>Extensions for options (configuration) class registration into MS DI</dd><dt>[ConfigureDirect(IServiceCollection, Type, IConfiguration) (Method)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect_microsoft.extensions.dependencyinjection.iservicecollection-system.type-microsoft.extensions.configuration.iconfiguration___1lbalbi)</dt><dd>Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI.</dd><dt>[ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration) (Method)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration___1049ily)</dt><dd>Creates the instance of the options (configuration) class, binds (fills) it to the configuration and registers is as singleton into MS DI.</dd><dt>[ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration, Func&lt;TConfig&gt;) (Method)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration-system.func_--0____1uka1kl)</dt><dd>Gets the instance of the options (configuration) class from <strong>pocoProvider</strong> , binds (fills) it to the configuration and registers is as singleton into MS DI.</dd><dt>[ConfigureDirect&lt;TConfig&gt;(IServiceCollection, IConfiguration, ServiceCollectionConfigureDirectExtensions.TConfig) (Method)](#m-net.adamec.lib.common.di.config.extensions.servicecollectionconfiguredirectextensions.configuredirect--1_microsoft.extensions.dependencyinjection.iservicecollection-microsoft.extensions.configuration.iconfiguration---0___18sq65m)</dt><dd>Binds (fills) given instance of the options (configuration) class to configuration and registers is as singleton into MS DI.</dd></dl>


<strong>Sources</strong><dl><dt>di\config\_SourceOnlyPackage.cs</dt><dd></dd><dt>di\config\AutoOptionsAttribute.cs</dt><dd></dd><dt>di\config\exception\ServiceCollectionAutoOptionsException.cs</dt><dd></dd><dt>di\config\exception\ServiceCollectionConfigureDirectException.cs</dt><dd></dd><dt>di\config\extensions\ContainerBuilderExtensions.cs</dt><dd></dd><dt>di\config\extensions\ServiceCollectionAutoOptionsExtension.cs</dt><dd></dd><dt>di\config\extensions\ServiceCollectionConfigureDirectExtensions.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.di.PostInit" />  RadCommons.di.PostInit Source only package ##
<small>Tags: RadCommons source-only RadCommons-DI dependency-injection post-init           
Includes: Folder           
Declaring file: di\postinit\_SourceOnlyPackage.cs</small>


RadCommons DI PostInit - allows to run post init method of component (Source only package).


<strong>Usings</strong><dl><dt>[RadCommons.di.Component](#src-only-package--RadCommons.di.Component)</dt><dd></dd></dl>


<strong>References needed</strong><dl><dt>Autofac</dt><dd></dd></dl>


<strong>Package members</strong><dl><dt>[ContainerBuilderExtensions (Type)](#t-net.adamec.lib.common.di.postinit.containerbuilderextensions__7mjuw3)</dt><dd>Autofac <em>Autofac.ContainerBuilder</em> extensions</dd><dt>[AddComponentPostInitSupport(ContainerBuilder) (Method)](#m-net.adamec.lib.common.di.postinit.containerbuilderextensions.addcomponentpostinitsupport_autofac.containerbuilder___nsekfd)</dt><dd>Adds the support of [PostInitAttribute](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl) to the Autofac container builder.</dd><dt>[ProcessComponentPostInit(IContainer) (Method)](#m-net.adamec.lib.common.di.postinit.containerbuilderextensions.processcomponentpostinit_autofac.icontainer___uo3mji)</dt><dd>Executes the components&#39; post init methods</dd><dt>[PostInitAttribute (Type)](#t-net.adamec.lib.common.di.postinit.postinitattribute__qimmrl)</dt><dd>Allows to run post init method of component. Component must be registered using the Component attribute as singleton in root scope and must register self Parameters of &quot;marked&quot; post init method are resolved from container (throws an exception on failure)</dd></dl>


<strong>Sources</strong><dl><dt>di\postinit\_SourceOnlyPackage.cs</dt><dd></dd><dt>di\postinit\ContainerBuilderExtensions.cs</dt><dd></dd><dt>di\postinit\PostInitAttribute.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.ArrayExtensions.ConcatenateBytes" />  RadCommons.extensions.ArrayExtensions.ConcatenateBytes Source only package ##
<small>Tags: RadCommons source-only extension array           
Includes: None           
Declaring file: extensions\ArrayExtensionsAppendBytes.cs</small>


Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one) (Source only package).


<strong>Package members</strong><dl><dt>[ArrayExtensions (Type)](#t-net.adamec.lib.common.extensions.arrayextensions__icw7wf)</dt><dd>Array extensions</dd><dt>[AppendBytes(byte[], byte[]) (Method)](#m-net.adamec.lib.common.extensions.arrayextensions.appendbytes_system.byte__-system.byte_____1lkijjg)</dt><dd>Adds the byte array to the current one and returns resulting array (concatenates two byte arrays into a new one)</dd></dl>


<strong>Sources</strong><dl><dt>extensions\ArrayExtensionsAppendBytes.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.ArrayExtensions.Fill" />  RadCommons.extensions.ArrayExtensions.Fill Source only package ##
<small>Tags: RadCommons source-only extension array           
Includes: None           
Declaring file: extensions\ArrayExtensionsFill.cs</small>


Fills the array with given value (Source only package).


<strong>Package members</strong><dl><dt>[ArrayExtensions (Type)](#t-net.adamec.lib.common.extensions.arrayextensions__icw7wf)</dt><dd>Array extensions</dd><dt>[Fill&lt;T&gt;(ArrayExtensions.T[], ArrayExtensions.T) (Method)](#m-net.adamec.lib.common.extensions.arrayextensions.fill--1_--0__---0___6j19g1)</dt><dd>Fills the <strong>array</strong> or <strong>T</strong> with <strong>defaultValue</strong></dd></dl>


<strong>Sources</strong><dl><dt>extensions\ArrayExtensionsFill.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.EnumeratorExtensions.ToEnumerable" />  RadCommons.extensions.EnumeratorExtensions.ToEnumerable Source only package ##
<small>Tags: RadCommons source-only extension enumerator           
Includes: None           
Declaring file: extensions\EnumeratorExtensionsToEnumerable.cs</small>


Transforms the IEnumerator or IEnumerator<T> to IEnumerable<T> (Source only package).


<strong>Package members</strong><dl><dt>[EnumeratorExtensions (Type)](#t-net.adamec.lib.common.extensions.enumeratorextensions__obwbb2)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1" target="_blank" >System.Collections.Generic.IEnumerator`1</a> class extensions</dd><dt>[ToEnumerable&lt;T&gt;(IEnumerator&lt;T&gt;) (Method)](#m-net.adamec.lib.common.extensions.enumeratorextensions.toenumerable--1_system.collections.generic.ienumerator_--0____1e4iyhs)</dt><dd>Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a></dd><dt>[ToEnumerable&lt;T&gt;(IEnumerator) (Method)](#m-net.adamec.lib.common.extensions.enumeratorextensions.toenumerable--1_system.collections.ienumerator___fs1sul)</dt><dd>Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a></dd><dt>[ToList&lt;T&gt;(IEnumerator) (Method)](#m-net.adamec.lib.common.extensions.enumeratorextensions.tolist--1_system.collections.ienumerator___lgcqeh)</dt><dd>Transforms the <strong>enumerator</strong> to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a></dd></dl>


<strong>Sources</strong><dl><dt>extensions\EnumeratorExtensionsToEnumerable.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.IEnumerableExtensions.ForEach" />  RadCommons.extensions.IEnumerableExtensions.ForEach Source only package ##
<small>Tags: RadCommons source-only extension enumerable           
Includes: None           
Declaring file: extensions\IEnumerableExtensionsForEach.cs</small>


Invokes the action for each item if IEnumerable<T> (Source only package).


<strong>Package members</strong><dl><dt>[IEnumerableExtensions (Type)](#t-net.adamec.lib.common.extensions.ienumerableextensions__1a6urvh)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> extensions</dd><dt>[ForEach&lt;T&gt;(IEnumerable&lt;T&gt;, Action&lt;T&gt;) (Method)](#m-net.adamec.lib.common.extensions.ienumerableextensions.foreach--1_system.collections.generic.ienumerable_--0_-system.action_--0____nwdpsf)</dt><dd>Invokes <strong>action</strong> for each item of <strong>enumerable</strong></dd></dl>


<strong>Sources</strong><dl><dt>extensions\IEnumerableExtensionsForEach.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.StringExtensions.Case" />  RadCommons.extensions.StringExtensions.Case Source only package ##
<small>Tags: RadCommons source-only extension string camel-case case           
Includes: None           
Declaring file: extensions\StringExtensionsCase.cs</small>


String case manipulation helpers (Source only package).


<strong>Package members</strong><dl><dt>[StringExtensions (Type)](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions</dd><dt>[ToCamelCase(string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.tocamelcase_system.string___xq94l0)</dt><dd>Simple CamelCase converter</dd><dt>[FirstLetterToUpper(string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.firstlettertoupper_system.string___12nwwlc)</dt><dd>Converts the first letter of string to upper case</dd></dl>


<strong>Sources</strong><dl><dt>extensions\StringExtensionsCase.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.StringExtensions.Html" />  RadCommons.extensions.StringExtensions.Html Source only package ##
<small>Tags: RadCommons source-only extension string html           
Includes: None           
Declaring file: extensions\StringExtensionsHtml.cs</small>


HTML related string manipulation helpers (Source only package).


<strong>Package members</strong><dl><dt>[StringExtensions (Type)](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions</dd><dt>[HtmlEncode(string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.htmlencode_system.string___1ozzgea)</dt><dd>HTML encodes the string</dd><dt>[HtmlDecode(string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.htmldecode_system.string___kajpem)</dt><dd>HTML decodes the string</dd></dl>


<strong>Sources</strong><dl><dt>extensions\StringExtensionsHtml.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.StringExtensions.Parts" />  RadCommons.extensions.StringExtensions.Parts Source only package ##
<small>Tags: RadCommons source-only extension string           
Includes: None           
Declaring file: extensions\StringExtensionsParts.cs</small>


String splitting and parts manipulation helpers (Source only package).


<strong>Package members</strong><dl><dt>[StringExtensions (Type)](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions</dd><dt>[SplitByFirstSpace(string, string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.splitbyfirstspace_system.string-system.string-___d5xnpu)</dt><dd>Splits the string by first space and returns the &quot;before&quot; part. The &quot;after&quot; part is provided in output parameter <strong>rest</strong> Both result and <strong>rest</strong> are trimmed</dd><dt>[LastPart(string, string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.lastpart_system.string-system.string___t4lkjk)</dt><dd>Returns the part of the string after the last occurence of the <strong>separator</strong> The result is always trimmed</dd></dl>


<strong>Sources</strong><dl><dt>extensions\StringExtensionsParts.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.StringExtensions.Paths" />  RadCommons.extensions.StringExtensions.Paths Source only package ##
<small>Tags: RadCommons source-only extension string file-utilities           
Includes: None           
Declaring file: extensions\StringExtensionsPaths.cs</small>


Path manipulation helpers for strings (Source only package).


<strong>Package members</strong><dl><dt>[StringExtensions (Type)](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions</dd><dt>[AddPath(string, string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.addpath_system.string-system.string___1m9wwnx)</dt><dd>Adds next path segment to string representing path to the file system</dd></dl>


<strong>Sources</strong><dl><dt>extensions\StringExtensionsPaths.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.StringExtensions.Whitespace" />  RadCommons.extensions.StringExtensions.Whitespace Source only package ##
<small>Tags: RadCommons source-only extension string           
Includes: None           
Declaring file: extensions\StringExtensionsWhitespace.cs</small>


Whitespace manipulation helpers for strings (Source only package).


<strong>Package members</strong><dl><dt>[StringExtensions (Type)](#t-net.adamec.lib.common.extensions.stringextensions__y7rgbb)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> class extensions</dd><dt>[TrimAndMergeLines(string) (Method)](#m-net.adamec.lib.common.extensions.stringextensions.trimandmergelines_system.string___1371ffr)</dt><dd>&quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break)</dd></dl>


<strong>Sources</strong><dl><dt>extensions\StringExtensionsWhitespace.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue" />  RadCommons.extensions.TypeExtensions.DefaultValue Source only package ##
<small>Tags: RadCommons source-only extension type default-value           
Includes: None           
Declaring file: extensions\TypeExtensionsDefaultValue.cs</small>


Provides default value for types (Source only package).


<strong>Package members</strong><dl><dt>[TypeExtensions (Type)](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions</dd><dt>[GetDefaultValue(Type) (Method)](#m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69)</dt><dd>Gets the default value of given <strong>type</strong></dd></dl>


<strong>Sources</strong><dl><dt>extensions\TypeExtensionsDefaultValue.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.BackgroundWorkerWithSyncCancel" />  RadCommons.utils.BackgroundWorkerWithSyncCancel Source only package ##
<small>Tags: RadCommons source-only worker background-worker           
Includes: None           
Declaring file: utils\BackgroundWorkerWithSyncCancel.cs</small>


Executes an operation on a separate thread with possibility of sync cancel (Source only package).


<strong>Package members</strong><dl><dt>[BackgroundWorkerWithSyncCancel (Type)](#t-net.adamec.lib.common.utils.backgroundworkerwithsynccancel__1hdlhvo)</dt><dd>Executes an operation on a separate thread with possibility of sync cancel.</dd><dt>[resetEvent (Field)](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.resetevent__7jv5b7)</dt><dd>Reset event used to ensure that the work is finished</dd><dt>[lockObject (Field)](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.lockobject__slen4g)</dt><dd>Lock object</dd><dt>[isRunningInternal (Field)](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.isrunninginternal__np6hee)</dt><dd>Internal flag whether the worker is running its DoWork action</dd><dt>[isCancelling (Field)](#f-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__14bxgje)</dt><dd>Backing field for [IsCancelling](#p-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__1krty8c)</dd><dt>[IsCancelling (Property)](#p-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.iscancelling__1krty8c)</dt><dd>Flag whether the worker is cancelling</dd><dt>[Cancel() (Method)](#m-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.cancel__1p5og1v)</dt><dd>Requests cancellation of a pending background operation and wait for cancel to complete</dd><dt>[OnDoWork(DoWorkEventArgs) (Method)](#m-net.adamec.lib.common.utils.backgroundworkerwithsynccancel.ondowork_system.componentmodel.doworkeventargs___1euewn7)</dt><dd>Raises the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker.dowork#System_ComponentModel_BackgroundWorker_DoWork" target="_blank" >System.ComponentModel.BackgroundWorker.DoWork</a> event.</dd></dl>


<strong>Sources</strong><dl><dt>utils\BackgroundWorkerWithSyncCancel.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.ConsoleUtils" />  RadCommons.utils.ConsoleUtils Source only package ##
<small>Tags: RadCommons source-only console           
Includes: None           
Declaring file: utils\ConsoleUtils.cs</small>


Console output utilities (Source only package).


<strong>Package members</strong><dl><dt>[ConsoleUtils (Type)](#t-net.adamec.lib.common.utils.consoleutils__8nc415)</dt><dd>Console output helpers</dd><dt>[ColorWarn (Field)](#f-net.adamec.lib.common.utils.consoleutils.colorwarn__1ewdf3q)</dt><dd>Warning text color (yellow)</dd><dt>[ColorErr (Field)](#f-net.adamec.lib.common.utils.consoleutils.colorerr__1pfz831)</dt><dd>Error text color (red)</dd><dt>[WriteLine(TextWriter, string, ConsoleColor) (Method)](#m-net.adamec.lib.common.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___1s54eb8)</dt><dd>Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong></dd><dt>[WriteLine(string, ConsoleColor) (Method)](#m-net.adamec.lib.common.utils.consoleutils.writeline_system.string-system.consolecolor___k0vd2z)</dt><dd>Writes colored <strong>line</strong> to console standard output</dd><dt>[WriteWarn(string) (Method)](#m-net.adamec.lib.common.utils.consoleutils.writewarn_system.string___1g2atmo)</dt><dd>Writes warning <strong>line</strong> to console standard output</dd><dt>[WriteErr(string) (Method)](#m-net.adamec.lib.common.utils.consoleutils.writeerr_system.string___p914w1)</dt><dd>Writes error <strong>line</strong> to console error output</dd><dt>[WriteErrWarn(string) (Method)](#m-net.adamec.lib.common.utils.consoleutils.writeerrwarn_system.string___1p5ryw7)</dt><dd>Writes warning <strong>line</strong> to console error output</dd><dt>[WriteInfo(string) (Method)](#m-net.adamec.lib.common.utils.consoleutils.writeinfo_system.string___16eewm4)</dt><dd>Writes info <strong>line</strong> to console standard output</dd></dl>


<strong>Sources</strong><dl><dt>utils\ConsoleUtils.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.Context" />  RadCommons.utils.Context Source only package ##
<small>Tags: RadCommons source-only disposable context           
Includes: None           
Declaring file: utils\Context.cs</small>


The runtime "container" for context operations.  The context can be both state-less and state-full and it's valid until it's disposed.
 The current context is accessible via static property Current.
 The contexts are chained, when a new context is created using static method BeginContext(),
 the Current context became the Parent of the new one and
 the newly created context will be set as the Current one.
 When the context is disposed, the Current context is set to Parent of disposing context.
 The base implementation just manages the life time, context chain and keeps the state (when provided).
 Inherit from the Context<TState> to add the context related operations (inherited classes have the access to state).
 Based on the implementation of Guard Scopes by  https://github.com/safakgur.
 (Source only package).


<strong>Usings</strong><dl><dt>[RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</dt><dd></dd></dl>


<strong>References needed</strong><dl><dt>RadCommons.core</dt><dd></dd></dl>


###  Remarks ###
The context can be both state-less and state-full and it&#39;s valid until it&#39;s disposed. The current context is accessible via [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) . The contexts are chained, when a new context is created using [BeginContext(Context&lt;TState&gt;.TState)](#m-net.adamec.lib.common.utils.context-1.begincontext_-0___mkgdox) , the [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context became the [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) of the new one and the newly created context will be set as the [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) one. When the context is disposed, the [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context is set to [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) of disposing context. Context&#39;s children are disposed as well during the context disposal. The [AddToDisposer(IDisposable)](#m-net.adamec.lib.common.utils.context-1.addtodisposer_system.idisposable___1y4aua6) method is to be used in inherited classes whenever they manage any disposable resource to ensure their proper life time (when the [State](#p-net.adamec.lib.common.utils.context-1.state__1qgilfy) is <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> , it&#39;s added to disposer automatically). The base implementation just manages the life time, context chain and keeps the state (when provided). Inherit from the [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) to add the context related operations (inherited classes have the access to [State](#p-net.adamec.lib.common.utils.context-1.state__1qgilfy) ).

 Based on the implementation of Guard Scopes by  https://github.com/safakgur at https://github.com/safakgur/guard/blob/v1.7.0/src/Guard.Scopes.cs




<strong>Package members</strong><dl><dt>[Context&lt;TState&gt; (Type)](#t-net.adamec.lib.common.utils.context-1__15rsz3v)</dt><dd>Base context implementation.</dd><dt>[ContextDisposedMessage (Field)](#f-net.adamec.lib.common.utils.context-1.contextdisposedmessage__161hgfs)</dt><dd>Error message that will be put into the exception when there will be any operation on the disposed context.</dd><dt>[Local (Field)](#f-net.adamec.lib.common.utils.context-1.local__17b69oq)</dt><dd>The context holder that is local to the calling asynchronous control flow.</dd><dt>[Current (Property)](#p-net.adamec.lib.common.utils.context-1.current__14ss4su)</dt><dd>Gets the current context.</dd><dt>[Disposer (Property)](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c)</dt><dd>Gets the disposer associated with this container.</dd><dt>[parentContext (Field)](#f-net.adamec.lib.common.utils.context-1.parentcontext__1an2htq)</dt><dd>Parent context.</dd><dt>[Parent (Property)](#p-net.adamec.lib.common.utils.context-1.parent__18v621x)</dt><dd>Gets the parent scope.</dd><dt>[contextState (Field)](#f-net.adamec.lib.common.utils.context-1.contextstate__5jvaxj)</dt><dd>State managed by the context.</dd><dt>[State (Property)](#p-net.adamec.lib.common.utils.context-1.state__1qgilfy)</dt><dd>Gets the state managed by the context.</dd><dt>[Context&lt;TState&gt;(Context&lt;TState&gt;.TState) (Method)](#m-net.adamec.lib.common.utils.context-1.-ctor_-0___7zfvl8)</dt><dd>Creates an instance of [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) and initialize its [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) . The new context will become [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) and the previous one its [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) .</dd><dt>[BeginContext(Context&lt;TState&gt;.TState) (Method)](#m-net.adamec.lib.common.utils.context-1.begincontext_-0___mkgdox)</dt><dd>Creates a new [Context&lt;TState&gt;](#t-net.adamec.lib.common.utils.context-1__15rsz3v) within the context chain. The new context will become [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) and the previous one its [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) .</dd><dt>[AddToDisposer(IDisposable) (Method)](#m-net.adamec.lib.common.utils.context-1.addtodisposer_system.idisposable___1y4aua6)</dt><dd>Adds the <strong>disposable</strong> object to the context disposer, so it will be disposed with the context</dd><dt>[DisposeManaged() (Method)](#m-net.adamec.lib.common.utils.context-1.disposemanaged__1ueqxf2)</dt><dd>Dispose any disposable managed objects - all disposables kept in [Disposer](#p-net.adamec.lib.common.utils.context-1.disposer__1lrrq4c) stack are pop and disposed. The [Parent](#p-net.adamec.lib.common.utils.context-1.parent__18v621x) context of the disposing one will become the new [Current](#p-net.adamec.lib.common.utils.context-1.current__14ss4su) context.

</dd></dl>


<strong>Sources</strong><dl><dt>utils\Context.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.Disposer" />  RadCommons.utils.Disposer Source only package ##
<small>Tags: RadCommons source-only disposable           
Includes: None           
Declaring file: utils\Disposer.cs</small>


Keeps the stack of disposable objects, and disposes them when the disposer is being disposed. (Source only package).


<strong>References needed</strong><dl><dt>RadCommons.core</dt><dd></dd></dl>


<strong>Package members</strong><dl><dt>[Disposer (Type)](#t-net.adamec.lib.common.utils.disposer__1ejr99q)</dt><dd>Keeps the stack of disposable objects, and disposes them when the disposer is being disposed.</dd><dt>[disposables (Field)](#f-net.adamec.lib.common.utils.disposer.disposables__5cwehn)</dt><dd>Stack of disposables kept by the [Disposer](#t-net.adamec.lib.common.utils.disposer__1ejr99q) .</dd><dt>[lockObj (Field)](#f-net.adamec.lib.common.utils.disposer.lockobj__1oj1wh6)</dt><dd>Lock object</dd><dt>[Dispose(bool) (Method)](#m-net.adamec.lib.common.utils.disposer.dispose_system.boolean___32o7wm)</dt><dd>Internal implementation of dispose - free the managed and native resources.</dd><dt>[Add(IDisposable) (Method)](#m-net.adamec.lib.common.utils.disposer.add_system.idisposable___1c4uk8l)</dt><dd>Adds the <strong>disposable</strong> object to the disposer.</dd></dl>


<strong>Sources</strong><dl><dt>utils\Disposer.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.FileUtils.Copy" />  RadCommons.utils.FileUtils.Copy Source only package ##
<small>Tags: RadCommons source-only file-copy file-utilities           
Includes: None           
Declaring file: utils\FileUtilsCopy.cs</small>


File copy utilities (Source only package).


<strong>Package members</strong><dl><dt>[FileUtils (Type)](#t-net.adamec.lib.common.utils.fileutils__1bi9r8y)</dt><dd>File copy utilities</dd><dt>[DirectoryCopy(string, string, bool, bool, List&lt;string&gt;) (Method)](#m-net.adamec.lib.common.utils.fileutils.directorycopy_system.string-system.string-system.boolean-system.boolean-system.collections.generic.list_system.string____14t7efj)</dt><dd>Copies the source directory to destination directory All files from source directory are copied to the destination directory. The destination directory is created when doesn&#39;t exist. <strong>recursive</strong> parameter set to true let also subdirectories to be copied To overwrite the existing destination files, <strong>overwrite</strong> must be set to true, otherwise the exception is thrown. When <strong>overwrite</strong> is set, it&#39;s possible to exclude the files by adding the file names (without path, so applicable to all directories) to <strong>doNotOverwriteFileNames</strong> list. The listed files are being &quot;silently&quot; skipped (no exception thrown)</dd><dt>[FileCopy(string, string, bool, List&lt;string&gt;) (Method)](#m-net.adamec.lib.common.utils.fileutils.filecopy_system.string-system.string-system.boolean-system.collections.generic.list_system.string____1j72c9b)</dt><dd>Copies the source file to destination file To overwrite the existing destination file, <strong>overwrite</strong> must be set to true, otherwise the exception is thrown. When <strong>overwrite</strong> is set, it&#39;s possible to exclude the files by adding the file names (without path) to <strong>doNotOverwriteFileNames</strong> list. The listed files are being &quot;silently&quot; skipped (no exception thrown)</dd></dl>


<strong>Sources</strong><dl><dt>utils\FileUtilsCopy.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.MarshalExt" />  RadCommons.utils.MarshalExt Source only package ##
<small>Tags: RadCommons source-only marshal interop           
Includes: None           
Declaring file: utils\MarshalExt.cs</small>


Marshaling helpers (Source only package).


<strong>Package members</strong><dl><dt>[MarshalExt (Type)](#t-net.adamec.lib.common.utils.marshalext__7jyavy)</dt><dd>Marshaling helper methods</dd><dt>[GetStructureAsData(object) (Method)](#m-net.adamec.lib.common.utils.marshalext.getstructureasdata_system.object___1emo3ax)</dt><dd>Get&#39;s the structure data byte array</dd><dt>[GetDataAsStructure(Type, byte[]) (Method)](#m-net.adamec.lib.common.utils.marshalext.getdataasstructure_system.type-system.byte_____3ecs3)</dt><dd>Converts the byte array <strong>data</strong> into the structure of given <strong>structureType</strong></dd></dl>


<strong>Sources</strong><dl><dt>utils\MarshalExt.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.PeriodicTask" />  RadCommons.utils.PeriodicTask Source only package ##
<small>Tags: RadCommons source-only async periodic-task           
Includes: None           
Declaring file: utils\PeriodicTask.cs</small>


Periodic (or scheduled) async task runner (Source only package).


<strong>Package members</strong><dl><dt>[PeriodicTask (Type)](#t-net.adamec.lib.common.utils.periodictask__1xfynj)</dt><dd>Helper class allowing to execute periodic (or one time) scheduled action</dd><dt>[RunAsync(Action, TimeSpan, CancellationToken, bool) (Method)](#m-net.adamec.lib.common.utils.periodictask.runasync_system.action-system.timespan-system.threading.cancellationtoken-system.boolean___uw465x)</dt><dd>Schedule and run the periodic <strong>action</strong></dd><dt>[RunAsync(Action, TimeSpan, bool) (Method)](#m-net.adamec.lib.common.utils.periodictask.runasync_system.action-system.timespan-system.boolean___9mkw46)</dt><dd>Schedule and run the periodic <strong>action</strong></dd></dl>


<strong>Sources</strong><dl><dt>utils\PeriodicTask.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.ProcessUtils" />  RadCommons.utils.ProcessUtils Source only package ##
<small>Tags: RadCommons source-only process           
Includes: None           
Declaring file: utils\ProcessUtils.cs</small>


Process related utilities (Source only package).


<strong>Package members</strong><dl><dt>[ProcessUtils (Type)](#t-net.adamec.lib.common.utils.processutils__tzt3e1)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process" target="_blank" >System.Diagnostics.Process</a> related utilities</dd><dt>[RunCommand(string, string, string, string) (Method)](#m-net.adamec.lib.common.utils.processutils.runcommand_system.string-system.string-system.string-system.string-___vsf405)</dt><dd>Synchronously runs a command (process) and returns the standard output or error text</dd></dl>


<strong>Sources</strong><dl><dt>utils\ProcessUtils.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.ProcessWrapper" />  RadCommons.utils.ProcessWrapper Source only package ##
<small>Tags: RadCommons source-only process           
Includes: None           
Declaring file: utils\ProcessWrapper.cs</small>


A class the wraps a process, allowing programmatic input and output (Source only package).


<strong>Package members</strong><dl><dt>[ProcessWrapper (Type)](#t-net.adamec.lib.common.utils.processwrapper__1oqe83p)</dt><dd>A class the wraps a process, allowing programmatic input and output.</dd><dt>[OutputWorkerPeriodMs (Field)](#f-net.adamec.lib.common.utils.processwrapper.outputworkerperiodms__vrr0db)</dt><dd></dd><dt>[Process (Property)](#p-net.adamec.lib.common.utils.processwrapper.process__16lml00)</dt><dd>The internal process.</dd><dt>[Command (Property)](#p-net.adamec.lib.common.utils.processwrapper.command__fluecw)</dt><dd>The command starting the process</dd><dt>[CommandArguments (Property)](#p-net.adamec.lib.common.utils.processwrapper.commandarguments__jgk6sk)</dt><dd>The command arguments.</dd><dt>[WorkingDirectory (Property)](#p-net.adamec.lib.common.utils.processwrapper.workingdirectory__kyrfvj)</dt><dd>The command working directory.</dd><dt>[IsProcessRunning (Property)](#p-net.adamec.lib.common.utils.processwrapper.isprocessrunning__g9exf9)</dt><dd>Returns true when the process is running</dd><dt>[inputWriter (Field)](#f-net.adamec.lib.common.utils.processwrapper.inputwriter__1vy4110)</dt><dd>The input writer.</dd><dt>[outputReader (Field)](#f-net.adamec.lib.common.utils.processwrapper.outputreader__1x6fvbr)</dt><dd>The output reader.</dd><dt>[errorReader (Field)](#f-net.adamec.lib.common.utils.processwrapper.errorreader__q0q33e)</dt><dd>The error reader.</dd><dt>[stdOutputWorker (Field)](#f-net.adamec.lib.common.utils.processwrapper.stdoutputworker__cmgjmf)</dt><dd>The standard output worker.</dd><dt>[errorOutputWorker (Field)](#f-net.adamec.lib.common.utils.processwrapper.erroroutputworker__16ni2qe)</dt><dd>The error output worker.</dd><dt>[OnProcessOutput (Event)](#e-net.adamec.lib.common.utils.processwrapper.onprocessoutput__m4qoan)</dt><dd>Occurs when process output (incl. error stream) is produced.</dd><dt>[OnProcessExit (Event)](#e-net.adamec.lib.common.utils.processwrapper.onprocessexit__qmichq)</dt><dd>Occurs when the process ends.</dd><dt>[ProcessWrapper() (Method)](#m-net.adamec.lib.common.utils.processwrapper.-ctor__32xh8z)</dt><dd>CTOR</dd><dt>[StartProcess(string, string, string) (Method)](#m-net.adamec.lib.common.utils.processwrapper.startprocess_system.string-system.string-system.string___nt2z9o)</dt><dd>Runs a process with given <strong>command</strong></dd><dt>[StopProcess() (Method)](#m-net.adamec.lib.common.utils.processwrapper.stopprocess__moyfm5)</dt><dd>Stops the process.</dd><dt>[WriteInput(string) (Method)](#m-net.adamec.lib.common.utils.processwrapper.writeinput_system.string___1vjk4n0)</dt><dd>Writes the input into the process</dd><dt>[OutputWorkerProgressChangedHandler(object, ProgressChangedEventArgs) (Method)](#m-net.adamec.lib.common.utils.processwrapper.outputworkerprogresschangedhandler_system.object-system.componentmodel.progresschangedeventargs___2syz2c)</dt><dd>Handles the ProgressChanged event of the output worker</dd><dt>[StdOutputWorkerDoWorkHandler(object, DoWorkEventArgs) (Method)](#m-net.adamec.lib.common.utils.processwrapper.stdoutputworkerdoworkhandler_system.object-system.componentmodel.doworkeventargs___1dqbwkp)</dt><dd>Handles the DoWork event of the standard output worker</dd><dt>[ErrorOutputWorkerDoWorkHandler(object, DoWorkEventArgs) (Method)](#m-net.adamec.lib.common.utils.processwrapper.erroroutputworkerdoworkhandler_system.object-system.componentmodel.doworkeventargs___16qj4ty)</dt><dd>Handles the DoWork event of the error output worker</dd><dt>[ProcessOutput(BackgroundWorkerWithSyncCancel, TextReader, bool) (Method)](#m-net.adamec.lib.common.utils.processwrapper.processoutput_net.adamec.lib.common.utils.backgroundworkerwithsynccancel-system.io.textreader-system.boolean___132jrkz)</dt><dd>Processes the output from standard output or error output stream <strong>reader</strong></dd><dt>[ProcessExitedHandler(object, EventArgs) (Method)](#m-net.adamec.lib.common.utils.processwrapper.processexitedhandler_system.object-system.eventargs___u7crnb)</dt><dd>Handles the Exited event of the currentProcess control.</dd><dt>[RaiseProcessOutputEvent(ProcessWrapper.OutputChunk) (Method)](#m-net.adamec.lib.common.utils.processwrapper.raiseprocessoutputevent_net.adamec.lib.common.utils.processwrapper.outputchunk___11yhou)</dt><dd>Raises OnProcessOutput event</dd><dt>[RaiseProcessExitEvent(int, string) (Method)](#m-net.adamec.lib.common.utils.processwrapper.raiseprocessexitevent_system.int32-system.string___1j8vxlz)</dt><dd>Raises OnProcessExit event</dd><dt>[ProcessWrapper.OutputChunk (Type)](#t-net.adamec.lib.common.utils.processwrapper.outputchunk__o3evan)</dt><dd>Internal class to hold the output chunk within the output worker</dd><dt>[IsError (Property)](#p-net.adamec.lib.common.utils.processwrapper.outputchunk.iserror__1d9rwlz)</dt><dd></dd><dt>[Output (Property)](#p-net.adamec.lib.common.utils.processwrapper.outputchunk.output__1v5g27m)</dt><dd></dd><dt>[ProcessWrapper.OutputChunk(bool, string) (Method)](#m-net.adamec.lib.common.utils.processwrapper.outputchunk.-ctor_system.boolean-system.string___edttbd)</dt><dd></dd><dt>[ProcessEventHandler (Type)](#t-net.adamec.lib.common.utils.processeventhandler__8h5v6w)</dt><dd>A ProcessEventHandler is a delegate for process output events.</dd><dt>[ProcessEventArgs (Type)](#t-net.adamec.lib.common.utils.processeventargs__1gw60ix)</dt><dd>The ProcessEventArgs are arguments for a console event.</dd><dt>[Content (Property)](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m)</dt><dd>Gets the process input/output content.</dd><dt>[IsError (Property)](#p-net.adamec.lib.common.utils.processeventargs.iserror__1dgcqs1)</dt><dd>Flag whether the [Content](#p-net.adamec.lib.common.utils.processeventargs.content__dgou0m) is from error stream (true)</dd><dt>[Code (Property)](#p-net.adamec.lib.common.utils.processeventargs.code__q4uuts)</dt><dd>Gets the process exit code.</dd><dt>[ProcessEventArgs(string, bool) (Method)](#m-net.adamec.lib.common.utils.processeventargs.-ctor_system.string-system.boolean___1ey6l7b)</dt><dd>CTOR with content</dd><dt>[ProcessEventArgs(int, string) (Method)](#m-net.adamec.lib.common.utils.processeventargs.-ctor_system.int32-system.string___12x7loh)</dt><dd>CTOR with code</dd></dl>


<strong>Sources</strong><dl><dt>utils\ProcessWrapper.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.Scope" />  RadCommons.utils.Scope Source only package ##
<small>Tags: RadCommons source-only disposable scope           
Includes: None           
Declaring file: utils\Scope.cs</small>


The runtime "container" for scoped operations.  The scope can be both state-less and state-full and it's valid until it's disposed.
 The scopes can be nested (when the scope is disposed, the children are disposed as well) and there can be multiple child scopes (siblings) living in parallel.
 The base implementation just manages the life time, child scopes and keeps the state (when provided).
 Inherit from the Scope<TState> (and IScope<TState>)
 to add the scope related operations (inherited classes have the access to state).
 (Source only package).


<strong>Usings</strong><dl><dt>[RadCommons.utils.Disposer](#src-only-package--RadCommons.utils.Disposer)</dt><dd></dd></dl>


<strong>References needed</strong><dl><dt>RadCommons.core</dt><dd></dd></dl>


###  Remarks ###
The scope can be both state-less and state-full and it&#39;s valid until it&#39;s disposed. The scopes can be nested, when the scope is disposed, the children are disposed as well. There can be multiple child scopes (siblings) living in parallel. The [AddToDisposer(IDisposable)](#m-net.adamec.lib.common.utils.scope-1.addtodisposer_system.idisposable___154ejbt) method is to be used in inherited classes whenever they manage any disposable resource to ensure the proper life time (when the [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar) is <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> , it&#39;s added to disposer automatically). The base implementation just manages the life time, child scopes and keeps the state (when provided). Inherit from the [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) (and [IScope&lt;TState&gt;](#t-net.adamec.lib.common.utils.iscope-1__88aydf) ) to add the scope related operations (inherited classes have the access to [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar) ).




<strong>Package members</strong><dl><dt>[IScope&lt;TState&gt; (Type)](#t-net.adamec.lib.common.utils.iscope-1__88aydf)</dt><dd>Scope interface.</dd><dt>[Parent (Property)](#p-net.adamec.lib.common.utils.iscope-1.parent__iyc99h)</dt><dd>Gets the parent scope.</dd><dt>[BeginScope(IScope&lt;TState&gt;.TState) (Method)](#m-net.adamec.lib.common.utils.iscope-1.beginscope_-0___1d7nxoa)</dt><dd>Creates a child scope of the current scope.</dd><dt>[Scope&lt;TState&gt; (Type)](#t-net.adamec.lib.common.utils.scope-1__eepqvi)</dt><dd>Base scope implementation.</dd><dt>[ScopeDisposedMessage (Field)](#f-net.adamec.lib.common.utils.scope-1.scopedisposedmessage__12oxry0)</dt><dd>Error message that will be put into the exception when there will be any operation on the disposed scope.</dd><dt>[RootInternal (Field)](#f-net.adamec.lib.common.utils.scope-1.rootinternal__coycy3)</dt><dd>Instance of the [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) created when the singleton is first touched - root scope with default [State](#p-net.adamec.lib.common.utils.scope-1.state__78jkar)</dd><dt>[Root (Property)](#p-net.adamec.lib.common.utils.scope-1.root__17hnd9c)</dt><dd>Gets the root scope.</dd><dt>[Scope&lt;TState&gt;() (Method)](#m-net.adamec.lib.common.utils.scope-1.-cctor__1t7jr8v)</dt><dd>Static constructor</dd><dt>[Disposer (Property)](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt)</dt><dd>Gets the disposer associated with this container.</dd><dt>[parentScope (Field)](#f-net.adamec.lib.common.utils.scope-1.parentscope__h8qyu6)</dt><dd>Parent scope.</dd><dt>[Parent (Property)](#p-net.adamec.lib.common.utils.scope-1.parent__1hk8ypk)</dt><dd>Gets the parent scope.</dd><dt>[scopeState (Field)](#f-net.adamec.lib.common.utils.scope-1.scopestate__16lomdz)</dt><dd>State managed by the scope.</dd><dt>[State (Property)](#p-net.adamec.lib.common.utils.scope-1.state__78jkar)</dt><dd>Gets the state managed by the scope.</dd><dt>[Scope&lt;TState&gt;(Scope&lt;TState&gt;.TState) (Method)](#m-net.adamec.lib.common.utils.scope-1.-ctor_-0___17usleh)</dt><dd>Creates an instance of [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) and initialize its [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) .</dd><dt>[Scope&lt;TState&gt;(IScope&lt;TState&gt;, Scope&lt;TState&gt;.TState) (Method)](#m-net.adamec.lib.common.utils.scope-1.-ctor_net.adamec.lib.common.utils.iscope_-0_--0___a63u7z)</dt><dd>Creates an instance of child [Scope&lt;TState&gt;](#t-net.adamec.lib.common.utils.scope-1__eepqvi) .</dd><dt>[BeginScope(Scope&lt;TState&gt;.TState) (Method)](#m-net.adamec.lib.common.utils.scope-1.beginscope_-0___1bcz3lp)</dt><dd>Creates a child scope of the current scope.</dd><dt>[AddToDisposer(IDisposable) (Method)](#m-net.adamec.lib.common.utils.scope-1.addtodisposer_system.idisposable___154ejbt)</dt><dd>Adds the <strong>disposable</strong> object to the scope disposer, so it will be disposed with the scope</dd><dt>[DisposeManaged() (Method)](#m-net.adamec.lib.common.utils.scope-1.disposemanaged__19g6lc3)</dt><dd>Dispose any disposable managed objects - all disposables kept in [Disposer](#p-net.adamec.lib.common.utils.scope-1.disposer__1at2jxt) stack are pop and disposed.</dd></dl>


<strong>Sources</strong><dl><dt>utils\Scope.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.Txt" />  RadCommons.utils.Txt Source only package ##
<small>Tags: RadCommons source-only text-builder string-builder           
Includes: None           
Declaring file: utils\Txt.cs</small>


Text builder allowing to build strings from parts, supporting conditions, enumerations, etc.(Source only package).


<strong>Package members</strong><dl><dt>[Txt (Type)](#t-net.adamec.lib.common.utils.txt__1fch6k9)</dt><dd>Text builder</dd><dt>[builder (Field)](#f-net.adamec.lib.common.utils.txt.builder__137g30a)</dt><dd>Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a></dd><dt>[Txt() (Method)](#m-net.adamec.lib.common.utils.txt.-ctor__41ctkn)</dt><dd>Creates a new empty text builder</dd><dt>[Txt(string) (Method)](#m-net.adamec.lib.common.utils.txt.-ctor_system.string___zqpefu)</dt><dd>Creates a new text builder with initial <strong>text</strong></dd><dt>[Add(string) (Method)](#m-net.adamec.lib.common.utils.txt.add_system.string___lgx7f6)</dt><dd>Adds the <strong>text</strong> to the text builder</dd><dt>[Add(Func&lt;string&gt;) (Method)](#m-net.adamec.lib.common.utils.txt.add_system.func_system.string____xzdmt3)</dt><dd>Adds the text returned from <strong>textFunc</strong> to the text builder</dd><dt>[AddIf(string, bool) (Method)](#m-net.adamec.lib.common.utils.txt.addif_system.string-system.boolean___1qmz3e2)</dt><dd>Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true.</dd><dt>[AddIf(Func&lt;string&gt;, bool) (Method)](#m-net.adamec.lib.common.utils.txt.addif_system.func_system.string_-system.boolean___ogucu7)</dt><dd>Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true.</dd><dt>[AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string) (Method)](#m-net.adamec.lib.common.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1pfl3rh)</dt><dd>Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder.</dd><dt>[AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string) (Method)](#m-net.adamec.lib.common.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___kykhox)</dt><dd>Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true.</dd><dt>[Clear() (Method)](#m-net.adamec.lib.common.utils.txt.clear__11a2n7)</dt><dd>Clear the text builder</dd><dt>[Start(string) (Method)](#m-net.adamec.lib.common.utils.txt.start_system.string___og05dp)</dt><dd>Creates a new instance ot [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder with optional initial <strong>text</strong></dd><dt>[ToString() (Method)](#m-net.adamec.lib.common.utils.txt.tostring__17wjkjc)</dt><dd>Returns the text content of the text builder</dd><dt>[From(string) (Method)](#m-net.adamec.lib.common.utils.txt.op_implicit_system.string_dtornet.adamec.lib.common.utils.txt__15d874r)</dt><dd>Creates a new instance ot [Txt](#t-net.adamec.lib.common.utils.txt__1fch6k9) text builder with optional initial <strong>text</strong></dd><dt>[ToString(Txt) (Method)](#m-net.adamec.lib.common.utils.txt.op_implicit_net.adamec.lib.common.utils.txt_dtorsystem.string__1e7zirr)</dt><dd>Converts the text builder to string containing its content</dd><dt>[Add(Txt, Txt) (Method)](#m-net.adamec.lib.common.utils.txt.op_addition_net.adamec.lib.common.utils.txt-net.adamec.lib.common.utils.txt___14gnt2r)</dt><dd>Concatenates the contents of two text builders</dd><dt>[BitwiseOr(Txt, Txt) (Method)](#m-net.adamec.lib.common.utils.txt.op_bitwiseor_net.adamec.lib.common.utils.txt-net.adamec.lib.common.utils.txt___84qns5)</dt><dd>Concatenates the contents of two text builders</dd></dl>


<strong>Sources</strong><dl><dt>utils\Txt.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.md#namespace-list) or [types](net.adamec.lib.common.md#type-list) or [source-only packages](net.adamec.lib.common.md#package-list)


 



