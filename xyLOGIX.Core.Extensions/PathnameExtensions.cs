using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static methods to extend the <see cref="T:System.String" /> class in
    /// order to help a caller in using <see cref="T:System.String" /> variables known
    /// or suspected to contain the fully-qualified pathname of a folder or a file.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class PathnameExtensions
    {
        /// <summary>
        /// Extension method that can be used with all
        /// <see cref="T:System.String" /> variables to determine whether a particular
        /// file's <paramref name="pathname" /> has a given filename
        /// <paramref name="extension" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname whose filename extension is to be tested.
        /// </param>
        /// <param name="extension">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the filename extension that the specified
        /// <paramref name="pathname" /> should have.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// has the specified filename <paramref name="extension" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="pathname" /> or <paramref name="extension" />
        /// have <see langword="null" /> or blank <see cref="T:System.String" /> values as
        /// their arguments, then this method returns <see langword="false" />.
        /// <para />
        /// <see langword="false" /> is also returned if the argument of the
        /// <paramref name="pathname" /> parameter refers to a file that does not exist on
        /// the filesystem.
        /// <para />
        /// <b>NOTE:</b> This method is meant to be used as an extension method of type
        /// <see cref="T:System.String" />.
        /// </remarks>
        public static bool HasExtension(
            this string pathname,
            string extension
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (string.IsNullOrWhiteSpace(extension)) return result;

                result = extension.Equals(Path.GetExtension(pathname));
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
        /// Extension method that can be used with all
        /// <see cref="T:System.String" /> variables to determine whether a particular
        /// file's <paramref name="pathname" /> has a given filename
        /// <paramref name="extensions" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname whose filename extension is to be tested.
        /// </param>
        /// <param name="extensions">
        /// (Required.) One or more <see cref="T:System.String" /> values indicating the
        /// possible extension(s) that the provided <paramref name="pathname" /> must have.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// has the specified filename <paramref name="extensions" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="pathname" /> or <paramref name="extensions" />
        /// have <see langword="null" /> or blank <see cref="T:System.String" /> values as
        /// their arguments, then this method returns <see langword="false" />.
        /// <para />
        /// <see langword="false" /> is also returned if the argument of the
        /// <paramref name="pathname" /> parameter refers to a file that does not exist on
        /// the filesystem.
        /// <para />
        /// <b>NOTE:</b> This method is meant to be used as an extension method of type
        /// <see cref="T:System.String" />.
        /// </remarks>
        public static bool HasAnyOfTheseExtensions(
            this string pathname,
            params string[] extensions
        )
        {
            var result = false;

            try
            {
                if (extensions == null) return result;
                if (extensions.Length <= 0) return result;
                if (!FileExists(pathname)) return result;

                result = Path.GetExtension(pathname)
                             .IsAnyOf(extensions);
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
        /// Determines whether the file having the specified
        /// <paramref name="pathname" /> exists on the filesystem or not.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file to check for existence.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// is not blank, and if it contains the fully-qualified pathname of a file that
        /// currently exists on the filesystem, or <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// This method is superior to calling the
        /// <see cref="M:Alphaleonis.Win32.Filesystem.File.Exists" /> method.  This is due
        /// to the fact that the other method throws an exception if it is passed a blank
        /// string, whereas this method simply returns <see langword="false" />.
        /// </remarks>
        private static bool FileExists(string pathname)
        {
            bool result;

            try
            {
                result = !string.IsNullOrWhiteSpace(pathname) &&
                         File.Exists(pathname);
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