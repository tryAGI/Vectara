#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Query a corpus with query parameters<br/>
        /// Queries a single corpus with a simple request. The [**Query APIs**](/docs/rest-api/queries) support Retrieval Augmented Generation (RAG). They search your data and generate AI-powered summaries.<br/>
        /// The platform provides three query types:<br/>
        /// * [**Single corpus query**](/docs/rest-api/search-corpus): A simple search within a single corpus.<br/>
        /// * [**Advanced single corpus query**](/docs/rest-api/query-corpus): Full search and RAG within one corpus. Supports table summarization, metadata filtering, and reranking.<br/>
        /// * [**Multiple corpora query**](/docs/rest-api/query): A search across one or more corpora with full RAG capabilities.<br/>
        /// Set these parameters:<br/>
        /// * `corpus_key`: The unique key of the corpus to query. You create the key in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus). You can assign a custom `corpus_key` that follows your preferred naming convention. Search requests reference the corpus by this key.<br/>
        /// * `query`: The search query string, which is the question you want to ask.<br/>
        /// * `limit`: The maximum number of results to return. **Default**: 10, **minimum**: 1
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="query"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="saveHistory"></param>
        /// <param name="intelligentQueryRewriting">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.QueryFullResponse> SearchAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            int? offset = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query a corpus with query parameters<br/>
        /// Queries a single corpus with a simple request. The [**Query APIs**](/docs/rest-api/queries) support Retrieval Augmented Generation (RAG). They search your data and generate AI-powered summaries.<br/>
        /// The platform provides three query types:<br/>
        /// * [**Single corpus query**](/docs/rest-api/search-corpus): A simple search within a single corpus.<br/>
        /// * [**Advanced single corpus query**](/docs/rest-api/query-corpus): Full search and RAG within one corpus. Supports table summarization, metadata filtering, and reranking.<br/>
        /// * [**Multiple corpora query**](/docs/rest-api/query): A search across one or more corpora with full RAG capabilities.<br/>
        /// Set these parameters:<br/>
        /// * `corpus_key`: The unique key of the corpus to query. You create the key in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus). You can assign a custom `corpus_key` that follows your preferred naming convention. Search requests reference the corpus by this key.<br/>
        /// * `query`: The search query string, which is the question you want to ask.<br/>
        /// * `limit`: The maximum number of results to return. **Default**: 10, **minimum**: 1
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="query"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="saveHistory"></param>
        /// <param name="intelligentQueryRewriting">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.QueryFullResponse>> SearchAsResponseAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            int? offset = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}