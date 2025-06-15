using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Formatters;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for <see cref="T:System.Object" />.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ObjectExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.ObjectExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ObjectExtensions() { }

        /// <summary>
        /// Converts a reference to <see cref="T:System.Object" /> to a string
        /// representation suitable for logging.
        /// </summary>
        /// <param name="value">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Object" /> that represents the object that is to be
        /// converted to a log-friendly string representation.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed as the argument of the
        /// <paramref name="value" /> parameter, then the method returns the string
        /// <c>&lt;null&gt;</c>.
        /// <para />
        /// This method uses PostSharp's formatting system to generate the string
        /// representation.
        /// <para />
        /// If PostSharp's formatter is not available, this method attempts to call
        /// <see cref="M:System.Object.ToString" /> on the specified
        /// <paramref name="value" />; failing that, the method returns
        /// <c>&lt;error&gt;</c>.
        /// </remarks>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the textual
        /// representation of the object; otherwise a <see cref="T:System.String" />
        /// containing the text <c>&lt;error&gt;</c>.
        /// </returns>
        [DebuggerStepThrough]
        public static string ToLogRepresentation([NotLogged] this object value)
        {
            var result = "<error>";

            try
            {
                if (value == null) return "<null>";

                // Try PostSharp’s registry first.
                var formatter = LoggingServices.Formatters.Get(value.GetType());
                if (formatter == null) return result;

                using (var sb = new UnsafeStringBuilder())
                {
                    formatter.Write(sb, value);

                    result = sb.Length > 0 ? sb.ToString() :
                        value is string s ? $"'{s}'" : value.ToString();
                }
            }
            catch (Exception ex)
            {
                DebugUtils.LogException(ex);

                result = "<error>";
            }

            return result;
        }
    }
}