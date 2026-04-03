
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The identity associated with an agent, including its roles and management mode.
    /// </summary>
    public sealed partial class AgentIdentity
    {
        /// <summary>
        /// The role management mode of the agent's identity.<br/>
        /// - `auto`: The platform keeps roles in sync with the agent's tool configuration. When tools change, roles are automatically recomputed.<br/>
        /// - `manual`: Roles are user-managed. The platform will not modify roles when the agent is updated.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentIdentityModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentIdentityMode Mode { get; set; }

        /// <summary>
        /// The OAuth2 client ID of the agent's service account.<br/>
        /// Included only in responses<br/>
        /// Example: abc123def456
        /// </summary>
        /// <default>default!</default>
        /// <example>abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// Customer-level roles assigned to this identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.ApiRole> ApiRoles { get; set; }

        /// <summary>
        /// Corpus-specific role assignments for this identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.CorpusRole> CorpusRoles { get; set; }

        /// <summary>
        /// Agent-specific role assignments for this identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentRole> AgentRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIdentity" /> class.
        /// </summary>
        /// <param name="mode">
        /// The role management mode of the agent's identity.<br/>
        /// - `auto`: The platform keeps roles in sync with the agent's tool configuration. When tools change, roles are automatically recomputed.<br/>
        /// - `manual`: Roles are user-managed. The platform will not modify roles when the agent is updated.<br/>
        /// Example: auto
        /// </param>
        /// <param name="apiRoles">
        /// Customer-level roles assigned to this identity.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific role assignments for this identity.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific role assignments for this identity.
        /// </param>
        /// <param name="clientId">
        /// The OAuth2 client ID of the agent's service account.<br/>
        /// Included only in responses<br/>
        /// Example: abc123def456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentIdentity(
            global::Vectara.AgentIdentityMode mode,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole> apiRoles,
            global::System.Collections.Generic.IList<global::Vectara.CorpusRole> corpusRoles,
            global::System.Collections.Generic.IList<global::Vectara.AgentRole> agentRoles,
            string clientId = default!)
        {
            this.Mode = mode;
            this.ClientId = clientId;
            this.ApiRoles = apiRoles ?? throw new global::System.ArgumentNullException(nameof(apiRoles));
            this.CorpusRoles = corpusRoles ?? throw new global::System.ArgumentNullException(nameof(corpusRoles));
            this.AgentRoles = agentRoles ?? throw new global::System.ArgumentNullException(nameof(agentRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIdentity" /> class.
        /// </summary>
        public AgentIdentity()
        {
        }
    }
}