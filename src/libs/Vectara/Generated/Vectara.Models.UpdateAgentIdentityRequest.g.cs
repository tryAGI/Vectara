
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Update the agent's identity. All fields are optional — only provided fields are changed.<br/>
    /// Setting `mode` to `manual` freezes roles. The platform will no longer recompute roles when the agent's tool configuration changes.<br/>
    /// Setting `mode` to `auto` resumes platform-managed roles. The platform will immediately resync roles to match the current tool configuration. Any provided role fields are ignored in auto mode.
    /// </summary>
    public sealed partial class UpdateAgentIdentityRequest
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
        public global::Vectara.AgentIdentityMode? Mode { get; set; }

        /// <summary>
        /// Customer-level roles to assign. Only applied in `manual` mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Corpus-specific roles to assign. Only applied in `manual` mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? CorpusRoles { get; set; }

        /// <summary>
        /// Agent-specific roles to assign. Only applied in `manual` mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentRole>? AgentRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentIdentityRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// The role management mode of the agent's identity.<br/>
        /// - `auto`: The platform keeps roles in sync with the agent's tool configuration. When tools change, roles are automatically recomputed.<br/>
        /// - `manual`: Roles are user-managed. The platform will not modify roles when the agent is updated.<br/>
        /// Example: auto
        /// </param>
        /// <param name="apiRoles">
        /// Customer-level roles to assign. Only applied in `manual` mode.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific roles to assign. Only applied in `manual` mode.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific roles to assign. Only applied in `manual` mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentIdentityRequest(
            global::Vectara.AgentIdentityMode? mode,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles,
            global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::Vectara.AgentRole>? agentRoles)
        {
            this.Mode = mode;
            this.ApiRoles = apiRoles;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentIdentityRequest" /> class.
        /// </summary>
        public UpdateAgentIdentityRequest()
        {
        }
    }
}