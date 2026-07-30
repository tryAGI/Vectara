
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v1 unit of work executed by the agent.
    /// </summary>
    public sealed partial class A2aV1Task
    {
        /// <summary>
        /// Unique identifier of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the conversation context the task belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Current status of a v1 task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV1TaskStatus Status { get; set; }

        /// <summary>
        /// Artifacts produced by the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Artifact>? Artifacts { get; set; }

        /// <summary>
        /// Conversation messages exchanged during the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1Message>? History { get; set; }

        /// <summary>
        /// Arbitrary agent-supplied metadata for the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1Task" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the task.
        /// </param>
        /// <param name="status">
        /// Current status of a v1 task.
        /// </param>
        /// <param name="contextId">
        /// Identifier of the conversation context the task belongs to.
        /// </param>
        /// <param name="artifacts">
        /// Artifacts produced by the task.
        /// </param>
        /// <param name="history">
        /// Conversation messages exchanged during the task.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary agent-supplied metadata for the task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1Task(
            string id,
            global::Vectara.A2aV1TaskStatus status,
            string? contextId,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1Artifact>? artifacts,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1Message>? history,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ContextId = contextId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Artifacts = artifacts;
            this.History = history;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1Task" /> class.
        /// </summary>
        public A2aV1Task()
        {
        }

    }
}