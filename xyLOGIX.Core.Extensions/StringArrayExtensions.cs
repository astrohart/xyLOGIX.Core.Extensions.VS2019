using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
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
    }
}