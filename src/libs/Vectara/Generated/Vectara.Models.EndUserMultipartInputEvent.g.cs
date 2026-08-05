
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A message from the end user with file uploads, sent as multipart form data.
    /// </summary>
    public sealed partial class EndUserMultipartInputEvent
    {
        /// <summary>
        /// List of inputs that make up this message. Sent as a JSON-encoded string in the multipart form.<br/>
        /// Example: [{"type":"text","content":"Review this file"}]
        /// </summary>
        /// <example>[{"type":"text","content":"Review this file"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentInput>? Messages { get; set; }

        /// <summary>
        /// Files to upload to the agent session. Any file type is accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserMultipartInputEvent" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of inputs that make up this message. Sent as a JSON-encoded string in the multipart form.<br/>
        /// Example: [{"type":"text","content":"Review this file"}]
        /// </param>
        /// <param name="files">
        /// Files to upload to the agent session. Any file type is accepted.
        /// </param>
        /// <param name="streamResponse">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserMultipartInputEvent(
            global::System.Collections.Generic.IList<global::Vectara.AgentInput>? messages,
            global::System.Collections.Generic.IList<byte[]>? files,
            bool? streamResponse)
        {
            this.Messages = messages;
            this.Files = files;
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserMultipartInputEvent" /> class.
        /// </summary>
        public EndUserMultipartInputEvent()
        {
        }

    }
}