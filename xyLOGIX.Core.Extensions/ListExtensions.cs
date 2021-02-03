﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace xyLOGIX.Core.Extensions
{
   /// <summary>
   /// Provides methods to help with lists of items.
   /// </summary>
   public static class ListHelpers
   {
      /// <summary>
      /// Adds an <paramref name="item" /> to a <paramref name="list" />, but only
      /// if the item is not already present in the collection. If it is, then
      /// this method does nothing.
      /// </summary>
      /// <param name="list">
      /// Reference to a collection that implements the
      /// <see
      ///    cref="T:System.Collections.Generic.IList" />
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
      /// Creates a duplicate of the list given to it and returns a reference to
      /// the clone.
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
      /// Gets a value indicating whether the <paramref name="value" /> is among
      /// the elements of the <paramref name="valueSet" />.
      /// </summary>
      /// <param name="value">
      /// Value to compare.
      /// </param>
      /// <param name="valueSet">
      /// Range of integer values to check.
      /// </param>
      /// <returns>
      /// true if <paramref name="value" /> is in the <paramref name="valueSet" />
      /// ; false otherwise.
      /// </returns>
      public static bool IsOneOf(this int value, IEnumerable<int> valueSet)
      {
         return valueSet.Any(n => n == value);
      }

      /// <summary>
      /// Writes a list variable out as a set {1,2,3,4} e.g., as in mathematics.
      /// Stops past the tenth item.
      /// </summary>
      /// <param name="list">
      /// List to be written.
      /// </param>
      /// <returns>
      /// The <paramref name="list" />, formatted as a set string.
      /// </returns>
      /// <remarks>
      /// This method is helpful for writing some of the members of a collection
      /// to a log file.
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
   }
}