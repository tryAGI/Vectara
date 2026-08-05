#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesSessionsClient
    {
        /// <summary>
        /// List outstanding client tool calls on alias-routed session<br/>
        /// Lists the client tool calls that a session originally created via this alias waits on the caller to fulfill. Each entry carries the fully materialized arguments to invoke the tool with. Secret-derived values are returned unmasked because the caller needs them to execute the tool. This endpoint therefore requires the same roles permitted to submit input to the session. The list is empty when the session is not parked on a client tool. See the agent-scoped endpoint for the full contract.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
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
        global::System.Threading.Tasks.Task<global::Vectara.OutstandingClientToolCallsResponse> ListOutstandingClientToolCallsAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List outstanding client tool calls on alias-routed session<br/>
        /// Lists the client tool calls that a session originally created via this alias waits on the caller to fulfill. Each entry carries the fully materialized arguments to invoke the tool with. Secret-derived values are returned unmasked because the caller needs them to execute the tool. This endpoint therefore requires the same roles permitted to submit input to the session. The list is empty when the session is not parked on a client tool. See the agent-scoped endpoint for the full contract.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.OutstandingClientToolCallsResponse>> ListOutstandingClientToolCallsAsResponseAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}