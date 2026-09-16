
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Handling of images embedded in page bodies. At most 20 MiB of base64-encoded image data (roughly 15 MiB<br/>
    /// of original image bytes) is inlined per page; images beyond that total are left as Confluence URLs.
    /// </summary>
    public sealed partial class ConfluenceEmbeddedImagesConfiguration
    {
        /// <summary>
        /// `inline` fetches each image attached to the page or to one of its ancestors using the source's<br/>
        /// credentials and embeds it in the page so it is indexed with the page. Images attached to any other<br/>
        /// page, images hosted outside the instance, images larger than `max_bytes`, and images that fail to<br/>
        /// download are left as Confluence URLs; a failed image never fails the page. `omit` leaves every image<br/>
        /// as a Confluence URL, which is not fetched and so is not indexed.<br/>
        /// Default Value: inline
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ConfluenceEmbeddedImagesConfigurationHandlingJsonConverter))]
        public global::Vectara.ConfluenceEmbeddedImagesConfigurationHandling? Handling { get; set; }

        /// <summary>
        /// Maximum image size in bytes; larger images are left as Confluence URLs instead of inlined. Between 1 KiB and 15 MiB.<br/>
        /// Default Value: 5242880
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_bytes")]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfluenceEmbeddedImagesConfiguration" /> class.
        /// </summary>
        /// <param name="handling">
        /// `inline` fetches each image attached to the page or to one of its ancestors using the source's<br/>
        /// credentials and embeds it in the page so it is indexed with the page. Images attached to any other<br/>
        /// page, images hosted outside the instance, images larger than `max_bytes`, and images that fail to<br/>
        /// download are left as Confluence URLs; a failed image never fails the page. `omit` leaves every image<br/>
        /// as a Confluence URL, which is not fetched and so is not indexed.<br/>
        /// Default Value: inline
        /// </param>
        /// <param name="maxBytes">
        /// Maximum image size in bytes; larger images are left as Confluence URLs instead of inlined. Between 1 KiB and 15 MiB.<br/>
        /// Default Value: 5242880
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfluenceEmbeddedImagesConfiguration(
            global::Vectara.ConfluenceEmbeddedImagesConfigurationHandling? handling,
            long? maxBytes)
        {
            this.Handling = handling;
            this.MaxBytes = maxBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfluenceEmbeddedImagesConfiguration" /> class.
        /// </summary>
        public ConfluenceEmbeddedImagesConfiguration()
        {
        }

    }
}