
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Decrypted content of an execute_tool span.
    /// </summary>
    public sealed partial class ExecuteToolSpanContent
    {
        /// <summary>
        /// Arguments passed to the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_arguments")]
        public string? ToolArguments { get; set; }

        /// <summary>
        /// Result returned by the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_result")]
        public string? ToolResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteToolSpanContent" /> class.
        /// </summary>
        /// <param name="toolArguments">
        /// Arguments passed to the tool call.
        /// </param>
        /// <param name="toolResult">
        /// Result returned by the tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteToolSpanContent(
            string? toolArguments,
            string? toolResult)
        {
            this.ToolArguments = toolArguments;
            this.ToolResult = toolResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteToolSpanContent" /> class.
        /// </summary>
        public ExecuteToolSpanContent()
        {
        }
    }
}