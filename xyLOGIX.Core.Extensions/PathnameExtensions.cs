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
                if (!pathname.FileExists()) return result;

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

        /// <summary>
        /// Replaces the file name component of the specified path with a new file name and
        /// outputs the resulting path.
        /// </summary>
        /// <remarks>
        /// If the directory portion of the provided path does not exist or is invalid, the
        /// method returns false and outputs the original path. The method does not check
        /// whether the new file name is
        /// valid or whether the resulting file exists. No file system changes are
        /// performed; only the path string is
        /// modified.
        /// </remarks>
        /// <param name="pathname">
        /// The full or relative path whose file name will be replaced. Must reference an
        /// existing directory; otherwise,
        /// the operation will not succeed.
        /// </param>
        /// <param name="newFileName">
        /// The new file name to use in place of the original file name in the path. This
        /// should not contain directory
        /// separators.
        /// </param>
        /// <param name="newPath">
        /// When the method returns, contains the path with the file name replaced if
        /// successful; otherwise, contains
        /// the original path.
        /// </param>
        /// <returns>
        /// true if the file name was successfully replaced and the resulting path differs
        /// from the original; otherwise,
        /// false.
        /// </returns>
        public static bool ReplaceFileNameWith(
            this string pathname,
            string newFileName,
            out string newPath
        )
        {
            var result = false;
            newPath = pathname;

            try
            {
                // Replace just the result of calling Path.GetFileName(pathname) with newFileName, and then combine it with the result of calling Path.GetDirectoryName(pathname)
                var directory =
                    Path.GetDirectoryName(
                        Path.GetFullPath(pathname)
                    ); // account for a relative pathname being passed in

                if (string.IsNullOrWhiteSpace(directory))
                {
                    // If the directory is null or whitespace, just return false
                    return result;
                }

                if (!Directory.Exists(directory))
                {
                    // If the directory does not exist, log a warning and return
                    DebugUtils.Write(
                        DebugLevel.Warning,
                        $"Directory '{directory}' does not exist. Cannot replace file name."
                    );
                    return result;
                }

                newPath = Path.Combine(directory, newFileName);
                DebugUtils.Write(
                    DebugLevel.Info,
                    $"Original pathname: '{pathname}'. New pathname: '{newPath}'."
                );

                result = !Path.GetFullPath(pathname)
                              .Equals(newPath);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
                newPath = pathname;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"PathnameExtensions.ReplaceFileNameWith: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Replaces all occurrences of a specified substring, <paramref name="findWhat" />
        /// , with the substring, <paramref name="replaceWith" />, in the file name portion
        /// of the specified <paramref name="pathname" /> and returns the updated file
        /// name.
        /// </summary>
        /// <remarks>
        /// This method does not modify any files on disk; it only returns the new file
        /// name as a
        /// string. The directory specified in <paramref name="pathname" /> must exist for
        /// the operation to succeed. If
        /// the directory does not exist or the file name is invalid, the method returns
        /// false and
        /// <paramref
        ///     name="newFileName" />
        /// is set to <see langword="null" />.
        /// </remarks>
        /// <param name="pathname">
        /// The full or relative path of the file whose file name
        /// will be modified. Must refer to an existing directory.
        /// </param>
        /// <param name="findWhat">
        /// The substring to search for within the file name. All
        /// occurrences will be replaced.
        /// </param>
        /// <param name="replaceWith">
        /// The string to replace each occurrence of the
        /// specified substring in the file name.
        /// </param>
        /// <param name="newFileName">
        /// When this method returns, contains the updated file name with replacements
        /// applied, or the original file
        /// name if no replacements were made. If the directory does not exist or the file
        /// name is invalid, this
        /// parameter is set to <see langword="null" />.
        /// </param>
        /// <returns>
        /// true if the file name was changed as a result of the replacement;
        /// otherwise, false.
        /// </returns>
        public static bool ReplaceInFileName(
            this string pathname,
            string findWhat,
            string replaceWith,
            out string newFileName
        )
        {
            var result = false;
            newFileName = default;

            try
            {
                // Replace the text, findWhat, in the value of Path.GetFileName(pathname) with the text, replaceWith, and then return the new file name in the out parameter, newFileName
                var directory =
                    Path.GetDirectoryName(
                        Path.GetFullPath(pathname)
                    ); // account for a relative pathname being passed in

                if (string.IsNullOrWhiteSpace(directory))
                {
                    // If the directory is null or whitespace, just return false
                    newFileName = default;
                    return result;
                }

                if (!Directory.Exists(directory))
                {
                    // If the directory does not exist, log a warning and return
                    DebugUtils.Write(
                        DebugLevel.Warning,
                        $"Directory '{directory}' does not exist. Cannot replace file name."
                    );
                    newFileName = default;
                    return result;
                }

                var fileName = Path.GetFileName(pathname);

                if (string.IsNullOrWhiteSpace(fileName))
                {
                    // If the file name is null or whitespace, just return false
                    return result;
                }

                newFileName = fileName.Replace(findWhat, replaceWith);

                DebugUtils.Write(
                    DebugLevel.Info,
                    $"Original pathname: '{pathname}'. New file name: '{newFileName}'."
                );
                result = !Path.GetFileName(Path.GetFullPath(pathname))
                              .Equals(newFileName);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
                newFileName = pathname;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"PathnameExtensions.ReplaceInFileName: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Replaces occurrences of a specified substring in the name of the lowest-level
        /// folder containing the file
        /// referenced by the given path, and outputs the modified path.
        /// </summary>
        /// <remarks>
        /// The method does not modify the file system; it only returns the modified path
        /// as a
        /// string. If the directory or its parent does not exist, or if the folder name is
        /// null or whitespace, the
        /// method returns false and outputs the original path. The method handles both
        /// absolute and relative paths.
        /// Exceptions encountered during processing are logged and result in a return
        /// value of false.
        /// </remarks>
        /// <param name="pathname">
        /// The full or relative path to the file whose containing folder name will be
        /// modified. Cannot be null or
        /// whitespace.
        /// </param>
        /// <param name="findWhat">
        /// The substring to search for in the lowest-level folder
        /// name. If not found, no replacement is made.
        /// </param>
        /// <param name="replaceWith">
        /// The substring to replace each occurrence of
        /// <paramref name="findWhat" /> in the folder name.
        /// </param>
        /// <param name="newPath">
        /// When the method returns, contains the path with the modified folder name if the
        /// replacement was successful;
        /// otherwise, contains the original path.
        /// </param>
        /// <returns>
        /// true if the folder name was successfully replaced and the new path was
        /// generated; otherwise, false.
        /// </returns>
        public static bool ReplaceInLowestLevelFolderName(
            this string pathname,
            string findWhat,
            string replaceWith,
            out string newPath
        )
        {
            var result = false;
            newPath = pathname;

            try
            {
                // Replace the text, findWhat, in the name of the lowest-level folder containing the file having the specified pathname, with the text, replaceWith, and then combine it with the result of calling Path.GetFileName(pathname)
                var directory =
                    Path.GetDirectoryName(
                        Path.GetFullPath(pathname)
                    ); // account for a relative pathname being passed in

                if (string.IsNullOrWhiteSpace(directory))
                {
                    // If the directory is null or whitespace, just return false
                    newPath = pathname;
                    return result;
                }

                if (!Directory.Exists(directory))
                {
                    // If the directory does not exist, log a warning and return
                    DebugUtils.Write(
                        DebugLevel.Warning,
                        $"Directory '{directory}' does not exist. Cannot replace folder name."
                    );
                    newPath = pathname;
                    return result;
                }

                var parentDirectory = Path.GetDirectoryName(directory);

                if (string.IsNullOrWhiteSpace(parentDirectory))
                {
                    // If the parent directory is null or whitespace, just return false
                    newPath = pathname;
                    return result;
                }

                if (!Directory.Exists(parentDirectory))
                {
                    // If the parent directory does not exist, log a warning and return
                    DebugUtils.Write(
                        DebugLevel.Warning,
                        $"Parent directory, '{parentDirectory}', does not exist. Cannot replace folder name."
                    );
                    newPath = pathname;
                    return result;
                }

                var folderName = Path.GetFileName(directory);

                if (string.IsNullOrWhiteSpace(folderName))
                {
                    // If the folder name is null or whitespace, just return false
                    newPath = pathname;
                    return result;
                }

                var newFolderName = folderName.Replace(findWhat, replaceWith);
                newPath = Path.Combine(parentDirectory, newFolderName);
                DebugUtils.Write(
                    DebugLevel.Info,
                    $"Original pathname: '{pathname}'. New pathname: '{newPath}'."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
                newPath = pathname;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"PathnameExtensions.ReplaceInFolderName: Result = {result}"
            );

            return result;
        }
    }
}