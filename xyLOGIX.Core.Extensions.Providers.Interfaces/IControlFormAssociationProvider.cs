using PostSharp.Patterns.Diagnostics;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a provider of
    /// associations between controls and the form(s) that contain them.
    /// </summary>
    public interface IControlFormAssociationProvider
    {
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
        void Add(Control control);

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
        Form GetFormFor(Control control);

        /// <summary>
        /// Removes the specified <paramref name="control" /> and the corresponding
        /// association to its containing <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="control">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.Control" /> that refers to the control that
        /// is to be removed.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified operation(s) have completed
        /// successfully; <see langword="false" /> otherwise.
        /// </returns>
        bool Remove([NotLogged] Control control);
    }
}