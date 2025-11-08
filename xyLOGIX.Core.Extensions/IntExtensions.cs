using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Provides methods that extend the <see cref="T:System.Int32" /> class. </summary>
    [Log(AttributeExclude = true)]
    public static class IntExtensions
    {
        /// <summary>
        /// Returns a value indicating whether the specified
        /// <paramref name="value" /> is equal to one of the items in a collection of
        /// integers.
        /// </summary>
        /// <param name="value"> Integer to be compared to the members of the list. </param>
        /// <param name="list">
        /// Collection of integers that should be searched for the
        /// <paramref name="value" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is one of the
        /// elements of the collection; <see langword="false" /> if not.
        /// </returns>
        public static bool EqualsOneOf(
            [NotLogged] this int value,
            [NotLogged] params int[] list
        )
        {
            var result = false;

            try
            {
                if (list == null) return result;
                if (list.Length <= 0) return result;

                foreach (var x in list)
                {
                    if (value != x) continue;

                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary> Determines whether a bitmask is 'on' or 'off'. </summary>
        /// <param name="num">(Required.) Value containing the data to be checked.</param>
        /// <param name="bitmask">(Required.) Bitmask.</param>
        /// <returns>
        /// <see langword="true" /> if the bit that is identified by the bitmask
        /// in the data is 'on'; <see langword="false" /> if it is not.
        /// </returns>
        public static bool IsBitmaskOn(this int num, int bitmask)
            => (num & bitmask) != 0;

        /// <summary>
        /// Converts an <see cref="T:System.Int32" /> <paramref name="value" /> to
        /// its ordinal string representation, appending the appropriate suffix (e.g.,
        /// <c>"st"</c>, <c>"nd"</c>, <c>"rd"</c>, <c>"th"</c>, etc.) based on the
        /// specified <paramref name="value" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) An <see cref="T:System.Int32" /> value that
        /// represents the number to format.
        /// <para />
        /// <b>NOTE:</b> The argument of this parameter must be <c>1</c> or greater.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the ordinal
        /// representation of the provided <paramref name="value" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown when the provided
        /// <paramref name="value" /> is less than 1.
        /// </exception>
        public static string ToOrdinalString(this int value)
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(
                    nameof(value), "Value must be 1 or greater."
                );

            // Determine the suffix
            var lastDigit = value % 10;
            var lastTwoDigits = value % 100;

            string suffix;
            if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
            {
                suffix = "th";
            }
            else
            {
                switch (lastDigit)
                {
                    case 1:
                        suffix = "st";
                        break;

                    case 2:
                        suffix = "nd";
                        break;

                    case 3:
                        suffix = "rd";
                        break;

                    default:
                        suffix = "th";
                        break;
                }
            }

            // Return the formatted value
            return $"{value}{suffix}";
        }
    }
}