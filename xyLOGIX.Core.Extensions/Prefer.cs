﻿using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    public static class Prefer
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.Prefer" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Prefer() { }

        /// <summary>
        /// Preferentially returns the specified <paramref name="preferredValue" /> over
        /// the <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </summary>
        /// <param name="nullableValue">
        /// (Required.) A nullable
        /// <see cref="T:System.Boolean" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Boolean" /> value that is to be returned if the
        /// <paramref name="nullableValue" /> is <see langword="null" /> or does not have a
        /// value.
        /// </param>
        /// <returns>
        /// The specified <paramref name="preferredValue" /> over the
        /// <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static bool BoolOverNull(
            [NotLogged] bool? nullableValue,
            [NotLogged] bool preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;

                result = nullableValue.Value;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = preferredValue;
            }

            return result;
        }

        /// <summary>
        /// Preferentially returns the specified <paramref name="preferredValue" /> over
        /// the <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </summary>
        /// <param name="nullableValue">
        /// (Required.) A nullable
        /// <see cref="T:System.Int32" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Int32" /> value that is to be returned if the
        /// <paramref name="nullableValue" /> is <see langword="null" /> or does not have a
        /// value.
        /// </param>
        /// <returns>
        /// The specified <paramref name="preferredValue" /> over the
        /// <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static int IntOverNull(
            [NotLogged] int? nullableValue,
            [NotLogged] int preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;

                result = nullableValue.Value;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = preferredValue;
            }

            return result;
        }

        /// <summary>
        /// Preferentially returns the specified <paramref name="preferredValue" /> over
        /// the <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </summary>
        /// <param name="nullableValue">
        /// (Required.) A <see cref="T:System.String" /> variable whose value is to be
        /// returned if it indeed does have a non-<see langword="null" />, non-blank value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the preferred value that is to be returned if the
        /// <paramref name="nullableValue" /> is <see langword="null" /> or does not have a
        /// value.
        /// </param>
        /// <returns>
        /// The specified <paramref name="preferredValue" /> over the
        /// <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static string StringOverNull(
            [NotLogged] string nullableValue,
            [NotLogged] string preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (string.IsNullOrWhiteSpace(nullableValue)) return result;

                result = nullableValue;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = preferredValue;
            }

            return result;
        }
    }
}