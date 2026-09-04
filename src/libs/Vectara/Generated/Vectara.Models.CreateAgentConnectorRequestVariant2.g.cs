
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentConnectorRequestVariant2
    {
        /// <summary>
        /// Optional confirmation of the connector type. When supplied it must match `configuration.type`; when omitted the type is taken from `configuration.type`.<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateAgentConnectorRequestVariant2TypeJsonConverter))]
        public global::Vectara.CreateAgentConnectorRequestVariant2Type? Type { get; set; }

        /// <summary>
        /// Write view of a connector's configuration, supplied when creating a<br/>
        /// connector. Carries the secrets and inputs the customer must supply.<br/>
        /// Platform-derived display fields are not accepted here and instead<br/>
        /// appear in the read view:<br/>
        /// - Slack returns `webhook_path`<br/>
        /// - gchat returns `audience_url` and `client_email`<br/>
        /// - zoom returns the generated `connector_token` and `webhook_path`<br/>
        /// - widget returns `bootstrap_path`
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
        /// Initializes a new instance of the <see cref="CreateAgentConnectorRequestVariant2" /> class.
        /// </summary>
        /// <param name="configuration">
        /// Write view of a connector's configuration, supplied when creating a<br/>
        /// connector. Carries the secrets and inputs the customer must supply.<br/>
        /// Platform-derived display fields are not accepted here and instead<br/>
        /// appear in the read view:<br/>
        /// - Slack returns `webhook_path`<br/>
        /// - gchat returns `audience_url` and `client_email`<br/>
        /// - zoom returns the generated `connector_token` and `webhook_path`<br/>
        /// - widget returns `bootstrap_path`
        /// </param>
        /// <param name="type">
        /// Optional confirmation of the connector type. When supplied it must match `configuration.type`; when omitted the type is taken from `configuration.type`.<br/>
        /// Example: slack
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConnectorRequestVariant2(
            global::Vectara.CreateConnectorConfiguration configuration,
            global::Vectara.CreateAgentConnectorRequestVariant2Type? type)
        {
            this.Type = type;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConnectorRequestVariant2" /> class.
        /// </summary>
        public CreateAgentConnectorRequestVariant2()
        {
        }

    }
}