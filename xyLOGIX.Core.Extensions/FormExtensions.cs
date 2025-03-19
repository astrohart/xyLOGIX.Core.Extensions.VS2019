using PostSharp.Patterns.Threading;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Helper methods for manipulating windows forms. </summary>
    public static class FormExtensions
    {
        /// <summary> Centers this form on the specified <paramref name="parent" /> form. </summary>
        /// <param name="child"> Reference to the form to be centered. </param>
        /// <param name="parent"> Reference to the parent form. </param>
        public static void CenterForm(this IForm child, Form parent)
        {
            if (child == null || child.IsDisposed) return;
            if (parent == null || parent.IsDisposed) return;

            child.StartPosition = FormStartPosition.Manual;
            child.Location = new Point(
                parent.Location.X + (parent.Width - child.Width) / 2,
                parent.Location.Y + (parent.Height - child.Height) / 2
            );
        }

        /// <summary>
        /// Centers the specified <paramref name="form" /> to the specific
        /// <paramref name="screen" /> that is passed.
        /// </summary>
        /// <param name="form">
        /// Reference to an instance of
        /// <see cref="T:System.Windows.Forms.Form" /> that specifies the form to be
        /// centered.
        /// </param>
        /// <param name="screen">
        /// Reference to an instance of
        /// <see cref="T:System.Windows.Forms.Screen" /> that specifies the screen that the
        /// form is to be centered on.
        /// </param>
        public static void CenterForm(this IForm form, Screen screen)
        {
            if (form == null || form.IsDisposed) return;

            if (screen == null)

                // stop.
                throw new ArgumentNullException(nameof(screen));

            form.StartPosition = FormStartPosition.Manual;

            var bounds = screen.WorkingArea;
            form.SetBounds(
                (bounds.Width - form.Width) / 2,
                (bounds.Height - form.Height) / 2, form.Width, form.Height
            );

            form.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Invokes an message on the form unless it's not disposed, in which
        /// case nothing is done.
        /// </summary>
        /// <param name="form">
        /// A <see cref="T:System.Windows.Forms.Form" /> on which to
        /// perform the <paramref name="message" />.
        /// </param>
        /// <param name="message">
        /// An <see cref="T:System.Action" /> specifying code to be
        /// run if the form is disposed.
        /// </param>
        [Yielder]
        public static void DoIfDisposed(this IForm form, Action message)
        {
            if (form != null && !form.IsDisposed) return;

            message?.Invoke();
        }

        /// <summary>
        /// Invokes an message on the form unless it's disposed, in which case
        /// nothing is done.
        /// </summary>
        /// <param name="form">
        /// A <see cref="T:System.Windows.Forms.Form" /> on which to
        /// perform the <paramref name="message" />.
        /// </param>
        /// <param name="message">
        /// An <see cref="T:System.Action" /> specifying code to be
        /// run if the form is not disposed.
        /// </param>
        [Yielder]
        public static void DoIfNotDisposed(this IForm form, Action message)
        {
            if (form == null || form.IsDisposed) return;
            if (message == null) return;

            if (form.InvokeRequired)
                form.BeginInvoke(message);
            else
                message?.Invoke();
        }

        /// <summary> Shows a modal dialog that can be awaited upon while a task completes. </summary>
        /// <param name="form">
        /// Reference to an instance of an object that is a child class
        /// of <see cref="T:System.Windows.Forms.Form" /> that represents the form to be
        /// shown.
        /// </param>
        /// <param name="owner">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> that represents the form's
        /// owner window.
        /// </param>
        /// <returns>
        /// An awaitable
        /// <see cref="T:System.Threading.Tasks.Task{System.Windows.Forms.DialogResult}" />
        /// that contains the result of the dialog's closure.
        /// </returns>
        public static async Task<DialogResult> ShowDialogAsync(
            this IForm form,
            IWin32Window owner
        )
        {
            await Task.Yield();
            return form.IsDisposed ? DialogResult.OK : form.ShowDialog(owner);
        }

        /// <summary> Shows a modal dialog that can be awaited upon while a task completes. </summary>
        /// <param name="form">
        /// Reference to an instance of an object that is a child class
        /// of <see cref="T:System.Windows.Forms.Form" /> that represents the form to be
        /// shown.
        /// </param>
        /// <returns>
        /// An awaitable
        /// <see cref="T:System.Threading.Tasks.Task{System.Windows.Forms.DialogResult}" />
        /// that contains the result of the dialog's closure.
        /// </returns>
        public static async Task<DialogResult> ShowDialogAsync(this IForm form)
        {
            await Task.Yield();
            return form.IsDisposed ? DialogResult.OK : form.ShowDialog();
        }

        /// <summary>
        /// Shows the specified <paramref name="form" /> on the user's primary
        /// monitor (whatever monitor they have designated as Monitor #1)
        /// </summary>
        /// <param name="form">
        /// Reference to the <see cref="T:System.Windows.Forms.Form" />
        /// to be moved to the user's primary monitor. The form is also centered on the
        /// screen.
        /// </param>
        public static void ShowOnPrimaryMonitor(this IForm form)
        {
            if (form == null) throw new ArgumentNullException(nameof(form));

            form.StartPosition = FormStartPosition.Manual;

            var bounds = Screen.AllScreens.First()
                               .WorkingArea;

            form.SetBounds(
                (bounds.Width - form.Width) / 2,
                (bounds.Height - form.Height) / 2, form.Width, form.Height
            );

            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}