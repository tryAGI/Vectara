
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Push notification configuration for a v1 task.
    /// </summary>
    public sealed partial class A2aV1TaskPushNotificationConfig
    {
        /// <summary>
        /// Tenant identifier the config applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// Server-assigned identifier for this push notification config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier of the task this config applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

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
        /// Authentication details the agent uses when calling the v1 push-notification URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        public global::Vectara.A2aV1AuthenticationInfo? Authentication { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1TaskPushNotificationConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// Webhook URL the agent posts task updates to.
        /// </param>
        /// <param name="tenant">
        /// Tenant identifier the config applies to.
        /// </param>
        /// <param name="id">
        /// Server-assigned identifier for this push notification config.
        /// </param>
        /// <param name="taskId">
        /// Identifier of the task this config applies to.
        /// </param>
        /// <param name="token">
        /// Optional token included in update requests so the receiver can validate the caller.
        /// </param>
        /// <param name="authentication">
        /// Authentication details the agent uses when calling the v1 push-notification URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1TaskPushNotificationConfig(
            string url,
            string? tenant,
            string? id,
            string? taskId,
            string? token,
            global::Vectara.A2aV1AuthenticationInfo? authentication)
        {
            this.Tenant = tenant;
            this.Id = id;
            this.TaskId = taskId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Token = token;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1TaskPushNotificationConfig" /> class.
        /// </summary>
        public A2aV1TaskPushNotificationConfig()
        {
        }

    }
}