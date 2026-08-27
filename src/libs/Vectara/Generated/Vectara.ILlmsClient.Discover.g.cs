#nullable enable

namespace Vectara
{
    public partial interface ILlmsClient
    {
        /// <summary>
        /// Discover LLMs<br/>
        /// Probes an external LLM provider endpoint and returns the model configurations most likely to work. The provider type and API dialect are inferred from the credential and the URI when `type` is omitted.<br/>
        /// Nothing is persisted. Combine a returned candidate with a `name` and the credential you supplied here and submit it to `POST /v2/llms`.<br/>
        /// Discovery live-tests at most three models per detected endpoint — with both OpenAI dialects probed, at most six upstream generation calls — and returns every usable model the endpoint advertises.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.DiscoverLLMsResponse> DiscoverAsync(

            global::Vectara.DiscoverLLMsRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Discover LLMs<br/>
        /// Probes an external LLM provider endpoint and returns the model configurations most likely to work. The provider type and API dialect are inferred from the credential and the URI when `type` is omitted.<br/>
        /// Nothing is persisted. Combine a returned candidate with a `name` and the credential you supplied here and submit it to `POST /v2/llms`.<br/>
        /// Discovery live-tests at most three models per detected endpoint — with both OpenAI dialects probed, at most six upstream generation calls — and returns every usable model the endpoint advertises.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.DiscoverLLMsResponse>> DiscoverAsResponseAsync(

            global::Vectara.DiscoverLLMsRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Discover LLMs<br/>
        /// Probes an external LLM provider endpoint and returns the model configurations most likely to work. The provider type and API dialect are inferred from the credential and the URI when `type` is omitted.<br/>
        /// Nothing is persisted. Combine a returned candidate with a `name` and the credential you supplied here and submit it to `POST /v2/llms`.<br/>
        /// Discovery live-tests at most three models per detected endpoint — with both OpenAI dialects probed, at most six upstream generation calls — and returns every usable model the endpoint advertises.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="uri">
        /// The provider endpoint URI: an http or https URL including a host. Accepts a base URL, a full chat/completions URL, or a Vertex `generateContent` URL; each is reduced to the provider's base endpoint. Optional when the credential itself identifies the provider: Anthropic (`sk-ant-…`) and OpenAI (`sk-…`) API keys, Bedrock credentials (endpoint derived from the region), `vertex_service_account`/`vertex_access_token` credentials (endpoint derived from the project and region), and the Gemini `api_key` credential (endpoint defaults to Google AI Studio). Required for any other credential, including the Gemini `service_account` credential, which declares no project or region.<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </param>
        /// <param name="type">
        /// Optional provider-type hint. When set, discovery is restricted to that provider; a hint that contradicts what the credential and URI imply fails with HTTP 422. When omitted, the platform infers candidate provider types from the credential shape and the URI host, and probes both the chat-completions and responses dialects for a generic OpenAI-compatible host.
        /// </param>
        /// <param name="auth">
        /// The credential to authenticate the probe with. Accepts any variant that any provider supports. Omit for an unauthenticated endpoint (e.g. a self-hosted vLLM server), in which case `uri` is required.
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to send with the probe requests.
        /// </param>
        /// <param name="testModelParameters">
        /// Extra parameters passed to the live verification call (e.g. `max_tokens` for providers that require it).<br/>
        /// Example: {"max_tokens":512}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.DiscoverLLMsResponse> DiscoverAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? uri = default,
            global::Vectara.LLMType? type = default,
            global::Vectara.LLMAuth? auth = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            object? testModelParameters = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}