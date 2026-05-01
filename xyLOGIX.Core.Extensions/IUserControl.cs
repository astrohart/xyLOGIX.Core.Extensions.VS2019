using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of a control that
    /// inherits <see cref="T:System.Windows.Forms.UserControl" />.
    /// </summary>
    public interface IUserControl : IWin32Window, IDisposable
    {
        /// <summary>
        /// Gets or sets the border style for the text box.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Windows.Forms.BorderStyle" /> indicating the border
        /// appearance.
        /// </value>
        BorderStyle BorderStyle
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }
    }
}