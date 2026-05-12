
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Map of secret name to plaintext value (or `null` to remove). Names not in the map are not touched.<br/>
    /// Example: {"jira_api_token":"ATATT3xFf...","old_token_to_remove":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
    /// </summary>
    public sealed partial class UpdateAgentSecretsRequestSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}