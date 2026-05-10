
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for an image_read span.
    /// </summary>
    public sealed partial class ImageReadSpanAttributes
    {
        /// <summary>
        /// The ID of the image artifact being loaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// The detail level used for image processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadSpanAttributes" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// The ID of the image artifact being loaded.
        /// </param>
        /// <param name="detail">
        /// The detail level used for image processing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageReadSpanAttributes(
            string? artifactId,
            string? detail)
        {
            this.ArtifactId = artifactId;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReadSpanAttributes" /> class.
        /// </summary>
        public ImageReadSpanAttributes()
        {
        }

    }
}