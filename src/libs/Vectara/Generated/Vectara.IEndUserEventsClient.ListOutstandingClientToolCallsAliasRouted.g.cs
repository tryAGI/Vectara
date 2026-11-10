#nullable enable

namespace Vectara
{
    public partial interface IEndUserEventsClient
    {
        /// <summary>
        /// List end user outstanding client tool calls for alias<br/>
        /// Lists the client tool calls that a session the caller owns is waiting on, addressed by the alias it was created through.<br/>
        /// Use it to recover waiting calls after a reconnect or reload, because the `client_tool_pending` event is not in the session's history. Submit each call's output as a `tool_output` input.<br/>
        /// Each entry carries the call's arguments, including argument override values, with secrets unmasked.<br/>
        /// The list is empty when the session is not waiting on a client tool. Returns 403 if the session belongs to a different principal.<br/>
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
        global::System.Threading.Tasks.Task<global::Vectara.OutstandingClientToolCallsResponse> ListOutstandingClientToolCallsAliasRoutedAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List end user outstanding client tool calls for alias<br/>
        /// Lists the client tool calls that a session the caller owns is waiting on, addressed by the alias it was created through.<br/>
        /// Use it to recover waiting calls after a reconnect or reload, because the `client_tool_pending` event is not in the session's history. Submit each call's output as a `tool_output` input.<br/>
        /// Each entry carries the call's arguments, including argument override values, with secrets unmasked.<br/>
        /// The list is empty when the session is not waiting on a client tool. Returns 403 if the session belongs to a different principal.<br/>
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.OutstandingClientToolCallsResponse>> ListOutstandingClientToolCallsAliasRoutedAsResponseAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? xVisitorId = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}