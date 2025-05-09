
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to search a specific corpus within a customer account and optionally generate a response using RAG techniques.
    /// </summary>
    public sealed partial class QueryCorpusRequest
    {
        /// <summary>
        /// The search query string, which is the question the user is asking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The parameters to search one corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AllOfJsonConverter<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>))]
        public global::Vectara.AllOf<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>? Search { get; set; }

        /// <summary>
        /// The parameters to control generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::Vectara.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Indicates whether to save the query to query history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to<br/>
        /// extract metadata filter and rewrite the query to improve search results. For more details: https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligent_query_rewriting")]
        public bool? IntelligentQueryRewriting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCorpusRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.
        /// </param>
        /// <param name="search">
        /// The parameters to search one corpus.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save the query to query history.
        /// </param>
        /// <param name="intelligentQueryRewriting">
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to<br/>
        /// extract metadata filter and rewrite the query to improve search results. For more details: https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryCorpusRequest(
            string query,
            global::Vectara.AllOf<global::Vectara.SearchCorpus, global::Vectara.SearchParameters>? search,
            global::Vectara.GenerationParameters? generation,
            bool? streamResponse,
            bool? saveHistory,
            bool? intelligentQueryRewriting)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Search = search;
            this.Generation = generation;
            this.StreamResponse = streamResponse;
            this.SaveHistory = saveHistory;
            this.IntelligentQueryRewriting = intelligentQueryRewriting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCorpusRequest" /> class.
        /// </summary>
        public QueryCorpusRequest()
        {
        }
    }
}