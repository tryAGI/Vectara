
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWidgetAgentConnectorRequestVariant2
    {
        /// <summary>
        /// The type of connector.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </summary>
        /// <default>"widget"</default>
        /// <example>widget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "widget";

        /// <summary>
        /// Whether the connector admits anonymous visitors upon creation. Defaults to `false`, so a widget never admits visitors until it is explicitly opened.<br/>
        /// Gates anonymous admission only; authenticated callers presenting this connector are governed by `enabled`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_access")]
        public bool? PublicAccess { get; set; }

        /// <summary>
        /// Write view of a web widget connector's configuration, supplied on create or update.<br/>
        /// Every field is served to anonymous visitors by the unauthenticated widget bootstrap endpoint.<br/>
        /// The `bootstrap_path` is platform-derived and appears only in the read view.<br/>
        /// Widget connectors ignore the base `hidden_output_types`; end-user event visibility is controlled by `revealed_output_types`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateWidgetConnectorConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.CreateWidgetConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWidgetAgentConnectorRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </param>
        /// <param name="configuration">
        /// Write view of a web widget connector's configuration, supplied on create or update.<br/>
        /// Every field is served to anonymous visitors by the unauthenticated widget bootstrap endpoint.<br/>
        /// The `bootstrap_path` is platform-derived and appears only in the read view.<br/>
        /// Widget connectors ignore the base `hidden_output_types`; end-user event visibility is controlled by `revealed_output_types`.
        /// </param>
        /// <param name="publicAccess">
        /// Whether the connector admits anonymous visitors upon creation. Defaults to `false`, so a widget never admits visitors until it is explicitly opened.<br/>
        /// Gates anonymous admission only; authenticated callers presenting this connector are governed by `enabled`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWidgetAgentConnectorRequestVariant2(
            string type,
            global::Vectara.CreateWidgetConnectorConfiguration configuration,
            bool? publicAccess)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PublicAccess = publicAccess;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWidgetAgentConnectorRequestVariant2" /> class.
        /// </summary>
        public CreateWidgetAgentConnectorRequestVariant2()
        {
        }

    }
}