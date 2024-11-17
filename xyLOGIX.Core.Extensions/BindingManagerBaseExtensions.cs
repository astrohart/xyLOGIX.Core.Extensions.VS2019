using System;
using System.Windows.Forms;
using Core.Logging;
using Core.Logging.Constants;
using Core.Logging.Events;

namespace xyLOGIX.Core.Extensions
{
    public static class BindingManagerBaseExtensions
    {
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