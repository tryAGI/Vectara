#nullable enable

namespace Vectara
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Send A2A v1 message<br/>
        /// Sends a message to the agent using the A2A v1 wire format. Blocks until the agent reaches a terminal or interrupted state. Returns the resulting `task`, or a direct `message` reply for stateless interactions.<br/>
        /// To continue an existing conversation, set `message.contextId` to the prior task's id.
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
        global::System.Threading.Tasks.Task<global::Vectara.A2aV1SendMessageResponse> SendV1MessageAsync(
            string agentKey,

            global::Vectara.A2aV1SendMessageRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send A2A v1 message<br/>
        /// Sends a message to the agent using the A2A v1 wire format. Blocks until the agent reaches a terminal or interrupted state. Returns the resulting `task`, or a direct `message` reply for stateless interactions.<br/>
        /// To continue an existing conversation, set `message.contextId` to the prior task's id.
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.A2aV1SendMessageResponse>> SendV1MessageAsResponseAsync(
            string agentKey,

            global::Vectara.A2aV1SendMessageRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send A2A v1 message<br/>
        /// Sends a message to the agent using the A2A v1 wire format. Blocks until the agent reaches a terminal or interrupted state. Returns the resulting `task`, or a direct `message` reply for stateless interactions.<br/>
        /// To continue an existing conversation, set `message.contextId` to the prior task's id.
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
        /// Optional settings that control how the agent processes and responds to a v1 message.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary client-supplied metadata for the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.A2aV1SendMessageResponse> SendV1MessageAsync(
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