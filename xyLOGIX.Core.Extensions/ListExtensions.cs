using PostSharp.Patterns.Collections;
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
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.ListExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ListExtensions() { }

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
        /// <remarks>
        /// This method does nothing if the values of either the <paramref name="list" />
        /// or the <paramref name="item" /> parameter(s), respectively, are set to a
        /// <see langword="null" /> reference.
        /// </remarks>
        /// <typeparam name="T"> Type of the new element. </typeparam>
        public static void AddDistinct<T>(this IList<T> list, T item)
        {
            try
            {
                // Nothing to do if the value of the 'list' parameter is NULL.
                if (list == null) return;

                // Reject nulls.
                if (item == null) return;

                // If the list already contains the item, then do nothing.
                if (list.Contains(item)) return;

                // Add the item to the list.
                list.Add(item);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
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
                if (items == null) return;

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
        public static IList<T> Clone<T>(this ICollection<T> source)
        {
            IList<T> result = new AdvisableCollection<T>();

            try
            {
                if (source == null) return result;
                if (source.Count <= 0) return result;

                foreach (var element in source) result.Add(element);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new AdvisableCollection<T>();
            }

            return result;
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
                if (list.Count <= 0) return result;
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

                result = -1;
            }

            return result;
        }

        /// <summary>
        /// Compares a <paramref name="left" /> and <paramref name="right" /> list.
        /// </summary>
        /// <typeparam name="T">(Required.) Data type of each element.</typeparam>
        /// <param name="left">(Required.) A collection of objects to check against.</param>
        /// <param name="right">
        /// (Required.) A collection of objects that serves as the
        /// right-hand side of the comparison.
        /// </param>
        /// <remarks>
        /// Returns <see langword="true" /> if either both the <paramref name="left" /> and
        /// <paramref name="right" /> lists are set to a <see langword="null" /> reference;
        /// otherwise, they must both be non-<see langword="null" />, have the same count
        /// of elements, and all elements must be identical, otherwise this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if both the <paramref name="left" /> and
        /// <paramref name="right" /> lists are identical; otherwise,
        /// <see langword="false" />.
        /// </returns>
        public static bool IsIdenticalTo<T>(this IList<T> left, IList<T> right)
            where T : class
        {
            var result = true;

            try
            {
                if (left == null && right == null) return result;
                if (left == null && right != null) return false;
                if (left != null && right == null) return false;

                if (left.Count != right.Count) return false;

                // ReSharper disable once LoopCanBeConvertedToQuery
                for (var i = 0; i < left.Count; i++)
                {
                    if (typeof(T) != typeof(string) && left[i]
                            .Equals(right[i])) continue;
                    if (typeof(T) == typeof(string) && string.Equals(
                            (string)(object)left[i], (string)(object)right[i],
                            StringComparison.InvariantCulture
                        )) continue;

                    result = false;
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
        {
            var result = false;

            try
            {
                if (valueSet == null) return result;
                if (!valueSet.Any()) return result;

                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var element in valueSet)
                {
                    if (!element.Equals(value)) continue;

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
        /// Returns the <paramref name="index" />-th element counted from the end of
        /// the <paramref name="source" /> collection (0 ⇒ last, 1 ⇒ second-to-last,
        /// and so on).
        /// </summary>
        /// <typeparam name="TSource">
        /// The element type of the <paramref name="source" /> collection.
        /// </typeparam>
        /// <param name="source">
        /// (Required.) The collection to inspect.  A <see langword="null" />
        /// reference or an empty collection causes the method to return the default
        /// value of <typeparamref name="TSource" />.
        /// </param>
        /// <param name="index">
        /// (Required.) Zero-based offset from the last element.  Must be greater
        /// than or equal to zero and strictly less than <c>source.Count</c>.
        /// </param>
        /// <remarks>
        /// The method never throws; on any error it returns
        /// <c>default(<typeparamref name="TSource" />)</c> after logging the
        /// exception.
        /// </remarks>
        /// <returns>
        /// A reference to the requested element, or the default value of
        /// <typeparamref name="TSource" /> on failure.
        /// </returns>
        [return: NotLogged]
        public static TSource NthLast<TSource>(
            [NotLogged] this IList<TSource> source,
            [NotLogged] int index
        )
        {
            // Default return value for error / edge cases.
            TSource result = default;

            try
            {
                // Basic validation.
                if (source == null || source.Count == 0) return result;
                if (index < 0 || index >= source.Count) return result;

                // Snapshot the collection to an array so that any concurrent changes to
                // 'source' made by another thread cannot affect our calculation.
                var buffer = new TSource[source.Count];
                source.CopyTo(buffer, 0);

                // Locate the element:  last element is buffer.Length-1, etc.
                var targetIndex = buffer.Length - 1 - index;
                result = buffer[targetIndex];
            }
            catch (Exception ex)
            {
                // Log the details; never propagate the exception.
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

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
                if (list.Count <= 0) return;
                if (index < 0) return;
                if (index >= list.Count) return;
                if (count <= 0) return;

                /*
                 * Iterate through the list backwards,
                 * starting at index + count and ending on
                 * index.
                 *
                 * For Each element of the list in that range,
                 * remove it.
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
        /// Returns a new collection that contains every element of
        /// <paramref name="source" /> <b>except</b> the last
        /// <paramref name="count" /> element(s).
        /// </summary>
        /// <typeparam name="TSource">
        /// The element type of the <paramref name="source" /> collection.
        /// </typeparam>
        /// <param name="source">
        /// (Required.) The input list.  If it is <see langword="null" /> or empty,
        /// the method returns an empty collection.
        /// </param>
        /// <param name="count">
        /// (Required.) The number of trailing elements to omit.  If
        /// <paramref name="count" /> is less than or equal to zero, the method
        /// returns a copy of the entire <paramref name="source" /> collection.  If
        /// <paramref name="count" /> is greater than or equal to
        /// <c>source.Count</c>, the method returns an empty collection.
        /// </param>
        /// <param name="includeNulls">
        /// (Optional.) If <see langword="true" />, the method copies
        /// <see langword="null" /> value(s) that may be present in the specified
        /// <paramref name="source" /> collection to the resulting collection; if
        /// <see langword="false" />, the method skips <see langword="null" /> value(s) in
        /// the specified <paramref name="source" /> collection.
        /// <para />
        /// The default value of this parameter is <see langword="true" />.
        /// </param>
        /// <remarks>
        ///     <list type="bullet">
        ///         <item>
        ///             <description>
        ///             The method never throws; on any unexpected failure it logs
        ///             the exception and returns an empty
        ///             <see cref="T:AdvisableCollection{TSource}" />.
        ///             </description>
        ///         </item>
        ///         <item>
        ///         The implementation avoids LINQ and allocates exactly one result
        ///         collection.  It is thread-safe because it works against a
        ///         snapshot of <paramref name="source" /> taken at the moment of
        ///         invocation.
        ///         </item>
        ///     </list>
        /// </remarks>
        /// <returns>
        /// A new <see cref="T:AdvisableCollection{TSource}" /> that contains all
        /// elements of <paramref name="source" /> except the last
        /// <paramref name="count" />; or an empty collection under the conditions
        /// noted above.
        /// </returns>
        [return: NotLogged]
        public static IList<TSource> TakeAllButLast<TSource>(
            [NotLogged] this IList<TSource> source,
            [NotLogged] int count,
            bool includeNulls = true
        )
        {
            var result = new AdvisableCollection<TSource>();

            try
            {
                // Validate the source collection.
                if (source == null) return result;

                var sourceArray = source.ToArray();

                if (sourceArray == null) return result;
                if (sourceArray.Length <= 0) return result;

                // If the caller asked to omit zero elements, return a copy of the source.
                if (count <= 0) return source;

                // If the caller asked to omit more (or the same number of) elements
                // than exist, the result is empty.
                if (count >= sourceArray.Length)
                    return result; // empty

                // Snapshot the current state to avoid multi-thread interference.
                var length = sourceArray.Length;
                var takeUpToIndex = length - count; // exclusive upper bound

                // Reserve capacity to avoid repeated reallocations.
                result = new AdvisableCollection<TSource>(takeUpToIndex);

                for (var i = 0; i < takeUpToIndex; i++)
                {
                    if (!includeNulls && sourceArray[i] == null)
                        continue; // skip nulls if the caller requested it

                    result.Add(sourceArray[i]);
                }
            }
            catch (Exception ex)
            {
                // Log the full exception details.  Never re-throw.
                DebugUtils.LogException(ex);

                result = new AdvisableCollection<TSource>();
            }

            return result;
        }

        /// <summary>
        /// Adds the specified <paramref name="items" /> to an instance of
        /// <see cref="T:xyLOGIX.Collections.Synchronized.ConcurrentList`1" />.
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
        /// <see cref="T:xyLOGIX.Collections.Synchronized.ConcurrentList`1" />, and returns
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
        /// Writes a list variable out as a Pythonic list, i.e., [1,2,3,4].  Stops past the
        /// tenth item.
        /// </summary>
        /// <param name="list"> List to be written. </param>
        /// <typeparam name="T"> The type of each element of the list. </typeparam>
        /// <returns> The <paramref name="list" />, formatted as a set string. </returns>
        /// <remarks>
        /// This method is helpful for writing some of the members of a
        /// collection to a log file.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public static string ToSetString<T>(this IList<T> list)
        {
            if (list == null || list.Count <= 0) return "[]";

            var result = "[ ";
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

            result += " ]";

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
            if (collection == null || collection.Count <= 0) return "[]";

            var result = "[ ";
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

            result += " ]";

            return result;
        }

        /// <summary>
        /// Writes a list variable out as a Pythonic list, [1,2,3,4] e.g. Stops past the
        /// tenth item.
        /// </summary>
        /// <param name="collection"> Collection to be written. </param>
        /// <typeparam name="T"> The type of each element of the list. </typeparam>
        /// <returns> The <paramref name="collection" />, formatted as a set string. </returns>
        /// <remarks>
        /// This method is helpful for writing some of the members of a
        /// collection to a log file.
        /// </remarks>
        public static string ToSetString<T>(this IEnumerable<T> collection)
        {
            if (collection == null || !collection.Any()) return "[]";

            var result = "[ ";
            foreach (var item in collection.Cast<object>()
                                           .Where(item => item != null)
                                           .Take(10))
                if (item is string)
                    result += $@"'{item}'" + ", ";
                else
                    result += item + ", ";

            if (!string.IsNullOrWhiteSpace(result) && result.EndsWith(", "))
                result = result.Remove(result.Length - 2);

            if (collection.Count() > 10) result += ", ...";

            result += " ]";

            return result;
        }
    }
}