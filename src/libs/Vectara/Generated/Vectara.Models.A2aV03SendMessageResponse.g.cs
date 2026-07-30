
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response of `POST /v1/message:send`. Exactly one of `task` or `message` is populated.
    /// </summary>
    public sealed partial class A2aV03SendMessageResponse
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03SendMessageResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// A v0.3 unit of work executed by the agent on behalf of a user.
        /// </param>
        /// <param name="message">
        /// A v0.3 unit of communication between client and agent. The `content` field carries the message parts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03SendMessageResponse(
            global::Vectara.A2aV03Task? task,
            global::Vectara.A2aV03Message? message)
        {
            this.Task = task;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03SendMessageResponse" /> class.
        /// </summary>
        public A2aV03SendMessageResponse()
        {
        }

    }
}