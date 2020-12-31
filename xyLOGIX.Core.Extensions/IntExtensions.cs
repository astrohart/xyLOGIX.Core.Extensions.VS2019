﻿using System.Linq;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>Provides methods that extend the <see cref="T:System.Int32" /> class.</summary>
    public static class IntExtensions
    {
        /// <summary>Returns a value indicating whether the specified <paramref name="value" /> is equal to one of the items in a collection of integers.</summary>
        /// <param name="value">Integer to be compared to the members of the list.</param>
        /// <param name="list">Collection of integers that should be searched for the <paramref name="value" />.</param>
        /// <returns><c>true</c> if <paramref name="value" /> is one of the elements of the collection; <c>false</c> if not.</returns>
        public static bool EqualsOneOf(this int value, params int[] list) =>
            list != null && list.Length != 0 && list.Any(t => value == t);
    }
}