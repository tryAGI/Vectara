
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for an execute_tool span.
    /// </summary>
    public sealed partial class ExecuteToolSpanAttributes
    {
        /// <summary>
        /// The name of the tool called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// The configuration key of the tool called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_key")]
        public string? ToolKey { get; set; }

        /// <summary>
        /// The LLM-assigned tool call identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// The type of the tool (e.g. corpora_search, web_search).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        public string? ToolType { get; set; }

        /// <summary>
        /// The event ID for the tool input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_input_event_id")]
        public string? ToolInputEventId { get; set; }

        /// <summary>
        /// The event ID for the tool output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_output_event_id")]
        public string? ToolOutputEventId { get; set; }

        /// <summary>
        /// Corpus keys accessed by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_keys")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteToolSpanAttributes" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool called.
        /// </param>
        /// <param name="toolKey">
        /// The configuration key of the tool called.
        /// </param>
        /// <param name="toolCallId">
        /// The LLM-assigned tool call identifier.
        /// </param>
        /// <param name="toolType">
        /// The type of the tool (e.g. corpora_search, web_search).
        /// </param>
        /// <param name="toolInputEventId">
        /// The event ID for the tool input.
        /// </param>
        /// <param name="toolOutputEventId">
        /// The event ID for the tool output.
        /// </param>
        /// <param name="corpusKeys">
        /// Corpus keys accessed by the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteToolSpanAttributes(
            string? toolName,
            string? toolKey,
            string? toolCallId,
            string? toolType,
            string? toolInputEventId,
            string? toolOutputEventId,
            global::System.Collections.Generic.IList<string>? corpusKeys)
        {
            this.ToolName = toolName;
            this.ToolKey = toolKey;
            this.ToolCallId = toolCallId;
            this.ToolType = toolType;
            this.ToolInputEventId = toolInputEventId;
            this.ToolOutputEventId = toolOutputEventId;
            this.CorpusKeys = corpusKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteToolSpanAttributes" /> class.
        /// </summary>
        public ExecuteToolSpanAttributes()
        {
        }

    }
}