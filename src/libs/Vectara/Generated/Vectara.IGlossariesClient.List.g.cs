#nullable enable

namespace Vectara
{
    public partial interface IGlossariesClient
    {
        /// <summary>
        /// List glossaries<br/>
        /// List all glossaries available to the authenticated user.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: engineering
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListGlossariesResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}