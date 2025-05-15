
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The parameters for the model. WARNING: This is an experimental feature, and breakable at any point with virtually no notice. It is meant for experimentation to converge on optimal parameters that can then be set in the prompt definitions.
    /// </summary>
    public sealed partial class GenerationParametersModelParameters
    {
        /// <summary>
        /// The model (e.g., `gpt-4`) to use for summarization. If specified, it will override the model behind `generation_preset_name`.<br/>
        /// Example: gpt4
        /// </summary>
        /// <example>gpt4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_name")]
        public string? LlmName { get; set; }

        /// <summary>
        /// The maximum number of tokens to be returned by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The sampling temperature to use. Higher values make the output more random, while lower values make it more focused and deterministic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Higher values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Higher values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationParametersModelParameters" /> class.
        /// </summary>
        /// <param name="llmName">
        /// The model (e.g., `gpt-4`) to use for summarization. If specified, it will override the model behind `generation_preset_name`.<br/>
        /// Example: gpt4
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to be returned by the model.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature to use. Higher values make the output more random, while lower values make it more focused and deterministic.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Higher values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </param>
        /// <param name="presencePenalty">
        /// Higher values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationParametersModelParameters(
            string? llmName,
            int? maxTokens,
            float? temperature,
            float? frequencyPenalty,
            float? presencePenalty)
        {
            this.LlmName = llmName;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationParametersModelParameters" /> class.
        /// </summary>
        public GenerationParametersModelParameters()
        {
        }
    }
}