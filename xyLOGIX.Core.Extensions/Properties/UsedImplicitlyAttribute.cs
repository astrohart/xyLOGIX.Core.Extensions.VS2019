using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class UsedImplicitlyAttribute : Attribute
    {
        public UsedImplicitlyAttribute() : this(
            ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default
        )
        { }

        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags) :
            this(useKindFlags, ImplicitUseTargetFlags.Default)
        { }

        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags) :
            this(ImplicitUseKindFlags.Default, targetFlags)
        { }

        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags,
            ImplicitUseTargetFlags targetFlags)
        {
            UseKindFlags = useKindFlags;
            TargetFlags = targetFlags;
        }

        public ImplicitUseTargetFlags TargetFlags { get; }
        public ImplicitUseKindFlags UseKindFlags { get; }
    }
}