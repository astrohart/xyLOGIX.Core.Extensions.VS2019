using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Helper methods to assist in handling runtime type information.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Dictionary that caches the results of the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.TypeExtensions.GetActualType" />
        /// method for faster performance.
        /// </summary>
        private static readonly Dictionary<Type, Type> CachedActualType =
            new Dictionary<Type, Type>();

        /// <summary>
        /// Gets the internal type of an IList. When the type is not a list then
        /// this method will return the same type. if type is List of T then
        /// this method will return the type of T.
        /// </summary>
        public static Type GetActualType(this Type type)
        {
            if (CachedActualType.ContainsKey(type))
                return CachedActualType[type];

            if (type.GetTypeInfo()
                    .IsArray)
                CachedActualType.Add(type, type.GetElementType());
            else if (type.GenericTypeArguments.Any())
                CachedActualType.Add(
                    type, type.GenericTypeArguments.First()
                ); // this is almost always find the right type of an IList but if it fail then do the below. Don't really remember why this fail sometimes.
            else if (type.FullName?.Contains("List`1") ?? false)
                CachedActualType.Add(
                    type, type.GetRuntimeProperty("Item")
                              .PropertyType
                );
            else
                CachedActualType.Add(type, type);

            return CachedActualType[type];
        }

        /// <summary>
        /// Ascertains whether the <paramref name="potentialDescendant" /> is of
        /// the same, or a subclass of, the base class whose
        /// <see
        ///     cref="T:System.Type" />
        /// is passed.
        /// </summary>
        /// <param name="potentialDescendant">
        /// Type to be examined.
        /// </param>
        /// <param name="potentialBaseType">
        /// Reference to the <see cref="T:System.Type" /> structure of the class
        /// you think might be the <paramref name="potentialDescendant" />'s base.
        /// </param>
        /// <returns>
        /// True if the type of the <paramref name="potentialDescendant" /> is
        /// the same as, or a subclass of, the base type.
        /// </returns>
        public static bool IsSameOrSubclassOf(this Type potentialDescendant,
            Type potentialBaseType)
            => potentialDescendant.IsSubclassOf(potentialBaseType) ||
               potentialDescendant == potentialBaseType;
    }
}
