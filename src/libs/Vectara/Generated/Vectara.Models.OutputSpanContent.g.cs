
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Decrypted content of an output span.
    /// </summary>
    public sealed partial class OutputSpanContent
    {
        /// <summary>
        /// The text output produced by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text")]
        public string? OutputText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSpanContent" /> class.
        /// </summary>
        /// <param name="outputText">
        /// The text output produced by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputSpanContent(
            string? outputText)
        {
            this.OutputText = outputText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSpanContent" /> class.
        /// </summary>
        public OutputSpanContent()
        {
        }
    }
}