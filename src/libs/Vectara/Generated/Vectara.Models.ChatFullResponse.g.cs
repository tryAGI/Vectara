
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Full response to a chat question when the result is not streamed.
    /// </summary>
    public sealed partial class ChatFullResponse
    {
        /// <summary>
        /// If the chat response was stored, the ID of the chat.<br/>
        /// Example: cht_123456789
        /// </summary>
        /// <example>cht_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// If the chat response was stored, the ID of the turn.<br/>
        /// Example: trn_987654321
        /// </summary>
        /// <example>trn_987654321</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The message from the chat model for the chat message.<br/>
        /// Example: EU banks in 2023 have increased carbon reduction initiatives by 20%, driven by new EU regulations mandating annual emissions reporting.
        /// </summary>
        /// <example>EU banks in 2023 have increased carbon reduction initiatives by 20%, driven by new EU regulations mandating annual emissions reporting.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LanguageJsonConverter))]
        public global::Vectara.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The ranked search results that the chat model used.
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
        /// View the actual query made to backend that was rephrased by the LLM from the input query.<br/>
        /// Example: Carbon reduction efforts by EU banks in 2023?
        /// </summary>
        /// <example>Carbon reduction efforts by EU banks in 2023?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// The rewritten queries for the corpora that were searched. Only populated when intelligent_query_rewriting is enabled.<br/>
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
        /// Initializes a new instance of the <see cref="ChatFullResponse" /> class.
        /// </summary>
        /// <param name="chatId">
        /// If the chat response was stored, the ID of the chat.<br/>
        /// Example: cht_123456789
        /// </param>
        /// <param name="turnId">
        /// If the chat response was stored, the ID of the turn.<br/>
        /// Example: trn_987654321
        /// </param>
        /// <param name="answer">
        /// The message from the chat model for the chat message.<br/>
        /// Example: EU banks in 2023 have increased carbon reduction initiatives by 20%, driven by new EU regulations mandating annual emissions reporting.
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results that the chat model used.
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
        /// <param name="rephrasedQuery">
        /// View the actual query made to backend that was rephrased by the LLM from the input query.<br/>
        /// Example: Carbon reduction efforts by EU banks in 2023?
        /// </param>
        /// <param name="rewrittenQueries">
        /// The rewritten queries for the corpora that were searched. Only populated when intelligent_query_rewriting is enabled.<br/>
        /// Example: [, ]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFullResponse(
            string? chatId,
            string? turnId,
            string? answer,
            global::Vectara.Language? responseLanguage,
            global::System.Collections.Generic.IList<global::Vectara.IndividualSearchResult>? searchResults,
            float? factualConsistencyScore,
            string? renderedPrompt,
            global::System.Collections.Generic.IList<global::Vectara.QueryWarning>? warnings,
            string? rephrasedQuery,
            global::System.Collections.Generic.IList<global::Vectara.RewrittenQuery>? rewrittenQueries)
        {
            this.ChatId = chatId;
            this.TurnId = turnId;
            this.Answer = answer;
            this.ResponseLanguage = responseLanguage;
            this.SearchResults = searchResults;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.RenderedPrompt = renderedPrompt;
            this.Warnings = warnings;
            this.RephrasedQuery = rephrasedQuery;
            this.RewrittenQueries = rewrittenQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFullResponse" /> class.
        /// </summary>
        public ChatFullResponse()
        {
        }
    }
}