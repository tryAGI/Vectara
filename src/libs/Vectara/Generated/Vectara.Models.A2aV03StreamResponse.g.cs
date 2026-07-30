
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Each SSE event payload from `POST /v1/message:stream` and `GET /v1/tasks/{task_id}:subscribe`. Exactly one of `task`, `message`, `statusUpdate`, or `artifactUpdate` is populated.
    /// </summary>
    public sealed partial class A2aV03StreamResponse
    {
        /// <summary>
        /// A v0.3 unit of work executed by the agent on behalf of a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Vectara.A2aV03Task? Task { get; set; }

        /// <summary>
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Vectara.A2aV03Message? Message { get; set; }

        /// <summary>
        /// A v0.3 streaming event indicating a task status change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusUpdate")]
        public global::Vectara.A2aV03TaskStatusUpdateEvent? StatusUpdate { get; set; }

        /// <summary>
        /// A v0.3 streaming event indicating an artifact change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifactUpdate")]
        public global::Vectara.A2aV03TaskArtifactUpdateEvent? ArtifactUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03StreamResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// A v0.3 unit of work executed by the agent on behalf of a user.
        /// </param>
        /// <param name="message">
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </param>
        /// <param name="statusUpdate">
        /// A v0.3 streaming event indicating a task status change.
        /// </param>
        /// <param name="artifactUpdate">
        /// A v0.3 streaming event indicating an artifact change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03StreamResponse(
            global::Vectara.A2aV03Task? task,
            global::Vectara.A2aV03Message? message,
            global::Vectara.A2aV03TaskStatusUpdateEvent? statusUpdate,
            global::Vectara.A2aV03TaskArtifactUpdateEvent? artifactUpdate)
        {
            this.Task = task;
            this.Message = message;
            this.StatusUpdate = statusUpdate;
            this.ArtifactUpdate = artifactUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03StreamResponse" /> class.
        /// </summary>
        public A2aV03StreamResponse()
        {
        }

    }
}