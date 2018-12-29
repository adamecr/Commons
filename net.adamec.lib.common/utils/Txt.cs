using System;
using System.Collections.Generic;
using System.Text;

namespace net.adamec.lib.common.utils
{
    /// <summary>
    /// Text builder
    /// </summary>
    /// <NuProp.Id>RadCommons.utils.Txt</NuProp.Id>
    /// <NuProp.Description>Text builder allowing to build strings from parts, supporting conditions, enumerations, etc.(Source only package).</NuProp.Description>
    /// <NuProp.Tags>RadCommons source-only text-builder string-builder</NuProp.Tags>
    public class Txt
    {
        /// <summary>
        /// Internal <see cref="StringBuilder"/>
        /// </summary>
        private readonly StringBuilder builder = new StringBuilder();

        /// <summary>
        /// Creates a new empty text builder
        /// </summary>
        public Txt() { }

        /// <summary>
        /// Creates a new text builder with initial <paramref name="text"/>
        /// </summary>
        /// <param name="text"></param>
        public Txt(string text)
        {
            Add(text);
        }

        /// <summary>
        /// Adds the <paramref name="text"/> to the text builder
        /// </summary>
        /// <param name="text">Text to add</param>
        /// <returns>Itself</returns>
        public Txt Add(string text)
        {
            if (text != null)
                builder.Append(text);
            return this;
        }

        /// <summary>
        /// Adds the text returned from <paramref name="textFunc"/> to the text builder
        /// </summary>
        /// <param name="textFunc">Function generating the text to add</param>
        /// <returns>Itself</returns>
        public Txt Add(Func<string> textFunc)
        {
            if (textFunc != null)
                Add(textFunc.Invoke());
            return this;
        }

        /// <summary>
        /// Adds the <paramref name="text"/> to the text builder when the <paramref name="condition"/> is true.
        /// </summary>
        /// <remarks>
        /// If using some code/variable to generate the <paramref name="text"/> (for example <c>AddIf(obj.Container.Text, obj.Container != null)</c>,
        /// the parameter will be evaluated even if the condition is not true !
        /// So the example here will throw NPE when the <c>obj.Container</c> is null.
        /// Use <see cref="AddIf(Func{string},bool)"/> (<c>AddIf(()=>obj.Container.Text, obj.Container != null)</c>)
        /// when the function should not be evaluated.
        /// Of course <c>AddIf(obj?.Container?.Text, obj?.Container != null)</c> null checks are also valid solution.
        /// </remarks>
        /// <param name="text">Text to add</param>
        ///<param name="condition">Condition that must be true to add the <paramref name="text"/></param>
        /// <returns>Itself</returns>
        public Txt AddIf(string text, bool condition)
        {
            if (condition)
                Add(text);
            return this;
        }

        /// <summary>
        /// Adds the text returned from <paramref name="textFunc"/> to the text builder when the <paramref name="condition"/> is true.
        /// </summary>
        /// <param name="textFunc">Function generating the text to add</param>
        ///<param name="condition">Condition that must be true to add the <paramref name="textFunc"/></param>
        /// <returns>Itself</returns>
        public Txt AddIf(Func<string> textFunc, bool condition)
        {
            if (condition && textFunc != null)
                Add(textFunc.Invoke());
            return this;
        }

        ///  <summary>
        ///  Adds the returned from <paramref name="textFunc"/> for each items from <paramref name="items"/> to the text builder.
        ///  </summary>
        ///  <param name="textFunc">Function generating the text to add</param>
        /// <param name="items">Items to generate the output for via <paramref name="textFunc"/> </param>
        /// <param name="separator">Optional separator</param>
        /// <returns>Itself</returns>
        public Txt AddEach<TItemType>(Func<TItemType, string> textFunc, IEnumerable<TItemType> items, string separator = null)
        {
            if (items == null || textFunc == null) return this;

            var isNotFirst = false;
            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(separator) && isNotFirst)
                {
                    Add(separator);
                }
                Add(textFunc.Invoke(item));
                isNotFirst = true;
            }

            return this;
        }

        ///  <summary>
        ///  Adds the returned from <paramref name="textFunc"/> for each items from <paramref name="items"/> to the text builder when the <paramref name="condition"/> is true.
        ///  </summary>
        ///  <remarks>
        ///  The <paramref name="condition"/> is evaluated once at the beginning of method execution, not for each item.
        ///  </remarks>
        ///  <param name="textFunc">Function generating the text to add</param>
        /// <param name="items">Items to generate the output for via <paramref name="textFunc"/> </param>
        /// <param name="condition">Condition that must be true to add the <paramref name="textFunc"/></param>
        /// <param name="separator">Optional separator</param>
        /// <returns>Itself</returns>
        public Txt AddEachIf<TItemType>(Func<TItemType, string> textFunc, IEnumerable<TItemType> items, bool condition, string separator = null)
        {
            if (condition && items != null && textFunc != null)
            {
                AddEach(textFunc, items, separator);
            }

            return this;
        }

        /// <summary>
        /// Clear the text builder
        /// </summary>
        /// <returns>Itself</returns>
        public Txt Clear()
        {
            builder.Clear();
            return this;
        }

        /// <summary>
        /// Creates a new instance ot <see cref="Txt"/> text builder with optional initial <paramref name="text"/>
        /// </summary>
        /// <param name="text">Optional initial text</param>
        /// <returns>A new instance of <see cref="Txt"/> text builder </returns>
        public static Txt Start(string text = null)
        {
            return new Txt().Add(text);
        }

        /// <summary>
        /// Returns the text content of the text builder
        /// </summary>
        /// <returns>The text content of the text builder</returns>
        public override string ToString()
        {
            return builder.ToString();
        }

        /// <summary>
        /// Creates a new instance ot <see cref="Txt"/> text builder with optional initial <paramref name="text"/>
        /// </summary>
        /// <param name="text">Optional initial text</param>
        /// <returns>A new instance of <see cref="Txt"/> text builder </returns>
        public static implicit operator Txt(string text)
        {
            return new Txt(text);
        }

        /// <summary>
        /// Converts the text builder to string containing its content
        /// </summary>
        /// <param name="txt">Text builder</param>
        public static implicit operator string(Txt txt)
        {
            return txt?.ToString();
        }

        /// <summary>
        /// Concatenates the contents of two text builders
        /// </summary>
        /// <param name="txt1"></param>
        /// <param name="txt2"></param>
        /// <returns>
        /// The first text builder (<paramref name="txt1"/>) with added text when <paramref name="txt1"/> is not null.
        /// The second text builder (<paramref name="txt2"/>) when <paramref name="txt1"/> is null.
        /// New empty text builder instance when both operands are null
        /// </returns>
        public static Txt operator +(Txt txt1, Txt txt2)
        {
            if (txt1 != null) return txt1.Add(txt2);
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (txt2 != null) return txt2; //nothing to add, txt1 is null
            return new Txt(); //nothing to add, both are null, so just create a new instance
        }

        /// <summary>
        /// Concatenates the contents of two text builders
        /// </summary>
        /// <param name="txt1"></param>
        /// <param name="txt2"></param>
        /// <returns>
        /// The first text builder (<paramref name="txt1"/>) with added text when <paramref name="txt1"/> is not null.
        /// The second text builder (<paramref name="txt2"/>) when <paramref name="txt1"/> is null.
        /// New empty text builder instance when both operands are null
        /// </returns>
        public static Txt operator |(Txt txt1, Txt txt2)
        {
            return txt1 + txt2;
        }
    }

}
