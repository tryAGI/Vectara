#nullable enable

namespace Vectara
{
    public partial interface IQueryHistory2Client
    {
        /// <summary>
        /// Get a query history<br/>
        /// The Get Query History API allows you to retrieve detailed history about a specific query that was made against a corpus. The response includes detailed information about the query, such as latency, the time it was executed, and the various stages in the query pipeline.<br/>
        /// You specify the `query_id` and the response includes the `id` of the query, the `query` object, the `chat_id`, the time information about the query, and the `spans` object.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="queryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.QueryHistory> GetAsync(
            string queryId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}