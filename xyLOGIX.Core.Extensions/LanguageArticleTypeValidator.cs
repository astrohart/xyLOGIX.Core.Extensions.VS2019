using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Validates whether certain value(s) are within the defined value set of the
    /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> enumeration.
    /// </summary>
    public class LanguageArticleTypeValidator : ILanguageArticleTypeValidator
    {
        /// <summary>Empty, <see langword="static" /> constructor to prohibit direct allocation of this class.</summary>
        [Log(AttributeExclude = true)]
        static LanguageArticleTypeValidator() { }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private LanguageArticleTypeValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that
        /// implements the
        /// <see cref="T:xyLOGIX.Core.Extensions.Interfaces.ILanguageArticleTypeValidator" />
        /// interface.
        /// </summary>
        public static ILanguageArticleTypeValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new LanguageArticleTypeValidator();

        /// <summary>
        /// Determines whether the language article <paramref name="type" /> value
        /// passed is within the value set that is defined by the
        /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> enumeration.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> values that is to
        /// be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the language article
        /// <paramref name="type" /> falls within the defined value set;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValid(LanguageArticleType type)
        {
            var result = false;

            try
            {
                // Dump the argument of the parameter, 'type', to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"LanguageArticleTypeValidator.IsValid: type = '{type}'"
                );

                /*
                 * For cybersecurity reasons, and to defeat reverse-engineering,
                 * check the value of the 'type' parameter to ensure that it
                 * is not set to a value outside the set of valid values defined
                 * by the xyLOGIX.Core.Extensions.LanguageArticleType
                 * enumeration.
                 *
                 * In principle, since all C# enums devolve to integer values, a
                 * hacker could insert a different value into the CPU register that the
                 * 'type' parameter is read from and thereby make this application
                 * do something it's not intended to do.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"LanguageArticleTypeValidator.IsValid: Checking whether the value of the 'type' parameter, i.e., '{type}', is within the defined value set of its enumerated data type..."
                );

                // Check whether the value of the 'type' parameter is within the defined value set of its 
                // enumeration data type.  If this is not the case, then write an error message to the log
                // file, and then terminate the execution of this method while returning the default return
                // value.
                if (!Enum.IsDefined(typeof(LanguageArticleType), type))
                {
                    // The value of the 'type' parameter is NOT within the defined value set for its enumerated data type.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The value of the 'type' parameter, i.e., '{type}', is NOT within the defined value set of its enumerated data type.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"LanguageArticleTypeValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"LanguageArticleTypeValidator.IsValid: *** SUCCESS *** The value of the 'type' parameter, i.e., '{type}', is within the defined value set of its enumerated data type.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "LanguageArticleTypeValidator.IsValid: Checking whether the 'Unknown' value has NOT been specified for the 'type' parameter..."
                );

                // Check whether the 'Unknown' value has been specified for the 'type' parameter.  If this is the case, then
                // write an error message to the log file, and then terminate the execution of this method, returning the default
                // return value in order to indicate that this method failed.
                if (LanguageArticleType.Unknown.Equals(type))
                {
                    // The 'Unknown' value has been specified for the 'type' parameter.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The 'Unknown' value has been specified for the 'type' parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"LanguageArticleTypeValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "LanguageArticleTypeValidator.IsValid: *** SUCCESS *** The 'Unknown' value has NOT been specified for the 'type' parameter.  Proceeding..."
                );

                /*
                 * If we made it here, then assume that the input data is valid.
                 */

                result = true;
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
