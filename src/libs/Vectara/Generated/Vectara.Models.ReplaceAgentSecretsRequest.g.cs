
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request body that replaces the agent's secrets. The submitted map fully replaces the stored set. Names not in the request are removed.<br/>
    /// Secrets are stored encrypted at rest.
    /// </summary>
    public sealed partial class ReplaceAgentSecretsRequest
    {
        /// <summary>
        /// Map of secret name to plaintext value.<br/>
        /// Example: {"jira_api_token":"ATATT3xFf..."}
        /// </summary>
        /// <example>{"jira_api_token":"ATATT3xFf..."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAgentSecretsRequest" /> class.
        /// </summary>
        /// <param name="secrets">
        /// Map of secret name to plaintext value.<br/>
        /// Example: {"jira_api_token":"ATATT3xFf..."}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceAgentSecretsRequest(
            global::System.Collections.Generic.Dictionary<string, string> secrets)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAgentSecretsRequest" /> class.
        /// </summary>
        public ReplaceAgentSecretsRequest()
        {
        }

    }
}