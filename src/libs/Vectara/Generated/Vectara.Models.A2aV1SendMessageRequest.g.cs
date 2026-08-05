
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Body of `POST /message:send` and `POST /message:stream`.
    /// </summary>
    public sealed partial class A2aV1SendMessageRequest
    {
        /// <summary>
        /// Tenant identifier the message is sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV1Message Message { get; set; }

        /// <summary>
        /// Optional settings that control how the agent processes and responds to a v1 message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Vectara.A2aV1SendMessageConfiguration? Configuration { get; set; }

        /// <summary>
        /// Arbitrary client-supplied metadata for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1SendMessageRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </param>
        /// <param name="tenant">
        /// Tenant identifier the message is sent to.
        /// </param>
        /// <param name="configuration">
        /// Optional settings that control how the agent processes and responds to a v1 message.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary client-supplied metadata for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1SendMessageRequest(
            global::Vectara.A2aV1Message message,
            string? tenant,
            global::Vectara.A2aV1SendMessageConfiguration? configuration,
            object? metadata)
        {
            this.Tenant = tenant;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Configuration = configuration;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1SendMessageRequest" /> class.
        /// </summary>
        public A2aV1SendMessageRequest()
        {
        }

    }
}