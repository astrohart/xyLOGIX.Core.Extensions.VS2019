using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions.Properties;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using File = Alphaleonis.Win32.Filesystem.File;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Provides methods and properties to assist with manipulating strings
    /// of text.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class StringExtensions
    {
        /// <summary> Collection of strings that are commonly-used acronyms. </summary>
        private static readonly string[] AcronymList =
        {
            "AP", "BC", "AB", "4S", "N", "S", "E", "W", "NE", "SE", "SW",
            "NW", "NNW", "NNE", "ENE", "ESE", "SSE", "SSW", "WSW", "WNW",
            "IB", "LSAT", "GMAT", "ACT", "SAT", "GRE", "MCAT", "TOEFL",
            "PSAT", "CBEST", "CEST", "APA", "ADA", "AMA", "RP", "RB", "RFS",
            "EE", "CS", "EECS", "ECE", "UC", "SDSU", "UCSB", "UCSD", "UCD",
            "CSU", "UCM", "UCR", "UCI", "UCSF", "UCSC", "UCLA", "USC",
            "USD", "CSUF", "CSULA", "CSUDH", "CSUNR", "HS", "LLC"
        };

        /// <summary>
        /// Collection of strings that should always be capitalized if they are
        /// the first word of a phrase.
        /// </summary>
        private static readonly string[] AlwaysCapitalizeIfFirstWord = { "El" };

        /// <summary>
        /// Collection of strings that are potentially needing to be capitalized
        /// if they are the first word of a phrase or a name.
        /// </summary>
        private static readonly string[] CapitalizeableAsFirstWords =
        {
            "Al", "A", "The", "Of", "An", "On", "With", "La", "De", "Or",
            "And", "Not"
        };

        /// <summary>
        /// A <see cref="T:System.String" /> containing a regular expression to match a
        /// GUID that is in all lowercase with no surrounding braces; e.g., for example,
        /// <c>b8f967ce-911d-4184-a0ba-b37e443b4541</c>.
        /// </summary>
        private const string GuidRegexLowercaseNoBraces =
            @"[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}";

        /// <summary>
        /// Collection of strings that contain words commonly found in the name
        /// of a street, and that need to be capitalized.
        /// </summary>
        private static readonly string[] NamesOfStreetsThatShouldBeCapitalized =
        {
            "St", "Rd", "Ave", "Blvd", "Pl", "Pky", "Pkwy", "Ct", "Ter",
            "Cir", "Hwy", "I-", "Dr", "Drwy", "Drvwy", "Pk", "Ln", "Fe",
            "Street", "Road", "Avenue", "Avenida", "Boulevard", "Place",
            "Rue", "Vieux", "Parkway", "Court", "Terrace", "Circle",
            "Highway", "Drive", "Driveway", "Pike", "Lane"
        };

        /// <summary>
        /// Collection of strings which are short words but are not acronyms per
        /// se.
        /// </summary>
        public static readonly string[] ShortWordsThatAreNotAcronyms =
        {
            "a", "an", "and", "of", "or", "the", "this", "that", "o", "O\'",
            "al-", "el-", "thus", "if", "then", "Jr.", "Sr.", "Ph.D.",
            "M.S.", "M.D."
        };

        /// <summary>
        /// Collection of strings that are the two-letter abbreviations of the 50
        /// U.S. states.
        /// </summary>
        private static readonly string[] StateAbbrList =
        {
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
            "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
            "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
            "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
            "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY",
            "DC", "PR", "VI", "AS", "GU", "MP"
        };

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.StringExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static StringExtensions()

            // Only initialize a new instance of the IdnMapping once per execution of a client 
            // application.
            => DomainMappingObject = new IdnMapping();

        private static IdnMapping DomainMappingObject
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.Text.RegularExpressions.Regex" /> that is compiled to match
        /// a <see cref="T:System.String" /> that ends with a colon (<c>:</c>) and then a
        /// natural number.
        /// </summary>
        private static Regex EndsWithColonAndNumberRegex
        {
            [DebuggerStepThrough] get;
        } = new Regex(@":\d+$", RegexOptions.Compiled);

        /// <summary>
        /// Gets or sets a value that indicates whether the string most recently
        /// checked for whether it contains a valid email address, does in fact contain
        /// such a valid address.
        /// </summary>
        public static bool IsEmailAddressInvalid
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] private set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Text.RegularExpressions.Regex" /> that
        /// matches all whitespace characters.
        /// </summary>
        private static Regex WhiteSpaceRegex { [DebuggerStepThrough] get; } =
            new Regex(@"\s+");

        /// <summary>
        /// Asks if the search text, in <paramref name="value" />, is a substring
        /// of the strings in <paramref name="collection" />, ignoring case.
        /// </summary>
        /// <param name="collection"> Collection to search. </param>
        /// <param name="value"> Value to compare. </param>
        /// <returns>
        /// <see langword="true" /> if the indicated value is in the specified
        /// collection, regardless of case; <see langword="false" /> otherwise.
        /// </returns>
        public static bool AnyContainNoCase(
            this IEnumerable<string> collection,
            string value
        )
            => collection.Any(s => s.ContainsNoCase(value));

        /// <summary>
        /// Determines if any of the <see cref="T:System.String" />s in
        /// <paramref name="targets" /> start with any of the specified
        /// <paramref name="values" />.
        /// </summary>
        /// <param name="targets">
        /// (Required.) Collection of <see cref="T:System.String" />
        /// value(s) that are to be searched.
        /// </param>
        /// <param name="values">
        /// (Required.) One or more <see cref="T:System.String" />
        /// value(s) that are to be used as search criteria.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed as the argument of
        /// the <paramref name="targets" /> parameter, of if either of the
        /// <paramref name="targets" /> or <paramref name="values" /> parameter(s) refer to
        /// the empty collection, then this method returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" />if any of the <paramref name="targets" /> start
        /// with any of the <paramref name="values" />; <see langword="false" /> otherwise.
        /// </returns>
        public static bool AnyStartWithAny(
            this IEnumerable<string> targets,
            params string[] values
        )
        {
            var result = false;

            try
            {
                if (targets == null) return result;
                if (targets.ToArray()
                           .Length <= 0) return result;
                if (values.Length <= 0) return result;

                foreach (var target in targets.ToArray())
                {
                    if (string.IsNullOrWhiteSpace(target)) continue;
                    if (!target.StartsWithAny(values)) continue;

                    result = true;
                    break;
                }
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
        /// Determines if the specified <paramref name="value" /> contains any letters that
        /// are recognized as lowercase.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> whose
        /// characters are to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> has
        /// at least one lowercase letter; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool AreAnyLettersLowercase(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                for (var i = 0; i < value.Length; i++)
                {
                    if (!char.IsLower(value[i])) continue;

                    /*
                     * If we are here, then we've encountered a lowercase letter.
                     */
                    result = true;
                    break;
                }
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
        /// Attempts to express the provided <see cref="T:System.String" />
        /// <paramref name="value" /> as a <see cref="T:System.Decimal" /> value.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the ASCII representation of a <see cref="T:System.Decimal" /> value.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Decimal" /> value that corresponds to what is
        /// represented by the ASCII <paramref name="value" /> specified; or
        /// <see cref="F:System.Decimal.MinValue" /> if an issue occurred in formatting the
        /// value.
        /// </returns>
        public static decimal AsDecimal(this string value)
        {
            var result = decimal.MinValue;

            try
            {
                if (string.IsNullOrWhiteSpace(value))
                    return result;

                result = Convert.ToDecimal(value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = decimal.MinValue;
            }

            return result;
        }

        /// <summary>
        /// Attempts to express the provided <see cref="T:System.String" />
        /// <paramref name="value" /> as a <see cref="T:System.Double" /> value.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the ASCII representation of a <see cref="T:System.Double" /> value.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Double" /> value that corresponds to what is
        /// represented by the ASCII <paramref name="value" /> specified; or
        /// <see cref="F:System.Double.MinValue" /> if an issue occurred in formatting the
        /// value.
        /// </returns>
        public static double AsDouble(this string value)
        {
            var result = double.MinValue;

            try
            {
                if (string.IsNullOrWhiteSpace(value))
                    return result;

                result = Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = double.MinValue;
            }

            return result;
        }

        /// <summary>
        /// Takes a quote and a selector function and exports a string that is
        /// comma-separated according to proper English grammar, i.e.
        /// <c> "dog, cat, and horse" </c> not just <c>"dog, cat, horse."</c>
        /// </summary>
        /// <typeparam name="TSource"> Type of each item in the quote collection. </typeparam>
        /// <param name="quote">
        /// Collection of <typeparamref name="TSource" /> to iterate
        /// over.
        /// </param>
        /// <param name="selectorFunc">
        /// Delegate specifying the way to represent each
        /// element of the collection <paramref name="quote" /> as a string.
        /// </param>
        /// <returns>
        /// String containing the strings selected by the selector, as
        /// illustrated above.
        /// </returns>
        /// <remarks>
        /// If this method is fed a <see langword="null" /> reference or the
        /// empty collection for <paramref name="quote" />, then the return value is the
        /// empty string.
        /// </remarks>
        public static string AsProseList<TSource>(
            this IEnumerable<TSource> quote,
            Func<TSource, string> selectorFunc
        )
        {
            if (quote == null) return string.Empty;

            if (!(quote is IList<TSource> items))
                items = quote.ToAdvisableCollection();

            // If we are passed the empty collection, then return the empty
            // string as the result.
            if (!items.Any()) return string.Empty;

            var itemStrings = items.Select(selectorFunc)
                                   .Distinct()
                                   .ToAdvisableCollection();
            var result = string.Join(
                items.Count > 2 ? ", " : " and ", itemStrings
            );

            if (!result.Contains(",") || items.Count <= 2)
                return result;
            var start = result.LastIndexOf(',');
            result = new StringBuilder(result).Replace(
                                                  ", ", ", and ", start,
                                                  result.Length - start
                                              )
                                              .ToString();

            return result;
        }

        /// <summary>
        /// Breaks a large body of <paramref name="text" /> into individual
        /// lines, on the newline character for the particular operating system. The result
        /// is a collection of strings, one for each line.
        /// </summary>
        /// <param name="text"> (Required.) String containing the text to be split. </param>
        /// <returns>
        /// Collection of strings containing one string per line of
        /// <paramref name="text" />.
        /// </returns>
        /// <remarks>
        /// If this method is passed the empty string or a blank string as input,
        /// then it returns the empty collection.
        /// </remarks>
        public static IEnumerable<string> BreakTextIntoLines(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return Enumerable.Empty<string>();

            text = text.Replace("\r\n", "\n");
            var result = text.Split('\n')
                             .ToAdvisableCollection();
            if (result.Any())
                result = result.Select(TrimLine)
                               .ToAdvisableCollection();

            return result;
        }

        /// <summary>
        /// Strips newlines from the text in <paramref name="line" />, and then
        /// calls <see cref="T:System.String.Trim" /> on the results.
        /// </summary>
        /// <param name="line"> Text to clean. </param>
        /// <returns>
        /// Same as input, except all newline characters and whitespace has been
        /// removed.
        /// </returns>
        /// <remarks>
        /// If the empty string is provided as input, then the empty string is
        /// returned.
        /// </remarks>
        public static string CleanLine(this string line)
        {
            var result = string.Empty;
            if (string.IsNullOrWhiteSpace(line))
                return result;

            result = line.Replace("\r", string.Empty);
            result = result.Replace("\n", string.Empty);
            result = result.Trim();

            return result;
        }

        /// <summary>
        /// "Collapses" or "folds" the specified <paramref name="value" /> so that all
        /// newlines are transformed to single whitespace characters.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// value that is to be collapsed.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the value passed, but with
        /// all newlines transformed to single whitespace characters.
        /// <para />
        /// Multiple newlines are removed.
        /// </returns>
        public static string CollapseNewlinesToSpaces(this string value)
        {
            string result;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return value;

                result = value.Trim()
                              .Replace("\r\n", "\n")
                              .Replace("\n\n", "\n")
                              .Replace("\n", " ")
                              .Replace("\t", " ");

                /*
                 * Strip out all repeating SPACE characters.
                 */

                do
                {
                    result = result.Replace("  ", " ");
                } while (result.Contains("  "));
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
        /// Takes the specified <paramref name="initialString" /> and joins the provided
        /// <see cref="T:System.String" /> <paramref name="parts" /> array of strings onto
        /// it, in the order specified.
        /// </summary>
        /// <param name="initialString">
        /// (Required.) A <see cref="T:System.String" /> that
        /// specifies the initial value to have other <see cref="T:System.String" /> values
        /// concatenated to it.
        /// </param>
        /// <param name="parts">
        /// (Required.) One or more <see cref="T:System.String" />
        /// values that are to be concatenated, in the order specified, to the
        /// <paramref name="initialString" />.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> consisting of the
        /// <paramref name="initialString" /> with the <paramref name="parts" />
        /// concatenated to it.
        /// </returns>
        /// <remarks>
        /// This method does nothing if the <paramref name="initialString" /> is
        /// blank or <see langword="null" />, or if there are zero values in the
        /// <paramref name="parts" />.
        /// </remarks>
        public static string Concat(
            this string initialString,
            params string[] parts
        )
        {
            var result = initialString;

            try
            {
                if (string.IsNullOrWhiteSpace(initialString)) return result;
                if (parts == null) return result;
                if (parts.Length <= 0) return result;

                result = parts.Aggregate(
                    result, (current, part) => current + part
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = initialString;
            }

            return result;
        }

        /// <summary>
        /// Returns <see langword="true" /> if the <paramref name="value" /> has
        /// any of the strings in <paramref name="searchStrings" /> as a substring.
        /// </summary>
        /// <param name="value"> (Required.) The value to be used as a filter. </param>
        /// <param name="searchStrings">
        /// (Required.) Collection of strings, any of which
        /// might be substrings of <paramref name="value" />.
        /// </param>
        /// <returns>
        /// Value indicating whether any of the strings in
        /// <paramref name="searchStrings" /> are substrings (case-insensitive) of
        /// <paramref name="value" />.
        /// </returns>
        /// <remarks>
        /// If <paramref name="value" /> is the empty string or if the
        /// <paramref name="searchStrings" /> collection is empty or is a
        /// <see langword="null" /> reference, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool ContainsAny(
            this string value,
            params string[] searchStrings
        )
            => ContainsAnyOf(value, searchStrings);

        /// <summary>
        /// Returns <see langword="true" /> if the <paramref name="value" /> has
        /// any of the strings in <paramref name="searchStrings" /> as a substring.
        /// </summary>
        /// <param name="value"> (Required.) The value to be used as a filter. </param>
        /// <param name="searchStrings">
        /// (Required.) Collection of strings, any of which
        /// might be substrings of <paramref name="value" />.
        /// </param>
        /// <returns>
        /// Value indicating whether any of the strings in
        /// <paramref name="searchStrings" /> are substrings (case-insensitive) of
        /// <paramref name="value" />.
        /// </returns>
        /// <remarks>
        /// If <paramref name="value" /> is the empty string or if the
        /// <paramref name="searchStrings" /> collection is empty or is a
        /// <see langword="null" /> reference, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool ContainsAny(
            this string value,
            IEnumerable<string> searchStrings
        )
            => ContainsAnyOf(value, searchStrings);

        /// <summary>
        /// Returns <see langword="true" /> if the <paramref name="value" />
        /// contains any of the characters in <paramref name="searchChars" />
        /// (case-insensitive).
        /// </summary>
        /// <param name="value"> (Required.) String to be searched. </param>
        /// <param name="searchChars">
        /// (Required.) Array of characters to look for in the
        /// <paramref name="value" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the string in <paramref name="value" />
        /// contains any of the characters (case-insensitive) in the
        /// <paramref name="searchChars" /> array; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If this method is passed the empty string for
        /// <paramref name="value" /> or a <see langword="null" /> reference or an empty
        /// collection for <paramref name="searchChars" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool ContainsAny(this string value, char[] searchChars)
            => ContainsAnyOf(value, searchChars);

        /// <summary>
        /// Returns <see langword="true" /> if the <paramref name="value" /> has
        /// any of the strings in <paramref name="searchStrings" /> as a substring.
        /// </summary>
        /// <param name="value"> (Required.) The value to be used as a filter. </param>
        /// <param name="searchStrings">
        /// (Required.) Collection of strings, any of which
        /// might be substrings of <paramref name="value" />.
        /// </param>
        /// <returns>
        /// Value indicating whether any of the strings in
        /// <paramref name="searchStrings" /> are substrings (case-insensitive) of
        /// <paramref name="value" />.
        /// </returns>
        /// <remarks>
        /// If <paramref name="value" /> is the empty string or if the
        /// <paramref name="searchStrings" /> collection is empty or is a
        /// <see langword="null" /> reference, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool ContainsAnyOf(
            this string value,
            IEnumerable<string> searchStrings
        )
            => !string.IsNullOrWhiteSpace(value) && searchStrings != null &&
               searchStrings.Any(item => ContainsNoCase(value, item));

        /// <summary>
        /// Returns <see langword="true" /> if the <paramref name="value" /> has
        /// any of the strings in <paramref name="searchStrings" /> as a substring.
        /// </summary>
        /// <param name="value"> (Required.) The value to be used as a filter. </param>
        /// <param name="searchStrings">
        /// (Required.) Collection of strings, any of which
        /// might be substrings of <paramref name="value" />.
        /// </param>
        /// <returns>
        /// Value indicating whether any of the strings in
        /// <paramref name="searchStrings" /> are substrings (case-insensitive) of
        /// <paramref name="value" />.
        /// </returns>
        /// <remarks>
        /// If <paramref name="value" /> is the empty string or if the
        /// <paramref name="searchStrings" /> collection is empty or is a
        /// <see langword="null" /> reference, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public static bool ContainsAnyOf(
            this string value,
            params string[] searchStrings
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (searchStrings == null || !searchStrings.Any())
                    return result;

                result = ContainsAnyOf(
                    value, (IEnumerable<string>)searchStrings
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
        /// Returns <see langword="true" /> if the <paramref name="value" />
        /// contains any of the characters in <paramref name="searchChars" />
        /// (case-insensitive).
        /// </summary>
        /// <param name="value"> (Required.) String to be searched. </param>
        /// <param name="searchChars">
        /// (Required.) Array of characters to look for in the
        /// <paramref name="value" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the string in <paramref name="value" />
        /// contains any of the characters (case-insensitive) in the
        /// <paramref name="searchChars" /> array; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If this method is passed the empty string for
        /// <paramref name="value" /> or a <see langword="null" /> reference or an empty
        /// collection for <paramref name="searchChars" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool ContainsAnyOf(this string value, char[] searchChars)
            => !string.IsNullOrWhiteSpace(value) && searchChars != null &&
               searchChars.Any(item => ContainsNoCase(value, item));

        /// <summary> Searches one string for another. Case-insensitive. </summary>
        /// <param name="stringToSearch"> The string to be searched. </param>
        /// <param name="value"> Value to search for. </param>
        /// <returns>
        /// Returns true if the stringToSearch contains the substring value,
        /// regardless of case; false otherwise.
        /// </returns>
        public static bool ContainsNoCase(
            this string stringToSearch,
            string value
        )
            => !string.IsNullOrWhiteSpace(stringToSearch) &&
               !string.IsNullOrWhiteSpace(value) && stringToSearch
                                                    .ToLowerInvariant()
                                                    .Contains(
                                                        value.ToLowerInvariant()
                                                    );

        /// <summary> Searches one string for another. Case-insensitive. </summary>
        /// <param name="stringToSearch"> The string to be searched. </param>
        /// <param name="value"> Value to search for. </param>
        /// <returns>
        /// Returns true if the stringToSearch contains the substring value,
        /// regardless of case; false otherwise.
        /// </returns>
        public static bool ContainsNoCase(
            this string stringToSearch,
            char value
        )
            => !string.IsNullOrWhiteSpace(stringToSearch) && stringToSearch
                .ToLowerInvariant()
                .Contains(
                    value.ToString()
                         .ToLowerInvariant()
                );

        /// <summary> Case-insensitive version of the collection Contains method. </summary>
        /// <param name="collection"> Collection to search. </param>
        /// <param name="value"> Value to compare. </param>
        /// <returns>
        /// TRUE if the indicated value is in the specified collection,
        /// regardless of case; FALSE otherwise.
        /// </returns>
        public static bool ContainsNoCase(
            this IEnumerable<string> collection,
            string value
        )
            => collection != null &&
               collection.Any(s => EqualsNoCase(s, value));

        /// <summary>
        /// Ascertains whether the specified <see cref="T:System.String" />,
        /// provided as the argument to the <paramref name="value" /> parameter, contains
        /// any digits.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> that is to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" />q if the <see cref="T:System.String" /> passed
        /// contains any digits.
        /// </returns>
        public static bool ContainsNumbers(this string value)
        {
            var result = false;

            try
            {
                return !string.IsNullOrWhiteSpace(value) &&
                       value.Any(char.IsDigit);
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
        /// Helper method to aid in transforming text casing of a string to
        /// Initial Caps.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the word that needs to be
        /// initial-capitalized.
        /// </param>
        /// <returns>
        /// Word provided in <paramref name="value" /> with its first letter
        /// replaced with a capital letter and all the remaining letters as lowercase.
        /// </returns>
        /// <remarks>
        /// If this method is provided with the empty or whitespace string, then
        /// this method returns the empty string.
        /// </remarks>
        private static string DoInitialCaps(string value)
            => string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : value[0]
                  .ToString(CultureInfo.InvariantCulture)
                  .ToUpper() + value.ToLowerInvariant()
                                    .Substring(1, value.Length - 1);

        /// <summary> Helper for determining whether strings contain valid email addresses. </summary>
        /// <param name="match">
        /// Reference to an instance of
        /// <see cref="T:System.Text.RegularExpressions.Match" /> that resulted from a
        /// regex search.
        /// </param>
        /// <returns> Correctly-formatted domain-name matching value. </returns>
        /// <remarks>
        /// This method also sets the value of the
        /// <see cref="P:xyLOGIX.Core.Extensions.StringExtensions.IsEmailAddressInvalid" />
        /// property to <see langword="true" /> in the event that an error occurs.
        /// </remarks>
        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.

            var domainName = match.Groups[2].Value;

            try
            {
                if (match == null) return domainName;
                if (string.IsNullOrWhiteSpace(domainName)) return domainName;

                domainName = DomainMappingObject.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                IsEmailAddressInvalid = true;
            }

            return match.Groups[1].Value + domainName;
        }

        /// <summary>
        /// Determines if the specified <see cref="T:System.String" />
        /// <paramref name="value" /> ends with any of the specified
        /// <paramref name="endings" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the value to be
        /// checked.
        /// </param>
        /// <param name="endings">
        /// (Required.) One or more <see cref="T:System.String" />
        /// elements, each of which is to be assessed against the specified
        /// <paramref name="value" /> as being what it ends with.
        /// </param>
        /// <remarks>
        /// <b>NOTE:</b> This method returns <see langword="false" /> if no values are
        /// passed for
        /// <paramref name="endings" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// ends with any of the specified <paramref name="endings" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool EndsWithAny(
            this string value,
            params string[] endings
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (endings == null) return result;
                if (endings.Length <= 0) return result;

                foreach (var ending in endings)
                {
                    if (string.IsNullOrWhiteSpace(ending)) continue;
                    if (!value.EndsWith(ending)) continue;

                    result = true;
                    break;
                }
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
        /// Determines if the specified <see cref="T:System.String" />
        /// <paramref name="value" /> ends with any of the specified
        /// <paramref name="endings" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the value to be
        /// checked.
        /// </param>
        /// <param name="endings">
        /// (Required.) One or more <see cref="T:System.String" />
        /// elements, each of which is to be assessed against the specified
        /// <paramref name="value" /> as being what it ends with.
        /// </param>
        /// <remarks>
        /// <b>NOTE:</b> This method returns <see langword="false" /> if no values are
        /// passed for
        /// <paramref name="endings" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// ends with any of the specified <paramref name="endings" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool EndsWithAny(
            this string value,
            IEnumerable<string> endings
        )
            => EndsWithAny(value, endings.ToArray());

        /// <summary>
        /// Determines if the specified <see cref="T:System.String" />
        /// <paramref name="value" /> ends with any of the specified
        /// <paramref name="endings" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the value to be
        /// checked.
        /// </param>
        /// <param name="endings">
        /// (Required.) One or more <see cref="T:System.String" />
        /// elements, each of which is to be assessed against the specified
        /// <paramref name="value" /> as being what it ends with.
        /// </param>
        /// <remarks>
        /// <b>NOTE:</b> This method returns <see langword="false" /> if no values are
        /// passed for
        /// <paramref name="endings" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// ends with any of the specified <paramref name="endings" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool EndsWithAnyOf(
            this string value,
            params string[] endings
        )
            => EndsWithAny(value, endings);

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> ends with a colon
        /// and a number.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> that is set to
        /// the value that is to be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" />if the specified <paramref name="value" /> ends
        /// with a colon and a number; <see langword="false" /> otherwise.
        /// </returns>
        public static bool EndsWithColonAndNumber(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                result = EndsWithColonAndNumberRegex.IsMatch(value);
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
        /// Double-checks a <paramref name="twitterSite" /> (at-mention) string
        /// to make sure it begins with the character '@'.
        /// </summary>
        /// <param name="twitterSite"> (Required.) Twitter handle to at-mention. </param>
        /// <returns>
        /// String containing the same value as in
        /// <paramref name="twitterSite" /> , but one which is guaranteed to start with the
        /// '@' character.
        /// </returns>
        /// <remarks>
        /// If this method is passed the empty string, then the result is the
        /// empty string.
        /// </remarks>
        public static string EnsureAtIsInFront(string twitterSite)
        {
            if (string.IsNullOrWhiteSpace(twitterSite)) return string.Empty;

            twitterSite =
                $"via @{twitterSite.Trim().Replace("@", string.Empty)}";
            return twitterSite;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is equal to,
        /// respecting case, any of the item(s) in the specified <paramref name="list" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// value that is to be examined.
        /// </param>
        /// <param name="list">
        /// (Required.) One or more <see cref="T:System.String" />
        /// value(s) that are to be checked for equality without regard to case.
        /// </param>
        /// <remarks>
        /// If nothing is passed for the <paramref name="list" /> parameter, then
        /// the method returns <see langword="false" />.
        /// <para />
        /// If the value is the <see langword="null" />, blank, or
        /// <see cref="F:System.String.Empty" /> value, and one of the element(s) of the
        /// <paramref name="list" /> is also, then this method returns
        /// <see langword="true" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if one of the element(s) of the specified
        /// <paramref name="list" /> matches the value, accounting for character casing;
        /// otherwise, <see langword="false" />.
        /// </returns>
        public static bool EqualsAnyOf(
            [NotLogged] this string value,
            [NotLogged] params string[] list
        )
        {
            var result = false;

            try
            {
                if (list == null) return result;
                if (list.Length <= 0) return result;

                foreach (var item in list)
                {
                    /* special case: if the current item is null or
                     blank, and so is the value, then return true
                     immediately */
                    if (string.IsNullOrWhiteSpace(item) &&
                        string.IsNullOrWhiteSpace(value)) return true;

                    if (!item.Equals(value, StringComparison.Ordinal)) continue;

                    result = true;
                    break;
                }
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
        /// Determines whether the specified <paramref name="value" /> is equal to,
        /// regardless of case, any of the item(s) in the specified
        /// <paramref name="list" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// value that is to be examined.
        /// </param>
        /// <param name="list">
        /// (Required.) One or more <see cref="T:System.String" />
        /// value(s) that are to be checked for equality without regard to case.
        /// </param>
        /// <remarks>
        /// If nothing is passed for the <paramref name="list" /> parameter, then
        /// the method returns <see langword="false" />.
        /// <para />
        /// If the value is the <see langword="null" />, blank, or
        /// <see cref="F:System.String.Empty" /> value, and one of the element(s) of the
        /// <paramref name="list" /> is also, then this method returns
        /// <see langword="true" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if one of the element(s) of the specified
        /// <paramref name="list" /> matches the value, regardless of case; otherwise,
        /// <see langword="false" />.
        /// </returns>
        public static bool EqualsAnyOfNoCase(
            [NotLogged] this string value,
            [NotLogged] params string[] list
        )
        {
            var result = false;

            try
            {
                if (list == null) return result;
                if (list.Length <= 0) return result;

                foreach (var item in list)
                {
                    /* special case: if the current item is null or
                     blank, and so is the value, then return true
                     immediately */
                    if (string.IsNullOrWhiteSpace(item) &&
                        string.IsNullOrWhiteSpace(value)) return true;

                    /*
                     * otherwise, skip the current item if it isn't equal
                     * to the value, regardless of case.
                     */
                    if (!item.Equals(
                            value, StringComparison.OrdinalIgnoreCase
                        )) continue;

                    result = true;
                    break;
                }
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
        /// A case-insensitive equality comparer for strings. Basically, converts
        /// each of its operands to lowercase before comparing.
        /// </summary>
        /// <param name="str1"> First string to compare. </param>
        /// <param name="str2"> Second string to compare. </param>
        /// <returns> Whether the two strings are the same, regardless of case. </returns>
        public static bool EqualsNoCase(this string str1, string str2)
        {
            var result = false;

            try
            {
                result =
                    string.IsNullOrWhiteSpace(str1) ||
                    string.IsNullOrWhiteSpace(str2)
                        ? string.IsNullOrWhiteSpace(str1) &&
                          string.IsNullOrWhiteSpace(str2)
                        : str2.Equals(str1, StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"StringExtensions.EqualsNoCase: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// A case-insensitive equality comparer for strings. Basically, converts
        /// each of its operands to lowercase before comparing.
        /// </summary>
        /// <param name="str1"> First string to compare. </param>
        /// <param name="str2"> Second string to compare. </param>
        /// <param name="comparisonType">
        /// One of the
        /// <see cref="T:System.StringComparison" /> values saying how the strings are to
        /// be compared.
        /// </param>
        /// <returns> Whether the two strings are the same, regardless of case. </returns>
        public static bool EqualsNoCase(
            this string str1,
            string str2,
            StringComparison comparisonType
        )
            => string.IsNullOrWhiteSpace(str1) ||
               string.IsNullOrWhiteSpace(str2)
                ? string.IsNullOrWhiteSpace(str1) &&
                  string.IsNullOrWhiteSpace(str2)
                : str2.ToLowerInvariant()
                      .Equals(str1.ToLowerInvariant(), comparisonType);

        /// <summary>
        /// Excludes whitespace characters from the specified
        /// <paramref name="value" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> from which to
        /// exclude all whitespace characters.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> that matches
        /// <paramref name="value" />, but with all whitespace characters removed.
        /// </returns>
        /// <remarks>
        /// This method is useful for conducting whitespace-insensitive testing
        /// of strings.
        /// </remarks>
        private static string ExcludingWhitespace(this string value)
            => WhiteSpaceRegex.Replace(value, "");

        /// <summary>
        /// Extracts all characters of the specified <paramref name="value" /> up to but
        /// not including the first occurrence of a colon (<c>:</c>).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> that is set to the value to be
        /// processed.
        /// </param>
        /// <remarks>
        /// If the specified <paramref name="value" /> is <see langword="null" />,
        /// blank, the <see cref="F:System.String.Empty" /> value, or does not contain a
        /// colon, then the method is idempotent.
        /// </remarks>
        /// <returns>
        /// A <see cref="T:System.String" /> containing all characters of the
        /// specified <paramref name="value" /> up to but not including the first colon (
        /// <c>:</c>), if present.
        /// </returns>
        public static string ExtractUpToColon(this string value)
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                /*
                 * Extract up to the FIRST occurrence of a colon.
                 */

                var colonIndex = value.IndexOf(':');
                if (colonIndex <= 0) return value;

                result = value.Substring(0, colonIndex);
            }
            catch (Exception ex)
            {
                // Log exception details
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Returns the specified <paramref name="val2" /> if <paramref name="val1" /> is
        /// <see langword="null" /> or a blank string; otherwise, <paramref name="val1" />
        /// is returned if both <paramref name="val1" /> and <paramref name="val2" /> are
        /// non-blank.
        /// </summary>
        /// <param name="val1">
        /// (Required.) A <see cref="T:System.String" /> that is the
        /// preferred value to be returned.
        /// </param>
        /// <param name="val2">
        /// (Required.) A <see cref="T:System.String" /> whose value is
        /// to be returned in the event that the argument of <paramref name="val1" /> is
        /// <see langword="null" />, whitespace, or the
        /// <see cref="F:System.String.Empty" /> value.
        /// </param>
        /// <returns>
        /// Specified <paramref name="val2" /> if <paramref name="val1" /> is
        /// <see langword="null" /> or a blank string; otherwise, <paramref name="val1" />
        /// is returned if both <paramref name="val1" /> and <paramref name="val2" /> are
        /// non-blank.
        /// </returns>
        [return: NotLogged]
        public static string FirstOrNotEmpty(this string val1, string val2)
        {
            var result = string.Empty;

            try
            {
                result = string.IsNullOrWhiteSpace(val1) ? val2 : val1;
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
        /// Formats the specified <paramref name="content" /> as HTML by replacing certain
        /// characters
        /// with their corresponding HTML entities.
        /// </summary>
        /// <param name="content">
        /// (Required.) A <see cref="T:System.String" /> containing the text to be
        /// formatted as HTML.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the formatted HTML text.
        /// </returns>
        /// <remarks>
        /// This method replaces the following characters in the input string:
        /// <list type="bullet">
        ///     <item>
        ///         <description>&lt; with <c>&amp;lt;</c></description>
        ///     </item>
        ///     <item>
        ///         <description>&gt; with <c>&amp;gt;</c></description>
        ///     </item>
        ///     <item>
        ///         <description>" with <c>&amp;quot;</c></description>
        ///     </item>
        ///     <item>
        ///         <description>Single quotes with <c>&amp;apos;</c></description>
        ///     </item>
        ///     <item>
        ///         <description>Spaces with <c>&amp;nbsp;</c></description>
        ///     </item>
        /// </list>
        /// <para />
        /// In addition, this method also transforms 'smart' quotes, i.e., "curly" quotes,
        /// to 'straight' quotes before performing the reformat of single and double
        /// quotation marks.
        /// <para />
        /// If an exception occurs during the formatting process, then this method is
        /// idempotent.
        /// </remarks>
        public static string FormatAsHtml(this string content)
        {
            var result = content;

            try
            {
                if (string.IsNullOrWhiteSpace(content)) return result;

                result = content.Replace("<", "&lt;")
                                .Replace(">", "&gt;")
                                .StripIncompatibleQuotes()
                                .Replace("\"", "&quot;")
                                .ReplaceSingleQuotesWithHTMLApostrophes()
                                .ReplaceSpacesWithHtmlNonBreakingSpace();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = content;
            }

            return result;
        }

        /// <summary>
        /// Provides a method to format a string in a more Pythonic manner, where we simply
        /// call <c>Format()</c> following the string to be formatted.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// value that is to be formatted.
        /// </param>
        /// <param name="args">
        /// (Required.) Zero or more object(s) whose value(s) are to be
        /// substituted in for the format specifier(s) in the specified
        /// <paramref name="value" />.
        /// </param>
        /// <returns>
        /// If successful, this method returns the specified
        /// <paramref name="value" />, with the format placeholders updated according to
        /// the specified <paramref name="args" />, if any; otherwise, the method is
        /// idempotent.
        /// </returns>
        public static string FormatLikePython(
            this string value,
            params object[] args
        )
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value))
                    return result;

                result = string.Format(value, args);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Re-expresses strings with ellipsis (...) if they are longer than a
        /// certain length.
        /// </summary>
        /// <param name="stringToCompact"> The text to be compacted. </param>
        /// <param name="font"> Font the text is in. </param>
        /// <param name="maxWidth"> The maximum length of the string. </param>
        /// <returns>
        /// Version of the string that has ellipsis (...) so as to fit within the
        /// given length.
        /// </returns>
        public static string GetCompactedString(
            this string stringToCompact,
            Font font,
            int maxWidth
        )
        {
            if (string.IsNullOrWhiteSpace(stringToCompact))
                return string.Empty;

            // Copy the string passed in since this string will be modified in
            // the TextRenderer MeasureText method
            var compactedString = string.Copy(stringToCompact);
            var maxSize = new Size(maxWidth, 0);

            const TextFormatFlags formattingOptions =
                TextFormatFlags.PathEllipsis | TextFormatFlags.ModifyString;
            TextRenderer.MeasureText(
                compactedString, font, maxSize, formattingOptions
            );

            return compactedString;
        }

        /// <summary>
        /// Gets the suffix of a so-called <i>dotted</i> string, i.e.,
        /// <c>My.Dotted.String</c>, which is presumed to be passed as the argument of the
        /// <paramref name="value" /> parameter.
        /// <para />
        /// For the example above, <c>.String</c> or <c>String</c> is the result of calling
        /// this method, depending on the value of the <paramref name="includingDot" />
        /// parameter.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// text to be parsed.
        /// </param>
        /// <param name="includingDot">
        /// (Optional.) <see langword="true" /> to make the resultant string include the
        /// <c>.</c> character at the start of the suffix; <see langword="false" /> to
        /// exclude the <c>.</c> character.
        /// <para />
        /// The default value of this parameter is <see langword="false" />.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the final
        /// part, or <i>suffix</i>, of the dotted string supplied as the argument to the
        /// <paramref name="value" /> parameter. The result includes the <c>.</c> character
        /// if <paramref name="includingDot" /> is set to <see langword="true" />;
        /// otherwise,
        /// the result does not include the <c>.</c> character. If the input is invalid,
        /// the
        /// <paramref name="value" /> parameter is idempotently returned.
        /// </returns>
        public static string GetDottedSuffix(
            this string value,
            bool includingDot = false
        )
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                var lastDotIndex = value.LastIndexOf('.');

                // Find the last occurrence of '.' without splitting the string,
                // except if a '.' character is not present in the string, or if
                // the '.' is the final character of the string.
                if (lastDotIndex < 0 || lastDotIndex == value.Length - 1)
                    return result;

                // Adjust the starting index based on includingDot parameter
                var startIndex = includingDot ? lastDotIndex : lastDotIndex + 1;

                // Extract the suffix directly
                result = value.Substring(startIndex);
            }

            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Gets the first <paramref name="nChars" /> characters of the string
        /// <paramref name="value" /> and returns them; returns the entire string
        /// <paramref name="value" /> if the string is smaller than
        /// <paramref name="nChars" /> characters in length.
        /// </summary>
        /// <param name="value">
        /// String to pull the first <paramref name="nChars" />
        /// characters from.
        /// </param>
        /// <param name="nChars">
        /// (Must be a positive number.) Number of characters from
        /// the start of the string to get.
        /// </param>
        /// <returns>
        /// First <paramref name="nChars" /> characters of the string in
        /// <paramref name="value" />; or, if <paramref name="value" /> is shorter than
        /// <paramref name="nChars" /> characters, the entire string that is passed in
        /// <paramref name="value" /> is returned. If a problem occurred, the empty string
        /// is returned.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if
        /// <paramref name="nChars" /> has a zero or negative number value.
        /// <paramref name="nChars" /> must be a positive number.
        /// </exception>
        public static string GetFirstNChars(this string value, int nChars)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;
            if (nChars <= 0)
                throw new ArgumentOutOfRangeException(
                    Resources.NCharsMustBePositive
                );

            return value.Length <= nChars ? value : value.Substring(0, nChars);
        }

        /// <summary>
        /// Extracts the last initial-capped word from a fully-qualified class name or
        /// string containing a name such as <c>FooBarBaz</c> (in which case, it would
        /// return <c>Baz</c>).
        /// </summary>
        /// <param name="input">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// text that is to be parsed.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the last
        /// initial-capped word in the <paramref name="input" />; otherwise, this method is
        /// idempotent.
        /// </returns>
        public static string GetLastWord(this string input)
        {
            var result = input;

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                    return input;

                // Start from the end of the string and work backwards
                for (var i = input.Length - 1; i >= 0; i--)
                {
                    if (!char.IsUpper(input[i])) continue;

                    // Return the substring starting from the capital letter
                    result = input.Substring(i);
                    break;
                }

                // If no capital letter is found, return the original input (unlikely with valid input)
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = input;
            }

            return result;
        }

        /// <summary>
        /// Very na?ve determination of person first name 99.9% of the time,
        /// persons' names are // given as &lt;First Name&gt; &lt;Rest&gt;.
        /// </summary>
        /// <param name="fullName">
        /// (Required.) String value containing the full name of
        /// the person.
        /// </param>
        /// <returns>
        /// String containing the first name of the person. Empty string if this
        /// method is passed the empty string as input.
        /// </returns>
        /// <remarks>
        /// Therefore, we can assume that, if we break the name field up by
        /// spaces, then everything before the first space is word of the first name. <p />
        /// This should even catch 'fancy' last name, such as "de la Haye." For instance,
        /// this method would read "Nathan de la Montoya" and return "Nathan," so our way
        /// of determining the last name is pretty safe, given the above assumptions and
        /// input patterns. If the empty string is passed as input to this method, then the
        /// empty string is returned.
        /// </remarks>
        public static string GetPersonFirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

            // parse out everything in the name after the first space character
            return fullName.IndexOf(' ') >= 0
                ? fullName.Substring(0, fullName.IndexOf(' '))
                          .ToInitialCaps()
                : fullName;
        }

        /// <summary>
        /// Very na?ve determination of person last name. In our software
        /// consulting and tutoring practice, new clients tend to given their first and
        /// last name only when signing up --- about 99.9% of the time.
        /// </summary>
        /// <param name="fullName">
        /// (Required.) String value containing the full name of
        /// the person.
        /// </param>
        /// <returns>
        /// String containing the first name of the person. Empty string if this
        /// method is passed the empty string as input.
        /// </returns>
        /// <remarks>
        /// Therefore, we can assume that, if we break the name field up by
        /// spaces, then everything after the first space is word of the last name. <p />
        /// This should even catch 'fancy' last name, such as "de la Haye." For instance,
        /// this method would read "Nathan de la Montoya" and return "de la Montoya," so
        /// our way of determining the last name is pretty safe, given the above
        /// assumptions and input patterns. If the empty string is passed as input, then
        /// the empty string is returned. If a string containing just one word is passed as
        /// input, a <see cref="T:System.IO.InvalidDataException" /> is thrown.
        /// </remarks>
        public static string GetPersonLastName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

            // break the name up into a String[] array based on spaces
            var nameParts = fullName.Split(
                new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries
            );

            // parse out everything in the name after the first space character
            return !nameParts.Any() || nameParts.Length == 1
                ? throw new InvalidDataException(
                    Resources.PersonNameIncorrectFormat
                )
                : fullName.Substring(
                              fullName.IndexOf(" ", StringComparison.Ordinal) +
                              1,
                              fullName.Length - fullName.IndexOf(
                                  " ", StringComparison.Ordinal
                              ) - 1
                          )
                          .ToInitialCaps();
        }

        /// <summary>
        /// Determines whether the specified <paramref name="path" /> is a
        /// fully-qualified, absolute path or not.
        /// </summary>
        /// <param name="path"> (Required.) String containing the path to be checked. </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="path" /> specified is
        /// a fully-qualified, absolute path; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsAbsolutePath(this string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return false; // obviously not the case

            bool result;

            try
            {
                result = Path.IsPathRooted(path) && !Path.GetPathRoot(path)
                    .Equals(
                        Path.DirectorySeparatorChar.ToString(),
                        StringComparison.Ordinal
                    );
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the current word in the text being parsed for a
        /// character-casing operation is
        /// </summary>
        /// <param name="array"> </param>
        /// <param name="i"> </param>
        /// <returns> </returns>
        private static bool IsAcronymOrStateAbbr(IList<string> array, int i)
        {
            if (array == null || !array.Any() ||
                string.IsNullOrWhiteSpace(array[i]) ||
                ShortWordsThatAreNotAcronyms.ContainsNoCase(array[i]))
                return false;

            // something can be classed as an acronym if (a) it's not in the
            // quote of "special" words, such as "The," "An", "Or", etc., and
            // (b) it has two or more characters
            if (i == 0 || array.Count == 1)
            {
                if (array.Count == 1)

                    // always initial-capitalize a one-word phrase
                    // --- but it's not an acronym
                    return false;

                return StateAbbrList.ContainsNoCase(array[i]) |
                       new Regex("\"[^\"]*\"").IsMatch(array[i]) |
                       (!CapitalizeableAsFirstWords.ContainsNoCase(array[i]) &
                        AcronymList.Any(s => EqualsNoCase(s, array[i])));
            }

            if (i > 0) /* means we are past the first word of a phrase */
                return (StateAbbrList.Contains(array[i]) && array[i - 1]
                           .EndsWith(",")) ||
                       !CapitalizeableAsFirstWords.ContainsNoCase(array[i]) &
                       AcronymList.ContainsNoCase(array[i]);

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.String" />
        /// <paramref name="value" /> is alphanumeric.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> that is to  be
        /// examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if every character of the specified
        /// <paramref name="value" /> is a letter or a digit, excluding any whitespace
        /// characters; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsAlphaNumeric(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                var valueExcludingWhiteSpace = value.ExcludingWhitespace();
                if (string.IsNullOrWhiteSpace(valueExcludingWhiteSpace))
                    return result;

                /*
                 * This method must return TRUE even if the
                 * string contains whitespace characters, yet it
                 * still fits the criteria otherwise.
                 */

                result = valueExcludingWhiteSpace.All(char.IsLetterOrDigit);
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
        /// Determines whether the specified <paramref name="value" /> is an
        /// alphanumeric <see cref="T:System.String" /> that consists solely of digits or
        /// lowercase letters (excluding whitespace).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text to be checked.
        /// </param>
        /// <remarks>
        /// If a blank <see cref="T:System.String" /> or a
        /// <see langword="null" /> reference is passed to this method, then this method
        /// returns <see langword="false" />.
        /// <para />
        /// If an error occurs during the check, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// consists solely of either digits or lowercase letters (excluding whitespace);
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsAlphaNumericLowercase(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                var valueExcludingWhiteSpace = value.ExcludingWhitespace();
                if (string.IsNullOrWhiteSpace(valueExcludingWhiteSpace))
                    return result;

                /*
                 * This method must return TRUE even if the
                 * string contains whitespace characters, yet it
                 * still fits the criteria otherwise.
                 */

                result = valueExcludingWhiteSpace.All(char.IsLetterOrDigit) &&
                         valueExcludingWhiteSpace.Where(char.IsLetter)
                                                 .All(char.IsLower);
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
        /// Determines whether the specified <paramref name="value" /> is an
        /// alphanumeric <see cref="T:System.String" /> that consists solely of digits or
        /// uppercase letters (excluding whitespace).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text to be checked.
        /// </param>
        /// <remarks>
        /// If a blank <see cref="T:System.String" /> or a
        /// <see langword="null" /> reference is passed to this method, then this method
        /// returns <see langword="false" />.
        /// <para />
        /// If an error occurs during the check, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// consists solely of either digits or uppercase letters (excluding whitespace);
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsAlphaNumericUppercase(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                var valueExcludingWhiteSpace = value.ExcludingWhitespace();
                if (string.IsNullOrWhiteSpace(valueExcludingWhiteSpace))
                    return result;

                /*
                 * This method must return TRUE even if the
                 * string contains whitespace characters, yet it
                 * still fits the criteria otherwise.
                 */

                result = valueExcludingWhiteSpace.All(char.IsLetterOrDigit) &&
                         valueExcludingWhiteSpace.Where(char.IsLetter)
                                                 .All(char.IsUpper);
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
        /// Gets a value that indicates whether the specified
        /// <paramref name="value" /> is blank, only consists of whitespace, or a
        /// <see langword="null" /> reference.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> value that
        /// should be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// blank, only consists of whitespace, or a <see langword="null" /> reference.
        /// </returns>
        public static bool IsBlankOrNull(this string value)
            => string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Determines whether the <paramref name="value" /> passed is a
        /// <c>decimal</c> number or not.
        /// </summary>
        /// <param name="value"> (Required.) String containing the value or not. </param>
        /// <returns>
        /// <see langword="true" /> if the string passed in
        /// <paramref name="value" /> is the string representation of a value that is in
        /// the range of the <c>decimal</c> data type; <see langword="false" /> otherwise.
        /// The method also returns <see langword="false" /> if it is passed the empty
        /// string.
        /// </returns>
        public static bool IsDecimal(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            bool result;
            try
            {
                result = decimal.TryParse(value, out _);
            }
            catch
            {
                /* silence! */
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="path" /> is the path
        /// to a folder or not.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the file-system entry to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the object at the specified pathname is a
        /// folder; <see langword="false" /> otherwise. If the specified pathname is blank,
        /// then this method simply returns <see langword="false" />. If a file-system
        /// error occurs during the checking, <see langword="false" /> is also returned.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <remarks>
        /// Note the exact words of the Returns statement: "if the object at the
        /// specified pathname is a folder." So if you pass in the phrase, "Hello, world,"
        /// it will be rejected.
        /// </remarks>
        public static bool IsFolderPath(this string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return false; // obviously not the case

            bool result;

            try
            {
                if (!File.Exists(path) && !Directory.Exists(path))
                    return
                        false; // the path must reference a file-system entry that exists

                // get the file attributes for file or directory
                var attr = File.GetAttributes(path);

                //detect whether it's a directory or file
                result = (attr & FileAttributes.Directory) ==
                         FileAttributes.Directory;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> is a
        /// <see cref="T:System.String" /> that consists solely of lowercase letters
        /// (excluding whitespace).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text to be checked.
        /// </param>
        /// <remarks>
        /// If a blank <see cref="T:System.String" /> or a
        /// <see langword="null" /> reference is passed to this method, then this method
        /// returns <see langword="false" />.
        /// <para />
        /// If an error occurs during the check, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// consists solely of lowercase letters (excluding whitespace);
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsLowercase(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                var valueExcludingWhiteSpace = value.ExcludingWhitespace();
                if (string.IsNullOrWhiteSpace(valueExcludingWhiteSpace))
                    return result;

                /*
                 * This method must return TRUE even if the
                 * string contains whitespace characters, yet it
                 * still fits the criteria otherwise.
                 */

                result = value.All(char.IsLower);
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
        /// Determines whether the <paramref name="value" /> passed is the string
        /// representation of a 32-bit <c>int</c> or not.
        /// </summary>
        /// <param name="value"> (Required.) String containing the value or not. </param>
        /// <returns>
        /// <see langword="true" /> if the string passed in
        /// <paramref name="value" /> is the string representation of a value that is in
        /// the range of the 32-bit <c>int</c> data type; <see langword="false" />
        /// otherwise. The method also returns <see langword="false" /> if it is passed the
        /// empty string.
        /// </returns>
        public static bool IsNumeric(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            bool result;
            try
            {
                result = int.TryParse(value, out _);
            }
            catch
            {
                /* silence! */
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Performs a culture-invariant, case-insensitive, OR match of the
        /// <paramref name="value" /> against the <paramref name="choices" /> provided.
        /// </summary>
        /// <param name="value"> Value to match. </param>
        /// <param name="choices"> Choices to match against. </param>
        /// <returns>
        /// <see langword="true" /> if the string <paramref name="value" />
        /// matches one or more of the <paramref name="choices" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If <paramref name="value" /> is the empty string, or if
        /// <paramref name="choices" /> is the empty collection, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool IsOneOf(
            this string value,
            IEnumerable<string> choices
        )
            => !string.IsNullOrWhiteSpace(value) && choices != null &&
               choices.Any(value.EqualsNoCase);

        /// <summary>
        /// Determines whether the passed <see cref="string" /> contains Roman
        /// numerals.
        /// </summary>
        /// <param name="value"> Value to be checked. </param>
        /// <returns> TRUE if the value contains Roman numerals; FALSE otherwise. </returns>
        private static bool IsRomanNumerals(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            var regex = new Regex(
                @"(?i)^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$"
            );
            var result = regex.IsMatch(value);
            return result;
        }

        /// <summary>
        /// Gets a value indicating whether a special word, such as 'The' or
        /// 'Dr.' or 'Mr.' or 'Ms.' or 'A' etc. is the first word of a word and still needs
        /// to be initial-capitalized.
        /// </summary>
        /// <param name="words"> Array of words (a phrase split on spaces, etc.) </param>
        /// <param name="currentWord"> Current word being checked. </param>
        /// <returns> </returns>
        private static bool IsSpecialWordAtBeginningOfPhrase(
            string[] words,
            string currentWord
        )
        {
            if (words == null || !words.Any()) return false;

            if (string.IsNullOrWhiteSpace(currentWord)) return false;

            return (currentWord.EndsWith(".") && EqualsNoCase(
                       currentWord, words.First()
                   )) // this is most likely someone's title
                   | CapitalizeableAsFirstWords
                       .ContainsNoCase(
                           currentWord
                       ) // any words appearing in this array that are at the beginning of our phrase, should always be initial-capitalized
                   && EqualsNoCase(currentWord, words.First());
        }

        /// <summary>
        /// Determines whether the current element in the list of words being
        /// parsed (as part of a character-casing operation) is the component of common
        /// names for US streets.
        /// </summary>
        /// <param name="array">
        /// (Required.) Collection of words from the text being
        /// parsed.
        /// </param>
        /// <param name="i">
        /// (Required.) Index into the <paramref name="array" /> of the
        /// current word being parsed.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the current word belongs as part of the
        /// name of common US streets; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If this method is provided with the empty collection or an array
        /// index outside the bounds of the collection, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        private static bool IsStreetNameComponent(
            IReadOnlyList<string> array,
            int i
        )
            => array != null && array.Any() && i < array.Count &&
               (i + 1 >= array.Count
                   ? NamesOfStreetsThatShouldBeCapitalized.ContainsNoCase(
                       array[i]
                   )
                   : NamesOfStreetsThatShouldBeCapitalized.ContainsNoCase(
                       array[i]
                   ) | NamesOfStreetsThatShouldBeCapitalized.ContainsNoCase(
                       array[i + 1]
                   ));

        /// <summary>
        /// Determines whether the specified character, <paramref name="c" />, is
        /// uppercase.
        /// </summary>
        /// <param name="c">
        /// (Required.) A <see cref="T:System.Char" /> value that is to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <see cref="T:System.Char" />
        /// value, <paramref name="c" />, is an ASCII or Unicode uppercase character;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsUppercase(this char c)
        {
            bool result;

            try
            {
                result = char.IsUpper(c);
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
        /// Determines whether the specified <paramref name="value" /> is a
        /// <see cref="T:System.String" /> that consists solely of uppercase letters
        /// (excluding whitespace).
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text to be checked.
        /// </param>
        /// <remarks>
        /// If a blank <see cref="T:System.String" /> or a
        /// <see langword="null" /> reference is passed to this method, then this method
        /// returns <see langword="false" />.
        /// <para />
        /// If an error occurs during the check, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// consists solely of uppercase letters (excluding whitespace);
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsUppercase(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                var valueExcludingWhiteSpace = value.ExcludingWhitespace();
                if (string.IsNullOrWhiteSpace(valueExcludingWhiteSpace))
                    return result;

                /*
                 * This method must return TRUE even if the
                 * string contains whitespace characters, yet it
                 * still fits the criteria otherwise.
                 */

                result = valueExcludingWhiteSpace.All(char.IsUpper);
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
        /// Determines whether the specified <paramref name="symbol" /> string contains a
        /// properly-formatted asset symbol, such as <c>FB</c>, <c>00</c>, <c>1INCH</c>,
        /// <c>cBETH</c> etc.
        /// </summary>
        /// <param name="symbol">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text, whose format is to be validated.
        /// </param>
        /// <remarks>
        /// If the <paramref name="symbol" /> parameter is passed a
        /// <see langword="null" /> reference, the <see cref="F:System.String.Empty" />
        /// value, or a <see cref="T:System.String" /> containing only whitespace, then the
        /// method returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="symbol" /> is
        /// of the proper format; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsValidAssetSymbol(this string symbol)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(symbol)) return result;

                result = Regex.IsMatch(symbol, @"[0-9a-zA-Z]+");
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
        /// Validates whether <paramref name="value" /> is a valid email address
        /// or not.
        /// </summary>
        /// <param name="value"> String to be checked. </param>
        /// <returns>
        /// true if the string contains a valid email address value; false
        /// otherwise.
        /// </returns>
        public static bool IsValidEmail(string value)
        {
            var result = false;

            try
            {
                // Dump the parameter value to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"StringExtensions.IsValidEmail: value = '{value}'"
                );

                if (string.IsNullOrWhiteSpace(value))
                {
                    IsEmailAddressInvalid = true;
                    return result;
                }

                // Use IdnMapping class to convert Unicode domain names.
                value = Regex.Replace(value, @"(@)(.+)$", DomainMapper);

                // Return true if value is in valid e-mail format.
                result = Regex.IsMatch(
                    value,
                    @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                    RegexOptions.IgnoreCase
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }
            finally
            {
                IsEmailAddressInvalid = !result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"StringExtensions.IsValidEmail: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Determines if the specified <paramref name="value" /> is a string that contains
        /// a globally-unique identifier (GUID) that is in all lowercase with no
        /// surrounding curly braces; e.g., for example,
        /// <c>b68d770b-8e37-4a20-b2cc-6cbc2ef4f136</c>.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// data to be validated.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the argument of the
        /// <paramref name="value" /> parameter is a <see langword="null" /> reference or
        /// consists of only whitespace characters, or is the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the contents of <paramref name="value" />
        /// consists of a single GUID that is in all lowercase with no surrounding curly
        /// braces; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsValidLowercaseGuidWithNoBraces(this string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                result = Regex.IsMatch(value, GuidRegexLowercaseNoBraces);
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the <paramref name="stringToSearch" /> contains
        /// the text in the <paramref name="findWhat" /> parameter, in a case-insensitive
        /// fashion.
        /// </summary>
        /// <param name="stringToSearch">
        /// (Required.) A <see cref="T:System.String" />
        /// value containing the text that is to be searched.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text that is to be located within the <paramref name="stringToSearch" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the case-insensitive search determines
        /// that the <paramref name="stringToSearch" /> values contains one or more
        /// instances of the <paramref name="findWhat" /> text; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool MatchesNoCase(
            this string stringToSearch,
            string findWhat
        )
        {
            bool result;

            try
            {
                result = !string.IsNullOrEmpty(stringToSearch) &&
                         stringToSearch.ContainsNoCase(findWhat);
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
        /// Determines whether the <paramref name="stringToSearch" /> contains
        /// the text in the <paramref name="findWhat" /> parameter, in a case-sensitive
        /// fashion.
        /// </summary>
        /// <param name="stringToSearch">
        /// (Required.) A <see cref="T:System.String" />
        /// value containing the text that is to be searched.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the text that is to be located within the <paramref name="stringToSearch" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the case-sensitive search determines that
        /// the <paramref name="stringToSearch" /> values contains instances of the
        /// <paramref name="findWhat" /> text; <see langword="false" /> otherwise.
        /// </returns>
        public static bool MatchesWithCase(
            this string stringToSearch,
            string findWhat
        )
        {
            bool result;

            try
            {
                result = !string.IsNullOrWhiteSpace(stringToSearch) &&
                         stringToSearch.Contains(findWhat);
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
        /// Pluralizes the word passed in, applying language rules from the
        /// specified <paramref name="culture" />.
        /// </summary>
        /// <param name="word"> Word to be pluralized. </param>
        /// <param name="culture">
        /// Specifies the
        /// <see cref="T:System.Globalization.CultureInfo" /> value to use when applying
        /// language rules.
        /// </param>
        /// <returns>
        /// The <paramref name="word" /> if it is already plural; otherwise, a
        /// <see cref="T:System.String" /> containing the plural version of the
        /// <paramref name="word" />.
        /// </returns>
        /// <remarks>
        /// If the empty string is passed for <paramref name="word" />, then this
        /// method returns the empty string.
        /// </remarks>
        public static string PluralizeWord(
            this string word,
            CultureInfo culture
        )
        {
            // If we are given blank input, then send blank output.
            if (string.IsNullOrWhiteSpace(word)) return string.Empty;

            var service = PluralizationService.CreateService(culture);
            return service.IsPlural(word) ? word : service.Pluralize(word);
        }

        /// <summary> Pluralizes the word passed in, using the current UI culture. </summary>
        /// <param name="word"> String containing the word to be pluralized. </param>
        /// <returns>
        /// The <paramref name="word" /> if it is already plural; otherwise, a
        /// <see cref="T:System.String" /> containing the plural version of the
        /// <paramref name="word" />.
        /// </returns>
        /// <remarks>
        /// If the empty string is passed for <paramref name="word" />, then this
        /// method returns the empty string.
        /// </remarks>
        public static string PluralizeWord(this string word)
            => PluralizeWord(word, CultureInfo.CurrentUICulture);

        /// <summary>
        /// More Pythonic version of the <see cref="M:System.String.FormatLikePython" />
        /// method, which you can put after a string literal or
        /// <see cref="T:System.String" /> variable to format a string.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// format placeholders.
        /// </param>
        /// <param name="args">
        /// (Optional.) One or more format values to be substituted in
        /// the corresponding locations in the specified <paramref name="value" />.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> that is the result of the formatting
        /// operation, or idempotent if the format operation could not be carried out, or
        /// if no format values were provided in the <paramref name="args" /> parameter.
        /// </returns>
        public static string PostfixFormat(
            this string value,
            params object[] args
        )
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (args == null || !args.Any()) return result;

                result = string.Format(value, args);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Prepends a bang (<c>!</c>) character before the specified
        /// <paramref name="value" />, and then returns the result.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// value to which a bang (<c>!</c>) character is to be prepended.
        /// </param>
        /// <returns>
        /// If successful, the argument of the <paramref name="value" />
        /// parameter, with a bang (<c>!</c>) character prepended; otherwise, the method is
        /// idempotent.
        /// </returns>
        public static string PrependBang(this string value)
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                result = "!" + value;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="stringToSearch" />
        /// matches the regular expression specified by the <paramref name="regex" />
        /// parameter's value, without regards to upper- or lower-case.
        /// </summary>
        /// <param name="stringToSearch">
        /// (Required.) String containing the data to be
        /// searched for a match.
        /// </param>
        /// <param name="regex">
        /// (Required.) String containing the regular expression that
        /// expresses the criteria to be used for matching.
        /// </param>
        /// <returns>
        /// If even one match is found by the <paramref name="regex" />, returns
        /// <see langword="true" />. Otherwise, if one or both of the required parameters
        /// are blank or <see langword="null" />, or if no matches are found by the
        /// <paramref name="regex" />, then this method returns <see langword="false" />.
        /// </returns>
        public static bool RegexMatchesNoCase(
            this string stringToSearch,
            string regex
        )
            => !string.IsNullOrEmpty(regex) &&
               !string.IsNullOrEmpty(stringToSearch) && Regex.IsMatch(
                   stringToSearch, regex, RegexOptions.IgnoreCase
               );

        /// <summary>
        /// Determines whether the specified <paramref name="stringToSearch" />
        /// matches the regular expression specified by the <paramref name="regex" />
        /// parameter's value, respecting case.
        /// </summary>
        /// <param name="stringToSearch">
        /// (Required.) String containing the data to be
        /// searched for a match.
        /// </param>
        /// <param name="regex">
        /// (Required.) String containing the regular expression that
        /// expresses the criteria to be used for matching.
        /// </param>
        /// <returns>
        /// If even one match is found by the <paramref name="regex" />, returns
        /// <see langword="true" />. Otherwise, if one or both of the required parameters
        /// are blank or <see langword="null" />, or if no matches are found by the
        /// <paramref name="regex" />, then this method returns <see langword="false" />.
        /// </returns>
        public static bool RegexMatchesWithCase(
            this string stringToSearch,
            string regex
        )
            => !string.IsNullOrEmpty(regex) &&
               !string.IsNullOrEmpty(stringToSearch) &&
               Regex.IsMatch(stringToSearch, regex);

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the <paramref name="value" /> . The
        /// <paramref name="search" /> parameter may contain a Regular Expression (regex).
        /// Case is ignored.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search
        /// and replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the
        /// string. May contain a regular expression.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any
        /// found occurrences of <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <returns> String containing the result. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required
        /// parameters, <paramref name="value" />, <paramref name="search" />, or
        /// <paramref name="replacement" />, are passed blank or <see langword="null" />
        /// strings for values.
        /// </exception>
        public static string RegexReplaceNoCase(
            this string value,
            string search,
            string replacement
        )
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(replacement)
                );

            string result; // no replacement if an error occurred

            try
            {
                result = Regex.Replace(
                    value, search, replacement, RegexOptions.IgnoreCase
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the <paramref name="value" /> . The
        /// <paramref name="search" /> parameter may contain a Regular Expression (regex).
        /// Case is ignored.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search
        /// and replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the
        /// string. May contain a regular expression.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any
        /// found occurrences of <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <param name="options">
        /// (Required.) A bitwise combination of the
        /// <see cref="T:System.Text.RegularExpressions.RegexOptions" /> enumeration values
        /// that provide options for matching.
        /// </param>
        /// <remarks>
        /// This overload allows specification of options in the
        /// <paramref name="options" /> parameter.
        /// <para />
        /// <b>NOTE:</b> The
        /// <see cref="T:System.Text.RegularExpressions.RegexOptions.IgnoreCase" />
        /// enumeration value is combined with whatever else is provided in the
        /// <paramref name="options" /> parameter by default.
        /// </remarks>
        /// <returns> String containing the result. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required
        /// parameters, <paramref name="value" />, <paramref name="search" />, or
        /// <paramref name="replacement" />, are passed blank or <see langword="null" />
        /// strings for values.
        /// </exception>
        public static string RegexReplaceNoCase(
            this string value,
            string search,
            string replacement,
            RegexOptions options
        )
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(replacement)
                );

            string result; // no replacement if an error occurred

            try
            {
                result = Regex.Replace(
                    value, search, replacement,
                    RegexOptions.IgnoreCase | options
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the <paramref name="value" /> . The
        /// <paramref name="search" /> parameter may contain a Regular Expression (regex).
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search
        /// and replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the
        /// string. May contain a regular expression.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any
        /// found occurrences of <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <returns> String containing the result. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required
        /// parameters, <paramref name="value" />, <paramref name="search" />, or
        /// <paramref name="replacement" />, are passed blank or <see langword="null" />
        /// strings for values.
        /// </exception>
        public static string RegexReplaceWithCase(
            this string value,
            string search,
            string replacement
        )
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(replacement)
                );

            string result; // no replacement if an error occurred

            try
            {
                result = Regex.Replace(value, search, replacement);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value; // no replacement if an error occurred.
            }

            return result;
        }

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the <paramref name="value" /> . The
        /// <paramref name="search" /> parameter may contain a Regular Expression (regex).
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search
        /// and replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the
        /// string. May contain a regular expression.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any
        /// found occurrences of <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <param name="options">
        /// (Required.) A bitwise combination of the
        /// <see cref="T:System.Text.RegularExpressions.RegexOptions" /> enumeration values
        /// that provide options for matching.
        /// </param>
        /// <returns> String containing the result. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required
        /// parameters, <paramref name="value" />, <paramref name="search" />, or
        /// <paramref name="replacement" />, are passed blank or <see langword="null" />
        /// strings for values.
        /// </exception>
        public static string RegexReplaceWithCase(
            this string value,
            string search,
            string replacement,
            RegexOptions options
        )
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(replacement)
                );

            string result;

            try
            {
                result = Regex.Replace(value, search, replacement, options);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value; // no replacement if an exception was thrown.
            }

            return result;
        }

        /// <summary>
        /// Strips all punctuation and numeric digits from a string and trims the
        /// result.
        /// </summary>
        /// <param name="value"> String to have punctuation and numbers stripped. </param>
        /// <returns> String after transformation. </returns>
        /// <remarks>
        /// If the empty string is passed to <paramref name="value" />, then the
        /// empty string is returned.
        /// </remarks>
        public static string RemoveDigitsAndPunctuation(this string value)
            => string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : Regex.Replace(
                           Regex.Replace(
                               value.Trim(), @"[^\w\s]", string.Empty
                           ), @"[\d-]", string.Empty
                       )
                       .Trim();

        /// <summary>
        /// Removes any trailing <c>\</c> characters from the string provided in
        /// <paramref name="value" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to be stripped of
        /// trailing backslash characters.
        /// </param>
        /// <returns>
        /// Same as <paramref name="value" />, but with no trailing backslash
        /// characters.
        /// <para />
        /// If the <paramref name="value" /> parameter's argument has no trailing backslash
        /// characters to begin with, then this method is idempotent.
        /// </returns>
        /// <remarks>
        /// If the argument of the <paramref name="value" /> parameter is blank
        /// or <see langword="null" />, then the <see cref="F:System.String.Empty" /> value
        /// is returned.
        /// </remarks>
        public static string RemoveTrailingBackslashes(this string value)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                result = value.TrimEnd('\\');
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
        /// Replaces any of the elements of the specified
        /// <paramref name="findWhatValues" /> in <paramref name="source" /> with the
        /// specified <paramref name="replacementText" />.
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:System.String" /> that is to be
        /// searched.
        /// </param>
        /// <param name="findWhatValues">
        /// (Required.) Collection of
        /// <see cref="T:System.String" /> values, each of which is to be searched for in
        /// the <paramref name="source" /> <see cref="T:System.String" />.
        /// </param>
        /// <param name="replacementText">
        /// (Required.) A <see cref="T:System.String" /> that
        /// is to serve as the replacement for any of the specified
        /// <paramref name="findWhatValues" /> in <paramref name="source" />.
        /// </param>
        /// <returns>
        /// If successful, the <paramref name="source" /> string, with any of the
        /// specified <paramref name="findWhatValues" />, if they occur in it, replaced
        /// with the specified <paramref name="replacementText" />.
        /// </returns>
        [return: NotLogged]
        public static string ReplaceAnyOf(
            [NotLogged] this string source,
            [NotLogged] ICollection<string> findWhatValues,
            [NotLogged] string replacementText
        )
        {
            var result = source;

            try
            {
                /*
                 * NOTE: A conscious choice has been deliberately made to NOT
                 * add logging statements to this method, since it may be called
                 * very frequently.
                 */

                if (string.IsNullOrWhiteSpace(source)) return result;
                if (findWhatValues == null) return result;
                if (findWhatValues.Count <= 0) return result;

                foreach (var thingToFind in findWhatValues.ToArray())
                {
                    if (string.IsNullOrEmpty(thingToFind)) continue;
                    if (!source.Contains(thingToFind)) continue;

                    result = result.Replace(thingToFind, replacementText);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = source;
            }

            return result;
        }

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the <paramref name="value" /> ,
        /// ignoring case.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search
        /// and replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the
        /// string.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any
        /// found occurrences of <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <returns> String containing the result. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required
        /// parameters, <paramref name="value" />, <paramref name="search" />, or
        /// <paramref name="replacement" />, are passed blank or <see langword="null" />
        /// strings for values.
        /// </exception>
        public static string ReplaceNoCase(
            this string value,
            string search,
            string replacement
        )
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(replacement)
                );

            return value.RegexReplaceNoCase(search, replacement);
        }

        /// <summary>
        /// Replaces single quotation marks, <c>'</c>, appearing in the specified
        /// <paramref name="inputString" /> with the HTML entity <c>&amp;apos;</c>.
        /// </summary>
        /// <param name="inputString">
        /// (Required.) A <see cref="T:System.String" /> value in
        /// which the replacement is to take place.
        /// </param>
        /// <remarks>
        /// If the value of the <paramref name="inputString" /> parameter is
        /// <see langword="null" />, blank, contains only whitespace, or is the
        /// <see cref="F:System.String.Empty" /> value, then this method is idempotent.
        /// <para />
        /// This method is also idempotent if an exception is caught during the execution
        /// of the algorithm.v
        /// </remarks>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the text that has had
        /// the replacement done on it.
        /// </returns>
        [return: NotLogged]
        public static string ReplaceSingleQuotesWithHTMLApostrophes(
            [NotLogged] this string inputString
        )
        {
            var result = inputString;

            try
            {
                if (string.IsNullOrWhiteSpace(inputString)) return result;

                result = inputString.Replace("'", "&apos;");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = inputString;
            }

            return result;
        }

        /// <summary>
        /// Replaces all spaces in the specified <paramref name="inputString" /> with HTML
        /// non-breaking space entities (<c>&amp;nbsp;</c>).
        /// </summary>
        /// <param name="inputString">
        /// (Required.) A <see cref="T:System.String" /> containing the text in which
        /// spaces are to be replaced.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> with all spaces replaced by HTML non-breaking
        /// space entities (<c>&amp;nbsp;</c>).
        /// </returns>
        /// <remarks>
        /// If the <paramref name="inputString" /> is <see langword="null" /> or consists
        /// only of whitespace, the method returns the original
        /// <paramref name="inputString" />.
        /// </remarks>
        [return: NotLogged]
        public static string ReplaceSpacesWithHtmlNonBreakingSpace(
            [NotLogged] this string inputString
        )
        {
            var result = inputString;

            try
            {
                if (string.IsNullOrWhiteSpace(inputString)) return result;

                result = inputString.Replace(" ", "&nbsp;");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = inputString;
            }

            return result;
        }

        /// <summary>
        /// Splits a string <paramref name="value" /> on a provided
        /// <paramref name="delimiter" />.
        /// </summary>
        /// <param name="value"> (Required.) String containing the value to be tokenized. </param>
        /// <param name="delimiter">
        /// (Required.) String containing the delimiter on which
        /// the <paramref name="value" /> should be split.
        /// </param>
        /// <returns>
        /// An array whose elements contain the substrings that were split on the
        /// provided <paramref name="delimiter" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required
        /// parameters, <paramref name="value" /> or <paramref name="delimiter" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public static string[] SplitOn(this string value, string delimiter)
        {
            string[] result = { };

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (string.IsNullOrWhiteSpace(delimiter)) return result;

                result = value.Split(
                    new[] { delimiter }, StringSplitOptions.RemoveEmptyEntries
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new string[] { };
            }

            return result;
        }

        /// <summary>
        /// Determines if the specified <see cref="T:System.String" />
        /// <paramref name="value" /> starts with any of the specified
        /// <paramref name="beginnings" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the value to be
        /// checked.
        /// </param>
        /// <param name="beginnings">
        /// (Required.) One or more <see cref="T:System.String" />
        /// elements, each of which is to be assessed against the specified
        /// <paramref name="value" /> as being what it starts with.
        /// </param>
        /// <remarks>
        /// <b>NOTE:</b> This method returns <see langword="false" /> if no values are
        /// passed for
        /// <paramref name="beginnings" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// starts with any of the specified <paramref name="beginnings" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool StartsWithAny(
            this string value,
            params string[] beginnings
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (beginnings == null) return result;
                if (beginnings.Length <= 0) return result;

                foreach (var beginning in beginnings)
                {
                    if (string.IsNullOrWhiteSpace(beginning)) continue;
                    if (!value.StartsWith(beginning)) continue;

                    result = true;
                    break;
                }
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
        /// Gets a value indicating whether <paramref name="text" /> starts with
        /// any of the values in the <paramref name="list" />.
        /// </summary>
        /// <param name="text"> String to be checked. </param>
        /// <param name="list"> List of entries. </param>
        /// <returns>
        /// true if the <paramref name="text" /> starts with any of the entries
        /// in <paramref name="list" />.
        /// </returns>
        /// <remarks>
        /// This method performs a case-insensitive search. It returns
        /// <see langword="false" /> if passed the empty string for
        /// <paramref name="text" /> or the empty collection for <paramref name="list" />.
        /// </remarks>
        public static bool StartsWithAnyOf(
            this string text,
            params string[] list
        )
            => !string.IsNullOrWhiteSpace(text) &&
               list.Any(text.StartsWithNoCase);

        /// <summary>
        /// Tells whether the <paramref name="value" /> starts with the substring
        /// <paramref name="searchText" />, ignoring case.
        /// </summary>
        /// <param name="value"> Value to search. </param>
        /// <param name="searchText"> Suspected starting substring. </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="value" /> starts with the
        /// <paramref name="searchText" />. <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If <paramref name="value" /> is the empty string or if
        /// <paramref name="searchText" /> is the empty string, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        public static bool StartsWithNoCase(
            this string value,
            string searchText
        )
            => !string.IsNullOrWhiteSpace(value) &&
               !string.IsNullOrWhiteSpace(searchText) && value
                   .ToLowerInvariant()
                   .StartsWith(searchText.ToLowerInvariant());

        /// <summary>
        /// Strips "smart quotes" from the specified <paramref name="inputString" /> and
        /// replaces them with "straight quotes."
        /// </summary>
        /// <param name="inputString">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the data on which replacement is to be performed.
        /// </param>
        /// <remarks>
        /// If the value of the <paramref name="inputString" /> is
        /// <see langword="null" />, only consists of whitespace, or is the
        /// <see cref="F:System.String.Empty" /> value, then this method is idempotent.
        /// </remarks>
        /// <returns>
        /// If successful, the <paramref name="inputString" />, but with "smart
        /// quotes" replaced by "straight quotes." Otherwise, the method is idempotent.
        /// </returns>
        [return: NotLogged]
        public static string StripIncompatibleQuotes(
            [NotLogged] this string inputString
        )
        {
            var result = inputString;

            try
            {
                if (string.IsNullOrWhiteSpace(inputString))
                {
                    return inputString;
                }

                result = inputString.Replace('\u2018', '\'')
                                    .Replace('\u2019', '\'')
                                    .Replace('\u201c', '\"')
                                    .Replace('\u201d', '\"');
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = inputString;
            }

            return result;
        }

        /// <summary>
        /// Removes all carriage-return (<c>CR</c>) and newline (<c>NL</c>) ASCII
        /// character(s) from the provided <paramref name="value" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the text from which
        /// newline(s) are to be stripped.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that is identical to
        /// the specified <paramref name="value" /> but where all newline character(s) have
        /// been converted to blanks; otherwise, the method is idempotent.
        /// </returns>
        [return: NotLogged]
        public static string StripNewlines([NotLogged] this string value)
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                result = value.Replace("\r", string.Empty)
                              .Replace("\n", string.Empty)
                              .Trim();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Formats a string using the <paramref name="format" /> and
        /// <paramref name="args" />.
        /// </summary>
        /// <param name="format"> (Required.) String containing the format. </param>
        /// <param name="args">
        /// (Optional.) Collection of args whose values are to be
        /// replaced in the format string.
        /// </param>
        /// <returns> A string with the format placeholders replaced by the args. </returns>
        /// <remarks>
        /// This method is just an alias for
        /// <see cref="T:System.String.FormatLikePython" /> . It is here to provide a way
        /// to
        /// translate VB to C# code and still use the moniker Sub from VB that does the
        /// same operation. If this method is passed the empty string for
        /// <paramref name="format" />, then the return value is the empty string.
        /// </remarks>
        public static string Sub(this string format, params object[] args)
            => string.IsNullOrWhiteSpace(format)
                ? string.Empty
                : string.Format(format, args);

        /// <summary>
        /// Turns the specified <paramref name="phrase" /> into an all-caps acronym, if a
        /// corresponding entry is not found in our dictionary fields of short, non-acronym
        /// terms, i.e.,
        /// <see
        ///     cref="F:xyLOGIX.Core.Extensions.StringExtensions.ShortWordsThatAreNotAcronyms" />
        /// .
        /// </summary>
        /// <param name="phrase">
        /// (Required.) String containing the phrase to turn into an
        /// acronym.
        /// </param>
        /// <returns> Acronym converted from <paramref name="phrase" />. </returns>
        /// <remarks>
        /// If this method is passed the empty or whitespace string, then it
        /// returns the empty string. If this method is passed a word or phrase that is
        /// short, but not an acronym, then the input is returned with no alteration.
        /// </remarks>
        public static string ToAcronym(this string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase)) return string.Empty;

            // split the phrase on space and remove everything that is a short
            // phrase or word but is not an acronym, such as the word 'an'.
            var parts = phrase.ToUpperInvariant()
                              .Split(
                                  new[] { ' ' },
                                  StringSplitOptions.RemoveEmptyEntries
                              )
                              .ToAdvisableCollection();

            if (parts.Count > 0)
                for (var i = parts.Count - 1; i >= 0; i--)
                {
                    var part = parts[i];
                    if (part == null) continue;

                    if (!part.IsOneOf(ShortWordsThatAreNotAcronyms)) continue;

                    parts.RemoveAt(i);
                }

            // If we ended up removing all parts from the list, then return the
            // empty string
            return parts.Count <= 0
                ? string.Empty
                : parts.Aggregate(
                    string.Empty,
                    (current, part) => current + ToAcronymLetter(part)
                );
        }

        /// <summary>
        /// Uses the first letter (turned into being uppercase, if necessary) of
        /// the <paramref name="word" /> provided to be one of the letters of an acronym
        /// that is being built, e.g., from a phrase, using the first letter of each of the
        /// words of the phrase as each of the corresponding letters of the resulting
        /// acronym.
        /// </summary>
        /// <param name="word">
        /// (Required.) String containing the word whose first letter
        /// should be made into a corresponding acronym letter.
        /// </param>
        /// <returns> String containing the letter(s) to be utilized in the acronym. </returns>
        /// <remarks>
        /// If <paramref name="word" /> is the empty or whitespace string, then
        /// this method returns the empty string.
        /// </remarks>
        private static string ToAcronymLetter(string word)
            => string.IsNullOrWhiteSpace(word) ? string.Empty :
                "Reengagement".EqualsNoCase(word) ? "RE" : word[0]
                    .ToString(CultureInfo.InvariantCulture)
                    .ToUpperInvariant();

        /// <summary>
        /// Forces all characters in the input string, <paramref name="value" />,
        /// to be ASCII-encoded characters only. If any Unicode characters are found in
        /// <paramref name="value" />, then they are mapped back into the range of
        /// ASCII-encoded values.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the characters to be
        /// processed.
        /// </param>
        /// <returns>
        /// Same string as <paramref name="value" />, except that all characters
        /// are now ASCII-encoded.
        /// </returns>
        /// <remarks>
        /// If this method is passed the empty or whitespace string for
        /// <paramref name="value" />, then this method returns the empty string.
        /// </remarks>
        public static string ToASCII(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var sb = new StringBuilder();
            foreach (var c in value)
                sb.Append(
                    c > 127 ? @"\u" + ((int)c).ToString("x4") : c.ToString()
                );

            return sb.ToString()
                     .Replace("%F1", "?");
        }

        /// <summary>
        /// Turns a GUID into a string representation but removes all the '{',
        /// '}' and '-' from the string representation, so that the string representation
        /// contains only letters and/or numbers.
        /// </summary>
        /// <param name="guid">
        /// Reference to a <see cref="T:System.Guid" /> to turn into a
        /// string of letters and numbers.
        /// </param>
        /// <returns>
        /// String representation with no '{', '}' and '-' in the string
        /// representation, so that the string representation contains only letters and/or
        /// numbers.
        /// </returns>
        public static string ToGuidWithNoPunctuation(this Guid guid)
            => guid.ToString("N");

        /// <summary>
        /// Returns a value that is the same as the string specified, but in
        /// Initial Caps format.
        /// </summary>
        /// <param name="value"> Value whose case should be changed. </param>
        /// <returns> String with the casing changed to InitialCaps. </returns>
        /// <remarks>
        /// If this method is passed the empty or whitespace string, then it
        /// returns the empty string.
        /// </remarks>
        public static string ToInitialCaps(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var array = value.Trim()
                             .Split(' ');
            if (!array.Any()) return string.Empty;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i]
                        .StartsWith("#") || // Leave hashtags alone
                    string.IsNullOrWhiteSpace(array[i])) continue;

                array[i] = array[i]
                    .ToLower();
                if (i == 0 &&
                    AlwaysCapitalizeIfFirstWord.ContainsNoCase(array[i]))
                    array[i] = DoInitialCaps(array[i]);
                if (array[i]
                    .Contains("-"))
                {
                    // split the string, and call this method recursively on the parts
                    var parts = array[i]
                        .Split('-');
                    array[i] = string.Empty;
                    for (var j = 0; j < parts.Length; j++)
                        parts[j] = ToInitialCaps(parts[j]);
                    array[i] = string.Join("-", parts);
                }
                else if (array.Length == 1 || array[i].Length == 1)
                {
                    // capitalize always
                    array[i] = DoInitialCaps(array[i]);
                }
                else if (IsAcronymOrStateAbbr(array, i))
                {
                    array[i] = array[i]
                        .ToUpperInvariant();
                }
                else if (!CapitalizeableAsFirstWords.ContainsNoCase(array[i]) &
                         !array[i]
                             .IsRomanNumerals() & !char.IsDigit(array[i][0]) &&
                         !"and/or".Equals(array[i]))
                {
                    array[i] = DoInitialCaps(array[i]);
                }
                else if (array[i]
                         .IsRomanNumerals())
                {
                    // capitalize the whole word if it's only Roman numerals
                    array[i] = array[i]
                        .ToUpperInvariant();
                }
                else if (IsSpecialWordAtBeginningOfPhrase(array, array[i]))
                {
                    array[i] = DoInitialCaps(array[i]);
                }
                else if (IsStreetNameComponent(array, i))
                {
                    array[i] = DoInitialCaps(array[i]);
                }
            }

            var result = string.Join(" ", array);
            return result;
        }

        /// <summary>
        /// Turns a delimited <see cref="T:System.String" /> into a collection of
        /// strings with one delimited entry per element.
        /// </summary>
        /// <param name="quote">
        /// (Required.) String containing the text to be
        /// transformed.
        /// </param>
        /// <param name="separators">
        /// Collection of strings specifying the delimiter(s) to
        /// split upon.
        /// </param>
        /// <returns> Collection of strings containing the delimited entries. </returns>
        /// <remarks>
        /// Any empty entries in the resultant collection are removed. If the
        /// empty string is provided as input to this method, then the method returns the
        /// empty string. If no separators are specified, then the empty collection is
        /// returned.
        /// </remarks>
        public static IEnumerable<string> ToList(
            this string quote,
            params string[] separators
        )
            => !string.IsNullOrWhiteSpace(quote) && separators != null &&
               separators.Any()
                ? string.IsNullOrWhiteSpace(quote)
                    ? Enumerable.Empty<string>()
                                .ToAdvisableCollection()
                    : quote.Split(
                               separators, StringSplitOptions.RemoveEmptyEntries
                           )
                           .ToAdvisableCollection()
                : Enumerable.Empty<string>()
                            .ToAdvisableCollection();

        public static string ToLowercase(this string value)
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                value = value.ToLowerInvariant();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Translates each character of the provided <paramref name="value" />,
        /// character-by-character, to Unicode encoding. This method performs the inverse
        /// operation of the
        /// <see cref="M:xyLOGIX.Core.Extensions.StringExtensions.ToASCII" /> method.
        /// </summary>
        /// <param name="value"> (Required.) String containing the text to be re-encoded. </param>
        /// <returns>
        /// String containing the re-encoded corresponding text to that in
        /// <paramref name="value" />; or the empty string if the empty string is provided
        /// to this method.
        /// </returns>
        public static string ToUnicode(this string value)
            => string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : Regex.Replace(
                    value, @"\\u(?<Value>[a-zA-Z0-9]{4})",
                    m => ((char)int.Parse(
                        m.Groups["Value"].Value, NumberStyles.HexNumber
                    )).ToString(CultureInfo.InvariantCulture)
                );

        /// <summary>
        /// Converts the provided <see cref="T:System.String" /> <paramref name="value" />
        /// to all uppercase, ignoring culture.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the text to be
        /// converted to uppercase.
        /// </param>
        /// <returns>
        /// If successful, the <paramref name="value" /> specified, but converted
        /// to uppercase; otherwise, this method is idempotent.
        /// </returns>
        public static string ToUppercase(this string value)
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                value = value.ToUpperInvariant();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Removes any specified substrings from the end of the given string.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the text to be
        /// processed.
        /// </param>
        /// <param name="caseSensitive">
        /// (Optional.) A <see cref="T:System.Boolean" /> value indicating whether a
        /// case-sensitive search is to be performed.
        /// <para />
        /// The default value of this parameter is <see langword="false" />.
        /// </param>
        /// <param name="recursive">
        /// (Optional.) A <see cref="T:System.Boolean" /> value indicating whether the
        /// removal of bad endings should be applied repeatedly until no matches remain.
        /// <para />
        /// The default value of this parameter is <see langword="true" />.
        /// </param>
        /// <param name="badEndings">
        /// An array of <see cref="T:System.String" /> values representing the substrings
        /// to remove from the end of <paramref name="value" />. If
        /// <paramref name="badEndings" />
        /// is <see langword="null" /> or empty, no changes are made.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> with any matching substrings from
        /// <paramref name="badEndings" />
        /// removed from the end. If <paramref name="value" /> is <see langword="null" />,
        /// whitespace,
        /// or no matches are found, the original string is returned.
        /// </returns>
        /// <remarks>
        /// The method iterates through the <paramref name="badEndings" /> array to
        /// identify
        /// and remove any substrings that match the end of <paramref name="value" />.
        /// It performs case-sensitive or case-insensitive comparisons depending on
        /// the value of <paramref name="caseSensitive" />.
        /// If <paramref name="recursive" /> is set to <see langword="true" />, the method
        /// will repeatedly trim matches until no further matches are found.
        /// </remarks>
        public static string TrimAnyOffEnd(
            this string value,
            bool caseSensitive = false,
            bool recursive = true,
            params string[] badEndings
        )
        {
            var result = value;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (badEndings == null) return result;
                if (badEndings.Length <= 0) return result;

                bool changed;
                do
                {
                    changed = false;
                    foreach (var ending in badEndings)
                    {
                        if (string.IsNullOrEmpty(ending)) continue;

                        if (!result.EndsWith(
                                ending,
                                caseSensitive
                                    ? StringComparison.Ordinal
                                    : StringComparison.OrdinalIgnoreCase
                            )) continue;

                        result = result.Substring(
                                           0, result.Length - ending.Length
                                       )
                                       .TrimEnd();
                        changed = true;
                        break; // Exit loop after one match
                    }
                } while
                    (recursive && changed); // Only repeat if recursive is true
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }

        /// <summary>
        /// Trims the <paramref name="currentLine" /> of text; i.e., removes
        /// whitespace both before and after the text.
        /// </summary>
        /// <param name="currentLine"> (Required.) Text to trim. </param>
        /// <returns> Trimmed text. </returns>
        /// <remarks>
        /// If the empty or whitespace string is provided for
        /// <paramref name="currentLine" /> , then the empty string is returned by this
        /// method.
        /// </remarks>
        public static string TrimLine(this string currentLine)
            => !string.IsNullOrWhiteSpace(currentLine)
                ? currentLine.Trim()
                : string.Empty;
    }
}