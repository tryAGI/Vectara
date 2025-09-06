
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
        /// The URI endpoint for the Vertex AI API<br/>
        /// Example: https://aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1
        /// </summary>
        /// <example>https://aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1</example>
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
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </param>
        /// <param name="name">
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="model">
        /// The model name to use (e.g. gemini-2.5-flash, gemini-2.5-pro, gemini-2.0-experimental-1219, etc).
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the Vertex AI API<br/>
        /// Example: https://aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Vertex AI
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
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
            object? testModelParameters)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Auth = auth;
            this.Description = description;
            this.TestModelParameters = testModelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        public CreateVertexAILLMRequest()
        {
        }
    }
}