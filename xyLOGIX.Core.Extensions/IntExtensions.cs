using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Provides methods that extend the <see cref="T:System.Int32" /> class. </summary>
    [Log(AttributeExclude = true)]
    public static class IntExtensions
    {
        /// <summary>
        /// Converts an <see cref="T:System.Int32" /> value to its ordinal string representation,
        /// appending the appropriate suffix (e.g., "st", "nd", "rd", "th") based on the value.
        /// </summary>
        /// <param name="value">
        /// (Required.) An <see cref="T:System.Int32" /> value that represents the number to format.
        /// Must be 1 or greater.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the ordinal representation
        /// of the provided <paramref name="value" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown when the provided <paramref name="value" /> is less than 1.
        /// </exception>
        public static string ToOrdinalString(this int value)
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be 1 or greater.");

            // Determine the suffix
            int lastDigit = value % 10;
            int lastTwoDigits = value % 100;

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
        public static bool EqualsOneOf(this int value, params int[] list)
            => list != null && list.Length != 0 && list.Any(t => value == t);
    }
}