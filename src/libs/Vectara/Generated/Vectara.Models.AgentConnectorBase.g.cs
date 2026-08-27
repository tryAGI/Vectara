
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Properties shared by every connector read view.
    /// </summary>
    public sealed partial class AgentConnectorBase
    {
        /// <summary>
        /// The unique identifier for the connector.<br/>
        /// Example: con_3Kx9QpVn2mZr8YbLc5TdWe
        /// </summary>
        /// <example>con_3Kx9QpVn2mZr8YbLc5TdWe</example>
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
        /// The current status of the connector.<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </summary>
        /// <default>global::Vectara.ConnectorStatus.Active</default>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ConnectorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ConnectorStatus Status { get; set; } = global::Vectara.ConnectorStatus.Active;

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
        /// Read view of a connector's configuration, as returned by GET and list<br/>
        /// endpoints. Contains the secrets supplied at create time alongside<br/>
        /// platform-derived display fields:<br/>
        /// - Slack exposes `webhook_path`<br/>
        /// - gchat exposes `audience_url` and `client_email`<br/>
        /// - zoom exposes the generated `connector_token` and `webhook_path`<br/>
        /// - widget exposes `bootstrap_path`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ConnectorConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ConnectorConfiguration Configuration { get; set; }

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
        /// Timestamp of the most recently received inbound webhook for this<br/>
        /// connector, regardless of outcome. Absent until the first webhook<br/>
        /// arrives.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </summary>
        /// <example>2024-01-16T14:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_webhook_at")]
        public global::System.DateTime? LastWebhookAt { get; set; }

        /// <summary>
        /// Outcome of the most recently received inbound webhook. Absent until the<br/>
        /// first webhook arrives. Values:<br/>
        /// - `success`: the webhook verified and the event was accepted.<br/>
        /// - `jwt_verification_failed`: the bearer token was missing or could not be verified.<br/>
        /// - `audience_mismatch`: the token was valid but its aud did not equal the connector's audience_url.<br/>
        /// - `auth_failed`: the inbound request lacked or did not match the connector's authentication secret.<br/>
        /// - `missing_signature`: the request lacked the signature needed for an asynchronous reply.<br/>
        /// - `missing_engagement`: the request lacked the engagement identifier needed to route the session.<br/>
        /// - `event_parse_failed`: the event body could not be parsed.<br/>
        /// - `internal_error`: an unexpected error occurred after the connector was resolved.<br/>
        /// - `unknown`: the outcome could not be classified.<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_webhook_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ConnectorWebhookStatusJsonConverter))]
        public global::Vectara.ConnectorWebhookStatus? LastWebhookStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConnectorBase" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the connector.<br/>
        /// Example: con_3Kx9QpVn2mZr8YbLc5TdWe
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
        /// Read view of a connector's configuration, as returned by GET and list<br/>
        /// endpoints. Contains the secrets supplied at create time alongside<br/>
        /// platform-derived display fields:<br/>
        /// - Slack exposes `webhook_path`<br/>
        /// - gchat exposes `audience_url` and `client_email`<br/>
        /// - zoom exposes the generated `connector_token` and `webhook_path`<br/>
        /// - widget exposes `bootstrap_path`
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the connector was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
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
        /// <param name="lastWebhookAt">
        /// Timestamp of the most recently received inbound webhook for this<br/>
        /// connector, regardless of outcome. Absent until the first webhook<br/>
        /// arrives.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </param>
        /// <param name="lastWebhookStatus">
        /// Outcome of the most recently received inbound webhook. Absent until the<br/>
        /// first webhook arrives. Values:<br/>
        /// - `success`: the webhook verified and the event was accepted.<br/>
        /// - `jwt_verification_failed`: the bearer token was missing or could not be verified.<br/>
        /// - `audience_mismatch`: the token was valid but its aud did not equal the connector's audience_url.<br/>
        /// - `auth_failed`: the inbound request lacked or did not match the connector's authentication secret.<br/>
        /// - `missing_signature`: the request lacked the signature needed for an asynchronous reply.<br/>
        /// - `missing_engagement`: the request lacked the engagement identifier needed to route the session.<br/>
        /// - `event_parse_failed`: the event body could not be parsed.<br/>
        /// - `internal_error`: an unexpected error occurred after the connector was resolved.<br/>
        /// - `unknown`: the outcome could not be classified.<br/>
        /// Example: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConnectorBase(
            string id,
            string agentKey,
            string name,
            global::Vectara.ConnectorStatus status,
            bool enabled,
            global::Vectara.ConnectorConfiguration configuration,
            global::System.DateTime createdAt,
            string? description,
            string? statusMessage,
            object? metadata,
            global::System.DateTime? updatedAt,
            global::System.DateTime? lastWebhookAt,
            global::Vectara.ConnectorWebhookStatus? lastWebhookStatus)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Configuration = configuration;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastWebhookAt = lastWebhookAt;
            this.LastWebhookStatus = lastWebhookStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConnectorBase" /> class.
        /// </summary>
        public AgentConnectorBase()
        {
        }

    }
}