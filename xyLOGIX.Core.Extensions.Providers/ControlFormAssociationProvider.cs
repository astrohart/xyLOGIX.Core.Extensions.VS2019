using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions.Providers.Interfaces;

namespace xyLOGIX.Core.Extensions.Providers
{
    /// <summary> Defines associations between forms and their contained controls. </summary>
    [Log(AttributeExclude = true), ExplicitlySynchronized]
    public class
        ControlFormAssociationProvider : IControlFormAssociationProvider
    {
        /// <summary>
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ControlFormAssociationProvider() { }

        /// <summary>
        /// Empty, <see langword="private" /> constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ControlFormAssociationProvider()
            => ParentFormDictionary = new AdvisableDictionary<Control, Form>();

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider" />
        /// interface.
        /// </summary>
        public static IControlFormAssociationProvider Instance
        {
            [DebuggerStepThrough] get;
        } = new ControlFormAssociationProvider();

        /// <summary>
        /// Reference to an instance of a dictionary that maps instances of
        /// <see cref="T:System.Windows.Forms.Control" />s to the parent
        /// <see cref="T:System.Windows.Forms.Form" />s that contain them.
        /// </summary>
        protected IDictionary<Control, Form> ParentFormDictionary
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Adds an association between the specified <paramref name="control" />
        /// and the specified <paramref name="form" />.
        /// </summary>
        /// <param name="control">
        /// (Required.) A
        /// <see cref="T:System.Windows.Forms.Control" /> for whom an association should be
        /// created between it and its containing
        /// <see cref="T:System.Windows.Forms.Form" />.
        /// </param>
        public void Add(Control control)
        {
            try
            {
                if (control == null || control.Disposing || control.IsDisposed)
                    return;
                if (ParentFormDictionary == null) return;
                if (ParentFormDictionary.ContainsKey(control)) return;

                var form = control.FindForm();
                if (form == null || form.IsDisposed) return;

                ParentFormDictionary.Add(control, form);

                CleanupOnControlDestroyed(control);
                CleanupOnFormClosed(form);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Given a reference to an instance of
        /// <see cref="T:System.Windows.Forms.Control" />, tries to lookup the
        /// corresponding parent <see cref="T:System.Windows.Forms.Form" /> that contains
        /// the control in our dictionary.
        /// </summary>
        /// <param name="control">
        /// (Required.) An instance of
        /// <see cref="T:System.Windows.Forms.Control" /> for whom the containing form is
        /// to be obtained.
        /// </param>
        /// <returns>
        /// If found, a reference to the instance of
        /// <see cref="T:System.Windows.Forms.Form" /> that contains the specified
        /// <paramref name="control" />, or <see langword="null" /> if no such form was
        /// found.
        /// </returns>
        public Form GetFormFor(Control control)
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

        /// <summary>
        /// Subscribes the
        /// <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event of the
        /// specified <paramref name="control" /> to remove all the mappings for it from
        /// our public dictionary.
        /// </summary>
        /// <param name="control">
        /// (Required.) A
        /// <see cref="T:System.Windows.Forms.Control" /> for whom all the mappings should
        /// be removed to its parent form(s) in our public dictionary.
        /// </param>
        private void CleanupOnControlDestroyed(Control control)
        {
            try
            {
                if (control == null || control.IsDisposed) return;
                if (ParentFormDictionary == null) return;
                if (!ParentFormDictionary.ContainsKey(control))
                    return;

                // Subscribe the HandleDestroyed event of the control to make sure and remove the
                // items from the dictionary for that control (to preserve memory).
                //
                // Unsubscribe the event first, in case we already subscribed the handler to
                // the control's HandleDestroyed event.

                control.HandleDestroyed += OnMemberControlHandleDestroyed;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Subscribes the <see cref="E:System.Windows.Forms.Form.FormClosed" />
        /// event of the specified <paramref name="form" /> to un-associate it with all its
        /// contained controls in our public dictionary.
        /// </summary>
        /// <param name="form">
        /// (Required.) A <see cref="T:System.Windows.Forms.Form" />
        /// that should be un-associated with its contained controls in our internal
        /// dictionary.
        /// </param>
        /// <remarks>
        /// If the specified <paramref name="form" /> is <see langword="null" />
        /// or disposed, or if the public dictionary has not been initialized, or if the
        /// public dictionary contains no mappings for the specified
        /// <paramref name="form" />, then this method does nothing.
        /// </remarks>
        private void CleanupOnFormClosed(Form form)
        {
            try
            {
                if (form == null || form.IsDisposed) return;
                if (ParentFormDictionary == null) return;
                if (!ParentFormDictionary.Values.Any(f => f.Equals(form)))
                    return;

                // Subscribe the FormClosed event of the form to make sure and remove the
                // items from the dictionary for that form (to preserve memory).
                //
                // Unsubscribe the event first, in case we already subscribed the handler to
                // the form's FormClosed event.

                form.FormClosed -= OnMemberFormClosed;
                form.FormClosed += OnMemberFormClosed;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Removes the association(s) between the specified
        /// <paramref name="control" /> and its containing form(s).
        /// </summary>
        /// <param name="control">
        /// A <see cref="T:System.Windows.Forms.Control" /> that is
        /// to be removed from our public dictionary.
        /// </param>
        /// <remarks>
        /// This method is usually called as part of the handling of a
        /// <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event for the
        /// specified <paramref name="control" />.
        /// </remarks>
        private void DetachControl(Control control)
        {
            try
            {
                if (control == null) return;
                if (ParentFormDictionary == null) return;
                if (!ParentFormDictionary.Any()) return;
                if (!ParentFormDictionary.ContainsKey(control)) return;

                var keysToRemove = ParentFormDictionary.Keys
                    .Where(k => k.Equals(control))
                    .ToAdvisableCollection();

                foreach (var key in keysToRemove)
                    ParentFormDictionary.Remove(key);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary> Called to remove all the key-value pairs that </summary>
        /// <param name="form">
        /// (Required.) Reference to the instance of
        /// <see cref="T:System.Windows.Forms.Form" /> whose associated controls are to be
        /// removed.
        /// </param>
        /// <remarks>
        /// This method is usually closed as part of the implementation of a
        /// handler for the <see cref="E:System.Windows.Forms.Form.FormClosed" /> event for
        /// the specified <paramref name="form" />.
        /// </remarks>
        private void DetachForm(Form form)
        {
            try
            {
                if (form == null) return;

                /*
                 * OKAY, get all the entries in the dictionary
                 * that map to the specified form.
                 *
                 * Then, remove all of them.
                 */
                var itemsToRemove = ParentFormDictionary
                                    .Where(kvp => kvp.Value.Equals(form))
                                    .ToAdvisableCollection();
                if (!itemsToRemove.Any()) return;

                foreach (var item in itemsToRemove)
                    ParentFormDictionary.Remove(item.Key);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event raised by a
        /// <see cref="T:System.Windows.Forms.Control" /> in our public collection.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by removing the mapping between the
        /// <see cref="T:System.Windows.Forms.Control" /> that is the
        /// <paramref name="sender" /> of this event and the associated parent
        /// <see cref="T:System.Windows.Forms.Form" />.
        /// </remarks>
        [EntryPoint]
        private void OnMemberControlHandleDestroyed([NotLogged] object sender, [NotLogged] EventArgs e)
        {
            if (!(sender is Control control)) return;

            DetachControl(control);
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Form.FormClosed" />
        /// event raised by a form that has been associated with one or more control(s).
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by removing all the entries from our internal
        /// dictionary that correspond to the specified form.
        /// </remarks>
        [EntryPoint]
        private void OnMemberFormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender is Form form)) return;
            if (ParentFormDictionary == null) return;
            if (!ParentFormDictionary.Any()) return;

            DetachForm(form);
        }
    }
}
