
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v1 message or artifact content part. Exactly one of `text`, `raw`, `url`, or `data` is populated. Optional `metadata`, `filename`, and `mediaType` siblings are valid for any variant.
    /// </summary>
    public sealed partial class A2aV1Part
    {
        /// <summary>
        /// Plain-text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Inline base64-encoded raw bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public byte[]? Raw { get; set; }

        /// <summary>
        /// URL pointing to the file's content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Arbitrary structured JSON value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with this part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Name of the file, when this part carries a file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Media type of the part's content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        public string? MediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1Part" /> class.
        /// </summary>
        /// <param name="text">
        /// Plain-text content.
        /// </param>
        /// <param name="raw">
        /// Inline base64-encoded raw bytes.
        /// </param>
        /// <param name="url">
        /// URL pointing to the file's content.
        /// </param>
        /// <param name="data">
        /// Arbitrary structured JSON value.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with this part.
        /// </param>
        /// <param name="filename">
        /// Name of the file, when this part carries a file.
        /// </param>
        /// <param name="mediaType">
        /// Media type of the part's content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1Part(
            string? text,
            byte[]? raw,
            string? url,
            object? data,
            object? metadata,
            string? filename,
            string? mediaType)
        {
            this.Text = text;
            this.Raw = raw;
            this.Url = url;
            this.Data = data;
            this.Metadata = metadata;
            this.Filename = filename;
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1Part" /> class.
        /// </summary>
        public A2aV1Part()
        {
        }

    }
}