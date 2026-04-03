#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get agent identity<br/>
        /// Retrieve the identity associated with an agent. The identity is the service account the agent uses when executing tools.<br/>
        /// In `auto` mode (the default), the platform keeps the identity's roles in sync with the agent's tool configuration.<br/>
        /// In `manual` mode, the roles are frozen and the platform will not modify them when the agent is updated.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentIdentity> GetIdentityAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}