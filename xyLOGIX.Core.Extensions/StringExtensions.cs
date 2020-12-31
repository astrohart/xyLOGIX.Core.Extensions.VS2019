﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions.Properties;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>Provides methods and properties to assist with manipulating strings of text.</summary>
    public static class StringExtensions
    {
        /// <summary>Collection of strings which are short words but are not acronyms per se.</summary>
        public static readonly string[] ShortWordsThatAreNotAcronyms =
        {
            "a", "an", "and", "of", "or", "the", "this", "that", "o", "O\'",
            "al-", "el-", "thus", "if", "then", "Jr.", "Sr.", "Ph.D.",
            "M.S.", "M.D."
        };

        /// <summary>Collection of strings that are commonly-used acronyms.</summary>
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

        /// <summary>Collection of strings that should always be capitalized if they are the first word of a phrase.</summary>
        private static readonly string[] AlwaysCapitalizeIfFirstWord = { "El" };

        /// <summary>Collection of strings that are potentially needing to be capitalized if they are the first word of a phrase or a name.</summary>
        private static readonly string[] CapitalizeableAsFirstWords =
        {
            "Al", "A", "The", "Of", "An", "On", "With", "La", "De", "Or",
            "And", "Not"
        };

        /// <summary>Collection of strings that contain words commonly found in the name of a street, and that need to be capitalized.</summary>
        private static readonly string[] NamesOfStreetsThatShouldBeCapitalized =
        {
            "St", "Rd", "Ave", "Blvd", "Pl", "Pky", "Pkwy", "Ct", "Ter",
            "Cir", "Hwy", "I-", "Dr", "Drwy", "Drvwy", "Pk", "Ln", "Fe",
            "Street", "Road", "Avenue", "Avenida", "Boulevard", "Place",
            "Rue", "Vieux", "Parkway", "Court", "Terrace", "Circle",
            "Highway", "Drive", "Driveway", "Pike", "Lane"
        };

        /// <summary>Collection of strings that are the two-letter abbreviations of the 50 U.S. states.</summary>
        private static readonly string[] StateAbbrList =
        {
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
            "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
            "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
            "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
            "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY",
            "DC", "PR", "VI", "AS", "GU", "MP"
        };

        /// <summary>Gets or sets a value that indicates whether the string most recently checked for whether it contains a valid email address, does in fact contain such a valid address.</summary>
        public static bool IsEmailAddressInvalid { get; private set; }

        /// <summary>Asks if the search text, in <paramref name="value" />, is a substring of any of the strings in <paramref name="collection" />, ignoring case.</summary>
        /// <param name="collection">Collection to search.</param>
        /// <param name="value">     Value to compare.</param>
        /// <returns><c>true</c> if the indicated value is in the specified collection, regardless of case; <c>false</c> otherwise.</returns>
        [UsedImplicitly]
        public static bool AnyContainNoCase(this IEnumerable<string> collection,
            string value)
        {
            return collection.Any(s => s.ContainsNoCase(value));
        }

        /// <summary>Takes a source and a selector function and exports a string that is comma-separated according to proper English grammar, i.e. <c>"dog, cat, and horse"</c> not just <c>"dog, cat, horse."</c></summary>
        /// <typeparam name="TSource">Type of each item in the source collection.</typeparam>
        /// <param name="source">Collection of <see cref="TSource" /> to iterate over.</param>
        /// <param name="selectorFunc">Delegate specifying the way to represent each element of the collection <paramref name="source" /> as a string.</param>
        /// <returns>String containing the strings selected by the selector, as illustrated above.</returns>
        /// <remarks>If this method is fed an <c>null</c> reference or the empty collection for <paramref name="source" />, then the return value is the empty string.</remarks>
        [UsedImplicitly]
        public static string AsProseList<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, string> selectorFunc)
        {
            if (source == null) return string.Empty;

            if (!(source is IList<TSource> items)) items = source.ToList();

            // If we are passed the empty collection, then return the empty string as the result.
            if (!items.Any()) return string.Empty;

            var itemStrings = items.Select(selectorFunc).Distinct().ToList();
            var result = string.Join(
                items.Count > 2 ? ", " : " and ", itemStrings
            );

            if (!result.Contains(",") || items.Count <= 2)
                return result;
            var start = result.LastIndexOf(',');
            result = new StringBuilder(result).Replace(
                ", ", ", and ", start, result.Length - start
            ).ToString();

            return result;
        }

        /// <summary>Breaks a large body of <paramref name="text" /> into individual lines, on the newline character for the particular operating system.  The result is a collection of strings, one for each line.</summary>
        /// <param name="text">(Required.) String containing the text to be split.</param>
        /// <returns>Collection of strings containing one string per line of <paramref name="text" />.</returns>
        /// <remarks>If this method is passed the empty string or a blank string as input, then it returns the empty collection.</remarks>
        [UsedImplicitly]
        public static IEnumerable<string> BreakTextIntoLines(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return Enumerable.Empty<string>();

            text = text.Replace("\r\n", "\n");
            var result = text.Split('\n').ToList();
            if (result.Any()) result = result.Select(TrimLine).ToList();

            return result;
        }

        /// <summary>Strips newlines from the text in <paramref name="line" />, and then calls <see cref="T:System.String.Trim" /> on the results.</summary>
        /// <param name="line">Text to clean.</param>
        /// <returns>Same as input, except all newline characters and whitespace has been removed.</returns>
        /// <remarks>If the empty string is provided as input, then the empty string is returned.</remarks>
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

        /// <summary>Returns <c>true</c> if the <paramref name="value" /> has any of the strings in <paramref name="searchStrings" /> as a substring.</summary>
        /// <param name="value">(Required.) The value to be used as a filter.</param>
        /// <param name="searchStrings">(Required.) Collection of strings, any of which might be substrings of <paramref name="value" />.</param>
        /// <returns>Value indicating whether any of the strings in <paramref name="searchStrings" /> are substrings (case-insensitive) of <paramref name="value" />.</returns>
        /// <remarks>If <paramref name="value" /> is the empty string or if the <paramref name="searchStrings" /> collection is empty or is a <c>null</c> reference, then this method returns <c>false</c>.</remarks>
        [UsedImplicitly]
        public static bool ContainsAnyOf(this string value,
            IEnumerable<string> searchStrings) =>
            !string.IsNullOrWhiteSpace(value) && searchStrings != null &&
            searchStrings.Any(item => ContainsNoCase(value, item));

        /// <summary>Returns <c>true</c> if the <paramref name="value" /> contains any of the characters in <paramref name="searchChars" /> (case-insensitive).</summary>
        /// <param name="value">(Required.) String to be searched.</param>
        /// <param name="searchChars">(Required.) Array of characters to look for in the <paramref name="value" />.</param>
        /// <returns><c>true</c> if the string in <paramref name="value" /> contains any of the characters (case-insensitive) in the <paramref name="searchChars" /> array; <c>false</c> otherwise.</returns>
        /// <remarks>If this method is passed the empty string for <paramref name="value" /> or a <c>null</c> reference or an empty collection for <paramref name="searchChars" />, then this method returns <c>false</c>.</remarks>
        public static bool
            ContainsAnyOf(this string value, char[] searchChars) =>
            !string.IsNullOrWhiteSpace(value) && searchChars != null &&
            searchChars.Any(item => ContainsNoCase(value, item));

        /// <summary>Searches one string for another. Case-insensitive.</summary>
        /// <param name="stringToSearch">The string to be searched.</param>
        /// <param name="value">         Value to search for.</param>
        /// <returns>Returns true if the stringToSearch contains the substring value, regardless of case; false otherwise.</returns>
        public static bool ContainsNoCase(this string stringToSearch,
            string value) =>
            !string.IsNullOrWhiteSpace(stringToSearch) &&
            !string.IsNullOrWhiteSpace(value) && stringToSearch
                .ToLowerInvariant().Contains(value.ToLowerInvariant());

        /// <summary>Searches one string for another. Case-insensitive.</summary>
        /// <param name="stringToSearch">The string to be searched.</param>
        /// <param name="value">         Value to search for.</param>
        /// <returns>Returns true if the stringToSearch contains the substring value, regardless of case; false otherwise.</returns>
        public static bool ContainsNoCase(this string stringToSearch,
            char value) =>
            !string.IsNullOrWhiteSpace(stringToSearch) && stringToSearch
                .ToLowerInvariant()
                .Contains(value.ToString().ToLowerInvariant());

        /// <summary>Case-insensitive version of the collection Contains method.</summary>
        /// <param name="collection">Collection to search.</param>
        /// <param name="value">     Value to compare.</param>
        /// <returns>TRUE if the indicated value is in the specified collection, regardless of case; FALSE otherwise.</returns>
        public static bool ContainsNoCase(this IEnumerable<string> collection,
            string value) =>
            collection != null && collection.Any(s => EqualsNoCase(s, value));

        /// <summary>Double-checks a <paramref name="twitterSite" /> (at-mention) string to make sure it begins with the character '@'.</summary>
        /// <param name="twitterSite">(Required.) Twitter handle to at-mention.</param>
        /// <returns>String containing the same value as in <paramref name="twitterSite" />, but one which is guaranteed to start with the '@' character.</returns>
        /// <remarks>If this method is passed the empty string, then the result is the empty string.</remarks>
        [UsedImplicitly]
        public static string EnsureAtIsInFront(string twitterSite)
        {
            if (string.IsNullOrWhiteSpace(twitterSite)) return string.Empty;

            twitterSite =
                $"via @{twitterSite.Trim().Replace("@", string.Empty)}";
            return twitterSite;
        }

        /// <summary>A case-insensitive equality comparer for strings. Basically, converts each of its operands to lowercase before comparing.</summary>
        /// <param name="str1">First string to compare.</param>
        /// <param name="str2">Second string to compare.</param>
        /// <returns>Whether the two strings are the same, regardless of case.</returns>
        public static bool EqualsNoCase(this string str1, string str2) =>
            string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2)
                ? string.IsNullOrWhiteSpace(str1) &&
                  string.IsNullOrWhiteSpace(str2)
                : str2.ToLowerInvariant().Equals(str1.ToLowerInvariant());

        /// <summary>A case-insensitive equality comparer for strings. Basically, converts each of its operands to lowercase before comparing.</summary>
        /// <param name="str1">          First string to compare.</param>
        /// <param name="str2">          Second string to compare.</param>
        /// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values saying how the strings are to be compared.</param>
        /// <returns>Whether the two strings are the same, regardless of case.</returns>
        [UsedImplicitly]
        public static bool EqualsNoCase(this string str1, string str2,
            StringComparison comparisonType) =>
            string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2)
                ? string.IsNullOrWhiteSpace(str1) &&
                  string.IsNullOrWhiteSpace(str2)
                : str2.ToLowerInvariant().Equals(
                    str1.ToLowerInvariant(), comparisonType
                );

        /// <summary>Re-expresses strings with ellipsis (...) if they are longer than a certain length.</summary>
        /// <param name="stringToCompact">The text to be compacted.</param>
        /// <param name="font">           Font the text is in.</param>
        /// <param name="maxWidth">       The maximum length of the string.</param>
        /// <returns>Version of the string that has ellipsis (...) so as to fit within the given length.</returns>
        public static string GetCompactedString(this string stringToCompact,
            Font font, int maxWidth)
        {
            if (string.IsNullOrWhiteSpace(stringToCompact)) return string.Empty;

            // Copy the string passed in since this string will be modified in the TextRenderer's
            // MeasureText method
            var compactedString = string.Copy(stringToCompact);
            var maxSize = new Size(maxWidth, 0);

            const TextFormatFlags formattingOptions =
                TextFormatFlags.PathEllipsis | TextFormatFlags.ModifyString;
            TextRenderer.MeasureText(
                compactedString, font, maxSize, formattingOptions
            );

            return compactedString;
        }

        /// <summary>Gets the first <paramref name="nChars" /> characters of the string <paramref name="value" /> and returns them; returns the entire string <paramref name="value" /> if the string is smaller than <paramref name="nChars" /> characters in length.</summary>
        /// <param name="value">String to pull the first <paramref name="nChars" /> characters from.</param>
        /// <param name="nChars">(Must be a positive number.)  Number of characters from the start of the string to get.</param>
        /// <returns>First <paramref name="nChars" /> characters of the string in <paramref name="value" />; or, if <paramref name="value" /> is shorter than <paramref name="nChars" /> characters, the entire string that is passed in <paramref name="value" /> is returned.  If a problem occurred, the empty string is returned.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if <paramref name="nChars" /> has a zero or negative number value.  <paramref name="nChars" /> must be a positive number.</exception>
        [UsedImplicitly]
        public static string GetFirstNChars(this string value, int nChars)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;
            if (nChars <= 0)
                throw new ArgumentOutOfRangeException(
                    Resources.NCharsMustBePositive
                );

            return value.Length <= nChars ? value : value.Substring(0, nChars);
        }

        /// <summary>Very naïve determination of person first name 99.9% of the time, persons' names are // given as &lt;First Name&gt; &lt;Rest&gt;.</summary>
        /// <param name="fullName">(Required.) String value containing the full name of the person.</param>
        /// <returns>String containing the first name of the person.  Empty string if this method is passed the empty string as input.</returns>
        /// <remarks>Therefore, we can assume that, if we break the name field up by spaces, then everything before the first space is word of the first name. <p />This should even catch 'fancy' last name, such as "de la Haye." For instance, this method would read "Nathan de la Montoya" and return "Nathan," so our way of determining the last name is pretty safe, given the above assumptions and input patterns.  If the empty string is passed as input to this method, then the empty string is returned.</remarks>
        [UsedImplicitly]
        public static string GetPersonFirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

            // parse out everything in the name after the first space character
            return fullName.IndexOf(' ') >= 0
                ? fullName.Substring(0, fullName.IndexOf(' ')).ToInitialCaps()
                : fullName;
        }

        /// <summary>Very naïve determination of person last name.  In our software consulting and tutoring practice, new clients tend to given their first and last name only when signing up --- about 99.9% of the time.</summary>
        /// <param name="fullName">(Required.) String value containing the full name of the person.</param>
        /// <returns>String containing the first name of the person.  Empty string if this method is passed the empty string as input.</returns>
        /// <remarks>Therefore, we can assume that, if we break the name field up by spaces, then everything after the first space is word of the last name. <p />This should even catch 'fancy' last name, such as "de la Haye." For instance, this method would read "Nathan de la Montoya" and return "de la Montoya," so our way of determining the last name is pretty safe, given the above assumptions and input patterns.  If the empty string is passed as input, then the empty string is returned.  If a string containing just one word is passed as input, a <see cref="T:System.IO.InvalidDataException" /> is thrown.</remarks>
        [UsedImplicitly]
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
                    fullName.IndexOf(" ", StringComparison.Ordinal) + 1,
                    fullName.Length - fullName.IndexOf(
                        " ", StringComparison.Ordinal
                    ) - 1
                ).ToInitialCaps();
        }

        /// <summary>Determines whether the <paramref name="value" /> passed is a <c>decimal</c> number or not.</summary>
        /// <param name="value">(Required.) String containing the value or not.</param>
        /// <returns><c>true</c> if the string passed in <paramref name="value" /> is the string representation of a value that is in the range of the <c>decimal</c> data type; <c>false</c> otherwise.  The method also returns <c>false</c> if it is passed the empty string.</returns>
        [UsedImplicitly]
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

        /// <summary>Determines whether the <paramref name="value" /> passed is the string representation of a 32-bit <c>int</c> or not.</summary>
        /// <param name="value">(Required.) String containing the value or not.</param>
        /// <returns><c>true</c> if the string passed in <paramref name="value" /> is the string representation of a value that is in the range of the 32-bit <c>int</c> data type; <c>false</c> otherwise.  The method also returns <c>false</c> if it is passed the empty string.</returns>
        [UsedImplicitly]
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

        /// <summary>Performs a culture-invariant, case-insensitive, OR match of the <paramref name="value" /> against the <paramref name="choices" /> provided.</summary>
        /// <param name="value">  Value to match.</param>
        /// <param name="choices">Choices to match against.</param>
        /// <returns><c>true</c> if the string <paramref name="value" /> matches one or more of the <paramref name="choices" />; <c>false</c> otherwise.</returns>
        /// <remarks>If <paramref name="value" /> is the empty string, or if <paramref name="choices" /> is the empty collection, then this method returns <c>false</c>.</remarks>
        public static bool IsOneOf(this string value,
            IEnumerable<string> choices) =>
            !string.IsNullOrWhiteSpace(value) && choices != null &&
            choices.Any(value.EqualsNoCase);

        /// <summary>Validates whether <paramref name="value" /> is a valid email address or not.</summary>
        /// <param name="value">String to be checked.</param>
        /// <returns>true if the string contains a valid email address value; false otherwise.</returns>
        public static bool IsValidEmail(string value)
        {
            IsEmailAddressInvalid = false;
            if (string.IsNullOrWhiteSpace(value)) return false;

            // Use IdnMapping class to convert Unicode domain names.
            value = Regex.Replace(value, @"(@)(.+)$", DomainMapper);

            // Return true if value is in valid e-mail format.
            return !IsEmailAddressInvalid && Regex.IsMatch(
                value,
                @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                RegexOptions.IgnoreCase
            );
        }

        /// <summary>Pluralizes the word passed in, applying language rules from the specified <see cref="culture" />.</summary>
        /// <param name="word">   Word to be pluralized.</param>
        /// <param name="culture">Specifies the <see cref="CultureInfo" /> to use when applying language rules.</param>
        /// <returns>The <paramref name="word" /> if it is not plural; otherwise, a string containing the plural version of the <paramref name="word" />.</returns>
        /// <remarks>If the empty string is passed for <paramref name="word" />, then this method returns the empty string.</remarks>
        public static string PluralizeWord(this string word,
            CultureInfo culture)
        {
            // If we are given blank input, then send blank output.
            if (string.IsNullOrWhiteSpace(word)) return string.Empty;

            var service = PluralizationService.CreateService(culture);
            return service.IsPlural(word) ? word : service.Pluralize(word);
        }

        /// <summary>Pluralizes the word passed in, using the current UI culture.</summary>
        /// <param name="word">String containing the word to be pluralized.</param>
        /// <returns>The <paramref name="word" /> if it is not plural; otherwise, a string containing the plural version of the <paramref name="word" />.</returns>
        /// <remarks>If the empty string is passed for <paramref name="word" />, then this method returns the empty string.</remarks>
        [UsedImplicitly]
        public static string PluralizeWord(this string word) =>
            PluralizeWord(word, CultureInfo.CurrentUICulture);

        /// <summary>Strips all punctuation and numeric digits from a string and trims the result.</summary>
        /// <param name="value">String to have punctuation and numbers stripped.</param>
        /// <returns>String after transformation.</returns>
        /// <remarks>If the empty string is passed to <paramref name="value" />, then the empty string is returned.</remarks>
        [UsedImplicitly]
        public static string RemoveDigitsAndPunctuation(this string value) =>
            string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : Regex.Replace(
                    Regex.Replace(value.Trim(), @"[^\w\s]", string.Empty),
                    @"[\d-]", string.Empty
                ).Trim();

        /// <summary>Removes any trailing '\' characters from the string provided in <paramref name="value" />.</summary>
        /// <param name="value">(Required.) String containing the value to be stripped of trailing backslash characters.</param>
        /// <returns>Same as <paramref name="value" />, but with no trailing backslash characters.</returns>
        /// <remarks>If this method is passed the empty string, then this method returns the empty string.</remarks>
        [UsedImplicitly]
        public static string RemoveTrailingBackslashes(this string value) =>
            string.IsNullOrWhiteSpace(value) ? string.Empty :
            value.EndsWith(@"\") ? value.Remove(value.Length - 1) : value;

        /// <summary>Gets a value indicating whether <paramref name="text" /> starts with any of the values in the <paramref name="list" />.</summary>
        /// <param name="text">String to be checked.</param>
        /// <param name="list">List of entries.</param>
        /// <returns>true if the <paramref name="text" /> starts with any of the entries in <paramref name="list" />.</returns>
        /// <remarks>This method performs a case-insensitive search.  It returns <c>false</c> if passed the empty string for <paramref name="text" /> or the empty collection for <paramref name="list" />.</remarks>
        [UsedImplicitly]
        public static bool StartsWithAnyOf(this string text,
            IEnumerable<string> list) =>
            !string.IsNullOrWhiteSpace(text) && list.Any(text.StartsWithNoCase);

        /// <summary>Tells whether the <paramref name="value" /> starts with the substring <paramref name="searchText" />, ignoring case.</summary>
        /// <param name="value">     Value to search.</param>
        /// <param name="searchText">Suspected starting substring.</param>
        /// <returns><c>true</c> if <paramref name="value" /> starts with the <paramref name="searchText" />. <c>false</c> otherwise.</returns>
        /// <remarks>If <paramref name="value" /> is the empty string or if <paramref name="searchText" /> is the empty string, then this method returns <c>false</c>.</remarks>
        public static bool StartsWithNoCase(this string value,
            string searchText) =>
            !string.IsNullOrWhiteSpace(value) &&
            !string.IsNullOrWhiteSpace(searchText) && value.ToLowerInvariant()
                .StartsWith(searchText.ToLowerInvariant());

        /// <summary>Formats a string using the <paramref name="format" /> and <paramref name="args" />.</summary>
        /// <param name="format">(Required.) String containing the format.</param>
        /// <param name="args">(Optional.) Collection of args whose values are to be replaced in the format string.</param>
        /// <returns>A string with the format placeholders replaced by the args.</returns>
        /// <remarks>This method is just an alias for <see cref="T:System.String.Format" />. It is here to provide a way to translate VB to C# code and still use the moniker Sub from VB that does the same operation.  If this method is passed the empty string for <paramref name="format" />, then the return value is the empty string. </remarks>
        [UsedImplicitly]
        public static string Sub(this string format, params object[] args) =>
            string.IsNullOrWhiteSpace(format)
                ? string.Empty
                : string.Format(format, args);

        /// <summary>Turns the specified <paramref name="phrase" /> into an all-caps acronym, if a corresponding entry is not found in our dictionary fields of short, non-acronym terms, i.e., <see cref="F:xyLOGIX.Core.Extensions.StringExtensions.ShortWordsThatAreNotAcronyms" />.</summary>
        /// <param name="phrase">(Required.) String containing the phrase to turn into an acronym.</param>
        /// <returns>Acronym converted from <paramref name="phrase" />.</returns>
        /// <remarks>If this method is passed the empty or whitespace string, then it returns the empty string.  If this method is passed a word or phrase that is short, but not an acronym, then the input is returned with no alteration.</remarks>
        [UsedImplicitly]
        public static string ToAcronym(this string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase)) return string.Empty;

            // split the phrase on space and remove everything that is a short
            // phrase or word but is not an acronym, such as the word 'an'.
            var parts = phrase.ToUpperInvariant().Split(
                new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries
            ).ToList();

            if (parts.Any())
                parts.RemoveAll(s => s.IsOneOf(ShortWordsThatAreNotAcronyms));

            // If we ended up removing all parts from the list, then return the empty string
            return !parts.Any()
                ? string.Empty
                : parts.Aggregate(
                    string.Empty,
                    (current, part) => current + ToAcronymLetter(part)
                );
        }

        /// <summary>Forces all characters in the input string, <paramref name="value" />, to be ASCII-encoded characters only.  If any Unicode characters are found in <paramref name="value" />, then they are mapped back into the range of ASCII-encoded values.</summary>
        /// <param name="value">(Required.) String containing the characters to be processed.</param>
        /// <returns>Same string as <paramref name="value" />, except that all characters are now ASCII-encoded.</returns>
        /// <remarks>If this method is passed the empty or whitespace string for <paramref name="value" />, then this method returns the empty string.</remarks>
        [UsedImplicitly]
        public static string ToASCII(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var sb = new StringBuilder();
            foreach (var c in value)
                sb.Append(
                    c > 127 ? @"\u" + ((int)c).ToString("x4") : c.ToString()
                );

            return sb.ToString().Replace("%F1", "ñ");
        }

        /// <summary>Turns a GUID into a string representation but removes all the '{', '}' and '-' from the string representation, so that the string representation contains only letters and/or numbers.</summary>
        /// <param name="guid">Reference to a <see cref="T:System.Guid" /> to turn into a string of letters and numbers.</param>
        /// <returns>String representation with no '{', '}' and '-' in the string representation, so that the string representation contains only letters and/or numbers.</returns>
        [UsedImplicitly]
        public static string ToGuidWithNoPunctuation(this Guid guid) =>
            guid.ToString("N");

        /// <summary>Returns a value that is the same as the string specified, but in Initial Caps format.</summary>
        /// <param name="value">Value whose case should be changed.</param>
        /// <returns>String with the casing changed to InitialCaps.</returns>
        /// <remarks>If this method is passed the empty or whitespace string, then it returns the empty string.</remarks>
        public static string ToInitialCaps(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var array = value.Trim().Split(' ');
            if (!array.Any()) return string.Empty;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].StartsWith("#") || // Leave hashtags alone
                    string.IsNullOrWhiteSpace(array[i])) continue;

                array[i] = array[i].ToLower();
                if (i == 0 &&
                    AlwaysCapitalizeIfFirstWord.ContainsNoCase(array[i]))
                    array[i] = DoInitialCaps(array[i]);
                if (array[i].Contains("-"))
                {
                    // split the string, and call this method recursively on the parts
                    var parts = array[i].Split('-');
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
                    array[i] = array[i].ToUpperInvariant();
                }
                else if (!CapitalizeableAsFirstWords.ContainsNoCase(array[i]) &
                         !array[i].IsRomanNumerals() &
                         !char.IsDigit(array[i][0]) &&
                         !"and/or".Equals(array[i]))
                {
                    array[i] = DoInitialCaps(array[i]);
                }
                else if (array[i].IsRomanNumerals())
                {
                    // capitalize the whole word if it's only Roman numerals
                    array[i] = array[i].ToUpperInvariant();
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

        /// <summary>Turns a delimited <see cref="T:System.String" /> into a collection of strings with one delimited entry per element.</summary>
        /// <param name="source">(Required.) String containing the text to be transformed.</param>
        /// <param name="separators">Collection of strings specifying the delimiter(s) to split upon.</param>
        /// <returns>Collection of strings containing the delimited entries.</returns>
        /// <remarks>Any empty entries in the resultant collection are removed.  If the empty string is provided as input to this method, then the method returns the empty string.  If no separators are specified, then the empty collection is returned.</remarks>
        public static IEnumerable<string>
            ToList(this string source, params string[] separators) =>
            !string.IsNullOrWhiteSpace(source) && separators != null &&
            separators.Any()
                ? string.IsNullOrWhiteSpace(source)
                    ?
                    Enumerable.Empty<string>().ToList()
                    : source.Split(
                        separators, StringSplitOptions.RemoveEmptyEntries
                    ).ToList()
                : Enumerable.Empty<string>().ToList();

        /// <summary>Translates each character of the provided <paramref name="value" />, character-by-character, to Unicode encoding.  This method performs the inverse operation of the <see cref="M:xyLOGIX.Core.Extensions.StringExtensions.ToASCII" /> method.</summary>
        /// <param name="value">(Required.) String containing the text to be re-encoded.</param>
        /// <returns>String containing the re-encoded corresponding text to that in <paramref name="value" />; or the empty string if the empty string is provided to this method.</returns>
        [UsedImplicitly]
        public static string ToUnicode(this string value) =>
            string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : Regex.Replace(
                    value, @"\\u(?<Value>[a-zA-Z0-9]{4})",
                    m => ((char)int.Parse(
                        m.Groups["Value"].Value, NumberStyles.HexNumber
                    )).ToString(CultureInfo.InvariantCulture)
                );

        /// <summary>Trims the <paramref name="currentLine" /> of text; i.e., removes whitespace both before and after the text.</summary>
        /// <param name="currentLine">(Required.) Text to trim.</param>
        /// <returns>Trimmed text.</returns>
        /// <remarks>If the empty or whitespace string is provided for <paramref name="currentLine" />, then the empty string is returned by this method.</remarks>
        public static string TrimLine(this string currentLine) =>
            !string.IsNullOrWhiteSpace(currentLine)
                ? currentLine.Trim()
                : string.Empty;

        /// <summary>Helper method to aid in transforming text casing of a string to Initial Caps.</summary>
        /// <param name="value">(Required.) String containing the word that needs to be initial-capitalized.</param>
        /// <returns>Word provided in <paramref name="value" /> with its first letter replaced with a capital letter and all the remaining letters as lowercase.</returns>
        /// <remarks>If this method is provided with the empty or whitespace string, then this method returns the empty string.</remarks>
        private static string DoInitialCaps(string value) =>
            string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : value[0].ToString(CultureInfo.InvariantCulture).ToUpper() +
                  value.ToLowerInvariant().Substring(1, value.Length - 1);

        /// <summary>Helper for determining whether strings contain valid email addresses.</summary>
        /// <param name="match">Reference to an instance of <see cref="T:System.Text.RegularExpressions.Match" /> that resulted from a regex search.</param>
        /// <returns>Correctly-formatted domain-name matching value.</returns>
        /// <remarks>This method also sets the value of the <see cref="P:xyLOGIX.Core.Extensions.StringExtensions.IsEmailAddressInvalid" /> property to <c>true</c> in the event that an error occurs.</remarks>
        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.

            var domainName = match.Groups[2].Value;
            try
            {
                domainName = new IdnMapping().GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                IsEmailAddressInvalid = true;
            }

            return match.Groups[1].Value + domainName;
        }

        /// <summary>Determines whether the current word in the text being parsed for a character-casing operation is </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static bool IsAcronymOrStateAbbr(IList<string> array, int i)
        {
            if (array == null || !array.Any() ||
                string.IsNullOrWhiteSpace(array[i]) ||
                ShortWordsThatAreNotAcronyms.ContainsNoCase(array[i]))
                return false;

            // something can be classed as an acronym if (a) it's not in the source of "special"
            // words, such as "The," "An", "Or", etc., and (b) it has two or more characters
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
                return StateAbbrList.Contains(array[i]) &&
                       array[i - 1].EndsWith(",") ||
                       !CapitalizeableAsFirstWords.ContainsNoCase(array[i]) &
                       AcronymList.ContainsNoCase(array[i]);

            return false;
        }

        /// <summary>Determines whether the passed <see cref="string" /> contains Roman numerals.</summary>
        /// <param name="value">Value to be checked.</param>
        /// <returns>TRUE if the value contains Roman numerals; FALSE otherwise.</returns>
        private static bool IsRomanNumerals(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            var regex = new Regex(
                @"(?i)^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$"
            );
            var result = regex.IsMatch(value);
            return result;
        }

        /// <summary>Gets a value indicating whether a special word, such as 'The' or 'Dr.' or 'Mr.' or 'Ms.' or 'A' etc. is the first word of a word and still needs to be initial-capitalized.</summary>
        /// <param name="words">      Array of words (a phrase split on spaces, etc.)</param>
        /// <param name="currentWord">Current word being checked.</param>
        /// <returns></returns>
        private static bool IsSpecialWordAtBeginningOfPhrase(string[] words,
            string currentWord)
        {
            if (words == null || !words.Any()) return false;

            if (string.IsNullOrWhiteSpace(currentWord)) return false;

            return (currentWord.EndsWith(".") &&
                    EqualsNoCase(currentWord, words.First())
                   ) // this is most likely someone's title
                   | CapitalizeableAsFirstWords
                       .ContainsNoCase(
                           currentWord
                       ) // any words appearing in this array that are at the beginning of our phrase, should always be initial-capitalized
                   && EqualsNoCase(currentWord, words.First());
        }

        /// <summary>Determines whether the current element in the list of words being parsed (as part of a character-casing operation) is the component of common names for US streets.</summary>
        /// <param name="array">(Required.) Collection of words from the text being parsed.</param>
        /// <param name="i">(Required.) Index into the <paramref name="array" /> of the current word being parsed.</param>
        /// <returns><c>true</c> if the current word belongs as part of the name of common US streets; <c>false</c> otherwise.</returns>
        /// <remarks>If this method is provided with the empty collection or an array index outside the bounds of the collection, then this method returns <c>false</c>.</remarks>
        private static bool
            IsStreetNameComponent(IReadOnlyList<string> array, int i) =>
            array != null && array.Any() && i < array.Count &&
            (i + 1 >= array.Count
                ? NamesOfStreetsThatShouldBeCapitalized.ContainsNoCase(array[i])
                : NamesOfStreetsThatShouldBeCapitalized.ContainsNoCase(
                    array[i]
                ) | NamesOfStreetsThatShouldBeCapitalized.ContainsNoCase(
                    array[i + 1]
                ));

        /// <summary>Uses the first letter (turned into being uppercase, if necessary) of the <paramref name="word" /> provided to be one of the letters of an acronym that is being built, e.g., from a phrase, using the first letter of each of the words of the phrase as each of the corresponding letters of the resulting acronym.</summary>
        /// <param name="word">(Required.)  String containing the word whose first letter should be made into an corresponding acronym letter.</param>
        /// <returns>String containing the letter(s) to be utilized in the acronym.</returns>
        /// <remarks>If <paramref name="word" /> is the empty or whitespace string, then this method returns the empty string.</remarks>
        private static string ToAcronymLetter(string word) =>
            string.IsNullOrWhiteSpace(word) ? string.Empty :
            "Reengagement".EqualsNoCase(word) ? "RE" :
            word[0].ToString(CultureInfo.InvariantCulture).ToUpperInvariant();
    }
}