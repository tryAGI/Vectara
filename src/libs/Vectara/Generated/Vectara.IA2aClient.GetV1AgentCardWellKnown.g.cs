#nullable enable

namespace Vectara
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Get A2A v1 agent card (well-known)<br/>
        /// Returns the v1 [Agent Card](https://a2a-protocol.org) at the well-known discovery URL `/.well-known/a2a/v1/agent-card.json`. The card lists every supported transport in `supportedInterfaces` (the first entry is preferred); v1 clients discover this URL and pick a binding from the list.
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
        global::System.Threading.Tasks.Task<global::Vectara.A2aV1AgentCard> GetV1AgentCardWellKnownAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get A2A v1 agent card (well-known)<br/>
        /// Returns the v1 [Agent Card](https://a2a-protocol.org) at the well-known discovery URL `/.well-known/a2a/v1/agent-card.json`. The card lists every supported transport in `supportedInterfaces` (the first entry is preferred); v1 clients discover this URL and pick a binding from the list.
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.A2aV1AgentCard>> GetV1AgentCardWellKnownAsResponseAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}