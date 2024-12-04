#nullable enable

namespace Vectara
{
    public partial interface IQueryHistoryClient
    {
        /// <summary>
        /// List the history of previous queries<br/>
        /// Retrieve query histories.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="chatId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListQueryHistoriesResponse> GetQueryHistoriesAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? corpusKey = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            string? chatId = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}