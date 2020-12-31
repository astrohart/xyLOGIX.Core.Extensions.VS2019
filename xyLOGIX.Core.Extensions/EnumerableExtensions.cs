using System;
using System.Collections.Generic;
using System.Linq;

namespace xyLOGIX.Core.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>Compares the <see cref="source" /> object with the <see cref="testObjects" /> provided, to see if any of the <see cref="testObjects" /> is a match.</summary>
        /// <typeparam name="T">Type of the object to be tested.</typeparam>
        /// <param name="source">     Source object to check.</param>
        /// <param name="testObjects">Object or objects that should be compared to source with the <see cref="T:System.Object.Equals" /> method.</param>
        /// <returns>True if any of the <see cref="testObjects" /> equals the source; false otherwise.</returns>
        public static bool IsAnyOf<T>(this T source, params T[] testObjects)
        {
            return testObjects.Any(o => o.Equals(source));
        }

        /// <summary>Shuffles the elements of the sequence into a random order, and then returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.</summary>
        /// <typeparam name="T">Type of the elements of the sequence.</typeparam>
        /// <param name="source">Sequence to be shuffled.</param>
        /// <returns>A new sequence, with the order of the elements randomized, according to the Fisher-Yates-Durstenfeld shuffle.</returns>
        /// <remarks>
        ///     see, e.g., <a href="http://stackoverflow.com/questions/5807128/an-extension-method-on-ienumerable-needed-for-shuffling">this StackOverflow article.</a>
        /// </remarks>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var rng = new Random();
            return source.Shuffle(rng);
        }

        private static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source,
            Random rng)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (rng == null) throw new ArgumentNullException(nameof(rng));

            return source.ShuffleIterator(rng);
        }

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