
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSearchResultVariant2
    {
        /// <summary>
        /// The type of search result.<br/>
        /// Default Value: image
        /// </summary>
        /// <default>"image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultType { get; set; } = "image";

        /// <summary>
        /// An image element within a document, containing its identifying information and optional metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Vectara.ImageMetadata? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResultVariant2" /> class.
        /// </summary>
        /// <param name="resultType">
        /// The type of search result.<br/>
        /// Default Value: image
        /// </param>
        /// <param name="image">
        /// An image element within a document, containing its identifying information and optional metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSearchResultVariant2(
            string resultType,
            global::Vectara.ImageMetadata? image)
        {
            this.ResultType = resultType ?? throw new global::System.ArgumentNullException(nameof(resultType));
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResultVariant2" /> class.
        /// </summary>
        public ImageSearchResultVariant2()
        {
        }

    }
}