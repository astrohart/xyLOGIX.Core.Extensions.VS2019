using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed methods, properties, and events of a Windows Forms
    /// ListView control.
    /// </summary>
    public interface IListView : IControl
    {
        /// <summary>
        /// Gets or sets how items are activated (clicked).
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.ItemActivation"/> values. The default is ItemActivation.Standard.
        /// </returns>
        ItemActivation Activation
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the alignment of items in the control.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.ListViewAlignment"/> values. The default is ListViewAlignment.Top.
        /// </returns>
        ListViewAlignment Alignment
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the user can drag column headers to reorder columns.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the user can drag column headers to reorder columns; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool AllowColumnReorder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether icons are automatically arranged.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if icons are automatically arranged; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool AutoArrange
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the background image is tiled.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the background image is tiled; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool BackgroundImageTiled
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the border style of the control.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.BorderStyle"/> values. The default is BorderStyle.Fixed3D.
        /// </returns>
        BorderStyle BorderStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a check box appears next to each item in the control.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if a check box appears next to each item in the control; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool CheckBoxes
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets the collection of items in the control that are checked.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListView.CheckedIndexCollection"/> that contains the indexes of checked items in the list.
        /// </returns>
        ListView.CheckedIndexCollection CheckedIndices { get; }

        /// <summary>
        /// Gets the collection of checked items in the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListView.CheckedListViewItemCollection"/> that contains the checked items in the list.
        /// </returns>
        ListView.CheckedListViewItemCollection CheckedItems { get; }

        /// <summary>
        /// Gets the collection of column headers in the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection"/> that contains all column header objects in the list.
        /// </returns>
        ListView.ColumnHeaderCollection Columns { get; }

        /// <summary>
        /// Gets the container for components.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.ComponentModel.IContainer"/> that contains the component.
        /// </returns>
        IContainer Container { get; }

        /// <summary>
        /// Gets or sets the item that has focus in the list view control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListViewItem"/> that represents the item that has focus.
        /// </returns>
        ListViewItem FocusedItem
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether clicking an item selects all its subitems.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if clicking an item selects all its subitems; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool FullRowSelect
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether grid lines appear between the rows and columns containing the items and subitems in the control.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if grid lines appear between the rows and columns of the list; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool GridLines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets the collection of groups in the list view control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListViewGroupCollection"/> that represents the groups within the list.
        /// </returns>
        ListViewGroupCollection Groups { get; }

        /// <summary>
        /// Gets or sets the column header style.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.ColumnHeaderStyle"/> values. The default is ColumnHeaderStyle.Clickable.
        /// </returns>
        ColumnHeaderStyle HeaderStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the selected item in the control remains highlighted when the control loses focus.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the selected item is not highlighted when the control loses focus; otherwise, <see langword="false"/>. 
        /// The default is <see langword="true"/>.
        /// </returns>
        bool HideSelection
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether an item is automatically selected when the mouse pointer remains over the item for a few seconds.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if an item is automatically selected when the mouse pointer hovers over the item; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool HotTracking
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether an item is automatically selected when the mouse pointer pauses over the item.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if an item is automatically selected when the mouse pointer hovers over the item; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool HoverSelection
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets the insertion mark for the list view.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListViewInsertionMark"/> that provides information about the insertion mark of the list view.
        /// </returns>
        ListViewInsertionMark InsertionMark { get; }

        /// <summary>
        /// Gets the collection of items in the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection"/> that contains all items in the list.
        /// </returns>
        ListView.ListViewItemCollection Items { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the user can edit the item labels.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if item labels can be edited; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool LabelEdit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value indicating whether item labels wrap when they are too long to fit in the control.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if item labels wrap when they are too long to fit in the control; otherwise, <see langword="false"/>. 
        /// The default is <see langword="true"/>.
        /// </returns>
        bool LabelWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the ImageList to use when displaying items as large icons in the control.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Windows.Forms.ImageList"/> that contains the images to display for the large icon view of the items.
        /// </returns>
        ImageList LargeImageList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the implementation of the <see cref="T:System.Collections.IComparer"/> interface used to sort the items in the control.
        /// </summary>
        /// <returns>
        /// An implementation of the <see cref="T:System.Collections.IComparer"/> interface used to sort the items in the list.
        /// </returns>
        IComparer ListViewItemSorter
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether multiple items can be selected.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if multiple items can be selected; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool MultiSelect
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the items in the control are drawn by the application.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the items in the control are drawn by the application; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool OwnerDraw { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value indicating whether the RightToLeft property should affect the layout of the ListView control and its elements.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the layout of the ListView control and its elements is affected by the RightToLeft property; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool RightToLeftLayout
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether scroll bars appear in the control when they are needed.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if scroll bars appear in the control when they are needed; otherwise, <see langword="false"/>. 
        /// The default is <see langword="true"/>.
        /// </returns>
        bool Scrollable
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a collection of the indexes of the selected items in the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListView.SelectedIndexCollection"/> that contains the indexes of the selected items in the list.
        /// </returns>
        ListView.SelectedIndexCollection SelectedIndices { get; }

        /// <summary>
        /// Gets a collection of the selected items in the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListView.SelectedListViewItemCollection"/> that contains the selected items in the list.
        /// </returns>
        ListView.SelectedListViewItemCollection SelectedItems { get; }

        /// <summary>
        /// Gets or sets a value indicating whether groups are displayed.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if groups are displayed; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool ShowGroups
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether ToolTips are shown for the ListViewItems and SubItems.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if ToolTips are shown for the ListViewItems and SubItems; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool ShowItemToolTips
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the ImageList to use when displaying items as small icons in the control.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Windows.Forms.ImageList"/> that contains the images to display for the small icon view of the items.
        /// </returns>
        ImageList SmallImageList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the sort order for items in the control.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.SortOrder"/> values. The default is SortOrder.None.
        /// </returns>
        SortOrder Sorting
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the state image list for the control.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Windows.Forms.ImageList"/> that contains the images to use for the different states of the items.
        /// </returns>
        ImageList StateImageList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the size of the tiles shown in tile view.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size"/> that represents the size, in pixels, of the tiles.
        /// </returns>
        Size TileSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the item at the top of the ListView.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ListViewItem"/> that represents the item at the top of the ListView.
        /// </returns>
        ListViewItem TopItem
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the system-defined or the user-defined behavior for the state image of the control is used.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the user-defined behavior for the state image is used; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool UseCompatibleStateImageBehavior
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the view mode of the control.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.View"/> values. The default is View.LargeIcon.
        /// </returns>
        View View { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the number of items that the list view control will display in virtual mode.
        /// </summary>
        /// <returns>
        /// The number of items that the list view control will display in virtual mode.
        /// </returns>
        int VirtualListSize
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the ListView uses the virtual mode.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the ListView uses the virtual mode; otherwise, <see langword="false"/>. 
        /// The default is <see langword="false"/>.
        /// </returns>
        bool VirtualMode
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Occurs after the label of an item has been edited.
        /// </summary>
        event LabelEditEventHandler AfterLabelEdit;

        /// <summary>
        /// Arranges the items in the control according to the specified value.
        /// </summary>
        /// <param name="value">One of the <see cref="T:System.Windows.Forms.ListViewAlignment"/> values.</param>
        void ArrangeIcons(ListViewAlignment value);

        /// <summary>
        /// Arranges the items in the control according to the default alignment.
        /// </summary>
        void ArrangeIcons();

        /// <summary>
        /// Resizes a column to fit the header or the contents, as specified.
        /// </summary>
        /// <param name="columnIndex">The zero-based index of the column to resize.</param>
        /// <param name="headerAutoResize">One of the <see cref="T:System.Windows.Forms.ColumnHeaderAutoResizeStyle"/> values.</param>
        void AutoResizeColumn(
            int columnIndex,
            ColumnHeaderAutoResizeStyle headerAutoResize
        );

        /// <summary>
        /// Resizes all columns to fit the header or the contents, as specified.
        /// </summary>
        /// <param name="headerAutoResize">One of the <see cref="T:System.Windows.Forms.ColumnHeaderAutoResizeStyle"/> values.</param>
        void AutoResizeColumns(ColumnHeaderAutoResizeStyle headerAutoResize);

        /// <summary>
        /// Occurs before the label of an item has been edited.
        /// </summary>
        event LabelEditEventHandler BeforeLabelEdit;

        /// <summary>
        /// Prevents the control from drawing until the EndUpdate method is called.
        /// </summary>
        void BeginUpdate();

        /// <summary>
        /// Occurs when the operating system is requesting a cache of items for the control.
        /// </summary>
        event CacheVirtualItemsEventHandler CacheVirtualItems;

        /// <summary>
        /// Removes all items from the control.
        /// </summary>
        void Clear();

        /// <summary>
        /// Occurs when a column in the control is clicked.
        /// </summary>
        event ColumnClickEventHandler ColumnClick;

        /// <summary>
        /// Occurs after a column in the control is moved.
        /// </summary>
        event ColumnReorderedEventHandler ColumnReordered;

        /// <summary>
        /// Occurs when the width of a column is changed.
        /// </summary>
        event ColumnWidthChangedEventHandler ColumnWidthChanged;

        /// <summary>
        /// Occurs when the width of a column is changing.
        /// </summary>
        event ColumnWidthChangingEventHandler ColumnWidthChanging;

        /// <summary>
        /// Creates an object reference that can be used to marshal to the control from another application domain.
        /// </summary>
        /// <param name="requestedType">The type of the requested object.</param>
        /// <returns>An <see cref="T:System.Runtime.Remoting.ObjRef"/> that represents a marshaled reference to the control.</returns>
        ObjRef CreateObjRef(Type requestedType);

        /// <summary>
        /// Occurs when the owner of the ListView draws the column headers.
        /// </summary>
        event DrawListViewColumnHeaderEventHandler DrawColumnHeader;

        /// <summary>
        /// Occurs when the owner of the ListView draws the items.
        /// </summary>
        event DrawListViewItemEventHandler DrawItem;

        /// <summary>
        /// Occurs when the owner of the ListView draws the subitems.
        /// </summary>
        event DrawListViewSubItemEventHandler DrawSubItem;

        /// <summary>
        /// Resumes the usual painting of the control, after painting is suspended by the BeginUpdate method.
        /// </summary>
        void EndUpdate();

        /// <summary>
        /// Ensures that the specified item is visible within the control, scrolling the control if necessary.
        /// </summary>
        /// <param name="index">The zero-based index of the item to scroll into view.</param>
        void EnsureVisible(int index);

        /// <summary>
        /// Searches for the item that matches the specified text.
        /// </summary>
        /// <param name="text">The text to search for.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewItem"/> that contains the specified text.</returns>
        ListViewItem FindItemWithText(string text);

        /// <summary>
        /// Searches for the item that matches the specified text with search options and starting index.
        /// </summary>
        /// <param name="text">The text to search for.</param>
        /// <param name="includeSubItemsInSearch"><see langword="true"/> to include subitems in the search; otherwise, <see langword="false"/>.</param>
        /// <param name="startIndex">The zero-based index of the item to start searching from.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewItem"/> that contains the specified text.</returns>
        ListViewItem FindItemWithText(
            string text,
            bool includeSubItemsInSearch,
            int startIndex
        );

        /// <summary>
        /// Searches for the item that matches the specified text with search options, starting index, and prefix search.
        /// </summary>
        /// <param name="text">The text to search for.</param>
        /// <param name="includeSubItemsInSearch"><see langword="true"/> to include subitems in the search; otherwise, <see langword="false"/>.</param>
        /// <param name="startIndex">The zero-based index of the item to start searching from.</param>
        /// <param name="isPrefixSearch"><see langword="true"/> to search from the beginning of the string; <see langword="false"/> to search for the text anywhere in the string.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewItem"/> that contains the specified text.</returns>
        ListViewItem FindItemWithText(
            string text,
            bool includeSubItemsInSearch,
            int startIndex,
            bool isPrefixSearch
        );

        /// <summary>
        /// Returns the nearest item to the location of the input point.
        /// </summary>
        /// <param name="dir">One of the <see cref="T:System.Windows.Forms.SearchDirectionHint"/> values.</param>
        /// <param name="point">The point to search from.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewItem"/> that is nearest to the location of the input point.</returns>
        ListViewItem FindNearestItem(SearchDirectionHint dir, Point point);

        /// <summary>
        /// Returns the nearest item to the point with the specified coordinates.
        /// </summary>
        /// <param name="searchDirection">One of the <see cref="T:System.Windows.Forms.SearchDirectionHint"/> values.</param>
        /// <param name="x">The x-coordinate of the point to search from.</param>
        /// <param name="y">The y-coordinate of the point to search from.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewItem"/> that is nearest to the specified coordinates.</returns>
        ListViewItem FindNearestItem(
            SearchDirectionHint searchDirection,
            int x,
            int y
        );

        /// <summary>
        /// Returns the item at the specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate of the point to search from.</param>
        /// <param name="y">The y-coordinate of the point to search from.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewItem"/> at the specified coordinates, or <see langword="null"/> if there is no item at those coordinates.</returns>
        ListViewItem GetItemAt(int x, int y);

        /// <summary>
        /// Retrieves the bounding rectangle for an item within the control.
        /// </summary>
        /// <param name="index">The zero-based index of the item whose bounding rectangle you want.</param>
        /// <returns>A <see cref="T:System.Drawing.Rectangle"/> that represents the bounding rectangle for the specified item.</returns>
        Rectangle GetItemRect(int index);

        /// <summary>
        /// Retrieves the bounding rectangle for an item within the control and specifies the portion of the item for which to retrieve the bounding rectangle.
        /// </summary>
        /// <param name="index">The zero-based index of the item whose bounding rectangle you want.</param>
        /// <param name="portion">One of the <see cref="T:System.Windows.Forms.ItemBoundsPortion"/> values that specifies the portion of the item for which to retrieve the bounding rectangle.</param>
        /// <returns>A <see cref="T:System.Drawing.Rectangle"/> that represents the bounding rectangle for the specified portion of the specified item.</returns>
        Rectangle GetItemRect(int index, ItemBoundsPortion portion);

        /// <summary>
        /// Gets the current lifetime service object that controls the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/> used to control the lifetime policy for this instance.</returns>
        object GetLifetimeService();

        /// <summary>
        /// Returns hit-test information about the specified point.
        /// </summary>
        /// <param name="point">A <see cref="T:System.Drawing.Point"/> that contains the coordinates for the hit test.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewHitTestInfo"/> that contains the information about the specified point.</returns>
        ListViewHitTestInfo HitTest(Point point);

        /// <summary>
        /// Returns hit-test information about the specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate at which to perform the hit test.</param>
        /// <param name="y">The y-coordinate at which to perform the hit test.</param>
        /// <returns>A <see cref="T:System.Windows.Forms.ListViewHitTestInfo"/> that contains the information about the specified coordinates.</returns>
        ListViewHitTestInfo HitTest(int x, int y);

        /// <summary>
        /// Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/> used to control the lifetime policy for this instance.</returns>
        object InitializeLifetimeService();

        /// <summary>
        /// Occurs when the user activates an item.
        /// </summary>
        event EventHandler ItemActivate;

        /// <summary>
        /// Occurs when the check state of an item changes.
        /// </summary>
        event ItemCheckEventHandler ItemCheck;

        /// <summary>
        /// Occurs when the check state of an item has changed.
        /// </summary>
        event ItemCheckedEventHandler ItemChecked;

        /// <summary>
        /// Occurs when the user begins dragging an item.
        /// </summary>
        event ItemDragEventHandler ItemDrag;

        /// <summary>
        /// Occurs when the mouse pointer hovers over an item.
        /// </summary>
        event ListViewItemMouseHoverEventHandler ItemMouseHover;

        /// <summary>
        /// Occurs when an item is selected or deselected.
        /// </summary>
        event ListViewItemSelectionChangedEventHandler ItemSelectionChanged;

        /// <summary>
        /// Forces the ListView to redraw the specified items.
        /// </summary>
        /// <param name="startIndex">The zero-based index of the first item to redraw.</param>
        /// <param name="endIndex">The zero-based index of the last item to redraw.</param>
        /// <param name="invalidateOnly"><see langword="true"/> to just invalidate the items; <see langword="false"/> to force an immediate repaint.</param>
        void RedrawItems(int startIndex, int endIndex, bool invalidateOnly);

        /// <summary>
        /// Occurs when the control is in virtual mode and the application needs to retrieve item data.
        /// </summary>
        event RetrieveVirtualItemEventHandler RetrieveVirtualItem;

        /// <summary>
        /// Occurs when the RightToLeftLayout property has changed.
        /// </summary>
        event EventHandler RightToLeftLayoutChanged;

        /// <summary>
        /// Occurs when the control is in virtual mode and the application needs to search for an item.
        /// </summary>
        event SearchForVirtualItemEventHandler SearchForVirtualItem;

        /// <summary>
        /// Occurs when the selected item changes.
        /// </summary>
        event EventHandler SelectedIndexChanged;

        /// <summary>
        /// Sorts the items using the current sort settings.
        /// </summary>
        void Sort();

        /// <summary>
        /// Returns a string representation of the control.
        /// </summary>
        /// <returns>A string that represents the control.</returns>
        string ToString();

        /// <summary>
        /// Occurs when the range of selected virtual items has changed in the ListView.
        /// </summary>
        event ListViewVirtualItemsSelectionRangeChangedEventHandler
            VirtualItemsSelectionRangeChanged;
    }
}