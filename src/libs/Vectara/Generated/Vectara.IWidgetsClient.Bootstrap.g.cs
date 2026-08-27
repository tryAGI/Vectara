#nullable enable

namespace Vectara
{
    public partial interface IWidgetsClient
    {
        /// <summary>
        /// Bootstrap widget visitor<br/>
        /// Mints a signed anonymous visitor id and returns it with the widget's presentation configuration.<br/>
        /// No credential is required.<br/>
        /// The client presents the minted id as `X-Visitor-Id` on `/v2/agent_aliases/{alias_key}/end_user_sessions` requests, using the `alias_key` returned here; the widget connector the id was minted through travels inside it.<br/>
        /// Returns `404` if the connector does not exist, is not a `widget` connector, is disabled, does not have `public_access` enabled, or belongs to a disabled customer.<br/>
        /// The visitor id never expires.<br/>
        /// Store it durably; a repeat call mints a fresh identity that owns none of the previous identity's sessions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="connectorId">
        /// Example: con_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.BootstrapWidgetResponse> BootstrapAsync(
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bootstrap widget visitor<br/>
        /// Mints a signed anonymous visitor id and returns it with the widget's presentation configuration.<br/>
        /// No credential is required.<br/>
        /// The client presents the minted id as `X-Visitor-Id` on `/v2/agent_aliases/{alias_key}/end_user_sessions` requests, using the `alias_key` returned here; the widget connector the id was minted through travels inside it.<br/>
        /// Returns `404` if the connector does not exist, is not a `widget` connector, is disabled, does not have `public_access` enabled, or belongs to a disabled customer.<br/>
        /// The visitor id never expires.<br/>
        /// Store it durably; a repeat call mints a fresh identity that owns none of the previous identity's sessions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="connectorId">
        /// Example: con_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.BootstrapWidgetResponse>> BootstrapAsResponseAsync(
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}