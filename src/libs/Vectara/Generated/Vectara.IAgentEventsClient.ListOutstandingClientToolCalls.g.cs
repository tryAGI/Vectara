#nullable enable

namespace Vectara
{
    public partial interface IAgentEventsClient
    {
        /// <summary>
        /// List outstanding client tool calls for an agent session<br/>
        /// Lists the client tool calls the session is waiting for the caller to fulfill. Each entry carries the originating `tool_input` event ID, the tool name, and the fully materialized arguments to invoke the tool with. The response returns secret-derived values unmasked because the caller needs them to execute the tool. For this reason, this endpoint is restricted to the same roles permitted to submit input to the session.<br/>
        /// Returns an empty list when the session is not waiting on a client tool. The corresponding `client_tool_pending` event appears only on the live event stream. The `listAgentEvents` endpoint does not return it. Use this endpoint to recover the pending calls after a reconnect. Submit one `tool_output` per returned `event_id` (via the create-input endpoint) to resume the session.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.OutstandingClientToolCallsResponse> ListOutstandingClientToolCallsAsync(
            string agentKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List outstanding client tool calls for an agent session<br/>
        /// Lists the client tool calls the session is waiting for the caller to fulfill. Each entry carries the originating `tool_input` event ID, the tool name, and the fully materialized arguments to invoke the tool with. The response returns secret-derived values unmasked because the caller needs them to execute the tool. For this reason, this endpoint is restricted to the same roles permitted to submit input to the session.<br/>
        /// Returns an empty list when the session is not waiting on a client tool. The corresponding `client_tool_pending` event appears only on the live event stream. The `listAgentEvents` endpoint does not return it. Use this endpoint to recover the pending calls after a reconnect. Submit one `tool_output` per returned `event_id` (via the create-input endpoint) to resume the session.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.OutstandingClientToolCallsResponse>> ListOutstandingClientToolCallsAsResponseAsync(
            string agentKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}