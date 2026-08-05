
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The A2A v0.3 Agent Card. Returned from `GET /v2/agents/{agent_key}/.well-known/agent-card.json` and `GET /v2/agents/{agent_key}/v1/card`. The card's `url` advertises the JSON-RPC, gRPC, or HTTP+JSON RPC endpoint per `preferredTransport`. `additionalInterfaces` lists other supported transports.
    /// </summary>
    public sealed partial class A2aV03AgentCard
    {
        /// <summary>
        /// The version of the A2A protocol this agent supports (e.g. `0.3.0`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolVersion")]
        public string? ProtocolVersion { get; set; }

        /// <summary>
        /// Human-readable name of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// URL of the agent's preferred RPC endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Transport of the preferred endpoint. If empty, defaults to `JSONRPC`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferredTransport")]
        public string? PreferredTransport { get; set; }

        /// <summary>
        /// Additional transport endpoints supported beyond `url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalInterfaces")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentInterface>? AdditionalInterfaces { get; set; }

        /// <summary>
        /// Identifies the organization providing the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::Vectara.A2aV03AgentProvider? Provider { get; set; }

        /// <summary>
        /// Version string of the agent implementation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// URL of the agent's documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Capabilities the v0.3 agent advertises.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV03AgentCapabilities Capabilities { get; set; }

        /// <summary>
        /// Security schemes the agent supports, keyed by scheme name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securitySchemes")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? SecuritySchemes { get; set; }

        /// <summary>
        /// Security requirements for the agent. Each entry maps scheme names to scope lists. Entries are alternatives. All schemes in one entry apply together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Security { get; set; }

        /// <summary>
        /// Default media types the agent accepts as input across all skills.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultInputModes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DefaultInputModes { get; set; }

        /// <summary>
        /// Default media types the agent produces as output across all skills.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultOutputModes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DefaultOutputModes { get; set; }

        /// <summary>
        /// The skills the agent advertises.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentSkill> Skills { get; set; }

        /// <summary>
        /// True if the agent serves an extended card requiring authentication.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsAuthenticatedExtendedCard")]
        public bool? SupportsAuthenticatedExtendedCard { get; set; }

        /// <summary>
        /// JWS signatures over the agent card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatures")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentCardSignature>? Signatures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AgentCard" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name of the agent.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the agent.
        /// </param>
        /// <param name="url">
        /// URL of the agent's preferred RPC endpoint.
        /// </param>
        /// <param name="version">
        /// Version string of the agent implementation.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities the v0.3 agent advertises.
        /// </param>
        /// <param name="defaultInputModes">
        /// Default media types the agent accepts as input across all skills.
        /// </param>
        /// <param name="defaultOutputModes">
        /// Default media types the agent produces as output across all skills.
        /// </param>
        /// <param name="skills">
        /// The skills the agent advertises.
        /// </param>
        /// <param name="protocolVersion">
        /// The version of the A2A protocol this agent supports (e.g. `0.3.0`).
        /// </param>
        /// <param name="preferredTransport">
        /// Transport of the preferred endpoint. If empty, defaults to `JSONRPC`.
        /// </param>
        /// <param name="additionalInterfaces">
        /// Additional transport endpoints supported beyond `url`.
        /// </param>
        /// <param name="provider">
        /// Identifies the organization providing the agent.
        /// </param>
        /// <param name="documentationUrl">
        /// URL of the agent's documentation.
        /// </param>
        /// <param name="securitySchemes">
        /// Security schemes the agent supports, keyed by scheme name.
        /// </param>
        /// <param name="security">
        /// Security requirements for the agent. Each entry maps scheme names to scope lists. Entries are alternatives. All schemes in one entry apply together.
        /// </param>
        /// <param name="supportsAuthenticatedExtendedCard">
        /// True if the agent serves an extended card requiring authentication.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="signatures">
        /// JWS signatures over the agent card.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03AgentCard(
            string name,
            string description,
            string url,
            string version,
            global::Vectara.A2aV03AgentCapabilities capabilities,
            global::System.Collections.Generic.IList<string> defaultInputModes,
            global::System.Collections.Generic.IList<string> defaultOutputModes,
            global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentSkill> skills,
            string? protocolVersion,
            string? preferredTransport,
            global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentInterface>? additionalInterfaces,
            global::Vectara.A2aV03AgentProvider? provider,
            string? documentationUrl,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? securitySchemes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? security,
            bool? supportsAuthenticatedExtendedCard,
            global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentCardSignature>? signatures)
        {
            this.ProtocolVersion = protocolVersion;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PreferredTransport = preferredTransport;
            this.AdditionalInterfaces = additionalInterfaces;
            this.Provider = provider;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DocumentationUrl = documentationUrl;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.SecuritySchemes = securitySchemes;
            this.Security = security;
            this.DefaultInputModes = defaultInputModes ?? throw new global::System.ArgumentNullException(nameof(defaultInputModes));
            this.DefaultOutputModes = defaultOutputModes ?? throw new global::System.ArgumentNullException(nameof(defaultOutputModes));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
            this.SupportsAuthenticatedExtendedCard = supportsAuthenticatedExtendedCard;
            this.Signatures = signatures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AgentCard" /> class.
        /// </summary>
        public A2aV03AgentCard()
        {
        }

    }
}