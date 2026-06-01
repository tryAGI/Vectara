#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesSessionsClient
    {
        /// <summary>
        /// List outstanding client tool calls on alias-routed session<br/>
        /// List the client tool calls a session originally created via this alias is currently waiting on the caller to fulfill. Each entry carries the fully materialized arguments to invoke the tool with; secret-derived values are returned unmasked because the caller needs them to execute the tool, so this endpoint is restricted to the same roles permitted to submit input to the session. Empty when the session is not parked on a client tool. See the agent-scoped endpoint for the full contract.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.OutstandingClientToolCallsResponse> ListOutstandingClientToolCallsAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List outstanding client tool calls on alias-routed session<br/>
        /// List the client tool calls a session originally created via this alias is currently waiting on the caller to fulfill. Each entry carries the fully materialized arguments to invoke the tool with; secret-derived values are returned unmasked because the caller needs them to execute the tool, so this endpoint is restricted to the same roles permitted to submit input to the session. Empty when the session is not parked on a client tool. See the agent-scoped endpoint for the full contract.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.OutstandingClientToolCallsResponse>> ListOutstandingClientToolCallsAsResponseAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}