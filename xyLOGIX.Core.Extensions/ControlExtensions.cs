using System.ComponentModel;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// The <c>ControlExtensions</c> class provides helper methods for extending
    /// the functionality of .NET framework controls.
    /// </summary>
    public static class ControlExtensions
    {
        /// <summary>
        /// Provides a thread-safe way to run managed code against, e.g., a
        /// GUI-thread control.
        /// </summary>
        /// <param name="obj">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.ComponentModel.ISynchronizeInvoke"/> interface.
        /// </param>
        /// <param name="message">
        /// (Required.) Reference to a <see
        /// cref="T:System.Windows.Forms.MethodInvoker"/> delegate that defines
        /// the code to be run.
        /// </param>
        /// <remarks>
        /// This method should always be called for a child control of a frame
        /// window; never the window itself (even though, technically, it also
        /// derives from <see cref="T:System.Windows.Forms.Control"/> and
        /// implements the <see
        /// cref="T:System.ComponentModel.ISynchronizeInvoke"/> interface).
        /// </remarks>
        /// <example>
        /// This example shows how to call the <see
        /// cref="M:xyLOGIX.Core.Extensions.ControlExtensions.InvokeIfRequired"/> method.
        /// <example>
        ///namespace Foo
        ///{
        ///public class Form1
        ///{
        ///private System.Windows.Forms.Label mainInstructionLabel;
        ///private System.Windows.Forms.TextBox filenameTextBox;
        ///private System.Windows.Forms.Button okButton;
        ///
        ///public Form1()
        ///{
        ///InitializeComponent();
        ///}
        ///
        ///protected override void OnLoad(EventArgs e)
        ///{
        ///// Let's suppose we are calling this form from another thread.
        ///// To fill the text box, we need to use Invoke, if required.
        ///// NOTE: You can call the InvokeIfRequired extension method on any
        ///// of the child controls of the form.  Just do not call it on the form
        ///// itself; i.e., do not do 'this.InvokeIfRequired(...)'.
        ///filenameTextBox.InvokeIfRequired(()=&gt; {
        ///mainInstructionLabel.Text = "Type the name of the file to open:";
        ///okButton.DialogResult = DialogResult.OK;
        ///AcceptButton = okButton;
        ///});
        ///}
        ///
        ////* ... other form code ... */
        ///}
        ///}
        /// </example>
        public static void InvokeIfRequired(this ISynchronizeInvoke obj,
            MethodInvoker message)
        {
            if (!(obj is Control control) || control.Parent == null ||
                control.Parent.IsDisposed)
                return;

            while (!control.Parent.Visible)
                Application.DoEvents();

            if (obj.InvokeRequired)
                obj.BeginInvoke(message, new object[0]);
            else
                message();
        }
    }
}