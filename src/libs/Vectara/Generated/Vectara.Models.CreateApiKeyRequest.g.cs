
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new API key for authenticating with the platform.
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// The human-readable name of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ApiKeyRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ApiKeyRole ApiKeyRole { get; set; }

        /// <summary>
        /// Corpora this API key has roles on if it is not a Personal API key. This property should be null or missing if this `api_key_role` is `personal`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_keys")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the API key.
        /// </param>
        /// <param name="apiKeyRole">
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </param>
        /// <param name="corpusKeys">
        /// Corpora this API key has roles on if it is not a Personal API key. This property should be null or missing if this `api_key_role` is `personal`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyRequest(
            string name,
            global::Vectara.ApiKeyRole apiKeyRole,
            global::System.Collections.Generic.IList<string>? corpusKeys)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiKeyRole = apiKeyRole;
            this.CorpusKeys = corpusKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }
    }
}