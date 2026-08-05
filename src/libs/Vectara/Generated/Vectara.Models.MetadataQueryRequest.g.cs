
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Defines parameters for fuzzy searching across metadata fields in a corpus.
    /// </summary>
    public sealed partial class MetadataQueryRequest
    {
        /// <summary>
        /// Whether to search document-level or part-level metadata. Document-level search returns unique documents. Part-level search can return multiple parts from the same document.<br/>
        /// Default Value: document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.MetadataQueryRequestLevelJsonConverter))]
        public global::Vectara.MetadataQueryRequestLevel? Level { get; set; }

        /// <summary>
        /// The list of field-specific queries for fuzzy matching.<br/>
        /// Example: [{"field":"title","query":"lease agreement","weight":2}, {"field":"category","query":"contract","weight":1}]
        /// </summary>
        /// <example>[{"field":"title","query":"lease agreement","weight":2}, {"field":"category","query":"contract","weight":1}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.FieldQuery> Queries { get; set; }

        /// <summary>
        /// An optional filter expression that narrows results before fuzzy matching. <br/>
        /// The expression uses the same format as document listing filters. The filter applies exact matching.<br/>
        /// Example: doc.Status = 'Active'
        /// </summary>
        /// <example>doc.Status = 'Active'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// The maximum number of documents to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The starting position for pagination.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataQueryRequest" /> class.
        /// </summary>
        /// <param name="queries">
        /// The list of field-specific queries for fuzzy matching.<br/>
        /// Example: [{"field":"title","query":"lease agreement","weight":2}, {"field":"category","query":"contract","weight":1}]
        /// </param>
        /// <param name="level">
        /// Whether to search document-level or part-level metadata. Document-level search returns unique documents. Part-level search can return multiple parts from the same document.<br/>
        /// Default Value: document
        /// </param>
        /// <param name="metadataFilter">
        /// An optional filter expression that narrows results before fuzzy matching. <br/>
        /// The expression uses the same format as document listing filters. The filter applies exact matching.<br/>
        /// Example: doc.Status = 'Active'
        /// </param>
        /// <param name="limit">
        /// The maximum number of documents to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// The starting position for pagination.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataQueryRequest(
            global::System.Collections.Generic.IList<global::Vectara.FieldQuery> queries,
            global::Vectara.MetadataQueryRequestLevel? level,
            string? metadataFilter,
            int? limit,
            int? offset)
        {
            this.Level = level;
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.MetadataFilter = metadataFilter;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataQueryRequest" /> class.
        /// </summary>
        public MetadataQueryRequest()
        {
        }

    }
}