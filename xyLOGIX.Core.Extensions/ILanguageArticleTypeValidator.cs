namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of a validator of
    /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> enumeration
    /// values.
    /// </summary>
    /// <remarks>
    /// Specifically, objects that implement this interface ascertain whether
    /// the values of variables fall within the value set that is defined by the
    /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> enumeration.
    /// </remarks>
    public interface ILanguageArticleTypeValidator
    {
        /// <summary>
        /// Determines whether the language article <paramref name="type" /> value
        /// passed is within the value set that is defined by the
        /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> enumeration.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:xyLOGIX.Core.Extensions.LanguageArticleType" /> value(s) that is
        /// to
        /// be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the language article
        /// <paramref name="type" /> falls within the defined value set;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(LanguageArticleType type);
    }
}