using System;

namespace net.adamec.lib.common.di.postinit
{
    /// <summary>
    /// Allows to run post init method of component.
    /// Component must be registered using the Component attribute as singleton in root scope and must register self
    /// Parameters of "marked" post init method are resolved from container (throws an exception on failure)
    /// </summary>
    // ReSharper disable once RedundantAttributeUsageProperty
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class PostInitAttribute : Attribute
    {
    }

}
