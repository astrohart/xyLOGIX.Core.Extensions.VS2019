using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [Flags]
    public enum ImplicitUseKindFlags
    {
        Default = Access | Assign | InstantiatedWithFixedConstructorSignature,

        Access = 1,

        Assign = 2,
        InstantiatedWithFixedConstructorSignature = 4,

        InstantiatedNoFixedConstructorSignature = 8
    }
}