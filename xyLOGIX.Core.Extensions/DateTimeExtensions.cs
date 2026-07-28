using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods to perform operations on
    /// <see cref="T:System.DateTime" /> value(s).
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Core.Extensions.DateTimeExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static DateTimeExtensions() { }

        /// <summary>
        /// Determines whether the specified <paramref name="dateTime1" />
        /// <see cref="T:System.DateTime" /> value is strictly after the specified
        /// <paramref name="dateTime2" /><see cref="T:System.DateTime" /> value.
        /// </summary>
        /// <param name="dateTime1">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime2" /> value.
        /// </param>
        /// <param name="dateTime2">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime1" /> value.
        /// </param>
        /// <remarks>
        /// If either <paramref name="dateTime1" /> or
        /// <paramref name="dateTime2" /> is equal to the default value of
        /// <see cref="T:System.DateTime" />, then this method will return
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="dateTime1" />
        /// value is strictly after the specified <paramref name="dateTime2" /> value;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsAfter(this DateTime dateTime1, DateTime dateTime2)
        {
            var result = false;

            try
            {
                if (dateTime2 == default) return result;
                if (dateTime1 == default) return result;

                result = dateTime1 > dateTime2;
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
        /// Determines whether the specified <paramref name="dateTime1" />
        /// <see cref="T:System.DateTime" /> value is after or on the specified
        /// <paramref name="dateTime2" /><see cref="T:System.DateTime" /> value.
        /// </summary>
        /// <param name="dateTime1">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime2" /> value.
        /// </param>
        /// <param name="dateTime2">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime1" /> value.
        /// </param>
        /// <remarks>
        /// If either <paramref name="dateTime1" /> or
        /// <paramref name="dateTime2" /> is equal to the default value of
        /// <see cref="T:System.DateTime" />, then this method will return
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="dateTime1" />
        /// value is after or on the specified <paramref name="dateTime2" /> value;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsAfterOrOn(this DateTime dateTime1, DateTime dateTime2)
        {
            var result = false;

            try
            {
                if (dateTime1 == default) return result;
                if (dateTime2 == default) return result;

                result = dateTime1 >= dateTime2;
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
        /// Determines whether the specified <paramref name="dateTime1" />
        /// <see cref="T:System.DateTime" /> value is strictly before the specified
        /// <paramref name="dateTime2" /><see cref="T:System.DateTime" /> value.
        /// </summary>
        /// <param name="dateTime1">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime2" /> value.
        /// </param>
        /// <param name="dateTime2">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime1" /> value.
        /// </param>
        /// <remarks>
        /// If either <paramref name="dateTime1" /> or
        /// <paramref name="dateTime2" /> is equal to the default value of
        /// <see cref="T:System.DateTime" />, then this method will return
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="dateTime1" />
        /// value is before the specified <paramref name="dateTime2" /> value; otherwise,
        /// <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsBefore(this DateTime dateTime1, DateTime dateTime2)
        {
            var result = false;

            try
            {
                if (dateTime2 == default) return result;
                if (dateTime1 == default) return result;

                result = dateTime1 < dateTime2;
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
        /// Determines whether the specified <paramref name="dateTime1" />
        /// <see cref="T:System.DateTime" /> value is before or on the specified
        /// <paramref name="dateTime2" /><see cref="T:System.DateTime" /> value.
        /// </summary>
        /// <param name="dateTime1">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime2" /> value.
        /// </param>
        /// <param name="dateTime2">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime1" /> value.
        /// </param>
        /// <remarks>
        /// If either <paramref name="dateTime1" /> or
        /// <paramref name="dateTime2" /> is equal to the default value of
        /// <see cref="T:System.DateTime" />, then this method will return
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="dateTime1" />
        /// value is before or on the specified <paramref name="dateTime2" /> value;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsBeforeOrOn(this DateTime dateTime1, DateTime dateTime2)
        {
            var result = false;

            try
            {
                if (dateTime2 == default) return result;
                if (dateTime1 == default) return result;

                result = dateTime1 <= dateTime2;
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
        /// Determines whether the specified <paramref name="dateTime1" />
        /// <see cref="T:System.DateTime" /> value is strictly after the specified
        /// <paramref name="dateTime2" /><see cref="T:System.DateTime" /> value.
        /// </summary>
        /// <param name="dateTime1">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime2" /> value.
        /// </param>
        /// <param name="dateTime2">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime1" /> value.
        /// </param>
        /// <remarks>
        /// If either <paramref name="dateTime1" /> or <paramref name="dateTime2" /> is
        /// equal to the default value of <see cref="T:System.DateTime" />, then this
        /// method will return <see langword="false" />.
        /// <para />
        /// This method is simply defined to be a semantic alias for the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.DateTimeExtensions.IsAfter(System.DateTime,System.DateTime)" />
        /// method.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="dateTime1" />
        /// value is strictly after the specified <paramref name="dateTime2" /> value;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsStrictlyAfter(this DateTime dateTime1, DateTime dateTime2)
            => dateTime1.IsAfter(dateTime2);

        /// <summary>
        /// Determines whether the specified <paramref name="dateTime1" />
        /// <see cref="T:System.DateTime" /> value is strictly before the specified
        /// <paramref name="dateTime2" /><see cref="T:System.DateTime" /> value.
        /// </summary>
        /// <param name="dateTime1">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime2" /> value.
        /// </param>
        /// <param name="dateTime2">
        /// (Required.) The <see cref="T:System.DateTime" /> value
        /// that is to be compared to the specified <paramref name="dateTime1" /> value.
        /// </param>
        /// <remarks>
        /// If either <paramref name="dateTime1" /> or <paramref name="dateTime2" /> is
        /// equal to the default value of <see cref="T:System.DateTime" />, then this
        /// method will return <see langword="false" />.
        /// <para />
        /// This method is simply defined to be a semantic alias for the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.DateTimeExtensions.IsBefore(System.DateTime,System.DateTime)" />
        /// method.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="dateTime1" />
        /// value is before the specified <paramref name="dateTime2" /> value; otherwise,
        /// <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsStrictlyBefore(this DateTime dateTime1, DateTime dateTime2)
            => dateTime1.IsBefore(dateTime2);

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
        [Log(AttributeExclude = true)]
        public static string ToRFC3339(this DateTime date)
        {
            string result;

            try
            {
                result = date.Kind == DateTimeKind.Utc
                    ? date.ToString("yyyy-MM-dd'T'HH:mm:ss.8efb9587-8309-4d74-b807-d02ecb2ce152K")
                    : date.ToUniversalTime()
                          .ToString("yyyy-MM-dd'T'HH:mm:ss.8efb9587-8309-4d74-b807-d02ecb2ce152K");
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