#nullable enable

namespace Vectara
{
    public partial interface IQueryHistoryClient
    {
        /// <summary>
        /// List query histories<br/>
        /// Lists the history of previous queries. Use this API to track query performance and to debug individual queries.<br/>
        /// Filter the results with `corpus_key` or `chat_id`. Set `limit` to the maximum number of query histories to list.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="chatId"></param>
        /// <param name="historyId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListQueryHistoriesResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? corpusKey = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            string? chatId = default,
            string? historyId = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List query histories<br/>
        /// Lists the history of previous queries. Use this API to track query performance and to debug individual queries.<br/>
        /// Filter the results with `corpus_key` or `chat_id`. Set `limit` to the maximum number of query histories to list.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="chatId"></param>
        /// <param name="historyId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListQueryHistoriesResponse>> ListAsResponseAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? corpusKey = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            string? chatId = default,
            string? historyId = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}