using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using System.Reflection;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Helper methods to assist in handling runtime type information. </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.TypeExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static TypeExtensions() { }

        /// <summary>
        /// Dictionary that caches the results of the
        /// <see cref="M:xyLOGIX.Core.Extensions.TypeExtensions.GetActualType" /> method
        /// for faster performance.
        /// </summary>
        public static AdvisableDictionary<Type, Type>
            CachedActualType
        { get; } = new AdvisableDictionary<Type, Type>();

        /// <summary>
        /// Gets the internal type of IList. When the type is not a list then
        /// this method will return the same type. if type is List of T then this method
        /// will return the type of T.
        /// </summary>
        public static Type GetActualType(this Type type)
        {
            Type result;

            try
            {
                if (CachedActualType.TryGetValue(type, out var actualType))
                    return result = actualType;

                if (type.GetTypeInfo()
                        .IsArray)
                    CachedActualType[type] = type.GetElementType();
                else if (type.GenericTypeArguments.Any())

                    // this almost always finds the right type of IList
                    // but if it fails then do the below. Don't really
                    // remember why this fails sometimes.
                    CachedActualType[type] = type.GenericTypeArguments.First();
                else if (type.FullName?.Contains("List`1") ?? false)
                    CachedActualType[type] = type.GetRuntimeProperty("Item")
                                                 .PropertyType;
                else
                    CachedActualType[type] = type;

                result = CachedActualType[type];
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Ascertains whether the <paramref name="potentialDescendant" /> is of
        /// the same, or a subclass of, the base class whose <see cref="T:System.Type" />
        /// is passed.
        /// </summary>
        /// <param name="potentialDescendant"> Type to be examined. </param>
        /// <param name="potentialBaseType">
        /// Reference to the <see cref="T:System.Type" />
        /// structure of the class you think might be the
        /// <paramref name="potentialDescendant" />'s base.
        /// </param>
        /// <returns>
        /// True if the type of the <paramref name="potentialDescendant" /> is
        /// the same as, or a subclass of, the base type.
        /// </returns>
        public static bool IsSameOrSubclassOf(
            this Type potentialDescendant,
            Type potentialBaseType
        )
        {
            var result = false;

            try
            {
                if (potentialDescendant == null) return result;
                if (potentialBaseType == null) return result;

                result = potentialDescendant.IsSubclassOf(potentialBaseType) ||
                         potentialDescendant == potentialBaseType;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}