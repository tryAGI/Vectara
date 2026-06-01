
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Input event with file uploads and optional message parts. Sent as multipart form data.
    /// </summary>
    public sealed partial class MultipartInputEvent
    {
        /// <summary>
        /// Deprecated: use messages instead.<br/>
        /// Plain text input message to accompany the file upload.<br/>
        /// If both message and messages are provided, messages takes precedence and message is ignored.<br/>
        /// Example: I need help with my widget installation
        /// </summary>
        /// <example>I need help with my widget installation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Message { get; set; }

        /// <summary>
        /// List of inputs that make up this event. Each entry is an AgentInput selected by "type: text" for plain text content (default), or "skill" to invoke a skill by name. Sent as a JSON-encoded string in the multipart form. If omitted, falls back to the deprecated "message" field as a single text input.<br/>
        /// Example: [{"type":"text","content":"Review this file"}, {"type":"skill","skill_name":"code_review"}]
        /// </summary>
        /// <example>[{"type":"text","content":"Review this file"}, {"type":"skill","skill_name":"code_review"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentInput>? Messages { get; set; }

        /// <summary>
        /// Files to upload to the agent session. Any file type is accepted.<br/>
        /// What the agent can do with the file depends on the tools available to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Event ID to return all events created after queueing the new input. When provided and the session is currently running, the response will include all events created after this event ID, and the new input will be processed according to the behavior field. Use the special value "start" to receive all events from the beginning of the session, including the input message itself.<br/>
        /// Example: start
        /// </summary>
        /// <example>start</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        public string? Since { get; set; }

        /// <summary>
        /// Controls how the input is processed when the session is already running.<br/>
        /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
        /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
        ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
        ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.InputBehaviorJsonConverter))]
        public global::Vectara.InputBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartInputEvent" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of inputs that make up this event. Each entry is an AgentInput selected by "type: text" for plain text content (default), or "skill" to invoke a skill by name. Sent as a JSON-encoded string in the multipart form. If omitted, falls back to the deprecated "message" field as a single text input.<br/>
        /// Example: [{"type":"text","content":"Review this file"}, {"type":"skill","skill_name":"code_review"}]
        /// </param>
        /// <param name="files">
        /// Files to upload to the agent session. Any file type is accepted.<br/>
        /// What the agent can do with the file depends on the tools available to it.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="since">
        /// Event ID to return all events created after queueing the new input. When provided and the session is currently running, the response will include all events created after this event ID, and the new input will be processed according to the behavior field. Use the special value "start" to receive all events from the beginning of the session, including the input message itself.<br/>
        /// Example: start
        /// </param>
        /// <param name="behavior">
        /// Controls how the input is processed when the session is already running.<br/>
        /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
        /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
        ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
        ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartInputEvent(
            global::System.Collections.Generic.IList<global::Vectara.AgentInput>? messages,
            global::System.Collections.Generic.IList<byte[]>? files,
            bool? streamResponse,
            string? since,
            global::Vectara.InputBehavior? behavior)
        {
            this.Messages = messages;
            this.Files = files;
            this.StreamResponse = streamResponse;
            this.Since = since;
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartInputEvent" /> class.
        /// </summary>
        public MultipartInputEvent()
        {
        }

    }
}