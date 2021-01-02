using System.ComponentModel;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>Helper methods for extending the functionality of controls and forms.</summary>
    public static class ControlExtensions
    {
        /// <summary>Thread-safe way to run managed code against, e.g., a GUI-thread control.</summary>
        /// <param name="obj">Reference to an instance of an object that implements the <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> interface.</param>
        /// <param name="action">Reference to a <see cref="T:System.Windows.Forms.MethodInvoker" /> delegate that defines the code to be run.</param>
        public static void InvokeIfRequired(this ISynchronizeInvoke obj,
            MethodInvoker action)
        {
            if (!(obj is Control control) || control.Parent == null ||
                control.Parent.IsDisposed)
                return;

            while (!control.Parent.Visible)
                Application.DoEvents();

            if (obj.InvokeRequired)
                obj.BeginInvoke(action, new object[0]);
            else
                action();
        }
    }
}