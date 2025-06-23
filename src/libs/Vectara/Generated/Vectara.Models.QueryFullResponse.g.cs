
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The full response to a RAG query when the result is not streamed.
    /// </summary>
    public sealed partial class QueryFullResponse
    {
        /// <summary>
        /// The summary of the search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LanguageJsonConverter))]
        public global::Vectara.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The ranked search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Indicates the probability that the summary is factually consistent with the results. The system excludes this property if it encounters excessively large outputs or search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates.<br/>
        /// Example: [{"role": "system", "content": "You are an ESG analyst."}, {"role": "user", "content": "What are the carbon reduction initiatives by EU banks in 2023?"}, {"role": "assistant", "content": "${vectaraQueryResults[0].getText()}"}]
        /// </summary>
        /// <example>[{"role": "system", "content": "You are an ESG analyst."}, {"role": "user", "content": "What are the carbon reduction initiatives by EU banks in 2023?"}, {"role": "assistant", "content": "${vectaraQueryResults[0].getText()}"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// Non-fatal warnings that occurred during request processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Vectara.QueryWarning>? Warnings { get; set; }

        /// <summary>
        /// The rewritten queries for the corpora that were searched. Only populated when `intelligent_query_rewriting` is enabled.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewritten_queries")]
        public global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? RewrittenQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFullResponse" /> class.
        /// </summary>
        /// <param name="summary">
        /// The summary of the search results.
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results.
        /// </param>
        /// <param name="factualConsistencyScore">
        /// Indicates the probability that the summary is factually consistent with the results. The system excludes this property if it encounters excessively large outputs or search results.
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates.<br/>
        /// Example: [{"role": "system", "content": "You are an ESG analyst."}, {"role": "user", "content": "What are the carbon reduction initiatives by EU banks in 2023?"}, {"role": "assistant", "content": "${vectaraQueryResults[0].getText()}"}]
        /// </param>
        /// <param name="warnings">
        /// Non-fatal warnings that occurred during request processing
        /// </param>
        /// <param name="rewrittenQueries">
        /// The rewritten queries for the corpora that were searched. Only populated when `intelligent_query_rewriting` is enabled.<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryFullResponse(
            string? summary,
            global::Vectara.Language? responseLanguage,
            global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? searchResults,
            float? factualConsistencyScore,
            string? renderedPrompt,
            global::System.Collections.Generic.IList<global::Vectara.QueryWarning>? warnings,
            global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? rewrittenQueries)
        {
            this.Summary = summary;
            this.ResponseLanguage = responseLanguage;
            this.SearchResults = searchResults;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.RenderedPrompt = renderedPrompt;
            this.Warnings = warnings;
            this.RewrittenQueries = rewrittenQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFullResponse" /> class.
        /// </summary>
        public QueryFullResponse()
        {
        }
    }
}