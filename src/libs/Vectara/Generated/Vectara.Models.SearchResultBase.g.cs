
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common fields for all search result types.
    /// </summary>
    public sealed partial class SearchResultBase
    {
        /// <summary>
        /// The score of the individual result.<br/>
        /// Example: 0.92
        /// </summary>
        /// <example>0.92</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The metadata for the document that contains the document part.<br/>
        /// Example: {"industry":"banking","year":2023,"doc_type":"annual_report"}
        /// </summary>
        /// <example>{"industry":"banking","year":2023,"doc_type":"annual_report"}</example>
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
        /// A query request can search over multiple corpora at a time. This property is set to the index in the list of corpora in the original search request that this search result originated from. If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_corpora_index")]
        public int? RequestCorporaIndex { get; set; }

        /// <summary>
        /// The corpus key that this search result originated from. For queries across multiple corpora, this identifies which corpus the result came from.<br/>
        /// Example: fin_docs
        /// </summary>
        /// <example>fin_docs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// The metadata for the document part as attached at indexing time. Filterable using `part.&lt;key&gt;` in metadata filter expressions.<br/>
        /// Example: {"section":"executive_summary"}
        /// </summary>
        /// <example>{"section":"executive_summary"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_metadata")]
        public object? PartMetadata { get; set; }

        /// <summary>
        /// The matched document part's text, expanded to the surrounding context window configured by `context_configuration`. For image parts, this is the text indexed alongside the image.<br/>
        /// Example: EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.
        /// </summary>
        /// <example>EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultBase" /> class.
        /// </summary>
        /// <param name="score">
        /// The score of the individual result.<br/>
        /// Example: 0.92
        /// </param>
        /// <param name="documentMetadata">
        /// The metadata for the document that contains the document part.<br/>
        /// Example: {"industry":"banking","year":2023,"doc_type":"annual_report"}
        /// </param>
        /// <param name="documentId">
        /// The ID of the document that contains the document part.<br/>
        /// Example: financial-report-2023
        /// </param>
        /// <param name="requestCorporaIndex">
        /// A query request can search over multiple corpora at a time. This property is set to the index in the list of corpora in the original search request that this search result originated from. If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="corpusKey">
        /// The corpus key that this search result originated from. For queries across multiple corpora, this identifies which corpus the result came from.<br/>
        /// Example: fin_docs
        /// </param>
        /// <param name="partMetadata">
        /// The metadata for the document part as attached at indexing time. Filterable using `part.&lt;key&gt;` in metadata filter expressions.<br/>
        /// Example: {"section":"executive_summary"}
        /// </param>
        /// <param name="text">
        /// The matched document part's text, expanded to the surrounding context window configured by `context_configuration`. For image parts, this is the text indexed alongside the image.<br/>
        /// Example: EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultBase(
            double? score,
            object? documentMetadata,
            string? documentId,
            int? requestCorporaIndex,
            string? corpusKey,
            object? partMetadata,
            string? text)
        {
            this.Score = score;
            this.DocumentMetadata = documentMetadata;
            this.DocumentId = documentId;
            this.RequestCorporaIndex = requestCorporaIndex;
            this.CorpusKey = corpusKey;
            this.PartMetadata = partMetadata;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultBase" /> class.
        /// </summary>
        public SearchResultBase()
        {
        }

    }
}