using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static method(s) to transform text strings in various ways.
    /// </summary>
    public static class Transform
    {
        /// <summary>
        /// A regular expression pattern that matches an entire string consisting only of
        /// uppercase letters.
        /// This pattern is useful for identifying acronyms (e.g., "NASA", "AI", "RADAR")
        /// that appear as
        /// standalone words without any lowercase letters.
        /// <para>
        /// This pattern ensures that the input string contains only uppercase letters from
        /// A to Z
        /// and does not include numbers, spaces, or lowercase characters.
        /// </para>
        /// </summary>
        public const string AcronymPattern = @"^[A-Z]+$";

        /// <summary>
        /// A regular expression pattern that matches words in an initial-caps formatted
        /// string.
        /// This pattern identifies:
        /// <list type="bullet">
        ///     <item>
        ///         <description>All-uppercase acronyms (e.g., "NASA", "AI", "RADAR").</description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///         Capitalized words that follow PascalCase or CamelCase
        ///         conventions (e.g., "Research", "Lab").
        ///         </description>
        ///     </item>
        /// </list>
        /// The matched words can be used to transform an initial-caps string into a
        /// space-separated phrase
        /// while preserving acronyms.
        /// </summary>
        public const string InitialCapsWordPattern =
            @"[A-Z]+(?![a-z])|[A-Z][a-z]*";

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.Transform" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Transform() { }

        /// <summary>
        /// Converts an initial-caps string into a space-separated, lowercase phrase,
        /// preserving acronyms.
        /// </summary>
        /// <param name="input">The initial-caps string to be transformed. (Required.)</param>
        /// <returns>
        /// A <see cref="T:System.String" /> where all words are separated by spaces.
        /// Acronyms remain in uppercase while other words are converted to lowercase.
        /// If <paramref name="input" /> is <see langword="null" /> or empty, an empty
        /// string is returned.
        /// </returns>
        [Log(AttributeExclude = true)]
        [return: NotLogged]
        public static string PascalCasedTextToPhrase([NotLogged] string input)
        {
            var result = input; //idempotent if input is null or empty

            try
            {
                /*
                 * DO NOT CREATE LOGGING STATEMENTS FOR THIS METHOD
                 */

                if (string.IsNullOrWhiteSpace(input))
                    return result;

                /*
                 * The 'working value' to which to set the result if our transformation
                 * process works.  We start out with the empty string by default, and then
                 * build it up as we process the input.
                 */

                var output = string.Empty;

                // Match uppercase acronyms, capitalized words, and uppercase-to-lowercase transitions
                var matches = Regex.Matches(input, InitialCapsWordPattern);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        // Preserve acronyms (all-uppercase words)
                        if (Regex.IsMatch(match.Value, AcronymPattern))
                            output += match.Value + " ";
                        else
                            output += match.Value.ToLower() + " ";
                    }

                    // Trim trailing space
                    output = output.Trim();
                }

                /* If the 'output' variable is still null, empty, or contains only whitespace,
                 * then we'll return the original input string.  Otherwise, we'll return the
                 * 'output' variable.
                 */
                result = string.IsNullOrWhiteSpace(output) ? input : output;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = input; // idempotent if an exception occurred
            }

            return result;
        }
    }
}