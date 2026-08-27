#nullable enable

namespace Vectara
{
    public partial interface ITrustedTokenIssuersClient
    {
        /// <summary>
        /// Replace trusted token issuer<br/>
        /// Replaces a trusted token issuer registration in full.<br/>
        /// The `issuer` is immutable and is not part of the request.<br/>
        /// Disabling the registration refuses every future sign-in immediately.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="trustedTokenIssuerId">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TrustedTokenIssuer> ReplaceAsync(
            string trustedTokenIssuerId,

            global::Vectara.ReplaceTrustedTokenIssuerRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace trusted token issuer<br/>
        /// Replaces a trusted token issuer registration in full.<br/>
        /// The `issuer` is immutable and is not part of the request.<br/>
        /// Disabling the registration refuses every future sign-in immediately.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="trustedTokenIssuerId">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.TrustedTokenIssuer>> ReplaceAsResponseAsync(
            string trustedTokenIssuerId,

            global::Vectara.ReplaceTrustedTokenIssuerRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace trusted token issuer<br/>
        /// Replaces a trusted token issuer registration in full.<br/>
        /// The `issuer` is immutable and is not part of the request.<br/>
        /// Disabling the registration refuses every future sign-in immediately.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="trustedTokenIssuerId">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
        /// <param name="name">
        /// The human-readable name of the trusted issuer.<br/>
        /// Example: Acme Okta production
        /// </param>
        /// <param name="description">
        /// A detailed description of what this trust registration is for.<br/>
        /// Example: Lets Acme portal users chat with the support agent.
        /// </param>
        /// <param name="jwksUri">
        /// The HTTPS URL of the issuer's JSON Web Key Set.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </param>
        /// <param name="enabled">
        /// Whether the registration accepts tokens. Disabling refuses every future sign-in immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TrustedTokenIssuer> ReplaceAsync(
            string trustedTokenIssuerId,
            string name,
            string jwksUri,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? description = default,
            bool? enabled = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}