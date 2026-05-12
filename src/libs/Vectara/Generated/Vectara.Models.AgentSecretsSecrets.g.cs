
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Map of secret name to masked value.<br/>
    /// Example: {"jira_api_token":"****","slack_webhook":"****"}
    /// </summary>
    public sealed partial class AgentSecretsSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}