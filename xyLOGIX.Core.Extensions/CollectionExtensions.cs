using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Exposes static extension methods for collection types. </summary>
    [Log(AttributeExclude = true)]
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds multiple items to a collection without the need to call
        /// <c>AddRange</c> and allocate up a whole new collection object instance just to
        /// be used once.
        /// <para />
        /// It seemed like the <c>AddRange</c> way was a waste of system resources.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Name of the data type of the elements of the
        /// specified <paramref name="collection" />.
        /// </typeparam>
        /// <param name="collection">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="ICollection{T}" /> interface.
        /// </param>
        /// <param name="items">
        /// (Required.) One or more instances of
        /// <typeparamref name="T" /> that are to be added to the collection.
        /// </param>
        /// <remarks>
        /// If the <paramref name="collection" /> parameter has been passed a
        /// <see langword="null" /> reference, then this method does nothing.
        /// <para />
        /// If zero items are passed for the <paramref name="items" /> parameter, then this
        /// method does nothing.
        /// <para />
        /// If an individual element of the <paramref name="items" /> parameter is a
        /// <see langword="null" /> reference, then it is not added.
        /// <para />
        /// If an individual element of the <paramref name="items" /> parameter is already
        /// a member of the specified <paramref name="collection" />, it is still added.
        /// Typical use of this method is for, e.g., generating script files.
        /// </remarks>
        public static void AddMultiple<T>(
            this ICollection<T> collection,
            params T[] items
        )
        {
            if (collection == null) return;
            if (items == null || !items.Any()) return;

            foreach (var item in items)
            {
                if (item == null) continue;
                collection.Add(item);
            }
        }

        /// <summary>
        /// Determines whether the <paramref name="predicate" /> returns
        /// <see langword="true" /> for any of the specified <paramref name="values" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of each element of the
        /// <paramref name="values" /> collection.
        /// </typeparam>
        /// <param name="values">
        /// (Required.) Collection of objects, each of whose elements
        /// are to be passed to the specified <paramref name="predicate" /> until either it
        /// returns <see langword="true" />, or if the entire collection is enumerated.
        /// </param>
        /// <param name="predicate">
        /// (Required.) Predicate that tests each value in the
        /// <paramref name="values" /> collection.
        /// </param>
        /// <remarks>
        /// This method can make no guarantee about the order in which it evaluates the
        /// <paramref name="predicate" /> on the elements of the <paramref name="values" />
        /// collection.
        /// <para />
        /// This method enumerates the entire <paramref name="values" />
        /// collection twice; once to determine if it contains any elements, and the other
        /// to test each element with the specified <paramref name="predicate" />.
        /// <para />
        /// If you do not want that, then use the LINQ <c>Any</c> method on the
        /// <paramref name="values" /> collection instead.
        /// <para />
        /// The approach of this method is designed to make it an asset where thread-safety
        /// is more important than performance.
        /// <para />
        /// Iteration of the <paramref name="values" /> collection stops the moment that
        /// either the <paramref name="predicate" /> returns <see langword="true" />, or if
        /// the end of the <paramref name="values" /> collection is reached.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if any of the <paramref name="values" />
        /// matches the supplied <paramref name="predicate" />; <see langword="false" />
        /// otheriwse.
        /// </returns>
        public static bool AnyAre<T>(
            this IEnumerable<T> values,
            Func<T, bool> predicate
        )
        {
            var result = false;

            try
            {
                if (values == null) return result;
                if (values.ToArray()
                          .Length <= 0) return result;

                foreach (var value in values.ToArray())
                {
                    if (value == null) continue;
                    if (!predicate(value)) continue;

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
        /// Determines whether the specified <paramref name="collection" />
        /// contains zero elements.
        /// </summary>
        /// <typeparam name="T">(Required.) Data type of the collection's elements.</typeparam>
        /// <param name="collection">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="ICollection{T}" /> interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="collection" /> contains zero elements; <see langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// If this method is passed a <see langword="null" /> reference, then
        /// the method also returns <see langword="false" />.
        /// </remarks>
        public static bool IsEmpty<T>(this ICollection<T> collection)
            => collection != null && !collection.Any();

        /// <summary>
        /// Determines whether the specified <paramref name="collection" /> is a
        /// <see langword="null" /> reference or the empty collection (i.e., the collection
        /// containing zero elements).
        /// </summary>
        /// <typeparam name="T">(Required.) Data type of the collection's elements.</typeparam>
        /// <param name="collection">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="ICollection{T}" /> interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="collection" /> is a <see langword="null" /> reference or if it
        /// contains zero elements; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
            => collection == null || collection.Count <= 0;

        /// <summary>
        /// Determines if the specified <c>object</c> is of one of the types in
        /// the specified tuple of types.
        /// </summary>
        /// <typeparam name="TTypes">
        /// Tuple of types that the <paramref name="obj" /> could
        /// be.
        /// </typeparam>
        /// <param name="obj">
        /// A <see cref="T:System.Object" /> instance whose type is to
        /// be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <c>object</c> is one of the
        /// types specified; otherwise, <see langword="false" /> is returned.
        /// </returns>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed to this method, then
        /// this method returns <see langword="false" />.
        /// <para />
        /// This method is useful for checking, say, if a
        /// <see cref="T:System.Windows.Forms.Control" /> is a
        /// <see cref="T:System.Windows.Forms.Button" />, a
        /// <see cref="T:System.Windows.Forms.CheckBox" />, or a
        /// <see cref="T:System.Windows.Forms.Label" />.
        /// <para />
        /// To perform that check, you would pass
        /// <c>Tuple&lt;Button, CheckBox, Label&gt;</c> as this method's type parameter.
        /// </remarks>
        public static bool IsOneOf<TTypes>(this object obj)
            where TTypes : ITuple
        {
            var tupleType = typeof(TTypes);
            return tupleType.GetGenericArguments()
                            .Any(type => type.IsInstanceOfType(obj));
        }
    }
}