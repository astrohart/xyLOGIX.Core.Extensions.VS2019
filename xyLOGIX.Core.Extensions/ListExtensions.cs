using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Provides methods to help with lists of items.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ListExtensions
    {
        /// <summary>
        /// Adds an <paramref name="item" /> to a <paramref name="list" />, but
        /// only if the item is not already present in the collection. If it is,
        /// then this method does nothing.
        /// </summary>
        /// <param name="list">
        /// Reference to a list that implements the
        /// <see
        ///     cref="T:System.Collections.Generic.IList" />
        /// interface for items of
        /// type <typeparamref name="T" />.
        /// </param>
        /// <param name="item">
        /// Element to be added to the collection, unless it's in the collection already.
        /// </param>
        /// <typeparam name="T">
        /// Type of the new element.
        /// </typeparam>
        public static void AddDistinct<T>(this IList<T> list, T item)
        {
            if (list.Contains(item)) return;

            list.Add(item);
        }

        /// <summary>
        /// Adds an <paramref name="item" /> to a <paramref name="collection" />,
        /// but only if the item is not already present in the collection. If
        /// the <paramref name="item" /> is already a member of the
        /// <paramref
        ///     name="collection" />
        /// , then this method does nothing.
        /// </summary>
        /// <param name="collection">
        /// Reference to a list that implements the
        /// <see
        ///     cref="T:System.Collections.Generic.ICollection{T}" />
        /// interface for
        /// items of type <typeparamref name="T" />.
        /// </param>
        /// <param name="item">
        /// Element to be added to the collection, unless it's in the collection already.
        /// </param>
        /// <typeparam name="T">
        /// Type of the elements of the <paramref name="collection" />.
        /// </typeparam>
        public static void AddDistinct<T>(
            this ICollection<T> collection,
            T item
        )
        {
            if (collection == null) return;

            if (collection.Contains(item)) return;

            collection.Add(item);
        }

        /// <summary>
        /// Adds an <paramref name="item" /> to a <paramref name="list" />, but
        /// only if the item is not already present in the list. If it is, then
        /// this method does nothing. If <see langword="null" /> is passed for the
        /// <paramref
        ///     name="list" />
        /// parameter, then this method likewise also does nothing.
        /// </summary>
        /// <param name="list">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Collections.IList" />
        /// interface.
        /// </param>
        /// <param name="item">
        /// Element to be added to the collection, unless it's in the collection already.
        /// </param>
        public static void AddDistinct(this IList list, object item)
        {
            if (list == null) return;

            if (list.Contains(item)) return;

            list.Add(item);
        }

        /// <summary>
        /// Adds a collection of <paramref name="items" /> to the specified
        /// <paramref name="list" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Name of the type of the individual elements of
        /// the <paramref name="list" />.
        /// </typeparam>
        /// <param name="list">
        /// (Required.) Collection to which the specified
        /// <paramref name="items" /> are to be added.
        /// </param>
        /// <param name="items">
        /// (Required.) Collection of <paramref name="items" /> to be
        /// added to the specified <paramref name="list" />.
        /// </param>
        /// <returns>
        /// The specified <paramref name="list" /> with the provided
        /// <paramref name="items" /> added to it.
        /// </returns>
        public static IList<T> AddRange<T>(
            this IList<T> list,
            IEnumerable<T> items
        ) where T : class
        {
            var result = list;

            try
            {
                if (list == null) return result;
                if (items == null || !items.Any()) return result;

                foreach (var item in items)
                    list.Add(item);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = list;
            }

            return result;
        }

        /// <summary>
        /// Creates a duplicate of the list given to it and returns a reference
        /// to the clone.
        /// </summary>
        /// <typeparam name="T">
        /// Type of object in the list.
        /// </typeparam>
        /// <param name="source">
        /// Reference to the collection to make a duplicate of.
        /// </param>
        /// <returns>
        /// Reference to the duplicate of the collection referenced by
        /// <paramref name="source" />.
        /// </returns>
        public static List<T> Clone<T>(this ICollection<T> source)
        {
            if (source == null || !source.Any())
                return new List<T>();

            return new List<T>(source);
        }

        /// <summary>
        /// Gets a value indicating whether the <paramref name="value" /> is
        /// among the elements of the <paramref name="valueSet" />.
        /// </summary>
        /// <param name="value">
        /// Value to compare.
        /// </param>
        /// <param name="valueSet">
        /// Range of integer values to check.
        /// </param>
        /// <returns>
        /// true if <paramref name="value" /> is in the
        /// <paramref
        ///     name="valueSet" />
        /// ; false otherwise.
        /// </returns>
        public static bool IsOneOf(this int value, IEnumerable<int> valueSet)
            => valueSet.Any(n => n == value);

        /*
        /// <summary>
        /// Writes a list variable out as a set {1,2,3,4} e.g., as in
        /// mathematics. Stops past the tenth item.
        /// </summary>
        /// <param name="list">
        /// List to be written.
        /// </param>
        /// <returns>
        /// The <paramref name="list"/>, formatted as a set string.
        /// </returns>
        /// <remarks>
        /// This method is helpful for writing some of the members of a
        /// collection to a log file.
        /// </remarks>
        public static string ToSetString(this IList list)
        {
           if (list == null || list.Count == 0) return "{}";

           var result = "{ ";
           foreach (var item in list.Cast<object>().Where(item => item != null)
              .Take(10))
              if (item is string)
                 result += $@"'{item}'" + ", ";
              else
                 result += item + ", ";

           if (!string.IsNullOrWhiteSpace(result) && result.EndsWith(", "))
              result = result.Remove(result.Length - 2);

           if (list.Count > 10) result += ", ...";

           result += " }";

           return result;
        }
        */

        /// <summary>
        /// Writes a list variable out as a set {1,2,3,4} e.g., as in
        /// mathematics. Stops past the tenth item.
        /// </summary>
        /// <param name="list">
        /// List to be written.
        /// </param>
        /// <typeparam name="T">
        /// The type of each element of the list.
        /// </typeparam>
        /// <returns>
        /// The <paramref name="list" />, formatted as a set string.
        /// </returns>
        /// <remarks>
        /// This method is helpful for writing some of the members of a
        /// collection to a log file.
        /// </remarks>
        public static string ToSetString<T>(this IList<T> list)
        {
            if (list == null || list.Count == 0) return "{}";

            var result = "{ ";
            foreach (var item in list.Cast<object>()
                                     .Where(item => item != null)
                                     .Take(10))
                if (item is string)
                    result += $@"'{item}'" + ", ";
                else
                    result += item + ", ";

            if (!string.IsNullOrWhiteSpace(result) && result.EndsWith(", "))
                result = result.Remove(result.Length - 2);

            if (list.Count > 10) result += ", ...";

            result += " }";

            return result;
        }

        /*
        /// <summary>
        /// Writes a list variable out as a set {1,2,3,4} e.g., as in
        /// mathematics. Stops past the tenth item.
        /// </summary>
        /// <param name="collection">
        /// Collection to be written.
        /// </param>
        /// <returns>
        /// The <paramref name="collection"/>, formatted as a set string.
        /// </returns>
        /// <remarks>
        /// This method is helpful for writing some of the members of a
        /// collection to a log file.
        /// </remarks>
        public static string ToSetString(this ICollection collection)
        {
           if (collection == null || collection.Count == 0) return "{}";

           var result = "{ ";
           foreach (var item in collection.Cast<object>().Where(item => item != null)
              .Take(10))
              if (item is string)
                 result += $@"'{item}'" + ", ";
              else
                 result += item + ", ";

           if (!string.IsNullOrWhiteSpace(result) && result.EndsWith(", "))
              result = result.Remove(result.Length - 2);

           if (collection.Count > 10) result += ", ...";

           result += " }";

           return result;
        }
        */

        /// <summary>
        /// Writes a list variable out as a set {1,2,3,4} e.g., as in
        /// mathematics. Stops past the tenth item.
        /// </summary>
        /// <param name="collection">
        /// Collection to be written.
        /// </param>
        /// <typeparam name="T">
        /// The type of each element of the list.
        /// </typeparam>
        /// <returns>
        /// The <paramref name="collection" />, formatted as a set string.
        /// </returns>
        /// <remarks>
        /// This method is helpful for writing some of the members of a
        /// collection to a log file.
        /// </remarks>
        public static string ToSetString<T>(this ICollection<T> collection)
        {
            if (collection == null || collection.Count == 0) return "{}";

            var result = "{ ";
            foreach (var item in collection.Cast<object>()
                                           .Where(item => item != null)
                                           .Take(10))
                if (item is string)
                    result += $@"'{item}'" + ", ";
                else
                    result += item + ", ";

            if (!string.IsNullOrWhiteSpace(result) && result.EndsWith(", "))
                result = result.Remove(result.Length - 2);

            if (collection.Count > 10) result += ", ...";

            result += " }";

            return result;
        }
    }
}