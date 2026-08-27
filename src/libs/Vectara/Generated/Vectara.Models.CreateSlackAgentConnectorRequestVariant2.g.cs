
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSlackAgentConnectorRequestVariant2
    {
        /// <summary>
        /// The type of connector.<br/>
        /// Default Value: slack<br/>
        /// Example: slack
        /// </summary>
        /// <default>"slack"</default>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "slack";

        /// <summary>
        /// Write view of a Slack connector's configuration, supplied on create or update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateSlackConnectorConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.CreateSlackConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackAgentConnectorRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Default Value: slack<br/>
        /// Example: slack
        /// </param>
        /// <param name="configuration">
        /// Write view of a Slack connector's configuration, supplied on create or update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSlackAgentConnectorRequestVariant2(
            string type,
            global::Vectara.CreateSlackConnectorConfiguration configuration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackAgentConnectorRequestVariant2" /> class.
        /// </summary>
        public CreateSlackAgentConnectorRequestVariant2()
        {
        }

    }
}