
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for an OpenAI-compatible encoder
    /// </summary>
    public sealed partial class CreateOpenAIEncoderRequest
    {
        /// <summary>
        /// Specifies this is an OpenAI encoder<br/>
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The unique name of the encoder<br/>
        /// Example: my-openai-encoder
        /// </summary>
        /// <example>my-openai-encoder</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what this encoder does<br/>
        /// Example: OpenAI text embedding encoder
        /// </summary>
        /// <example>OpenAI text embedding encoder</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The number of dimensions in the output embedding vector. If the encoder endpoint returns<br/>
        /// more dimensions than specified here, the response will be truncated to this number of dimensions.<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputDimensions { get; set; }

        /// <summary>
        /// The URL of the OpenAI-compatible embedding endpoint<br/>
        /// Example: https://api.openai.com/v1/embeddings
        /// </summary>
        /// <example>https://api.openai.com/v1/embeddings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointUrl { get; set; }

        /// <summary>
        /// The model name to use for embeddings<br/>
        /// Example: text-embedding-ada-002
        /// </summary>
        /// <example>text-embedding-ada-002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Authentication configuration for an LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RemoteAuth Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAIEncoderRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies this is an OpenAI encoder<br/>
        /// Default Value: openai
        /// </param>
        /// <param name="name">
        /// The unique name of the encoder<br/>
        /// Example: my-openai-encoder
        /// </param>
        /// <param name="description">
        /// A description of what this encoder does<br/>
        /// Example: OpenAI text embedding encoder
        /// </param>
        /// <param name="outputDimensions">
        /// The number of dimensions in the output embedding vector. If the encoder endpoint returns<br/>
        /// more dimensions than specified here, the response will be truncated to this number of dimensions.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="endpointUrl">
        /// The URL of the OpenAI-compatible embedding endpoint<br/>
        /// Example: https://api.openai.com/v1/embeddings
        /// </param>
        /// <param name="model">
        /// The model name to use for embeddings<br/>
        /// Example: text-embedding-ada-002
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOpenAIEncoderRequest(
            string name,
            string description,
            int outputDimensions,
            string endpointUrl,
            string model,
            global::Vectara.RemoteAuth auth,
            string? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.OutputDimensions = outputDimensions;
            this.EndpointUrl = endpointUrl ?? throw new global::System.ArgumentNullException(nameof(endpointUrl));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Auth = auth;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAIEncoderRequest" /> class.
        /// </summary>
        public CreateOpenAIEncoderRequest()
        {
        }
    }
}