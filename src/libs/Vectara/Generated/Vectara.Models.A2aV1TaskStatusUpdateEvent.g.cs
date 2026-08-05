
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v1 streaming event indicating a task status change.
    /// </summary>
    public sealed partial class A2aV1TaskStatusUpdateEvent
    {
        /// <summary>
        /// Identifier of the task whose status changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Identifier of the conversation context the task belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// Current status of a v1 task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV1TaskStatus Status { get; set; }

        /// <summary>
        /// True when this is the terminal status update for the task. The platform sends no further status updates for the task after this one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final")]
        public bool? Final { get; set; }

        /// <summary>
        /// Arbitrary agent-supplied metadata for the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1TaskStatusUpdateEvent" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Identifier of the task whose status changed.
        /// </param>
        /// <param name="contextId">
        /// Identifier of the conversation context the task belongs to.
        /// </param>
        /// <param name="status">
        /// Current status of a v1 task.
        /// </param>
        /// <param name="final">
        /// True when this is the terminal status update for the task. The platform sends no further status updates for the task after this one.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary agent-supplied metadata for the event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1TaskStatusUpdateEvent(
            string taskId,
            string contextId,
            global::Vectara.A2aV1TaskStatus status,
            bool? final,
            object? metadata)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Final = final;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1TaskStatusUpdateEvent" /> class.
        /// </summary>
        public A2aV1TaskStatusUpdateEvent()
        {
        }

    }
}