#nullable enable

namespace Vectara
{
    public partial interface ITrustedTokenIssuersClient
    {
        /// <summary>
        /// Register trusted token issuer<br/>
        /// Registers a customer identity provider as a trusted issuer of end-user sign-in tokens.<br/>
        /// A widget connector references the registration by id to accept tokens the issuer signs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TrustedTokenIssuer> CreateAsync(

            global::Vectara.CreateTrustedTokenIssuerRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register trusted token issuer<br/>
        /// Registers a customer identity provider as a trusted issuer of end-user sign-in tokens.<br/>
        /// A widget connector references the registration by id to accept tokens the issuer signs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.TrustedTokenIssuer>> CreateAsResponseAsync(

            global::Vectara.CreateTrustedTokenIssuerRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register trusted token issuer<br/>
        /// Registers a customer identity provider as a trusted issuer of end-user sign-in tokens.<br/>
        /// A widget connector references the registration by id to accept tokens the issuer signs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="name">
        /// The human-readable name of the trusted issuer.<br/>
        /// Example: Acme Okta production
        /// </param>
        /// <param name="description">
        /// A detailed description of what this trust registration is for.<br/>
        /// Example: Lets Acme portal users chat with the support agent.
        /// </param>
        /// <param name="issuer">
        /// The issuer URL exactly as it appears in the `iss` claim of the identity provider's tokens. Immutable after creation.<br/>
        /// A customer may register an issuer once; a duplicate registration returns `409`.<br/>
        /// Example: https://acme.okta.com/oauth2/default
        /// </param>
        /// <param name="jwksUri">
        /// The HTTPS URL of the issuer's JSON Web Key Set.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </param>
        /// <param name="enabled">
        /// Whether the registration accepts tokens upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TrustedTokenIssuer> CreateAsync(
            string name,
            string issuer,
            string jwksUri,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? description = default,
            bool? enabled = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}