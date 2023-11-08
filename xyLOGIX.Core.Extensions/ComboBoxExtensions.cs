using System;
using System.Linq;
using System.Windows.Forms;

namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Exposes static extension methods for instances of <see cref="T:System.Windows.Forms.ComboBox"/>.
    /// </summary>
    public static class ComboBoxExtensions
    {
        /// <summary>
        /// Data-binds an enumeration in code to a <see cref="T:System.Windows.Forms.ComboBox"/>.
        /// </summary>
        /// <typeparam name="T">(Required.) The name of the C# enumeration to be data-bound.</typeparam>
        /// <param name="comboBox">(Required.) Reference to an instance of the <see cref="T:System.Windows.Forms.ComboBox"/> that is to be data-bound.</param>
        /// <param name="defaultSelection">(Required.) Default value to be selected when the form is first displayed.</param>
        public static void BindEnum<T>(
            this ComboBox comboBox,
            T defaultSelection
        ) where T : struct, Enum
        {
            var list = Enum.GetValues(typeof(T))
                           .Cast<Enum>()
                           .Select(
                               value => new
                               {
                                   Description = value.AsString(),
                                   Value = value
                               }
                           )
                           .OrderBy(item => item.Value.ToString())
                           .ToList();

            comboBox.DataSource = list;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";

            // more thread-safe this way
            // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            foreach (var opts in list)
                if (opts.Value.ToString() == defaultSelection.AsString())
                    comboBox.SelectedItem = opts;
        }
    }
}