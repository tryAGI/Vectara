#nullable enable

namespace Vectara
{
    public partial interface ITrustedTokenIssuersClient
    {
        /// <summary>
        /// Get trusted token issuer<br/>
        /// Returns a trusted token issuer registration.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="trustedTokenIssuerId">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TrustedTokenIssuer> GetAsync(
            string trustedTokenIssuerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get trusted token issuer<br/>
        /// Returns a trusted token issuer registration.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="trustedTokenIssuerId">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.TrustedTokenIssuer>> GetAsResponseAsync(
            string trustedTokenIssuerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}