using System.Drawing;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of controls that
    /// support auto-scrolling behavior.
    /// </summary>
    public interface IScrollableControl : IControl
    {
        /// <summary>
        /// Occurs when the user or code scrolls through the client area.
        /// </summary>
        event ScrollEventHandler Scroll;

        /// <summary>
        /// Gets or sets a value indicating whether the container enables the user
        /// to scroll to any controls placed outside of its visible boundaries.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the container enables auto-scrolling;
        /// otherwise, <see langword="false" />. The default value is
        /// <see langword="false" />.
        /// </returns>
        bool AutoScroll { get; set; }

        /// <summary>
        /// Gets or sets the size of the auto-scroll margin.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size" /> that represents the height and
        /// width of the auto-scroll margin in pixels.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The <see cref="P:System.Drawing.Size.Height" /> or
        /// <see
        ///   cref="P:System.Drawing.Size.Width" />
        /// value assigned is less than 0.
        /// </exception>
        Size AutoScrollMargin { get; set; }

        /// <summary>
        /// Gets or sets the minimum size of the auto-scroll.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Size" /> that determines the minimum size
        /// of the virtual area through which the user can scroll.
        /// </returns>
        Size AutoScrollMinSize { get; set; }

        /// <summary>
        /// Gets or sets the location of the auto-scroll position.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Point" /> that represents the auto-scroll
        /// position in pixels.
        /// </returns>
        Point AutoScrollPosition { get; set; }

        /// <summary>
        /// Gets the dock padding settings for all edges of the control.
        /// </summary>
        /// <returns>
        /// A
        /// <see
        ///   cref="T:System.Windows.Forms.ScrollableControl.DockPaddingEdges" />
        /// that
        /// represents the padding for all the edges of a docked control.
        /// </returns>
        ScrollableControl.DockPaddingEdges DockPadding { get; }

        /// <summary>
        /// Gets the characteristics associated with the horizontal scroll bar.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.HScrollProperties" /> that contains
        /// information about the horizontal scroll bar.
        /// </returns>
        HScrollProperties HorizontalScroll { get; }

        /// <summary>
        /// Gets the characteristics associated with the vertical scroll bar.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.VScrollProperties" /> that contains
        /// information about the vertical scroll bar.
        /// </returns>
        VScrollProperties VerticalScroll { get; }

        /// <summary>
        /// Scrolls the specified child control into view on an auto-scroll enabled
        /// control.
        /// </summary>
        /// <param name="activeControl">
        /// The child control to scroll into view.
        /// </param>
        void ScrollControlIntoView(Control activeControl);

        /// <summary>
        /// Sets the size of the auto-scroll margins.
        /// </summary>
        /// <param name="x">
        /// The <see cref="P:System.Drawing.Size.Width" /> value.
        /// </param>
        /// <param name="y">
        /// The <see cref="P:System.Drawing.Size.Height" /> value.
        /// </param>
        void SetAutoScrollMargin(int x, int y);
    }
}