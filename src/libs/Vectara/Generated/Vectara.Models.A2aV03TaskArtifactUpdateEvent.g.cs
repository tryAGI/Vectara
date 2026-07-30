
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v0.3 streaming event indicating an artifact change.
    /// </summary>
    public sealed partial class A2aV03TaskArtifactUpdateEvent
    {
        /// <summary>
        /// Identifier of the task that produced the artifact.
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
        /// A v0.3 task output artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV03Artifact Artifact { get; set; }

        /// <summary>
        /// True when this artifact's parts append to the prior version with the same `artifactId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("append")]
        public bool? Append { get; set; }

        /// <summary>
        /// True when this is the final chunk for the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastChunk")]
        public bool? LastChunk { get; set; }

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
        /// Initializes a new instance of the <see cref="A2aV03TaskArtifactUpdateEvent" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Identifier of the task that produced the artifact.
        /// </param>
        /// <param name="contextId">
        /// Identifier of the conversation context the task belongs to.
        /// </param>
        /// <param name="artifact">
        /// A v0.3 task output artifact.
        /// </param>
        /// <param name="append">
        /// True when this artifact's parts append to the prior version with the same `artifactId`.
        /// </param>
        /// <param name="lastChunk">
        /// True when this is the final chunk for the artifact.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary agent-supplied metadata for the event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03TaskArtifactUpdateEvent(
            string taskId,
            string contextId,
            global::Vectara.A2aV03Artifact artifact,
            bool? append,
            bool? lastChunk,
            object? metadata)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.Artifact = artifact ?? throw new global::System.ArgumentNullException(nameof(artifact));
            this.Append = append;
            this.LastChunk = lastChunk;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03TaskArtifactUpdateEvent" /> class.
        /// </summary>
        public A2aV03TaskArtifactUpdateEvent()
        {
        }

    }
}