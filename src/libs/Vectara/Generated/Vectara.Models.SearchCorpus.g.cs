
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for search parameters specific to a single corpus within a customer account, including filters and semantics.
    /// </summary>
    public sealed partial class SearchCorpus
    {
        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The filter string used to narrow the search based on metadata attributes. The query against this corpus will be confined to document parts that match the `metadata_filter`. Only metadata fields set as `filter_attributes` on the corpus can be filtered. Filter syntax is similar to a SQL WHERE clause. See [metadata filters documentation](https://docs.vectara.com/docs/learn/metadata-search-filtering/filter-overview) for more information.<br/>
        /// Example: doc.title = 'Annual Report'
        /// </summary>
        /// <example>doc.title = 'Annual Report'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Example: 0.005F
        /// </summary>
        /// <example>0.005F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_interpolation")]
        public float? LexicalInterpolation { get; set; }

        /// <summary>
        /// Indicates whether to consider a query against this corpus as a query or a response.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.SearchSemanticsJsonConverter))]
        public global::Vectara.SearchSemantics? Semantics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCorpus" /> class.
        /// </summary>
        /// <param name="customDimensions">
        /// The custom dimensions as additional weights.
        /// </param>
        /// <param name="metadataFilter">
        /// The filter string used to narrow the search based on metadata attributes. The query against this corpus will be confined to document parts that match the `metadata_filter`. Only metadata fields set as `filter_attributes` on the corpus can be filtered. Filter syntax is similar to a SQL WHERE clause. See [metadata filters documentation](https://docs.vectara.com/docs/learn/metadata-search-filtering/filter-overview) for more information.<br/>
        /// Example: doc.title = 'Annual Report'
        /// </param>
        /// <param name="lexicalInterpolation">
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Example: 0.005F
        /// </param>
        /// <param name="semantics">
        /// Indicates whether to consider a query against this corpus as a query or a response.<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCorpus(
            global::System.Collections.Generic.Dictionary<string, double>? customDimensions,
            string? metadataFilter,
            float? lexicalInterpolation,
            global::Vectara.SearchSemantics? semantics)
        {
            this.CustomDimensions = customDimensions;
            this.MetadataFilter = metadataFilter;
            this.LexicalInterpolation = lexicalInterpolation;
            this.Semantics = semantics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCorpus" /> class.
        /// </summary>
        public SearchCorpus()
        {
        }
    }
}