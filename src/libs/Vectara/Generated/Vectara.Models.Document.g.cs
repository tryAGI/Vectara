
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// The document ID.<br/>
        /// Example: my-doc-id
        /// </summary>
        /// <example>my-doc-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The document metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tables that this document contains. Tables are not available when table extraction is not enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Vectara.Table>? Tables { get; set; }

        /// <summary>
        /// Parts of the document that make up the document. However, parts are not available when<br/>
        /// retrieving a list of documents or when creating a document. This property is only available<br/>
        /// when retrieving a document by ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        public global::System.Collections.Generic.IList<global::Vectara.DocumentPart>? Parts { get; set; }

        /// <summary>
        /// How much storage the document used. This information is currently not returned when<br/>
        /// retrieving the document, and only returned when indexing a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_usage")]
        public global::Vectara.DocumentStorageUsage? StorageUsage { get; set; }

        /// <summary>
        /// How much extraction quota the document used. This information is currently not returned when<br/>
        /// retrieving the document, and only returned when indexing a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_usage")]
        public global::Vectara.ExtractionUsage? ExtractionUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="id">
        /// The document ID.<br/>
        /// Example: my-doc-id
        /// </param>
        /// <param name="metadata">
        /// The document metadata.
        /// </param>
        /// <param name="tables">
        /// The tables that this document contains. Tables are not available when table extraction is not enabled.
        /// </param>
        /// <param name="parts">
        /// Parts of the document that make up the document. However, parts are not available when<br/>
        /// retrieving a list of documents or when creating a document. This property is only available<br/>
        /// when retrieving a document by ID.
        /// </param>
        /// <param name="storageUsage">
        /// How much storage the document used. This information is currently not returned when<br/>
        /// retrieving the document, and only returned when indexing a document.
        /// </param>
        /// <param name="extractionUsage">
        /// How much extraction quota the document used. This information is currently not returned when<br/>
        /// retrieving the document, and only returned when indexing a document.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Document(
            string? id,
            object? metadata,
            global::System.Collections.Generic.IList<global::Vectara.Table>? tables,
            global::System.Collections.Generic.IList<global::Vectara.DocumentPart>? parts,
            global::Vectara.DocumentStorageUsage? storageUsage,
            global::Vectara.ExtractionUsage? extractionUsage)
        {
            this.Id = id;
            this.Metadata = metadata;
            this.Tables = tables;
            this.Parts = parts;
            this.StorageUsage = storageUsage;
            this.ExtractionUsage = extractionUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}