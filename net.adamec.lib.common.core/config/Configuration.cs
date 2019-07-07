using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Environment = System.Environment;
using InvalidCastException = System.InvalidCastException;

namespace net.adamec.lib.common.core.config
{
    /// <summary>
    /// Singleton holding the application configuration (options) 
    /// </summary>
    /// <remarks>
    /// This is the simple configuration container in case DI with more sophisticated containers is not used
    /// The configuration is stored as the key-value dictionary, supporting hierarchy using the dot separator
    /// and arrays.The arrays can contain values or another objects. Actually, mixed arrays of values and objects can be
    /// stored, but they are not supported for binding.
    /// <para>
    /// For example <c>section1.option1</c> means the option1 available in section1,
    /// <c>section1.subSection2.option1</c> means the option1 available in section1.subSection2.
    /// <c>section1.option1[0]</c> means, that the option1 is array of values or objects (sections) within the section1.
    ///  For arrays, the keys are like <c>OtherSection.SimpleArray[0]</c> or
    /// <c> OtherSection.ComplexObjectArray[0].Name</c>
    ///</para>
    /// <para>
    /// <see cref="Configuration"/> class provides a singleton instance, however the key functionality
    /// is provided via static functions, so no need to touch the <see cref="Instance"/> at all.
    /// The items can be retrieved by key using the <see cref="Get"/> and <see cref="Get{TValueType}"/>
    /// methods. The first one returns null when the key is not found, the other one allow to
    /// define the default value to be returned, when the item is not found.
    ///  </para>
    /// <para>
    /// The inner class <see cref="ConfigurationBuilder"/>provides the methods to build the configuration
    /// from JSON config files, commandline arguments, environment values and/or direct entries.
    /// The static method <see cref="Builder"/> clears the configuration items and
    /// binding cache and creates a new instance of <see cref="ConfigurationBuilder"  /> allowing
    /// to build a configuration from scratch. The configuration is updated directly during the calls to
    /// builder methods, the existing items (keys) are updated, so it's possible to manage the
    /// priority of individual sources and the overrides if needed.
    /// The method <see cref="ConfigurationBuilder.Build"/> returns the configuration
    /// instance, breaking the fluent design of builder methods, however there is no other functionality
    /// within the method, so it's more the convention than need to use it at the end of configuration build.
    /// </para>
    /// <para>
    /// Configuration binding it the way, how to access the configuration using the configuration objects
    /// instead of querying the individual items by key.
    /// When the method <see cref="Bind{TOptionsContainer}"/> is used, it creates a new instance of
    /// given type and tries to map the public properties with public setter to the keys (using the "dot notation")
    /// within the <see cref="Configuration"/>. It's possible to bind the object to  to
    /// the root  of the configuration to provide the whole configuration at once or
    /// bind it to the particular section to provide a configuration sub-tree.
    /// In general, the nested objects and both value and object arrays are supported. There are some rules
    /// when binding the arrays: The index must start with zero and must be in sequence (the first non-existing
    /// index stops the evaluation). The array should not mix the array or values and array of objects.
    /// The decision is made at the first item (index=0) whether it's value or object.
    /// </para>
    /// <para>
    /// The implementation  of binding treats the <see cref="bool"/> values the special way - if there is no value, but existing key,
    /// the value is converted to true. This is useful when the command line arguments are used like flags.
    /// For example having the argument <c>-p:SkipStep1</c>  and prefix <c>-p:</c>, the binding a bool property
    /// <c>SkipStep1</c> will set the value of the property to <c>true</c>  (doesn't change the configuration item itself).
    /// Of course, it's still possible to use the syntax <c>-p:SkipStep1=true</c> or  <c>-p:SkipStep1=false</c> even in this case.
    /// </para>
    /// <para>
    /// As the binding uses the reflection, it's quite expensive operation, so by default, the bound objects are
    /// cached (the cache key is the type of bound object, so binding the same type to different sections is not recommended ).
    /// It's possible to force the binding using the parameter of <see cref="Bind{TOptionsContainer}"/> method.
    /// In general, the recommended pattern is to <see cref="Bind{TOptionsContainer}"/> the configuration  object after the configuration is built and
    /// then <see cref="Retrieve{TOptionsContainer}"/> it from the cache when needed.
    /// </para>
    /// </remarks>
    public sealed class Configuration
    {
        #region Singleton
        /// <summary>
        /// Instance of the <see cref="Configuration"/> created when the singleton is first touched
        /// </summary>
        /// <remarks>
        /// Not using the auto-property to have better control, when the instance is created
        /// </remarks>
        // ReSharper disable once InconsistentNaming
        private static readonly Configuration instance = new Configuration();

        /// <summary>
        /// Public <see cref="Configuration"/> instance
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static Configuration Instance => instance;

        /// <summary>
        /// Static constructor
        /// </summary>
        /// <remarks>Explicit static constructor to tell C# compiler not to mark type as beforefieldinit </remarks>
        static Configuration() { }

        /// <summary>
        /// Private constructor used to build the singleton instance
        /// </summary>
        private Configuration() { }
        #endregion

        #region Configuration items
        /// <summary>
        /// Configuration items stored as key-value pairs
        /// </summary>
        private ConcurrentDictionary<string, object> Items { get; } = new ConcurrentDictionary<string, object>();

        /// <summary>
        /// Gets the configuration item by <paramref name="key"/>
        /// </summary>
        /// <param name="key">Key of the configuration item</param>
        /// <returns>Retrieved configuration item value or null if not found (or the configuration item is null itself)</returns>
        public static object Get(string key)
        {
            return Instance.Items.TryGetValue(key, out var value) ? value : null;
        }

        /// <summary>
        /// Gets the typed configuration item by <paramref name="key"/>.
        /// Returns the default value, that can be provided or is default to given <typeparamref name="TValueType"/>
        /// The function tries to convert the value to <typeparamref name="TValueType"/> using <see cref="Convert.ChangeType(object,Type)"/>
        /// if the conversion is not successful, the default is returned.
        /// </summary>
        /// <typeparam name="TValueType">The type the value is to be retrieved in</typeparam>
        /// <param name="key">Key of the configuration item</param>
        /// <param name="defaultValue">Optional default value to be returned when the value can't be retrieved of converted</param>
        /// <returns>Retrieved configuration item value or <paramref name="defaultValue"/> when it can't be retrieved or converted</returns>
        public static TValueType Get<TValueType>(string key, TValueType defaultValue = default)
        {
            var value = Get(key);
            switch (value)
            {
                case null:
                    return defaultValue;
                case TValueType nativeValue:
                    return nativeValue; //no conversion needed
                default:
                    try
                    {
                        var convertedValue = (TValueType)Convert.ChangeType(value, typeof(TValueType));
                        return convertedValue;
                    }
                    catch (InvalidCastException)
                    {
                        return defaultValue;
                    }
            }
        }
        #endregion

        #region Binding
        /// <summary>
        /// Cache for bindings. Dictionary of type bound as a key and the bound object as value.
        ///</summary>
        /// <remarks>Cache is used to prevent the "expensive" binding operation in case there is no need to refresh the bound configuration object</remarks>
        private readonly ConcurrentDictionary<Type, object> bindingsCache = new ConcurrentDictionary<Type, object>();

        /// <summary>
        /// Binds the configuration to given <typeparamref name="TOptionsContainer"/> type and returns the bound object of such type.
        /// The resulting configuration object is stored to the cache and can be later on retrieved using <see cref="Retrieve{TOptionsContainer}"/>
        /// </summary>
        /// <typeparam name="TOptionsContainer">Type to bind the configuration to</typeparam>
        /// <param name="sectionName">Optional section to bind</param>
        /// <param name="allowCached">True if the cache of bindings can be used to retrieve existing binding with the same <typeparamref name="TOptionsContainer"/> and <paramref name="sectionName"/></param>
        /// <returns>The instance of <typeparamref name="TOptionsContainer"/> bound to the configuration</returns>
        public static TOptionsContainer Bind<TOptionsContainer>(string sectionName = null, bool allowCached = true) where TOptionsContainer : new()
        {
            if (allowCached)
            {
                if (Instance.bindingsCache.TryGetValue(typeof(TOptionsContainer), out var cacheItem))
                {
                    return (TOptionsContainer)cacheItem;
                }
            }

            var binding = (TOptionsContainer)Bind(typeof(TOptionsContainer), sectionName);
            Instance.bindingsCache.AddOrUpdate(typeof(TOptionsContainer), binding, (k, v) => binding);
            return binding;
        }

        /// <summary>
        /// Retrieves the configuration object of given <typeparamref name="TOptionsContainer"/> that has been bound and cached before.
        /// The new instance of <typeparamref name="TOptionsContainer"/> is created when the type not found in cache
        /// </summary>
        /// <typeparam name="TOptionsContainer">Type of the configuration class to retrieve from cache</typeparam>
        /// <returns>The instance of <typeparamref name="TOptionsContainer"/> bound to the configuration or a new instance if not found</returns>
        public static TOptionsContainer Retrieve<TOptionsContainer>() where TOptionsContainer : new()
        {
            if (Instance.bindingsCache.TryGetValue(typeof(TOptionsContainer), out var cacheItem))
            {
                return (TOptionsContainer)cacheItem;
            }
            return Activator.CreateInstance<TOptionsContainer>();
        }

        /// <summary>
        /// Creates a  new object with given <paramref name="type"/> and binds the configuration
        /// to its public properties where possible.
        /// </summary>
        /// <remarks>This method doesn't use the binding cache</remarks>
        /// <param name="type">Type to bind the configuration to</param>
        /// <param name="sectionName">Optional section to bind</param>
        /// <returns>The instance of  <paramref name="type"/> bound to the configuration</returns>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is null</exception>
        private static object Bind(Type type, string sectionName = null)
        {
            if(type==null) throw new ArgumentNullException(nameof(type));

            var options = Activator.CreateInstance(type);
            var items = GetSection(sectionName);
            if (items.Count == 0) return options;

            //get public properties with public setter
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(x => x.GetSetMethod() != null);

            foreach (var prop in props)
                //Value properties
                if (prop.PropertyType.IsValueType || prop.PropertyType == typeof(string))
                {
                    if (!items.TryGetValue(prop.Name, out var item) ||
                        !TryConvertValue(prop.PropertyType, item, out var targetValue)) continue;
                    prop.SetValue(options, targetValue);
                }
                else if (prop.PropertyType.IsArray)
                {
                    //Arrays
                    var elementType = prop.PropertyType.GetElementType();
                    if (elementType == null) continue;

                    var idx = 0;
                    var arrayItems = new List<object>();
                    if (elementType.IsValueType || elementType == typeof(string))
                    {
                        //Array of values
                        while (items.TryGetValue($"{prop.Name}[{idx}]", out var arrayItemValue))
                        {
                            if (TryConvertValue(elementType, arrayItemValue, out var targetValue))
                                arrayItems.Add(targetValue);
                            idx++;
                        }
                    }
                    else
                    {
                        //Array of object
                        while (items.Keys.FirstOrDefault(k => k.StartsWith($"{prop.Name}[{idx}].")) != null)
                        {
                            var arrayItemValue = Bind(elementType, (string.IsNullOrEmpty(sectionName) ? "" : sectionName + ".") + $"{prop.Name}[{idx}]");
                            arrayItems.Add(arrayItemValue);
                            idx++;
                        }
                    }

                    var propItems = Activator.CreateInstance(prop.PropertyType, arrayItems.Count);
                    if (propItems is Array propItemsArray) Array.Copy(arrayItems.ToArray(), propItemsArray, arrayItems.Count);
                    prop.SetValue(options, propItems);
                }
                else
                {
                    //Nested object
                    prop.SetValue(
                        options,
                        Bind(prop.PropertyType, (string.IsNullOrEmpty(sectionName) ? "" : sectionName + ".") + prop.Name));
                }

            return options;
        }

        /// <summary>
        /// Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section!
        /// When the section is not provided, the whole configuration tree is returned.
        /// </summary>
        /// <param name="sectionName">Optional name of the section.</param>
        /// <returns>The configuration items that belong to the section with <paramref name="sectionName"/>.
        /// The keys in returned dictionary are relative to given section! </returns>
        private static Dictionary<string, object> GetSection(string sectionName = null)
        {
            sectionName = sectionName == null ? string.Empty : sectionName + ".";
            var sectionItems = Instance.Items.Where(kv => kv.Key.StartsWith(sectionName));
            return sectionItems.ToDictionary(sectionItem => sectionItem.Key.Substring(sectionName.Length), sectionItem => sectionItem.Value);
        }

        /// <summary>
        /// Tries to convert <paramref name="sourceValue"/> to <paramref name="targetType"/>.
        /// The converted values is returned in <paramref name="targetValue"/> out parameter,
        /// the result of conversion is the function return value.
        /// </summary>
        /// <remarks>
        /// The implementation treats the <see cref="bool"/> values the special way -
        /// if there is no value, but existing key, the value is converted to true. 
        /// </remarks>
        /// <param name="targetType">Target (property) type</param>
        /// <param name="sourceValue">Source value as stored in configuration item</param>
        /// <param name="targetValue"><paramref name="sourceValue"/> converted to <paramref name="targetType"/>
        /// when the conversion succeeded (return value is true) or source value otherwise</param> 
        /// <returns>The result or conversion. If true, the <paramref name="targetValue"/> can be set to property having <paramref name="targetType"/></returns>
        private static bool TryConvertValue(Type targetType, object sourceValue, out object targetValue)
        {
            if (sourceValue == null)
            {
                if (targetType == typeof(bool))
                {
                    targetValue = true; //existing key with no value=true for bool
                    return true;
                }
                targetValue = targetType.IsValueType ? Activator.CreateInstance(targetType) : null;
                return true;
            }

            if (targetType != sourceValue.GetType())
            {
                try
                {
                    targetValue = Convert.ChangeType(sourceValue, targetType);
                    return true;
                }
                catch (InvalidCastException)
                {
                    targetValue = sourceValue;
                    return false;
                }
            }

            targetValue = sourceValue;
            return true;
        }
        #endregion

        #region Builder
        /// <summary>
        /// Add a new configuration item with given <paramref name="value"/>
        /// or updates its value if the <paramref name="key"/> already exists.
        /// </summary>
        /// <param name="key">Configuration item key</param>
        /// <param name="value">The value to be set for the configuration item</param>
        /// <exception cref="ArgumentException"><paramref name="key"/> is null or empty</exception>
        private void AddOrUpdateItem(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException(nameof(key));

            Items.AddOrUpdate(key, value, (k, v) => value);
        }

        /// <summary>
        /// Clears the configuration items and binding cache and creates a new instance of <see cref="ConfigurationBuilder"/>
        /// </summary>
        /// <returns>The instance of <see cref="ConfigurationBuilder"/></returns>
        public static ConfigurationBuilder Builder()
        {
            Instance.Items.Clear();
            Instance.bindingsCache.Clear();
            return new ConfigurationBuilder();
        }

        /// <summary>
        /// Configuration builder providing the methods for adding the
        /// configuration items from individual sources
        /// </summary>
        public class ConfigurationBuilder
        {
            /// <summary>
            ///  Finishes the configuration building and returns the <see cref="Configuration.Instance"/>
            /// </summary>
            /// <returns>The <see cref="Configuration"/> singleton</returns>
            public Configuration Build()
            {
                return Instance;
            }

            /// <summary>
            /// Add a new configuration item with given <paramref name="value"/>
            /// or updates its value if the <paramref name="key"/> already exists.
            /// </summary>
            /// <param name="key">Configuration item key</param>
            /// <param name="value">The value to be set for the configuration item</param>
            /// <exception cref="ArgumentException"><paramref name="key"/> is null or empty</exception>
            /// <returns>The current <see cref="ConfigurationBuilder"/></returns>
            public ConfigurationBuilder Add(string key, object value)
            {
                if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException(nameof(key));
                Instance.AddOrUpdateItem(key, value);
                return this;
            }

            /// <summary>
            /// Adds all environment variables into the <see cref="Configuration"/>.
            /// When a configuration item exists, the value is updated.
            /// </summary>
            /// <remarks>
            /// The name of the environment variable is used as a key to the configuration item.
            /// Use the "dot notation" in variable names to support the configuration hierarchy.
            /// </remarks>
            /// <returns>The current <see cref="ConfigurationBuilder"/></returns>
            public ConfigurationBuilder AddEnvironmentVariables()
            {
                foreach (DictionaryEntry entry in Environment.GetEnvironmentVariables())
                {
                    Instance.AddOrUpdateItem(entry.Key.ToString(), entry.Value);
                }
                return this;
            }

            /// <summary>
            /// Adds the command line arguments starting with <paramref name="prefixes"/> into the <see cref="Configuration"/>.
            /// When a configuration item exists, the value is updated.
            /// </summary>
            /// <remarks>
            ///The command line arguments have the syntax <c>key=value</c> (for example <c>Key1=Option1</c>or
            /// <c>prefixkey=value</c> (for example <c>-p:Key1=Option1</c> where <c>-p:</c> is the prefix).
            /// When the prefixes are not provided, all command line arguments are added to the configuration.
            /// When the prefixes are provided,the prefix is not a part of the key.
            /// <para>
            /// The implementation  of binding treats the <see cref="bool"/> values the special way - if there is no value, but existing key,
            /// the value is converted to true, allowing to use the parameters like flags. For example having the argument <c>-p:SkipStep1</c>
            /// and prefix <c>-p:</c>, the binding a bool property <c>SkipStep1</c> will set the value of the property to <c>true</c>
            /// (doesn't change the configuration item itself). Of course, it's still possible to use the syntax <c>-p:SkipStep1=true</c> or
            /// <c>-p:SkipStep1=false</c> even in this case.
            /// </para>
            /// </remarks>
            /// <param name="prefixes">Optional list of prefixes marking the command line arguments to be the configuration items</param>
            /// <returns>The current <see cref="ConfigurationBuilder"/></returns>
            public ConfigurationBuilder AddCommandLineArguments(params string[] prefixes)
            {
                foreach (var argRaw in Environment.GetCommandLineArgs())
                {
                    if (prefixes != null && !prefixes.Any(p => argRaw.StartsWith(p))) continue;

                    var arg = argRaw;
                    if (prefixes != null)
                    {
                        arg = argRaw.Substring(prefixes.First(p => arg.StartsWith(p)).Length);
                    }

                    var argSplit = arg.Split(new[] { '=' }, 2);
                    var argKey = argSplit[0];
                    var argValue = argSplit.Length > 1 ? argSplit[1] : null;
                    Instance.AddOrUpdateItem(argKey, argValue);
                }
                return this;
            }

            /// <summary>
            /// Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays)
            /// When a configuration item exists, the value is updated.
            /// </summary>
            /// <param name="fileName">Name of the JSON file with configuration</param>
            /// <param name="ignoreNullOrEmptyFileName">If true, the missing file name will not throw the exception and the method just "silently" ends.</param>
            /// <param name="ignoreIfNotExist">If true, the non existing file will not throw the exception and the method just "silently" ends.</param>
            /// <exception cref="ArgumentException"><paramref name="fileName"/> is null or empty and <paramref name="ignoreNullOrEmptyFileName"/> is false</exception>       
            /// <exception cref="ArgumentException"><paramref name="fileName"/> doesn't exist and <paramref name="ignoreIfNotExist"/> is false</exception>       
            /// <returns>The current <see cref="ConfigurationBuilder"/></returns>
            public ConfigurationBuilder AddJsonFile(string fileName, bool ignoreNullOrEmptyFileName = false, bool ignoreIfNotExist = false)
            {
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    if (!ignoreNullOrEmptyFileName) throw new ArgumentException(nameof(fileName));
                    return this;
                }

                if (!File.Exists(fileName))
                {
                    if (!ignoreIfNotExist) throw new ArgumentException($"File {fileName} doesn't exist");
                    return this;
                }

                var content = File.ReadAllText(fileName);
                var root = JToken.Parse(content);

                WalkNode(root, n => Instance.AddOrUpdateItem(n.Path, n.Value));
                return this;

                void WalkNode(JToken node, Action<JValue> action)
                {
                    if (node is JValue value) action(value);

                    foreach (var child in node.Children())
                    {
                        WalkNode(child, action);
                    }
                }
            }
        }

        #endregion
    }

}
