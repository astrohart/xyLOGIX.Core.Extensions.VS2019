using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Helper methods for collections. </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.EnumerableExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static EnumerableExtensions() { }

        /// <summary>
        /// Determines whether any of the element(s) of the specified
        /// <paramref name="collection" /> are equal to any of the specified
        /// <paramref name="values" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of the individual elements of the
        /// specified <paramref name="collection" />.
        /// </typeparam>
        /// <param name="collection">
        /// (Required.) Collection of values, all of the type,
        /// <typeparamref name="T" />, that is to be searched.
        /// </param>
        /// <param name="values">(Required.) One or more values that are to be matched.</param>
        /// <returns>
        /// <see langword="true" /> if even one match is found;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool AnyEqualAnyOf<T>(
            this IEnumerable<T> collection,
            params T[] values
        )
        {
            var result = false;

            try
            {
                if (collection == null) return result;
                if (collection.ToArray()
                              .Length <= 0) return result;
                if (values == null) return result;
                if (values.Length <= 0) return result;
                if (values.Length == 1) return AnyEqual(collection, values[0]);

                foreach (var element in collection)
                {
                    if (element == null) continue;
                    if (!element.IsAnyOf(values)) continue;

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
        /// Determines if any of the element(s) of the specified
        /// <paramref name="collection" /> happen to equal the specified
        /// <paramref name="value" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of the individual elements of the
        /// specified <paramref name="collection" />.
        /// </typeparam>
        /// <param name="collection">
        /// (Required.) Collection of values, all of the type,
        /// <typeparamref name="T" />, that is to be searched.
        /// </param>
        /// <param name="value">(Required.) The value that is to be matched.</param>
        /// <returns>
        /// <see langword="true" /> if at least one element of the specified
        /// <paramref name="collection" /> matches the specified <paramref name="value" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool AnyEqual<T>(this IEnumerable<T> collection, T value)
        {
            var result = false;

            try
            {
                if (collection == null) return result;
                if (collection.ToArray()
                              .Length <= 0) return result;

                foreach (var element in collection.ToArray())
                {
                    if (element == null) return result;
                    if (!value.Equals(element)) return result;

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
        /// A more fluent version of the LINQ <c>Except</c> extension method; this method
        /// takes a <paramref name="source" /> enumerable collection, and filters out just
        /// the element equalling <paramref name="value" /> from it.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of each element of the source
        /// enumerable collection.
        /// </typeparam>
        /// <param name="source">
        /// (Required.) The enumerable collection from which to filter
        /// the <paramref name="value" />.
        /// </param>
        /// <param name="value">
        /// (Required.) The value to be removed from the
        /// <paramref name="source" />.
        /// </param>
        /// <returns>
        /// A sequence containing all elements from the <paramref name="source" />,
        /// except for any that match the specified <paramref name="value" />.
        /// The original <paramref name="source" /> is not cloned or modified.
        /// </returns>
        [DebuggerStepThrough, Log(AttributeExclude = true)]
        public static IEnumerable<T> Except<T>(
            this IEnumerable<T> source,
            T value
        )
        {
            if (source == null) yield break;
            if (!source.Any()) yield break;

            foreach (var element in source)
            {
                bool shouldYield;

                try
                {
                    // Check if element equals the specified value
                    shouldYield = !element.Equals(value);
                }
                catch (Exception ex)
                {
                    // Log and decide whether to skip or include the element in case of error
                    DebugUtils.LogException(ex);
                    shouldYield =
                        true; // Default behavior: don't filter out on exception
                }

                if (shouldYield)
                {
                    yield return element;
                }
            }
        }

        /// <summary>
        /// Runs the specified <paramref name="action" /> for each element of the
        /// specified <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Name of the type of each element of the
        /// <paramref name="collection" />.
        /// </typeparam>
        /// <param name="collection">
        /// (Required.) Reference to an instance of a collection
        /// of elements, each of which are of type <typeparamref name="T" />.
        /// </param>
        /// <param name="action">
        /// (Required.) Reference to an instance of a
        /// <see cref="T:System.Action{T}" /> <see langword="delegate" /> that is executed
        /// for each of the elements in the collection, with the corresponding element
        /// passed as its input.
        /// </param>
        /// <remarks>
        /// If the <paramref name="collection" /> is empty, or if the
        /// <paramref name="action" /> is <see langword="null" />, then this method does
        /// nothing.
        /// </remarks>
        public static void ForEach<T>(
            this IList<T> collection,
            Action<T> action
        )
        {
            if (collection == null) return;
            if (action == null) return;
            if (!collection.Any()) return;

            foreach (var item in collection)
                action(item);
        }

        /// <summary>
        /// Runs the specified <paramref name="action" /> for each element of the
        /// specified <paramref name="collection" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Name of the type of each element of the
        /// <paramref name="collection" />.
        /// </typeparam>
        /// <param name="collection">
        /// (Required.) Reference to an instance of a collection
        /// of elements, each of which are of type <typeparamref name="T" />.
        /// </param>
        /// <param name="action">
        /// (Required.) Reference to an instance of a
        /// <see cref="T:System.Action{T}" /> <see langword="delegate" /> that is executed
        /// for each of the elements in the collection, with the corresponding element
        /// passed as its input.
        /// </param>
        /// <remarks>
        /// If the <paramref name="collection" /> is empty, or if the
        /// <paramref name="action" /> is <see langword="null" />, then this method does
        /// nothing.
        /// </remarks>
        public static void ForEach<T>(
            this IEnumerable<T> collection,
            Action<T> action
        )
        {
            if (collection == null) return;
            if (action == null) return;
            if (!collection.Any()) return;

            foreach (var item in collection)
                action(item);
        }

        /// <summary>
        /// Compares the <paramref name="value" /> object with the
        /// <paramref name="testObjects" /> provided, to see if any of the
        /// <paramref name="testObjects" /> is a match.
        /// </summary>
        /// <typeparam name="T"> Type of the object to be tested. </typeparam>
        /// <param name="value"> Source object to check. </param>
        /// <param name="testObjects">
        /// Object or objects that should be compared to value
        /// with the <see cref="M:System.Object.Equals" /> method.
        /// </param>
        /// <returns>
        /// True if any of the <paramref name="testObjects" /> equals the value;
        /// false otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsAnyOf<T>(this T value, params T[] testObjects)
            => testObjects.Contains(value);

        /// <summary>
        /// Shuffles the elements of the sequence into a random order, and then
        /// returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.
        /// </summary>
        /// <typeparam name="T"> Type of the elements of the sequence. </typeparam>
        /// <param name="quote"> Sequence to be shuffled. </param>
        /// <returns>
        /// A new sequence, with the order of the elements randomized, according
        /// to the Fisher-Yates-Durstenfeld shuffle.
        /// </returns>
        /// <remarks>
        /// see, e.g.,
        /// <a
        ///     href="http://stackoverflow.com/questions/5807128/an-extension-method-on-ienumerable-needed-for-shuffling">
        /// this
        /// StackOverflow article.
        /// </a>
        /// </remarks>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> quote)
        {
            var rng = new Random();
            return quote.Shuffle(rng);
        }

        /// <summary>
        /// Returns all the elements of the <paramref name="quote" /> enumerable
        /// object, except for the last.
        /// </summary>
        /// <typeparam name="T"> Name of the type of item in the collection. </typeparam>
        /// <param name="quote"> Reference to an enumerable collection. </param>
        /// <returns>
        /// Enumerable iterator over the collection that yields every item in the
        /// collection, except for the last.
        /// </returns>
        public static IEnumerable<T> TakeAllButLast<T>(
            this IEnumerable<T> quote
        )
        {
            if (quote == null) throw new ArgumentNullException(nameof(quote));
            using (var it = quote.GetEnumerator())
            {
                var hasRemainingItems = false;
                var isFirst = true;
                var item = default(T);

                do
                {
                    hasRemainingItems = it.MoveNext();
                    if (!hasRemainingItems) continue;
                    if (!isFirst) yield return item;
                    item = it.Current;
                    isFirst = false;
                } while (hasRemainingItems);
            }
        }

        /// <summary>
        /// Shuffles the elements of the sequence into a random order, and then
        /// returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle. Uses
        /// the random-number generator passed in the <paramref name="rng" /> parameter.
        /// </summary>
        /// <typeparam name="T"> Type of the elements of the sequence. </typeparam>
        /// <param name="quote"> Sequence to be shuffled. </param>
        /// <param name="rng">
        /// A <see cref="T:System.Random" /> instance with which to
        /// generate new random values for the shuffle operation.
        /// </param>
        /// <returns>
        /// A new sequence, with the order of the elements randomized, according
        /// to the Fisher-Yates-Durstenfeld shuffle.
        /// </returns>
        /// <remarks>
        /// see, e.g.,
        /// <a
        ///     href="http://stackoverflow.com/questions/5807128/an-extension-method-on-ienumerable-needed-for-shuffling">
        /// this
        /// StackOverflow article.
        /// </a>
        /// </remarks>
        private static IEnumerable<T> Shuffle<T>(
            this IEnumerable<T> quote,
            Random rng
        )
        {
            if (quote == null) throw new ArgumentNullException(nameof(quote));
            if (rng == null) throw new ArgumentNullException(nameof(rng));

            return quote.ShuffleIterator(rng);
        }

        /// <summary>
        /// Shuffles the elements of the sequence into a random order, and then
        /// returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle. Uses
        /// the random-number generator passed in the <paramref name="rng" /> parameter.
        /// Behaves like the
        /// <see cref="M:xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle" /> method,
        /// although this method can be utilized as an iterator.
        /// </summary>
        /// <typeparam name="T"> Type of the elements of the sequence. </typeparam>
        /// <param name="quote"> Sequence to be shuffled. </param>
        /// <param name="rng">
        /// A <see cref="T:System.Random" /> instance with which to
        /// generate new random values for the shuffle operation.
        /// </param>
        /// <returns>
        /// A new sequence, with the order of the elements randomized, according
        /// to the Fisher-Yates-Durstenfeld shuffle.
        /// </returns>
        /// <remarks>
        /// see, e.g.,
        /// <a
        ///     href="http://stackoverflow.com/questions/5807128/an-extension-method-on-ienumerable-needed-for-shuffling">
        /// this
        /// StackOverflow article.
        /// </a>
        /// </remarks>
        private static IEnumerable<T> ShuffleIterator<T>(
            this IEnumerable<T> quote,
            Random rng
        )
        {
            var buffer = quote.ToList();

            for (var i = 0; i < buffer.Count; i++)
            {
                var j = rng.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}