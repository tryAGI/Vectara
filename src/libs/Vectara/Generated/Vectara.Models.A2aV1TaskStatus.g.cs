
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Current status of a v1 task.
    /// </summary>
    public sealed partial class A2aV1TaskStatus
    {
        /// <summary>
        /// A2A v1 task lifecycle state. Note `TASK_STATE_CANCELED` uses the US spelling per the v1 proto (one L).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.A2aV1TaskStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV1TaskState State { get; set; }

        /// <summary>
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Vectara.A2aV1Message? Message { get; set; }

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
        /// Initializes a new instance of the <see cref="A2aV1TaskStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// A2A v1 task lifecycle state. Note `TASK_STATE_CANCELED` uses the US spelling per the v1 proto (one L).
        /// </param>
        /// <param name="message">
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </param>
        /// <param name="timestamp">
        /// ISO 8601 timestamp of the transition into this state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1TaskStatus(
            global::Vectara.A2aV1TaskState state,
            global::Vectara.A2aV1Message? message,
            global::System.DateTime? timestamp)
        {
            this.State = state;
            this.Message = message;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1TaskStatus" /> class.
        /// </summary>
        public A2aV1TaskStatus()
        {
        }

    }
}