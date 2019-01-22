using System;

namespace net.adamec.lib.common.logging
{
    /// <summary>
    /// Logger interface - wrapper around the <see cref="NLog.ILogger"/> with some additional methods
    /// </summary>
    /// <remarks>
    /// <para>
    /// The NLog supports having additional (custom) event properties provided to loggers and optionally rendered to logs.
    /// The event properties are represented as key-value dictionary, where key is the unique name of the property.
    /// <para>Extended logger provides following methods to log with given set of the properties.</para>
    /// <list type="bullet">
    /// <item><description><see cref="Trace"/>,</description></item>
    /// <item><description><see cref="Debug"/>,</description></item>
    /// <item><description><see cref="Info"/>,</description></item>
    /// <item><description><see cref="Warn(System.Collections.Generic.Dictionary{string,object},string)"/>,</description></item>
    /// <item><description><see cref="Error(System.Collections.Generic.Dictionary{string,object},string)"/>,</description></item>
    /// <item><description><see cref="Fatal(System.Collections.Generic.Dictionary{string,object},string)"/>,</description></item>
    /// <item><description><see cref="Warn(System.Collections.Generic.Dictionary{string,object},System.Exception,string)"/>,</description></item>
    /// <item><description><see cref="Error(System.Collections.Generic.Dictionary{string,object},System.Exception,string)"/> and</description></item>
    /// <item><description><see cref="Fatal(System.Collections.Generic.Dictionary{string,object},System.Exception,string)"/></description></item>
    /// </list>
    ///  </para>
    /// <para></para>
    /// <para>
    /// Sometimes, it's useful to have an exception logging method implemented as the operation returning the exception being logged.
    /// The <see cref="ErrorPassThrough"/> and <see cref="FatalPassThrough"/> methods will log given exception and return it for further processing.
    ///  <code>
    /// try
    /// {
    ///   ...
    /// }
    /// catch (Exception ex){
    ///    if(logger.ErrorPassThrough(ex) is MyException){
    ///      return null;
    ///    }else{
    ///      throw;
    ///    } 
    /// }
    /// </code>
    /// In the example above, the exception is always logged and then the decision/action is taken.
    /// </para>
    /// <para>
    /// C# 6 brought the exception filters that don't unwind the stack as the exception is not catch yet when processing the filter.
    /// It can also be used for logging the exceptions without actually catching them (when the exception filter returns <c>false</c>).
    /// Extended logger provides functions <see cref="ErrorFltr{TException}"/> and <see cref="FatalFltr{TException}"/> for this purpose.
    /// <code>
    /// try
    /// {
    ///   ...
    /// }
    /// catch (Exception ex) when (logger.ErrorFltr(ex,"Error here!"){
    ///   //newer called as the default return value of ErrorFltr is false     
    /// }
    /// </code>
    /// The example above logs but never catch all exceptions.
    /// The following code catch and log the ArgumentException and logs any other exception without catching it.
    /// <code>
    /// try
    /// {
    ///   ...
    /// }
    /// catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) { ... }
    /// catch (Exception e) when (Logger.FatalFltr(e)) {}
    /// </code> 
    /// </para>
    /// <para></para>
    /// <para>
    /// Logger can also create and exception, log it and return using functions <see cref="Error{TException}"/> and <see cref="Fatal{TException}"/>
    /// <code>
    /// if(value is null) throw logger.Fatal&lt;ArgumentNullException&gt;("Value is null");
    /// </code>
    /// </para>
    /// <para></para>
    /// <para>
    /// When logging an exception using the <see cref="LoggerExt"/> methods, the event property <c>StackTrace</c> is set from <see cref="Exception.StackTrace"/>,
    /// when the logger creates an exception, the property is set using <c>new StackTrace(2, true).ToString()</c>.
    /// In other cases when the <see cref="Exception.StackTrace"/> is null or empty, <c>new StackTrace(true).ToString()</c> is used.
    /// </para>
    /// <para></para>
    /// <para>
    /// <see cref="LoggerExt"/> also provides set of methods for logging with the correlation ID (for example in integration scenarios),
    /// where the given correlation ID is set to the event property <c>CorrelationId</c>.
    /// Such methods have the name ending with <c>Corr</c> suffix.
    /// </para>
    /// </remarks>
    internal partial interface ILogger : NLog.ILogger
    {
    }
}