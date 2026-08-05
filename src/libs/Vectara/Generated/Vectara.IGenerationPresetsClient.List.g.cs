#nullable enable

namespace Vectara
{
    public partial interface IGenerationPresetsClient
    {
        /// <summary>
        /// List generation presets<br/>
        /// Lists the generation presets used for [query](/docs/rest-api/queries) requests. The platform creates and maintains predefined generation presets. A generation preset groups several properties that configure generation for a request. This includes the `prompt_template`, the Large Language Model (LLM), and other generation settings like `max_tokens` and `temperature`. Each preset includes a complete Velocity template for the prompt. Presets are typically associated with a single LLM.<br/>
        /// Specify a generation preset in query or chat requests with the `generation_preset_name` field.<br/>
        /// ## Generation presets object<br/>
        /// The `generation_presets` object contains the `name`, `description`, `llm_name`, `prompt_template`, and other fields that make up the preset.<br/>
        /// If your account has access to a preset, `enabled` is set to `true`. A preset can also be set as a `default`.<br/>
        /// ### Example generation presets response<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generation_presets": [<br/>
        ///     {<br/>
        ///       "name": "vectara-summary-ext-24-05-med-omni",<br/>
        ///       "description": "Generate summary with controllable citations, Uses GPT-4o with 2,048 max tokens",<br/>
        ///       "llm_name": "gpt-4o",<br/>
        ///       "prompt_template": "[\n    {\"role\": \"system\", \"content\": \"Follow these detailed step-by-step",<br/>
        ///       "max_used_search_results": 25,<br/>
        ///       "max_tokens": 2048,<br/>
        ///       "temperature": 0,<br/>
        ///       "frequency_penalty": 0,<br/>
        ///       "presence_penalty": 0,<br/>
        ///       "enabled": true,<br/>
        ///       "default": false<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmName">
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="filter">
        /// Example: mockingbird.*
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListGenerationPresetsResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? llmName = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List generation presets<br/>
        /// Lists the generation presets used for [query](/docs/rest-api/queries) requests. The platform creates and maintains predefined generation presets. A generation preset groups several properties that configure generation for a request. This includes the `prompt_template`, the Large Language Model (LLM), and other generation settings like `max_tokens` and `temperature`. Each preset includes a complete Velocity template for the prompt. Presets are typically associated with a single LLM.<br/>
        /// Specify a generation preset in query or chat requests with the `generation_preset_name` field.<br/>
        /// ## Generation presets object<br/>
        /// The `generation_presets` object contains the `name`, `description`, `llm_name`, `prompt_template`, and other fields that make up the preset.<br/>
        /// If your account has access to a preset, `enabled` is set to `true`. A preset can also be set as a `default`.<br/>
        /// ### Example generation presets response<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generation_presets": [<br/>
        ///     {<br/>
        ///       "name": "vectara-summary-ext-24-05-med-omni",<br/>
        ///       "description": "Generate summary with controllable citations, Uses GPT-4o with 2,048 max tokens",<br/>
        ///       "llm_name": "gpt-4o",<br/>
        ///       "prompt_template": "[\n    {\"role\": \"system\", \"content\": \"Follow these detailed step-by-step",<br/>
        ///       "max_used_search_results": 25,<br/>
        ///       "max_tokens": 2048,<br/>
        ///       "temperature": 0,<br/>
        ///       "frequency_penalty": 0,<br/>
        ///       "presence_penalty": 0,<br/>
        ///       "enabled": true,<br/>
        ///       "default": false<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmName">
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="filter">
        /// Example: mockingbird.*
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListGenerationPresetsResponse>> ListAsResponseAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? llmName = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}