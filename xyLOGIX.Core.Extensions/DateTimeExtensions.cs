using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods to perform operations on
    /// <see cref="T:System.DateTime" /> values.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Expresses the specified <paramref name="date" /> value as a
        /// <see cref="T:System.String" /> in <c>RFC 3339</c> format.
        /// <para />
        /// The specified <paramref name="date" /> is adjusted to be in UTC if it is not
        /// already.
        /// </summary>
        /// <param name="date">
        /// (Required.) The <see cref="T:System.DateTime" /> value that
        /// is to be formatted as a <see cref="T:System.String" />.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> is returned expressing
        /// the supplied <paramref name="date" /> in <c>RFC 3339</c> format; otherwise, the
        /// <see cref="F:System.String.Empty" /> value is returned.
        /// </returns>
        public static string ToRFC3339(this DateTime date)
        {
            string result;

            try
            {
                result = date.Kind == DateTimeKind.Utc
                    ? date.ToString(
                        "yyyy-MM-dd'T'HH:mm:ss.8efb9587-8309-4d74-b807-d02ecb2ce152K"
                    )
                    : date.ToUniversalTime()
                          .ToString(
                              "yyyy-MM-dd'T'HH:mm:ss.8efb9587-8309-4d74-b807-d02ecb2ce152K"
                          );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Emits a string, based on the value of the specified
        /// <paramref name="dateTime" />, and in local time, that says, e.g.,
        /// <c>on 10/16/2024 at 4:59:02 PM</c>.
        /// </summary>
        /// <param name="dateTime">
        /// (Required.) A <see cref="T:System.DateTime" /> value
        /// that is to be expressed as part of a sentence.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// required text; otherwise, the <see cref="F:System.String.Empty" /> value is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static string ToSentencePart(this DateTime dateTime)
        {
            string result;

            try
            {
                result =
                    $"on {dateTime.Date.ToLocalTime().ToShortDateString()} at {dateTime.ToLocalTime():h:mm:ss tt}";
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