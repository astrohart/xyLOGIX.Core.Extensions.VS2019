using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions.Actions
{
    /// <summary>
    /// Exposes static methods to round various quantities to various values.
    /// </summary>
    public static class Round
    {
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
        public static decimal ToNearestCent(decimal value)
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
    }
}