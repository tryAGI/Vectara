
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Decrypted content of an invoke_agent span.
    /// </summary>
    public sealed partial class InvokeAgentSpanContent
    {
        /// <summary>
        /// Input messages sent to the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_messages")]
        public string? InputMessages { get; set; }

        /// <summary>
        /// Output messages returned by the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_messages")]
        public string? OutputMessages { get; set; }

        /// <summary>
        /// Extended thinking content, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        /// System instructions provided to the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instructions")]
        public string? SystemInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAgentSpanContent" /> class.
        /// </summary>
        /// <param name="inputMessages">
        /// Input messages sent to the LLM.
        /// </param>
        /// <param name="outputMessages">
        /// Output messages returned by the LLM.
        /// </param>
        /// <param name="thinking">
        /// Extended thinking content, if available.
        /// </param>
        /// <param name="systemInstructions">
        /// System instructions provided to the LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvokeAgentSpanContent(
            string? inputMessages,
            string? outputMessages,
            string? thinking,
            string? systemInstructions)
        {
            this.InputMessages = inputMessages;
            this.OutputMessages = outputMessages;
            this.Thinking = thinking;
            this.SystemInstructions = systemInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAgentSpanContent" /> class.
        /// </summary>
        public InvokeAgentSpanContent()
        {
        }

    }
}