using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Extension methods to utilize on enums. </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.EnumExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static EnumExtensions() { }

        /// <summary>
        /// Converts an enumeration value of the specified type (with a
        /// Description attribute) to a string value.
        /// </summary>
        /// <typeparam name="T"> Type of the enumeration. </typeparam>
        /// <param name="enumerationValue"> Value of the enumeration. </param>
        /// <returns> String containing the enumeration value expressed as a string. </returns>
        public static string AsString<T>(this T enumerationValue) where T : Enum
        {
            var result = enumerationValue.ToString();

            try
            {
                var type = enumerationValue.GetType();
                if (!type.IsEnum) return result;

                var memberInfo = type.GetMember(enumerationValue.ToString());
                if (memberInfo == null) return result;
                if (memberInfo.Length <= 0) return result;

                //Tries to find a DescriptionAttribute for a potential friendly name
                //for the enum
                var attrs = memberInfo[0]
                    .GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs == null || attrs.Length == 0) return result;

                //Pull out the description value
                result = ((DescriptionAttribute)attrs[0]).Description;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = enumerationValue.ToString();
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="enumerationValue" /> is not
        /// within the value set of its defining <see langword="enum" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Name of the <see langword="enum" /> from which
        /// the specified <paramref name="enumerationValue" /> comes.
        /// </typeparam>
        /// <param name="enumerationValue">(Required.) Enumeration value to be checked.</param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="enumerationValue" /> is not within the value set of its
        /// defining <see langword="enum" />; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsUndefined<T>(this T enumerationValue)
            where T : Enum
        {
            var result = false;

            try
            {
                result = !Enum.IsDefined(typeof(T), enumerationValue);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }
    }
}