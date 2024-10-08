﻿using PostSharp.Patterns.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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