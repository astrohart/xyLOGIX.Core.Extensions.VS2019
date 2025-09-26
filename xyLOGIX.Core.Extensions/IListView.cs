using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    public interface IListView : IControl
    {
        ItemActivation Activation { get; set; }
        ListViewAlignment Alignment { get; set; }
        bool AllowColumnReorder { get; set; }
        bool AutoArrange { get; set; }
        bool BackgroundImageTiled { get; set; }
        BorderStyle BorderStyle { get; set; }
        bool CheckBoxes { get; set; }
        ListView.CheckedIndexCollection CheckedIndices { get; }
        ListView.CheckedListViewItemCollection CheckedItems { get; }
        ListView.ColumnHeaderCollection Columns { get; }
        IContainer Container { get; }
        ListViewItem FocusedItem { get; set; }
        bool FullRowSelect { get; set; }
        bool GridLines { get; set; }
        ListViewGroupCollection Groups { get; }
        ColumnHeaderStyle HeaderStyle { get; set; }
        bool HideSelection { get; set; }
        bool HotTracking { get; set; }
        bool HoverSelection { get; set; }
        ListViewInsertionMark InsertionMark { get; }
        ListView.ListViewItemCollection Items { get; }
        bool LabelEdit { get; set; }
        bool LabelWrap { get; set; }
        ImageList LargeImageList { get; set; }
        IComparer ListViewItemSorter { get; set; }
        bool MultiSelect { get; set; }
        bool OwnerDraw { get; set; }
        bool RightToLeftLayout { get; set; }
        bool Scrollable { get; set; }
        ListView.SelectedIndexCollection SelectedIndices { get; }
        ListView.SelectedListViewItemCollection SelectedItems { get; }
        bool ShowGroups { get; set; }
        bool ShowItemToolTips { get; set; }
        ImageList SmallImageList { get; set; }
        SortOrder Sorting { get; set; }
        ImageList StateImageList { get; set; }
        Size TileSize { get; set; }
        ListViewItem TopItem { get; set; }
        bool UseCompatibleStateImageBehavior { get; set; }
        View View { get; set; }
        int VirtualListSize { get; set; }
        bool VirtualMode { get; set; }
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