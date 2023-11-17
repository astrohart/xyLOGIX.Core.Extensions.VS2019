using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Core.Extensions.Providers.Interfaces;

namespace xyLOGIX.Core.Extensions.Providers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider" />
    /// interface.
    /// </summary>
    public static class GetControlFormAssociationProvider
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Core.Extensions.Providers.Factories.GetControlFormAssociationProvider" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetControlFormAssociationProvider() { }

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
        public static IControlFormAssociationProvider SoleInstance()
            => ControlFormAssociationProvider.Instance;
    }
}