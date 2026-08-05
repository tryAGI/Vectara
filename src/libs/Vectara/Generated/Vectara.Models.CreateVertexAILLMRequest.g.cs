
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
        /// The name that references the LLM. Other endpoints (like query) use this name to select the LLM. If the name conflicts with a global LLM (an LLM that is preconfigured with the platform), this LLM overrides the global LLM for all usages.
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
        /// The base URI for the Gemini API. You can provide URIs in various formats. The platform normalizes them automatically and strips any model path, method suffix, or query parameters.<br/>
        /// **Vertex AI** (for service account auth): Provide the project/location base URI. Example: `https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1`<br/>
        /// **Google AI Studio** (for API key auth): Provide the Generative Language API base URI. Example: `https://generativelanguage.googleapis.com/v1beta`<br/>
        /// Full URIs copied from Google docs also work. The platform strips the model path and `:generateContent` suffix and rebuilds them from the `model` field.<br/>
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
        /// The maximum time in seconds that the platform waits for the model to send data before it closes the stale connection. During streaming, this is the SSE idle timeout. If no new server-sent events arrive within this window, the stream closes with an error. For non-streaming requests, where the model sends the entire response at once, this is the maximum time to wait for that response. If unset, the platform uses its default read timeout for the provider. On update, omit the field to keep the configured value, or send an explicit null to clear it.<br/>
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
        /// The capabilities of a Large Language Model. If you do not provide capabilities when you create an LLM, the platform infers them from the model name and provider type. Fields you provide explicitly override the inferred defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vectara.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// The maximum number of requests per second for this LLM. Omit the field or set it to null to apply no limit. The platform rejects requests above the limit with HTTP 429.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public long? RequestsPerSecond { get; set; }

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
        /// The name that references the LLM. Other endpoints (like query) use this name to select the LLM. If the name conflicts with a global LLM (an LLM that is preconfigured with the platform), this LLM overrides the global LLM for all usages.
        /// </param>
        /// <param name="model">
        /// The model name to use (e.g. gemini-2.5-flash, gemini-2.5-pro, gemini-2.0-experimental-1219, etc).
        /// </param>
        /// <param name="uri">
        /// The base URI for the Gemini API. You can provide URIs in various formats. The platform normalizes them automatically and strips any model path, method suffix, or query parameters.<br/>
        /// **Vertex AI** (for service account auth): Provide the project/location base URI. Example: `https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1`<br/>
        /// **Google AI Studio** (for API key auth): Provide the Generative Language API base URI. Example: `https://generativelanguage.googleapis.com/v1beta`<br/>
        /// Full URIs copied from Google docs also work. The platform strips the model path and `:generateContent` suffix and rebuilds them from the `model` field.<br/>
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
        /// The maximum time in seconds that the platform waits for the model to send data before it closes the stale connection. During streaming, this is the SSE idle timeout. If no new server-sent events arrive within this window, the stream closes with an error. For non-streaming requests, where the model sends the entire response at once, this is the maximum time to wait for that response. If unset, the platform uses its default read timeout for the provider. On update, omit the field to keep the configured value, or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
        /// <param name="capabilities">
        /// The capabilities of a Large Language Model. If you do not provide capabilities when you create an LLM, the platform infers them from the model name and provider type. Fields you provide explicitly override the inferred defaults.
        /// </param>
        /// <param name="requestsPerSecond">
        /// The maximum number of requests per second for this LLM. Omit the field or set it to null to apply no limit. The platform rejects requests above the limit with HTTP 429.
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
            global::Vectara.LLMCapabilities? capabilities,
            long? requestsPerSecond)
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
            this.RequestsPerSecond = requestsPerSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        public CreateVertexAILLMRequest()
        {
        }

    }
}