#nullable enable

namespace Vectara
{
    public partial interface IEndUserSessionsClient
    {
        /// <summary>
        /// Create end user session for alias<br/>
        /// Creates a session owned by the calling end user, routed through this alias's policy. The session's owning principal is the caller's authenticated identity.<br/>
        /// An administrator calling this operation is bound to the sessions it owns like every other caller; the operator endpoints are the administrative view of an alias's sessions.<br/>
        /// Ownership binds to the alias key, not the resolved agent, so it is unaffected by a later change to the alias's routing weights.<br/>
        /// Anonymous widget visitors authenticate by presenting `X-Visitor-Id` instead of an `Authorization` credential; the platform mints an identity holding `agent_end_user` on the addressed alias, which satisfies this operation's role requirement. A visitor id is customer-scoped, so it need not have been minted through the connector named in the request body; that connector must still admit anonymous visitors (`403` otherwise). The connector's `allowed_origins` also applies to anonymous and signed-in callers; requests without an `Origin` header are admitted.<br/>
        /// The session binds to the connector named by the request body's `connector_id` and takes its idle lifetime from that connector's `session_tti_minutes`, reported on the returned session.<br/>
        /// Returns `429` when the caller reaches the live-session or hourly session-creation cap, or when the customer-wide anonymous session-creation ceiling is reached.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xVisitorId"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.EndUserSession> CreateAliasRoutedAsync(
            string aliasKey,

            global::Vectara.CreateEndUserSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create end user session for alias<br/>
        /// Creates a session owned by the calling end user, routed through this alias's policy. The session's owning principal is the caller's authenticated identity.<br/>
        /// An administrator calling this operation is bound to the sessions it owns like every other caller; the operator endpoints are the administrative view of an alias's sessions.<br/>
        /// Ownership binds to the alias key, not the resolved agent, so it is unaffected by a later change to the alias's routing weights.<br/>
        /// Anonymous widget visitors authenticate by presenting `X-Visitor-Id` instead of an `Authorization` credential; the platform mints an identity holding `agent_end_user` on the addressed alias, which satisfies this operation's role requirement. A visitor id is customer-scoped, so it need not have been minted through the connector named in the request body; that connector must still admit anonymous visitors (`403` otherwise). The connector's `allowed_origins` also applies to anonymous and signed-in callers; requests without an `Origin` header are admitted.<br/>
        /// The session binds to the connector named by the request body's `connector_id` and takes its idle lifetime from that connector's `session_tti_minutes`, reported on the returned session.<br/>
        /// Returns `429` when the caller reaches the live-session or hourly session-creation cap, or when the customer-wide anonymous session-creation ceiling is reached.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xVisitorId"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.EndUserSession>> CreateAliasRoutedAsResponseAsync(
            string aliasKey,

            global::Vectara.CreateEndUserSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create end user session for alias<br/>
        /// Creates a session owned by the calling end user, routed through this alias's policy. The session's owning principal is the caller's authenticated identity.<br/>
        /// An administrator calling this operation is bound to the sessions it owns like every other caller; the operator endpoints are the administrative view of an alias's sessions.<br/>
        /// Ownership binds to the alias key, not the resolved agent, so it is unaffected by a later change to the alias's routing weights.<br/>
        /// Anonymous widget visitors authenticate by presenting `X-Visitor-Id` instead of an `Authorization` credential; the platform mints an identity holding `agent_end_user` on the addressed alias, which satisfies this operation's role requirement. A visitor id is customer-scoped, so it need not have been minted through the connector named in the request body; that connector must still admit anonymous visitors (`403` otherwise). The connector's `allowed_origins` also applies to anonymous and signed-in callers; requests without an `Origin` header are admitted.<br/>
        /// The session binds to the connector named by the request body's `connector_id` and takes its idle lifetime from that connector's `session_tti_minutes`, reported on the returned session.<br/>
        /// Returns `429` when the caller reaches the live-session or hourly session-creation cap, or when the customer-wide anonymous session-creation ceiling is reached.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xVisitorId"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="connectorId">
        /// The globally unique identifier of a connector.<br/>
        /// Example: con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session. Platform-generated if omitted.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// A short description of the session's purpose. If omitted, the platform generates one after the agent produces events.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.EndUserSession> CreateAliasRoutedAsync(
            string aliasKey,
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            string? name = default,
            string? description = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}