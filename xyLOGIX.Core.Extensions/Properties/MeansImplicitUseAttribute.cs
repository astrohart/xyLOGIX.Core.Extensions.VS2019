using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MeansImplicitUseAttribute : Attribute
    {
        public MeansImplicitUseAttribute() : this(
            ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default
        )
        { }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags) :
            this(useKindFlags, ImplicitUseTargetFlags.Default)
        { }

        public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags) :
            this(ImplicitUseKindFlags.Default, targetFlags)
        { }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags,
            ImplicitUseTargetFlags targetFlags)
        {
            UseKindFlags = useKindFlags;
            TargetFlags = targetFlags;
        }

        [UsedImplicitly] public ImplicitUseTargetFlags TargetFlags { get; }

        [UsedImplicitly] public ImplicitUseKindFlags UseKindFlags { get; }
    }
}