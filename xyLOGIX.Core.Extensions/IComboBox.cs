using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a WinForms
    /// combo box control.
    /// </summary>
    public interface IComboBox : IControl
    {
        /// <summary>
        /// Gets or sets a custom
        /// <see cref="T:System.Collections.Specialized.StringCollection" /> to use when
        /// the <see cref="P:System.Windows.Forms.ComboBox.AutoCompleteSource" /> property
        /// is set to <see langword="CustomSource" />.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Specialized.StringCollection" /> to
        /// use with <see cref="P:System.Windows.Forms.ComboBox.AutoCompleteSource" />.
        /// </returns>
        AutoCompleteStringCollection AutoCompleteCustomSource
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets an option that controls how automatic completion works
        /// for the <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// One of the values of
        /// <see cref="T:System.Windows.Forms.AutoCompleteMode" /> . The values are
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.Append" />,
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.None" /> ,
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.Suggest" /> , and
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.SuggestAppend" /> . The
        /// default is <see cref="F:System.Windows.Forms.AutoCompleteMode.None" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// specified value is not one of the values of
        /// <see cref="T:System.Windows.Forms.AutoCompleteMode" />.
        /// </exception>
        AutoCompleteMode AutoCompleteMode
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value specifying the quote of complete strings used
        /// for automatic completion.
        /// </summary>
        /// <returns>
        /// One of the values of
        /// <see cref="T:System.Windows.Forms.AutoCompleteSource" /> . The options are
        /// <see langword="AllSystemSources" />, <see langword="AllUrl" />,
        /// <see langword="FileSystem" /> , <see langword="HistoryList" />,
        /// <see langword="RecentlyUsedList" /> , <see langword="CustomSource" />, and
        /// <see langword="None" />. The default is <see langword="None" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// specified value is not one of the values of
        /// <see cref="T:System.Windows.Forms.AutoCompleteSource" />.
        /// </exception>
        AutoCompleteSource AutoCompleteSource
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the data source for this
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// An object that implements the
        /// <see cref="T:System.Collections.IList" /> interface or an
        /// <see cref="T:System.Array" /> . The default is <see langword="null" />.
        /// </returns>
        object DataSource
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether your code or the operating
        /// system will handle drawing of elements in the list.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DrawMode" /> enumeration
        /// values. The default is <see cref="F:System.Windows.Forms.DrawMode.Normal" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value is not a valid <see cref="T:System.Windows.Forms.DrawMode" /> enumeration
        /// value.
        /// </exception>
        DrawMode DrawMode
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the height in pixels of the drop-down portion of the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns> The height, in pixels, of the drop-down box. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The specified value is less than
        /// one.
        /// </exception>
        int DropDownHeight
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets a value specifying the style of the combo box. </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.ComboBoxStyle" />
        /// values. The default is <see langword="DropDown" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// assigned value is not one of the
        /// <see cref="T:System.Windows.Forms.ComboBoxStyle" /> value(s).
        /// </exception>
        ComboBoxStyle DropDownStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the width of the of the drop-down portion of a combo
        /// box.
        /// </summary>
        /// <returns> The width, in pixels, of the drop-down box. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The specified value is less than
        /// one.
        /// </exception>
        int DropDownWidth
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the combo box is displaying
        /// its drop-down portion.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the drop-down portion is displayed;
        /// otherwise, <see langword="false" />. The default is false.
        /// </returns>
        bool DroppedDown
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the appearance of the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// One of the enumeration values that specifies the appearance of the
        /// control. The options are <see langword="Flat" />, <see langword="Popup" /> ,
        /// <see langword="Standard" />, and <see langword="System" /> . The default is
        /// <see langword="Standard" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// specified value is not one of the values of
        /// <see cref="T:System.Windows.Forms.FlatStyle" />.
        /// </exception>
        FlatStyle FlatStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the control should resize to
        /// avoid showing partial items.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the list portion can contain only complete
        /// items; otherwise, <see langword="false" />. The default is
        /// <see langword="true" />.
        /// </returns>
        bool IntegralHeight
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the height of an item in the combo box. </summary>
        /// <returns> The height, in pixels, of an item in the combo box. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The item height value is less
        /// than zero.
        /// </exception>
        int ItemHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets an object representing the collection of the items contained in
        /// this <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ComboBox.ObjectCollection" />
        /// representing the items in the <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </returns>
        ComboBox.ObjectCollection Items { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets the maximum number of items to be shown in the drop-down
        /// portion of the <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// The maximum number of items of in the drop-down portion. The minimum
        /// for this property is 1 and the maximum is 100.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The maximum number is set less
        /// than one or greater than 100.
        /// </exception>
        int MaxDropDownItems
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the number of characters a user can type into the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// The maximum number of characters a user can enter. Values of less
        /// than zero are reset to zero, which is the default value.
        /// </returns>
        int MaxLength { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets the preferred height of the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> .
        /// </summary>
        /// <returns> The preferred height, in pixels, of the item area of the combo box. </returns>
        int PreferredHeight { [DebuggerStepThrough] get; }

        /// <summary> Gets or sets the index specifying the currently selected item. </summary>
        /// <returns>
        /// A zero-based index of the currently selected item. A value of
        /// negative one (-1) is returned if no item is selected.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The specified index is
        /// less than or equal to -2. -or- The specified index is greater than or equal to
        /// the number of items in the combo box.
        /// </exception>
        int SelectedIndex
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets currently selected item in the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// The object that is the currently selected item or
        /// <see langword="null" /> if there is no currently selected item.
        /// </returns>
        object SelectedItem
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the text that is selected in the editable portion of a
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <returns>
        /// A string that represents the currently selected text in the combo
        /// box. If <see cref="P:System.Windows.Forms.ComboBox.DropDownStyle" /> is set to
        /// <see cref="F:System.Windows.Forms.ComboBoxStyle.DropDownList" /> , the return
        /// value is an empty string ("").
        /// </returns>
        string SelectedText
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the number of characters selected in the editable
        /// portion of the combo box.
        /// </summary>
        /// <returns> The number of characters selected in the combo box. </returns>
        /// <exception cref="T:System.ArgumentException"> The value was less than zero. </exception>
        int SelectionLength
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the starting index of text selected in the combo box. </summary>
        /// <returns>
        /// The zero-based index of the first character in the string of the
        /// current text selection.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"> The value is less than zero. </exception>
        int SelectionStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the items in the combo box
        /// are sorted.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the combo box is sorted; otherwise,
        /// <see langword="false" /> . The default is <see langword="false" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// An attempt was made to sort a
        /// <see cref="T:System.Windows.Forms.ComboBox" /> that is attached to a data
        /// quote.
        /// </exception>
        bool Sorted { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Maintains performance when items are added to the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> one at a time.
        /// </summary>
        void BeginUpdate();

        /// <summary>
        /// Occurs when a visual aspect of an owner-drawn
        /// <see cref="T:System.Windows.Forms.ComboBox" /> changes.
        /// </summary>
        event DrawItemEventHandler DrawItem;

        /// <summary>
        /// Occurs when the drop-down portion of a
        /// <see cref="T:System.Windows.Forms.ComboBox" /> is shown.
        /// </summary>
        event EventHandler DropDown;

        /// <summary>
        /// Occurs when the drop-down portion of the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> is no longer visible.
        /// </summary>
        event EventHandler DropDownClosed;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.ComboBox.DropDownStyle" /> property has
        /// changed.
        /// </summary>
        event EventHandler DropDownStyleChanged;

        /// <summary>
        /// Resumes painting the <see cref="T:System.Windows.Forms.ComboBox" />
        /// control after painting is suspended by the
        /// <see cref="M:System.Windows.Forms.ComboBox.BeginUpdate" /> method.
        /// </summary>
        void EndUpdate();

        /// <summary>
        /// Returns the index of the first item in the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> that starts with the specified
        /// string.
        /// </summary>
        /// <param name="s"> The <see cref="T:System.String" /> to search for. </param>
        /// <returns>
        /// The zero-based index of the first item found; returns -1 if no match
        /// is found.
        /// </returns>
        int FindString(string s);

        /// <summary>
        /// Returns the index of the first item in the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> beyond the specified index that
        /// contains the specified string. The search is not case sensitive.
        /// </summary>
        /// <param name="s"> The <see cref="T:System.String" /> to search for. </param>
        /// <param name="startIndex">
        /// The zero-based index of the item before the first
        /// item to be searched. Set to -1 to search from the beginning of the control.
        /// </param>
        /// <returns>
        /// The zero-based index of the first item found; returns -1 if no match
        /// is found, or 0 if the <paramref name="s" /> parameter specifies
        /// <see cref="F:System.String.Empty" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The
        /// <paramref name="startIndex" /> is less than -1. -or- The
        /// <paramref name="startIndex" /> is greater than the last index in the
        /// collection.
        /// </exception>
        int FindString(string s, int startIndex);

        /// <summary>
        /// Finds the first item in the combo box that matches the specified
        /// string.
        /// </summary>
        /// <param name="s"> The <see cref="T:System.String" /> to search for. </param>
        /// <returns>
        /// The zero-based index of the first item found; returns -1 if no match
        /// is found, or 0 if the <paramref name="s" /> parameter specifies
        /// <see cref="F:System.String.Empty" />.
        /// </returns>
        int FindStringExact(string s);

        /// <summary>
        /// Finds the first item after the specified index that matches the
        /// specified string.
        /// </summary>
        /// <param name="s"> The <see cref="T:System.String" /> to search for. </param>
        /// <param name="startIndex">
        /// The zero-based index of the item before the first
        /// item to be searched. Set to -1 to search from the beginning of the control.
        /// </param>
        /// <returns>
        /// The zero-based index of the first item found; returns -1 if no match
        /// is found, or 0 if the <paramref name="s" /> parameter specifies
        /// <see cref="F:System.String.Empty" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The
        /// <paramref name="startIndex" /> is less than -1. -or- The
        /// <paramref name="startIndex" /> is equal to the last index in the collection.
        /// </exception>
        int FindStringExact(string s, int startIndex);

        /// <summary>
        /// Returns the height of an item in the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <param name="index"> The index of the item to return the height of. </param>
        /// <returns> The height, in pixels, of the item at the specified index. </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The
        /// <paramref name="index" /> is less than zero. -or- The <paramref name="index" />
        /// is greater than count of items in the list.
        /// </exception>
        int GetItemHeight(int index);

        /// <summary>
        /// Occurs each time an owner-drawn
        /// <see cref="T:System.Windows.Forms.ComboBox" /> item needs to be drawn and when
        /// the sizes of the list items are determined.
        /// </summary>
        event MeasureItemEventHandler MeasureItem;

        /// <summary>
        /// Selects a range of text in the editable portion of the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        /// <param name="start">
        /// The position of the first character in the current text
        /// selection within the textbox.
        /// </param>
        /// <param name="length"> The number of characters to select. </param>
        /// <exception cref="T:System.ArgumentException">
        /// The <paramref name="start" /> is
        /// less than zero. -or- <paramref name="start" /> plus <paramref name="length" />
        /// is less than zero.
        /// </exception>
        void Select(int start, int length);

        /// <summary>
        /// Selects all the text in the editable portion of the
        /// <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        void SelectAll();

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.ComboBox.SelectedIndex" /> property has
        /// changed.
        /// </summary>
        event EventHandler SelectedIndexChanged;

        /// <summary>
        /// Occurs when the user changes the selected item and that change is
        /// displayed in the <see cref="T:System.Windows.Forms.ComboBox" />.
        /// </summary>
        event EventHandler SelectionChangeCommitted;

        /// <summary>
        /// Occurs when the control has formatted the text, but before the text
        /// is displayed.
        /// </summary>
        event EventHandler TextUpdate;

        /// <summary>
        /// Returns a string that represents the
        /// <see cref="T:System.Windows.Forms.ComboBox" /> control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current
        /// <see cref="T:System.Windows.Forms.ComboBox" /> . The string includes the type
        /// and the number of items in the <see cref="T:System.Windows.Forms.ComboBox" />
        /// control.
        /// </returns>
        string ToString();
    }
}