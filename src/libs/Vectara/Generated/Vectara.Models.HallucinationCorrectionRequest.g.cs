
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The request to detect and correct hallucinations in generated text.
    /// </summary>
    public sealed partial class HallucinationCorrectionRequest
    {
        /// <summary>
        /// The generated text to be evaluated. The hallucination corrector reviews this text and applies corrections based on the provided source documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedText { get; set; }

        /// <summary>
        /// The source documents that were used to generate the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument> Documents { get; set; }

        /// <summary>
        /// The name of the LLM model to use for hallucination correction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrectionRequest" /> class.
        /// </summary>
        /// <param name="generatedText">
        /// The generated text to be evaluated. The hallucination corrector reviews this text and applies corrections based on the provided source documents.
        /// </param>
        /// <param name="documents">
        /// The source documents that were used to generate the text.
        /// </param>
        /// <param name="model">
        /// The name of the LLM model to use for hallucination correction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HallucinationCorrectionRequest(
            string generatedText,
            global::System.Collections.Generic.IList<global::Vectara.HcmSourceDocument> documents,
            string model)
        {
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrectionRequest" /> class.
        /// </summary>
        public HallucinationCorrectionRequest()
        {
        }
    }
}