#nullable enable

namespace Vectara
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Send A2A v1 streaming message<br/>
        /// Send a message to the agent using the A2A v1 wire format and stream task lifecycle events as Server-Sent Events. Each SSE `data:` line is a JSON `A2aV1StreamResponse` carrying a `task`, `message`, `statusUpdate`, or `artifactUpdate`. The stream ends when the task reaches a terminal or interrupted state.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vectara.A2aV1StreamResponse> SendV1MessageStreamAsync(
            string agentKey,

            global::Vectara.A2aV1SendMessageRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send A2A v1 streaming message<br/>
        /// Send a message to the agent using the A2A v1 wire format and stream task lifecycle events as Server-Sent Events. Each SSE `data:` line is a JSON `A2aV1StreamResponse` carrying a `task`, `message`, `statusUpdate`, or `artifactUpdate`. The stream ends when the task reaches a terminal or interrupted state.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="tenant">
        /// Tenant identifier the message is sent to.
        /// </param>
        /// <param name="message">
        /// A v1 unit of communication between client and agent. The `parts` field carries the message parts.
        /// </param>
        /// <param name="configuration">
        /// Optional knobs that influence how the agent processes and responds to a v1 message.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary client-supplied metadata for the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vectara.A2aV1StreamResponse> SendV1MessageStreamAsync(
            string agentKey,
            global::Vectara.A2aV1Message message,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? tenant = default,
            global::Vectara.A2aV1SendMessageConfiguration? configuration = default,
            object? metadata = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}