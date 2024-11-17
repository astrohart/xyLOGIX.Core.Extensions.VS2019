using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Extension methods for a
    /// <see cref="T:System.Windows.Forms.CheckedListBox" />.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class CheckedListBoxExtensions
    {
        /// <summary>
        /// Gets a value indicating whether all the items in the
        /// <paramref name="checkedListBox" /> box are selected.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) Reference to the
        /// <see cref="T:System.Windows.Forms.CheckedListBox" /> the items of which are to
        /// be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if all the items in the checked list box are
        /// selected; <see langword="false" /> otherwise, or if the list box contains zero
        /// items.
        /// </returns>
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="checkedListBox" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static bool AreAllItemsSelected(
            this CheckedListBox checkedListBox
        )
        {
            if (checkedListBox == null)
                throw new ArgumentNullException(nameof(checkedListBox));

            if (checkedListBox.Items.Count == 0)
                return false;

            return checkedListBox.Items.Count > 0 &&
                   checkedListBox.CheckedItems.Count ==
                   checkedListBox.Items.Count;
        }

        /// <summary>
        /// Toggles the Checked state of all the items in the specified
        /// <paramref name="checkedListBox" />
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) A
        /// <see cref="T:System.Windows.Forms.CheckedListBox" /> to act upon.
        /// </param>
        /// <param name="isChecked">
        /// (Optional.) Whether to set the Checked state of all
        /// the list items or not. Default value is <see langword="true" />.
        /// </param>
        /// <remarks>
        /// If the <paramref name="checkedListBox" /> parameter is
        /// <see langword="null" />, or if the checked list box contains zero items, then
        /// this method does nothing.
        /// </remarks>
        public static void CheckAll(
            this CheckedListBox checkedListBox,
            bool isChecked = true
        )
        {
            try
            {
                if (checkedListBox == null) return;
                if (checkedListBox.Items.Count == 0) return;

                for (var i = 0; i < checkedListBox.Items.Count; i++)
                    checkedListBox.SetItemCheckState(
                        i, isChecked ? CheckState.Checked : CheckState.Unchecked
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Sets the Checked state of the check the box whose name is identical
        /// to the value in the <paramref name="itemName" /> parameter.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) A
        /// <see cref="T:System.Windows.Forms.CheckedListBox" /> to act upon.
        /// </param>
        /// <param name="itemName">
        /// (Required.) String containing the name of the item
        /// whose Checked state is to be altered.
        /// </param>
        /// <param name="isChecked">
        /// (Optional.) Whether to set the Checked state of the
        /// list item whose name matches that of the string specified by the
        /// <paramref name="itemName" /> parameter. Default value is
        /// <see langword="true" />.
        /// </param>
        public static void CheckByName(
            this CheckedListBox checkedListBox,
            string itemName,
            bool isChecked = true
        )
        {
            try
            {
                if (checkedListBox == null) return;
                if (checkedListBox.Items.Count == 0) return;
                if (string.IsNullOrWhiteSpace(itemName)) return;

                for (var i = 0; i < checkedListBox.Items.Count; i++)
                {
                    var listItemCaption = checkedListBox.Items[i]
                        .ToString();
                    if (string.IsNullOrWhiteSpace(listItemCaption)) continue;
                    if (!itemName.Equals(listItemCaption)) continue;

                    checkedListBox.SetItemCheckState(
                        i, isChecked ? CheckState.Checked : CheckState.Unchecked
                    );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Gets the Checked state ( <see langword="true" /> for checked,
        /// <see langword="false" /> for unchecked) of the
        /// <paramref name="checkedListBox" /> item with the specified
        /// <paramref name="itemName" />.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) Reference to the
        /// <see cref="T:System.Windows.Forms.CheckedListBox" /> containing the items to be
        /// checked.
        /// </param>
        /// <param name="itemName">
        /// (Required.) String containing the caption of the item
        /// whose Checked state should be ascertained.
        /// </param>
        /// <returns>
        /// <see langword="false" /> if the item having a caption of
        /// <paramref name="itemName" /> does not exist or the
        /// <paramref name="checkedListBox" /> has zero items, or the checked state --
        /// <see langword="true" /> for checked, <see langword="false" /> for unchecked --
        /// of the item whose caption matches the <paramref name="itemName" /> parameter's
        /// value.
        /// </returns>
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="checkedListBox" />, is passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="itemName" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        public static bool GetCheckedByName(
            this CheckedListBox checkedListBox,
            string itemName
        )
        {
            var result = false;

            try
            {
                if (checkedListBox == null) return result;
                if (checkedListBox.Items.Count == 0) return result;
                if (string.IsNullOrWhiteSpace(itemName)) return result;

                for (var i = 0; i < checkedListBox.Items.Count; i++)
                {
                    var listItemCaption = checkedListBox.Items[i]
                        .ToString();
                    if (!itemName.Equals(listItemCaption)) continue;

                    result = checkedListBox.GetItemCheckState(i) ==
                             CheckState.Checked;

                    break; /* no need to keep iterating */
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether none of the checkboxes in a
        /// <see cref="T:System.Windows.Forms.CheckedListBox" /> are selected.
        /// </summary>
        /// <param name="checkedListBox">
        /// (Required.) Reference to the
        /// <see cref="T:System.Windows.Forms.CheckedListBox" /> the items of which are to
        /// be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if none of the items in the list are checked
        /// or if there are zero entries in the list; <see langword="false" /> otherwise.
        /// </returns>
        public static bool NoItemsAreSelected(
            this CheckedListBox checkedListBox
        )
        {
            bool result;

            try
            {
                result = checkedListBox != null &&
                         (checkedListBox.Items.Count == 0 ||
                          checkedListBox.CheckedItems.Count == 0);
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