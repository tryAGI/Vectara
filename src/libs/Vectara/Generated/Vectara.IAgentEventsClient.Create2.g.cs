#nullable enable

namespace Vectara
{
    public partial interface IAgentEventsClient
    {
        /// <summary>
        /// Interact with an agent<br/>
        /// Create a new input to an agent to interact with it.
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentResponse> Create2Async(
            string agentKey,
            string sessionKey,

            global::Vectara.CreateInputRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}