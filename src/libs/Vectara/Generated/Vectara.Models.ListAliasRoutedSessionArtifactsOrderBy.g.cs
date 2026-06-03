
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListAliasRoutedSessionArtifactsOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAliasRoutedSessionArtifactsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAliasRoutedSessionArtifactsOrderBy value)
        {
            return value switch
            {
                ListAliasRoutedSessionArtifactsOrderBy.Asc => "asc",
                ListAliasRoutedSessionArtifactsOrderBy.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAliasRoutedSessionArtifactsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAliasRoutedSessionArtifactsOrderBy.Asc,
                "desc" => ListAliasRoutedSessionArtifactsOrderBy.Desc,
                _ => null,
            };
        }
    }
}