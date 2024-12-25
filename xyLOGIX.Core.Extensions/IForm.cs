using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Defines the publicly-exposed methods and properties of a form. </summary>
    public interface IForm : IContainerControl, IScrollableControl, IWin32Window
    {
        /// <summary>
        /// Gets or sets the button on the form that is clicked when the user
        /// presses the ENTER key.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Windows.Forms.IButtonControl" /> that
        /// represents the button to use as the accept button for the form.
        /// </returns>
        IButtonControl AcceptButton
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets the currently active multiple-document interface (MDI) child
        /// window.
        /// </summary>
        /// <returns>
        /// Returns a <see cref="T:System.Windows.Forms.Form" /> that represents
        /// the currently active MDI child window, or <see langword="null" /> if there are
        /// currently no child windows present.
        /// </returns>
        Form ActiveMdiChild { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether the opacity of the form can
        /// be adjusted.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the opacity of the form can be changed;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool AllowTransparency
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the form adjusts its size to
        /// fit the height of the font used on the form and scales its controls.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form will automatically scale itself
        /// and its controls based on the current font assigned to the form; otherwise,
        /// <see langword="false" />. The default is <see langword="true" />.
        /// </returns>
        bool AutoScale { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets or sets the base size used for autoscaling of the form. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size" /> that represents the base size
        /// that this form uses for autoscaling.
        /// </returns>
        Size AutoScaleBaseSize
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the mode by which the form automatically resizes itself. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.AutoSizeMode" /> enumerated
        /// value. The default is
        /// <see cref="F:System.Windows.Forms.AutoSizeMode.GrowOnly" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value is not a valid <see cref="T:System.Windows.Forms.AutoSizeMode" /> value.
        /// </exception>
        AutoSizeMode AutoSizeMode
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether controls in this
        /// container will be automatically validated when the focus changes.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.AutoValidate" /> enumerated
        /// value that indicates whether contained controls are implicitly validated on
        /// focus change. The default is Inherit.
        /// </returns>
        AutoValidate AutoValidate
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the background color for the control. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Color" /> that represents the
        /// background color of the control. The default is the value of the
        /// <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.
        /// </returns>
        /// <summary>
        /// Gets or sets the button control that is clicked when the user presses
        /// the ESC key.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Windows.Forms.IButtonControl" /> that
        /// represents the cancel button for the form.
        /// </returns>
        IButtonControl CancelButton
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a control box is displayed in
        /// the caption bar of the form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form displays a control box in the
        /// upper-right corner of the form; otherwise, <see langword="false" />. The
        /// default is <see langword="true" />.
        /// </returns>
        bool ControlBox
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the size and location of the form on the Windows
        /// desktop.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> that represents the
        /// bounds of the form on the Windows desktop using desktop coordinates.
        /// </returns>
        Rectangle DesktopBounds
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the location of the form on the Windows desktop. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Point" /> that represents the location
        /// of the form on the desktop.
        /// </returns>
        Point DesktopLocation
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the dialog result for the form. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.DialogResult" /> that represents
        /// the result of the form when used as a dialog box.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value specified is outside the range of valid values.
        /// </exception>
        DialogResult DialogResult
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the border style of the form. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.FormBorderStyle" /> that
        /// represents the style of border to display for the form. The default is
        /// <see langword="FormBorderStyle.Sizable" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value specified is outside the range of valid values.
        /// </exception>
        FormBorderStyle FormBorderStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a Help button should be
        /// displayed in the caption box of the form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to display a Help button in the form's
        /// caption bar; otherwise, <see langword="false" />. The default is
        /// <see langword="false" />.
        /// </returns>
        bool HelpButton
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the icon for the form. </summary>
        /// <returns>
        /// An <see cref="T:System.Drawing.Icon" /> that represents the icon for
        /// the form.
        /// </returns>
        Icon Icon { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets a value indicating whether the form is a multiple-document
        /// interface (MDI) child form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form is an MDI child form; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool IsMdiChild { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether the form is a container for
        /// multiple-document interface (MDI) child forms.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form is a container for MDI child
        /// forms; otherwise, <see langword="false" />. The default is
        /// <see langword="false" />.
        /// </returns>
        bool IsMdiContainer
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a value indicating whether the form can use all windows and user
        /// input events without restriction.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form has restrictions; otherwise,
        /// <see langword="false" /> . The default is <see langword="true" />.
        /// </returns>
        bool IsRestrictedWindow { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether the form will receive key
        /// events before the event is passed to the control that has focus.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form will receive all key events;
        /// <see langword="false" /> if the currently selected control on the form receives
        /// key events. The default is <see langword="false" />.
        /// </returns>
        bool KeyPreview
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the primary menu container for the form. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.MenuStrip" /> that represents the
        /// container for the menu structure of the form. The default is
        /// <see langword="null" />.
        /// </returns>
        MenuStrip MainMenuStrip
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Maximize button is
        /// displayed in the caption bar of the form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to display a Maximize button for the form;
        /// otherwise, <see langword="false" />. The default is <see langword="true" />.
        /// </returns>
        bool MaximizeBox
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets the maximum size the form can be resized to. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size" /> that represents the maximum
        /// size for the form.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The values of the
        /// height or width within the <see cref="T:System.Drawing.Size" /> object are less
        /// than zero.
        /// </exception>
        /// <summary>
        /// Gets an array of forms that represent the multiple-document interface
        /// (MDI) child forms that are parented to this form.
        /// </summary>
        /// <returns>
        /// An array of <see cref="T:System.Windows.Forms.Form" /> objects, each
        /// of which identifies one of this form's MDI child forms.
        /// </returns>
        Form[] MdiChildren { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets the current multiple-document interface (MDI) parent
        /// form of this form.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Form" /> that represents the MDI
        /// parent form.
        /// </returns>
        /// <exception cref="T:System.Exception">
        /// The
        /// <see cref="T:System.Windows.Forms.Form" /> assigned to this property is not
        /// marked as an MDI container. -or- The <see cref="T:System.Windows.Forms.Form" />
        /// assigned to this property is both a child and an MDI container form. -or- The
        /// <see cref="T:System.Windows.Forms.Form" /> assigned to this property is located
        /// on a different thread.
        /// </exception>
        Form MdiParent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Windows.Forms.MainMenu" /> that
        /// is displayed in the form.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.MainMenu" /> that represents the
        /// menu to display in the form.
        /// </returns>
        MainMenu Menu { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets the merged menu for the form. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.MainMenu" /> that represents the
        /// merged menu of the form.
        /// </returns>
        MainMenu MergedMenu
        {
            [UIPermission(
                SecurityAction.Demand, Window = UIPermissionWindow.AllWindows
            )]
            get;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Minimize button is
        /// displayed in the caption bar of the form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to display a Minimize button for the form;
        /// otherwise, <see langword="false" />. The default is <see langword="true" />.
        /// </returns>
        bool MinimizeBox
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets a value indicating whether this form is displayed modally. </summary>
        /// <returns>
        /// <see langword="true" /> if the form is displayed modally; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool Modal { [DebuggerStepThrough] get; }

        /// <summary> Gets or sets the opacity level of the form. </summary>
        /// <returns> The level of opacity for the form. The default is 1.00. </returns>
        double Opacity { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets an array of <see cref="T:System.Windows.Forms.Form" /> objects
        /// that represent all forms that are owned by this form.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Form" /> array that represents
        /// the owned forms for this form.
        /// </returns>
        Form[] OwnedForms { [DebuggerStepThrough] get; }

        /// <summary> Gets or sets the form that owns this form. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.Form" /> that represents the form
        /// that is the owner of this form.
        /// </returns>
        /// <exception cref="T:System.Exception"> A top-level window cannot have an owner. </exception>
        Form Owner { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary> Gets the location and size of the form in its normal window state. </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Rectangle" /> that contains the
        /// location and size of the form in the normal window state.
        /// </returns>
        Rectangle RestoreBounds { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether right-to-left mirror
        /// placement is turned on.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if right-to-left mirror placement is turned
        /// on; otherwise, <see langword="false" /> for standard child control placement.
        /// The default is <see langword="false" />.
        /// </returns>
        bool RightToLeftLayout
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether an icon is displayed in the
        /// caption bar of the form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the form displays an icon in the caption
        /// bar; otherwise, <see langword="false" />. The default is
        /// <see langword="true" />.
        /// </returns>
        bool ShowIcon { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form is displayed in the
        /// Windows taskbar.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to display the form in the Windows taskbar at
        /// run time; otherwise, <see langword="false" />. The default is
        /// <see langword="true" />.
        /// </returns>
        bool ShowInTaskbar
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the style of the size grip to display in the lower-right
        /// corner of the form.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.SizeGripStyle" /> that represents
        /// the style of the size grip to display. The default is
        /// <see cref="F:System.Windows.Forms.SizeGripStyle.Auto" />
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value specified is outside the range of valid values.
        /// </exception>
        SizeGripStyle SizeGripStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Gets or sets the starting position of the form at run time. </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.FormStartPosition" /> that
        /// represents the starting position of the form.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value specified is outside the range of valid values.
        /// </exception>
        FormStartPosition StartPosition
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to display the form as a
        /// top-level window.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to display the form as a top-level window;
        /// otherwise, <see langword="false" />. The default is <see langword="true" />.
        /// </returns>
        /// <exception cref="T:System.Exception">
        /// A Multiple-document interface (MDI)
        /// parent form must be a top-level window.
        /// </exception>
        bool TopLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form should be displayed
        /// as a topmost form.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> to display the form as a topmost form;
        /// otherwise, <see langword="false" />. The default is <see langword="false" />.
        /// </returns>
        bool TopMost { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the color that will represent transparent areas of the
        /// form.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Color" /> that represents the color to
        /// display transparently on the form.
        /// </returns>
        Color TransparencyKey
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether form is minimized,
        /// maximized, or normal.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.FormWindowState" /> that
        /// represents whether form is minimized, maximized, or normal. The default is
        /// <see langword="FormWindowState.Normal" />.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// The
        /// value specified is outside the range of valid values.
        /// </exception>
        FormWindowState WindowState
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary> Occurs when the form is activated in code or by the user. </summary>
        event EventHandler Activated;

        /// <summary> Occurs when the form is closed. </summary>
        event EventHandler Closed;

        /// <summary> Occurs when the form is closing. </summary>
        event CancelEventHandler Closing;

        /// <summary> Occurs when the form loses focus and is no longer the active form. </summary>
        event EventHandler Deactivate;

        /// <summary>
        /// Occurs when the DPI setting changes on the display device where the
        /// form is currently displayed.
        /// </summary>
        event DpiChangedEventHandler DpiChanged;

        /// <summary> Occurs after the form is closed. </summary>
        event FormClosedEventHandler FormClosed;

        /// <summary> Occurs before the form is closed. </summary>
        event FormClosingEventHandler FormClosing;

        /// <summary> Occurs when the Help button is clicked. </summary>
        event CancelEventHandler HelpButtonClicked;

        /// <summary> Occurs after the input language of the form has changed. </summary>
        event InputLanguageChangedEventHandler InputLanguageChanged;

        /// <summary>
        /// Occurs when the user attempts to change the input language for the
        /// form.
        /// </summary>
        event InputLanguageChangingEventHandler InputLanguageChanging;

        /// <summary> Occurs before a form is displayed for the first time. </summary>
        event EventHandler Load;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Form.MaximizedBounds" /> property has
        /// changed.
        /// </summary>
        event EventHandler MaximizedBoundsChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Form.MaximumSize" /> property has changed.
        /// </summary>
        event EventHandler MaximumSizeChanged;

        /// <summary>
        /// Occurs when a multiple-document interface (MDI) child form is
        /// activated or closed within an MDI application.
        /// </summary>
        event EventHandler MdiChildActivate;

        /// <summary> Occurs when the menu of a form loses focus. </summary>
        event EventHandler MenuComplete;

        /// <summary> Occurs when the menu of a form receives focus. </summary>
        event EventHandler MenuStart;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:System.Windows.Forms.Form.MinimumSize" /> property has changed.
        /// </summary>
        event EventHandler MinimumSizeChanged;

        /// <summary> Occurs when a form enters resizing mode. </summary>
        event EventHandler ResizeBegin;

        /// <summary> Occurs when a form exits resizing mode. </summary>
        event EventHandler ResizeEnd;

        /// <summary>
        /// Occurs after the value of the
        /// <see cref="P:System.Windows.Forms.Form.RightToLeftLayout" /> property changes.
        /// </summary>
        event EventHandler RightToLeftLayoutChanged;

        /// <summary> Occurs whenever the form is first displayed. </summary>
        event EventHandler Shown;

        /// <summary> Activates the form and gives it focus. </summary>
        void Activate();

        /// <summary> Adds an owned form to this form. </summary>
        /// <param name="ownedForm">
        /// The <see cref="T:System.Windows.Forms.Form" /> that
        /// this form will own.
        /// </param>
        void AddOwnedForm(Form ownedForm);

        /// <summary> Closes the form. </summary>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form was closed while
        /// a handle was being created.
        /// </exception>
        /// <exception cref="T:System.ObjectDisposedException">
        /// You cannot call this method
        /// from the <see cref="E:System.Windows.Forms.Form.Activated" /> event when
        /// <see cref="P:System.Windows.Forms.Form.WindowState" /> is set to
        /// <see cref="F:System.Windows.Forms.FormWindowState.Maximized" />.
        /// </exception>
        void Close();

        /// <summary>
        /// Arranges the multiple-document interface (MDI) child forms within the
        /// MDI parent form.
        /// </summary>
        /// <param name="value">
        /// One of the <see cref="T:System.Windows.Forms.MdiLayout" />
        /// values that defines the layout of MDI child forms.
        /// </param>
        void LayoutMdi(MdiLayout value);

        /// <summary> Removes an owned form from this form. </summary>
        /// <param name="ownedForm">
        /// A <see cref="T:System.Windows.Forms.Form" />
        /// representing the form to remove from the list of owned forms for this form.
        /// </param>
        void RemoveOwnedForm(Form ownedForm);

        /// <summary> Sets the bounds of the form in desktop coordinates. </summary>
        /// <param name="x"> The x-coordinate of the form's location. </param>
        /// <param name="y"> The y-coordinate of the form's location. </param>
        /// <param name="width"> The width of the form. </param>
        /// <param name="height"> The height of the form. </param>
        void SetDesktopBounds(int x, int y, int width, int height);

        /// <summary> Sets the location of the form in desktop coordinates. </summary>
        /// <param name="x"> The x-coordinate of the form's location. </param>
        /// <param name="y"> The y-coordinate of the form's location. </param>
        void SetDesktopLocation(int x, int y);

        /// <summary> Shows the form with the specified owner to the user. </summary>
        /// <param name="owner">
        /// Any object that implements
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> and represents the top-level
        /// window that will own this form.
        /// </param>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is
        /// already visible. -or- The form specified in the <paramref name="owner" />
        /// parameter is the same as the form being shown. -or- The form being shown is
        /// disabled. -or- The form being shown is not a top-level window. -or- The form
        /// being shown as a dialog box is already a modal form. -or- The current process
        /// is not running in user interactive mode (for more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        void Show(IWin32Window owner);

        /// <summary> Shows the form as a modal dialog box. </summary>
        /// <returns> One of the <see cref="T:System.Windows.Forms.DialogResult" /> values. </returns>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is
        /// already visible. -or- The form being shown is disabled. -or- The form being
        /// shown is not a top-level window. -or- The form being shown as a dialog box is
        /// already a modal form. -or- The current process is not running in user
        /// interactive mode (for more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        DialogResult ShowDialog();

        /// <summary> Shows the form as a modal dialog box with the specified owner. </summary>
        /// <param name="owner">
        /// Any object that implements
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> that represents the
        /// top-level window that will own the modal dialog box.
        /// </param>
        /// <returns> One of the <see cref="T:System.Windows.Forms.DialogResult" /> values. </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The form specified in the
        /// <paramref name="owner" /> parameter is the same as the form being shown.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is
        /// already visible. -or- The form being shown is disabled. -or- The form being
        /// shown is not a top-level window. -or- The form being shown as a dialog box is
        /// already a modal form. -or- The current process is not running in user
        /// interactive mode (for more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        DialogResult ShowDialog(IWin32Window owner);

        /// <summary> Gets a string representing the current instance of the form. </summary>
        /// <returns>
        /// A string consisting of the fully qualified name of the form object's
        /// class, with the <see cref="P:System.Windows.Forms.Form.Text" /> property of the
        /// form appended to the end. For example, if the form is derived from the class
        /// <c>MyForm</c> in the <c>MyNamespace</c> namespace, and the
        /// <see cref="P:System.Windows.Forms.Form.Text" /> property is set to
        /// <c>Hello, World</c>, this method will return
        /// <c> MyNamespace.MyForm, Text: Hello, World </c> .
        /// </returns>
        string ToString();

        /// <summary>
        /// Causes all of the child controls within a control that support
        /// validation to validate their data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if all of the children validated
        /// successfully; otherwise, <see langword="false" />. If called from the
        /// <see cref="E:System.Windows.Forms.Control.Validating" /> or
        /// <see cref="E:System.Windows.Forms.Control.Validated" /> event handlers, this
        /// method will always return <see langword="false" />.
        /// </returns>
        bool ValidateChildren();

        /// <summary>
        /// Causes all of the child controls within a control that support
        /// validation to validate their data.
        /// </summary>
        /// <param name="validationConstraints">
        /// Places restrictions on which controls have
        /// their <see cref="E:System.Windows.Forms.Control.Validating" /> event raised.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if all of the children validated
        /// successfully; otherwise, <see langword="false" />. If called from the
        /// <see cref="E:System.Windows.Forms.Control.Validating" /> or
        /// <see cref="E:System.Windows.Forms.Control.Validated" /> event handlers, this
        /// method will always return <see langword="false" />.
        /// </returns>
        bool ValidateChildren(ValidationConstraints validationConstraints);
    }
}