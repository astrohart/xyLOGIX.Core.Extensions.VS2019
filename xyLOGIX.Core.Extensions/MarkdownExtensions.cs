using PostSharp.Patterns.Diagnostics;
using System;
using System.Xml.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension method(s) for manipulating Markdown text.
    /// </summary>
    public static class MarkdownExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.MarkdownExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MarkdownExtensions() { }

        /// <summary>
        /// Wraps the <paramref name="code" /> into Markdown backticks safely.
        /// </summary>
        /// <param name="code">
        /// (Required.) A <see cref="T:System.String" /> containing the content that is to
        /// be wrapped in Markdown backticks.
        /// </param>
        /// <remarks>
        /// See also
        /// <a
        ///     href="http://meta.stackexchange.com/questions/55437/how-can-the-backtick-character-be-included-in-code" />
        /// .
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// corresponding Markdown; otherwise, the method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// </returns>
        public static string AsCode(this string code)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(code)) return result;

                var backticks = "`";
                while (code.Contains(
                           backticks, StringComparison.InvariantCulture
                       ))
                {
                    backticks += "`";
                }

                result =
                    code.StartsWith("`", StringComparison.Ordinal) ||
                    code.EndsWith("`", StringComparison.Ordinal)
                        ? $"{backticks} {code} {backticks}"
                        : $"{backticks}{code}{backticks}";
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
        /// Attempts to detect leading whitespace in the value of the specified
        /// <paramref name="node" /> and, if found, carries the whitespace over to the
        /// resultant Markdown span as a whitespace character.
        /// </summary>
        /// <param name="node">
        /// (Required.) Reference to an instance of <see cref="T:System.Xml.Linq.XNode" />
        /// that represents the XML node that is to be examined for leading whitespace.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed as the argument of
        /// the <paramref name="node" /> parameter, then the method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// <para />
        /// The method also returns the <see cref="F:System.String.Empty" /> value if the
        /// specified <paramref name="node" /> is not of type
        /// <see cref="T:System.Xml.Linq.XText" />.
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// resultant Markdown; otherwise, the method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// </returns>
        public static string AsSpanMargin([NotLogged] this XNode node)
        {
            var result = string.Empty;

            try
            {
                if (node == null) return result;
                if (!(node is XText text)) return result;
                if (string.IsNullOrWhiteSpace(text.Value)) return result;

                if (!text.Value.StartsWith(" ", StringComparison.Ordinal))
                    return result;

                result = " "; // a single whitespace character
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
        /// Escapes the specified <paramref name="content" /> by replacing all backticks
        /// with a backtick preceded by a backslash, so that the content can be safely used
        /// in Markdown as-is.
        /// </summary>
        /// <param name="content">
        /// (Required.) A <see cref="T:System.String" /> containing the content that is to
        /// be escaped.
        /// </param>
        /// <remarks>
        /// If <see langword="null" />, a blank <see cref="T:System.String" />, or
        /// the <see cref="F:System.String.Empty" /> value is passed as the argument of the
        /// parameter, <paramref name="content" />, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// <para />
        /// The method is idempotent if the <paramref name="content" /> does not contain
        /// any backticks.
        /// </remarks>
        /// <returns>The escaped content.</returns>
        public static string EscapeMarkdownText(this string content)
        {
            var result = content;

            try
            {
                if (string.IsNullOrWhiteSpace(content)) return string.Empty;
                if (!content.Contains("`", StringComparison.InvariantCulture))
                    return content;

                // escape the backticks in the content
                result = content.Replace(
                    "`", @"\`", StringComparison.InvariantCulture
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
        /// Generates an anchor for the specified <paramref name="hyperlink" />.
        /// </summary>
        /// <param name="hyperlink">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the hyperlink reference destination.
        /// </param>
        /// <remarks>
        /// If <see langword="null" />, a blank <see cref="T:System.String" />, or the
        /// <see cref="F:System.String.Empty" /> value is passed as the argument of the
        /// <paramref name="hyperlink" /> parameter, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the anchor
        /// for the specified <paramref name="hyperlink" />; otherwise, the method returns
        /// the <see cref="F:System.String.Empty" /> value.
        /// </returns>
        public static string ToAnchor(this string hyperlink)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(hyperlink)) return result;

                result = $"<a name='{hyperlink}'></a>\n";
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
        /// Generates a "to here" link for the <paramref name="hyperlink" />.
        /// </summary>
        /// <param name="hyperlink">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the hyperlink reference destination.
        /// </param>
        /// <returns>The "to here" link for the <paramref name="hyperlink" />.</returns>
        public static string ToHereLink(this string hyperlink)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(hyperlink)) return result;

                result = $"[#](#{hyperlink} 'Go To Here')";
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