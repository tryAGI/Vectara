#nullable enable

namespace Vectara
{
    public partial interface IEndUserSessionsClient
    {
        /// <summary>
        /// Delete end user session for alias<br/>
        /// Permanently deletes a session the caller owns, addressed by the alias it was created through. Returns 403 if the session belongs to a different principal. This action cannot be undone.<br/>
        /// Anonymous widget visitors authenticate by presenting `X-Visitor-Id` instead of an `Authorization` credential; the platform mints an identity holding `agent_end_user` on the addressed alias, which satisfies this operation's role requirement.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xVisitorId"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAliasRoutedAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete end user session for alias<br/>
        /// Permanently deletes a session the caller owns, addressed by the alias it was created through. Returns 403 if the session belongs to a different principal. This action cannot be undone.<br/>
        /// Anonymous widget visitors authenticate by presenting `X-Visitor-Id` instead of an `Authorization` credential; the platform mints an identity holding `agent_end_user` on the addressed alias, which satisfies this operation's role requirement.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="xVisitorId"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse> DeleteAliasRoutedAsResponseAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}