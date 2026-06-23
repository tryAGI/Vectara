
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for updating an existing agent connector. If `configuration`<br/>
    /// is supplied, it fully replaces the existing configuration including any<br/>
    /// caller-supplied secrets. Server-generated fields, such as the Zoom<br/>
    /// connector's `connector_token`, are preserved across updates. If<br/>
    /// `configuration` is omitted, the existing configuration is left untouched.
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
        /// Write view of a connector's configuration. Used when creating a connector<br/>
        /// and reused when updating one. Carries the secrets and inputs the customer<br/>
        /// must supply. Server-derived display fields are not accepted here and instead<br/>
        /// appear in the read view: Slack returns `webhook_path`, gchat returns<br/>
        /// `audience_url` and `client_email`, and zoom returns the generated<br/>
        /// `connector_token` and `webhook_path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateConnectorConfigurationJsonConverter))]
        public global::Vectara.CreateConnectorConfiguration? Configuration { get; set; }

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
        /// Write view of a connector's configuration. Used when creating a connector<br/>
        /// and reused when updating one. Carries the secrets and inputs the customer<br/>
        /// must supply. Server-derived display fields are not accepted here and instead<br/>
        /// appear in the read view: Slack returns `webhook_path`, gchat returns<br/>
        /// `audience_url` and `client_email`, and zoom returns the generated<br/>
        /// `connector_token` and `webhook_path`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentConnectorRequest(
            string? name,
            string? description,
            object? metadata,
            bool? enabled,
            global::Vectara.CreateConnectorConfiguration? configuration)
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