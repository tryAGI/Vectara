
#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual ranked search result from a query.
    /// </summary>
    public sealed partial class IndividualSearchResult
    {
        /// <summary>
        /// The document part altered by the context configuration that matches the query.<br/>
        /// Example: EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.
        /// </summary>
        /// <example>EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The score of the individual result.<br/>
        /// Example: 0.92
        /// </summary>
        /// <example>0.92</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The metadata for the document part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_metadata")]
        public object? PartMetadata { get; set; }

        /// <summary>
        /// The metadata for the document that contains the document part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_metadata")]
        public object? DocumentMetadata { get; set; }

        /// <summary>
        /// The ID of the document that contains the document part.<br/>
        /// Example: financial-report-2023
        /// </summary>
        /// <example>financial-report-2023</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

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
        /// A query request can search over multiple corpora at a time. This property is set to the index in the list of corpora in the original search request that this search result originated from. If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_corpora_index")]
        public int? RequestCorporaIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualSearchResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The document part altered by the context configuration that matches the query.<br/>
        /// Example: EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.
        /// </param>
        /// <param name="score">
        /// The score of the individual result.<br/>
        /// Example: 0.92
        /// </param>
        /// <param name="partMetadata">
        /// The metadata for the document part.
        /// </param>
        /// <param name="documentMetadata">
        /// The metadata for the document that contains the document part.
        /// </param>
        /// <param name="documentId">
        /// The ID of the document that contains the document part.<br/>
        /// Example: financial-report-2023
        /// </param>
        /// <param name="table">
        /// A table in a document.
        /// </param>
        /// <param name="image">
        /// An image element within a document, containing its identifying information and optional metadata.
        /// </param>
        /// <param name="requestCorporaIndex">
        /// A query request can search over multiple corpora at a time. This property is set to the index in the list of corpora in the original search request that this search result originated from. If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndividualSearchResult(
            string? text,
            double? score,
            object? partMetadata,
            object? documentMetadata,
            string? documentId,
            global::Vectara.Table? table,
            global::Vectara.ImageMetadata? image,
            int? requestCorporaIndex)
        {
            this.Text = text;
            this.Score = score;
            this.PartMetadata = partMetadata;
            this.DocumentMetadata = documentMetadata;
            this.DocumentId = documentId;
            this.Table = table;
            this.Image = image;
            this.RequestCorporaIndex = requestCorporaIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualSearchResult" /> class.
        /// </summary>
        public IndividualSearchResult()
        {
        }
    }
}