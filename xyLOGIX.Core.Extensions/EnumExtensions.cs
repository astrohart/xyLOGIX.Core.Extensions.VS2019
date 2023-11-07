using System;
using System.ComponentModel;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Extension methods to utilize on enums. </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Converts an enumeration value of the specified type (with a
        /// Description attribute) to a string value.
        /// </summary>
        /// <typeparam name="T"> Type of the enumeration. </typeparam>
        /// <param name="enumerationValue"> Value of the enumeration. </param>
        /// <returns> String containing the enumeration value expressed as a string. </returns>
        public static string AsString<T>(this T enumerationValue)
            where T : struct
        {
            var type = enumerationValue.GetType();
            if (!type.IsEnum)
                throw new ArgumentException(
                    "EnumerationValue must be of Enum type",
                    nameof(enumerationValue)
                );

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            var memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo == null || memberInfo.Length <= 0)
                return enumerationValue.ToString();

            var attrs = memberInfo[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attrs != null && attrs.Length > 0)

                //Pull out the description value
                return ((DescriptionAttribute)attrs[0]).Description;

            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }
    }
}