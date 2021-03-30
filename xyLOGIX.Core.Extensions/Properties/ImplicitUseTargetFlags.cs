using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [Flags]
    public enum ImplicitUseTargetFlags
    {
        Default = Itself,
        Itself = 1,

        Members = 2,

        WithMembers = Itself | Members
    }
}