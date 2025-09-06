
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
        /// Authentication configuration for an LLM
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
        /// Any additional parameters that are required for the LLM during the test call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_model_parameters")]
        public object? TestModelParameters { get; set; }

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
        /// <param name="description">
        /// Description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model
        /// </param>
        /// <param name="model">
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.<br/>
        /// Example: claude-3-7-sonnet-20250219
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)<br/>
        /// Example: https://api.anthropic.com/v1/chat/completions
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
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
            object? testModelParameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Description = description;
            this.Model = model;
            this.Auth = auth;
            this.Headers = headers;
            this.TestModelParameters = testModelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAILLMRequestBase" /> class.
        /// </summary>
        public OpenAILLMRequestBase()
        {
        }
    }
}