
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v0.3 file attachment. Exactly one of `fileWithUri` or `fileWithBytes` is populated.
    /// </summary>
    public sealed partial class A2aV03FilePart
    {
        /// <summary>
        /// URI to the file's content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileWithUri")]
        public string? FileWithUri { get; set; }

        /// <summary>
        /// Inline base64-encoded file bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileWithBytes")]
        public byte[]? FileWithBytes { get; set; }

        /// <summary>
        /// Media type of the file content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03FilePart" /> class.
        /// </summary>
        /// <param name="fileWithUri">
        /// URI to the file's content.
        /// </param>
        /// <param name="fileWithBytes">
        /// Inline base64-encoded file bytes.
        /// </param>
        /// <param name="mimeType">
        /// Media type of the file content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03FilePart(
            string? fileWithUri,
            byte[]? fileWithBytes,
            string? mimeType)
        {
            this.FileWithUri = fileWithUri;
            this.FileWithBytes = fileWithBytes;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03FilePart" /> class.
        /// </summary>
        public A2aV03FilePart()
        {
        }

    }
}