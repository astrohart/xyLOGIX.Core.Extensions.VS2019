using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for the <see cref="T:System.Guid" />
    /// class.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GuidExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.GuidExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GuidExtensions() { }

        /// <summary>
        /// Expresses the provided <paramref name="guid" /> as a
        /// <see cref="T:System.String" /> containing only the <see cref="T:System.Guid" />
        /// digits, including hyphens.
        /// </summary>
        /// <param name="guid">
        /// (Required.) A <see cref="T:System.Guid" /> that is to be
        /// expressed as a <see cref="T:System.String" /> with braces.
        /// </param>
        /// <returns>
        /// If successful, the <paramref name="guid" /> is expressed a
        /// <see cref="T:System.String" /> containing only the <see cref="T:System.Guid" />
        /// digits, including hyphens.  Otherwise, and including the case where the Zero
        /// GUID is passed, the method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </returns>
        public static string AsDigitsWithHyphens(this Guid guid)
        {
            var result = string.Empty;

            try
            {
                if (guid.IsZero()) return result;

                result = guid.ToString("D");
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
        /// Determines whether the specified <see cref="T:System.Guid" /> value
        /// is the Zero GUID or not.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see cref="T:System.Guid" /> that should
        /// be checked whether it's the Zero GUID.
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
        /// If this method is passed the <see cref="F:System.Guid.Empty" />
        /// value, then this method returns the <see cref="F:System.String.Empty" /> value.
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

        /// <summary>
        /// Expresses the provided <paramref name="guid" /> as a
        /// <see cref="T:System.String" />, surrounded by braces (as in the system
        /// Registry, for instance).
        /// </summary>
        /// <param name="guid">
        /// (Required.) A <see cref="T:System.Guid" /> that is to be
        /// expressed as a <see cref="T:System.String" /> with braces.
        /// </param>
        /// <returns>
        /// If successful, the <paramref name="guid" /> is expressed as a
        /// <see cref="T:System.String" />, surrounded by braces (as in the system
        /// Registry, for instance).  Otherwise, and including the case where the Zero GUID
        /// is passed, the method returns the <see cref="F:System.String.Empty" /> value.
        /// </returns>
        public static string WithBraces(this Guid guid)
        {
            var result = string.Empty;

            try
            {
                if (guid.IsZero()) return result;

                result = guid.ToString("B");
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