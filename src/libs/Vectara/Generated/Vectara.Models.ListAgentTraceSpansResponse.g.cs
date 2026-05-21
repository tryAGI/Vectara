
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A list of spans for an agent trace.
    /// </summary>
    public sealed partial class ListAgentTraceSpansResponse
    {
        /// <summary>
        /// The list of spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentTraceSpan> Spans { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vectara.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentTraceSpansResponse" /> class.
        /// </summary>
        /// <param name="spans">
        /// The list of spans.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentTraceSpansResponse(
            global::System.Collections.Generic.IList<global::Vectara.AgentTraceSpan> spans,
            global::Vectara.ListMetadata? metadata)
        {
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentTraceSpansResponse" /> class.
        /// </summary>
        public ListAgentTraceSpansResponse()
        {
        }

    }
}