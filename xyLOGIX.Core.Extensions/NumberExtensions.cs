using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Helper functions for doing operations on, or making decisions about,
    /// numerical data.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class NumberExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.NumberExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static NumberExtensions() { }

        /// <summary>
        /// Converts the specified <see langword="double" /> value to
        /// <see langword="decimal" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see langword="double" /> value to be
        /// converted to <see langword="decimal" />.
        /// </param>
        /// <remarks>
        /// This method returns zero if the conversion was not successful, or if
        /// zero is passed for <paramref name="value" />.
        /// </remarks>
        /// <returns>
        /// The specified <paramref name="value" />, converted to type
        /// <see langword="decimal" />.
        /// </returns>
        public static decimal AsDecimal(this double value)
        {
            var result = decimal.Zero;

            try
            {
                if (0D == value) return result;

                result = Convert.ToDecimal(value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Converts the specified <see langword="double" /> value to
        /// <see langword="decimal" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see langword="double" /> value to be
        /// converted to <see langword="decimal" />.
        /// </param>
        /// <remarks>
        /// This method returns zero if the conversion was not successful, or if
        /// zero is passed for <paramref name="value" />.
        /// </remarks>
        /// <returns>
        /// The specified <paramref name="value" />, converted to type
        /// <see langword="decimal" />.
        /// </returns>
        public static decimal AsDecimal(this double? value)
        {
            var result = decimal.Zero;

            try
            {
                if (value == null) return result;
                if (!value.HasValue) return result;

                result = Convert.ToDecimal(value.Value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Converts the specified <see langword="long" /> value to
        /// <see langword="decimal" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see langword="long" /> value to be
        /// converted to <see langword="decimal" />.
        /// </param>
        /// <remarks>
        /// This method returns zero if the conversion was not successful, or if
        /// zero is passed for <paramref name="value" />.
        /// </remarks>
        /// <returns>
        /// The specified <paramref name="value" />, converted to type
        /// <see langword="decimal" />.
        /// </returns>
        public static decimal AsDecimal(this long? value)
        {
            var result = decimal.Zero;

            try
            {
                if (value == null) return result;
                if (!value.HasValue) return result;

                result = Convert.ToDecimal(value.Value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Returns a value that is not less than the specified
        /// <paramref name="floorValue" />.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <param name="floorValue">(Required.) Floor value.</param>
        /// <remarks>
        /// If the specified <paramref name="value" /> is equal to or greater than
        /// the <paramref name="floorValue" />, then this method is the identity.
        /// </remarks>
        /// <returns>
        /// <paramref name="floorValue" /> if the specified
        /// <paramref name="value" /> is less than <paramref name="floorValue" />,
        /// otherwise <paramref name="value" />.
        /// </returns>
        public static int FloorOf(this int value, int floorValue)
            => value < floorValue ? value : floorValue;

        /// <summary>
        /// Determines whether a number is strictly between (as in, can't be
        /// equal to either).
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// True if <paramref name="value" /> is strictly greater than
        /// <paramref name="lowerBound" /> and strictly less than
        /// <paramref name="upperBound" /> ; false otherwise.
        /// </returns>
        public static bool IsBetween(
            this decimal value,
            decimal lowerBound,
            decimal upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound > value && value > lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a number is strictly between (as in, can't be
        /// equal to either).
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// True if <paramref name="value" /> is strictly greater than
        /// <paramref name="lowerBound" /> and strictly less than
        /// <paramref name="upperBound" /> ; false otherwise.
        /// </returns>
        public static bool IsBetween(
            this int value,
            int lowerBound,
            int upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound > value && value > lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a number is strictly between (as in, can't be
        /// equal to either).
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// True if <paramref name="value" /> is strictly greater than
        /// <paramref name="lowerBound" /> and strictly less than
        /// <paramref name="upperBound" /> ; false otherwise.
        /// </returns>
        public static bool IsBetween(
            this long value,
            long lowerBound,
            long upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound > value && value > lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines if a decimal value is between a pair of values or equal to
        /// either of them.
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// <see langword="true" /> if the value is either within the range
        /// specified or equal to either of the bounds; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsIncludedInRange(
            this decimal value,
            decimal lowerBound,
            decimal upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound >= value && value >= lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines if an integer value is between a pair of values or equal to
        /// either of them.
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// <see langword="true" /> if the value is either within the range
        /// specified or equal to either of the bounds; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsIncludedInRange(
            this int value,
            int lowerBound,
            int upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound >= value && value >= lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines if an integer value is between a pair of values or equal to
        /// either of them.
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// <see langword="true" /> if the value is either within the range
        /// specified or equal to either of the bounds; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsIncludedInRangeSilent(
            [NotLogged] this int value,
            [NotLogged] int lowerBound,
            [NotLogged] int upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound >= value && value >= lowerBound;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines if an <see cref="T:System.Int32" /> value is between a pair of
        /// values or equal to the lower bound of the given range.
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <remarks>
        /// The <paramref name="upperBound" /> is EXCLUDED from the range of valid
        /// value(s) by this method.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the value is either within the range specified or
        /// equal to the <paramref name="lowerBound" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool IsInRangeWithLowerBound(
            this int value,
            int lowerBound,
            int upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound > value && value >= lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

        /// <summary>
        /// Determines if an <see cref="T:System.Int32" /> value is either strictly between
        /// a pair of values or equal to the upper bound of the given range.
        /// </summary>
        /// <param name="value"> The value to be checked. </param>
        /// <param name="lowerBound"> Lower bound. </param>
        /// <param name="upperBound"> Upper bound. </param>
        /// <returns>
        /// <see langword="true" /> if the value is either within the range specified or
        /// equal to the <paramref name="upperBound" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool IsInRangeWithUpperBound(
            this int value,
            int lowerBound,
            int upperBound
        )
        {
            var result = false;

            try
            {
                if ((upperBound - lowerBound).IsNonPositive()) return result;

                result = upperBound >= value && value > lowerBound;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="value" />  is a member of the
        /// set of all natural numbers; i.e., one or greater.
        /// </summary>
        /// <param name="value">
        /// Value to be compared.  Must be of
        /// <see cref="T:System.Int32" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// a member of the set of all natural numbers; otherwise, <see langword="false" />
        /// .
        /// </returns>
        public static bool IsNaturalNumber(this int value)
            => value >= 1;

        /// <summary> Determines if a <paramref name="value" /> is negative. </summary>
        /// <param name="value">
        /// (Required.) Value to be compared. Must be of
        /// <see cref="T:System.Decimal" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is strictly
        /// less than zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNegative(this decimal value)
            => value < decimal.Zero;

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is negative; i.e.,
        /// strictly less than zero.
        /// </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of <see cref="T:System.Int32" />
        /// type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is negative;
        /// <see langword="false" /> if the <paramref name="value" /> is zero or greater.
        /// </returns>
        public static bool IsNegative(this int value)
            => value < 0;

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is
        /// non-positive; i.e., zero, or a negative number.
        /// </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of
        /// <see cref="T:System.Decimal" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// nonnegative; <see langword="false" /> if the <paramref name="value" /> is
        /// strictly less than <see cref="F:System.Decimal.Zero" />.
        /// </returns>
        public static bool IsNonNegative(this decimal value)
            => value >= decimal.Zero;

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is
        /// non-negative; i.e., zero, or a positive number.
        /// </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of
        /// <see cref="T:System.Int32" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// nonnegative; <see langword="false" /> if the <paramref name="value" /> is
        /// strictly less than <see cref="F:System.Int32.Zero" />.
        /// </returns>
        public static bool IsNonNegative(this int value)
            => value >= 0;

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is
        /// non-positive; i.e., zero, or a negative number.
        /// </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of
        /// <see cref="T:System.Decimal" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// nonpositive; <see langword="false" /> if the <paramref name="value" /> is
        /// strictly greater than<see cref="F:System.Decimal.Zero" />.
        /// </returns>
        public static bool IsNonPositive(this decimal value)
            => value <= decimal.Zero;

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is
        /// non-positive; i.e., zero, or a negative number.
        /// </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of
        /// <see cref="T:System.Int32" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// nonpositive; <see langword="false" /> if the <paramref name="value" /> is
        /// strictly greater than<see cref="F:System.Int32.Zero" />.
        /// </returns>
        public static bool IsNonPositive(this int value)
            => value <= 0;

        /// <summary> Determines whether a <paramref name="value" /> is nonzero. </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of
        /// <see cref="T:System.Decimal" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// strictly nonzero; <see langword="false" /> if the <paramref name="value" /> is
        /// identically equal to <see cref="F:System.Decimal.Zero" />.
        /// </returns>
        public static bool IsNonzero(this decimal value)
            => value != decimal.Zero;

        /// <summary> Determines whether a <paramref name="value" /> is nonzero. </summary>
        /// <param name="value">
        /// (Required.) Value to be compared.  Must be of
        /// <see cref="T:System.Decimal" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// strictly nonzero; <see langword="false" /> if the <paramref name="value" /> is
        /// identically equal to <see cref="F:System.Decimal.Zero" />.
        /// </returns>
        public static bool IsNonzero(this double value)
            => value != 0D;

        /// <summary>
        /// Determines whether the specified <paramref name="value" />  is a positive
        /// integer; i.e., the <paramref name="value" /> is strictly greater than zero.
        /// </summary>
        /// <param name="value">
        /// Value to be compared.  Must be of
        /// <see cref="T:System.Int32" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// greater than zero; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsPositive(this int value)
            => value > 0;

        /// <summary> Determines whether a <paramref name="value" /> is positive. </summary>
        /// <param name="value">
        /// (Required.)  Value to be compared. Must be of
        /// <see cref="T:System.Decimal" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is strictly
        /// greater than zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsPositive(this decimal value)
            => value > decimal.Zero;

        /// <summary> Determines whether a <paramref name="value" /> is positive. </summary>
        /// <param name="value">
        /// (Required.)  Value to be compared. Must be of
        /// <see cref="T:System.Double" /> data type.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is strictly
        /// greater than zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsPositive(this double value)
            => value > 0D;

        /// <summary> Determines whether a <paramref name="value" /> is zero. </summary>
        /// <param name="value"> Value to be compared. </param>
        /// <returns> True if the <paramref name="value" /> is zero; false otherwise. </returns>
        public static bool IsZero(this decimal value)
            => value == decimal.Zero;

        /// <summary> Determines whether a <paramref name="value" /> is zero. </summary>
        /// <param name="value"> Value to be compared. </param>
        /// <returns> True if the <paramref name="value" /> is zero; false otherwise. </returns>
        public static bool IsZero(this int value)
            => value == 0;

        /// <summary>
        /// Rounds the specified <paramref name="value" /> to the nearest cent, using
        /// banker's rounding, assuming that the specified <paramref name="value" /> is
        /// denominated in <c>U.S. Dollars (USD)</c>.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see cref="T:System.Decimal" /> value that
        /// is to be rounded.
        /// </param>
        /// <returns>
        /// Result of the rounding, using banker's rounding; or
        /// <see cref="F:System.Decimal.Zero" /> if not successful.
        /// <para />
        /// <see cref="F:System.Decimal.Zero" /> is also returned if
        /// <see cref="F:System.Decimal.Zero" /> or less is passed as the argument of
        /// <paramref name="value" />.
        /// </returns>
        public static decimal ToNearestCent(this decimal value)
        {
            var result = decimal.Zero;

            try
            {
                if (decimal.Zero.Equals(value)) return result;
                if (value < decimal.Zero) return result;

                result = Math.Round(value, 2, MidpointRounding.ToEven);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }

        /// <summary>
        /// Takes a value of type decimal and truncates it to the specified
        /// number of places.
        /// </summary>
        /// <param name="val"> Value to be truncated. </param>
        /// <param name="places"> Number of digits following the decimal point. </param>
        /// <returns>
        /// New decimal value with all the digits removed except places digits
        /// following the decimal point.
        /// </returns>
        public static decimal TruncateDecimalPlaces(
            this decimal val,
            int places
        )
        {
            if (places < 0) throw new ArgumentException("places");

            return Math.Round(
                val - Convert.ToDecimal(0.5 / Math.Pow(10, places)), places
            );
        }

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is the identity.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static int ZeroFloor(this int value)
            => value < 0 ? 0 : value;

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is the identity.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static double ZeroFloor(this double value)
            => value < 0.00D ? 0.00D : value;

        /// <summary>
        /// Computes the zero floor.  Meaning, if the specified
        /// <paramref name="value" /> is negative, then this method returns zero.
        /// <para />
        /// If the specified <paramref name="value" /> is zero or greater, then this method
        /// is idempotent.
        /// </summary>
        /// <param name="value">(Required.) Input value.</param>
        /// <returns>
        /// Zero if the specified <paramref name="value" /> is negative;
        /// otherwise, if the specified <paramref name="value" /> is zero or greater, then
        /// the method is the identity map.
        /// </returns>
        public static decimal ZeroFloor(this decimal value)
            => value < decimal.Zero ? decimal.Zero : value;
    }
}