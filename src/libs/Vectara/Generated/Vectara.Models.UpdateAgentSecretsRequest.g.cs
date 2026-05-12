
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Patch the agent's secrets. Names present in the map are added or replaced; names absent from the map are left unchanged.<br/>
    /// A name mapped to `null` is removed. Stored encrypted at rest using the agent's encryption key.
    /// </summary>
    public sealed partial class UpdateAgentSecretsRequest
    {
        /// <summary>
        /// Map of secret name to plaintext value (or `null` to remove). Names not in the map are not touched.<br/>
        /// Example: {"jira_api_token":"ATATT3xFf...","old_token_to_remove":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
        /// </summary>
        /// <example>{"jira_api_token":"ATATT3xFf...","old_token_to_remove":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string?> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSecretsRequest" /> class.
        /// </summary>
        /// <param name="secrets">
        /// Map of secret name to plaintext value (or `null` to remove). Names not in the map are not touched.<br/>
        /// Example: {"jira_api_token":"ATATT3xFf...","old_token_to_remove":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentSecretsRequest(
            global::System.Collections.Generic.Dictionary<string, string?> secrets)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSecretsRequest" /> class.
        /// </summary>
        public UpdateAgentSecretsRequest()
        {
        }

    }
}