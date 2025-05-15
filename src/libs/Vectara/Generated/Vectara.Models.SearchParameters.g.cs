
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Search parameters to retrieve knowledge for the query.
    /// </summary>
    public sealed partial class SearchParameters
    {
        /// <summary>
        /// Specifies how many results into the result to skip. This is useful for pagination.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// The maximum number of results returned.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Configuration on the presentation of each document part in the result set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_configuration")]
        public global::Vectara.ContextConfiguration? ContextConfiguration { get; set; }

        /// <summary>
        /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results. By default the search will use the most powerful reranker available to the customer's plan. To disable reranking, set the reranker `type` to `"none"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.SearchRerankerJsonConverter))]
        public global::Vectara.SearchReranker? Reranker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        /// <param name="offset">
        /// Specifies how many results into the result to skip. This is useful for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// The maximum number of results returned.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="contextConfiguration">
        /// Configuration on the presentation of each document part in the result set.
        /// </param>
        /// <param name="reranker">
        /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results. By default the search will use the most powerful reranker available to the customer's plan. To disable reranking, set the reranker `type` to `"none"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchParameters(
            int? offset,
            int? limit,
            global::Vectara.ContextConfiguration? contextConfiguration,
            global::Vectara.SearchReranker? reranker)
        {
            this.Offset = offset;
            this.Limit = limit;
            this.ContextConfiguration = contextConfiguration;
            this.Reranker = reranker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        public SearchParameters()
        {
        }
    }
}