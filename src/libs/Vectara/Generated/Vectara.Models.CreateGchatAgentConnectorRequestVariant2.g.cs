
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGchatAgentConnectorRequestVariant2
    {
        /// <summary>
        /// The type of connector.<br/>
        /// Default Value: gchat<br/>
        /// Example: gchat
        /// </summary>
        /// <default>"gchat"</default>
        /// <example>gchat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "gchat";

        /// <summary>
        /// Write view of a Google Chat connector's configuration. Supply the service<br/>
        /// account JSON key for the Chat app you have configured in the Google Cloud<br/>
        /// console. The Chat app's HTTP endpoint URL and Authentication audience must<br/>
        /// be set to the connector's audience_url (returned in the read view).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateGchatConnectorConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.CreateGchatConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGchatAgentConnectorRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Default Value: gchat<br/>
        /// Example: gchat
        /// </param>
        /// <param name="configuration">
        /// Write view of a Google Chat connector's configuration. Supply the service<br/>
        /// account JSON key for the Chat app you have configured in the Google Cloud<br/>
        /// console. The Chat app's HTTP endpoint URL and Authentication audience must<br/>
        /// be set to the connector's audience_url (returned in the read view).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGchatAgentConnectorRequestVariant2(
            string type,
            global::Vectara.CreateGchatConnectorConfiguration configuration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGchatAgentConnectorRequestVariant2" /> class.
        /// </summary>
        public CreateGchatAgentConnectorRequestVariant2()
        {
        }

    }
}