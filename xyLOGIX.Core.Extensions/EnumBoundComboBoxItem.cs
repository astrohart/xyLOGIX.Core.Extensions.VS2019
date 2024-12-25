using System.Diagnostics;
using PostSharp.Patterns.Threading;
using System;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Represents a C# <see langword="enum" /> value together with a user-friendly
    /// display name, i.e., description.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [ExplicitlySynchronized]
    public class EnumBoundComboBoxItem<T> where T : struct, Enum
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains a user-friendly
        /// display name, or description, for the specific enumeration value.
        /// </summary>
        public string Description { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the enumeration value that is "behind" the combo box selection.
        /// </summary>
        public T Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Creates a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.ComboBoxExtensions.EnumBoundComboBoxItem{T}" />
        /// and initializes it with the specified <paramref name="value" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) The C# enumeration value to use for
        /// initialization.
        /// </param>
        /// <returns>
        /// Reference to an instance of
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.ComboBoxExtensions.EnumBoundComboBoxItem{T}" />
        /// that contains the required data.
        /// </returns>
        public static EnumBoundComboBoxItem<T> ForEnumValue(T value)
            => new EnumBoundComboBoxItem<T>
            {
                Description = value.AsString(), Value = value
            };
    }
}