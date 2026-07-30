
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The A2A v1 Agent Card. The card lists every transport endpoint in `supportedInterfaces`; the first entry is the preferred binding.
    /// </summary>
    public sealed partial class A2aV1AgentCard
    {
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
        /// All transport endpoints supported by the agent; the first entry is the preferred binding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedInterfaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentInterface> SupportedInterfaces { get; set; }

        /// <summary>
        /// Identifies the organization providing the v1 agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::Vectara.A2aV1AgentProvider? Provider { get; set; }

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
        /// Optional capabilities the v1 agent supports, such as streaming and the extended agent card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV1AgentCapabilities Capabilities { get; set; }

        /// <summary>
        /// Security schemes the agent supports, keyed by scheme name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securitySchemes")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? SecuritySchemes { get; set; }

        /// <summary>
        /// List of OR'd security requirements; each entry is a map of scheme name → scope list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityRequirements")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? SecurityRequirements { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentSkill> Skills { get; set; }

        /// <summary>
        /// JWS signatures over the agent card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatures")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentCardSignature>? Signatures { get; set; }

        /// <summary>
        /// URL of the agent's icon image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentCard" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name of the agent.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the agent.
        /// </param>
        /// <param name="supportedInterfaces">
        /// All transport endpoints supported by the agent; the first entry is the preferred binding.
        /// </param>
        /// <param name="version">
        /// Version string of the agent implementation.
        /// </param>
        /// <param name="capabilities">
        /// Optional capabilities the v1 agent supports, such as streaming and the extended agent card.
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
        /// <param name="provider">
        /// Identifies the organization providing the v1 agent.
        /// </param>
        /// <param name="documentationUrl">
        /// URL of the agent's documentation.
        /// </param>
        /// <param name="securitySchemes">
        /// Security schemes the agent supports, keyed by scheme name.
        /// </param>
        /// <param name="securityRequirements">
        /// List of OR'd security requirements; each entry is a map of scheme name → scope list.
        /// </param>
        /// <param name="signatures">
        /// JWS signatures over the agent card.
        /// </param>
        /// <param name="iconUrl">
        /// URL of the agent's icon image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentCard(
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentInterface> supportedInterfaces,
            string version,
            global::Vectara.A2aV1AgentCapabilities capabilities,
            global::System.Collections.Generic.IList<string> defaultInputModes,
            global::System.Collections.Generic.IList<string> defaultOutputModes,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentSkill> skills,
            global::Vectara.A2aV1AgentProvider? provider,
            string? documentationUrl,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.A2aV03SecurityScheme>? securitySchemes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? securityRequirements,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentCardSignature>? signatures,
            string? iconUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SupportedInterfaces = supportedInterfaces ?? throw new global::System.ArgumentNullException(nameof(supportedInterfaces));
            this.Provider = provider;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DocumentationUrl = documentationUrl;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.SecuritySchemes = securitySchemes;
            this.SecurityRequirements = securityRequirements;
            this.DefaultInputModes = defaultInputModes ?? throw new global::System.ArgumentNullException(nameof(defaultInputModes));
            this.DefaultOutputModes = defaultOutputModes ?? throw new global::System.ArgumentNullException(nameof(defaultOutputModes));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
            this.Signatures = signatures;
            this.IconUrl = iconUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentCard" /> class.
        /// </summary>
        public A2aV1AgentCard()
        {
        }

    }
}