using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    /// <inheritdoc />
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspMvcAreaAttribute : PathReferenceAttribute
    {
        public AspMvcAreaAttribute()
        {
        }

        public AspMvcAreaAttribute([NotNull] string anonymousProperty)
        {
            AnonymousProperty = anonymousProperty;
        }

        [NotNull] public string AnonymousProperty { get; }
    }
}