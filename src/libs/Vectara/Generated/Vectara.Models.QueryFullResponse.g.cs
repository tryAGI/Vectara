
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
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

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
        /// The probability that the summary is factually consistent with the results.
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public QueryFullResponse(
            string? summary,
            global::Vectara.Language? responseLanguage,
            global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? searchResults,
            float? factualConsistencyScore,
            string? renderedPrompt)
        {
            this.Summary = summary;
            this.ResponseLanguage = responseLanguage;
            this.SearchResults = searchResults;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.RenderedPrompt = renderedPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFullResponse" /> class.
        /// </summary>
        public QueryFullResponse()
        {
        }
    }
}