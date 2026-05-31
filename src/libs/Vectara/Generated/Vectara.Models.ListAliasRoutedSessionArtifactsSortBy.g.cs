
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum ListAliasRoutedSessionArtifactsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAliasRoutedSessionArtifactsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasRoutedSessionArtifactsSortBy value)
        {
            return value switch
            {
                ListAliasRoutedSessionArtifactsSortBy.CreatedAt => "created_at",
                ListAliasRoutedSessionArtifactsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasRoutedSessionArtifactsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListAliasRoutedSessionArtifactsSortBy.CreatedAt,
                "updated_at" => ListAliasRoutedSessionArtifactsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}