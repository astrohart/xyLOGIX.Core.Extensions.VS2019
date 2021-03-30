using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [AttributeUsage(
        AttributeTargets.Interface | AttributeTargets.Class |
        AttributeTargets.Struct
    )]
    public sealed class CannotApplyEqualityOperatorAttribute : Attribute { }
}