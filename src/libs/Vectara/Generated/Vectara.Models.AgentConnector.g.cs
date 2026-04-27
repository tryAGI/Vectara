
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A connector that allows an agent to receive events from external platforms like Slack.
    /// </summary>
    public sealed partial class AgentConnector
    {
        /// <summary>
        /// The unique identifier for the connector.<br/>
        /// Example: con_slack_support
        /// </summary>
        /// <example>con_slack_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// The human-readable name of the connector.<br/>
        /// Example: Customer Support Slack Channel
        /// </summary>
        /// <example>Customer Support Slack Channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
        /// </summary>
        /// <example>Receives customer support messages from the</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of connector.<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentConnectorTypeJsonConverter))]
        public global::Vectara.AgentConnectorType Type { get; set; }

        /// <summary>
        /// The current status of the connector.<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </summary>
        /// <default>global::Vectara.AgentConnectorStatus.Active</default>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentConnectorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentConnectorStatus Status { get; set; } = global::Vectara.AgentConnectorStatus.Active;

        /// <summary>
        /// Detailed status message (e.g., error description or success confirmation).<br/>
        /// Example: Slack authentication successful
        /// </summary>
        /// <example>Slack authentication successful</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the connector.<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </summary>
        /// <example>{"priority":"high","department":"customer_service"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the connector is currently enabled and can receive events.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Configuration for different types of connectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.SlackConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Timestamp when the connector was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the connector was last updated.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </summary>
        /// <example>2024-01-16T14:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConnector" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the connector.<br/>
        /// Example: con_slack_support
        /// </param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of the connector.<br/>
        /// Example: Customer Support Slack Channel
        /// </param>
        /// <param name="status">
        /// The current status of the connector.<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </param>
        /// <param name="enabled">
        /// Whether the connector is currently enabled and can receive events.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="configuration">
        /// Configuration for different types of connectors.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the connector was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
        /// </param>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Example: slack
        /// </param>
        /// <param name="statusMessage">
        /// Detailed status message (e.g., error description or success confirmation).<br/>
        /// Example: Slack authentication successful
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the connector.<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the connector was last updated.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConnector(
            string id,
            string agentKey,
            string name,
            global::Vectara.AgentConnectorStatus status,
            bool enabled,
            global::Vectara.SlackConnectorConfiguration configuration,
            global::System.DateTime createdAt,
            string? description,
            global::Vectara.AgentConnectorType type,
            string? statusMessage,
            object? metadata,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConnector" /> class.
        /// </summary>
        public AgentConnector()
        {
        }
    }
}