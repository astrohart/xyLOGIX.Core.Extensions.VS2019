using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    public interface IListView : IControl
    {
        ItemActivation Activation
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        ListViewAlignment Alignment
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool AllowColumnReorder
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool AutoArrange
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool BackgroundImageTiled
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        BorderStyle BorderStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool CheckBoxes
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        ListView.CheckedIndexCollection CheckedIndices { get; }
        ListView.CheckedListViewItemCollection CheckedItems { get; }
        ListView.ColumnHeaderCollection Columns { get; }
        IContainer Container { get; }

        ListViewItem FocusedItem
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool FullRowSelect
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool GridLines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
        ListViewGroupCollection Groups { get; }

        ColumnHeaderStyle HeaderStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool HideSelection
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool HotTracking
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool HoverSelection
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        ListViewInsertionMark InsertionMark { get; }
        ListView.ListViewItemCollection Items { get; }
        bool LabelEdit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
        bool LabelWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        ImageList LargeImageList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        IComparer ListViewItemSorter
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool MultiSelect
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool OwnerDraw { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        bool RightToLeftLayout
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool Scrollable
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        ListView.SelectedIndexCollection SelectedIndices { get; }
        ListView.SelectedListViewItemCollection SelectedItems { get; }

        bool ShowGroups
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool ShowItemToolTips
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        ImageList SmallImageList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        SortOrder Sorting
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        ImageList StateImageList
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        Size TileSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        ListViewItem TopItem
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool UseCompatibleStateImageBehavior
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        View View { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        int VirtualListSize
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        bool VirtualMode
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        event LabelEditEventHandler AfterLabelEdit;
        void ArrangeIcons(ListViewAlignment value);
        void ArrangeIcons();

        void AutoResizeColumn(
            int columnIndex,
            ColumnHeaderAutoResizeStyle headerAutoResize
        );

        void AutoResizeColumns(ColumnHeaderAutoResizeStyle headerAutoResize);
        event LabelEditEventHandler BeforeLabelEdit;
        void BeginUpdate();
        event CacheVirtualItemsEventHandler CacheVirtualItems;
        void Clear();
        event ColumnClickEventHandler ColumnClick;
        event ColumnReorderedEventHandler ColumnReordered;
        event ColumnWidthChangedEventHandler ColumnWidthChanged;
        event ColumnWidthChangingEventHandler ColumnWidthChanging;
        ObjRef CreateObjRef(Type requestedType);
        event DrawListViewColumnHeaderEventHandler DrawColumnHeader;
        event DrawListViewItemEventHandler DrawItem;
        event DrawListViewSubItemEventHandler DrawSubItem;
        void EndUpdate();
        void EnsureVisible(int index);
        ListViewItem FindItemWithText(string text);

        ListViewItem FindItemWithText(
            string text,
            bool includeSubItemsInSearch,
            int startIndex
        );

        ListViewItem FindItemWithText(
            string text,
            bool includeSubItemsInSearch,
            int startIndex,
            bool isPrefixSearch
        );

        ListViewItem FindNearestItem(SearchDirectionHint dir, Point point);

        ListViewItem FindNearestItem(
            SearchDirectionHint searchDirection,
            int x,
            int y
        );

        ListViewItem GetItemAt(int x, int y);
        Rectangle GetItemRect(int index);
        Rectangle GetItemRect(int index, ItemBoundsPortion portion);
        object GetLifetimeService();
        ListViewHitTestInfo HitTest(Point point);
        ListViewHitTestInfo HitTest(int x, int y);
        object InitializeLifetimeService();
        event EventHandler ItemActivate;
        event ItemCheckEventHandler ItemCheck;
        event ItemCheckedEventHandler ItemChecked;
        event ItemDragEventHandler ItemDrag;
        event ListViewItemMouseHoverEventHandler ItemMouseHover;
        event ListViewItemSelectionChangedEventHandler ItemSelectionChanged;
        void RedrawItems(int startIndex, int endIndex, bool invalidateOnly);
        event RetrieveVirtualItemEventHandler RetrieveVirtualItem;
        event EventHandler RightToLeftLayoutChanged;
        event SearchForVirtualItemEventHandler SearchForVirtualItem;
        event EventHandler SelectedIndexChanged;
        void Sort();
        string ToString();

        event ListViewVirtualItemsSelectionRangeChangedEventHandler
            VirtualItemsSelectionRangeChanged;
    }
}