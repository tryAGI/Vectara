
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The search response results.
    /// </summary>
    public sealed partial class StreamSearchResponse
    {
        /// <summary>
        /// When the streaming event has the search results, the type will be `search_results`.<br/>
        /// Default Value: search_results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ranked search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// The rewritten queries for the corpora that were searched. Only populated when `intelligent_query_rewriting` is enabled.<br/>
        /// Example: [, ]
        /// </summary>
        /// <example>[, ]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewritten_queries")]
        public global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? RewrittenQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSearchResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// When the streaming event has the search results, the type will be `search_results`.<br/>
        /// Default Value: search_results
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results.
        /// </param>
        /// <param name="rewrittenQueries">
        /// The rewritten queries for the corpora that were searched. Only populated when `intelligent_query_rewriting` is enabled.<br/>
        /// Example: [, ]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamSearchResponse(
            string? type,
            global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? searchResults,
            global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? rewrittenQueries)
        {
            this.Type = type;
            this.SearchResults = searchResults;
            this.RewrittenQueries = rewrittenQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSearchResponse" /> class.
        /// </summary>
        public StreamSearchResponse()
        {
        }
    }
}