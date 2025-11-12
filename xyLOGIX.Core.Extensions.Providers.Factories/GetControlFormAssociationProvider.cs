using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;
using xyLOGIX.Core.Extensions.Providers.Interfaces;

namespace xyLOGIX.Core.Extensions.Providers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetControlFormAssociationProvider
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider" />
        /// interface.
        /// </returns>
        [return: NotLogged]
        [DebuggerStepThrough]
        public static IControlFormAssociationProvider SoleInstance()
            => ControlFormAssociationProvider.Instance;
    }
}