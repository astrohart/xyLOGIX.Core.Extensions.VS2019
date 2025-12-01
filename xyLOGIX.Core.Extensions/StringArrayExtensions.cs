using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="T:System.String[]" /> arrays.
    /// </summary>
    public static class StringArrayExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.StringArrayExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static StringArrayExtensions() { }

        /// <summary>
        /// Dumps the contents of the specified <see cref="T:System.String[]" />
        /// array to the application log.
        /// </summary>
        /// <param name="values">
        /// (Required.) Reference to the <see cref="T:System.String[]" /> whose
        /// contents are to be logged.
        /// </param>
        [DebuggerStepThrough]
        public static void DumpToLog([NotLogged] this string[] values)
        {
            try
            {
                if (values == null) return;
                if (values.Length <= 0) return;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"(Dumping {values.Length} value(s) to log...)"
                );

                for (var i = 0; i < values.Length; i++)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Debug, $"[{i}]: '{values[i]}'"
                    );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Replaces all occurrences of a specified substring with another
        /// substring in each string within the provided <paramref name="target" />
        /// collection.
        /// </summary>
        /// <remarks>
        /// This method processes each string in the collection individually.
        /// <para />
        /// If a string in the collection  is <see langword="null" />, the
        /// <see cref="F:System.String.Empty" /> value, or consists only of whitespace, it
        /// is included in the resultset without modification.
        /// </remarks>
        /// <param name="target">
        /// The collection of strings to process.
        /// <para />
        /// If <paramref name="target" /> is <see langword="null" />, an empty collection
        /// is returned.
        /// </param>
        /// <param name="findWhat">
        /// The substring to find within each string. If
        /// <paramref name="findWhat" /> is <see langword="null" /> or empty, no
        /// replacements are performed.
        /// </param>
        /// <param name="replaceWith">
        /// The substring to replace <paramref name="findWhat" />
        /// with.
        /// <para />
        /// If <paramref name="replaceWith" /> is <see langword="null" />, it is treated as
        /// an empty string.
        /// </param>
        /// <returns>
        /// An <see cref="T:System.Collections.Generic.IEnumerable`1" />
        /// containing the string(s) with the specified replacements applied.
        /// <para />
        /// String(s) that are <see langword="null" />, the
        /// <see cref="F:System.String.Empty" /> value, or whitespace in the
        /// <paramref name="target" /> collection are returned unchanged.
        /// </returns>
        public static IEnumerable<string> ReplaceInAll(
            this IEnumerable<string> target,
            string findWhat,
            string replaceWith
        )
        {
            if (target == null) yield break;
            if (!target.Any()) yield break;

            foreach (var item in target)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    yield return item;
                    continue;
                }

                yield return item.Replace(findWhat, replaceWith);
            }
        }
    }
}