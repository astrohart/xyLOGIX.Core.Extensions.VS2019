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
                    $"*** WARNING: The dictionary already contains the keu '{key}'.  Updating the corresponding value to '{value}'."
                );
                dictionary[key] = value;
                return;
            }

            dictionary.Add(key, value);
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