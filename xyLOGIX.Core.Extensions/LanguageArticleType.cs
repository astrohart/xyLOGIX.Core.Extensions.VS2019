namespace xyLOGIX.Core.Extensions
{
    /// <summary>
    /// Specifies the kind of article, if any, to be inserted before a noun phrase
    /// during phrase rewording.
    /// </summary>
    public enum LanguageArticleType
    {
        /// <summary>
        /// Indicates that no article should be inserted.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that the definite article <c>the</c> should be inserted.
        /// </summary>
        Definite = 1,

        /// <summary>
        /// Indicates that the indefinite article <c>a</c> or <c>an</c> should be inserted,
        /// depending on the starting sound of the following word.
        /// </summary>
        Indefinite = 2,

        /// <summary>
        /// Indicates that a preposition should be inserted, the default being <c>of</c>.
        /// </summary>
        Preposition = 3,

        /// <summary>
        /// Indicates that a preposition should be inserted, the default being <c>of</c>,
        /// followed by the definite article, <c>the</c>.
        /// </summary>
        PrepopsitionWithDefinite = 4,

        /// <summary>
        /// Indicates that a preposition should be inserted, the default being <c>of</c>,
        /// followed by the indefinite article, <c>a</c> or <c>an</c>.
        /// </summary>
        PrepopsitionWithIndefinite = 5,

        /// <summary>
        /// Unknown article type.
        /// </summary>
        Unknown = -1
    }
}