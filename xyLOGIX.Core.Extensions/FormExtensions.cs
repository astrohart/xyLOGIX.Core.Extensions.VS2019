using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary> Helper methods for manipulating windows forms. </summary>
    public static class FormExtensions
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Core.Extensions.FormExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static FormExtensions() { }

        /// <summary> Centers this form on the specified <paramref name="parent" /> form. </summary>
        /// <param name="child">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:xyLOGIX.Core.Extensions.IForm" /> interface that
        /// represents the <c>Child Form</c>; i.e., the form that is to be centered with
        /// respect to the specified <paramref name="parent" /> form.
        /// </param>
        /// <param name="parent">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:xyLOGIX.Core.Extensions.IForm" /> interface that
        /// represents the parent form.
        /// </param>
        public static void CenterForm(
            [NotLogged] this IForm child,
            [NotLogged] IForm parent
        )
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
        /// Invokes the specified <paramref name="message" /> on the form unless it's NOT
        /// disposed, in which case nothing is done.
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
        public static void DoIfDisposed(
            [NotLogged] this IForm form,
            [NotLogged] Action message
        )
        {
            if (form != null && !form.IsDisposed) return;

            message?.Invoke();
        }

        /// <summary>
        /// Invokes the specified <paramref name="message" /> on the form unless it's
        /// disposed, in which case nothing is done.
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
        public static void DoIfNotDisposed(
            [NotLogged] this IForm form,
            [NotLogged] Action message
        )
        {
            if (form == null || form.IsDisposed) return;
            if (message == null) return;

            if (form.InvokeRequired)
                form.BeginInvoke(message);
            else
                message();
        }

        /// <summary>
        /// Gets a value indicating whether the specified <paramref name="form" /> is
        /// either set to a <see langword="null" /> reference, or is in the process of
        /// being disposed, or has already been disposed.
        /// </summary>
        /// <param name="form">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Core.Extensions.IForm" /> interface that is to be
        /// checked for being in the <c>Disposed</c> state.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="form" />
        /// is in the <see langword="null" /> reference or <c>Disposed</c> state, or if it
        /// is in the process of being disposed.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsNullOrDisposed([NotLogged] this IForm form)
        {
            bool result;

            try
            {
                result = form == null || form.Disposing || form.IsDisposed;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                /*
                 * We are actually going to return TRUE here, so
                 * that the caller of this method errs on the side of
                 * caution and does not use the specified form.
                 */

                result = true;
            }

            return result;
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
        /// <see cref="T:DialogResult" />
        /// that contains the result of the dialog's closure.
        /// </returns>
        public static async Task<DialogResult> ShowDialogAsync(
            [NotLogged] this IForm form,
            [NotLogged] IWin32Window owner
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
        /// <see cref="T:DialogResult" />
        /// that contains the result of the dialog's closure.
        /// </returns>
        public static async Task<DialogResult> ShowDialogAsync(
            [NotLogged] this IForm form
        )
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
        public static void ShowOnPrimaryMonitor([NotLogged] this IForm form)
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