using PostSharp.Patterns.Diagnostics;
using System;
using System.Text;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Provides extension method(s) for working with byte array(s).
    /// </summary>
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Core.Extensions.ByteArrayExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ByteArrayExtensions() { }

        /// <summary>
        /// Returns the length of the specified byte array, <paramref name="bytes" />, or
        /// zero if the array is set to a <see langword="null" /> reference.
        /// </summary>
        /// <param name="bytes">
        /// (Require.) Reference to the byte array whose length is to
        /// be determined.
        /// </param>
        /// <remarks>Calls to this method are not logged.</remarks>
        /// <returns>
        /// The length of the byte array, or zero if the array is set to a
        /// <see langword="null" /> reference.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static int GetSafeLength([NotLogged] this byte[] bytes)
        {
            var result = 0;

            try
            {
                if (bytes == null) return result;

                result = bytes.Length;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = 0;
            }

            return result;
        }

        /// <summary>
        /// Converts a byte array, <paramref name="bytes" /> to a
        /// <see cref="T:System.String" /> of hex value(s), separated by space(s), each of
        /// which correspond to the value of the byte(s) in the array.
        /// </summary>
        /// <param name="bytes">
        /// (Required.) Reference to the byte array that is to be
        /// converted.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is supplied as the argument of
        /// the <paramref name="bytes" /> parameter, or if the <paramref name="bytes" />
        /// parameter refers to an array with zero element(s), then the
        /// <see cref="F:System.String.Empty" /> value is returned.
        /// </remarks>
        /// <returns>A <see cref="T:System.String" /> representation of the byte array.</returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static string ToHexString([NotLogged] this byte[] bytes)
        {
            var result = string.Empty;

            try
            {
                if (bytes == null) return result;
                var hex = new StringBuilder(bytes.Length * 2);
                var safeLength = bytes.GetSafeLength();

                if (safeLength <= 0) return result;

                for (var i = 0; i < safeLength; i++)
                {
                    if (i > 0) hex.Append(" ");
                    hex.AppendFormat("{0:x2}", bytes[i]);
                }

                result = hex.ToString();
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