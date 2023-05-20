using System;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Helper functions for doing math.
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Determines if a decimal value is between a pair of values or equal
        /// to either of them.
        /// </summary>
        /// <param name="value">
        /// The value to be checked.
        /// </param>
        /// <param name="lowerBound">
        /// Lower bound.
        /// </param>
        /// <param name="upperBound">
        /// Upper bound.
        /// </param>
        /// <returns>
        /// True if the value is either within the range specified or equal to
        /// either of the bounds; false otherwise.
        /// </returns>
        public static bool IsIncludedInRange(this decimal value,
            decimal lowerBound, decimal upperBound)
            => upperBound >= value && value >= lowerBound;

        /// <summary>
        /// Determines if a <paramref name="value"/> is negative.
        /// </summary>
        /// <param name="value">
        /// Value to be compared. Must be of decimal type.
        /// </param>
        /// <returns>
        /// True if the <paramref name="value"/> is strictly less than zero;
        /// false otherwise.
        /// </returns>
        public static bool IsNegative(this decimal value)
            => value < decimal.Zero;

        /// <summary>
        /// Determines whether a <paramref name="value"/> is positive.
        /// </summary>
        /// <param name="value">
        /// Value to be compared. Must be of decimal type.
        /// </param>
        /// <returns>
        /// True if the <paramref name="value"/> is strictly greater than zero;
        /// false otherwise.
        /// </returns>
        public static bool IsPositive(this decimal value)
            => value > decimal.Zero;

        /// <summary>
        /// Determines whether a number is strictly between (as in, can't be
        /// equal to either)
        /// </summary>
        /// <param name="value">
        /// The value to be checked.
        /// </param>
        /// <param name="lowerBound">
        /// Lower bound.
        /// </param>
        /// <param name="upperBound">
        /// Upper bound.
        /// </param>
        /// <returns>
        /// True if <paramref name="value"/> is strictly greater than <paramref
        /// name="lowerBound"/> and strictly less than <paramref
        /// name="upperBound"/> ; false otherwise.
        /// </returns>
        public static bool IsStrictlyInRange(this decimal value,
            decimal lowerBound,
            decimal upperBound)
            => upperBound > value && value > lowerBound;

        /// <summary>
        /// Determines whether a <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">
        /// Value to be compared.
        /// </param>
        /// <returns>
        /// True if the <paramref name="value"/> is zero; false otherwise.
        /// </returns>
        public static bool IsZero(this decimal value)
            => value == decimal.Zero;

        /// <summary>
        /// Takes a value of type decimal and truncates it to the specified
        /// number of places.
        /// </summary>
        /// <param name="val">
        /// Value to be truncated.
        /// </param>
        /// <param name="places">
        /// Number of digits following the decimal point.
        /// </param>
        /// <returns>
        /// New decimal value with all the digits removed except places digits
        /// following the decimal point.
        /// </returns>
        public static decimal TruncateDecimalPlaces(this decimal val,
            int places)
        {
            if (places < 0) throw new ArgumentException("places");

            return Math.Round(
                val - Convert.ToDecimal(0.5 / Math.Pow(10, places)), places);
        }
    }
}