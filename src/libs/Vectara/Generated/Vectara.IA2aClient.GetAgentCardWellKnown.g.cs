#nullable enable

namespace Vectara
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Get A2A agent card (well-known)<br/>
        /// Returns the A2A v0.3 [Agent Card](https://a2a-protocol.org) for the specified agent at the canonical `.well-known/agent-card.json` discovery URL. Stock A2A clients fetch this URL, then use the card's `url` and `preferredTransport` to drive subsequent calls.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.A2aV03AgentCard> GetAgentCardWellKnownAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get A2A agent card (well-known)<br/>
        /// Returns the A2A v0.3 [Agent Card](https://a2a-protocol.org) for the specified agent at the canonical `.well-known/agent-card.json` discovery URL. Stock A2A clients fetch this URL, then use the card's `url` and `preferredTransport` to drive subsequent calls.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.A2aV03AgentCard>> GetAgentCardWellKnownAsResponseAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}