
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to start or continue a chat conversation with a large language model.
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// The chat message or question.<br/>
        /// Example: What are the carbon reduction efforts by EU banks in 2023?
        /// </summary>
        /// <example>What are the carbon reduction efforts by EU banks in 2023?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The parameters to search one or more corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.SearchCorporaParametersJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.SearchCorporaParameters Search { get; set; }

        /// <summary>
        /// The parameters to control generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::Vectara.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Parameters to control chat behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public global::Vectara.ChatParameters? Chat { get; set; }

        /// <summary>
        /// Indicates whether to save the chat in both the chat and query history. This overrides `chat.store`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to extract metadata filter and rewrite the query to improve search results. Read [here](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligent_query_rewriting")]
        public bool? IntelligentQueryRewriting { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The chat message or question.<br/>
        /// Example: What are the carbon reduction efforts by EU banks in 2023?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="chat">
        /// Parameters to control chat behavior.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save the chat in both the chat and query history. This overrides `chat.store`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="intelligentQueryRewriting">
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to extract metadata filter and rewrite the query to improve search results. Read [here](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequest(
            string query,
            global::Vectara.SearchCorporaParameters search,
            global::Vectara.GenerationParameters? generation,
            global::Vectara.ChatParameters? chat,
            bool? saveHistory,
            bool? intelligentQueryRewriting,
            bool? streamResponse)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Search = search;
            this.Generation = generation;
            this.Chat = chat;
            this.SaveHistory = saveHistory;
            this.IntelligentQueryRewriting = intelligentQueryRewriting;
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        public ChatRequest()
        {
        }
    }
}