
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Google Chat connector's configuration. Includes the display<br/>
    /// field `client_email` parsed out of the service account key and the audience<br/>
    /// URL used to verify inbound events. The service account key is never returned.
    /// </summary>
    public sealed partial class GchatConnectorConfiguration
    {
        /// <summary>
        /// The type of connector configuration.<br/>
        /// Default Value: gchat<br/>
        /// Example: gchat
        /// </summary>
        /// <default>"gchat"</default>
        /// <example>gchat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "gchat";

        /// <summary>
        /// The webhook URL for this connector. Set the Chat app's HTTP endpoint URL<br/>
        /// and Authentication audience fields to this value in the Google Cloud<br/>
        /// console. Inbound Google Chat ID tokens are accepted only if aud equals<br/>
        /// this URL. This value contains a secret and is encrypted at rest.<br/>
        /// Example: https://api.example.com/v2/agents/customer_support/connectors/con_3Kx9QpVn2mZr8YbLc5TdWe/gchat
        /// </summary>
        /// <example>https://api.example.com/v2/agents/customer_support/connectors/con_3Kx9QpVn2mZr8YbLc5TdWe/gchat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudienceUrl { get; set; }

        /// <summary>
        /// Service account email derived from the service account key.<br/>
        /// Example: chat-bot@my-gchat-app.iam.gserviceaccount.com
        /// </summary>
        /// <example>chat-bot@my-gchat-app.iam.gserviceaccount.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GchatConnectorConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: gchat<br/>
        /// Example: gchat
        /// </param>
        /// <param name="audienceUrl">
        /// The webhook URL for this connector. Set the Chat app's HTTP endpoint URL<br/>
        /// and Authentication audience fields to this value in the Google Cloud<br/>
        /// console. Inbound Google Chat ID tokens are accepted only if aud equals<br/>
        /// this URL. This value contains a secret and is encrypted at rest.<br/>
        /// Example: https://api.example.com/v2/agents/customer_support/connectors/con_3Kx9QpVn2mZr8YbLc5TdWe/gchat
        /// </param>
        /// <param name="clientEmail">
        /// Service account email derived from the service account key.<br/>
        /// Example: chat-bot@my-gchat-app.iam.gserviceaccount.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GchatConnectorConfiguration(
            string type,
            string audienceUrl,
            string clientEmail)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AudienceUrl = audienceUrl ?? throw new global::System.ArgumentNullException(nameof(audienceUrl));
            this.ClientEmail = clientEmail ?? throw new global::System.ArgumentNullException(nameof(clientEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GchatConnectorConfiguration" /> class.
        /// </summary>
        public GchatConnectorConfiguration()
        {
        }

    }
}