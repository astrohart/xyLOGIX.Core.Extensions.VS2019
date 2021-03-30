using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class AspMvcSupressViewErrorAttribute : Attribute { }
}