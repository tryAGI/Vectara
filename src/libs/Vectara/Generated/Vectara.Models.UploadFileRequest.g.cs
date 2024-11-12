
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFileRequest
    {
        /// <summary>
        /// Arbitrary object that will be attached as document metadata to the extracted document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// (Optional) Choose how to split documents into chunks during indexing. If you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        public global::Vectara.MaxCharsChunkingStrategy? ChunkingStrategy { get; set; }

        /// <summary>
        /// Optional multipart section to override the filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Arbitrary object that will be attached as document metadata to the extracted document.
        /// </param>
        /// <param name="chunkingStrategy">
        /// (Optional) Choose how to split documents into chunks during indexing. If you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.
        /// </param>
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadFileRequest(
            byte[] file,
            object? metadata,
            global::Vectara.MaxCharsChunkingStrategy? chunkingStrategy,
            string? filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Metadata = metadata;
            this.ChunkingStrategy = chunkingStrategy;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        public UploadFileRequest()
        {
        }
    }
}