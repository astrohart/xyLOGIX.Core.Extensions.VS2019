// Must be first per preference.

using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of a
    /// text-entry control that is interface-compatible with
    /// <see cref="T:System.Windows.Forms.TextBox" /> while supporting interface-first
    /// programming and dark-theme hosting scenarios.
    /// </summary>
    /// <remarks>
    /// This interface is intended to be implemented by controls that behave
    /// like a <see cref="T:System.Windows.Forms.TextBox" />, including wrappers which
    /// host a real <see cref="T:System.Windows.Forms.TextBox" /> internally. Consumers
    /// should depend on <see cref="T:ITextBox" /> to enable
    /// loose coupling, improved testability, and SOLID design.
    /// </remarks>
    public interface ITextBox : IControl, IWin32Window
    {
        /// <summary>
        /// Gets or sets a value indicating whether pressing <c>ENTER</c> in a multiline
        /// text box creates a new line of text.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if the <c>ENTER</c> key inserts a new line in a
        /// multiline control; otherwise,
        /// <see langword="false" /> (the form’s default button is activated). The default
        /// is <see langword="false" />.
        /// </value>
        bool AcceptsReturn
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether pressing <c>TAB</c> in a multiline text
        /// box inserts a tab character instead of moving focus.
        /// </summary>
        /// <value>
        /// <see langword="true" /> to allow a literal tab to be inserted; otherwise,
        /// <see langword="false" />. The default is <see langword="false" />.
        /// </value>
        bool AcceptsTab
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the custom source of strings used for automatic completion.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" /> providing
        /// completion candidates; may be
        /// <see langword="null" /> or empty.
        /// </value>
        AutoCompleteStringCollection AutoCompleteCustomSource
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the auto-completion mode for this control.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:System.Windows.Forms.AutoCompleteMode" /> value(s):
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.None" />,
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.Append" />,
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.Suggest" />, or
        /// <see cref="F:System.Windows.Forms.AutoCompleteMode.SuggestAppend" />.
        /// </value>
        /// <remarks>
        /// Implementers should validate assigned values and ignore or coerce invalid
        /// enumeration values.
        /// </remarks>
        AutoCompleteMode AutoCompleteMode
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the auto-completion string source for this control.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:System.Windows.Forms.AutoCompleteSource" /> value(s).
        /// The default is
        /// <see cref="F:System.Windows.Forms.AutoCompleteSource.None" />.
        /// </value>
        /// <remarks>
        /// Implementers should validate assigned values and ignore or coerce invalid
        /// enumeration values.
        /// </remarks>
        AutoCompleteSource AutoCompleteSource
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a value indicating whether the previous operation can be undone.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if an undo is available; otherwise,
        /// <see langword="false" />.
        /// </value>
        bool CanUndo { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets how the control modifies the case of characters as they are typed.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:System.Windows.Forms.CharacterCasing" /> value(s). The
        /// default is
        /// <see cref="F:System.Windows.Forms.CharacterCasing.Normal" />.
        /// </value>
        CharacterCasing CharacterCasing
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets the <see cref="T:System.ComponentModel.IContainer" /> that contains the
        /// component.
        /// </summary>
        /// <value>
        /// Reference to an instance of <see cref="T:System.ComponentModel.IContainer" />
        /// that contains this component,
        /// or <see langword="null" /> if the component has no site.
        /// </value>
        IContainer Container { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether the selected text remains highlighted
        /// when the control loses focus.
        /// </summary>
        /// <value>
        /// <see langword="true" /> to hide the selection when focus is lost;
        /// <see langword="false" /> to keep it highlighted.
        /// The default is <see langword="true" />.
        /// </value>
        bool HideSelection
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the lines of text within the control.
        /// </summary>
        /// <value>
        /// An array of <see cref="T:System.String" /> value(s) containing the individual
        /// lines.
        /// </value>
        string[] Lines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the maximum number of characters the user can type or paste.
        /// </summary>
        /// <value>
        /// A positive <see cref="T:System.Int32" />. The default is <c>32767</c>.
        /// </value>
        /// <remarks>
        /// Implementers should reject values less than 1.
        /// </remarks>
        int MaxLength { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value indicating whether the text has been modified by the user.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if the contents have been modified; otherwise,
        /// <see langword="false" />.
        /// </value>
        bool Modified { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a multiline text box.
        /// </summary>
        /// <value>
        /// <see langword="true" /> for multiline; otherwise, <see langword="false" />.
        /// </value>
        bool Multiline { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets the masking character used to display password input for a
        /// single-line text box.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Char" /> masking character, or <c>\0</c> to disable
        /// masking. The default is <c>\0</c>.
        /// </value>
        char PasswordChar
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets the preferred height for a text box.
        /// </summary>
        /// <value>
        /// The recommended height in pixels.
        /// </value>
        int PreferredHeight { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether the text box is read-only.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if the control is read-only; otherwise,
        /// <see langword="false" />.
        /// </value>
        bool ReadOnly { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Gets or sets which scroll bars appear in a multiline control.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:System.Windows.Forms.ScrollBars" /> value(s). The
        /// default is
        /// <see cref="F:System.Windows.Forms.ScrollBars.None" />.
        /// </value>
        ScrollBars ScrollBars
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the currently selected text.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> containing the current selection, or
        /// <see cref="F:System.String.Empty" /> if no selection exists.
        /// </value>
        string SelectedText
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the number of characters selected.
        /// </summary>
        /// <value>
        /// A non-negative <see cref="T:System.Int32" /> indicating the length of the
        /// selection.
        /// </value>
        int SelectionLength
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets the starting index of the selection.
        /// </summary>
        /// <value>
        /// A non-negative <see cref="T:System.Int32" /> indicating the zero-based start of
        /// the selection.
        /// </value>
        int SelectionStart
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether standard editing shortcuts are enabled.
        /// </summary>
        /// <value>
        /// <see langword="true" /> to enable shortcuts (e.g., <c>Ctrl+C</c>, <c>Ctrl+V</c>
        /// ); otherwise, <see langword="false" />.
        /// </value>
        bool ShortcutsEnabled
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets how text is horizontally aligned within the control.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:System.Windows.Forms.HorizontalAlignment" /> value(s).
        /// The default is
        /// <see cref="F:System.Windows.Forms.HorizontalAlignment.Left" />.
        /// </value>
        HorizontalAlignment TextAlign
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets the length of the text content.
        /// </summary>
        /// <value>
        /// A non-negative <see cref="T:System.Int32" /> indicating the number of
        /// characters.
        /// </value>
        int TextLength { [DebuggerStepThrough] get; }

        /// <summary>
        /// Gets or sets a value indicating whether to display the system password
        /// character.
        /// </summary>
        /// <value>
        /// <see langword="true" /> to display the system-defined password character;
        /// otherwise, <see langword="false" />.
        /// </value>
        bool UseSystemPasswordChar
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a multiline text box automatically
        /// wraps words to the next line.
        /// </summary>
        /// <value>
        /// <see langword="true" /> to wrap; <see langword="false" /> to allow horizontal
        /// scrolling. The default is <see langword="true" />.
        /// </value>
        bool WordWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

        /// <summary>
        /// Occurs when the value of
        /// <see cref="P:AcceptsTab" /> changes.
        /// </summary>
        event EventHandler AcceptsTabChanged;

        /// <summary>
        /// Appends the specified text to the existing content.
        /// </summary>
        /// <param name="text">
        /// (Required.) A <see cref="T:System.String" /> containing the text to append. If
        /// <see langword="null" />,
        /// <see cref="F:System.String.Empty" />, or whitespace, implementers should
        /// perform no action.
        /// </param>
        /// <remarks>
        /// Implementations should be resilient to large input and avoid exceptions. If the
        /// control is read-only or disabled,
        /// no action is expected.
        /// </remarks>
        void AppendText(string text);

        /// <summary>
        /// Clears all text.
        /// </summary>
        /// <remarks>
        /// If the control is read-only, implementers should perform no action.
        /// </remarks>
        void Clear();

        /// <summary>
        /// Clears the most recent operation from the undo buffer.
        /// </summary>
        /// <remarks>
        /// Implementers should perform no action if there is nothing to clear.
        /// </remarks>
        void ClearUndo();

        /// <summary>
        /// Copies the current selection to the Clipboard.
        /// </summary>
        /// <remarks>
        /// Implementers should perform no action if there is no selection or Clipboard
        /// access is unavailable.
        /// </remarks>
        void Copy();

        /// <summary>
        /// Creates an object that contains all the relevant information required to
        /// generate a proxy used to communicate with a remote object.
        /// </summary>
        /// <param name="requestedType">
        /// (Required.) Reference to an instance of <see cref="T:System.Type" /> that
        /// represents the type of the proxy requested.
        /// </param>
        /// <returns>
        /// <see cref="T:System.Runtime.Remoting.ObjRef" /> containing remoting information
        /// for the object.
        /// </returns>
        /// <remarks>
        /// This member mirrors
        /// <see cref="M:System.MarshalByRefObject.CreateObjRef(System.Type)" /> semantics.
        /// </remarks>
        [return: NotLogged]
        ObjRef CreateObjRef([NotLogged] Type requestedType);

        /// <summary>
        /// Cuts the current selection and places it on the Clipboard.
        /// </summary>
        /// <remarks>
        /// Implementers should perform no action if the control is read-only or there is
        /// no selection.
        /// </remarks>
        void Cut();

        /// <summary>
        /// Clears the current selection.
        /// </summary>
        /// <remarks>
        /// Implementers should set
        /// <see cref="P:SelectionLength" /> to zero
        /// without altering the caret position.
        /// </remarks>
        void DeselectAll();

        /// <summary>
        /// Gets the character closest to the specified point within the client area.
        /// </summary>
        /// <param name="pt">
        /// (Required.) Reference to an instance of <see cref="T:System.Drawing.Point" />
        /// specifying the location (client coordinates).
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Char" /> representing the character at the location; if
        /// the position cannot be resolved,
        /// implementers may return <see cref="F:System.Char.MinValue" />.
        /// </returns>
        char GetCharFromPosition([NotLogged] Point pt);

        /// <summary>
        /// Gets the zero-based index of the character nearest to the specified point.
        /// </summary>
        /// <param name="pt">
        /// (Required.) Reference to an instance of <see cref="T:System.Drawing.Point" />
        /// specifying the location (client coordinates).
        /// </param>
        /// <returns>
        /// A non-negative <see cref="T:System.Int32" /> character index. If the index
        /// cannot be determined, implementers may return <c>0</c>.
        /// </returns>
        int GetCharIndexFromPosition([NotLogged] Point pt);

        /// <summary>
        /// Gets the zero-based index of the first character of the specified line.
        /// </summary>
        /// <param name="lineNumber">
        /// (Required.) A non-negative <see cref="T:System.Int32" /> specifying the
        /// zero-based line number.
        /// </param>
        /// <returns>
        /// A non-negative <see cref="T:System.Int32" /> index of the first character in
        /// the line.
        /// </returns>
        /// <remarks>
        /// Implementers should handle out-of-range values gracefully (e.g., return
        /// <c>0</c> or clamp to valid ranges).
        /// </remarks>
        int GetFirstCharIndexFromLine(int lineNumber);

        /// <summary>
        /// Gets the zero-based index of the first character in the current line.
        /// </summary>
        /// <returns>
        /// A non-negative <see cref="T:System.Int32" /> index.
        /// </returns>
        int GetFirstCharIndexOfCurrentLine();

        /// <summary>
        /// Obtains the lifetime service object that controls the lifetime policy for this
        /// instance.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.Object" /> controlling lifetime
        /// policy, or <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// Mirrors <see cref="M:System.MarshalByRefObject.GetLifetimeService" />
        /// semantics.
        /// </remarks>
        [return: NotLogged]
        object GetLifetimeService();

        /// <summary>
        /// Retrieves the zero-based line number corresponding to the specified character
        /// index.
        /// </summary>
        /// <param name="index">
        /// (Required.) A non-negative <see cref="T:System.Int32" /> specifying the
        /// character position.
        /// </param>
        /// <returns>
        /// A non-negative <see cref="T:System.Int32" /> line number.
        /// </returns>
        /// <remarks>
        /// Implementers should validate <paramref name="index" /> against
        /// <see cref="P:TextLength" />.
        /// </remarks>
        int GetLineFromCharIndex(int index);

        /// <summary>
        /// Gets the client coordinates of the specified character index.
        /// </summary>
        /// <param name="index">
        /// (Required.) A non-negative <see cref="T:System.Int32" /> specifying the
        /// character index (&lt;
        /// <see cref="P:TextLength" />).
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.Drawing.Point" /> indicating
        /// the location; if unavailable, implementers may return
        /// <see cref="P:System.Drawing.Point.Empty" />.
        /// </returns>
        [return: NotLogged]
        Point GetPositionFromCharIndex(int index);

        /// <summary>
        /// Occurs when the value of
        /// <see cref="P:HideSelection" /> changes.
        /// </summary>
        event EventHandler HideSelectionChanged;

        /// <summary>
        /// Initializes the lifetime service object that controls the lifetime policy for
        /// this instance.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.Object" /> that controls
        /// lifetime policy for this instance, or <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// Mirrors <see cref="M:System.MarshalByRefObject.InitializeLifetimeService" />
        /// semantics.
        /// </remarks>
        [return: NotLogged]
        object InitializeLifetimeService();

        /// <summary>
        /// Occurs when the value of
        /// <see cref="P:Modified" /> changes.
        /// </summary>
        event EventHandler ModifiedChanged;

        /// <summary>
        /// Occurs when the value of
        /// <see cref="P:Multiline" /> changes.
        /// </summary>
        event EventHandler MultilineChanged;

        /// <summary>
        /// Pastes the contents of the Clipboard at the current caret position.
        /// </summary>
        /// <remarks>
        /// Implementers should perform no action if Clipboard access is unavailable or the
        /// control is read-only.
        /// </remarks>
        void Paste();

        /// <summary>
        /// Pastes the specified text at the current caret position (replacing the
        /// selection, if any).
        /// </summary>
        /// <param name="text">
        /// (Required.) A <see cref="T:System.String" /> containing the text to insert. If
        /// <see langword="null" />,
        /// <see cref="F:System.String.Empty" />, or whitespace, implementers should
        /// perform no action.
        /// </param>
        void Paste(string text);

        /// <summary>
        /// Occurs when the value of
        /// <see cref="P:ReadOnly" /> changes.
        /// </summary>
        event EventHandler ReadOnlyChanged;

        /// <summary>
        /// Scrolls the content to the current caret position.
        /// </summary>
        void ScrollToCaret();

        /// <summary>
        /// Selects a range of text.
        /// </summary>
        /// <param name="start">
        /// (Required.) A non-negative <see cref="T:System.Int32" /> specifying the
        /// zero-based index of the first character in the selection.
        /// </param>
        /// <param name="length">
        /// (Required.) A positive <see cref="T:System.Int32" /> specifying the number of
        /// characters to select.
        /// </param>
        /// <remarks>
        /// Implementers should validate <paramref name="start" /> and
        /// <paramref name="length" /> against
        /// <see cref="P:TextLength" /> and perform no
        /// action for out-of-range requests.
        /// </remarks>
        void Select(int start, int length);

        /// <summary>
        /// Selects all text within the control.
        /// </summary>
        /// <remarks>
        /// Implementers should perform no action if there is no content to select.
        /// </remarks>
        void SelectAll();

        /// <summary>
        /// Occurs when the value of
        /// <see cref="P:TextAlign" /> changes.
        /// </summary>
        event EventHandler TextAlignChanged;

        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> representing the object; typically the type
        /// name or a concise state description.
        /// </returns>
        string ToString();

        /// <summary>
        /// Undoes the last edit operation, if possible.
        /// </summary>
        /// <remarks>
        /// Implementers should perform no action if there is nothing to undo.
        /// </remarks>
        void Undo();
    }
}