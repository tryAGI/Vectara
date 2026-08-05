
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update a Vertex AI Large Language Model connection. All fields are optional.
    /// </summary>
    public sealed partial class UpdateVertexAILLMRequest
    {
        /// <summary>
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The model identifier to use for this LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The base URI for the Gemini API. Accepts Vertex AI or Google AI Studio URIs in any format.<br/>
        /// See the create endpoint for full details and examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Authentication configuration for Vertex AI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.VertexAiAuthJsonConverter))]
        public global::Vectara.VertexAiAuth? Auth { get; set; }

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
        /// Whether the LLM is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

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
        /// The maximum number of requests per second for this LLM.<br/>
        /// - Set a value to apply that limit.<br/>
        /// - Set the field to null to remove the limit.<br/>
        /// - Omit the field to keep the current limit.<br/>
        /// The platform rejects requests above the limit with HTTP 429.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public long? RequestsPerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVertexAILLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </param>
        /// <param name="model">
        /// The model identifier to use for this LLM.
        /// </param>
        /// <param name="uri">
        /// The base URI for the Gemini API. Accepts Vertex AI or Google AI Studio URIs in any format.<br/>
        /// See the create endpoint for full details and examples.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Vertex AI
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to include with requests to the Gemini API.
        /// </param>
        /// <param name="idleTimeoutSeconds">
        /// The maximum time in seconds that the platform waits for the model to send data before it closes the stale connection. During streaming, this is the SSE idle timeout. If no new server-sent events arrive within this window, the stream closes with an error. For non-streaming requests, where the model sends the entire response at once, this is the maximum time to wait for that response. If unset, the platform uses its default read timeout for the provider. On update, omit the field to keep the configured value, or send an explicit null to clear it.<br/>
        /// Example: 300
        /// </param>
        /// <param name="enabled">
        /// Whether the LLM is enabled.
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
        /// <param name="capabilities">
        /// The capabilities of a Large Language Model. If you do not provide capabilities when you create an LLM, the platform infers them from the model name and provider type. Fields you provide explicitly override the inferred defaults.
        /// </param>
        /// <param name="requestsPerSecond">
        /// The maximum number of requests per second for this LLM.<br/>
        /// - Set a value to apply that limit.<br/>
        /// - Set the field to null to remove the limit.<br/>
        /// - Omit the field to keep the current limit.<br/>
        /// The platform rejects requests above the limit with HTTP 429.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVertexAILLMRequest(
            string? type,
            string? model,
            string? uri,
            string? description,
            global::Vectara.VertexAiAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? idleTimeoutSeconds,
            bool? enabled,
            object? testModelParameters,
            global::Vectara.LLMCapabilities? capabilities,
            long? requestsPerSecond)
        {
            this.Type = type;
            this.Model = model;
            this.Uri = uri;
            this.Description = description;
            this.Auth = auth;
            this.Headers = headers;
            this.IdleTimeoutSeconds = idleTimeoutSeconds;
            this.Enabled = enabled;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
            this.RequestsPerSecond = requestsPerSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVertexAILLMRequest" /> class.
        /// </summary>
        public UpdateVertexAILLMRequest()
        {
        }

    }
}