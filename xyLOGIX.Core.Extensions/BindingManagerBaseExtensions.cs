using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    public static class BindingManagerBaseExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.BindingManagerBaseExtensions" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static BindingManagerBaseExtensions() { }

        public static void SuspendTwoWayBinding(
            this BindingManagerBase bindingManager
        )
        {
            try
            {
                if (bindingManager == null) return;

                foreach (Binding b in bindingManager.Bindings)
                    b.DataSourceUpdateMode = DataSourceUpdateMode.Never;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        public static void UpdateDataBoundObject(
            this BindingManagerBase bindingManager
        )
        {
            try
            {
                if (bindingManager == null) return;

                foreach (Binding b in bindingManager.Bindings)
                {
                    b.DataSourceUpdateMode =
                        DataSourceUpdateMode.OnPropertyChanged;
                    b.WriteValue();
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}