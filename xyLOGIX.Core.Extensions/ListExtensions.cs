using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Collections.Synchronized;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Provides methods to help with lists of items. </summary>
    [Log(AttributeExclude = true)]
    public static class ListExtensions
    {
        /// <summary>
        /// Adds an <paramref name="item" /> to a <paramref name="list" />, but
        /// only if the item is not already present in the collection. If it is, then this
        /// method does nothing.
        /// </summary>
        /// <param name="list">
        /// Reference to a list that implements the
        /// <see cref="T:System.Collections.Generic.IList" /> interface for items of type
        /// <typeparamref name="T" />.
        /// </param>
        /// <param name="item">
        /// Element to be added to the collection, unless it's in the
        /// collection already.
        /// </param>
        /// <typeparam name="T"> Type of the new element. </typeparam>
        public static void AddDistinct<T>(this IList<T> list, T item)
        {
            if (list == null) return;
            if (list.Contains(item)) return;

            list.Add(item);
        }

        /// <summary>
        /// Adds an <paramref name="item" /> to a <paramref name="collection" />,
        /// but only if the item is not already present in the collection. If the
        /// <paramref name="item" /> is already a member of the
        /// <paramref name="collection" /> , then this method does nothing.
        /// </summary>
        /// <param name="collection">
        /// Reference to a list that implements the
        /// <see cref="T:System.Collections.Generic.ICollection{T}" /> interface for items
        /// of type <typeparamref name="T" />.
        /// </param>
        /// <param name="item">
        /// Element to be added to the collection, unless it's in the
        /// collection already.
        /// </param>
        /// <typeparam name="T">
        /// Type of the elements of the <paramref name="collection" />
        /// .
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
        /// only if the item is not already present in the list. If it is, then this method
        /// does nothing. If <see langword="null" /> is passed for the
        /// <paramref name="list" /> parameter, then this method likewise also does
        /// nothing.
        /// </summary>
        /// <param name="list">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:System.Collections.IList" /> interface.
        /// </param>
        /// <param name="item">
        /// Element to be added to the collection, unless it's in the
        /// collection already.
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
        public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
            where T : class
        {
            try
            {
                if (list == null) return;
                if (items == null || !items.Any()) return;

                foreach (var item in items)
                    list.Add(item);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return;
        }

        /// <summary>
        /// Creates a duplicate of the list given to it and returns a reference
        /// to the clone.
        /// </summary>
        /// <typeparam name="T"> Type of object in the list. </typeparam>
        /// <param name="source"> Reference to the collection to make a duplicate of. </param>
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
        /// Searches the provided <paramref name="list" />, trying to locate the element
        /// that satisfies the Boolean conditions imposed by the specified
        /// <paramref name="predicate" />.
        /// <para />
        /// The zero-based index into the list at which the first matching element exists
        /// is returned, or <c>-1</c> if no matching element can be found.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of each <paramref name="list" />
        /// element.
        /// </typeparam>
        /// <param name="list">
        /// (Required.) Reference to an instance of the collection of
        /// items that is to be searched.
        /// </param>
        /// <param name="predicate">
        /// (Required.) A predicate that evaluates to
        /// <see langword="true" /> or <see langword="false" /> for each element of the
        /// specified <paramref name="list" />, specifying the conditions by which a match
        /// is to be identified.
        /// </param>
        /// <returns>
        /// Zero-based index of the first element of the specified
        /// <paramref name="list" /> for which the specified <paramref name="predicate" />
        /// evaluates to <see langword="true" />; or <c>-1</c> if no such element can be
        /// located.
        /// </returns>
        public static int FindIndex<T>(
            this IList<T> list,
            Predicate<T> predicate
        )
        {
            var result = -1;

            try
            {
                if (list == null) return result;
                if (list.Count == 0) return result;
                if (predicate == null) return result;

                for (var i = 0; i < list.Count; i++)
                {
                    if (!predicate(list[i])) continue;

                    result = i;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

        /// <summary>
        /// Gets a value indicating whether the <paramref name="value" /> is
        /// among the elements of the <paramref name="valueSet" />.
        /// </summary>
        /// <param name="value"> Value to compare. </param>
        /// <param name="valueSet"> Range of integer values to check. </param>
        /// <returns>
        /// true if <paramref name="value" /> is in the
        /// <paramref name="valueSet" /> ; false otherwise.
        /// </returns>
        public static bool IsOneOf(this int value, IEnumerable<int> valueSet)
            => valueSet.Any(n => n == value);

        /// <summary>
        /// Removes <paramref name="count" /> items from the specified
        /// <paramref name="list" />, starting at the specified zero-based
        /// <paramref name="index" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of each of the elements of
        /// <paramref name="list" />.
        /// </typeparam>
        /// <param name="list">
        /// (Required.) Collection of items from which certain elements
        /// are to be removed.
        /// </param>
        /// <param name="index">
        /// (Required.) Must be zero or greater.  Starting zero-based
        /// index of the first element to be removed from the specified
        /// <paramref name="list" />.
        /// </param>
        /// <param name="count">
        /// (Required.) A number that is 1 or greater, indicating how
        /// many items are to be removed from the specified <paramref name="list" />.
        /// </param>
        /// <remarks>
        /// If the input <paramref name="list" /> is <see langword="null" /> or
        /// contains zero elements, then this method does nothing.
        /// <para />
        /// This method also does nothing in the event that <paramref name="index" /> is
        /// less than zero, or <paramref name="count" />  is less than or equal to zero.
        /// </remarks>
        public static void RemoveRange<T>(
            this IList<T> list,
            int index,
            int count
        )
        {
            try
            {
                if (list == null) return;
                if (list.Count == 0) return;
                if (index < 0) return;
                if (index >= list.Count) return;
                if (count <= 0) return;

                /*
                 * Iterate through the list backwards,
                 * starting at index + count and ending on
                 * index.
                 */

                for (var i = index + count; i >= index; i--) list.RemoveAt(i);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Adds the specified <paramref name="items" /> to an instance of
        /// <see cref="xyLOGIX.Collections.Synchronized.ConcurrentList{T}" />.
        /// </summary>
        /// <typeparam name="T">(Required.) Data type of each element.</typeparam>
        /// <param name="items">
        /// (Required.) Enumerable collection of items to be added to
        /// the new list.
        /// </param>
        /// <remarks>
        /// If no <paramref name="items" /> are supplied, or the
        /// <paramref name="items" /> parameter is set to a <see langword="null" />
        /// reference, then this method returns the empty collection.
        /// <para />
        /// The collection to be returned has its excess memory storage reduced to match
        /// the actual number of items in the collection, and the garbage collector is run,
        /// prior to being returned by this method.
        /// </remarks>
        /// <returns>
        /// Adds the provided <paramref name="items" /> to a new instance of
        /// <see cref="xyLOGIX.Collections.Synchronized.ConcurrentList{T}" />, and returns
        /// a reference to it.
        /// </returns>
        public static IList<T> ToConcurrentList<T>(this IEnumerable<T> items)
        {
            IList<T> result = new ConcurrentList<T>();

            try
            {
                if (items == null) return result;

                foreach (var element in items) result.Add(element);

                /*
                 * NOTE: We must pierce the IList<T> interface and
                 * call the TrimExcess() method of the concrete class
                 * here, in order to avoid an exception.
                 */

                ((ConcurrentList<T>)result).TrimExcess();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new ConcurrentList<T>();
            }

            return result;
        }

        /// <summary>
        /// Writes a list variable out as a set {1,2,3,4} e.g., as in
        /// mathematics. Stops past the tenth item.
        /// </summary>
        /// <param name="list"> List to be written. </param>
        /// <typeparam name="T"> The type of each element of the list. </typeparam>
        /// <returns> The <paramref name="list" />, formatted as a set string. </returns>
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

        /// <summary>
        /// Writes a list variable out as a set {1,2,3,4} e.g., as in
        /// mathematics. Stops past the tenth item.
        /// </summary>
        /// <param name="collection"> Collection to be written. </param>
        /// <typeparam name="T"> The type of each element of the list. </typeparam>
        /// <returns> The <paramref name="collection" />, formatted as a set string. </returns>
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

        /// <summary>
        /// Provides a
        /// <see cref="M:System.Collections.Generic.List{T}.TrimExcess" /> method that can
        /// be called on objects implementing
        /// <see cref="T:System.Collections.Generic.IList{T}" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of each element of the specified
        /// <paramref name="list" />.
        /// </typeparam>
        /// <param name="list">(Required.) A <c>List</c> to be trimmed.</param>
        public static void TrimExcess<T>(this IList<T> list)
        {
            try
            {
                if (list == null) return;

                ((List<T>)list).TrimExcess();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /*
///  <summary> Writes a list variable out as a set {1,2,3,4} e.g., as in mathematics. Stops past the tenth item. </summary> <param name="list"> List to be written. </param> <returns> The <paramref name="list"/>, formatted as a set string. </returns> <remarks> This method is helpful for writing some of the members of a collection to a log file. </remarks>
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
        /*
///  <summary> Writes a list variable out as a set {1,2,3,4} e.g., as in mathematics. Stops past the tenth item. </summary> <param name="collection"> Collection to be written. </param> <returns> The <paramref name="collection"/>, formatted as a set string. </returns> <remarks> This method is helpful for writing some of the members of a collection to a log file. </remarks>
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
    }
}