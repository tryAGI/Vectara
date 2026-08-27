
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The role of the API key. A `personal` key has the same permissions as its owner. A `serving` API key can only perform query type requests on its corpora, and a `serving_and_indexing` key can perform both indexing and query type requests; these two roles are deprecated for creation — assign roles with `api_roles` instead.
    /// </summary>
    public enum ApiKeyRole
    {
        /// <summary>
        ///
        /// </summary>
        Personal,
        /// <summary>
        ///
        /// </summary>
        Serving,
        /// <summary>
        ///
        /// </summary>
        ServingAndIndexing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyRole value)
        {
            return value switch
            {
                ApiKeyRole.Personal => "personal",
                ApiKeyRole.Serving => "serving",
                ApiKeyRole.ServingAndIndexing => "serving_and_indexing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyRole? ToEnum(string value)
        {
            return value switch
            {
                "personal" => ApiKeyRole.Personal,
                "serving" => ApiKeyRole.Serving,
                "serving_and_indexing" => ApiKeyRole.ServingAndIndexing,
                _ => null,
            };
        }
    }
}