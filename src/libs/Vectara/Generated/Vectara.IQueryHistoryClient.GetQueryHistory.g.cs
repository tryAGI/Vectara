#nullable enable

namespace Vectara
{
    public partial interface IQueryHistoryClient
    {
        /// <summary>
        /// Get a query history<br/>
        /// Retrieve a detailed history of previously executed query.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="queryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.QueryHistory> GetQueryHistoryAsync(
            string queryId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}