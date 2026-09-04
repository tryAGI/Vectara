
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for updating an existing agent connector. An omitted<br/>
    /// top-level field (`name`, `description`, `metadata`, `enabled`) is left<br/>
    /// unchanged, and an omitted `configuration` leaves the stored configuration<br/>
    /// untouched. A supplied Slack, Google Chat, or Zoom `configuration` replaces<br/>
    /// the stored one in full, exactly as on create; a supplied widget<br/>
    /// `configuration` updates partially, keeping the fields it omits. The<br/>
    /// connector's `type` cannot change, and platform-generated fields such as the<br/>
    /// Zoom connector's `connector_token` are preserved.
    /// </summary>
    public sealed partial class UpdateAgentConnectorRequest
    {
        /// <summary>
        /// The human-readable name of the connector.<br/>
        /// Example: Updated Customer Support Slack Channel
        /// </summary>
        /// <example>Updated Customer Support Slack Channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A detailed description of what this connector does.<br/>
        /// Example: Updated description for the Slack connector
        /// </summary>
        /// <example>Updated description for the Slack connector</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the connector.<br/>
        /// Example: {"priority":"medium","department":"customer_service","last_reviewed":"2024-01-15"}
        /// </summary>
        /// <example>{"priority":"medium","department":"customer_service","last_reviewed":"2024-01-15"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the connector is enabled.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Write view of a connector's configuration, supplied on update. Discriminated by `type`, which must equal the connector's stored type.<br/>
        /// Slack, Google Chat, and Zoom configurations are supplied in full and replace the stored configuration wholesale, exactly as on create; caller-omitted platform-generated fields (such as the Zoom `connector_token`) are preserved.<br/>
        /// A widget configuration is the exception: it updates partially, so a supplied field replaces the stored one while an omitted field keeps it — see `UpdateWidgetConnectorConfiguration`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.UpdateConnectorConfigurationJsonConverter))]
        public global::Vectara.UpdateConnectorConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentConnectorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the connector.<br/>
        /// Example: Updated Customer Support Slack Channel
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Updated description for the Slack connector
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the connector.<br/>
        /// Example: {"priority":"medium","department":"customer_service","last_reviewed":"2024-01-15"}
        /// </param>
        /// <param name="enabled">
        /// Whether the connector is enabled.<br/>
        /// Example: false
        /// </param>
        /// <param name="configuration">
        /// Write view of a connector's configuration, supplied on update. Discriminated by `type`, which must equal the connector's stored type.<br/>
        /// Slack, Google Chat, and Zoom configurations are supplied in full and replace the stored configuration wholesale, exactly as on create; caller-omitted platform-generated fields (such as the Zoom `connector_token`) are preserved.<br/>
        /// A widget configuration is the exception: it updates partially, so a supplied field replaces the stored one while an omitted field keeps it — see `UpdateWidgetConnectorConfiguration`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentConnectorRequest(
            string? name,
            string? description,
            object? metadata,
            bool? enabled,
            global::Vectara.UpdateConnectorConfiguration? configuration)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentConnectorRequest" /> class.
        /// </summary>
        public UpdateAgentConnectorRequest()
        {
        }

    }
}