using System;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>Helper methods to assist in handling runtime type information.</summary>
    public static class TypeExtensions
    {
        /// <summary>Ascertains whether the <see cref="potentialDescendant" /> is of the same, or a subclass of, the base class whose <see cref="Type" /> is passed.</summary>
        /// <param name="potentialDescendant">Type to be examined.</param>
        /// <param name="potentialBaseType">Reference to the <see cref="Type" /> structure of the class you think might be the <see cref="potentialDescendant" />'s base.</param>
        /// <returns>True if the type of the <see cref="potentialDescendant" /> is the same as, or a subclass of, the base type.</returns>
        public static bool IsSameOrSubclass(this Type potentialDescendant,
            Type potentialBaseType) =>
            potentialDescendant.IsSubclassOf(potentialBaseType) ||
            potentialDescendant == potentialBaseType;
    }
}