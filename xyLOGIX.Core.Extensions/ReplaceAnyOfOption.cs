namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Value(s) that allow the caller of the
    /// <see cref="M:xyLOGIX.Core.Extensions.StringExtensions.ReplaceAnyOf" /> method
    /// to specify options for how the replacement should be performed.
    /// </summary>
    public enum ReplaceAnyOfOption
    {
        /// <summary>
        /// All occurrences of the target string(s) should be replaced.
        /// </summary>
        All,

        /// <summary>
        /// Only the first occurrence of the target string(s) should be replaced.
        /// </summary>
        First,

        /// <summary>
        /// Represents an unknown or undefined state.
        /// </summary>
        /// <remarks>
        /// This value is typically used as a default or sentinel value to indicate that
        /// the
        /// state is not recognized or has not been explicitly set.
        /// </remarks>
        Unknown = -1
    }
}