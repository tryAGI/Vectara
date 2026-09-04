#nullable enable

namespace Vectara
{
    public partial interface IWidgetsClient
    {
        /// <summary>
        /// Bootstrap widget visitor<br/>
        /// Returns the widget's presentation configuration and, when the widget admits anonymous visitors, a signed anonymous visitor id.<br/>
        /// No credential is required.<br/>
        /// A widget that admits anonymous visitors (`public_access` true) mints a visitor id, returned as `visitor_id`. A sign-in-only widget (`public_access` false) still bootstraps — the response carries its `alias_key`, `presentation`, and `end_user_sign_in` so the client can render and sign a user in — but returns no `visitor_id`; the client must authenticate before creating an end-user session for the alias.<br/>
        /// The client presents the minted id as `X-Visitor-Id` on `/v2/agent_aliases/{alias_key}/end_user_sessions` requests, using the `alias_key` returned here; the widget connector the id was minted through travels inside it.<br/>
        /// Returns `404` if the alias does not front a widget connector, or that connector is disabled, or belongs to a disabled customer.<br/>
        /// The visitor id never expires.<br/>
        /// Store it durably; a repeat call mints a fresh identity that owns none of the previous identity's sessions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The platform-generated key of the alias fronting a widget connector, as reported in the connector's `alias_key` and `bootstrap_path`. Always `als_`-prefixed; the prefix is reserved, so no operator-chosen alias ever matches it.<br/>
        /// Example: als_9f3a1c2b-4d5e-6f70-8192-a3b4c5d6e7f8_00aa
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.BootstrapWidgetResponse> BootstrapAsync(
            string aliasKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bootstrap widget visitor<br/>
        /// Returns the widget's presentation configuration and, when the widget admits anonymous visitors, a signed anonymous visitor id.<br/>
        /// No credential is required.<br/>
        /// A widget that admits anonymous visitors (`public_access` true) mints a visitor id, returned as `visitor_id`. A sign-in-only widget (`public_access` false) still bootstraps — the response carries its `alias_key`, `presentation`, and `end_user_sign_in` so the client can render and sign a user in — but returns no `visitor_id`; the client must authenticate before creating an end-user session for the alias.<br/>
        /// The client presents the minted id as `X-Visitor-Id` on `/v2/agent_aliases/{alias_key}/end_user_sessions` requests, using the `alias_key` returned here; the widget connector the id was minted through travels inside it.<br/>
        /// Returns `404` if the alias does not front a widget connector, or that connector is disabled, or belongs to a disabled customer.<br/>
        /// The visitor id never expires.<br/>
        /// Store it durably; a repeat call mints a fresh identity that owns none of the previous identity's sessions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The platform-generated key of the alias fronting a widget connector, as reported in the connector's `alias_key` and `bootstrap_path`. Always `als_`-prefixed; the prefix is reserved, so no operator-chosen alias ever matches it.<br/>
        /// Example: als_9f3a1c2b-4d5e-6f70-8192-a3b4c5d6e7f8_00aa
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.BootstrapWidgetResponse>> BootstrapAsResponseAsync(
            string aliasKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}