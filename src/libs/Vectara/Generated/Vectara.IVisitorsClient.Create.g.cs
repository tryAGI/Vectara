#nullable enable

namespace Vectara
{
    public partial interface IVisitorsClient
    {
        /// <summary>
        /// Create anonymous visitor<br/>
        /// Mints the anonymous identity a widget visitor presents as `X-Visitor-Id` on `/v2/agent_aliases/{alias_key}/end_user_sessions` requests, naming a connector in the session create body.<br/>
        /// No credential is required. The `X-Customer-Id` header carries the `customer_id` served by the public connector view; the minted id is scoped to that customer and authenticates the same visitor on any of the customer's widgets that admit anonymous visitors.<br/>
        /// Call this only when the client holds no visitor id. The id never expires — store it durably; it is the only proof of ownership of the sessions it creates, and a repeat call mints a fresh identity that owns none of the previous identity's sessions.<br/>
        /// Returns `404` when the customer does not exist, is disabled, or has no enabled widget connector that admits anonymous visitors — one indistinguishable refusal, so the endpoint confirms nothing about which customer ids exist.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xCustomerId">
        /// Example: 1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.CreateVisitorResponse> CreateAsync(
            long xCustomerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create anonymous visitor<br/>
        /// Mints the anonymous identity a widget visitor presents as `X-Visitor-Id` on `/v2/agent_aliases/{alias_key}/end_user_sessions` requests, naming a connector in the session create body.<br/>
        /// No credential is required. The `X-Customer-Id` header carries the `customer_id` served by the public connector view; the minted id is scoped to that customer and authenticates the same visitor on any of the customer's widgets that admit anonymous visitors.<br/>
        /// Call this only when the client holds no visitor id. The id never expires — store it durably; it is the only proof of ownership of the sessions it creates, and a repeat call mints a fresh identity that owns none of the previous identity's sessions.<br/>
        /// Returns `404` when the customer does not exist, is disabled, or has no enabled widget connector that admits anonymous visitors — one indistinguishable refusal, so the endpoint confirms nothing about which customer ids exist.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xCustomerId">
        /// Example: 1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.CreateVisitorResponse>> CreateAsResponseAsync(
            long xCustomerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}