using System.Collections.Generic;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>Provides methods for extending any dictionary.</summary>
    public static class DictionaryExtensions
    {
        /// <summary>Transforms an instance of an object of type <see cref="Dictionary{TKey, TValue}" /> into an object by mapping the dictionary elements onto the object's properties that have the same name.</summary>
        /// <typeparam name="T">Type parameter identifying the object to receive the dictionary's information.</typeparam>
        /// <param name="source">Reference to an instance of an object of type <see cref="Dictionary{TKey,TValue}" />, whose key-value pairs identify what properties to fill with what information.</param>
        /// <remarks>In order for this method to work, the object and the dictionary must have the same schema.</remarks>
        /// <returns>Reference to an instance of an object of type T whose properties are filled in with the values from the <see cref="source" />.</returns>
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