using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.ComboBoxExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ComboBoxExtensions() { }

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
                    new AdvisableCollection<EnumBoundComboBoxItem<T>>();

                comboBoxItems = GetComboBoxItems<T>();
                if (comboBoxItems == null) return;
                if (comboBoxItems.Count <= 0) return;

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
        /// Attempts to select the first item in the list of items present in the specified
        /// <paramref name="comboBox" />.
        /// </summary>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.ComboBox" /> that contains the item(s) to be
        /// used.
        /// </param>
        /// <remarks>
        /// If the specified <paramref name="comboBox" /> is a
        /// <see langword="null" /> reference or it contains zero items, then this method
        /// does nothing.
        /// </remarks>
        public static void SelectFirstItem(this ComboBox comboBox)
        {
            try
            {
                if (comboBox == null) return;
                if (comboBox.Items.Count <= 0) return;

                comboBox.SelectedIndex = 0;
                comboBox.Select();
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
                new AdvisableCollection<EnumBoundComboBoxItem<T>>();

            try
            {
                var values = Enum.GetValues(typeof(T));
                if (values.Length <= 0) return result;

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

                result = new AdvisableCollection<EnumBoundComboBoxItem<T>>();
            }

            return result;
        }
    }
}