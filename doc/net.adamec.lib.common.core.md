#  Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x) |  | 
 | [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k) |  | 
 | [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh) | public abstract | Class | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [CommonLogging](#t-net.adamec.lib.common.core.logging.commonlogging__1x32qka) | public static | Class | [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) factory | 
 | [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) | public | Class | Singleton holding the application configuration (options) | 
 | [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6) | public | Class | Configuration builder providing the methods for adding the configuration items from individual sources | 
 | [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix) | public | Class | Extended logger implementing [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) | 
 | [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) | public abstract | Interface | Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods | 

Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="n-net.adamec.lib.common.core.config__1q6ay5x" />  net.adamec.lib.common.core.config Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) | public | Singleton holding the application configuration (options) | 
 | [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6) | public | Configuration builder providing the methods for adding the configuration items from individual sources | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="t-net.adamec.lib.common.core.config.configuration__1akk3r9" />  Configuration Class ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Sources: config\Configuration.cs</small>


Singleton holding the application configuration (options)



```csharp
public sealed class Configuration
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
This is the simple configuration container in case DI with more sophisticated containers is not used The configuration is stored as the key-value dictionary, supporting hierarchy using the dot separator and arrays.The arrays can contain values or another objects. Actually, mixed arrays of values and objects can be stored, but they are not supported for binding. For example `section1.option1` means the option1 available in section1, `section1.subSection2.option1` means the option1 available in section1.subSection2. `section1.option1[0]` means, that the option1 is array of values or objects (sections) within the section1. For arrays, the keys are like `OtherSection.SimpleArray[0]` or `OtherSection.ComplexObjectArray[0].Name`

 [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) class provides a singleton instance, however the key functionality is provided via static functions, so no need to touch the [Instance](#p-net.adamec.lib.common.core.config.configuration.instance__svsil0) at all. The items can be retrieved by key using the [Get(string)](#m-net.adamec.lib.common.core.config.configuration.get_system.string___18gsgyv) and [Get&lt;TValueType&gt;(string, Configuration.TValueType)](#m-net.adamec.lib.common.core.config.configuration.get--1_system.string---0___5k6md0) methods. The first one returns null when the key is not found, the other one allow to define the default value to be returned, when the item is not found.

 The inner class [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6) provides the methods to build the configuration from JSON config files, commandline arguments, environment values and/or direct entries. The static method [Builder()](#m-net.adamec.lib.common.core.config.configuration.builder__8hz4rf) clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6) allowing to build a configuration from scratch. The configuration is updated directly during the calls to builder methods, the existing items (keys) are updated, so it&#39;s possible to manage the priority of individual sources and the overrides if needed. The method [Build()](#m-net.adamec.lib.common.core.config.configuration.configurationbuilder.build__1runkhj) returns the configuration instance, breaking the fluent design of builder methods, however there is no other functionality within the method, so it&#39;s more the convention than need to use it at the end of configuration build.

 Configuration binding it the way, how to access the configuration using the configuration objects instead of querying the individual items by key. When the method [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.lib.common.core.config.configuration.bind--1_system.string-system.boolean___989gee) is used, it creates a new instance of given type and tries to map the public properties with public setter to the keys (using the &quot;dot notation&quot;) within the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) . It&#39;s possible to bind the object to  to the root  of the configuration to provide the whole configuration at once or bind it to the particular section to provide a configuration sub-tree. In general, the nested objects and both value and object arrays are supported. There are some rules when binding the arrays: The index must start with zero and must be in sequence (the first non-existing index stops the evaluation). The array should not mix the array or values and array of objects. The decision is made at the first item (index=0) whether it&#39;s value or object.

 The implementation  of binding treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true. This is useful when the command line arguments are used like flags. For example having the argument `-p:SkipStep1` and prefix `-p:` , the binding a bool property `SkipStep1` will set the value of the property to `true` (doesn&#39;t change the configuration item itself). Of course, it&#39;s still possible to use the syntax `-p:SkipStep1=true` or `-p:SkipStep1=false` even in this case.

 As the binding uses the reflection, it&#39;s quite expensive operation, so by default, the bound objects are cached (the cache key is the type of bound object, so binding the same type to different sections is not recommended ). It&#39;s possible to force the binding using the parameter of [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.lib.common.core.config.configuration.bind--1_system.string-system.boolean___989gee) method. In general, the recommended pattern is to [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.lib.common.core.config.configuration.bind--1_system.string-system.boolean___989gee) the configuration  object after the configuration is built and then [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.lib.common.core.config.configuration.retrieve--1__12g1h9d) it from the cache when needed.




###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [bindingsCache](#f-net.adamec.lib.common.core.config.configuration.bindingscache__1l7sa9v) | private | Cache for bindings. Dictionary of type bound as a key and the bound object as value. | 
 | [instance](#f-net.adamec.lib.common.core.config.configuration.instance__1ezti22) | private static | Instance of the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) created when the singleton is first touched | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Instance](#p-net.adamec.lib.common.core.config.configuration.instance__svsil0) | public static | Public [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) instance | 
 | [Items](#p-net.adamec.lib.common.core.config.configuration.items__b4jvtt) | private | Configuration items stored as key-value pairs | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Configuration()](#m-net.adamec.lib.common.core.config.configuration.-cctor__1ooanmi) | private static | Static constructor | 
 | [Configuration()](#m-net.adamec.lib.common.core.config.configuration.-ctor__doxeb7) | private | Private constructor used to build the singleton instance | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddOrUpdateItem(string, object)](#m-net.adamec.lib.common.core.config.configuration.addorupdateitem_system.string-system.object___zdqimv) | private | Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists. | 
 | [Bind(Type, string)](#m-net.adamec.lib.common.core.config.configuration.bind_system.type-system.string___nirsun) | private static | Creates a  new object with given <strong>type</strong> and binds the configuration to its public properties where possible. | 
 | [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.lib.common.core.config.configuration.bind--1_system.string-system.boolean___989gee) | public static | Binds the configuration to given <strong>TOptionsContainer</strong> type and returns the bound object of such type. The resulting configuration object is stored to the cache and can be later on retrieved using [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.lib.common.core.config.configuration.retrieve--1__12g1h9d) | 
 | [Builder()](#m-net.adamec.lib.common.core.config.configuration.builder__8hz4rf) | public static | Clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6) | 
 | [Get(string)](#m-net.adamec.lib.common.core.config.configuration.get_system.string___18gsgyv) | public static | Gets the configuration item by <strong>key</strong> | 
 | [Get&lt;TValueType&gt;(string, Configuration.TValueType)](#m-net.adamec.lib.common.core.config.configuration.get--1_system.string---0___5k6md0) | public static | Gets the typed configuration item by <strong>key</strong> . Returns the default value, that can be provided or is default to given <strong>TValueType</strong> The function tries to convert the value to <strong>TValueType</strong> using <a href="https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype#System_Convert_ChangeType_System_Object_System_Type_" target="_blank" >System.Convert.ChangeType(System.Object,System.Type)</a> if the conversion is not successful, the default is returned. | 
 | [GetSection(string)](#m-net.adamec.lib.common.core.config.configuration.getsection_system.string___1jts3sw) | private static | Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section! When the section is not provided, the whole configuration tree is returned. | 
 | [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.lib.common.core.config.configuration.retrieve--1__12g1h9d) | public static | Retrieves the configuration object of given <strong>TOptionsContainer</strong> that has been bound and cached before. The new instance of <strong>TOptionsContainer</strong> is created when the type not found in cache | 
 | [TryConvertValue(Type, object, object)](#m-net.adamec.lib.common.core.config.configuration.tryconvertvalue_system.type-system.object-system.object-___63jecz) | private static | Tries to convert <strong>sourceValue</strong> to <strong>targetType</strong> . The converted values is returned in <strong>targetValue</strong> out parameter, the result of conversion is the function return value. | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="f-net.adamec.lib.common.core.config.configuration.bindingscache__1l7sa9v" />  Configuration.bindingsCache Field ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Cache for bindings. Dictionary of type bound as a key and the bound object as value.



```csharp
private readonly ConcurrentDictionary<System.Type,object> bindingsCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;System.Type,object&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Cache is used to prevent the &quot;expensive&quot; binding operation in case there is no need to refresh the bound configuration object


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="f-net.adamec.lib.common.core.config.configuration.instance__1ezti22" />  Configuration.instance Field ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Instance of the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) created when the singleton is first touched



```csharp
private static readonly Configuration instance
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)</dt><dd></dd></dl>


###  Remarks ###
Not using the auto-property to have better control, when the instance is created


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="p-net.adamec.lib.common.core.config.configuration.instance__svsil0" />  Configuration.Instance Property ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Public [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) instance



```csharp
public static Configuration Instance { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="p-net.adamec.lib.common.core.config.configuration.items__b4jvtt" />  Configuration.Items Property ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Configuration items stored as key-value pairs



```csharp
private ConcurrentDictionary<string,object> Items { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;string,object&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.-cctor__1ooanmi" />  Configuration.Configuration() Constructor ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Static constructor



```csharp
private static Configuration()
```

###  Remarks ###
Explicit static constructor to tell C# compiler not to mark type as beforefieldinit


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.-ctor__doxeb7" />  Configuration.Configuration() Constructor ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Private constructor used to build the singleton instance



```csharp
private Configuration()
```

Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.addorupdateitem_system.string-system.object___zdqimv" />  Configuration.AddOrUpdateItem(string, object) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists.



```csharp
private void AddOrUpdateItem(string key, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Configuration item key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>The value to be set for the configuration item</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>key</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.bind_system.type-system.string___nirsun" />  Configuration.Bind(Type, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Creates a  new object with given <strong>type</strong> and binds the configuration to its public properties where possible.



```csharp
private static object Bind(Type type, string sectionName = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to bind the configuration to</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional section to bind</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The instance of <strong>type</strong> bound to the configuration</dd></dl>


###  Remarks ###
This method doesn&#39;t use the binding cache


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>type</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.bind--1_system.string-system.boolean___989gee" />  Configuration.Bind&lt;TOptionsContainer&gt;(string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Binds the configuration to given <strong>TOptionsContainer</strong> type and returns the bound object of such type. The resulting configuration object is stored to the cache and can be later on retrieved using [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.lib.common.core.config.configuration.retrieve--1__12g1h9d)



```csharp
public static Configuration.TOptionsContainer Bind<TOptionsContainer>(string sectionName = null, bool allowCached = true) where TOptionsContainer: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptionsContainer</strong></dt><dd>Type to bind the configuration to</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional section to bind</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>allowCached</strong></dt><dd>True if the cache of bindings can be used to retrieve existing binding with the same <strong>TOptionsContainer</strong> and <strong>sectionName</strong></dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.config.Configuration.TOptionsContainer</dt><dd>The instance of <strong>TOptionsContainer</strong> bound to the configuration</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.builder__8hz4rf" />  Configuration.Builder() Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)



```csharp
public static Configuration.ConfigurationBuilder Builder()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dt><dd>The instance of [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.get_system.string___18gsgyv" />  Configuration.Get(string) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Gets the configuration item by <strong>key</strong>



```csharp
public static object Get(string key)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Key of the configuration item</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Retrieved configuration item value or null if not found (or the configuration item is null itself)</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.get--1_system.string---0___5k6md0" />  Configuration.Get&lt;TValueType&gt;(string, Configuration.TValueType) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Gets the typed configuration item by <strong>key</strong> . Returns the default value, that can be provided or is default to given <strong>TValueType</strong> The function tries to convert the value to <strong>TValueType</strong> using <a href="https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype#System_Convert_ChangeType_System_Object_System_Type_" target="_blank" >System.Convert.ChangeType(System.Object,System.Type)</a> if the conversion is not successful, the default is returned.



```csharp
public static Configuration.TValueType Get<TValueType>(string key, Configuration.TValueType defaultValue = null)
```

<strong>Type parameters</strong><dl><dt><strong>TValueType</strong></dt><dd>The type the value is to be retrieved in</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Key of the configuration item</dd><dt>net.adamec.lib.common.core.config.Configuration.TValueType <strong>defaultValue</strong></dt><dd>Optional default value to be returned when the value can&#39;t be retrieved of converted</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.config.Configuration.TValueType</dt><dd>Retrieved configuration item value or <strong>defaultValue</strong> when it can&#39;t be retrieved or converted</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.getsection_system.string___1jts3sw" />  Configuration.GetSection(string) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section! When the section is not provided, the whole configuration tree is returned.



```csharp
private static Dictionary<string,object> GetSection(string sectionName = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional name of the section.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a></dt><dd>The configuration items that belong to the section with <strong>sectionName</strong> . The keys in returned dictionary are relative to given section!</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.retrieve--1__12g1h9d" />  Configuration.Retrieve&lt;TOptionsContainer&gt;() Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Retrieves the configuration object of given <strong>TOptionsContainer</strong> that has been bound and cached before. The new instance of <strong>TOptionsContainer</strong> is created when the type not found in cache



```csharp
public static Configuration.TOptionsContainer Retrieve<TOptionsContainer>() where TOptionsContainer: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptionsContainer</strong></dt><dd>Type of the configuration class to retrieve from cache</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.config.Configuration.TOptionsContainer</dt><dd>The instance of <strong>TOptionsContainer</strong> bound to the configuration or a new instance if not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.tryconvertvalue_system.type-system.object-system.object-___63jecz" />  Configuration.TryConvertValue(Type, object, object) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)           
Sources: config\Configuration.cs</small>


Tries to convert <strong>sourceValue</strong> to <strong>targetType</strong> . The converted values is returned in <strong>targetValue</strong> out parameter, the result of conversion is the function return value.



```csharp
private static bool TryConvertValue(Type targetType, object sourceValue, out object targetValue)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>targetType</strong></dt><dd>Target (property) type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sourceValue</strong></dt><dd>Source value as stored in configuration item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>targetValue</strong></dt><dd><strong>sourceValue</strong> converted to <strong>targetType</strong> when the conversion succeeded (return value is true) or source value otherwise</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>The result or conversion. If true, the <strong>targetValue</strong> can be set to property having <strong>targetType</strong></dd></dl>


###  Remarks ###
The implementation treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true.


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6" />  Configuration.ConfigurationBuilder Class ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Sources: config\Configuration.cs</small>


Configuration builder providing the methods for adding the configuration items from individual sources



```csharp
public class Configuration.ConfigurationBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(string, object)](#m-net.adamec.lib.common.core.config.configuration.configurationbuilder.add_system.string-system.object___awv60h) | public | Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists. | 
 | [AddCommandLineArguments(string[])](#m-net.adamec.lib.common.core.config.configuration.configurationbuilder.addcommandlinearguments_system.string_____hzn4jm) | public | Adds the command line arguments starting with <strong>prefixes</strong> into the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) . When a configuration item exists, the value is updated. | 
 | [AddEnvironmentVariables()](#m-net.adamec.lib.common.core.config.configuration.configurationbuilder.addenvironmentvariables__f440e4) | public | Adds all environment variables into the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) . When a configuration item exists, the value is updated. | 
 | [AddJsonFile(string, bool, bool)](#m-net.adamec.lib.common.core.config.configuration.configurationbuilder.addjsonfile_system.string-system.boolean-system.boolean___slvwrt) | public | Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays) When a configuration item exists, the value is updated. | 
 | [Build()](#m-net.adamec.lib.common.core.config.configuration.configurationbuilder.build__1runkhj) | public | Finishes the configuration building and returns the [Instance](#p-net.adamec.lib.common.core.config.configuration.instance__svsil0) | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.configurationbuilder.add_system.string-system.object___awv60h" />  Configuration.ConfigurationBuilder.Add(string, object) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)           
Sources: config\Configuration.cs</small>


Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists.



```csharp
public Configuration.ConfigurationBuilder Add(string key, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Configuration item key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>The value to be set for the configuration item</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>key</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.configurationbuilder.addcommandlinearguments_system.string_____hzn4jm" />  Configuration.ConfigurationBuilder.AddCommandLineArguments(string[]) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)           
Sources: config\Configuration.cs</small>


Adds the command line arguments starting with <strong>prefixes</strong> into the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) . When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddCommandLineArguments(params string[] prefixes)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>prefixes</strong></dt><dd>Optional list of prefixes marking the command line arguments to be the configuration items</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dd></dl>


###  Remarks ###
The command line arguments have the syntax `key=value` (for example `Key1=Option1` or `prefixkey=value` (for example `-p:Key1=Option1` where `-p:` is the prefix). When the prefixes are not provided, all command line arguments are added to the configuration. When the prefixes are provided,the prefix is not a part of the key. The implementation  of binding treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true, allowing to use the parameters like flags. For example having the argument `-p:SkipStep1` and prefix `-p:` , the binding a bool property `SkipStep1` will set the value of the property to `true` (doesn&#39;t change the configuration item itself). Of course, it&#39;s still possible to use the syntax `-p:SkipStep1=true` or `-p:SkipStep1=false` even in this case.




Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.configurationbuilder.addenvironmentvariables__f440e4" />  Configuration.ConfigurationBuilder.AddEnvironmentVariables() Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)           
Sources: config\Configuration.cs</small>


Adds all environment variables into the [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) . When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddEnvironmentVariables()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dd></dl>


###  Remarks ###
The name of the environment variable is used as a key to the configuration item. Use the &quot;dot notation&quot; in variable names to support the configuration hierarchy.


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.configurationbuilder.addjsonfile_system.string-system.boolean-system.boolean___slvwrt" />  Configuration.ConfigurationBuilder.AddJsonFile(string, bool, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)           
Sources: config\Configuration.cs</small>


Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays) When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddJsonFile(string fileName, bool ignoreNullOrEmptyFileName = false, bool ignoreIfNotExist = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Name of the JSON file with configuration</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>ignoreNullOrEmptyFileName</strong></dt><dd>If true, the missing file name will not throw the exception and the method just &quot;silently&quot; ends.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>ignoreIfNotExist</strong></dt><dd>If true, the non existing file will not throw the exception and the method just &quot;silently&quot; ends.</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>fileName</strong> is null or empty and <strong>ignoreNullOrEmptyFileName</strong> is false</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>fileName</strong> doesn&#39;t exist and <strong>ignoreIfNotExist</strong> is false</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.config.configuration.configurationbuilder.build__1runkhj" />  Configuration.ConfigurationBuilder.Build() Method ##
<small>Namespace: [net.adamec.lib.common.core.config](#n-net.adamec.lib.common.core.config__1q6ay5x)           
Assembly: net.adamec.lib.common.core           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.lib.common.core.config.configuration.configurationbuilder__90jrb6)           
Sources: config\Configuration.cs</small>


Finishes the configuration building and returns the [Instance](#p-net.adamec.lib.common.core.config.configuration.instance__svsil0)



```csharp
public Configuration Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.config.Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9)</dt><dd>The [Configuration](#t-net.adamec.lib.common.core.config.configuration__1akk3r9) singleton</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="n-net.adamec.lib.common.core.logging__1s55q1k" />  net.adamec.lib.common.core.logging Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CommonLogging](#t-net.adamec.lib.common.core.logging.commonlogging__1x32qka) | public static | [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) factory | 
 | [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix) | public | Extended logger implementing [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) | public abstract | Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="t-net.adamec.lib.common.core.logging.commonlogging__1x32qka" />  CommonLogging Class ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Sources: logging\CommonLogging.cs</small>


[ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h) factory



```csharp
public static class CommonLogging
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateLogger(string)](#m-net.adamec.lib.common.core.logging.commonlogging.createlogger_system.string___1f44gey) | public static | Creates the logger with given <strong>categoryName</strong> | 
 | [CreateLogger(Type)](#m-net.adamec.lib.common.core.logging.commonlogging.createlogger_system.type___1du8p4r) | public static | Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a> | 
 | [CreateLogger&lt;T&gt;()](#m-net.adamec.lib.common.core.logging.commonlogging.createlogger--1__53om5m) | public static | Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a> | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.commonlogging.createlogger_system.string___1f44gey" />  CommonLogging.CreateLogger(string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [CommonLogging](#t-net.adamec.lib.common.core.logging.commonlogging__1x32qka)           
Sources: logging\CommonLogging.cs</small>


Creates the logger with given <strong>categoryName</strong>



```csharp
public static ILogger CreateLogger(string categoryName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>categoryName</strong></dt><dd>Name of the logger</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.logging.ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.commonlogging.createlogger_system.type___1du8p4r" />  CommonLogging.CreateLogger(Type) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [CommonLogging](#t-net.adamec.lib.common.core.logging.commonlogging__1x32qka)           
Sources: logging\CommonLogging.cs</small>


Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a>



```csharp
public static ILogger CreateLogger(Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to create the logger for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.logging.ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.commonlogging.createlogger--1__53om5m" />  CommonLogging.CreateLogger&lt;T&gt;() Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [CommonLogging](#t-net.adamec.lib.common.core.logging.commonlogging__1x32qka)           
Sources: logging\CommonLogging.cs</small>


Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a>



```csharp
public static ILogger CreateLogger<T>()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type to create the logger for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.core.logging.ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="t-net.adamec.lib.common.core.logging.loggerext__1aeycix" />  LoggerExt Class ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Sources: logging\LoggerExt.CorrelationId.cs, logging\LoggerExt.cs, logging\LoggerExt.EventProperties.cs, logging\LoggerExt.ExceptionFilter.cs, logging\LoggerExt.ExceptionPassThrough.cs</small>


Extended logger implementing [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)



```csharp
public class LoggerExt : Logger, ILogger
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; NLog.Logger           
Implements: [net.adamec.lib.common.core.logging.ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h), NLog.ILogger, NLog.ILoggerBase, NLog.ISuppress


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateException&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.loggerext.createexception--1_system.string-system.string--system.exception___gv82y9) | private static | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [Debug(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.loggerext.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___12jvdw5) | public | Writes the diagnostic message at the `Debug` level. | 
 | [DebugCorr(string, string)](#m-net.adamec.lib.common.core.logging.loggerext.debugcorr_system.string-system.string___1vciqec) | public | Writes the diagnostic message at the `Debug` level with correlation ID. | 
 | [Error(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___13j0xyo) | public | Writes the diagnostic message at the `Error` level. | 
 | [Error(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.string___gaullw) | public | Writes the diagnostic message at the `Error` level. | 
 | [Error&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.loggerext.error--1_system.string-system.exception___1b66v34) | public | Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type | 
 | [ErrorCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.errorcorr_system.string-system.exception-system.string___glh8ib) | public | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr(string, string)](#m-net.adamec.lib.common.core.logging.loggerext.errorcorr_system.string-system.string___1v17zgb) | public | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr&lt;TException&gt;(string, LoggerExt.TException, string)](#m-net.adamec.lib.common.core.logging.loggerext.errorcorr--1_system.string---0-system.string___1u206c2) | public | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorCorr&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.loggerext.errorcorr--1_system.string-system.string-system.exception___1u345km) | public | Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type | 
 | [ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___urporj) | public | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.errorfltrcorr--1_system.string---0-system.string-system.boolean___1emqn0t) | public | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.errorpassthrough_system.exception-system.string___1v1x3rv) | public | Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong> | 
 | [Fatal(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1jocg2c) | public | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___hi7jxo) | public | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.loggerext.fatal--1_system.string-system.exception___16xajtw) | public | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [FatalCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.fatalcorr_system.string-system.exception-system.string___hk8lud) | public | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr(string, string)](#m-net.adamec.lib.common.core.logging.loggerext.fatalcorr_system.string-system.string___1by18q9) | public | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr&lt;TException&gt;(string, LoggerExt.TException, string)](#m-net.adamec.lib.common.core.logging.loggerext.fatalcorr--1_system.string---0-system.string___1gzp2nu) | public | Writes the diagnostic message at the `Fatal` level and returns the exception of given type | 
 | [FatalCorr&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.loggerext.fatalcorr--1_system.string-system.string-system.exception___500x9y) | public | Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type | 
 | [FatalFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.fatalfltr--1_--0-system.string-system.boolean___g4elu9) | public | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.fatalfltrcorr--1_system.string---0-system.string-system.boolean___k3oapn) | public | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.fatalpassthrough_system.exception-system.string___49a9f1) | public | Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong> &gt; | 
 | [Info(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.loggerext.info_system.collections.generic.dictionary_system.string-system.object_-system.string___134z29q) | public | Writes the diagnostic message at the `Info` level. | 
 | [InfoCorr(string, string)](#m-net.adamec.lib.common.core.logging.loggerext.infocorr_system.string-system.string___6odg4h) | public | Writes the diagnostic message at the `Info` level with correlation ID. | 
 | [LogIt(LogLevel, Dictionary&lt;string,object&gt;, string, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.logit_nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception-system.string___7kezy9) | private | Writes the item (message with optional event properties and exception)  into the log | 
 | [LogIt(LogLevel, string, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.logit_nlog.loglevel-system.string-system.exception-system.string___c50zo8) | private | Writes the item (message with optional exception)  into the log | 
 | [LogIt(LogLevel, string, string, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.logit_nlog.loglevel-system.string-system.string-system.exception-system.string___zz7fm8) | private | Writes the item (message with optional exception) with correlation Id into the log | 
 | [Trace(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.loggerext.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___1s43qmh) | public | Writes the diagnostic message at the `Trace` level. | 
 | [TraceCorr(string, string)](#m-net.adamec.lib.common.core.logging.loggerext.tracecorr_system.string-system.string___19gcjny) | public | Writes the diagnostic message at the `Trace` level with correlation ID | 
 | [Warn(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1l2efzm) | public | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___1olzpfm) | public | Writes the diagnostic message at the `Warn` level. | 
 | [WarnCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.loggerext.warncorr_system.string-system.exception-system.string___bxfkhp) | public | Writes the diagnostic message at the `Warn` level with correlation ID. | 
 | [WarnCorr(string, string)](#m-net.adamec.lib.common.core.logging.loggerext.warncorr_system.string-system.string___2mtn55) | public | Writes the diagnostic message at the `Warn` level with correlation ID. | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.createexception--1_system.string-system.string--system.exception___gv82y9" />  LoggerExt.CreateException&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.cs</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
private static LoggerExt.TException CreateException<TException>(string message, out string stackTrace, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>stackTrace</strong></dt><dd>Stack trace to be logged in `StackTrace` event property</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___12jvdw5" />  LoggerExt.Debug(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Debug` level.



```csharp
public void Debug(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Debug(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___1d4086l)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.debugcorr_system.string-system.string___1vciqec" />  LoggerExt.DebugCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Debug` level with correlation ID.



```csharp
public void DebugCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.DebugCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.debugcorr_system.string-system.string___1ni5dj8)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___13j0xyo" />  LoggerExt.Error(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Error` level.



```csharp
public void Error(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Error(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1b3rh4)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.string___gaullw" />  LoggerExt.Error(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Error` level.



```csharp
public void Error(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Error(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___mem0ik)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.error--1_system.string-system.exception___1b66v34" />  LoggerExt.Error&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type



```csharp
public LoggerExt.TException Error<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.Error&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.error--1_system.string-system.exception___urvjig)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorcorr_system.string-system.exception-system.string___glh8ib" />  LoggerExt.ErrorCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public void ErrorCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.ErrorCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr_system.string-system.exception-system.string___1all5er)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorcorr_system.string-system.string___1v17zgb" />  LoggerExt.ErrorCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public void ErrorCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.ErrorCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr_system.string-system.string___1w7b7or)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorcorr--1_system.string---0-system.string___1u206c2" />  LoggerExt.ErrorCorr&lt;TException&gt;(string, LoggerExt.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public LoggerExt.TException ErrorCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.ErrorCorr&lt;TException&gt;(string, ILogger.TException, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr--1_system.string---0-system.string___15rz22y)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorcorr--1_system.string-system.string-system.exception___1u345km" />  LoggerExt.ErrorCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type



```csharp
public LoggerExt.TException ErrorCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.ErrorCorr&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr--1_system.string-system.string-system.exception___zycwpy)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___urporj" />  LoggerExt.ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.ExceptionFilter.cs</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public bool ErrorFltr<TException>(LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb)


###  Example ###
The following code logs any exception without catching it (function returns false by default) 
```csharp
    try
    {
      ...
    }
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```
 The following code catch and log the ArgumentException and logs any other exception without catching it. 
```csharp
    try
    {
      ...
    }
    catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) {}
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```



###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorfltrcorr--1_system.string---0-system.string-system.boolean___1emqn0t" />  LoggerExt.ErrorFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public bool ErrorFltrCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.ErrorFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltrcorr--1_system.string---0-system.string-system.boolean___cp8skd)


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___urporj)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.errorpassthrough_system.exception-system.string___1v1x3rv" />  LoggerExt.ErrorPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong>



```csharp
public Exception ErrorPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.ErrorPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorpassthrough_system.exception-system.string___1ewxalv)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1jocg2c" />  LoggerExt.Fatal(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public void Fatal(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Fatal(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1mot8ic)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___hi7jxo" />  LoggerExt.Fatal(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public void Fatal(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Fatal(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1xh403w)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatal--1_system.string-system.exception___16xajtw" />  LoggerExt.Fatal&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
public LoggerExt.TException Fatal<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.Fatal&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.fatal--1_system.string-system.exception___3m9nac)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalcorr_system.string-system.exception-system.string___hk8lud" />  LoggerExt.FatalCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public void FatalCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.FatalCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr_system.string-system.exception-system.string___zugzl9)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalcorr_system.string-system.string___1by18q9" />  LoggerExt.FatalCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public void FatalCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.FatalCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr_system.string-system.string___1iiczh5)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalcorr--1_system.string---0-system.string___1gzp2nu" />  LoggerExt.FatalCorr&lt;TException&gt;(string, LoggerExt.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level and returns the exception of given type



```csharp
public LoggerExt.TException FatalCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.FatalCorr&lt;TException&gt;(string, ILogger.TException, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr--1_system.string---0-system.string___1h2a4gq)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalcorr--1_system.string-system.string-system.exception___500x9y" />  LoggerExt.FatalCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type



```csharp
public LoggerExt.TException FatalCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.FatalCorr&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr--1_system.string-system.string-system.exception___12e1fry)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalfltr--1_--0-system.string-system.boolean___g4elu9" />  LoggerExt.FatalFltr&lt;TException&gt;(LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.ExceptionFilter.cs</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public bool FatalFltr<TException>(LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.core.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.FatalFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1d7c7n5)


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___urporj)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalfltrcorr--1_system.string---0-system.string-system.boolean___k3oapn" />  LoggerExt.FatalFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public bool FatalFltrCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.FatalFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.fatalfltrcorr--1_system.string---0-system.string-system.boolean___b4uopf)


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](#m-net.adamec.lib.common.core.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___urporj)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.fatalpassthrough_system.exception-system.string___49a9f1" />  LoggerExt.FatalPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong> &gt;



```csharp
public Exception FatalPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.FatalPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalpassthrough_system.exception-system.string___5v7ipp)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.info_system.collections.generic.dictionary_system.string-system.object_-system.string___134z29q" />  LoggerExt.Info(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Info` level.



```csharp
public void Info(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Info(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1w4twda)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.infocorr_system.string-system.string___6odg4h" />  LoggerExt.InfoCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Info` level with correlation ID.



```csharp
public void InfoCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.InfoCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.infocorr_system.string-system.string___1h9q83t)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.logit_nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception-system.string___7kezy9" />  LoggerExt.LogIt(LogLevel, Dictionary&lt;string,object&gt;, string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.cs</small>


Writes the item (message with optional event properties and exception)  into the log



```csharp
private void LogIt(LogLevel level, Dictionary<string,object> eventProperties, [Localizable(false)] string message, Exception exception = null, string stackTrace = null)
```

<strong>Method parameters</strong><dl><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties (null when no properties are provided)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>stackTrace</strong></dt><dd>Optional stack trace to be logged in `StackTrace` event property when the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception.stacktrace#System_Exception_StackTrace" target="_blank" >System.Exception.StackTrace</a> of <strong>exception</strong> is empty</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.logit_nlog.loglevel-system.string-system.exception-system.string___c50zo8" />  LoggerExt.LogIt(LogLevel, string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.cs</small>


Writes the item (message with optional exception)  into the log



```csharp
private void LogIt(LogLevel level, [Localizable(false)] string message, Exception exception = null, string stackTrace = null)
```

<strong>Method parameters</strong><dl><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>stackTrace</strong></dt><dd>Optional stack trace to be logged in `StackTrace` event property when the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception.stacktrace#System_Exception_StackTrace" target="_blank" >System.Exception.StackTrace</a> of <strong>exception</strong> is empty</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.logit_nlog.loglevel-system.string-system.string-system.exception-system.string___zz7fm8" />  LoggerExt.LogIt(LogLevel, string, string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the item (message with optional exception) with correlation Id into the log



```csharp
private void LogIt(LogLevel level, string correlationId, [Localizable(false)] string message, Exception exception = null, string stackTrace = null)
```

<strong>Method parameters</strong><dl><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>stackTrace</strong></dt><dd>Optional stack trace to be logged in `StackTrace` event property when the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception.stacktrace#System_Exception_StackTrace" target="_blank" >System.Exception.StackTrace</a> of <strong>exception</strong> is empty</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___1s43qmh" />  LoggerExt.Trace(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Trace` level.



```csharp
public void Trace(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Trace(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___k7nqox)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.tracecorr_system.string-system.string___19gcjny" />  LoggerExt.TraceCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Trace` level with correlation ID



```csharp
public void TraceCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.TraceCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.tracecorr_system.string-system.string___14lwu26)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1l2efzm" />  LoggerExt.Warn(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public void Warn(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Warn(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___15qeutm)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___1olzpfm" />  LoggerExt.Warn(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.EventProperties.cs</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public void Warn(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Warn(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___13bvxqi)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.warncorr_system.string-system.exception-system.string___bxfkhp" />  LoggerExt.WarnCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public void WarnCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.WarnCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.warncorr_system.string-system.exception-system.string___s8xk3x)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.loggerext.warncorr_system.string-system.string___2mtn55" />  LoggerExt.WarnCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Sources: logging\LoggerExt.CorrelationId.cs</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public void WarnCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.WarnCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.warncorr_system.string-system.string___98ayxl)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="t-net.adamec.lib.common.core.logging.ilogger__pion8h" />  ILogger Interface ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Sources: logging\ILogger.CorrelationId.cs, logging\ILogger.cs, logging\ILogger.EventProperties.cs, logging\ILogger.ExceptionFilter.cs, logging\ILogger.ExceptionPassThrough.cs</small>


Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods



```csharp
public interface ILogger : ILogger
```

Implemented by: [net.adamec.lib.common.core.logging.LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix)           
Implements: NLog.ILogger, NLog.ILoggerBase, NLog.ISuppress


###  Remarks ###
The NLog supports having additional (custom) event properties provided to loggers and optionally rendered to logs. The event properties are represented as key-value dictionary, where key is the unique name of the property. Extended logger provides following methods to log with given set of the properties.

 


 - [Trace(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___k7nqox) ,
 - [Debug(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___1d4086l) ,
 - [Info(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1w4twda) ,
 - [Warn(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___13bvxqi) ,
 - [Error(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___mem0ik) ,
 - [Fatal(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1xh403w) ,
 - [Warn(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___15qeutm) ,
 - [Error(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1b3rh4) and
 - [Fatal(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1mot8ic)
           




  Sometimes, it&#39;s useful to have an exception logging method implemented as the operation returning the exception being logged. The [ErrorPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorpassthrough_system.exception-system.string___1ewxalv) and [FatalPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalpassthrough_system.exception-system.string___5v7ipp) methods will log given exception and return it for further processing. 
```csharp
    try
    {
      ...
    }
    catch (Exception ex){
       if(logger.ErrorPassThrough(ex) is MyException){
         return null;
       }else{
         throw;
       } 
    }
```
 In the example above, the exception is always logged and then the decision/action is taken.

 C# 6 brought the exception filters that don&#39;t unwind the stack as the exception is not catch yet when processing the filter. It can also be used for logging the exceptions without actually catching them (when the exception filter returns `false` ). Extended logger provides functions [ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb) and [FatalFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1d7c7n5) for this purpose. 
```csharp
    try
    {
      ...
    }
    catch (Exception ex) when (logger.ErrorFltr(ex,"Error here!"){
      //newer called as the default return value of ErrorFltr is false     
    }
```
 The example above logs but never catch all exceptions. The following code catch and log the ArgumentException and logs any other exception without catching it. 
```csharp
    try
    {
      ...
    }
    catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) { ... }
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```


  Logger can also create and exception, log it and return using functions [Error&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.error--1_system.string-system.exception___urvjig) and [Fatal&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.fatal--1_system.string-system.exception___3m9nac) 
```csharp
    if(value is null) throw logger.Fatal<ArgumentNullException>("Value is null");
```


  When logging an exception using the [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix) methods, the event property `StackTrace` is set from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception.stacktrace#System_Exception_StackTrace" target="_blank" >System.Exception.StackTrace</a> , when the logger creates an exception, the property is set using `new StackTrace(2, true).ToString()` . In other cases when the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception.stacktrace#System_Exception_StackTrace" target="_blank" >System.Exception.StackTrace</a> is null or empty, `new StackTrace(true).ToString()` is used.

  [LoggerExt](#t-net.adamec.lib.common.core.logging.loggerext__1aeycix) also provides set of methods for logging with the correlation ID (for example in integration scenarios), where the given correlation ID is set to the event property `CorrelationId` . Such methods have the name ending with `Corr` suffix.




###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Debug(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___1d4086l) | public abstract | Writes the diagnostic message at the `Debug` level. | 
 | [DebugCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.debugcorr_system.string-system.string___1ni5dj8) | public abstract | Writes the diagnostic message at the `Debug` level with correlation ID. | 
 | [Error(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1b3rh4) | public abstract | Writes the diagnostic message at the `Error` level. | 
 | [Error(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___mem0ik) | public abstract | Writes the diagnostic message at the `Error` level. | 
 | [Error&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.error--1_system.string-system.exception___urvjig) | public abstract | Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type | 
 | [ErrorCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr_system.string-system.exception-system.string___1all5er) | public abstract | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr_system.string-system.string___1w7b7or) | public abstract | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr&lt;TException&gt;(string, ILogger.TException, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr--1_system.string---0-system.string___15rz22y) | public abstract | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorCorr&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.errorcorr--1_system.string-system.string-system.exception___zycwpy) | public abstract | Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type | 
 | [ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb) | public abstract | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltrcorr--1_system.string---0-system.string-system.boolean___cp8skd) | public abstract | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.errorpassthrough_system.exception-system.string___1ewxalv) | public abstract | Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong> | 
 | [Fatal(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1mot8ic) | public abstract | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1xh403w) | public abstract | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal&lt;TException&gt;(string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.fatal--1_system.string-system.exception___3m9nac) | public abstract | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [FatalCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr_system.string-system.exception-system.string___zugzl9) | public abstract | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr_system.string-system.string___1iiczh5) | public abstract | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr&lt;TException&gt;(string, ILogger.TException, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr--1_system.string---0-system.string___1h2a4gq) | public abstract | Writes the diagnostic message at the `Fatal` level and returns the exception of given type | 
 | [FatalCorr&lt;TException&gt;(string, string, Exception)](#m-net.adamec.lib.common.core.logging.ilogger.fatalcorr--1_system.string-system.string-system.exception___12e1fry) | public abstract | Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type | 
 | [FatalFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1d7c7n5) | public abstract | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.fatalfltrcorr--1_system.string---0-system.string-system.boolean___b4uopf) | public abstract | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalPassThrough(Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.fatalpassthrough_system.exception-system.string___5v7ipp) | public abstract | Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong> | 
 | [Info(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1w4twda) | public abstract | Writes the diagnostic message at the `Info` level. | 
 | [InfoCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.infocorr_system.string-system.string___1h9q83t) | public abstract | Writes the diagnostic message at the `Info` level with correlation ID. | 
 | [Trace(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___k7nqox) | public abstract | Writes the diagnostic message at the `Trace` level. | 
 | [TraceCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.tracecorr_system.string-system.string___14lwu26) | public abstract | Writes the diagnostic message at the `Trace` level with correlation ID. | 
 | [Warn(Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___15qeutm) | public abstract | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___13bvxqi) | public abstract | Writes the diagnostic message at the `Warn` level. | 
 | [WarnCorr(string, Exception, string)](#m-net.adamec.lib.common.core.logging.ilogger.warncorr_system.string-system.exception-system.string___s8xk3x) | public abstract | Writes the diagnostic message at the `Warn` level with correlation ID. | 
 | [WarnCorr(string, string)](#m-net.adamec.lib.common.core.logging.ilogger.warncorr_system.string-system.string___98ayxl) | public abstract | Writes the diagnostic message at the `Warn` level with correlation ID. | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___1d4086l" />  ILogger.Debug(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Debug` level.



```csharp
public abstract void Debug(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.debugcorr_system.string-system.string___1ni5dj8" />  ILogger.DebugCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Debug` level with correlation ID.



```csharp
public abstract void DebugCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1b3rh4" />  ILogger.Error(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Error` level.



```csharp
public abstract void Error(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___mem0ik" />  ILogger.Error(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Error` level.



```csharp
public abstract void Error(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.error--1_system.string-system.exception___urvjig" />  ILogger.Error&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException Error<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorcorr_system.string-system.exception-system.string___1all5er" />  ILogger.ErrorCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public abstract void ErrorCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorcorr_system.string-system.string___1w7b7or" />  ILogger.ErrorCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public abstract void ErrorCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorcorr--1_system.string---0-system.string___15rz22y" />  ILogger.ErrorCorr&lt;TException&gt;(string, ILogger.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public abstract ILogger.TException ErrorCorr<TException>(string correlationId, ILogger.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException</dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorcorr--1_system.string-system.string-system.exception___zycwpy" />  ILogger.ErrorCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException ErrorCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb" />  ILogger.ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.ExceptionFilter.cs</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public abstract bool ErrorFltr<TException>(ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Example ###
The following code logs any exception without catching it (function returns false by default) 
```csharp
    try
    {
      ...
    }
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```
 The following code catch and log the ArgumentException and logs any other exception without catching it. 
```csharp
    try
    {
      ...
    }
    catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) {}
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```



###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorfltrcorr--1_system.string---0-system.string-system.boolean___cp8skd" />  ILogger.ErrorFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public abstract bool ErrorFltrCorr<TException>(string correlationId, ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.errorpassthrough_system.exception-system.string___1ewxalv" />  ILogger.ErrorPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong>



```csharp
public abstract Exception ErrorPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1mot8ic" />  ILogger.Fatal(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public abstract void Fatal(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1xh403w" />  ILogger.Fatal(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public abstract void Fatal(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatal--1_system.string-system.exception___3m9nac" />  ILogger.Fatal&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException Fatal<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalcorr_system.string-system.exception-system.string___zugzl9" />  ILogger.FatalCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public abstract void FatalCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalcorr_system.string-system.string___1iiczh5" />  ILogger.FatalCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public abstract void FatalCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalcorr--1_system.string---0-system.string___1h2a4gq" />  ILogger.FatalCorr&lt;TException&gt;(string, ILogger.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level and returns the exception of given type



```csharp
public abstract ILogger.TException FatalCorr<TException>(string correlationId, ILogger.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException</dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalcorr--1_system.string-system.string-system.exception___12e1fry" />  ILogger.FatalCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException FatalCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1d7c7n5" />  ILogger.FatalFltr&lt;TException&gt;(ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.ExceptionFilter.cs</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public abstract bool FatalFltr<TException>(ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalfltrcorr--1_system.string---0-system.string-system.boolean___b4uopf" />  ILogger.FatalFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public abstract bool FatalFltrCorr<TException>(string correlationId, ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.core.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](#m-net.adamec.lib.common.core.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___jv4zvb)


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.fatalpassthrough_system.exception-system.string___5v7ipp" />  ILogger.FatalPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.ExceptionPassThrough.cs</small>


Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong>



```csharp
public abstract Exception FatalPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1w4twda" />  ILogger.Info(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Info` level.



```csharp
public abstract void Info(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.infocorr_system.string-system.string___1h9q83t" />  ILogger.InfoCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Info` level with correlation ID.



```csharp
public abstract void InfoCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___k7nqox" />  ILogger.Trace(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Trace` level.



```csharp
public abstract void Trace(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.tracecorr_system.string-system.string___14lwu26" />  ILogger.TraceCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Trace` level with correlation ID.



```csharp
public abstract void TraceCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___15qeutm" />  ILogger.Warn(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public abstract void Warn(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___13bvxqi" />  ILogger.Warn(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.EventProperties.cs</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public abstract void Warn(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.warncorr_system.string-system.exception-system.string___s8xk3x" />  ILogger.WarnCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public abstract void WarnCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.logging.ilogger.warncorr_system.string-system.string___98ayxl" />  ILogger.WarnCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.core.logging](#n-net.adamec.lib.common.core.logging__1s55q1k)           
Assembly: net.adamec.lib.common.core           
Type: [ILogger](#t-net.adamec.lib.common.core.logging.ilogger__pion8h)           
Sources: logging\ILogger.CorrelationId.cs</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public abstract void WarnCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="n-net.adamec.lib.common.core.utils__1ltknbs" />  net.adamec.lib.common.core.utils Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh) | public abstract | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh" />  BaseDisposable Class ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Sources: utils\BaseDisposable.cs</small>


Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types



```csharp
public abstract class BaseDisposable : IDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs) | 1 | Internal flag whether the object is fully disposed | 

 


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [isDisposed](#f-net.adamec.lib.common.core.utils.basedisposable.isdisposed__n61qq6) | private | The object is disposed when equals to [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs) | 
 | [isManagedDisposed](#f-net.adamec.lib.common.core.utils.basedisposable.ismanageddisposed__1rksf51) | private | The managed resources are disposed when equals to [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs) | 
 | [isNativeDisposed](#f-net.adamec.lib.common.core.utils.basedisposable.isnativedisposed__hgch1d) | private | The native resources are disposed when equals to [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs) | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Disposed](#p-net.adamec.lib.common.core.utils.basedisposable.disposed__18q7dig) | public | Returns ```csharp true ``` when the object is fully disposed | 
 | [DisposedManaged](#p-net.adamec.lib.common.core.utils.basedisposable.disposedmanaged__t02rvd) | public | Returns ```csharp true ``` when the managed resources are disposed | 
 | [DisposedNative](#p-net.adamec.lib.common.core.utils.basedisposable.disposednative__f70w4d) | public | Returns ```csharp true ``` when the native resources are disposed | 

 


###  Destructor ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [~BaseDisposable()](#m-net.adamec.lib.common.core.utils.basedisposable.finalize__1lkn2hc) | protected |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssertNotDisposed(string)](#m-net.adamec.lib.common.core.utils.basedisposable.assertnotdisposed_system.string___1g7ogfx) | protected | Throws an <a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a> when the current object is disposed | 
 | [Dispose()](#m-net.adamec.lib.common.core.utils.basedisposable.dispose__mtboxd) | public | Dispose the object | 
 | [Dispose(bool)](#m-net.adamec.lib.common.core.utils.basedisposable.dispose_system.boolean___1v427g3) | protected | Internal implementation of dispose - free the managed and native resources using the respective methods | 
 | [DisposeManaged()](#m-net.adamec.lib.common.core.utils.basedisposable.disposemanaged__dm848c) | protected | Dispose any disposable managed fields or properties. | 
 | [DisposeNative()](#m-net.adamec.lib.common.core.utils.basedisposable.disposenative__10cel2o) | protected | Dispose of COM objects, Handles, etc. Then set those objects to null. | 

 


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs" />  BaseDisposable.DisposedFlag Constant ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Internal flag whether the object is fully disposed



```csharp
private const int DisposedFlag = 1
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="f-net.adamec.lib.common.core.utils.basedisposable.isdisposed__n61qq6" />  BaseDisposable.isDisposed Field ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


The object is disposed when equals to [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs)



```csharp
private int isDisposed
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="f-net.adamec.lib.common.core.utils.basedisposable.ismanageddisposed__1rksf51" />  BaseDisposable.isManagedDisposed Field ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


The managed resources are disposed when equals to [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs)



```csharp
private int isManagedDisposed
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="f-net.adamec.lib.common.core.utils.basedisposable.isnativedisposed__hgch1d" />  BaseDisposable.isNativeDisposed Field ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


The native resources are disposed when equals to [DisposedFlag](#f-net.adamec.lib.common.core.utils.basedisposable.disposedflag__1062pgs)



```csharp
private int isNativeDisposed
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="p-net.adamec.lib.common.core.utils.basedisposable.disposed__18q7dig" />  BaseDisposable.Disposed Property ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Returns 
```csharp
true
```
 when the object is fully disposed



```csharp
public bool Disposed { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="p-net.adamec.lib.common.core.utils.basedisposable.disposedmanaged__t02rvd" />  BaseDisposable.DisposedManaged Property ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Returns 
```csharp
true
```
 when the managed resources are disposed



```csharp
public bool DisposedManaged { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="p-net.adamec.lib.common.core.utils.basedisposable.disposednative__f70w4d" />  BaseDisposable.DisposedNative Property ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Returns 
```csharp
true
```
 when the native resources are disposed



```csharp
public bool DisposedNative { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.utils.basedisposable.finalize__1lkn2hc" />  BaseDisposable.~BaseDisposable() Destructor ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>



```csharp
 ~BaseDisposable()
```

Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.utils.basedisposable.assertnotdisposed_system.string___1g7ogfx" />  BaseDisposable.AssertNotDisposed(string) Method ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Throws an <a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a> when the current object is disposed



```csharp
protected void AssertNotDisposed(string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Optional exception message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.objectdisposedexception" target="_blank" >System.ObjectDisposedException</a></dt><dd>Current object is disposed</dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.utils.basedisposable.dispose__mtboxd" />  BaseDisposable.Dispose() Method ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Dispose the object



```csharp
public void Dispose()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose#System_IDisposable_Dispose" target="_blank" >IDisposable.Dispose</a>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.utils.basedisposable.dispose_system.boolean___1v427g3" />  BaseDisposable.Dispose(bool) Method ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Internal implementation of dispose - free the managed and native resources using the respective methods



```csharp
protected virtual void Dispose(bool disposing)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>disposing</strong></dt><dd>True to dispose both managed and native resources, false to dispose the native resources only</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.utils.basedisposable.disposemanaged__dm848c" />  BaseDisposable.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Dispose any disposable managed fields or properties.



```csharp
protected virtual void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 


##  <a id="m-net.adamec.lib.common.core.utils.basedisposable.disposenative__10cel2o" />  BaseDisposable.DisposeNative() Method ##
<small>Namespace: [net.adamec.lib.common.core.utils](#n-net.adamec.lib.common.core.utils__1ltknbs)           
Assembly: net.adamec.lib.common.core           
Type: [BaseDisposable](#t-net.adamec.lib.common.core.utils.basedisposable__mdk3wh)           
Sources: utils\BaseDisposable.cs</small>


Dispose of COM objects, Handles, etc. Then set those objects to null.



```csharp
protected virtual void DisposeNative()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.core.md#namespace-list) or [types](net.adamec.lib.common.core.md#type-list)


 



