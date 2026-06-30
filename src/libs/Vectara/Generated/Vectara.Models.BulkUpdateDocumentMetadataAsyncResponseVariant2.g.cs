
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateDocumentMetadataAsyncResponseVariant2
    {
        /// <summary>
        /// Indicates this is an async response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataAsyncResponseVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates this is an async response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateDocumentMetadataAsyncResponseVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataAsyncResponseVariant2" /> class.
        /// </summary>
        public BulkUpdateDocumentMetadataAsyncResponseVariant2()
        {
        }

    }
}