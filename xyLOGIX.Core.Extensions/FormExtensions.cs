using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    public static class FormExtensions
    {
        /// <summary>Centers this form on the specified <see cref="parent" /> form.</summary>
        /// <param name="child">Reference to the form to be centered.</param>
        /// <param name="parent">Reference to the parent form.</param>
        public static void CenterForm(this Form child, Form parent)
        {
            child.StartPosition = FormStartPosition.Manual;
            child.Location = new Point(
                parent.Location.X + (parent.Width - child.Width) / 2,
                parent.Location.Y + (parent.Height - child.Height) / 2
            );
        }

        /// <summary>Centers the specified <see cref="form" /> to the specific <see cref="screen" /> that is passed.</summary>
        /// <param name="form">Reference to an instance of <see cref="T:System.Windows.Forms.Form" /> that specifies the form to be centered.</param>
        /// <param name="screen">Reference to an instance of <see cref="T:System.Windows.Forms.Screen" /> that specifies the screen that the form is to be centered on.</param>
        public static void CenterForm(this Form form, Screen screen)
        {
            if (form == null)
                // stop.
                throw new ArgumentNullException(nameof(form));

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

        /// <summary>Shows the specified <see cref="form" /> on the user's primary monitor (whatever monitor they have designated as Monitor #1)</summary>
        /// <param name="form">Reference to the <see cref="T:System.Windows.Forms.Form" /> to be moved to the user's primary monitor.  The form is also centered on the screen.</param>
        public static void ShowOnPrimaryMonitor(this Form form)
        {
            if (form == null) throw new ArgumentNullException(nameof(form));

            form.StartPosition = FormStartPosition.Manual;

            var bounds = Screen.AllScreens.First().WorkingArea;

            form.SetBounds(
                (bounds.Width - form.Width) / 2,
                (bounds.Height - form.Height) / 2, form.Width, form.Height
            );

            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}