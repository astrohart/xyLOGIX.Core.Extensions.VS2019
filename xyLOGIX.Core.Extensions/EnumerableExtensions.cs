using System;
using System.Collections.Generic;
using System.Linq;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Helper methods for collections.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Compares the <paramref name="source" /> object with the
        /// <paramref
        ///     name="testObjects" />
        /// provided, to see if any of the
        /// <paramref
        ///     name="testObjects" />
        /// is a match.
        /// </summary>
        /// <typeparam name="T">
        /// Type of the object to be tested.
        /// </typeparam>
        /// <param name="source">
        /// Source object to check.
        /// </param>
        /// <param name="testObjects">
        /// Object or objects that should be compared to source with the
        /// <see
        ///     cref="M:System.Object.Equals" />
        /// method.
        /// </param>
        /// <returns>
        /// True if any of the <paramref name="testObjects" /> equals the source;
        /// false otherwise.
        /// </returns>
        public static bool IsAnyOf<T>(this T source, params T[] testObjects)
            => testObjects.Any(o => o.Equals(source));

        /// <summary>
        /// Shuffles the elements of the sequence into a random order, and then
        /// returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.
        /// </summary>
        /// <typeparam name="T">
        /// Type of the elements of the sequence.
        /// </typeparam>
        /// <param name="source">
        /// Sequence to be shuffled.
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
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var rng = new Random();
            return source.Shuffle(rng);
        }

        /// <summary>
        /// Returns all the elements of the <paramref name="source" /> enumerable
        /// object, except for the last.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the type of item in the collection.
        /// </typeparam>
        /// <param name="source">
        /// Reference to an enumerable collection.
        /// </param>
        /// <returns>
        /// Enumerable iterator over the collection that yields every item in
        /// the collection, except for the last.
        /// </returns>
        public static IEnumerable<T> TakeAllButLast<T>(
            this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using (var it = source.GetEnumerator())
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
        /// returns the resulting sequence. From the Fisher-Yates-Durstenfeld
        /// shuffle. Uses the random-number generator passed in the
        /// <paramref
        ///     name="rng" />
        /// parameter.
        /// </summary>
        /// <typeparam name="T">
        /// Type of the elements of the sequence.
        /// </typeparam>
        /// <param name="source">
        /// Sequence to be shuffled.
        /// </param>
        /// <param name="rng">
        /// A <see cref="T:System.Random" /> instance with which to generate new
        /// random values for the shuffle operation.
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
        private static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source,
            Random rng)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (rng == null) throw new ArgumentNullException(nameof(rng));

            return source.ShuffleIterator(rng);
        }

        /// <summary>
        /// Shuffles the elements of the sequence into a random order, and then
        /// returns the resulting sequence. From the Fisher-Yates-Durstenfeld
        /// shuffle. Uses the random-number generator passed in the
        /// <paramref
        ///     name="rng" />
        /// parameter. Behaves like the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle" />
        /// method, although this method can be utilized as an iterator.
        /// </summary>
        /// <typeparam name="T">
        /// Type of the elements of the sequence.
        /// </typeparam>
        /// <param name="source">
        /// Sequence to be shuffled.
        /// </param>
        /// <param name="rng">
        /// A <see cref="T:System.Random" /> instance with which to generate new
        /// random values for the shuffle operation.
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
            this IEnumerable<T> source, Random rng)
        {
            var buffer = source.ToList();

            for (var i = 0; i < buffer.Count; i++)
            {
                var j = rng.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}