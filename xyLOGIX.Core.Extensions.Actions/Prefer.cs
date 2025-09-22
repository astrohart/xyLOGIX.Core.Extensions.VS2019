using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions.Actions
{
    /// <summary>
    /// Provides a set of static methods that preferentially return a specified
    /// preferred value over a nullable value, if the nullable value is
    /// <see langword="null" /> or does not have a value.
    /// </summary>
    /// <remarks>
    /// This class comes in particularly handy when the use-case is to merge
    /// settings either specified on the command-line by the user or not specified,
    /// with the config of the application.
    /// </remarks>
    public static class Prefer
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.Actions.Prefer" /> class.
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
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.Byte" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Byte" /> value that is to be returned if the
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
        public static byte ByteOverNull(
            [NotLogged] byte? nullableValue,
            [NotLogged] byte preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.Char" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Char" /> value that is to be returned if the
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
        public static char CharOverNull(
            [NotLogged] char? nullableValue,
            [NotLogged] char preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;
                if ('\0'.Equals(nullableValue.Value)) return result;

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
        /// <see cref="T:System.Decimal" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Decimal" /> value that is to be returned if the
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
        public static decimal DecimalOverNull(
            [NotLogged] decimal? nullableValue,
            [NotLogged] decimal preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.Double" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Double" /> value that is to be returned if the
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
        public static double DoubleOverNull(
            [NotLogged] double? nullableValue,
            [NotLogged] double preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:Single" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:Single" /> value that is to be returned if the
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
        public static float FloatOverNull(
            [NotLogged] float? nullableValue,
            [NotLogged] float preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.IntPtr" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.IntPtr" /> value that is to be returned if the
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
        public static IntPtr IntPtrOverNull(
            [NotLogged] IntPtr? nullableValue,
            [NotLogged] IntPtr preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.Int64" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Int64" /> value that is to be returned if the
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
        public static long LongOverNull(
            [NotLogged] long? nullableValue,
            [NotLogged] long preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.UInt64" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.UInt64" /> value that is to be returned if the
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
        public static ulong LongOverNull(
            [NotLogged] ulong? nullableValue,
            [NotLogged] ulong preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// the <paramref name="valueToCheck" />, if the specified
        /// <paramref name="valueToCheck" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="valueToCheck" /> is
        /// returned.
        /// </summary>
        /// <param name="valueToCheck">
        /// (Required.) A nullable
        /// <see cref="T:System.IntPtr" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.IntPtr" /> value that is to be returned if the
        /// <paramref name="valueToCheck" /> is <see langword="null" /> or does not have a
        /// value.
        /// </param>
        /// <returns>
        /// The specified <paramref name="preferredValue" /> over the
        /// <paramref name="valueToCheck" />, if the specified
        /// <paramref name="valueToCheck" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="valueToCheck" /> is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static IntPtr NonZeroIntPtrOverZero(
            [NotLogged] IntPtr valueToCheck,
            [NotLogged] IntPtr preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (IntPtr.Zero.Equals(valueToCheck) &&
                    !IntPtr.Zero.Equals(result)) return result;

                result = valueToCheck;
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
        /// the <paramref name="valueToCheck" />, if the specified
        /// <paramref name="valueToCheck" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="valueToCheck" /> is
        /// returned.
        /// </summary>
        /// <param name="valueToCheck">
        /// (Required.) A nullable
        /// <see cref="T:System.UIntPtr" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.UIntPtr" /> value that is to be returned if the
        /// <paramref name="valueToCheck" /> is <see langword="null" /> or does not have a
        /// value.
        /// </param>
        /// <returns>
        /// The specified <paramref name="preferredValue" /> over the
        /// <paramref name="valueToCheck" />, if the specified
        /// <paramref name="valueToCheck" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="valueToCheck" /> is
        /// returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static UIntPtr NonZeroUIntPtrOverZero(
            [NotLogged] UIntPtr valueToCheck,
            [NotLogged] UIntPtr preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (UIntPtr.Zero.Equals(valueToCheck) &&
                    !UIntPtr.Zero.Equals(result)) return result;

                result = valueToCheck;
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
        /// (Required.) A <see cref="T:System.Object" /> variable whose value is to be
        /// returned if it indeed does have a non-<see langword="null" />, non-blank value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) A <see cref="T:System.Object" />
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
        public static object ObjectOverNull(
            [NotLogged] object nullableValue,
            [NotLogged] object preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null && preferredValue == null)
                    return result;
                if (nullableValue == null && preferredValue != null)
                    return result;
                if (nullableValue != null && preferredValue == null)
                    return nullableValue;

                result = preferredValue;
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
        /// <see cref="T:System.SByte" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.SByte" /> value that is to be returned if the
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
        public static sbyte SByteOverNull(
            [NotLogged] sbyte? nullableValue,
            [NotLogged] sbyte preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.Int16" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.Int16" /> value that is to be returned if the
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
        public static short ShortOverNull(
            [NotLogged] short? nullableValue,
            [NotLogged] short preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        public static string StringOverBlank(
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

        /// <summary>
        /// Preferentially returns the specified <paramref name="preferredValue" /> over
        /// the <paramref name="nullableValue" />, if the specified
        /// <paramref name="nullableValue" /> is <see langword="null" /> or it does not
        /// have a value; otherwise, the value of the <paramref name="nullableValue" /> is
        /// returned.
        /// </summary>
        /// <param name="nullableValue">
        /// (Required.) A nullable
        /// <see cref="T:System.UInt32" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.UInt32" /> value that is to be returned if the
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
        public static uint UInt32OverNull(
            [NotLogged] uint? nullableValue,
            [NotLogged] uint preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.UIntPtr" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.UIntPtr" /> value that is to be returned if the
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
        public static UIntPtr UIntPtrOverNull(
            [NotLogged] UIntPtr? nullableValue,
            [NotLogged] UIntPtr preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// <see cref="T:System.UInt16" /> variable whose value is to be returned if it
        /// indeed does have a value.
        /// </param>
        /// <param name="preferredValue">
        /// (Required.) Reference to the preferred
        /// <see cref="T:System.UInt16" /> value that is to be returned if the
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
        public static ushort UShortOverNull(
            [NotLogged] ushort? nullableValue,
            [NotLogged] ushort preferredValue
        )
        {
            var result = preferredValue;

            try
            {
                if (nullableValue == null) return result;
                if (!nullableValue.HasValue) return result;
                if (nullableValue.Value == preferredValue) return result;

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
        /// Returns the value of the <paramref name="value1" /> parameter if it is greater
        /// than or equal to zero; otherwise, <paramref name="value2" /> is returned.
        /// </summary>
        /// <param name="value1">
        /// (Required.) An integer value to be returned if it is greater than or equal to
        /// zero.
        /// </param>
        /// <param name="value2">
        /// (Required.) An integer value to be returned if the <paramref name="value1" />
        /// is less than zero.
        /// </param>
        /// <returns>
        /// <c>-1</c> if neither <paramref name="value1" /> nor
        /// <paramref name="value2" /> are zero or greater; otherwise,
        /// <paramref name="value1" /> if it is nonnegative; otherwise,
        /// <paramref name="value2" />.
        /// </returns>
        public static int WhicheverValueIsNonNegative(int value1, int value2)
        {
            var result = value1;

            try
            {
                if (value1 < 0)
                    if (value2 >= 0)
                        result = value2;
                    else
                        result = -1;
                else
                    result = value1;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }
    }
}