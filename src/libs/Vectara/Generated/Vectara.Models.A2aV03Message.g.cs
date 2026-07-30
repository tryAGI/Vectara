
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
    /// </summary>
    public sealed partial class A2aV03Message
    {
        /// <summary>
        /// Unique identifier for this message, set by the sender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Identifier of the conversation context this message belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Identifier of the task this message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// The sender role in an A2A v0.3 message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.A2aV03RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV03Role Role { get; set; }

        /// <summary>
        /// Message content parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.A2aV03Part> Content { get; set; }

        /// <summary>
        /// Arbitrary sender-supplied metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// URIs of A2A extensions this message activates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<string>? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03Message" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Unique identifier for this message, set by the sender.
        /// </param>
        /// <param name="role">
        /// The sender role in an A2A v0.3 message.
        /// </param>
        /// <param name="content">
        /// Message content parts.
        /// </param>
        /// <param name="contextId">
        /// Identifier of the conversation context this message belongs to.
        /// </param>
        /// <param name="taskId">
        /// Identifier of the task this message is associated with.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary sender-supplied metadata.
        /// </param>
        /// <param name="extensions">
        /// URIs of A2A extensions this message activates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03Message(
            string messageId,
            global::Vectara.A2aV03Role role,
            global::System.Collections.Generic.IList<global::Vectara.A2aV03Part> content,
            string? contextId,
            string? taskId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? extensions)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.ContextId = contextId;
            this.TaskId = taskId;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Metadata = metadata;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03Message" /> class.
        /// </summary>
        public A2aV03Message()
        {
        }

    }
}