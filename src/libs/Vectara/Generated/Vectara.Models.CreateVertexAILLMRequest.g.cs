
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a Vertex AI Large Language Model connection for Gemini models.
    /// </summary>
    public sealed partial class CreateVertexAILLMRequest
    {
        /// <summary>
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </summary>
        /// <default>"vertex-ai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "vertex-ai";

        /// <summary>
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The model name to use (e.g. gemini-2.5-flash, gemini-2.5-pro, gemini-2.0-experimental-1219, etc).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The base URI for the Gemini API. You can provide URIs in various formats — the system will normalize them automatically, stripping any model path, method suffix, or query parameters.<br/>
        /// **Vertex AI** (for service account auth): Provide the project/location base URI. Example: `https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1`<br/>
        /// **Google AI Studio** (for API key auth): Provide the Generative Language API base URI. Example: `https://generativelanguage.googleapis.com/v1beta`<br/>
        /// Full URIs copied from Google docs also work — the model path and `:generateContent` suffix will be stripped and rebuilt automatically from the `model` field.<br/>
        /// Example: https://us-central1-aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1
        /// </summary>
        /// <example>https://us-central1-aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Authentication configuration for Vertex AI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.VertexAiAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.VertexAiAuth Auth { get; set; }

        /// <summary>
        /// Additional HTTP headers to include with requests to the Gemini API.
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
        /// Any additional parameters that are required for the LLM during the test call.
        /// </summary>
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
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </param>
        /// <param name="name">
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.
        /// </param>
        /// <param name="model">
        /// The model name to use (e.g. gemini-2.5-flash, gemini-2.5-pro, gemini-2.0-experimental-1219, etc).
        /// </param>
        /// <param name="uri">
        /// The base URI for the Gemini API. You can provide URIs in various formats — the system will normalize them automatically, stripping any model path, method suffix, or query parameters.<br/>
        /// **Vertex AI** (for service account auth): Provide the project/location base URI. Example: `https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1`<br/>
        /// **Google AI Studio** (for API key auth): Provide the Generative Language API base URI. Example: `https://generativelanguage.googleapis.com/v1beta`<br/>
        /// Full URIs copied from Google docs also work — the model path and `:generateContent` suffix will be stripped and rebuilt automatically from the `model` field.<br/>
        /// Example: https://us-central1-aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Vertex AI
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to include with requests to the Gemini API.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// Maximum time in seconds the platform will wait for the model to send data before considering the connection stale and terminating it. For example, this is used as the SSE idle timeout during streaming — if no new server-sent events arrive within this window the stream is closed with an error. If unset, the platform falls back to its default read timeout for that provider (typically 60 seconds for OpenAI / Anthropic; provider SDK default for Vertex). On update, omit the field to leave the configured value unchanged or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model. If not provided when creating an LLM, capabilities are automatically inferred from the model name and provider type. Any explicitly provided fields override the inferred defaults.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVertexAILLMRequest(
            string type,
            string name,
            string model,
            string uri,
            global::Vectara.VertexAiAuth auth,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? idleTimeoutSeconds,
            object? testModelParameters,
            global::Vectara.LLMCapabilities? capabilities)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Auth = auth;
            this.Headers = headers;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        public CreateVertexAILLMRequest()
        {
        }

    }
}