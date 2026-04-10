#nullable enable

namespace Vectara
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Request an access token<br/>
        /// Obtain an OAuth2 access token using client credentials
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GetTokenResponse> GetTokenAsync(

            global::Vectara.GetOAuthTokenRequest request,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request an access token<br/>
        /// Obtain an OAuth2 access token using client credentials
        /// </summary>
        /// <param name="clientId">
        /// The client ID of the application
        /// </param>
        /// <param name="clientSecret">
        /// The client secret of the application
        /// </param>
        /// <param name="grantType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GetTokenResponse> GetTokenAsync(
            string clientId,
            string clientSecret,
            string grantType = "client_credentials",
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}