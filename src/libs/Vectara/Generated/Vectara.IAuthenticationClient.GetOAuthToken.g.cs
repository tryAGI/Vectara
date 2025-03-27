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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GetOAuthTokenResponse> GetOAuthTokenAsync(
            global::Vectara.GetOAuthTokenRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GetOAuthTokenResponse> GetOAuthTokenAsync(
            string clientId,
            string clientSecret,
            object grantType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}