using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for the <see cref="T:System.Guid" /> class.
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// Determines whether the specified <see cref="T:System.Guid" /> value is the Zero
        /// GUID or not.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see cref="T:System.Guid" /> that should be
        /// checked whether it's the Zero GUID.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// equal to the Zero GUID; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsZero(this Guid value)
        {
            bool result;

            try
            {
                result = Guid.Empty.Equals(value);
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
        /// Represents the specified <paramref name="guid" /> as a
        /// <see cref="T:System.String" /> that is surrounded by curly braces and is in
        /// uppercase.
        /// </summary>
        /// <param name="guid">
        /// (Required.) A <see cref="T:System.Guid" /> value that is to
        /// be represented as a <see cref="T:System.String" />.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        /// If this method is passed the <see cref="F:System.Guid.Empty" /> value, then
        /// this method returns the <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        public static string ToUppercaseWithBraces(this Guid guid)
        {
            var result = string.Empty;

            try
            {
                if (guid.IsZero()) return result;

                result = guid.ToString("B")
                             .ToUpperInvariant();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}