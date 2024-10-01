
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// The Document ID.<br/>
        /// Example: my-doc-id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The document metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vectara.DocumentMetadata? Metadata { get; set; }

        /// <summary>
        /// Parts of the document that make up the document. However, parts are not available when<br/>
        /// retrieving a list of documents or when creating a document. This property is only available<br/>
        /// when retrieving a document by id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        public global::System.Collections.Generic.IList<global::Vectara.DocumentPart>? Parts { get; set; }

        /// <summary>
        /// How much storage the document used. This information is currently not returned when<br/>
        /// retrieving the document, and only returned when indexing document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_usage")]
        public global::Vectara.DocumentStorageUsage? StorageUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}