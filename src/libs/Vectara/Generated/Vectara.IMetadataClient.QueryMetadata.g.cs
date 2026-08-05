#nullable enable

namespace Vectara
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Query across metadata fields in a corpus<br/>
        /// Queries documents in a corpus with fuzzy matching across the specified metadata fields. The search first applies any exact metadata filters to narrow the results. It then performs fuzzy matching on the remaining documents with the specified field queries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.MetadataQueryResponse> QueryMetadataAsync(
            string corpusKey,

            global::Vectara.MetadataQueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query across metadata fields in a corpus<br/>
        /// Queries documents in a corpus with fuzzy matching across the specified metadata fields. The search first applies any exact metadata filters to narrow the results. It then performs fuzzy matching on the remaining documents with the specified field queries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.MetadataQueryResponse>> QueryMetadataAsResponseAsync(
            string corpusKey,

            global::Vectara.MetadataQueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query across metadata fields in a corpus<br/>
        /// Queries documents in a corpus with fuzzy matching across the specified metadata fields. The search first applies any exact metadata filters to narrow the results. It then performs fuzzy matching on the remaining documents with the specified field queries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="level">
        /// Whether to search document-level or part-level metadata. Document-level search returns unique documents. Part-level search can return multiple parts from the same document.<br/>
        /// Default Value: document
        /// </param>
        /// <param name="queries">
        /// The list of field-specific queries for fuzzy matching.<br/>
        /// Example: [{"field":"title","query":"lease agreement","weight":2}, {"field":"category","query":"contract","weight":1}]
        /// </param>
        /// <param name="metadataFilter">
        /// An optional filter expression that narrows results before fuzzy matching. <br/>
        /// The expression uses the same format as document listing filters. The filter applies exact matching.<br/>
        /// Example: doc.Status = 'Active'
        /// </param>
        /// <param name="limit">
        /// The maximum number of documents to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// The starting position for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.MetadataQueryResponse> QueryMetadataAsync(
            string corpusKey,
            global::System.Collections.Generic.IList<global::Vectara.FieldQuery> queries,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.MetadataQueryRequestLevel? level = default,
            string? metadataFilter = default,
            int? limit = default,
            int? offset = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}