using System;
using System.Linq;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Extension methods for a <see cref="T:System.Windows.Forms.CheckedListBox" />.
    /// </summary>
    public static class CheckedListBoxExtensions
    {
        /// <summary>
        /// Gets a value indicating whether all the items in the
        /// <paramref
        ///     name="checkedListBox" />
        /// box are selected.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) Reference to the
        /// <see
        ///     cref="T:System.Windows.Forms.CheckedListBox" />
        /// the items of which
        /// are to be checked.
        /// </param>
        /// <returns>
        /// <c>true</c> if all the items in the checked list box are selected;
        /// <c>false</c> otherwise, or if the list box contains zero items.
        /// </returns>
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="checkedListBox" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        public static bool AreAllItemsSelected(
            this CheckedListBox checkedListBox)
        {
            if (checkedListBox == null)
                throw new ArgumentNullException(nameof(checkedListBox));

            if (checkedListBox.Items.Count == 0)
                return false;

            return Enumerable.Range(0, checkedListBox.Items.Count)
                .All(checkedListBox.GetItemChecked);
        }

        /// <summary>
        /// Toggles the Checked state of all the items in the specified
        /// <paramref name="checkedListBox" />
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) A <see cref="T:System.Windows.Forms.CheckedListBox" /> to
        /// act upon.
        /// </param>
        /// <param name="isChecked">
        /// (Optional.) Whether to set the Checked state of all the list items
        /// or not. Default value is <c>true</c>.
        /// </param>
        /// <remarks>
        /// If the <paramref name="checkedListBox" /> parameter is <c>null</c>,
        /// or if the checked list box contains zero items, then this method
        /// does nothing.
        /// </remarks>
        public static void CheckAll(this CheckedListBox checkedListBox,
            bool isChecked = true)
        {
            if (checkedListBox == null)
                return;

            if (checkedListBox.Items.Count == 0)
                return;

            foreach (var i in Enumerable.Range(0, checkedListBox.Items.Count))
                checkedListBox.SetItemChecked(i, isChecked);
        }

        /// <summary>
        /// Sets the Checked state of the check the box whose name is identical
        /// to the value in the <paramref name="itemName" /> parameter.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) A <see cref="T:System.Windows.Forms.CheckedListBox" /> to
        /// act upon.
        /// </param>
        /// <param name="itemName">
        /// (Required.) String containing the name of the item whose Checked
        /// state is to be altered.
        /// </param>
        /// <param name="isChecked">
        /// (Optional.) Whether to set the Checked state of the list item whose
        /// name matches that of the string specified by the
        /// <paramref
        ///     name="itemName" />
        /// parameter. Default value is <c>true</c>.
        /// </param>
        public static void CheckByName(this CheckedListBox checkedListBox,
            string itemName, bool isChecked = true)
        {
            if (checkedListBox == null)
                return;

            if (checkedListBox.Items.Count == 0)
                return;

            if (string.IsNullOrWhiteSpace(itemName))
                return;

            foreach (var i in Enumerable.Range(0, checkedListBox.Items.Count))
                if (itemName.Equals(checkedListBox.Items[i].ToString()))
                {
                    checkedListBox.SetItemChecked(i, isChecked);
                    return;
                }
        }

        /// <summary>
        /// Gets the Checked state ( <c>true</c> for checked, <c>false</c> for
        /// unchecked) of the <paramref name="checkedListBox" /> item with the
        /// specified <paramref name="itemName" />.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) Reference to the
        /// <see
        ///     cref="T:System.Windows.Forms.CheckedListBox" />
        /// containing the items
        /// to be checked.
        /// </param>
        /// <param name="itemName">
        /// (Required.) String containing the caption of the item whose Checked
        /// state should be ascertained.
        /// </param>
        /// <returns>
        /// <c>false</c> if the item having a caption of
        /// <paramref
        ///     name="itemName" />
        /// does not exist or the
        /// <paramref
        ///     name="checkedListBox" />
        /// has zero items, or the checked state --
        /// <c>true</c> for checked, <c>false</c> for unchecked -- of the item
        /// whose caption matches the <paramref name="itemName" /> parameter's value.
        /// </returns>
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="checkedListBox" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="itemName" />, is
        /// passed a blank or <c>null</c> string for a value.
        /// </exception>
        public static bool GetCheckedByName(this CheckedListBox checkedListBox,
            string itemName)
        {
            if (checkedListBox == null)
                throw new ArgumentNullException(nameof(checkedListBox));
            if (string.IsNullOrWhiteSpace(itemName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(itemName)
                );

            if (checkedListBox.Items.Count == 0)
                return false;

            return (from i in Enumerable.Range(0, checkedListBox.Items.Count)
                where itemName.Equals(checkedListBox.Items[i].ToString())
                select checkedListBox.GetItemChecked(i)).FirstOrDefault();
        }
    }
}