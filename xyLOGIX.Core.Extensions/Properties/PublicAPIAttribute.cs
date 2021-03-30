using System;

namespace xyLOGIX.Core.Extensions.Properties
{
    [MeansImplicitUse]
    public sealed class PublicAPIAttribute : Attribute
    {
        public PublicAPIAttribute()
        {
        }

        public PublicAPIAttribute([NotNull] string comment)
        {
            Comment = comment;
        }

        [NotNull] public string Comment { get; }
    }
}