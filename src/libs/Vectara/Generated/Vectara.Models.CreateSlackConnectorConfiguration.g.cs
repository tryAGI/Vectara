
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a Slack connector's configuration, supplied on create or update.
    /// </summary>
    public sealed partial class CreateSlackConnectorConfiguration
    {
        /// <summary>
        /// The type of connector configuration.<br/>
        /// Default Value: slack<br/>
        /// Example: slack
        /// </summary>
        /// <default>"slack"</default>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "slack";

        /// <summary>
        /// Slack bot token (xoxb-) for API access. Encrypted at rest.<br/>
        /// Example: xoxb-1234567890-1234567890123-abcdefghijklmnopqrstuvwx
        /// </summary>
        /// <example>xoxb-1234567890-1234567890123-abcdefghijklmnopqrstuvwx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotToken { get; set; }

        /// <summary>
        /// Slack signing secret for webhook verification. Encrypted at rest.<br/>
        /// Example: abcdef1234567890abcdef1234567890abcdef12
        /// </summary>
        /// <example>abcdef1234567890abcdef1234567890abcdef12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

        /// <summary>
        /// Slack App ID for customer lookup in webhooks.<br/>
        /// Example: A1234567890
        /// </summary>
        /// <example>A1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiAppId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackConnectorConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: slack<br/>
        /// Example: slack
        /// </param>
        /// <param name="botToken">
        /// Slack bot token (xoxb-) for API access. Encrypted at rest.<br/>
        /// Example: xoxb-1234567890-1234567890123-abcdefghijklmnopqrstuvwx
        /// </param>
        /// <param name="signingSecret">
        /// Slack signing secret for webhook verification. Encrypted at rest.<br/>
        /// Example: abcdef1234567890abcdef1234567890abcdef12
        /// </param>
        /// <param name="apiAppId">
        /// Slack App ID for customer lookup in webhooks.<br/>
        /// Example: A1234567890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSlackConnectorConfiguration(
            string type,
            string botToken,
            string signingSecret,
            string apiAppId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BotToken = botToken ?? throw new global::System.ArgumentNullException(nameof(botToken));
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
            this.ApiAppId = apiAppId ?? throw new global::System.ArgumentNullException(nameof(apiAppId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackConnectorConfiguration" /> class.
        /// </summary>
        public CreateSlackConnectorConfiguration()
        {
        }

    }
}