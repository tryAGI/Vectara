
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for a vLLM-served embedding encoder. The endpoint must accept text-embedding requests and, when `image_encoding` is true, image-embedding requests.
    /// </summary>
    public sealed partial class CreateVLlmEncoderRequest
    {
        /// <summary>
        /// Must be "vllm-compatible" for vLLM-served embedding endpoints.<br/>
        /// Default Value: vllm-compatible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A unique name for the encoder.<br/>
        /// Example: vllm-multimodal-encoder
        /// </summary>
        /// <example>vllm-multimodal-encoder</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what this encoder does.<br/>
        /// Example: Multimodal encoder for chart and table images
        /// </summary>
        /// <example>Multimodal encoder for chart and table images</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The number of dimensions in the output embedding vector. If provided and the model supports truncation, the response will be truncated to this number of dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensions")]
        public int? OutputDimensions { get; set; }

        /// <summary>
        /// The URI endpoint for the vLLM embedding API.<br/>
        /// Example: https://my-vllm-host/v1/embeddings
        /// </summary>
        /// <example>https://my-vllm-host/v1/embeddings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// The model name to use for embeddings.<br/>
        /// Example: nomic-embed-vision-v1.5
        /// </summary>
        /// <example>nomic-embed-vision-v1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to a remote service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        public global::Vectara.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Whether the encoder produces image embeddings. When `true`, the endpoint must accept image-embedding requests; the create call validates this and fails if the endpoint does not support them.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_encoding")]
        public bool? ImageEncoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVLlmEncoderRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name for the encoder.<br/>
        /// Example: vllm-multimodal-encoder
        /// </param>
        /// <param name="description">
        /// A description of what this encoder does.<br/>
        /// Example: Multimodal encoder for chart and table images
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the vLLM embedding API.<br/>
        /// Example: https://my-vllm-host/v1/embeddings
        /// </param>
        /// <param name="model">
        /// The model name to use for embeddings.<br/>
        /// Example: nomic-embed-vision-v1.5
        /// </param>
        /// <param name="type">
        /// Must be "vllm-compatible" for vLLM-served embedding endpoints.<br/>
        /// Default Value: vllm-compatible
        /// </param>
        /// <param name="outputDimensions">
        /// The number of dimensions in the output embedding vector. If provided and the model supports truncation, the response will be truncated to this number of dimensions.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
        /// <param name="imageEncoding">
        /// Whether the encoder produces image embeddings. When `true`, the endpoint must accept image-embedding requests; the create call validates this and fails if the endpoint does not support them.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVLlmEncoderRequest(
            string name,
            string description,
            string uri,
            string model,
            string? type,
            int? outputDimensions,
            global::Vectara.RemoteAuth? auth,
            bool? imageEncoding)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.OutputDimensions = outputDimensions;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Auth = auth;
            this.ImageEncoding = imageEncoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVLlmEncoderRequest" /> class.
        /// </summary>
        public CreateVLlmEncoderRequest()
        {
        }

    }
}