using PostSharp.Patterns.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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
    public static void InvokeIfRequired(this ISynchronizeInvoke obj,
      MethodInvoker message)
    {
      if (!(obj is Control control)) return;

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
  }
}
