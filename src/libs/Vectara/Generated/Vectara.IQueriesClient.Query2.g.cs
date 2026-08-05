#nullable enable

namespace Vectara
{
    public partial interface IQueriesClient
    {
        /// <summary>
        /// Query multiple corpora<br/>
        /// Queries one or more corpora and generates a response with Retrieval Augmented Generation (RAG). Similar to the [advanced single corpus query](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Set the unique `corpus_key` for each corpus to query. You create the key in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus). You can assign a custom `corpus_key` that follows your preferred naming convention. Search requests reference the corpus by this key.<br/>
        /// * Customize the search with the query text (`query`), pagination (`offset` and `limit`), and metadata filters (`metadata_filter`).<br/>
        /// * Apply reranking (`reranker`) to improve the order of results. Opt in to generation by setting the `generation` property. If you exclude the property or set it to null, the response does not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Set `generation_preset_name` to Vectara's RAG-focused LLM (Mockingbird). [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Control summarization with parameters such as `max_response_characters`, `temperature`, and `frequency_penalty`. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries with the `citations` object: numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.QueryFullResponse> Query2Async(

            global::Vectara.QueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query multiple corpora<br/>
        /// Queries one or more corpora and generates a response with Retrieval Augmented Generation (RAG). Similar to the [advanced single corpus query](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Set the unique `corpus_key` for each corpus to query. You create the key in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus). You can assign a custom `corpus_key` that follows your preferred naming convention. Search requests reference the corpus by this key.<br/>
        /// * Customize the search with the query text (`query`), pagination (`offset` and `limit`), and metadata filters (`metadata_filter`).<br/>
        /// * Apply reranking (`reranker`) to improve the order of results. Opt in to generation by setting the `generation` property. If you exclude the property or set it to null, the response does not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Set `generation_preset_name` to Vectara's RAG-focused LLM (Mockingbird). [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Control summarization with parameters such as `max_response_characters`, `temperature`, and `frequency_penalty`. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries with the `citations` object: numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.QueryFullResponse>> Query2AsResponseAsync(

            global::Vectara.QueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query multiple corpora<br/>
        /// Queries one or more corpora and generates a response with Retrieval Augmented Generation (RAG). Similar to the [advanced single corpus query](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Set the unique `corpus_key` for each corpus to query. You create the key in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus). You can assign a custom `corpus_key` that follows your preferred naming convention. Search requests reference the corpus by this key.<br/>
        /// * Customize the search with the query text (`query`), pagination (`offset` and `limit`), and metadata filters (`metadata_filter`).<br/>
        /// * Apply reranking (`reranker`) to improve the order of results. Opt in to generation by setting the `generation` property. If you exclude the property or set it to null, the response does not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Set `generation_preset_name` to Vectara's RAG-focused LLM (Mockingbird). [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Control summarization with parameters such as `max_response_characters`, `temperature`, and `frequency_penalty`. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries with the `citations` object: numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save the query to query history.
        /// </param>
        /// <param name="intelligentQueryRewriting">
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform attempts to extract metadata filters and rewrite the query to improve search results. See [intelligent query rewriting](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.QueryFullResponse> Query2Async(
            string query,
            global::Vectara.SearchCorporaParameters search,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.GenerationParameters? generation = default,
            bool? streamResponse = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}