#nullable enable

namespace Vectara
{
    public partial interface IQueryHistoryClient
    {
        /// <summary>
        /// Get a query history<br/>
        /// Returns the detailed history of a specific query made against a corpus. The response includes the query latency, the execution time, and the stages of the query pipeline.<br/>
        /// Set the `query_id` path parameter. The response includes the `id` of the query, the `query` object, the `chat_id`, timing information, and the `spans` object.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="queryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.QueryHistory> GetAsync(
            string queryId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a query history<br/>
        /// Returns the detailed history of a specific query made against a corpus. The response includes the query latency, the execution time, and the stages of the query pipeline.<br/>
        /// Set the `query_id` path parameter. The response includes the `id` of the query, the `query` object, the `chat_id`, timing information, and the `spans` object.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="queryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.QueryHistory>> GetAsResponseAsync(
            string queryId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}