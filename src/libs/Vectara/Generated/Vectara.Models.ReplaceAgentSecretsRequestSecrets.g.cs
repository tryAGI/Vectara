
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Map of secret name to plaintext value.<br/>
    /// Example: {"jira_api_token":"ATATT3xFf..."}
    /// </summary>
    public sealed partial class ReplaceAgentSecretsRequestSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}