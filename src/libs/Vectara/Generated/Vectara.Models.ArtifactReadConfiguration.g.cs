
#nullable enable

namespace Vectara
{
    /// <summary>
    /// User-configurable settings for the artifact read tool.
    /// </summary>
    public sealed partial class ArtifactReadConfiguration
    {
        /// <summary>
        /// Maximum size of any response, in bytes. A full read of a larger artifact is rejected and must be read by line range; a line range holding more is rejected naming the lines that fit. Under base64 encoding this bounds the encoded text, which is 4 bytes for every 3 bytes of the artifact.<br/>
        /// Default Value: 262144
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_size_bytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Maximum number of lines a range-based read returns.<br/>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_lines")]
        public int? MaxLines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadConfiguration" /> class.
        /// </summary>
        /// <param name="maxSizeBytes">
        /// Maximum size of any response, in bytes. A full read of a larger artifact is rejected and must be read by line range; a line range holding more is rejected naming the lines that fit. Under base64 encoding this bounds the encoded text, which is 4 bytes for every 3 bytes of the artifact.<br/>
        /// Default Value: 262144
        /// </param>
        /// <param name="maxLines">
        /// Maximum number of lines a range-based read returns.<br/>
        /// Default Value: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactReadConfiguration(
            long? maxSizeBytes,
            int? maxLines)
        {
            this.MaxSizeBytes = maxSizeBytes;
            this.MaxLines = maxLines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadConfiguration" /> class.
        /// </summary>
        public ArtifactReadConfiguration()
        {
        }

    }
}