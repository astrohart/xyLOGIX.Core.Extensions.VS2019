using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// implements a Windows Form.
    /// </summary>
    /// <remarks>
    /// This interface is allows any object to serve as a proxy for a Windows
    /// Form. This interface is here so that any form, in principle, that
    /// implements the methods and properties below can be extended by the <see
    /// cref="T:xyLOGIX.Core.Extensions.FormExtensions"/> class without
    /// necessarily having to be a Windows Form per se. NOTE: The methods and
    /// properties of this interface are not documented here. Please see the
    /// <see cref="T:System.Windows.Forms.Form"/> class' XML doc comments for
    /// the documentation.
    /// </remarks>
    public interface IForm : IWin32Window
    {
#pragma warning disable 1591

        event EventHandler Activated;

        event EventHandler AutoSizeChanged;

        event EventHandler AutoValidateChanged;

        event EventHandler BackColorChanged;

        event EventHandler BackgroundImageChanged;

        event EventHandler BackgroundImageLayoutChanged;

        event EventHandler BindingContextChanged;

        event EventHandler CausesValidationChanged;

        event UICuesEventHandler ChangeUICues;

        event EventHandler Click;

        event EventHandler ClientSizeChanged;

        event EventHandler Closed;

        event CancelEventHandler Closing;

        event EventHandler ContextMenuChanged;

        event EventHandler ContextMenuStripChanged;

        event ControlEventHandler ControlAdded;

        event ControlEventHandler ControlRemoved;

        event EventHandler CursorChanged;

        event EventHandler Deactivate;

        event EventHandler Disposed;

        event EventHandler DockChanged;

        event EventHandler DoubleClick;

        event DpiChangedEventHandler DpiChanged;

        event EventHandler DpiChangedAfterParent;

        event EventHandler DpiChangedBeforeParent;

        event DragEventHandler DragDrop;

        event DragEventHandler DragEnter;

        event EventHandler DragLeave;

        event DragEventHandler DragOver;

        event EventHandler EnabledChanged;

        event EventHandler Enter;

        event EventHandler FontChanged;

        event EventHandler ForeColorChanged;

        event FormClosedEventHandler FormClosed;

        event FormClosingEventHandler FormClosing;

        event GiveFeedbackEventHandler GiveFeedback;

        event EventHandler GotFocus;

        event EventHandler HandleCreated;

        event EventHandler HandleDestroyed;

        event CancelEventHandler HelpButtonClicked;

        event HelpEventHandler HelpRequested;

        event EventHandler ImeModeChanged;

        event InputLanguageChangedEventHandler InputLanguageChanged;

        event InputLanguageChangingEventHandler InputLanguageChanging;

        event InvalidateEventHandler Invalidated;

        event KeyEventHandler KeyDown;

        event KeyPressEventHandler KeyPress;

        event KeyEventHandler KeyUp;

        event LayoutEventHandler Layout;

        event EventHandler Leave;

        event EventHandler Load;

        event EventHandler LocationChanged;

        event EventHandler LostFocus;

        event EventHandler MarginChanged;

        event EventHandler MaximizedBoundsChanged;

        event EventHandler MaximumSizeChanged;

        event EventHandler MdiChildActivate;

        event EventHandler MenuComplete;

        event EventHandler MenuStart;

        event EventHandler MinimumSizeChanged;

        event EventHandler MouseCaptureChanged;

        event MouseEventHandler MouseClick;

        event MouseEventHandler MouseDoubleClick;

        event MouseEventHandler MouseDown;

        event EventHandler MouseEnter;

        event EventHandler MouseHover;

        event EventHandler MouseLeave;

        event MouseEventHandler MouseMove;

        event MouseEventHandler MouseUp;

        event MouseEventHandler MouseWheel;

        event EventHandler Move;

        event EventHandler PaddingChanged;

        event PaintEventHandler Paint;

        event EventHandler ParentChanged;

        event PreviewKeyDownEventHandler PreviewKeyDown;

        event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;

        event QueryContinueDragEventHandler QueryContinueDrag;

        event EventHandler RegionChanged;

        event EventHandler Resize;

        event EventHandler ResizeBegin;

        event EventHandler ResizeEnd;

        event EventHandler RightToLeftChanged;

        event EventHandler RightToLeftLayoutChanged;

        event ScrollEventHandler Scroll;

        event EventHandler Shown;

        event EventHandler SizeChanged;

        event EventHandler StyleChanged;

        event EventHandler SystemColorsChanged;

        event EventHandler TabIndexChanged;

        event EventHandler TabStopChanged;

        event EventHandler TextChanged;

        event EventHandler Validated;

        event CancelEventHandler Validating;

        event EventHandler VisibleChanged;

        IButtonControl AcceptButton { get; set; }
        AccessibleObject AccessibilityObject { get; }
        string AccessibleDefaultActionDescription { get; set; }
        string AccessibleDescription { get; set; }
        string AccessibleName { get; set; }
        AccessibleRole AccessibleRole { get; set; }
        Control ActiveControl { get; set; }
        Form ActiveMdiChild { get; }
        bool AllowDrop { get; set; }
        bool AllowTransparency { get; set; }
        AnchorStyles Anchor { get; set; }
        bool AutoScale { get; set; }
        Size AutoScaleBaseSize { get; set; }
        SizeF AutoScaleDimensions { get; set; }
        AutoScaleMode AutoScaleMode { get; set; }
        bool AutoScroll { get; set; }
        Size AutoScrollMargin { get; set; }
        Size AutoScrollMinSize { get; set; }
        Point AutoScrollOffset { get; set; }
        Point AutoScrollPosition { get; set; }
        bool AutoSize { get; set; }
        AutoSizeMode AutoSizeMode { get; set; }
        AutoValidate AutoValidate { get; set; }
        Color BackColor { get; set; }
        Image BackgroundImage { get; set; }
        ImageLayout BackgroundImageLayout { get; set; }
        BindingContext BindingContext { get; set; }
        int Bottom { get; }
        Rectangle Bounds { get; set; }
        IButtonControl CancelButton { get; set; }
        bool CanFocus { get; }
        bool CanSelect { get; }
        bool Capture { get; set; }
        bool CausesValidation { get; set; }
        Rectangle ClientRectangle { get; }
        Size ClientSize { get; set; }
        string CompanyName { get; }
        IContainer Container { get; }
        bool ContainsFocus { get; }
        ContextMenu ContextMenu { get; set; }
        ContextMenuStrip ContextMenuStrip { get; set; }
        bool ControlBox { get; set; }
        Control.ControlCollection Controls { get; }
        bool Created { get; }
        SizeF CurrentAutoScaleDimensions { get; }
        Cursor Cursor { get; set; }
        ControlBindingsCollection DataBindings { get; }
        Rectangle DesktopBounds { get; set; }
        Point DesktopLocation { get; set; }
        int DeviceDpi { get; }
        DialogResult DialogResult { get; set; }
        Rectangle DisplayRectangle { get; }
        bool Disposing { get; }
        DockStyle Dock { get; set; }
        ScrollableControl.DockPaddingEdges DockPadding { get; }
        bool Enabled { get; set; }
        bool Focused { get; }
        Font Font { get; set; }
        Color ForeColor { get; set; }
        FormBorderStyle FormBorderStyle { get; set; }
        bool HasChildren { get; }
        int Height { get; set; }
        bool HelpButton { get; set; }
        HScrollProperties HorizontalScroll { get; }
        Icon Icon { get; set; }
        ImeMode ImeMode { get; set; }
        bool InvokeRequired { get; }
        bool IsAccessible { get; set; }
        bool IsDisposed { get; }
        bool IsHandleCreated { get; }
        bool IsMdiChild { get; }
        bool IsMdiContainer { get; set; }
        bool IsMirrored { get; }
        bool IsRestrictedWindow { get; }
        bool KeyPreview { get; set; }
        LayoutEngine LayoutEngine { get; }
        int Left { get; set; }
        Point Location { get; set; }
        MenuStrip MainMenuStrip { get; set; }
        Padding Margin { get; set; }
        bool MaximizeBox { get; set; }
        Size MaximumSize { get; set; }
        Form[] MdiChildren { get; }
        Form MdiParent { get; set; }
        MainMenu Menu { get; set; }
        MainMenu MergedMenu { get; }
        bool MinimizeBox { get; set; }
        Size MinimumSize { get; set; }
        bool Modal { get; }
        string Name { get; set; }
        double Opacity { get; set; }
        Form[] OwnedForms { get; }
        Form Owner { get; set; }
        Padding Padding { get; set; }
        Control Parent { get; set; }
        Form ParentForm { get; }
        Size PreferredSize { get; }
        string ProductName { get; }
        string ProductVersion { get; }

        /// <summary>
        /// Gets a reference to the progress bar control.
        /// </summary>
        ProgressBar ProgressBar { [DebuggerStepThrough] get; }

        bool RecreatingHandle { get; }
        Region Region { get; set; }
        Rectangle RestoreBounds { get; }
        int Right { get; }
        RightToLeft RightToLeft { get; set; }
        bool RightToLeftLayout { get; set; }
        bool ShowIcon { get; set; }
        bool ShowInTaskbar { get; set; }
        ISite Site { get; set; }
        Size Size { get; set; }
        SizeGripStyle SizeGripStyle { get; set; }
        FormStartPosition StartPosition { get; set; }

        int TabIndex { get; set; }
        bool TabStop { get; set; }
        object Tag { get; set; }
        string Text { get; set; }
        int Top { get; set; }
        bool TopLevel { get; set; }
        Control TopLevelControl { get; }
        bool TopMost { get; set; }
        Color TransparencyKey { get; set; }
        bool UseWaitCursor { get; set; }
        VScrollProperties VerticalScroll { get; }
        bool Visible { get; set; }
        int Width { get; set; }
        FormWindowState WindowState { get; set; }
        IWindowTarget WindowTarget { get; set; }

        void Activate();

        void AddOwnedForm(Form ownedForm);

        IAsyncResult BeginInvoke(Delegate method);

        IAsyncResult BeginInvoke(Delegate method, params object[] args);

        void BringToFront();

        void Close();

        bool Contains(Control ctl);

        void CreateControl();

        Graphics CreateGraphics();

        ObjRef CreateObjRef(Type requestedType);

        void Dispose();

        DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);

        void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);

        object EndInvoke(IAsyncResult asyncResult);

        Form FindForm();

        bool Focus();

        Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);

        Control GetChildAtPoint(Point pt);

        IContainerControl GetContainerControl();

        object GetLifetimeService();

        Control GetNextControl(Control ctl, bool forward);

        Size GetPreferredSize(Size proposedSize);

        void Hide();

        object InitializeLifetimeService();

        void Invalidate(Region region);

        void Invalidate(Region region, bool invalidateChildren);

        void Invalidate();

        void Invalidate(bool invalidateChildren);

        void Invalidate(Rectangle rc);

        void Invalidate(Rectangle rc, bool invalidateChildren);

        object Invoke(Delegate method);

        object Invoke(Delegate method, params object[] args);

        void LayoutMdi(MdiLayout value);

        int LogicalToDeviceUnits(int value);

        Size LogicalToDeviceUnits(Size value);

        void PerformAutoScale();

        void PerformLayout();

        void PerformLayout(Control affectedControl, string affectedProperty);

        Point PointToClient(Point p);

        Point PointToScreen(Point p);

        PreProcessControlState PreProcessControlMessage(ref Message msg);

        bool PreProcessMessage(ref Message msg);

        Rectangle RectangleToClient(Rectangle r);

        Rectangle RectangleToScreen(Rectangle r);

        void Refresh();

        void RemoveOwnedForm(Form ownedForm);

        void ResetBackColor();

        void ResetBindings();

        void ResetCursor();

        void ResetFont();

        void ResetForeColor();

        void ResetImeMode();

        void ResetRightToLeft();

        void ResetText();

        void ResumeLayout();

        void ResumeLayout(bool performLayout);

        void Scale(float ratio);

        void Scale(float dx, float dy);

        void Scale(SizeF factor);

        void ScaleBitmapLogicalToDevice(ref Bitmap logicalBitmap);

        void ScrollControlIntoView(Control activeControl);

        void Select();

        bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly,
           bool nested, bool wrap);

        void SendToBack();

        void SetAutoScrollMargin(int x, int y);

        void SetBounds(int x, int y, int width, int height);

        void SetBounds(int x, int y, int width, int height,
           BoundsSpecified specified);

        void SetDesktopBounds(int x, int y, int width, int height);

        void SetDesktopLocation(int x, int y);

        void Show(IWin32Window owner);

        void Show();

        DialogResult ShowDialog();

        DialogResult ShowDialog(IWin32Window owner);

        void SuspendLayout();

        string ToString();

        void Update();

        bool Validate();

        bool Validate(bool checkAutoValidate);

        bool ValidateChildren();

        bool ValidateChildren(ValidationConstraints validationConstraints);

#pragma warning restore 1591
    }
}