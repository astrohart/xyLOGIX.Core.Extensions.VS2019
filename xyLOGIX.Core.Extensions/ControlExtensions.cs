using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions.Providers.Factories;
using xyLOGIX.Core.Extensions.Providers.Interfaces;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// The <c>ControlExtensions</c> class provides helper methods for
    /// extending the functionality of .NET framework controls.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ControlExtensions
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider" />
        /// interface.
        /// </summary>
        private static IControlFormAssociationProvider
            ControlFormAssociationProvider
            => GetControlFormAssociationProvider.SoleInstance();

        /// <summary>
        /// Associates the specified <paramref name="control" /> with its
        /// containing (i.e., parent) <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="control">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.Control" /> that is to be associated with its
        /// containing (i.e., parent) <see cref="T:System.Windows.Forms.Form" />.
        /// </param>
        /// <remarks>
        /// If the <paramref name="control" /> parameter is passed a
        /// <see langword="null" /> reference as its argument, then this method does
        /// nothing.
        /// </remarks>
        public static void AssociateWithParentForm(this Control control)
        {
            try
            {
                if (control == null || control.Disposing || control.IsDisposed)
                    return;

                ControlFormAssociationProvider.Add(control);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Windows.Forms.Form" />
        /// that contains this control.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="T:System.Windows.Forms.Form" /> that
        /// contains this control.
        /// </returns>
        /// <remarks>
        /// This method provides the return value of the
        /// <see cref="M:System.Windows.Forms.Control.FindForm" /> method if the value of
        /// the <see cref="F:xyLOGIX.UI.Dark.Controls.DarkCheckBox2._parentForm" /> field
        /// is uninitialized.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public static Form GetParentForm(this Control control)
        {
            Form result = default;

            try
            {
                if (control == null) return result;

                result = ControlFormAssociationProvider.GetFormFor(control) ??
                         control.FindForm();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Provides a thread-safe way to run managed code against, e.g., a
        /// GUI-thread control.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Name of the return type of the specified
        /// <paramref name="message" />.
        /// </typeparam>
        /// <param name="obj">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.ComponentModel.ISynchronizeInvoke" />
        /// interface.
        /// </param>
        /// <param name="message">
        /// (Required.) Reference to a
        /// <see cref="T:System.Windows.Forms.MethodInvoker" /> delegate that defines the
        /// code to be run.
        /// </param>
        /// <returns>
        /// Reference to an instance of the return type of the specified
        /// <paramref name="message" />, or <see langword="null" /> if an error occurred.
        /// </returns>
        /// <remarks>
        /// This method should always be called for a child control of a frame
        /// window; never the window itself (even though, technically, it also derives from
        /// <see cref="T:System.Windows.Forms.Control" /> and implements the
        /// <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> interface).
        /// </remarks>
        public static T InvokeIfRequired<T>(
            this ISynchronizeInvoke obj,
            Func<T> message
        )
        {
            T result = default;

            if (!(obj is Control)) return result;

            if (obj.InvokeRequired)
                result = (T)obj.Invoke(
                    message, Enumerable.Empty<object>()
                                       .ToArray()
                );
            else
                result = message();

            return result;
        }

        /// <summary>
        /// Provides a thread-safe way to run managed code against, e.g., a
        /// GUI-thread control.
        /// </summary>
        /// <param name="obj">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.ComponentModel.ISynchronizeInvoke" />
        /// interface.
        /// </param>
        /// <param name="message">
        /// (Required.) Reference to a
        /// <see cref="T:System.Windows.Forms.MethodInvoker" /> delegate that defines the
        /// code to be run.
        /// </param>
        /// <remarks>
        /// This method should always be called for a child control of a frame
        /// window; never the window itself (even though, technically, it also derives from
        /// <see cref="T:System.Windows.Forms.Control" /> and implements the
        /// <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> interface).
        /// </remarks>
        [Yielder]
        public static void InvokeIfRequired(
            this ISynchronizeInvoke obj,
            MethodInvoker message
        )
        {
            if (!(obj is Control)) return;

            if (obj.InvokeRequired)
                obj.Invoke(
                    message, Enumerable.Empty<object>()
                                       .ToArray()
                );
            else
                message?.Invoke();
        }

        /// <summary>
        /// Gets a value that indicates whether the reference to the
        /// <see cref="T:System.Windows.Forms.Form" /> that contains this control is not
        /// initialized, or whether that <see cref="T:System.Windows.Forms.Form" /> is
        /// disposed.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the reference to the
        /// <see cref="T:System.Windows.Forms.Form" /> that contains this control is not
        /// initialized, or if that <see cref="T:System.Windows.Forms.Form" /> has been
        /// disposed; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsParentFormNullOrDisposed(this Control control)
        {
            var result = false;

            try
            {
                if (control == null || control.IsDisposed) return result;

                var parentForm =
                    ControlFormAssociationProvider.GetFormFor(control);
                result = parentForm == null || parentForm.Disposing ||
                         parentForm.IsDisposed;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}