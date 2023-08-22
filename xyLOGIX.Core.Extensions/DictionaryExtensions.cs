using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Provides methods for extending any dictionary.
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds the specified <paramref name="key" /> and <paramref name="value" /> to the
        /// specified <paramref name="dictionary" />, but only if the specified
        /// <paramref name="key" /> is not already in the dictionary.
        /// <para />
        /// Otherwise, the entry having the specified <paramref name="key" /> will have its
        /// value updated to be <paramref name="value" />.
        /// </summary>
        /// <typeparam name="K">(Required.) Data type of the key.</typeparam>
        /// <typeparam name="V">(Required.) Data type of the value.</typeparam>
        /// <param name="dictionary">
        /// (Required.) Dictionary to which the new
        /// <paramref name="key" /> and <paramref name="value" /> are to be added.
        /// </param>
        /// <param name="key">
        /// (Required.) Key to be added/updated in the dictionary.
        /// <para />
        /// If this is the <see langword="null" /> or otherwise the default value of the
        /// key's data type, then this method will do nothing.
        /// </param>
        /// <param name="value">(Required.) Value to be added/updated in the dictionary.</param>
        public static void AddDistinct<K, V>(
            this IDictionary<K, V> dictionary,
            K key,
            V value
        )
        {
            if (dictionary == null) return;
            if (EqualityComparer<K>.Default.Equals(key, default)) return;

            if (!dictionary.Any())
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Dictionary has no existing entries.  Adding the new key-value pair."
                );

                dictionary.Add(key, value);
                return;
            }

            if (dictionary.ContainsKey(key))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Warning,
                    $"*** WARNING: The dictionary already contains the key '{key}'.  Updating the corresponding value to '{value}'."
                );
                dictionary[key] = value;
                return;
            }

            dictionary.Add(key, value);
        }

        /// <summary>
        /// Adds all the elements of the <paramref name="source" /> dictionary to the
        /// <paramref name="target" /> dictionary.
        /// <para />
        /// Dupes are ignored.
        /// </summary>
        /// <typeparam name="K">(Required.) Data type of the key.</typeparam>
        /// <typeparam name="V">(Required.) Data type of the value.</typeparam>
        /// <param name="target">
        /// (Required.) The dictionary that is to be the target of the merge.
        /// </param>
        /// <param name="source">
        /// (Required.) A dictionary that has the items to be merged in.
        /// <para />
        /// If this is the <see langword="null" /> or otherwise the default value of the
        /// key's data type, then this method will do nothing.
        /// </param>
        /// <remarks>
        /// If a key in the <paramref name="source" /> dictionary matches a key in
        /// the <paramref name="target" /> dictionary, then the corresponding value is
        /// overwritten.
        /// </remarks>
        public static void MergeWith<K, V>(
            this IDictionary<K, V> target,
            IDictionary<K, V> source
        )
        {
            try
            {
                if (target == null) return;
                if (source == null || !source.Any()) return;

                foreach (var kvp in source)
                    target.AddDistinct(kvp.Key, kvp.Value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Crates a <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />
        /// from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> according to
        /// the specified <paramref name="keySelector" /> and
        /// <paramref name="elementSelector" /> functions.
        /// </summary>
        /// <typeparam name="TSource">
        /// (Required.) The type of the elements of
        /// <paramref name="source" />.
        /// </typeparam>
        /// <typeparam name="TKey">
        /// (Required.) The type of the key returned by
        /// <paramref name="keySelector" />.
        /// </typeparam>
        /// <typeparam name="TElement">
        /// (Required.) The type of the value returned by
        /// <paramref name="elementSelector" />.
        /// </typeparam>
        /// <param name="source">
        /// (Required.) An
        /// <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a
        /// <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> from.
        /// </param>
        /// <param name="keySelector">
        /// (Required.) A function to extract a key from each
        /// element of <paramref name="source" />.
        /// </param>
        /// <param name="elementSelector">
        /// (Required.) A transform function to produce a
        /// result element value from each element of <paramref name="source" />.
        /// </param>
        /// <remarks>
        /// If any of the inputs are invalid values, i.e., <see langword="null" />
        /// reference and the like, or if an issue occurs during the generation of the
        /// requested <c>Dictionary</c> object, then the method returns the empty
        /// collection.
        /// </remarks>
        /// <returns>
        /// A
        /// <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> that
        /// contains values of type <typeparamref name="TElement" /> selected from the
        /// input sequence.
        /// </returns>
        public static IDictionary<TKey, TElement>
            ToConcurrentDictionary<TSource, TKey, TElement>(
                this IEnumerable<TSource> source,
                Func<TSource, TKey> keySelector,
                Func<TSource, TElement> elementSelector
            )
        {
            IDictionary<TKey, TElement> result =
                new ConcurrentDictionary<TKey, TElement>();

            try
            {
                if (source == null || !source.Any()) return result;
                if (keySelector == null) return result;
                if (elementSelector == null) return result;

                foreach (var value in source)
                    result[keySelector(value)] = elementSelector(value);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result.Clear();
            }

            return result;
        }

        /// <summary>
        /// Transforms an instance of an object of type
        /// <see
        ///     cref="T:System.Collections.Generic.Dictionary{System.String,System.String}" />
        /// into an object by mapping the dictionary elements onto the object's
        /// properties that have the same name.
        /// </summary>
        /// <typeparam name="T">
        /// Type parameter identifying the object to receive the dictionary's information.
        /// </typeparam>
        /// <param name="source">
        /// Reference to an instance of an object of type
        /// <see
        ///     cref="T:System.Collections.Generic.Dictionary{System.String,System.String}" />
        /// , whose key-value pairs identify what properties to fill with what information.
        /// </param>
        /// <remarks>
        /// In order for this method to work, the object and the dictionary must
        /// have the same schema.
        /// </remarks>
        /// <returns>
        /// Reference to an instance of an object of type T whose properties are
        /// filled in with the values from the <paramref name="source" />.
        /// </returns>
        /// <remarks>
        /// Basically, this method flattens the dictionary provided into a POCO.
        /// The dictionary must be a list of key-value pairs and it is assumed
        /// that the key is the name of a property, and the value is a string
        /// that is the property's value. Therefore, the destination object is
        /// assumed to have all its properties be of type
        /// <see
        ///     cref="T:System.String" />
        /// and the name of each property should match
        /// each key. Each corresponding property named the same as a key will
        /// have its value set to the value in the dictionary that corresponds
        /// to the key with the same name.
        /// </remarks>
        public static T ToObject<T>(this Dictionary<string, string> source)
            where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();

            foreach (var item in source)
                someObjectType.GetProperty(item.Key)
                              ?.SetValue(someObject, item.Value, null);

            return someObject;
        }
    }
}