
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A Wolken knowledge-base article lifecycle status.
    /// </summary>
    public enum WolkenArticleStatus
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Draft,
        /// <summary>
        ///
        /// </summary>
        Published,
        /// <summary>
        ///
        /// </summary>
        Retired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WolkenArticleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WolkenArticleStatus value)
        {
            return value switch
            {
                WolkenArticleStatus.Delete => "delete",
                WolkenArticleStatus.Draft => "draft",
                WolkenArticleStatus.Published => "published",
                WolkenArticleStatus.Retired => "retired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WolkenArticleStatus? ToEnum(string value)
        {
            return value switch
            {
                "delete" => WolkenArticleStatus.Delete,
                "draft" => WolkenArticleStatus.Draft,
                "published" => WolkenArticleStatus.Published,
                "retired" => WolkenArticleStatus.Retired,
                _ => null,
            };
        }
    }
}