
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A Large Language Model. An LLM enhances query results with a generated response and acts as the responder during a chat.
    /// </summary>
    public sealed partial class Llm
    {
        /// <summary>
        /// The ID of the LLM.<br/>
        /// Example: llm_1021844
        /// </summary>
        /// <example>llm_1021844</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the LLM.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </summary>
        /// <example>Claude 3.7 Sonnet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model.
        /// </summary>
        /// <example>The Anthropic Claude 3.7 Sonnet model.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the LLM is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether this is the default LLM. Queries use the default LLM when they do not specify a generator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// The capabilities of a Large Language Model. If you do not provide capabilities when you create an LLM, the platform infers them from the model name and provider type. Fields you provide explicitly override the inferred defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vectara.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Indicates whether the LLM is provided by the platform or created by the customer. Platform LLMs are pre-configured and cannot be modified or deleted. Customer LLMs are created and managed by the customer.<br/>
        /// Example: platform
        /// </summary>
        /// <example>platform</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LLMOwnershipJsonConverter))]
        public global::Vectara.LLMOwnership? Ownership { get; set; }

        /// <summary>
        /// The provider type. It determines which authentication and configuration apply. Responses always include this field. If a stored LLM cannot be mapped to one of these values, the request fails with HTTP 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LlmTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.LlmType Type { get; set; }

        /// <summary>
        /// Provider-specific model identifier (e.g. `gpt-4o`, `claude-3-5-sonnet-20241022`, `gemini-2.5-flash`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The API endpoint URI configured for this LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional HTTP headers configured for requests to the LLM API. Not applicable to `vertex-ai`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The maximum time in seconds that the platform waits for the model to send data before it closes the stale connection. During streaming, this is the SSE idle timeout. If no new server-sent events arrive within this window, the stream closes with an error. For non-streaming requests, where the model sends the entire response at once, this is the maximum time to wait for that response. If unset, the platform uses its default read timeout for the provider. On update, omit the field to keep the configured value, or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_seconds")]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// The maximum number of requests per second for this LLM. The platform omits this field when the LLM has no limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public long? RequestsPerSecond { get; set; }

        /// <summary>
        /// The authentication configuration for an LLM. It is a union over every variant any LLM provider accepts. In `GET` responses, secret fields contain the literal string `****`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LLMAuthJsonConverter))]
        public global::Vectara.LLMAuth? Auth { get; set; }

        /// <summary>
        /// List of prompts that the model can use. This is deprecated; see `/v2/generation_presets` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Vectara.Prompt>? Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Llm" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the LLM.<br/>
        /// Example: llm_1021844
        /// </param>
        /// <param name="name">
        /// Name of the LLM.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </param>
        /// <param name="type">
        /// The provider type. It determines which authentication and configuration apply. Responses always include this field. If a stored LLM cannot be mapped to one of these values, the request fails with HTTP 500.
        /// </param>
        /// <param name="description">
        /// The description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the LLM is enabled.
        /// </param>
        /// <param name="default">
        /// Whether this is the default LLM. Queries use the default LLM when they do not specify a generator.
        /// </param>
        /// <param name="capabilities">
        /// The capabilities of a Large Language Model. If you do not provide capabilities when you create an LLM, the platform infers them from the model name and provider type. Fields you provide explicitly override the inferred defaults.
        /// </param>
        /// <param name="ownership">
        /// Indicates whether the LLM is provided by the platform or created by the customer. Platform LLMs are pre-configured and cannot be modified or deleted. Customer LLMs are created and managed by the customer.<br/>
        /// Example: platform
        /// </param>
        /// <param name="model">
        /// Provider-specific model identifier (e.g. `gpt-4o`, `claude-3-5-sonnet-20241022`, `gemini-2.5-flash`).
        /// </param>
        /// <param name="uri">
        /// The API endpoint URI configured for this LLM.
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers configured for requests to the LLM API. Not applicable to `vertex-ai`.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// The maximum time in seconds that the platform waits for the model to send data before it closes the stale connection. During streaming, this is the SSE idle timeout. If no new server-sent events arrive within this window, the stream closes with an error. For non-streaming requests, where the model sends the entire response at once, this is the maximum time to wait for that response. If unset, the platform uses its default read timeout for the provider. On update, omit the field to keep the configured value, or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </param>
        /// <param name="requestsPerSecond">
        /// The maximum number of requests per second for this LLM. The platform omits this field when the LLM has no limit.
        /// </param>
        /// <param name="auth">
        /// The authentication configuration for an LLM. It is a union over every variant any LLM provider accepts. In `GET` responses, secret fields contain the literal string `****`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Llm(
            string id,
            string name,
            global::Vectara.LlmType type,
            string? description,
            bool? enabled,
            bool? @default,
            global::Vectara.LLMCapabilities? capabilities,
            global::Vectara.LLMOwnership? ownership,
            string? model,
            string? uri,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? idleTimeoutSeconds,
            long? requestsPerSecond,
            global::Vectara.LLMAuth? auth)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Enabled = enabled;
            this.Default = @default;
            this.Capabilities = capabilities;
            this.Ownership = ownership;
            this.Type = type;
            this.Model = model;
            this.Uri = uri;
            this.Headers = headers;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
            this.RequestsPerSecond = requestsPerSecond;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Llm" /> class.
        /// </summary>
        public Llm()
        {
        }

    }
}