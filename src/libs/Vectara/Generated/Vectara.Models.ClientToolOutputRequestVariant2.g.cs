
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientToolOutputRequestVariant2
    {
        /// <summary>
        /// Always `tool_output`. Identifies this input as a client tool output submission.<br/>
        /// Default Value: tool_output
        /// </summary>
        /// <default>"tool_output"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "tool_output";

        /// <summary>
        /// The tool outputs to deliver, one per pending client tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.CreateToolOutputRequest> ToolOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolOutputRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `tool_output`. Identifies this input as a client tool output submission.<br/>
        /// Default Value: tool_output
        /// </param>
        /// <param name="toolOutputs">
        /// The tool outputs to deliver, one per pending client tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolOutputRequestVariant2(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.CreateToolOutputRequest> toolOutputs)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolOutputRequestVariant2" /> class.
        /// </summary>
        public ClientToolOutputRequestVariant2()
        {
        }

    }
}