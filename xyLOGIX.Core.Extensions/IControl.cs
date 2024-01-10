using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// represents a WinForms control.
    /// </summary>
    public interface IControl : IComponent, ISynchronizeInvoke, IWin32Window
    {
        /// <summary>
        /// Gets the <see cref="T:System.Windows.Forms.AccessibleObject" />
        /// assigned to the control.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.AccessibleObject" /> assigned
        /// to the control.
        /// </returns>
        AccessibleObject AccessibilityObject { get; }

        /// <summary>
        /// Gets or sets the default action description of the control for use by
        /// accessibility client applications.
        /// </summary>
        /// <returns>
        /// The default action description of the control for use by
        /// accessibility client applications.
        /// </returns>
        string AccessibleDefaultActionDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the control used by accessibility
        /// client applications.
        /// </summary>
        /// <returns>
        /// The description of the control used by accessibility client
        /// applications. The default is <see langword="null" />.
        /// </returns>
        string AccessibleDescription { get; set; }

        /// <summary>
        /// Gets or sets the name of the control used by accessibility client
        /// applications.
        /// </summary>
        /// <returns>
        /// The name of the control used by accessibility client applications.
        /// The default is <see langword="null" />.
        /// </returns>
        string AccessibleName { get; set; }

        /// <summary> Gets or sets the accessible role of the control </summary>
        /// <returns>
        /// One of the values of
        /// <see cref="T:System.Windows.Forms.AccessibleRole" /> . The default is
        /// <see langword="Default" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value assigned is not one of the
        /// <see cref="T:System.Windows.Forms.AccessibleRole" /> values.
        /// </exception>
        AccessibleRole AccessibleRole { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the control can accept data
        /// that the user drags onto it.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if drag-and-drop operations are allowed in
        /// the control; otherwise, <see langword="false" />. The default is
        /// <see langword="false" />.
        /// </returns>
        bool AllowDrop { get; set; }

        /// <summary>
        /// Gets or sets the edges of the container to which a control is bound
        /// and determines how a control is resized with its parent.
        /// </summary>
        /// <returns>
        /// A bitwise combination of the
        /// <see cref="T:System.Windows.Forms.AnchorStyles" /> values. The default is
        /// <see langword="Top" /> and <see langword="Left" />.
        /// </returns>
        AnchorStyles Anchor { get; set; }

        /// <summary>
        /// Gets or sets where this control is scrolled to in
        /// <see
        ///     cref="M:System.Windows.Forms.ScrollableControl.ScrollControlIntoView(System.Windows.Forms.Control)" />
        /// .
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Point" /> specifying the scroll
        /// location. The default is the upper-left corner of the control.
        /// </returns>
        Point AutoScrollOffset { get; set; }

        /// <summary> Gets or sets the background color for the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Color" /> that represents the
        /// background color of the control. The default is the value of the
        /// <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.
        /// </returns>
        Color BackColor { get; set; }

        /// <summary> Gets or sets the background image displayed in the control. </summary>
        /// <returns>
        /// An <see cref="T:System.Drawing.Image" /> that represents the image to
        /// display in the background of the control.
        /// </returns>
        Image BackgroundImage { get; set; }

        /// <summary>
        /// Gets or sets the background image layout as defined in the
        /// <see cref="T:System.Windows.Forms.ImageLayout" /> enumeration.
        /// </summary>
        /// <returns>
        /// One of the values of
        /// <see cref="T:System.Windows.Forms.ImageLayout" /> (
        /// <see cref="F:System.Windows.Forms.ImageLayout.Center" /> ,
        /// <see cref="F:System.Windows.Forms.ImageLayout.None" /> ,
        /// <see cref="F:System.Windows.Forms.ImageLayout.Stretch" /> ,
        /// <see cref="F:System.Windows.Forms.ImageLayout.Tile" /> , or
        /// <see cref="F:System.Windows.Forms.ImageLayout.Zoom" /> ).
        /// <see cref="F:System.Windows.Forms.ImageLayout.Tile" /> is the default value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// specified enumeration value does not exist.
        /// </exception>
        ImageLayout BackgroundImageLayout { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Windows.Forms.BindingContext" />
        /// for the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.BindingContext" /> for the
        /// control.
        /// </returns>
        BindingContext BindingContext { get; set; }

        /// <summary>
        /// Gets the distance, in pixels, between the bottom edge of the control
        /// and the top edge of its container's client area.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Int32" /> representing the distance, in
        /// pixels, between the bottom edge of the control and the top edge of its
        /// container's client area.
        /// </returns>
        int Bottom { get; }

        /// <summary>
        /// Gets or sets the size and location of the control including its
        /// nonclient elements, in pixels, relative to the parent control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> in pixels relative to the
        /// parent control that represents the size and location of the control including
        /// its nonclient elements.
        /// </returns>
        Rectangle Bounds { get; set; }

        /// <summary> Gets a value indicating whether the control can receive focus. </summary>
        /// <returns>
        /// <see langword="true" /> if the control can receive focus; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool CanFocus { get; }

        /// <summary> Gets a value indicating whether the control can be selected. </summary>
        /// <returns>
        /// <see langword="true" /> if the control can be selected; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool CanSelect { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the control has captured the
        /// mouse.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control has captured the mouse;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool Capture { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the control causes validation
        /// to be performed on any controls that require validation when it receives focus.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control causes validation to be
        /// performed on any controls requiring validation when it receives focus;
        /// otherwise, <see langword="false" />. The default is <see langword="true" />.
        /// </returns>
        bool CausesValidation { get; set; }

        /// <summary> Gets the rectangle that represents the client area of the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents the
        /// client area of the control.
        /// </returns>
        Rectangle ClientRectangle { get; }

        /// <summary> Gets or sets the height and width of the client area of the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size" /> that represents the dimensions
        /// of the client area of the control.
        /// </returns>
        Size ClientSize { get; set; }

        /// <summary>
        /// Gets the name of the company or creator of the application containing
        /// the control.
        /// </summary>
        /// <returns>
        /// The company name or creator of the application containing the
        /// control.
        /// </returns>
        string CompanyName { get; }

        /// <summary>
        /// Gets a value indicating whether the control, or one of its child
        /// controls, currently has the input focus.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control or one of its child controls
        /// currently has the input focus; otherwise, <see langword="false" />.
        /// </returns>
        bool ContainsFocus { get; }

        /// <summary> Gets or sets the shortcut menu associated with the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ContextMenu" /> that represents
        /// the shortcut menu associated with the control.
        /// </returns>
        ContextMenu ContextMenu { get; set; }

        /// <summary>
        /// Gets or sets the
        /// <see cref="T:System.Windows.Forms.ContextMenuStrip" /> associated with this
        /// control.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.ContextMenuStrip" /> for this
        /// control, or <see langword="null" /> if there is no
        /// <see cref="T:System.Windows.Forms.ContextMenuStrip" /> . The default is
        /// <see langword="null" />.
        /// </returns>
        ContextMenuStrip ContextMenuStrip { get; set; }

        /// <summary> Gets the collection of controls contained within the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Control.ControlCollection" />
        /// representing the collection of controls contained within the control.
        /// </returns>
        Control.ControlCollection Controls { get; }

        /// <summary> Gets a value indicating whether the control has been created. </summary>
        /// <returns>
        /// <see langword="true" /> if the control has been created; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool Created { get; }

        /// <summary>
        /// Gets or sets the cursor that is displayed when the mouse pointer is
        /// over the control.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Cursor" /> that represents the
        /// cursor to display when the mouse pointer is over the control.
        /// </returns>
        Cursor Cursor { get; set; }

        /// <summary> Gets the data bindings for the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.ControlBindingsCollection" />
        /// that contains the <see cref="T:System.Windows.Forms.Binding" /> objects for the
        /// control.
        /// </returns>
        ControlBindingsCollection DataBindings { get; }

        /// <summary>
        /// Gets the DPI value for the display device where the control is
        /// currently being displayed.
        /// </summary>
        /// <returns> The DPI value of the display device. </returns>
        int DeviceDpi { get; }

        /// <summary> Gets the rectangle that represents the display area of the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents the
        /// display area of the control.
        /// </returns>
        Rectangle DisplayRectangle { get; }

        /// <summary>
        /// Gets a value indicating whether the base
        /// <see cref="T:System.Windows.Forms.Control" /> class is in the process of
        /// disposing.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the base
        /// <see cref="T:System.Windows.Forms.Control" /> class is in the process of
        /// disposing; otherwise, <see langword="false" />.
        /// </returns>
        bool Disposing { get; }

        /// <summary>
        /// Gets or sets which control borders are docked to its parent control
        /// and determines how a control is resized with its parent.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DockStyle" /> values.
        /// The default is <see cref="F:System.Windows.Forms.DockStyle.None" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value assigned is not one of the
        /// <see cref="T:System.Windows.Forms.DockStyle" /> values.
        /// </exception>
        DockStyle Dock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the control can respond to
        /// user interaction.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control can respond to user
        /// interaction; otherwise, <see langword="false" />. The default is
        /// <see langword="true" />.
        /// </returns>
        bool Enabled { get; set; }

        /// <summary> Gets a value indicating whether the control has input focus. </summary>
        /// <returns>
        /// <see langword="true" /> if the control has focus; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool Focused { get; }

        /// <summary> Gets or sets the font of the text displayed by the control. </summary>
        /// <returns>
        /// The <see cref="T:System.Drawing.Font" /> to apply to the text
        /// displayed by the control. The default is the value of the
        /// <see cref="P:System.Windows.Forms.Control.DefaultFont" /> property.
        /// </returns>
        Font Font { get; set; }

        /// <summary> Gets or sets the foreground color of the control. </summary>
        /// <returns>
        /// The foreground <see cref="T:System.Drawing.Color" /> of the control.
        /// The default is the value of the
        /// <see cref="P:System.Windows.Forms.Control.DefaultForeColor" /> property.
        /// </returns>
        Color ForeColor { get; set; }

        /// <summary>
        /// Gets a value indicating whether the control contains one or more
        /// child controls.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control contains one or more child
        /// controls; otherwise, <see langword="false" />.
        /// </returns>
        bool HasChildren { get; }

        /// <summary> Gets or sets the height of the control. </summary>
        /// <returns> The height of the control in pixels. </returns>
        int Height { get; set; }

        /// <summary> Gets or sets the Input Method Editor (IME) mode of the control. </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.ImeMode" /> values. The
        /// default is <see cref="F:System.Windows.Forms.ImeMode.Inherit" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// assigned value is not one of the <see cref="T:System.Windows.Forms.ImeMode" />
        /// enumeration values.
        /// </exception>
        ImeMode ImeMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the control is visible to
        /// accessibility applications.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control is visible to accessibility
        /// applications; otherwise, <see langword="false" />.
        /// </returns>
        bool IsAccessible { get; set; }

        /// <summary> Gets a value indicating whether the control has been disposed of. </summary>
        /// <returns>
        /// <see langword="true" /> if the control has been disposed of;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool IsDisposed { get; }

        /// <summary>
        /// Gets a value indicating whether the control has a handle associated
        /// with it.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if a handle has been assigned to the control;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool IsHandleCreated { get; }

        /// <summary> Gets a value indicating whether the control is mirrored. </summary>
        /// <returns>
        /// <see langword="true" /> if the control is mirrored; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool IsMirrored { get; }

        /// <summary> Gets a cached instance of the control's layout engine. </summary>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> for the
        /// control's contents.
        /// </returns>
        LayoutEngine LayoutEngine { get; }

        /// <summary>
        /// Gets or sets the distance, in pixels, between the left edge of the
        /// control and the left edge of its container's client area.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Int32" /> representing the distance, in
        /// pixels, between the left edge of the control and the left edge of its
        /// container's client area.
        /// </returns>
        int Left { get; set; }

        /// <summary>
        /// Gets or sets the coordinates of the upper-left corner of the control
        /// relative to the upper-left corner of its container.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Drawing.Point" /> that represents the
        /// upper-left corner of the control relative to the upper-left corner of its
        /// container.
        /// </returns>
        Point Location { get; set; }

        /// <summary> Gets or sets the space between controls. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Padding" /> representing the
        /// space between controls.
        /// </returns>
        Padding Margin { get; set; }

        /// <summary>
        /// Gets or sets the size that is the upper limit that
        /// <see
        ///     cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" />
        /// can specify.
        /// </summary>
        /// <returns>
        /// An ordered pair of type <see cref="T:System.Drawing.Size" />
        /// representing the width and height of a rectangle.
        /// </returns>
        Size MaximumSize { get; set; }

        /// <summary>
        /// Gets or sets the size that is the lower limit that
        /// <see
        ///     cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" />
        /// can specify.
        /// </summary>
        /// <returns>
        /// An ordered pair of type <see cref="T:System.Drawing.Size" />
        /// representing the width and height of a rectangle.
        /// </returns>
        Size MinimumSize { get; set; }

        /// <summary> Gets or sets the name of the control. </summary>
        /// <returns> The name of the control. The default is an empty string (""). </returns>
        string Name { get; set; }

        /// <summary> Gets or sets padding within the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Padding" /> representing the
        /// control's internal spacing characteristics.
        /// </returns>
        Padding Padding { get; set; }

        /// <summary> Gets or sets the parent container of the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Control" /> that represents the
        /// parent or container control of the control.
        /// </returns>
        Control Parent { get; set; }

        /// <summary> Gets the size of a rectangular area into which the control can fit. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size" /> containing the height and
        /// width, in pixels.
        /// </returns>
        Size PreferredSize { get; }

        /// <summary> Gets the product name of the assembly containing the control. </summary>
        /// <returns> The product name of the assembly containing the control. </returns>
        string ProductName { get; }

        /// <summary> Gets the version of the assembly containing the control. </summary>
        /// <returns> The file version of the assembly containing the control. </returns>
        string ProductVersion { get; }

        /// <summary>
        /// Gets a value indicating whether the control is currently re-creating
        /// its handle.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control is currently re-creating its
        /// handle; otherwise, <see langword="false" />.
        /// </returns>
        bool RecreatingHandle { get; }

        /// <summary> Gets or sets the window region associated with the control. </summary>
        /// <returns>
        /// The window <see cref="T:System.Drawing.Region" /> associated with the
        /// control.
        /// </returns>
        Region Region { get; set; }

        /// <summary>
        /// Gets the distance, in pixels, between the right edge of the control
        /// and the left edge of its container's client area.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Int32" /> representing the distance, in
        /// pixels, between the right edge of the control and the left edge of its
        /// container's client area.
        /// </returns>
        int Right { get; }

        /// <summary>
        /// Gets or sets a value indicating whether control's elements are
        /// aligned to support locales using right-to-left fonts.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.RightToLeft" /> values.
        /// The default is <see cref="F:System.Windows.Forms.RightToLeft.Inherit" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// assigned value is not one of the
        /// <see cref="T:System.Windows.Forms.RightToLeft" /> values.
        /// </exception>
        RightToLeft RightToLeft { get; set; }

        /// <summary> Gets or sets the height and width of the control. </summary>
        /// <returns>
        /// The <see cref="T:System.Drawing.Size" /> that represents the height
        /// and width of the control in pixels.
        /// </returns>
        Size Size { get; set; }

        /// <summary> Gets or sets the tab order of the control within its container. </summary>
        /// <returns>
        /// The index value of the control within the set of controls within its
        /// container. The controls in the container are included in the tab order.
        /// </returns>
        int TabIndex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user can give the focus
        /// to this control using the TAB key.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user can give the focus to the control
        /// using the TAB key; otherwise, <see langword="false" />. The default is
        /// <see langword="true" />. This property will always return
        /// <see langword="true" /> for an instance of the
        /// <see cref="T:System.Windows.Forms.Form" /> class.
        /// </returns>
        bool TabStop { get; set; }

        /// <summary> Gets or sets the object that contains data about the control. </summary>
        /// <returns>
        /// An <see cref="T:System.Object" /> that contains data about the
        /// control. The default is <see langword="null" />.
        /// </returns>
        object Tag { get; set; }

        /// <summary> Gets or sets the text associated with this control. </summary>
        /// <returns> The text associated with this control. </returns>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the distance, in pixels, between the top edge of the
        /// control and the top edge of its container's client area.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Int32" /> representing the distance, in
        /// pixels, between the bottom edge of the control and the top edge of its
        /// container's client area.
        /// </returns>
        int Top { get; set; }

        /// <summary>
        /// Gets the parent control that is not parented by another Windows Forms
        /// control. Typically, this is the outermost
        /// <see cref="T:System.Windows.Forms.Form" /> that the control is contained in.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.Control" /> that represents the
        /// top-level control that contains the current control.
        /// </returns>
        Control TopLevelControl { get; }

        /// <summary>
        /// Gets or sets a value indicating whether to use the wait cursor for
        /// the current control and all child controls.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to use the wait cursor for the current
        /// control and all child controls; otherwise, <see langword="false" />. The
        /// default is <see langword="false" />.
        /// </returns>
        bool UseWaitCursor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the control and all its child
        /// controls are displayed.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the control and all its child controls are
        /// displayed; otherwise, <see langword="false" />. The default is
        /// <see langword="true" />.
        /// </returns>
        bool Visible { get; set; }

        /// <summary> Gets or sets the width of the control. </summary>
        /// <returns> The width of the control in pixels. </returns>
        int Width { get; set; }

        /// <summary> This property is not relevant for this class. </summary>
        /// <returns> The NativeWindow contained within the control. </returns>
        IWindowTarget WindowTarget
        {
            [SecurityPermission(
                SecurityAction.LinkDemand,
                Flags = SecurityPermissionFlag.UnmanagedCode
            )]
            get;
            [SecurityPermission(
                SecurityAction.LinkDemand,
                Flags = SecurityPermissionFlag.UnmanagedCode
            )]
            set;
        }

        /// <summary> This event is not relevant for this class. </summary>
        event EventHandler AutoSizeChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.BackColor" /> property changes.
        /// </summary>
        event EventHandler BackColorChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.BackgroundImage" /> property changes.
        /// </summary>
        event EventHandler BackgroundImageChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.Control.BackgroundImageLayout" /> property
        /// changes.
        /// </summary>
        event EventHandler BackgroundImageLayoutChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="T:System.Windows.Forms.BindingContext" /> property changes.
        /// </summary>
        event EventHandler BindingContextChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.CausesValidation" /> property
        /// changes.
        /// </summary>
        event EventHandler CausesValidationChanged;

        /// <summary> Occurs when the focus or keyboard user interface (UI) cues change. </summary>
        event UICuesEventHandler ChangeUICues;

        /// <summary> Occurs when the control is clicked. </summary>
        event EventHandler Click;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.ClientSize" /> property changes.
        /// </summary>
        event EventHandler ClientSizeChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.ContextMenu" /> property changes.
        /// </summary>
        event EventHandler ContextMenuChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.ContextMenuStrip" /> property
        /// changes.
        /// </summary>
        event EventHandler ContextMenuStripChanged;

        /// <summary>
        /// Occurs when a new control is added to the
        /// <see cref="T:System.Windows.Forms.Control.ControlCollection" />.
        /// </summary>
        event ControlEventHandler ControlAdded;

        /// <summary>
        /// Occurs when a control is removed from the
        /// <see cref="T:System.Windows.Forms.Control.ControlCollection" />.
        /// </summary>
        event ControlEventHandler ControlRemoved;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.Cursor" /> property changes.
        /// </summary>
        event EventHandler CursorChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.Dock" /> property changes.
        /// </summary>
        event EventHandler DockChanged;

        /// <summary> Occurs when the control is double-clicked. </summary>
        event EventHandler DoubleClick;

        /// <summary>
        /// Occurs when the DPI setting for a control is changed programmatically
        /// after the DPI of its parent control or form has changed.
        /// </summary>
        event EventHandler DpiChangedAfterParent;

        /// <summary>
        /// Occurs when the DPI setting for a control is changed programmatically
        /// before a DPI change event for its parent control or form has occurred.
        /// </summary>
        event EventHandler DpiChangedBeforeParent;

        /// <summary> Occurs when a drag-and-drop operation is completed. </summary>
        event DragEventHandler DragDrop;

        /// <summary> Occurs when an object is dragged into the control's bounds. </summary>
        event DragEventHandler DragEnter;

        /// <summary> Occurs when an object is dragged out of the control's bounds. </summary>
        event EventHandler DragLeave;

        /// <summary> Occurs when an object is dragged over the control's bounds. </summary>
        event DragEventHandler DragOver;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.Enabled" />
        /// property value has changed.
        /// </summary>
        event EventHandler EnabledChanged;

        /// <summary> Occurs when the control is entered. </summary>
        event EventHandler Enter;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.Font" />
        /// property value changes.
        /// </summary>
        event EventHandler FontChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.Control.ForeColor" /> property value changes.
        /// </summary>
        event EventHandler ForeColorChanged;

        /// <summary> Occurs during a drag operation. </summary>
        event GiveFeedbackEventHandler GiveFeedback;

        /// <summary> Occurs when the control receives focus. </summary>
        event EventHandler GotFocus;

        /// <summary> Occurs when a handle is created for the control. </summary>
        event EventHandler HandleCreated;

        /// <summary>
        /// Occurs when the control's handle is in the process of being
        /// destroyed.
        /// </summary>
        event EventHandler HandleDestroyed;

        /// <summary> Occurs when the user requests help for a control. </summary>
        event HelpEventHandler HelpRequested;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.ImeMode" />
        /// property has changed.
        /// </summary>
        event EventHandler ImeModeChanged;

        /// <summary> Occurs when a control's display requires redrawing. </summary>
        event InvalidateEventHandler Invalidated;

        /// <summary> Occurs when a key is pressed while the control has focus. </summary>
        event KeyEventHandler KeyDown;

        /// <summary>
        /// Occurs when a character. space or backspace key is pressed while the
        /// control has focus.
        /// </summary>
        event KeyPressEventHandler KeyPress;

        /// <summary> Occurs when a key is released while the control has focus. </summary>
        event KeyEventHandler KeyUp;

        /// <summary> Occurs when a control should reposition its child controls. </summary>
        event LayoutEventHandler Layout;

        /// <summary> Occurs when the input focus leaves the control. </summary>
        event EventHandler Leave;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.Control.Location" /> property value has
        /// changed.
        /// </summary>
        event EventHandler LocationChanged;

        /// <summary> Occurs when the control loses focus. </summary>
        event EventHandler LostFocus;

        /// <summary> Occurs when the control's margin changes. </summary>
        event EventHandler MarginChanged;

        /// <summary> Occurs when the control loses mouse capture. </summary>
        event EventHandler MouseCaptureChanged;

        /// <summary> Occurs when the control is clicked by the mouse. </summary>
        event MouseEventHandler MouseClick;

        /// <summary> Occurs when the control is double-clicked by the mouse. </summary>
        event MouseEventHandler MouseDoubleClick;

        /// <summary>
        /// Occurs when the mouse pointer is over the control and a mouse button
        /// is pressed.
        /// </summary>
        event MouseEventHandler MouseDown;

        /// <summary> Occurs when the mouse pointer enters the control. </summary>
        event EventHandler MouseEnter;

        /// <summary> Occurs when the mouse pointer rests on the control. </summary>
        event EventHandler MouseHover;

        /// <summary> Occurs when the mouse pointer leaves the control. </summary>
        event EventHandler MouseLeave;

        /// <summary> Occurs when the mouse pointer is moved over the control. </summary>
        event MouseEventHandler MouseMove;

        /// <summary>
        /// Occurs when the mouse pointer is over the control and a mouse button
        /// is released.
        /// </summary>
        event MouseEventHandler MouseUp;

        /// <summary> Occurs when the mouse wheel moves while the control has focus. </summary>
        event MouseEventHandler MouseWheel;

        /// <summary> Occurs when the control is moved. </summary>
        event EventHandler Move;

        /// <summary> Occurs when the control's padding changes. </summary>
        event EventHandler PaddingChanged;

        /// <summary> Occurs when the control is redrawn. </summary>
        event PaintEventHandler Paint;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.Parent" />
        /// property value changes.
        /// </summary>
        event EventHandler ParentChanged;

        /// <summary>
        /// Occurs before the
        /// <see cref="E:System.Windows.Forms.Control.KeyDown" /> event when a key is
        /// pressed while focus is on this control.
        /// </summary>
        event PreviewKeyDownEventHandler PreviewKeyDown;

        /// <summary>
        /// Occurs when <see cref="T:System.Windows.Forms.AccessibleObject" /> is
        /// providing help to accessibility applications.
        /// </summary>
        event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;

        /// <summary>
        /// Occurs during a drag-and-drop operation and enables the drag source
        /// to determine whether the drag-and-drop operation should be Cancelled.
        /// </summary>
        event QueryContinueDragEventHandler QueryContinueDrag;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Control.Region" /> property changes.
        /// </summary>
        event EventHandler RegionChanged;

        /// <summary> Occurs when the control is resized. </summary>
        event EventHandler Resize;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.Control.RightToLeft" /> property value
        /// changes.
        /// </summary>
        event EventHandler RightToLeftChanged;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.Size" />
        /// property value changes.
        /// </summary>
        event EventHandler SizeChanged;

        /// <summary> Occurs when the control style changes. </summary>
        event EventHandler StyleChanged;

        /// <summary> Occurs when the system colors change. </summary>
        event EventHandler SystemColorsChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:System.Windows.Forms.Control.TabIndex" /> property value changes.
        /// </summary>
        event EventHandler TabIndexChanged;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.TabStop" />
        /// property value changes.
        /// </summary>
        event EventHandler TabStopChanged;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.Text" />
        /// property value changes.
        /// </summary>
        event EventHandler TextChanged;

        /// <summary> Occurs when the control is finished validating. </summary>
        event EventHandler Validated;

        /// <summary> Occurs when the control is validating. </summary>
        event CancelEventHandler Validating;

        /// <summary>
        /// Occurs when the <see cref="P:System.Windows.Forms.Control.Visible" />
        /// property value changes.
        /// </summary>
        event EventHandler VisibleChanged;

        /// <summary>
        /// Executes the specified delegate asynchronously on the thread that the
        /// control's underlying handle was created on.
        /// </summary>
        /// <param name="method"> A delegate to a method that takes no parameters. </param>
        /// <returns>
        /// An <see cref="T:System.IAsyncResult" /> that represents the result of
        /// the <see cref="M:System.Windows.Forms.Control.BeginInvoke(System.Delegate)" />
        /// operation.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        /// No appropriate window
        /// handle can be found.
        /// </exception>
        IAsyncResult BeginInvoke(Delegate method);

        /// <summary> Brings the control to the front of the z-order. </summary>
        void BringToFront();

        /// <summary>
        /// Retrieves a value indicating whether the specified control is a child
        /// of the control.
        /// </summary>
        /// <param name="ctl">
        /// The <see cref="T:System.Windows.Forms.Control" /> to
        /// evaluate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified control is a child of the
        /// control; otherwise, <see langword="false" />.
        /// </returns>
        bool Contains(Control ctl);

        /// <summary>
        /// Forces the creation of the visible control, including the creation of
        /// the handle and any visible child controls.
        /// </summary>
        void CreateControl();

        /// <summary> Creates the <see cref="T:System.Drawing.Graphics" /> for the control. </summary>
        /// <returns> The <see cref="T:System.Drawing.Graphics" /> for the control. </returns>
        Graphics CreateGraphics();

        /// <summary> Begins a drag-and-drop operation. </summary>
        /// <param name="data"> The data to drag. </param>
        /// <param name="allowedEffects">
        /// One of the
        /// <see cref="T:System.Windows.Forms.DragDropEffects" /> values.
        /// </param>
        /// <returns>
        /// A value from the
        /// <see cref="T:System.Windows.Forms.DragDropEffects" /> enumeration that
        /// represents the final effect that was performed during the drag-and-drop
        /// operation.
        /// </returns>
        DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);

        /// <summary> Supports rendering to the specified bitmap. </summary>
        /// <param name="bitmap"> The bitmap to be drawn to. </param>
        /// <param name="targetBounds"> The bounds within which the control is rendered. </param>
        void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);

        /// <summary> Retrieves the form that the control is on. </summary>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.Form" /> that the control is
        /// on.
        /// </returns>
        Form FindForm();

        /// <summary> Sets input focus to the control. </summary>
        /// <returns>
        /// <see langword="true" /> if the input focus request was successful;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool Focus();

        /// <summary>
        /// Retrieves the child control that is located at the specified
        /// coordinates, specifying whether to ignore child controls of a certain type.
        /// </summary>
        /// <param name="pt">
        /// A <see cref="T:System.Drawing.Point" /> that contains the
        /// coordinates where you want to look for a control. Coordinates are expressed
        /// relative to the upper-left corner of the control's client area.
        /// </param>
        /// <param name="skipValue">
        /// One of the values of
        /// <see cref="T:System.Windows.Forms.GetChildAtPointSkip" /> , determining whether
        /// to ignore child controls of a certain type.
        /// </param>
        /// <returns>
        /// The child <see cref="T:System.Windows.Forms.Control" /> at the
        /// specified coordinates.
        /// </returns>
        Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);

        /// <summary>
        /// Retrieves the child control that is located at the specified
        /// coordinates.
        /// </summary>
        /// <param name="pt">
        /// A <see cref="T:System.Drawing.Point" /> that contains the
        /// coordinates where you want to look for a control. Coordinates are expressed
        /// relative to the upper-left corner of the control's client area.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Control" /> that represents the
        /// control that is located at the specified point.
        /// </returns>
        Control GetChildAtPoint(Point pt);

        /// <summary>
        /// Returns the next
        /// <see cref="T:System.Windows.Forms.ContainerControl" /> up the control's chain
        /// of parent controls.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.IContainerControl" />, that
        /// represents the parent of the <see cref="T:System.Windows.Forms.Control" />.
        /// </returns>
        IContainerControl GetContainerControl();

        /// <summary>
        /// Retrieves the next control forward or back in the tab order of child
        /// controls.
        /// </summary>
        /// <param name="ctl">
        /// The <see cref="T:System.Windows.Forms.Control" /> to start
        /// the search with.
        /// </param>
        /// <param name="forward">
        /// <see langword="true" /> to search forward in the tab
        /// order; <see langword="false" /> to search backward.
        /// </param>
        /// <returns>
        /// The next <see cref="T:System.Windows.Forms.Control" /> in the tab
        /// order.
        /// </returns>
        Control GetNextControl(Control ctl, bool forward);

        /// <summary>
        /// Retrieves the size of a rectangular area into which a control can be
        /// fitted.
        /// </summary>
        /// <param name="proposedSize"> The custom-sized area for a control. </param>
        /// <returns>
        /// An ordered pair of type <see cref="T:System.Drawing.Size" />
        /// representing the width and height of a rectangle.
        /// </returns>
        Size GetPreferredSize(Size proposedSize);

        /// <summary> Conceals the control from the user. </summary>
        void Hide();

        /// <summary>
        /// Invalidates the specified region of the control (adds it to the
        /// control's update region, which is the area that will be repainted at the next
        /// paint operation), and causes a paint message to be sent to the control.
        /// </summary>
        /// <param name="region">
        /// The <see cref="T:System.Drawing.Region" /> to
        /// invalidate.
        /// </param>
        void Invalidate(Region region);

        /// <summary>
        /// Invalidates the specified region of the control (adds it to the
        /// control's update region, which is the area that will be repainted at the next
        /// paint operation), and causes a paint message to be sent to the control.
        /// Optionally, invalidates the child controls assigned to the control.
        /// </summary>
        /// <param name="region">
        /// The <see cref="T:System.Drawing.Region" /> to
        /// invalidate.
        /// </param>
        /// <param name="invalidateChildren">
        /// <see langword="true" /> to invalidate the
        /// control's child controls; otherwise, <see langword="false" />.
        /// </param>
        void Invalidate(Region region, bool invalidateChildren);

        /// <summary>
        /// Invalidates the entire surface of the control and causes the control
        /// to be redrawn.
        /// </summary>
        void Invalidate();

        /// <summary>
        /// Invalidates a specific region of the control and causes a paint
        /// message to be sent to the control. Optionally, invalidates the child controls
        /// assigned to the control.
        /// </summary>
        /// <param name="invalidateChildren">
        /// <see langword="true" /> to invalidate the
        /// control's child controls; otherwise, <see langword="false" />.
        /// </param>
        void Invalidate(bool invalidateChildren);

        /// <summary>
        /// Invalidates the specified region of the control (adds it to the
        /// control's update region, which is the area that will be repainted at the next
        /// paint operation), and causes a paint message to be sent to the control.
        /// </summary>
        /// <param name="rc">
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents
        /// the region to invalidate.
        /// </param>
        void Invalidate(Rectangle rc);

        /// <summary>
        /// Invalidates the specified region of the control (adds it to the
        /// control's update region, which is the area that will be repainted at the next
        /// paint operation), and causes a paint message to be sent to the control.
        /// Optionally, invalidates the child controls assigned to the control.
        /// </summary>
        /// <param name="rc">
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents
        /// the region to invalidate.
        /// </param>
        /// <param name="invalidateChildren">
        /// <see langword="true" /> to invalidate the
        /// control's child controls; otherwise, <see langword="false" />.
        /// </param>
        void Invalidate(Rectangle rc, bool invalidateChildren);

        /// <summary>
        /// Executes the specified delegate on the thread that owns the control's
        /// underlying window handle.
        /// </summary>
        /// <param name="method">
        /// A delegate that contains a method to be called in the
        /// control's thread context.
        /// </param>
        /// <returns>
        /// The return value from the delegate being invoked, or
        /// <see langword="null" /> if the delegate has no return value.
        /// </returns>
        object Invoke(Delegate method);

        /// <summary> Converts a Logical DPI value to its equivalent DeviceUnit DPI value. </summary>
        /// <param name="value"> The Logical value to convert. </param>
        /// <returns> The resulting DeviceUnit value. </returns>
        int LogicalToDeviceUnits(int value);

        /// <summary>
        /// Transforms a size from logical to device units by scaling it for the
        /// current DPI and rounding down to the nearest integer value for width and
        /// height.
        /// </summary>
        /// <param name="value"> The size to be scaled. </param>
        /// <returns> The scaled size. </returns>
        Size LogicalToDeviceUnits(Size value);

        /// <summary> Forces the control to apply layout logic to all its child controls. </summary>
        void PerformLayout();

        /// <summary> Forces the control to apply layout logic to all its child controls. </summary>
        /// <param name="affectedControl">
        /// A <see cref="T:System.Windows.Forms.Control" />
        /// that represents the most recently changed control.
        /// </param>
        /// <param name="affectedProperty">
        /// The name of the most recently changed property
        /// on the control.
        /// </param>
        void PerformLayout(Control affectedControl, string affectedProperty);

        /// <summary>
        /// Computes the location of the specified screen point into client
        /// coordinates.
        /// </summary>
        /// <param name="p">
        /// The screen coordinate <see cref="T:System.Drawing.Point" /> to
        /// convert.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Point" /> that represents the converted
        /// <see cref="T:System.Drawing.Point" />, <paramref name="p" />, in client
        /// coordinates.
        /// </returns>
        Point PointToClient(Point p);

        /// <summary>
        /// Computes the location of the specified client point into screen
        /// coordinates.
        /// </summary>
        /// <param name="p">
        /// The client coordinate <see cref="T:System.Drawing.Point" /> to
        /// convert.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Point" /> that represents the converted
        /// <see cref="T:System.Drawing.Point" />, <paramref name="p" />, in screen
        /// coordinates.
        /// </returns>
        Point PointToScreen(Point p);

        /// <summary>
        /// Preprocesses keyboard or input messages within the message loop
        /// before they are dispatched.
        /// </summary>
        /// <param name="msg">
        /// A <see cref="T:System.Windows.Forms.Message" /> that
        /// represents the message to process.
        /// </param>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.PreProcessControlState" /> values,
        /// depending on whether
        /// <see
        ///     cref="M:System.Windows.Forms.Control.PreProcessMessage(System.Windows.Forms.Message@)" />
        /// is <see langword="true" /> or <see langword="false" /> and whether
        /// <see
        ///     cref="M:System.Windows.Forms.Control.IsInputKey(System.Windows.Forms.Keys)" />
        /// or <see cref="M:System.Windows.Forms.Control.IsInputChar(System.Char)" /> are
        /// <see langword="true" /> or <see langword="false" />.
        /// </returns>
        PreProcessControlState PreProcessControlMessage(ref Message msg);

        /// <summary>
        /// Preprocesses keyboard or input messages within the message loop
        /// before they are dispatched.
        /// </summary>
        /// <param name="msg">
        /// A <see cref="T:System.Windows.Forms.Message" />, passed by
        /// reference, that represents the message to process. The possible values are
        /// WM_KEYDOWN, WM_SYSKEYDOWN, WM_CHAR, and WM_SYSCHAR.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the message was processed by the control;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool PreProcessMessage(ref Message msg);

        /// <summary>
        /// Computes the size and location of the specified screen rectangle in
        /// client coordinates.
        /// </summary>
        /// <param name="r">
        /// The screen coordinate
        /// <see cref="T:System.Drawing.Rectangle" /> to convert.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents the
        /// converted <see cref="T:System.Drawing.Rectangle" />, <paramref name="r" /> , in
        /// client coordinates.
        /// </returns>
        Rectangle RectangleToClient(Rectangle r);

        /// <summary>
        /// Computes the size and location of the specified client rectangle in
        /// screen coordinates.
        /// </summary>
        /// <param name="r">
        /// The client coordinate
        /// <see cref="T:System.Drawing.Rectangle" /> to convert.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents the
        /// converted <see cref="T:System.Drawing.Rectangle" />, <paramref name="r" /> , in
        /// screen coordinates.
        /// </returns>
        Rectangle RectangleToScreen(Rectangle r);

        /// <summary>
        /// Forces the control to invalidate its client area and immediately
        /// redraw itself and any child controls.
        /// </summary>
        void Refresh();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.BackColor" />
        /// property to its default value.
        /// </summary>
        void ResetBackColor();

        /// <summary>
        /// Causes a control bound to the
        /// <see cref="T:System.Windows.Forms.BindingSource" /> to reread all the items in
        /// the list and refresh their displayed values.
        /// </summary>
        void ResetBindings();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.Cursor" />
        /// property to its default value.
        /// </summary>
        void ResetCursor();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.Font" />
        /// property to its default value.
        /// </summary>
        void ResetFont();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.ForeColor" />
        /// property to its default value.
        /// </summary>
        void ResetForeColor();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.ImeMode" />
        /// property to its default value.
        /// </summary>
        void ResetImeMode();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.RightToLeft" />
        /// property to its default value.
        /// </summary>
        void ResetRightToLeft();

        /// <summary>
        /// Resets the <see cref="P:System.Windows.Forms.Control.Text" />
        /// property to its default value ( <see cref="F:System.String.Empty" />).
        /// </summary>
        void ResetText();

        /// <summary> Resumes usual layout logic. </summary>
        void ResumeLayout();

        /// <summary>
        /// Resumes usual layout logic, optionally forcing an immediate layout of
        /// pending layout requests.
        /// </summary>
        /// <param name="performLayout">
        /// <see langword="true" /> to execute pending layout
        /// requests; otherwise, <see langword="false" />.
        /// </param>
        void ResumeLayout(bool performLayout);

        /// <summary> Scales the control and any child controls. </summary>
        /// <param name="ratio"> The ratio to use for scaling. </param>
        void Scale(float ratio);

        /// <summary> Scales the entire control and any child controls. </summary>
        /// <param name="dx"> The horizontal scaling factor. </param>
        /// <param name="dy"> The vertical scaling factor. </param>
        void Scale(float dx, float dy);

        /// <summary>
        /// Scales the control and all child controls by the specified scaling
        /// factor.
        /// </summary>
        /// <param name="factor">
        /// A <see cref="T:System.Drawing.SizeF" /> containing the
        /// horizontal and vertical scaling factors.
        /// </param>
        void Scale(SizeF factor);

        /// <summary>
        /// Scales a logical bitmap value to it's equivalent device unit value
        /// when a DPI change occurs.
        /// </summary>
        /// <param name="logicalBitmap"> The bitmap to scale. </param>
        void ScaleBitmapLogicalToDevice(ref Bitmap logicalBitmap);

        /// <summary> Activates the control. </summary>
        void Select();

        /// <summary> Activates the next control. </summary>
        /// <param name="ctl">
        /// The <see cref="T:System.Windows.Forms.Control" /> at which
        /// to start the search.
        /// </param>
        /// <param name="forward">
        /// <see langword="true" /> to move forward in the tab
        /// order; <see langword="false" /> to move backward in the tab order.
        /// </param>
        /// <param name="tabStopOnly">
        /// <see langword="true" /> to ignore the controls with
        /// the <see cref="P:System.Windows.Forms.Control.TabStop" /> property set to
        /// <see langword="false" /> ; otherwise, <see langword="false" />.
        /// </param>
        /// <param name="nested">
        /// <see langword="true" /> to include nested (children of
        /// child controls) child controls; otherwise, <see langword="false" />.
        /// </param>
        /// <param name="wrap">
        /// <see langword="true" /> to continue searching from the
        /// first control in the tab order after the last control has been reached;
        /// otherwise, <see langword="false" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a control was activated; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool SelectNextControl(
            Control ctl,
            bool forward,
            bool tabStopOnly,
            bool nested,
            bool wrap
        );

        /// <summary> Sends the control to the back of the z-order. </summary>
        void SendToBack();

        /// <summary> Sets the bounds of the control to the specified location and size. </summary>
        /// <param name="x">
        /// The new <see cref="P:System.Windows.Forms.Control.Left" />
        /// property value of the control.
        /// </param>
        /// <param name="y">
        /// The new <see cref="P:System.Windows.Forms.Control.Top" />
        /// property value of the control.
        /// </param>
        /// <param name="width">
        /// The new
        /// <see cref="P:System.Windows.Forms.Control.Width" /> property value of the
        /// control.
        /// </param>
        /// <param name="height">
        /// The new
        /// <see cref="P:System.Windows.Forms.Control.Height" /> property value of the
        /// control.
        /// </param>
        void SetBounds(int x, int y, int width, int height);

        /// <summary>
        /// Sets the specified bounds of the control to the specified location
        /// and size.
        /// </summary>
        /// <param name="x">
        /// The new <see cref="P:System.Windows.Forms.Control.Left" />
        /// property value of the control.
        /// </param>
        /// <param name="y">
        /// The new <see cref="P:System.Windows.Forms.Control.Top" />
        /// property value of the control.
        /// </param>
        /// <param name="width">
        /// The new
        /// <see cref="P:System.Windows.Forms.Control.Width" /> property value of the
        /// control.
        /// </param>
        /// <param name="height">
        /// The new
        /// <see cref="P:System.Windows.Forms.Control.Height" /> property value of the
        /// control.
        /// </param>
        /// <param name="specified">
        /// A bitwise combination of the
        /// <see cref="T:System.Windows.Forms.BoundsSpecified" /> values. For any parameter
        /// not specified, the current value will be used.
        /// </param>
        void SetBounds(
            int x,
            int y,
            int width,
            int height,
            BoundsSpecified specified
        );

        /// <summary> Displays the control to the user. </summary>
        void Show();

        /// <summary> Temporarily suspends the layout logic for the control. </summary>
        void SuspendLayout();

        /// <summary>
        /// Causes the control to redraw the invalidated regions within its
        /// client area.
        /// </summary>
        void Update();
    }
}