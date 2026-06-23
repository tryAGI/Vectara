
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ZoomConnectorConfigurationVariant2
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
        /// Server-generated shared secret that authenticates inbound webhook<br/>
        /// requests. Zoom Contact Center must send this value in the<br/>
        /// `x-zoom-connector-token` header. Generated at create time, preserved<br/>
        /// across configuration updates, and encrypted at rest.<br/>
        /// Example: 3q2-8hG7kPzR5tWvYxA1bC4dE6fJ9mN0oQsUiZlXnKw
        /// </summary>
        /// <example>3q2-8hG7kPzR5tWvYxA1bC4dE6fJ9mN0oQsUiZlXnKw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorToken { get; set; }

        /// <summary>
        /// The Zoom-provided URL the agent's reply is POSTed to once it is<br/>
        /// ready. Always an absolute https URL.<br/>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TypingDurationSeconds { get; set; }

        /// <summary>
        /// The inbound webhook path for this connector. Configure the Zoom<br/>
        /// Contact Center bot endpoint URL to this path on the Vectara API<br/>
        /// host.<br/>
        /// Example: /v2/agents/customer_support/connectors/con_3Kx9QpVn2mZr8YbLc5TdWe/zoom
        /// </summary>
        /// <example>/v2/agents/customer_support/connectors/con_3Kx9QpVn2mZr8YbLc5TdWe/zoom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoomConnectorConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: zoom<br/>
        /// Example: zoom
        /// </param>
        /// <param name="connectorToken">
        /// Server-generated shared secret that authenticates inbound webhook<br/>
        /// requests. Zoom Contact Center must send this value in the<br/>
        /// `x-zoom-connector-token` header. Generated at create time, preserved<br/>
        /// across configuration updates, and encrypted at rest.<br/>
        /// Example: 3q2-8hG7kPzR5tWvYxA1bC4dE6fJ9mN0oQsUiZlXnKw
        /// </param>
        /// <param name="callbackUrl">
        /// The Zoom-provided URL the agent's reply is POSTed to once it is<br/>
        /// ready. Always an absolute https URL.<br/>
        /// Example: https://zcc.zoom.us/webhook/chatbot/12345
        /// </param>
        /// <param name="typingDurationSeconds">
        /// How long the typing indicator returned by the webhook runs while<br/>
        /// the agent works on its reply.<br/>
        /// Default Value: 60<br/>
        /// Example: 60
        /// </param>
        /// <param name="webhookPath">
        /// The inbound webhook path for this connector. Configure the Zoom<br/>
        /// Contact Center bot endpoint URL to this path on the Vectara API<br/>
        /// host.<br/>
        /// Example: /v2/agents/customer_support/connectors/con_3Kx9QpVn2mZr8YbLc5TdWe/zoom
        /// </param>
        /// <param name="callbackAccessToken">
        /// Optional access token issued by Zoom for the callback URL. When<br/>
        /// set, reply POSTs carry it as a bearer Authorization header.<br/>
        /// Encrypted at rest.<br/>
        /// Example: kP9mW2nR7sT1vX6cB3dF8gH5jL0qYzA4eU7iO2xK
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ZoomConnectorConfigurationVariant2(
            string type,
            string connectorToken,
            string callbackUrl,
            int typingDurationSeconds,
            string webhookPath,
            string? callbackAccessToken)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ConnectorToken = connectorToken ?? throw new global::System.ArgumentNullException(nameof(connectorToken));
            this.CallbackUrl = callbackUrl ?? throw new global::System.ArgumentNullException(nameof(callbackUrl));
            this.CallbackAccessToken = callbackAccessToken;
            this.TypingDurationSeconds = typingDurationSeconds;
            this.WebhookPath = webhookPath ?? throw new global::System.ArgumentNullException(nameof(webhookPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoomConnectorConfigurationVariant2" /> class.
        /// </summary>
        public ZoomConnectorConfigurationVariant2()
        {
        }

    }
}