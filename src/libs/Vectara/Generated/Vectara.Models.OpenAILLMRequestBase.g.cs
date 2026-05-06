
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common fields for OpenAI-compatible and Responses API LLM requests.
    /// </summary>
    public sealed partial class OpenAILLMRequestBase
    {
        /// <summary>
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </summary>
        /// <example>Claude 3.7 Sonnet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model
        /// </summary>
        /// <example>The Anthropic Claude 3.7 Sonnet model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.<br/>
        /// Example: claude-3-7-sonnet-20250219
        /// </summary>
        /// <example>claude-3-7-sonnet-20250219</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)<br/>
        /// Example: https://api.anthropic.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.anthropic.com/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to a remote service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        public global::Vectara.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Maximum time in seconds the platform will wait for the model to send data before considering the connection stale and terminating it. For example, this is used as the SSE idle timeout during streaming — if no new server-sent events arrive within this window the stream is closed with an error. If unset, the platform falls back to its default read timeout for that provider (typically 60 seconds for OpenAI / Anthropic; provider SDK default for Vertex). On update, omit the field to leave the configured value unchanged or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_seconds")]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// Any additional parameters that are required for the LLM during the test call.<br/>
        /// Example: {"max_tokens":512}
        /// </summary>
        /// <example>{"max_tokens":512}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_model_parameters")]
        public object? TestModelParameters { get; set; }

        /// <summary>
        /// Capabilities of a Large Language Model. If not provided when creating an LLM, capabilities are automatically inferred from the model name and provider type. Any explicitly provided fields override the inferred defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vectara.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAILLMRequestBase" /> class.
        /// </summary>
        /// <param name="name">
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)<br/>
        /// Example: https://api.anthropic.com/v1/chat/completions
        /// </param>
        /// <param name="description">
        /// Description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model
        /// </param>
        /// <param name="model">
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.<br/>
        /// Example: claude-3-7-sonnet-20250219
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// Maximum time in seconds the platform will wait for the model to send data before considering the connection stale and terminating it. For example, this is used as the SSE idle timeout during streaming — if no new server-sent events arrive within this window the stream is closed with an error. If unset, the platform falls back to its default read timeout for that provider (typically 60 seconds for OpenAI / Anthropic; provider SDK default for Vertex). On update, omit the field to leave the configured value unchanged or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.<br/>
        /// Example: {"max_tokens":512}
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model. If not provided when creating an LLM, capabilities are automatically inferred from the model name and provider type. Any explicitly provided fields override the inferred defaults.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAILLMRequestBase(
            string name,
            string uri,
            string? description,
            string? model,
            global::Vectara.RemoteAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? idleTimeoutSeconds,
            object? testModelParameters,
            global::Vectara.LLMCapabilities? capabilities)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Model = model;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Auth = auth;
            this.Headers = headers;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAILLMRequestBase" /> class.
        /// </summary>
        public OpenAILLMRequestBase()
        {
        }
    }
}