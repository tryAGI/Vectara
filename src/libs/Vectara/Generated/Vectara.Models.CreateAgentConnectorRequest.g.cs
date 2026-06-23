
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a new agent connector.
    /// </summary>
    public sealed partial class CreateAgentConnectorRequest
    {
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
        /// Arbitrary metadata associated with the connector.<br/>
        /// Default Value: {}<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </summary>
        /// <example>{"priority":"high","department":"customer_service"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the connector should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.CreateConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConnectorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the connector.<br/>
        /// Example: Customer Support Slack Channel
        /// </param>
        /// <param name="configuration">
        /// Write view of a connector's configuration. Used when creating a connector<br/>
        /// and reused when updating one. Carries the secrets and inputs the customer<br/>
        /// must supply. Server-derived display fields are not accepted here and instead<br/>
        /// appear in the read view: Slack returns `webhook_path`, gchat returns<br/>
        /// `audience_url` and `client_email`, and zoom returns the generated<br/>
        /// `connector_token` and `webhook_path`.
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the connector.<br/>
        /// Default Value: {}<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </param>
        /// <param name="enabled">
        /// Whether the connector should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConnectorRequest(
            string name,
            global::Vectara.CreateConnectorConfiguration configuration,
            string? description,
            object? metadata,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConnectorRequest" /> class.
        /// </summary>
        public CreateAgentConnectorRequest()
        {
        }

    }
}