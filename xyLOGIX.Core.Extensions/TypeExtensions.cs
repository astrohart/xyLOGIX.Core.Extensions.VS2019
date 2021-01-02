using System;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>Helper methods to assist in handling runtime type information.</summary>
    public static class TypeExtensions
    {
        /// <summary>Ascertains whether the <paramref name="potentialDescendant" /> is of the same, or a subclass of, the base class whose <see cref="T:System.Type" />  is passed.</summary>
        /// <param name="potentialDescendant">Type to be examined.</param>
        /// <param name="potentialBaseType">Reference to the <see cref="T:System.Type" /> structure of the class you think might be the <paramref name="potentialDescendant" />'s base.</param>
        /// <returns>True if the type of the <paramref name="potentialDescendant" /> is the same as, or a subclass of, the base type.</returns>
        public static bool IsSameOrSubclass(this Type potentialDescendant,
            Type potentialBaseType) =>
            potentialDescendant.IsSubclassOf(potentialBaseType) ||
            potentialDescendant == potentialBaseType;
    }
}