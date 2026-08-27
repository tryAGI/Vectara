
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to probe an external LLM provider endpoint and return the model configurations most likely to work. Nothing is persisted. Submit a returned candidate to `POST /v2/llms` to create the LLM.
    /// </summary>
    public sealed partial class DiscoverLLMsRequest
    {
        /// <summary>
        /// The provider endpoint URI: an http or https URL including a host. Accepts a base URL, a full chat/completions URL, or a Vertex `generateContent` URL; each is reduced to the provider's base endpoint. Optional when the credential itself identifies the provider: Anthropic (`sk-ant-…`) and OpenAI (`sk-…`) API keys, Bedrock credentials (endpoint derived from the region), `vertex_service_account`/`vertex_access_token` credentials (endpoint derived from the project and region), and the Gemini `api_key` credential (endpoint defaults to Google AI Studio). Required for any other credential, including the Gemini `service_account` credential, which declares no project or region.<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.openai.com/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Optional provider-type hint. When set, discovery is restricted to that provider; a hint that contradicts what the credential and URI imply fails with HTTP 422. When omitted, the platform infers candidate provider types from the credential shape and the URI host, and probes both the chat-completions and responses dialects for a generic OpenAI-compatible host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LLMTypeJsonConverter))]
        public global::Vectara.LLMType? Type { get; set; }

        /// <summary>
        /// The credential to authenticate the probe with. Accepts any variant that any provider supports. Omit for an unauthenticated endpoint (e.g. a self-hosted vLLM server), in which case `uri` is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LLMAuthJsonConverter))]
        public global::Vectara.LLMAuth? Auth { get; set; }

        /// <summary>
        /// Additional HTTP headers to send with the probe requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Extra parameters passed to the live verification call (e.g. `max_tokens` for providers that require it).<br/>
        /// Example: {"max_tokens":512}
        /// </summary>
        /// <example>{"max_tokens":512}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_model_parameters")]
        public object? TestModelParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverLLMsRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoverLLMsRequest(
            string? uri,
            global::Vectara.LLMType? type,
            global::Vectara.LLMAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? testModelParameters)
        {
            this.Uri = uri;
            this.Type = type;
            this.Auth = auth;
            this.Headers = headers;
            this.TestModelParameters = testModelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverLLMsRequest" /> class.
        /// </summary>
        public DiscoverLLMsRequest()
        {
        }

    }
}