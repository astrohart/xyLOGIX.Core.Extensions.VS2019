using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Extension methods for a <c>decimal?</c> value. </summary>
    public static class NullableDecimalExtensions
    {
        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a strictly negative (i.e., less than zero)
        /// numerical value.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.decimal" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly less than
        /// zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNegative(this decimal? value)
            => value != null && value.HasValue && value.Value < decimal.Zero;

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
        public static bool IsNonPositive(this decimal? value)
            => value != null && value.HasValue && value.Value <= decimal.Zero;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly not equal to
        /// zero.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.decimal" /> value to be
        /// checked.
        /// </param>
        /// <remarks>
        /// Callers must remember that this method returns
        /// <see langword="falsedoc" /> only in the case where the numeric value of
        /// <paramref name="value" /> is identically equal to <c>decimal.Zero</c>.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly not equal
        /// zero; <see langword="false" /> if the <paramref name="value" /> is identically
        /// equal to zero
        /// </returns>
        public static bool IsNonzero(this decimal? value)
            => value != null && value.HasValue && value.Value != decimal.Zero;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a strictly positive (i.e., greater than zero)
        /// numerical value.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.decimal" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly greater than
        /// zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsPositive(this decimal? value)
            => value != null && value.HasValue && value.Value > decimal.Zero;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" />.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.decimal" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" />; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsValid(this decimal? value)
            => value != null && value.HasValue;

        /// <summary>
        /// Rounds the specified <paramref name="value" /> to the nearest cent, assuming
        /// that the specified <paramref name="value" /> is denominated in
        /// <c>U.S. Dollars (USD)</c>.
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
        public static decimal ToNearestCent(this decimal? value)
        {
            var result = decimal.Zero;

            try
            {
                if (value == null) return result;
                if (!value.HasValue) return result;
                if (decimal.Zero.Equals(value)) return result;
                if (value < decimal.Zero) return result;

                result = Math.Round(value.Value, 2, MidpointRounding.ToEven);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.Zero;
            }

            return result;
        }
    }
}