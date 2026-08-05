
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Current status of a v0.3 task.
    /// </summary>
    public sealed partial class A2aV03TaskStatus
    {
        /// <summary>
        /// The A2A v0.3 task lifecycle state. `TASK_STATE_CANCELLED` uses the UK spelling, as defined in the A2A v0.3 specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.A2aV03TaskStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV03TaskState State { get; set; }

        /// <summary>
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Vectara.A2aV03Message? Message { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of the transition into this state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03TaskStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// The A2A v0.3 task lifecycle state. `TASK_STATE_CANCELLED` uses the UK spelling, as defined in the A2A v0.3 specification.
        /// </param>
        /// <param name="message">
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </param>
        /// <param name="timestamp">
        /// ISO 8601 timestamp of the transition into this state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03TaskStatus(
            global::Vectara.A2aV03TaskState state,
            global::Vectara.A2aV03Message? message,
            global::System.DateTime? timestamp)
        {
            this.State = state;
            this.Message = message;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03TaskStatus" /> class.
        /// </summary>
        public A2aV03TaskStatus()
        {
        }

    }
}