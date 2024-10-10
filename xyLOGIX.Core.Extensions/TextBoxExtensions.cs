using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for
    /// <see cref="T:System.Windows.Forms.TextBox" />-derived controls.
    /// </summary>
    public static class TextBoxExtensions
    {
        /// <summary>
        /// Specifies the message to set the cue banner text (placeholder text) for a
        /// <see cref="T:System.Windows.Forms.TextBox" /> control.
        /// </summary>
        /// <remarks>
        /// This message is sent to a <see cref="T:System.Windows.Forms.TextBox" /> control
        /// to display greyed-out text when the
        /// <see cref="T:System.Windows.Forms.TextBox" /> is empty and unfocused.
        /// </remarks>
        private const uint EM_SETCUEBANNER = 0x1501;

        /// <summary>
        /// Determines whether the specified window handle identifies an existing window.
        /// </summary>
        /// <param name="hWnd">A handle to the window to be tested.</param>
        /// <returns>
        /// <see langword="true" /> if the window handle identifies an existing window;
        /// otherwise, <see langword="false" />.
        /// </returns>
        /// <remarks>
        /// The <paramref name="hWnd" /> parameter is a handle to a window.
        /// The function checks if the window associated with the handle still exists.
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);

        /// <summary>
        /// Sets the cue banner of the specified <paramref name="textBox" />  to the
        /// specified <paramref name="cueText" />.
        /// </summary>
        /// <param name="textBox">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.TextBox" /> that refers to the textbox for
        /// which cue text is to be set.
        /// </param>
        /// <param name="cueText">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// contains the cue text.
        /// <para />
        /// Pass the <see cref="F:System.String.Empty" /> value to remove the cue text.
        /// </param>
        public static void SetCueBanner(this TextBox textBox, string cueText)
        {
            try
            {
                if (textBox == null) return;
                if (textBox.IsDisposed) return;
                if (!IsWindow(textBox.Handle)) return;
                if (string.IsNullOrWhiteSpace(cueText)) return;

                SendMessage(
                    textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, cueText
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Sends the specified message to a window or windows.
        /// <para />
        /// The <c>SendMessage</c> function calls the window procedure for the specified
        /// window and does not return until the window procedure has processed the
        /// message.
        /// </summary>
        /// <param name="hWnd">
        /// (Required.) A handle to the window whose window procedure
        /// will receive the message.
        /// </param>
        /// <param name="Msg">(Required.) The message to be sent.</param>
        /// <param name="wParam">(Required.) Additional message-specific information.</param>
        /// <param name="lParam">
        /// (Required.) Additional message-specific information,
        /// passed as a string.
        /// </param>
        /// <returns>
        /// The result of the message processing, which depends on the message sent.
        /// </returns>
        /// <remarks>
        /// Use this method to send messages directly to a window's window procedure,
        /// bypassing the system's message queue.
        /// </remarks>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint Msg,
            IntPtr wParam,
            string lParam
        );
    }
}