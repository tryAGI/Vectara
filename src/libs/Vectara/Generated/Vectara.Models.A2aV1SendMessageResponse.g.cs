
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response of `POST /message:send`. Exactly one of `task` or `message` is populated.
    /// </summary>
    public sealed partial class A2aV1SendMessageResponse
    {
        /// <summary>
        /// A v1 unit of work executed by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Vectara.A2aV1Task? Task { get; set; }

        /// <summary>
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Vectara.A2aV1Message? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1SendMessageResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// A v1 unit of work executed by the agent.
        /// </param>
        /// <param name="message">
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1SendMessageResponse(
            global::Vectara.A2aV1Task? task,
            global::Vectara.A2aV1Message? message)
        {
            this.Task = task;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1SendMessageResponse" /> class.
        /// </summary>
        public A2aV1SendMessageResponse()
        {
        }

    }
}