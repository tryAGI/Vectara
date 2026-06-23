
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateZoomConnectorConfigurationVariant2
    {
        /// <summary>
        /// The type of connector configuration.<br/>
        /// Default Value: zoom<br/>
        /// Example: zoom
        /// </summary>
        /// <default>"zoom"</default>
        /// <example>zoom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "zoom";

        /// <summary>
        /// The Zoom-provided URL the agent's reply is POSTed to once it is<br/>
        /// ready. Must be an absolute https URL.<br/>
        /// Example: https://zcc.zoom.us/webhook/chatbot/12345
        /// </summary>
        /// <example>https://zcc.zoom.us/webhook/chatbot/12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackUrl { get; set; }

        /// <summary>
        /// Optional access token issued by Zoom for the callback URL. When<br/>
        /// set, reply POSTs carry it as a bearer Authorization header.<br/>
        /// Encrypted at rest.<br/>
        /// Example: kP9mW2nR7sT1vX6cB3dF8gH5jL0qYzA4eU7iO2xK
        /// </summary>
        /// <example>kP9mW2nR7sT1vX6cB3dF8gH5jL0qYzA4eU7iO2xK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_access_token")]
        public string? CallbackAccessToken { get; set; }

        /// <summary>
        /// How long the typing indicator returned by the webhook runs while<br/>
        /// the agent works on its reply.<br/>
        /// Default Value: 60<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("typing_duration_seconds")]
        public int? TypingDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateZoomConnectorConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: zoom<br/>
        /// Example: zoom
        /// </param>
        /// <param name="callbackUrl">
        /// The Zoom-provided URL the agent's reply is POSTed to once it is<br/>
        /// ready. Must be an absolute https URL.<br/>
        /// Example: https://zcc.zoom.us/webhook/chatbot/12345
        /// </param>
        /// <param name="callbackAccessToken">
        /// Optional access token issued by Zoom for the callback URL. When<br/>
        /// set, reply POSTs carry it as a bearer Authorization header.<br/>
        /// Encrypted at rest.<br/>
        /// Example: kP9mW2nR7sT1vX6cB3dF8gH5jL0qYzA4eU7iO2xK
        /// </param>
        /// <param name="typingDurationSeconds">
        /// How long the typing indicator returned by the webhook runs while<br/>
        /// the agent works on its reply.<br/>
        /// Default Value: 60<br/>
        /// Example: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateZoomConnectorConfigurationVariant2(
            string type,
            string callbackUrl,
            string? callbackAccessToken,
            int? typingDurationSeconds)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CallbackUrl = callbackUrl ?? throw new global::System.ArgumentNullException(nameof(callbackUrl));
            this.CallbackAccessToken = callbackAccessToken;
            this.TypingDurationSeconds = typingDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateZoomConnectorConfigurationVariant2" /> class.
        /// </summary>
        public CreateZoomConnectorConfigurationVariant2()
        {
        }

    }
}