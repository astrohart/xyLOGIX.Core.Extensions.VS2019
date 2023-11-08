using System;
using System.Collections.Generic;
using System.Windows.Forms;
using xyLOGIX.Collections.Synchronized;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for instances of
    /// <see cref="T:System.Windows.Forms.ComboBox" />.
    /// </summary>
    public static class ComboBoxExtensions
    {
        /// <summary>
        /// Data-binds an enumeration in code to a
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) The name of the C# enumeration to be
        /// data-bound.
        /// </typeparam>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> that is to be data-bound.
        /// </param>
        /// <param name="defaultSelection">
        /// (Required.) Default value to be selected when
        /// the form is first displayed.
        /// </param>
        public static void BindToEnum<T>(
            this ComboBox comboBox,
            T defaultSelection
        ) where T : struct, Enum
        {
            try
            {
                IList<EnumBoundComboBoxItem<T>> comboBoxItems =
                    new ConcurrentList<EnumBoundComboBoxItem<T>>();

                comboBoxItems = GetComboBoxItems<T>();
                if (comboBoxItems == null) return;
                if (comboBoxItems.Count == 0) return;

                comboBox.DataSource = comboBoxItems;
                comboBox.DisplayMember = "Description";
                comboBox.ValueMember = "Value";

                var defaultComboBoxItem =
                    EnumBoundComboBoxItem<T>.ForEnumValue(defaultSelection);
                if (defaultComboBoxItem == null) return;
                if (string.IsNullOrWhiteSpace(defaultComboBoxItem.Description))
                    return;

                // more thread-safe this way
                // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
                foreach (var comboBoxItem in comboBoxItems)
                    if (comboBoxItem.Description.Equals(
                            defaultComboBoxItem.Description
                        ))
                        comboBox.SelectedItem = comboBoxItem;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Attempts to gather a collection of combo box items for the specified C#
        /// enumeration.
        /// </summary>
        /// <typeparam name="T">(Required.) Name of the enumeration.</typeparam>
        /// <returns>
        /// A collection of instances of
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.ComboBoxExtensions.EnumBoundComboBoxItem{T}" />
        /// , each of which represent an item to be added to a
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </returns>
        private static IList<EnumBoundComboBoxItem<T>> GetComboBoxItems<T>()
            where T : struct, Enum
        {
            IList<EnumBoundComboBoxItem<T>> result =
                new ConcurrentList<EnumBoundComboBoxItem<T>>();

            try
            {
                var values = Enum.GetValues(typeof(T));
                if (values.Length == 0) return result;

                foreach (T value in values)
                {
                    // Eliminate an "Unknown" value or negative number
                    if (Convert.ToInt32(value) == -1) continue;
                    if (Convert.ToInt32(value) < 0) continue;

                    var comboBoxItem =
                        EnumBoundComboBoxItem<T>.ForEnumValue(value);
                    if (comboBoxItem == null) continue;
                    if (string.IsNullOrWhiteSpace(comboBoxItem.Description))
                        continue;

                    result.Add(comboBoxItem);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new ConcurrentList<EnumBoundComboBoxItem<T>>();
            }

            return result;
        }

        /// <summary>
        /// Represents a C# <see langword="enum" /> value together with a user-friendly
        /// display name, i.e., description.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class EnumBoundComboBoxItem<T> where T : struct, Enum
        {
            /// <summary>
            /// Gets or sets a <see cref="T:System.String" /> that contains a user-friendly
            /// display name, or description, for the specific enumeration value.
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets the enumeration value that is "behind" the combo box selection.
            /// </summary>
            public T Value { get; set; }

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
}