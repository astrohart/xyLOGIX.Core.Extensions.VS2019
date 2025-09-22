using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for instances of object(s) that implement the
    /// <see cref="T:System.Collections.Generic.ISet`1" /> interface.
    /// </summary>
    public static class SetExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.SetExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static SetExtensions() { }

        /// <summary>
        /// Adds a range of data value(s) from the specified <paramref name="source" />
        /// collection to the <paramref name="target" /> set.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of the individual element(s) of the
        /// <paramref name="target" /> and <paramref name="source" />.
        /// </typeparam>
        /// ///
        /// <param name="target">
        /// (Required.) Reference to a collection of element(s), each of which is of type,
        /// <typeparamref name="T" />, that implements the
        /// <see cref="T:System.Collections.Generic.ISet`1" /> interface that is to receive
        /// the element(s) of <paramref name="source" />.
        /// </param>
        /// <param name="source">
        /// (Required.) Reference to a collection of element(s), each
        /// of which is of type, <typeparamref name="T" />, that is enumerated and added to
        /// the <paramref name="target" />.
        /// </param>
        /// <remarks>
        /// If the <paramref name="source" /> collection is passed a
        /// <see langword="null" /> reference, or has zero element(s), then this method
        /// does nothing.
        /// <para />
        /// This method also does nothing if a <see langword="null" /> reference is passed
        /// for the <paramref name="target" /> collection.
        /// If an element from the <paramref name="source" /> collection is
        /// already a member of the <paramref name="target" /> collection, then it is
        /// skipped.
        /// <para />
        /// <see langword="null" /> references are also skipped.
        /// </remarks>
        [return: NotLogged]
        public static void AddRange<T>(
            [NotLogged] this ISet<T> target,
            [NotLogged] IEnumerable<T> source
        )
        {
            try
            {
                if (target == null) return;
                if (source == null) return;

                var sourceData = source.ToArray();
                if (sourceData.Length <= 0) return;

                foreach (var value in sourceData)
                {
                    if (value == null) continue;

                    target.Add(value);
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