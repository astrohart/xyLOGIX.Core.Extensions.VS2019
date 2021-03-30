﻿using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [AttributeUsage(
        AttributeTargets.Method | AttributeTargets.Parameter |
        AttributeTargets.Property | AttributeTargets.Delegate |
        AttributeTargets.Field
    )]
    public sealed class NotNullAttribute : Attribute { }
}