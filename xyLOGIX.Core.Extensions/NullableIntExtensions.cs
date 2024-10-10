namespace xyLOGIX.Core.Extensions
{
    /// <summary> Extension methods for a <c>int?</c> value. </summary>
    public static class NullableIntExtensions
    {
        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a strictly negative (i.e., less than zero)
        /// numerical value.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.Int32" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly less than
        /// zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNegative(this int? value)
            => value != null && value.HasValue && value.Value < 0;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly not equal to
        /// zero.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.Int32" /> value to be
        /// checked.
        /// </param>
        /// <remarks>
        /// Callers must remember that this method returns
        /// <see langword="falsedoc" /> only in the case where the numeric value of
        /// <paramref name="value" /> is identically equal to zero.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly not equal
        /// zero; <see langword="false" /> if the <paramref name="value" /> is identically
        /// equal to zero
        /// </returns>
        public static bool IsNonzero(this int? value)
            => value != null && value.HasValue && value.Value != 0;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" /> and has a strictly positive (i.e., greater than zero)
        /// numerical value.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.Int32" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" /> and has a numerical value that is strictly greater than
        /// zero; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsPositive(this int? value)
            => value != null && value.HasValue && value.Value > 0;

        /// <summary>
        /// Indicates whether the specified <paramref name="value" /> is non-
        /// <see langword="null" />.
        /// </summary>
        /// <param name="value">
        /// A nullable <see cref="T:System.Int32" /> value to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="value" /> is non-
        /// <see langword="null" />; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsValid(this int? value)
            => value != null && value.HasValue;
    }
}