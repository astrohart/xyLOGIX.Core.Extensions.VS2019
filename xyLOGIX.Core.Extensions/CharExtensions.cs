using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Contains extension methods to be used on instances of the
    /// <see cref="T:System.Char" />.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Core.Extensions.CharExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CharExtensions() { }

        /// <summary>Determines whether the specified <paramref name="value" /> is a digit.</summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.Char" /> value to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is a digit;
        /// otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsDigit([NotLogged] this char value)
        {
            bool result;

            try
            {
                result = char.IsDigit(value);
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
        /// Determines whether the specified <see cref="T:System.Char" /> is a
        /// single hyphen character (<c>'-'</c>).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.Char" /> value to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is a single
        /// hyphen character; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsHyphen([NotLogged] this char value)
        {
            bool result;

            try
            {
                result = '-'.Equals(value);
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
        /// Determines whether the specified <paramref name="value" /> is an ASCII
        /// lowercase letter ('a' through 'z').
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.Char" /> value to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is a lowercase
        /// ASCII letter; otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsLowercase([NotLogged] this char value)
        {
            bool result;

            try
            {
                result = char.IsLower(value);
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
        /// Determines whether the specified <see cref="T:System.Char" /> is a
        /// single period character (<c>'.'</c>).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.Char" /> value to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is a single
        /// period character; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsPeriod([NotLogged] this char value)
        {
            bool result;

            try
            {
                result = '.'.Equals(value);
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
        /// Determines whether the specified <see cref="T:System.Char" /> is a
        /// single space character (<c>' '</c>).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.Char" /> value to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is a single space
        /// character; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsSingleSpace([NotLogged] this char value)
        {
            bool result;

            try
            {
                result = ' '.Equals(value);
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
        /// Determines whether the specified <paramref name="value" /> is an ASCII
        /// uppercase letter ('A' through 'Z').
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.Char" /> value to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> is an uppercase
        /// ASCII letter; otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsUppercase([NotLogged] this char value)
        {
            bool result;

            try
            {
                result = char.IsUpper(value);
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