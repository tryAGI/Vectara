
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateZoomAgentConnectorRequestVariant2
    {
        /// <summary>
        /// The type of connector.<br/>
        /// Default Value: zoom<br/>
        /// Example: zoom
        /// </summary>
        /// <default>"zoom"</default>
        /// <example>zoom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "zoom";

        /// <summary>
        /// Write view of a Zoom Contact Center connector's configuration. Supply the<br/>
        /// Zoom-provided callback URL that agent replies are POSTed to. The platform<br/>
        /// generates the inbound `connector_token` and returns it in the read view.<br/>
        /// Configure it as the `x-zoom-connector-token` header on the Zoom Contact Center bot<br/>
        /// connector. Updating the configuration preserves the existing `connector_token`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateZoomConnectorConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.CreateZoomConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateZoomAgentConnectorRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Default Value: zoom<br/>
        /// Example: zoom
        /// </param>
        /// <param name="configuration">
        /// Write view of a Zoom Contact Center connector's configuration. Supply the<br/>
        /// Zoom-provided callback URL that agent replies are POSTed to. The platform<br/>
        /// generates the inbound `connector_token` and returns it in the read view.<br/>
        /// Configure it as the `x-zoom-connector-token` header on the Zoom Contact Center bot<br/>
        /// connector. Updating the configuration preserves the existing `connector_token`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateZoomAgentConnectorRequestVariant2(
            string type,
            global::Vectara.CreateZoomConnectorConfiguration configuration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateZoomAgentConnectorRequestVariant2" /> class.
        /// </summary>
        public CreateZoomAgentConnectorRequestVariant2()
        {
        }

    }
}