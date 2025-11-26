using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static method(s) to extend the <see cref="T:System.String" /> class in
    /// order to help a caller in using <see cref="T:System.String" /> variables known
    /// or suspected to contain the fully-qualified pathname of a folder or a file.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class PathnameExtensions
    {
        /// <summary>
        /// Ensures a trailing directory separator is present.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> containing the pathname that is to
        /// be modified.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> ending with a directory
        /// separator; otherwise, the method is idempotent.
        /// </returns>
        [return: NotLogged]
        private static string AppendDirectorySeparatorChar(
            [NotLogged] this string path
        )
        {
            var result = path;

            try
            {
                if (string.IsNullOrWhiteSpace(path)) return string.Empty;

                var sep = Path.DirectorySeparatorChar;
                if (!path.EndsWith(sep.ToString(), StringComparison.Ordinal))
                {
                    result = path + sep;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
                result = path;
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
        /// <see cref="M:Alphaleonis.Win32.Filesystem.File.Exists(System.String)" />
        /// method.  This is due
        /// to the fact that the other method throws an exception if it is passed a blank
        /// string, whereas this method simply returns <see langword="false" />.
        /// </remarks>
        private static bool FileExists([NotLogged] this string pathname)
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

        /// <summary>
        /// Attempts to get the fully-qualified pathname of the containing folder of the
        /// specified <paramref name="file" />.
        /// </summary>
        /// <param name="file">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file for whom the pathname of the containing folder is to be
        /// retrieved.
        /// </param>
        /// <remarks>
        /// If <see langword="null" />, a blank <see cref="T:System.String" />, or the
        /// <see cref="F:System.String.Empty" /> value is passed as the argument of the
        /// parameter, <paramref name="file" />, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// <para />
        /// The method also returns the <see cref="F:System.String.Empty" /> value if an
        /// exception is encountered while attempting to retrieve the containing folder's
        /// pathname.
        /// <para />
        /// <b>NOTE:</b> This method will attempt to discover the fully-qualified pathname
        /// of the folder that contains the specified <paramref name="file" /> regardless
        /// of whether the specified <paramref name="file" /> exists.
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the folder that contains the specified <paramref name="file" />;
        /// otherwise, the method returns the <see cref="F:System.String.Empty" /> value.
        /// </returns>
        [return: NotLogged]
        public static string GetDirectoryName([NotLogged] this string file)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(file)) return result;

                result = Path.GetDirectoryName(file);
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
        /// Computes a relative path string from <paramref name="baseDir" /> to
        /// <paramref name="path" />.
        /// </summary>
        /// <param name="baseDir">
        /// (Required.) A <see cref="T:System.String" /> base directory path.
        /// </param>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> absolute path to be relativized.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> relative path;
        /// <see cref="F:System.String.Empty" /> on failure.
        /// </returns>
        [return: NotLogged]
        public static string GetRelativePath(
            [NotLogged] this string baseDir,
            [NotLogged] string path
        )
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(baseDir)) return result;
                if (string.IsNullOrWhiteSpace(path)) return result;

                var uriBase = new Uri(
                    baseDir.AppendDirectorySeparatorChar(), UriKind.Absolute
                );
                var uriPath = new Uri(path, UriKind.Absolute);
                result = Uri.UnescapeDataString(
                    uriBase.MakeRelativeUri(uriPath)
                           .ToString()
                           .Replace('/', Path.DirectorySeparatorChar)
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
        /// (Required.) One or more <see cref="T:System.String" /> value(s) indicating the
        /// possible extension(s) that the provided <paramref name="pathname" /> must have.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// has the specified filename <paramref name="extensions" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="pathname" /> or <paramref name="extensions" />
        /// have <see langword="null" /> or blank <see cref="T:System.String" /> value(s)
        /// as
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
            [NotLogged] this string pathname,
            [NotLogged] params string[] extensions
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
        /// have <see langword="null" /> or blank <see cref="T:System.String" /> value(s)
        /// as
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
            [NotLogged] this string pathname,
            string extension
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (string.IsNullOrWhiteSpace(extension)) return result;

                result = extension.Equals(
                    Path.GetExtension(pathname),
                    StringComparison.OrdinalIgnoreCase
                );
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
        /// Determines whether the specified <paramref name="target" /> path matches the
        /// specified
        /// <paramref
        ///     name="source" />
        /// path.
        /// </summary>
        /// <remarks>
        /// This method normalizes and resolves the absolute paths of both
        /// <paramref
        ///     name="target" />
        /// and <paramref name="source" />  before performing a case-insensitive
        /// comparison.
        /// <para />
        /// Trailing
        /// directory separator(s), if any are present, are ignored during the comparison.
        /// <para />
        /// <b>NOTE:</b> If either or both of <paramref name="target" /> and
        /// <paramref name="source" /> are <see langword="null" />, blank, or the
        /// <see cref="F:System.String.Empty" /> value, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <param name="target">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the target pathname to compare.
        /// <para />
        /// This parameter cannot be null, empty, or consist only of whitespace.
        /// </param>
        /// <param name="source">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the source path to compare against.
        /// <para />
        /// This parameter cannot be null, empty, or consist only of whitespace.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the normalized, absolute path(s) of
        /// <paramref name="target" /> and
        /// <paramref
        ///     name="source" />
        /// are equal, ignoring case and trailing directory separators; otherwise,
        /// <see
        ///     langword="false" />
        /// .
        /// </returns>
        public static bool MatchesPath(
            [NotLogged] this string target,
            [NotLogged] string source
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(target)) return result;
                if (string.IsNullOrWhiteSpace(source)) return result;

                result = string.Equals(
                    Path.GetFullPath(target)
                        .TrimEnd(
                            Path.DirectorySeparatorChar,
                            Path.AltDirectorySeparatorChar
                        ), Path.GetFullPath(source)
                               .TrimEnd(
                                   Path.DirectorySeparatorChar,
                                   Path.AltDirectorySeparatorChar
                               ), StringComparison.OrdinalIgnoreCase
                );
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