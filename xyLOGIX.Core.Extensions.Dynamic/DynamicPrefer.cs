using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions.Dynamic
{
    /// <summary>
    /// Contains methods that allow you to prefer one type over another when working
    /// with <see langword="dynamic" /> objects.
    /// </summary>
    public static class DynamicPrefer
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.Dynamic.DynamicPrefer" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static DynamicPrefer() { }

        /// <summary>
        /// Preferentially returns the specified <paramref name="preferredValue" /> over
        /// the <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </summary>
        /// <param name="nullableValue">
        /// (Required.) A <see cref="T:System.Object" /> variable whose value is to be
        /// returned if it indeed does have a non-<see langword="null" />, non-blank value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) A <see cref="T:System.Object" />
        /// containing the preferred value that is to be returned if the
        /// <paramref name="nullableValue" /> is <see langword="null" /> or does not have a
        /// value.
        /// </param>
        /// <returns>
        /// The specified <paramref name="preferredValue" /> over the
        /// <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static dynamic DynamicOverNull(
            [NotLogged] dynamic nullableValue,
            [NotLogged] dynamic preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null && preferredValue == null)
                    return result;
                if (nullableValue == null && preferredValue != null)
                    return result;
                if (nullableValue != null && preferredValue == null)
                    return nullableValue;

                result = preferredValue;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = preferredValue;
            }

            return result;
        }
    }
}