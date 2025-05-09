
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A hallucination corrector that detects and corrects hallucinations in generated text.
    /// </summary>
    public sealed partial class HallucinationCorrector
    {
        /// <summary>
        /// The unique ID for the Hallucination Corrector (HC).<br/>
        /// Example: hcm_123
        /// </summary>
        /// <example>hcm_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The hallucination corrector name, typically including the base name and variant.<br/>
        /// Example: qwen2.5-7b-instruct-hcm
        /// </summary>
        /// <example>qwen2.5-7b-instruct-hcm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The hallucination corrector type. Defaults to `vectara`.<br/>
        /// Default Value: vectara
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A short description of the hallucination corrector’s purpose.<br/>
        /// Example: Qwen/Qwen2.5-7B-Instruct for hallucination correction in AI-generated text.
        /// </summary>
        /// <example>Qwen/Qwen2.5-7B-Instruct for hallucination correction in AI-generated text.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the hallucination corrector is enabled and available for use in hallucination correction workflows.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrector" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID for the Hallucination Corrector (HC).<br/>
        /// Example: hcm_123
        /// </param>
        /// <param name="name">
        /// The hallucination corrector name, typically including the base name and variant.<br/>
        /// Example: qwen2.5-7b-instruct-hcm
        /// </param>
        /// <param name="type">
        /// The hallucination corrector type. Defaults to `vectara`.<br/>
        /// Default Value: vectara
        /// </param>
        /// <param name="description">
        /// A short description of the hallucination corrector’s purpose.<br/>
        /// Example: Qwen/Qwen2.5-7B-Instruct for hallucination correction in AI-generated text.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the hallucination corrector is enabled and available for use in hallucination correction workflows.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HallucinationCorrector(
            string? id,
            string? name,
            string? type,
            string? description,
            bool? enabled)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrector" /> class.
        /// </summary>
        public HallucinationCorrector()
        {
        }
    }
}