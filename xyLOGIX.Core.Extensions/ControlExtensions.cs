using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// The <c>ControlExtensions</c> class provides helper methods for extending
    /// the functionality of .NET framework controls.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ControlExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.ControlExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        static ControlExtensions()
            => ParentFormDictionary = new Dictionary<Control, Form>();

        /// <summary>
        /// Reference to an instance of a dictionary that maps instances of
        /// <see cref="T:System.Windows.Forms.Control" />s to the parent
        /// <see cref="T:System.Windows.Forms.Form" />s that contain them.
        /// </summary>
        public static IDictionary<Control, Form> ParentFormDictionary { get; }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Windows.Forms.Form" /> that
        /// contains this control.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="T:System.Windows.Forms.Form" /> that
        /// contains this control.
        /// </returns>
        /// <remarks>
        /// This method provides the return value of the
        /// <see cref="M:System.Windows.Forms.Control.FindForm" /> method if the value of
        /// the <see cref="F:xyLOGIX.UI.Dark.Controls.DarkCheckBox2._parentForm" />
        /// field is uninitialized.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public static Form GetParentForm(this Control control)
        {
            Form result = default;

            try
            {
                if (control == null) return result;

                result = GetFormFor(control) ?? control.FindForm();
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
        /// <param name="obj">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> interface.
        /// </param>
        /// <param name="message">
        /// (Required.) Reference to a
        /// <see
        ///     cref="T:System.Windows.Forms.MethodInvoker" />
        /// delegate that defines
        /// the code to be run.
        /// </param>
        /// <remarks>
        /// This method should always be called for a child control of a frame
        /// window; never the window itself (even though, technically, it also
        /// derives from <see cref="T:System.Windows.Forms.Control" /> and
        /// implements the
        /// <see
        ///     cref="T:System.ComponentModel.ISynchronizeInvoke" />
        /// interface).
        /// </remarks>
        public static void InvokeIfRequired(this ISynchronizeInvoke obj,
            MethodInvoker message)
        {
            if (!(obj is Control)) return;

            //if (control.Parent != null &&
            //    !control.Parent.IsDisposed)
            //  while (!control.Parent.Visible)
            //    Application.DoEvents();

            if (obj.InvokeRequired)
                obj.Invoke(
                    message, Enumerable.Empty<object>()
                                       .ToArray()
                );
            else
                message?.Invoke();
        }

        /// <summary>
        /// Given a reference to an instance of
        /// <see cref="T:System.Windows.Forms.Control" />, tries to lookup the
        /// corresponding parent <see cref="T:System.Windows.Forms.Form" /> that contains
        /// the control in our dictionary.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private static Form GetFormFor(Control control)
        {
            Form result = default;

            try
            {
                if (control == null) return result;
                if (ParentFormDictionary == null) return result;
                if (!ParentFormDictionary.Any()) return result;
                if (!ParentFormDictionary.ContainsKey(control)) return result;

                result = ParentFormDictionary[control];
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}