
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Agent-scoped secrets for the agent. On read, values are masked (`****`) — plaintext is never returned.<br/>
    /// Reference values from a tool's `argument_override` via `{"$ref": "agent.secrets.&lt;name&gt;"}`.
    /// </summary>
    public sealed partial class AgentSecrets
    {
        /// <summary>
        /// Map of secret name to masked value.<br/>
        /// Example: {"jira_api_token":"****","slack_webhook":"****"}
        /// </summary>
        /// <example>{"jira_api_token":"****","slack_webhook":"****"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSecrets" /> class.
        /// </summary>
        /// <param name="secrets">
        /// Map of secret name to masked value.<br/>
        /// Example: {"jira_api_token":"****","slack_webhook":"****"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSecrets(
            global::System.Collections.Generic.Dictionary<string, string> secrets)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSecrets" /> class.
        /// </summary>
        public AgentSecrets()
        {
        }

    }
}