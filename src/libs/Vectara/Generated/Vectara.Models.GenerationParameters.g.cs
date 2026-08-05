
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The parameters to control generation.
    /// </summary>
    public sealed partial class GenerationParameters
    {
        /// <summary>
        /// Whether generation is enabled for this query. Chat requests ignore this field.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The name of the generation preset that supplies default values for generation.<br/>
        /// A `generation_preset` is an object with a bundle of properties that specifies:<br/>
        /// * The `prompt_template` that is rendered and then sent to the LLM.<br/>
        /// * The LLM to use.<br/>
        /// * `model_parameter`s such as temperature.<br/>
        /// You can override any of these properties by setting them in this object. Set `model_parameters.llm_name` to override the model that `generation_preset_name` selects.<br/>
        /// If `generation_preset_name` is not set, the platform uses the default model and prompt.<br/>
        /// Example: mockingbird-2.0
        /// </summary>
        /// <example>mockingbird-2.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_preset_name")]
        public string? GenerationPresetName { get; set; }

        /// <summary>
        /// Use `generation_preset_name` instead of `prompt_name`.<br/>
        /// Example: mockingbird-2.0
        /// </summary>
        /// <example>mockingbird-2.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The maximum number of search results available to the prompt.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_used_search_results")]
        public int? MaxUsedSearchResults { get; set; }

        /// <summary>
        /// The template that renders the prompt sent to the generative LLM. By default, the platform manages the system and user roles and prompts for the generative LLM. Set this field to override the default prompts. The `prompt_template` is an Apache Velocity template. For details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </summary>
        /// <example>
        /// [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Deprecated. Use `prompt_template` instead. If `prompt_template` is set, the platform ignores this property.<br/>
        /// Example: [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </summary>
        /// <example>
        /// [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_text")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Controls the length of the generated output. This is a rough estimate and not a hard limit: the end output can be longer or shorter than this value. The platform includes `max_response_characters` in the prompt, so the LLM's instruction-following capability dictates how closely the output stays within the limit.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_characters")]
        public int? MaxResponseCharacters { get; set; }

        /// <summary>
        /// Languages that the platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LanguageJsonConverter))]
        public global::Vectara.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The parameters for the model. WARNING: This is an experimental feature that can change at any point with virtually no notice. Use it to converge on optimal parameters, then set them in the prompt definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public global::Vectara.GenerationParametersModelParameters? ModelParameters { get; set; }

        /// <summary>
        /// Style the generator should use when making citations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::Vectara.CitationParameters? Citations { get; set; }

        /// <summary>
        /// Whether to return the factual consistency score with query results.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_factual_consistency_score")]
        public bool? EnableFactualConsistencyScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationParameters" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether generation is enabled for this query. Chat requests ignore this field.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="generationPresetName">
        /// The name of the generation preset that supplies default values for generation.<br/>
        /// A `generation_preset` is an object with a bundle of properties that specifies:<br/>
        /// * The `prompt_template` that is rendered and then sent to the LLM.<br/>
        /// * The LLM to use.<br/>
        /// * `model_parameter`s such as temperature.<br/>
        /// You can override any of these properties by setting them in this object. Set `model_parameters.llm_name` to override the model that `generation_preset_name` selects.<br/>
        /// If `generation_preset_name` is not set, the platform uses the default model and prompt.<br/>
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="maxUsedSearchResults">
        /// The maximum number of search results available to the prompt.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="promptTemplate">
        /// The template that renders the prompt sent to the generative LLM. By default, the platform manages the system and user roles and prompts for the generative LLM. Set this field to override the default prompts. The `prompt_template` is an Apache Velocity template. For details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: [<br/>
        ///   {"role": "system", "content": "You are a helpful search assistant."},<br/>
        ///   #foreach ($qResult in $vectaraQueryResults)<br/>
        ///      {"role": "user", "content": "Given the $vectaraIdxWord[$foreach.index] search result."},<br/>
        ///      {"role": "assistant", "content": "${qResult.getText()}" },<br/>
        ///   #end<br/>
        ///   {"role": "user", "content": "Generate a summary for the query '${vectaraQuery}' based on the above results."}<br/>
        /// ]
        /// </param>
        /// <param name="maxResponseCharacters">
        /// Controls the length of the generated output. This is a rough estimate and not a hard limit: the end output can be longer or shorter than this value. The platform includes `max_response_characters` in the prompt, so the LLM's instruction-following capability dictates how closely the output stays within the limit.<br/>
        /// Example: 300
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="modelParameters">
        /// The parameters for the model. WARNING: This is an experimental feature that can change at any point with virtually no notice. Use it to converge on optimal parameters, then set them in the prompt definitions.
        /// </param>
        /// <param name="citations">
        /// Style the generator should use when making citations.
        /// </param>
        /// <param name="enableFactualConsistencyScore">
        /// Whether to return the factual consistency score with query results.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationParameters(
            bool? enabled,
            string? generationPresetName,
            int? maxUsedSearchResults,
            string? promptTemplate,
            int? maxResponseCharacters,
            global::Vectara.Language? responseLanguage,
            global::Vectara.GenerationParametersModelParameters? modelParameters,
            global::Vectara.CitationParameters? citations,
            bool? enableFactualConsistencyScore)
        {
            this.Enabled = enabled;
            this.GenerationPresetName = generationPresetName;
            this.MaxUsedSearchResults = maxUsedSearchResults;
            this.PromptTemplate = promptTemplate;
            this.MaxResponseCharacters = maxResponseCharacters;
            this.ResponseLanguage = responseLanguage;
            this.ModelParameters = modelParameters;
            this.Citations = citations;
            this.EnableFactualConsistencyScore = enableFactualConsistencyScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationParameters" /> class.
        /// </summary>
        public GenerationParameters()
        {
        }

    }
}