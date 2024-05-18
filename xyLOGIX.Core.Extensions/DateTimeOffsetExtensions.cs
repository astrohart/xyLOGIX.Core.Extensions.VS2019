using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for <see cref="T:System.DateTimeOffset" />
    /// value(s).
    /// </summary>
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Determines if <paramref name="dto1" />  is within <paramref name="seconds" />
        /// second(s) of <paramref name="dto2" />, where <paramref name="dto1" /> and
        /// <paramref name="dto2" />  are both instances of
        /// <see cref="T:System.DateTimeOffset" />.
        /// </summary>
        /// <param name="dto1">
        /// (Required.) One of the
        /// <see cref="T:System.DateTimeOffset" /> value(s) to be compared.
        /// </param>
        /// <param name="dto2">
        /// (Required.) The other of the two
        /// <see cref="T:System.DateTimeOffset" /> value(s) to be compared.
        /// </param>
        /// <param name="seconds">
        /// (Required.) A positive <see cref="T:System.Int32" /> that
        /// gives the number of seconds that the difference between
        /// <paramref name="dto1" /> and <paramref name="dto2" />  must be within.
        /// </param>
        /// <remarks>
        /// This method measures the time difference between
        /// <paramref name="dto1" />  and <paramref name="dto2" /> to the nearest
        /// millisecond.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the two
        /// <see cref="T:System.DateTimeOffset" /> value(s), <paramref name="dto1" /> and
        /// <paramref name="dto2" />, are equal to or less than <paramref name="seconds" />
        /// apart.
        /// </returns>
        public static bool IsWithinXSecondsOf(
            this DateTimeOffset dto1,
            DateTimeOffset dto2,
            int seconds
        )
        {
            var result = false;

            try
            {
                if (seconds <= 0) return result;
                if (dto1 == null) return result;
                if (dto2 == null) return result;

                var difference = dto1 - dto2;
                return Math.Abs(difference.TotalMilliseconds) <=
                       Convert.ToDouble(seconds) * 1000.0D;
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
        /// Determines if <paramref name="dto1" />  is within <paramref name="seconds" />
        /// second(s) of <paramref name="dto2" />, where <paramref name="dto1" /> and
        /// <paramref name="dto2" />  are both instances of
        /// <see cref="T:System.DateTimeOffset" />.
        /// </summary>
        /// <param name="dto1">
        /// (Required.) One of the
        /// <see cref="T:System.DateTime" /> value(s) to be compared.
        /// </param>
        /// <param name="dto2">
        /// (Required.) The other of the two
        /// <see cref="T:System.DateTimeOffset" /> value(s) to be compared.
        /// </param>
        /// <param name="seconds">
        /// (Required.) A positive <see cref="T:System.Int32" /> that
        /// gives the number of seconds that the difference between
        /// <paramref name="dto1" /> and <paramref name="dto2" />  must be within.
        /// </param>
        /// <remarks>
        /// This method measures the time difference between
        /// <paramref name="dto1" />  and <paramref name="dto2" /> to the nearest
        /// millisecond.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the two
        /// <see cref="T:System.DateTimeOffset" /> value(s), <paramref name="dto1" /> and
        /// <paramref name="dto2" />, are equal to or less than <paramref name="seconds" />
        /// apart.
        /// </returns>
        public static bool IsWithinXSecondsOf(
            this DateTime dto1,
            DateTimeOffset dto2,
            int seconds
        )
        {
            var result = false;

            try
            {
                if (seconds <= 0) return result;
                if (dto1 == null) return result;
                if (dto2 == null) return result;

                var difference = dto1 - dto2;
                return Math.Abs(difference.TotalMilliseconds) <=
                       Convert.ToDouble(seconds) * 1000.0D;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}