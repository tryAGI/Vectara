#nullable enable

namespace Vectara
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List users in the account<br/>
        /// Lists all users in the account.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListUsersResponse> ListUsersAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            string? corpusKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}