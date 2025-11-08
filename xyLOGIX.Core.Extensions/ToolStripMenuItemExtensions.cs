using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for
    /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> controls.
    /// </summary>
    public static class ToolStripMenuItemExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions" />
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
        static ToolStripMenuItemExtensions() { }

        /// <summary>
        /// Determines whether the specified <paramref name="item" /> contains a menu item
        /// with the specified <paramref name="name" />.
        /// </summary>
        /// <param name="item">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that is the menu item
        /// whose drop-down item(s) are to be searched.
        /// </param>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the menu
        /// item to search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a drop-down menu item having the specified
        /// <paramref name="name" /> is found in the drop-down items of the specified
        /// <paramref name="item" />; <see langword="false" /> otherwise.
        /// </returns>
        public static bool ContainsMenuItemNamed(
            this ToolStripMenuItem item,
            string name
        )
        {
            var result = false;

            try
            {
                if (item == null) return result;
                if (item.IsDisposed) return result;
                if (string.IsNullOrWhiteSpace(name)) return result;
                if (!item.HasDropDownItems) return result;

                foreach (var dropDownItem in item
                                             .DropDownItems
                                             .OfType<ToolStripMenuItem>()
                                             .ToArray())
                {
                    if (dropDownItem == null) continue;
                    if (dropDownItem.IsDisposed) continue;
                    if (!name.Equals(
                            dropDownItem.Name,
                            StringComparison.OrdinalIgnoreCase
                        )) continue;

                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="menu" /> contains a menu item
        /// with the specified <paramref name="name" />.
        /// </summary>
        /// <param name="menu">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that is the menu
        /// whose drop-down menu(s) are to be searched.
        /// </param>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the menu
        /// item to search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a drop-down menu item having the specified
        /// <paramref name="name" /> is found in the drop-down items of the specified
        /// <paramref name="menu" />; <see langword="false" /> otherwise.
        /// </returns>
        public static bool ContainsMenuItemNamed(
            this MenuStrip menu,
            string name
        )
        {
            var result = false;

            try
            {
                if (menu == null) return result;
                if (menu.IsDisposed) return result;
                if (string.IsNullOrWhiteSpace(name)) return result;
                if (menu.Items.Count <= 0) return result;

                foreach (var dropDownItem in menu
                                             .Items.OfType<ToolStripMenuItem>()
                                             .ToArray())
                {
                    if (dropDownItem == null) continue;
                    if (dropDownItem.IsDisposed) continue;
                    if (!name.Equals(
                            dropDownItem.Name,
                            StringComparison.OrdinalIgnoreCase
                        )) continue;

                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Among the drop-down items of the specified <paramref name="menu" />,
        /// gets a reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that has the specified
        /// <paramref name="name" />.
        /// </summary>
        /// <param name="menu">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that is the menu
        /// whose drop-down menu(s) are to be searched.
        /// </param>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the menu
        /// item to search for.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that refers to the
        /// matching menu item; otherwise, a <see langword="null" /> reference is
        /// returned.
        /// </returns>
        public static ToolStripMenuItem GetMenuItemNamed(
            this ToolStripMenuItem menu,
            string name
        )
        {
            ToolStripMenuItem result = default;

            try
            {
                if (menu == null) return result;
                if (menu.IsDisposed) return result;
                if (string.IsNullOrWhiteSpace(name)) return result;
                if (!menu.HasDropDownItems) return result;

                foreach (var dropDownItem in menu
                                             .DropDownItems
                                             .OfType<ToolStripMenuItem>()
                                             .ToArray())
                {
                    if (dropDownItem == null) continue;
                    if (dropDownItem.IsDisposed) continue;
                    if (!name.Equals(
                            dropDownItem.Name,
                            StringComparison.OrdinalIgnoreCase
                        )) continue;

                    result = dropDownItem;
                    break;
                }
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
        /// Among the drop-down items of the specified <paramref name="menu" />, gets a
        /// reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that has the specified
        /// <paramref name="name" />.
        /// </summary>
        /// <param name="menu">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that is the menu
        /// whose drop-down menu(s) are to be searched.
        /// </param>
        /// <param name="name">
        /// (Required.) A <see cref="T:System.String" /> containing the name of the menu
        /// item to search for.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of
        /// <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> that refers to the
        /// matching menu item; otherwise, a <see langword="null" /> reference is returned.
        /// </returns>
        public static ToolStripMenuItem GetMenuItemNamed(
            this MenuStrip menu,
            string name
        )
        {
            ToolStripMenuItem result = default;

            try
            {
                if (menu == null) return result;
                if (menu.IsDisposed) return result;
                if (string.IsNullOrWhiteSpace(name)) return result;
                if (menu.Items.Count <= 0) return result;

                foreach (var dropDownItem in menu
                                             .Items.OfType<ToolStripMenuItem>()
                                             .ToArray())
                {
                    if (dropDownItem == null) continue;
                    if (dropDownItem.IsDisposed) continue;
                    if (!name.Equals(
                            dropDownItem.Name,
                            StringComparison.OrdinalIgnoreCase
                        )) continue;

                    result = dropDownItem;
                    break;
                }
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