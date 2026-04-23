#nullable enable

namespace Vectara
{
    public partial interface IGenerationPresetsClient
    {
        /// <summary>
        /// Create a generation preset<br/>
        /// Create a custom generation preset for use in query and chat requests. A generation preset bundles a prompt template, an LLM, and model parameters into a reusable configuration.<br/>
        /// The created preset can be referenced by name using the `generation_preset_name` field in query or chat requests.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GenerationPreset> CreateAsync(

            global::Vectara.CreateGenerationPresetRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a generation preset<br/>
        /// Create a custom generation preset for use in query and chat requests. A generation preset bundles a prompt template, an LLM, and model parameters into a reusable configuration.<br/>
        /// The created preset can be referenced by name using the `generation_preset_name` field in query or chat requests.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="id">
        /// The ID of the generation preset.<br/>
        /// Example: gnp_123
        /// </param>
        /// <param name="name">
        /// Name of the generation preset to be used with configuring generation.<br/>
        /// Example: Mockingbird 2.0
        /// </param>
        /// <param name="description">
        /// Description of the generation preset.<br/>
        /// Example: Mockingbird LLM 2.0 prompt for summarizing query results as an answer. Designed for RAG.
        /// </param>
        /// <param name="llmName">
        /// Name of the model that these presets are used with. The list of available names can be fetched by the `GET /v2/llms` endpoint.<br/>
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="promptTemplate">
        /// Preset template used to render the prompt sent to generation.
        /// </param>
        /// <param name="maxUsedSearchResults">
        /// Preset maximum number of search results that will be available to the prompt.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxTokens">
        /// Preset maximum number of tokens to be returned by the generation.<br/>
        /// Example: 500
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature to use. Higher values make the output more random, while lower values make it more focused and deterministic.<br/>
        /// Example: 0.4
        /// </param>
        /// <param name="frequencyPenalty">
        /// Higher values penalize new tokens based on their existing frequency in the generation so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Example: 0.2
        /// </param>
        /// <param name="presencePenalty">
        /// Higher values penalize new tokens based on whether they appear in the generation so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Example: 0.2
        /// </param>
        /// <param name="additionalModelParams">
        /// Additional model parameters beyond the standard fields above.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the prompt is enabled.
        /// </param>
        /// <param name="default">
        /// Indicates if this prompt is the default prompt used with the LLM.
        /// </param>
        /// <param name="ownership">
        /// Indicates whether the generation preset is provided by the platform or created by the customer. Platform presets are pre-configured and cannot be modified or deleted. Customer presets are created and managed by the customer.<br/>
        /// Example: platform
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GenerationPreset> CreateAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? id = default,
            string? name = default,
            string? description = default,
            string? llmName = default,
            string? promptTemplate = default,
            int? maxUsedSearchResults = default,
            int? maxTokens = default,
            float? temperature = default,
            float? frequencyPenalty = default,
            float? presencePenalty = default,
            object? additionalModelParams = default,
            bool? enabled = default,
            bool? @default = default,
            global::Vectara.GenerationPresetOwnership? ownership = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}