using PostSharp.Patterns.Threading;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// A <see cref="T:System.Windows.Forms.ComboBox" /> that writes values when the
    /// value of the <see cref="P:System.Windows.Forms.ComboBox.SelectedIndex" />
    /// property is changed.
    /// </summary>
    [ExplicitlySynchronized]
    public class BoundComboBox : ComboBox
    {
        /// <summary>
        /// Raises the
        /// <see cref="E:System.Windows.Forms.ComboBox.SelectedIndexChanged" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            try
            {
                base.OnSelectedIndexChanged(e);

                if (DataBindings.Count == 0) return;
                if (DataBindings["SelectedItem"] == null) return;

                DataBindings["SelectedItem"]
                    .WriteValue();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}