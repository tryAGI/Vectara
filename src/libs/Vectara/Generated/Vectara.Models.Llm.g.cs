
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A LLM can be used to enhance query results with a response, and be used as the responder during a chat.
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
        /// If this is the default LLM, it is used in queries when the generator is not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Capabilities of a Large Language Model. If not provided when creating an LLM, capabilities are automatically inferred from the model name and provider type. Any explicitly provided fields override the inferred defaults.
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
        /// Provider type identifying which authentication and configuration apply. Required on responses; the server fails closed (HTTP 500) for any stored LLM whose connection spec it cannot map to one of these values.
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
        /// API endpoint URI configured for this LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Additional HTTP headers configured for requests to the LLM API. Not applicable to `vertex-ai`.
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
        /// Authentication configuration for an LLM. Union over every variant any LLM provider accepts. When returned on `GET`, secret fields contain the literal string `****`.
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
        /// Provider type identifying which authentication and configuration apply. Required on responses; the server fails closed (HTTP 500) for any stored LLM whose connection spec it cannot map to one of these values.
        /// </param>
        /// <param name="description">
        /// The description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the LLM is enabled.
        /// </param>
        /// <param name="default">
        /// If this is the default LLM, it is used in queries when the generator is not specified.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model. If not provided when creating an LLM, capabilities are automatically inferred from the model name and provider type. Any explicitly provided fields override the inferred defaults.
        /// </param>
        /// <param name="ownership">
        /// Indicates whether the LLM is provided by the platform or created by the customer. Platform LLMs are pre-configured and cannot be modified or deleted. Customer LLMs are created and managed by the customer.<br/>
        /// Example: platform
        /// </param>
        /// <param name="model">
        /// Provider-specific model identifier (e.g. `gpt-4o`, `claude-3-5-sonnet-20241022`, `gemini-2.5-flash`).
        /// </param>
        /// <param name="uri">
        /// API endpoint URI configured for this LLM.
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers configured for requests to the LLM API. Not applicable to `vertex-ai`.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// Maximum time in seconds the platform will wait for the model to send data before considering the connection stale and terminating it. For example, this is used as the SSE idle timeout during streaming — if no new server-sent events arrive within this window the stream is closed with an error. If unset, the platform falls back to its default read timeout for that provider (typically 60 seconds for OpenAI / Anthropic; provider SDK default for Vertex). On update, omit the field to leave the configured value unchanged or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM. Union over every variant any LLM provider accepts. When returned on `GET`, secret fields contain the literal string `****`.
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