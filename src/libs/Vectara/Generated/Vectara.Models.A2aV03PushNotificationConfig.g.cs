
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Webhook configuration for receiving v0.3 task updates out-of-band.
    /// </summary>
    public sealed partial class A2aV03PushNotificationConfig
    {
        /// <summary>
        /// Server-assigned identifier for this push notification config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Webhook URL the agent posts task updates to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional token included in update requests so the receiver can validate the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Authentication parameters for the agent to use when pushing task updates to a webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        public global::Vectara.A2aV03AuthenticationInfo? Authentication { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03PushNotificationConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// Webhook URL the agent posts task updates to.
        /// </param>
        /// <param name="id">
        /// Server-assigned identifier for this push notification config.
        /// </param>
        /// <param name="token">
        /// Optional token included in update requests so the receiver can validate the caller.
        /// </param>
        /// <param name="authentication">
        /// Authentication parameters for the agent to use when pushing task updates to a webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03PushNotificationConfig(
            string url,
            string? id,
            string? token,
            global::Vectara.A2aV03AuthenticationInfo? authentication)
        {
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Token = token;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03PushNotificationConfig" /> class.
        /// </summary>
        public A2aV03PushNotificationConfig()
        {
        }

    }
}