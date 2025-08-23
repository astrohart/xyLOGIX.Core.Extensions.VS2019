using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes <see langword="static" /> extension method(s) for the
    /// <see cref="T:System.ComponentModel.Component" /> class.
    /// </summary>
    public static class ComponentExtensions
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Core.Extensions.ComponentExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ComponentExtensions() { }

        /// <summary>
        /// Determines whether the specified <paramref name="component" /> is set to a
        /// <see langword="null" /> reference or has been disposed.
        /// </summary>
        /// <remarks>
        /// Uses the <see cref="P:System.Windows.Forms.Control.IsDisposed" /> for
        /// WinForms controls and falls back to reflection and a conservative probe for
        /// other Component implementations.
        /// <para />
        /// On any exception the method logs and returns <see langword="true" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public static bool IsNullOrDisposed(
            [NotLogged] this Component component
        )
        {
            var result = false;

            try
            {
                // null -> considered disposed for callers that want to be defensive
                if (component == null)
                {
                    result = true;
                }
                else
                {
                    // Fast path for WinForms controls
                    if (component is Control ctrl)
                    {
                        result = ctrl.IsDisposed;
                    }
                    else
                    {
                        // Reflection: look for public/non-public bool properties named IsDisposed / Disposed
                        var t = component.GetType();
                        var prop =
                            t.GetProperty(
                                "IsDisposed",
                                BindingFlags.Instance | BindingFlags.Public |
                                BindingFlags.NonPublic
                            ) ?? t.GetProperty(
                                "Disposed",
                                BindingFlags.Instance | BindingFlags.Public |
                                BindingFlags.NonPublic
                            );

                        if (prop != null && prop.PropertyType == typeof(bool))
                        {
                            // property getter may throw if object is disposed; catch below
                            result = (bool)prop.GetValue(component);
                        }
                        else
                        {
                            // Reflection: common private field names often used by implementations
                            var foundField = false;
                            foreach (var fieldName in new[]
                                     {
                                         "_disposed", "disposed",
                                         "isDisposed", "m_disposed"
                                     })
                            {
                                var fld = t.GetField(
                                    fieldName,
                                    BindingFlags.Instance |
                                    BindingFlags.NonPublic | BindingFlags.Public
                                );
                                if (fld == null ||
                                    fld.FieldType != typeof(bool)) continue;
                                result = (bool)fld.GetValue(component);
                                foundField = true;
                                break;
                            }

                            if (!foundField)
                            {
                                // Last resort: attempt to touch a benign property and see if ObjectDisposedException is thrown.
                                // If touching throws ObjectDisposedException, treat it as disposed; otherwise assume not disposed.
                                try
                                {
                                    _ = component.Site; // benign probe
                                    result = false;
                                }
                                catch (ObjectDisposedException)
                                {
                                    result = true;
                                }
                                catch
                                {
                                    // If anything else goes wrong, be conservative.
                                    result = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DebugUtils.LogException(ex);

                // Be conservative on unexpected errors.
                result = true;
            }

            return result;
        }
    }
}