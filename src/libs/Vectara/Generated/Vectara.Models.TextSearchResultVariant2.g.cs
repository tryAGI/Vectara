
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextSearchResultVariant2
    {
        /// <summary>
        /// The type of search result. Always `text` for this variant.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultType { get; set; } = "text";

        /// <summary>
        /// A table in a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public global::Vectara.Table? Table { get; set; }

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
        /// Initializes a new instance of the <see cref="TextSearchResultVariant2" /> class.
        /// </summary>
        /// <param name="resultType">
        /// The type of search result. Always `text` for this variant.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="table">
        /// A table in a document.
        /// </param>
        /// <param name="image">
        /// An image element within a document, containing its identifying information and optional metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextSearchResultVariant2(
            string resultType,
            global::Vectara.Table? table,
            global::Vectara.ImageMetadata? image)
        {
            this.ResultType = resultType ?? throw new global::System.ArgumentNullException(nameof(resultType));
            this.Table = table;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextSearchResultVariant2" /> class.
        /// </summary>
        public TextSearchResultVariant2()
        {
        }

    }
}