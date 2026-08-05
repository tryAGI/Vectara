
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Body of `POST /v1/message:send` and `POST /v1/message:stream`.
    /// </summary>
    public sealed partial class A2aV03SendMessageRequest
    {
        /// <summary>
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV03Message Message { get; set; }

        /// <summary>
        /// Optional settings that control how the agent processes and responds to a v0.3 message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Vectara.A2aV03SendMessageConfiguration? Configuration { get; set; }

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
        /// Initializes a new instance of the <see cref="A2aV03SendMessageRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </param>
        /// <param name="configuration">
        /// Optional settings that control how the agent processes and responds to a v0.3 message.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary client-supplied metadata for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03SendMessageRequest(
            global::Vectara.A2aV03Message message,
            global::Vectara.A2aV03SendMessageConfiguration? configuration,
            object? metadata)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Configuration = configuration;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03SendMessageRequest" /> class.
        /// </summary>
        public A2aV03SendMessageRequest()
        {
        }

    }
}