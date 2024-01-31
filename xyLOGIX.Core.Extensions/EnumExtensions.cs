using xyLOGIX.Core.Debug;
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
    }
}