using System.Collections.Generic;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Provides methods for extending any dictionary.
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Transforms an instance of an object of type <see
        /// cref="T:System.Collections.Generic.Dictionary{System.String,System.String}"/>
        /// into an object by mapping the dictionary elements onto the object's
        /// properties that have the same name.
        /// </summary>
        /// <typeparam name="T">
        /// Type parameter identifying the object to receive the dictionary's information.
        /// </typeparam>
        /// <param name="source">
        /// Reference to an instance of an object of type <see
        /// cref="T:System.Collections.Generic.Dictionary{System.String,System.String}"/>
        /// , whose key-value pairs identify what properties to fill with what information.
        /// </param>
        /// <remarks>
        /// In order for this method to work, the object and the dictionary must
        /// have the same schema.
        /// </remarks>
        /// <returns>
        /// Reference to an instance of an object of type T whose properties are
        /// filled in with the values from the <paramref name="source"/>.
        /// </returns>
        /// <remarks>
        /// Basically, this method flattens the dictionary provided into a POCO.
        /// The dictionary must be a list of key-value pairs and it is assumed
        /// that the key is the name of a property, and the value is a string
        /// that is the property's value. Therefore, the destination object is
        /// assumed to have all its properties be of type <see
        /// cref="T:System.String"/> and the name of each property should match
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
                someObjectType.GetProperty(item.Key)?.SetValue(
                   someObject, item.Value, null
                );

            return someObject;
        }
    }
}