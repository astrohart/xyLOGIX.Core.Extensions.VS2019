﻿using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Extension methods for a <c>long</c> value. </summary>
    [Log(AttributeExclude = true)]
    public static class LongExtensions
    {
        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a strictly negative (i.e., less than zero)
        /// numerical value.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.Int64" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly less than
        /// zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNegative(this long value)
            => value < 0L;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is nonnegative (i.e.,
        /// greater than, or equal to, zero).
        /// </summary>
        /// <param name="value"> A <see cref="T:System.Int64" /> value to be checked. </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is greater than, or
        /// equal to, zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNonNegative(this long value)
            => value >= 0L;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is nonpositive (i.e.,
        /// less than, or equal to, zero).
        /// </summary>
        /// <param name="value"> A <see cref="T:System.Int64" /> value to be checked. </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is less than, or
        /// equal to, zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNonPositive(this long value)
            => value <= 0L;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly not equal to
        /// zero.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.Int64" /> value to be
        /// checked.
        /// </param>
        /// <remarks>
        /// Callers must remember that this method returns
        /// <see langword="falsedoc" /> only in the case where the numeric value of
        /// <paramref name="value" /> is identically equal to <c>0L</c>.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly not equal
        /// zero; <see langword="false" /> if the <paramref name="value" /> is identically
        /// equal to zero
        /// </returns>
        public static bool IsNonzero(this long value)
            => value != 0L;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is strictly
        /// positive (i.e., greater than zero).
        /// </summary>
        /// <param name="value"> A <see cref="T:System.Int64" /> value to be checked. </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is strictly
        /// greater than zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsPositive(this long value)
            => value > 0L;
    }
}