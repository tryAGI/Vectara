#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent identity<br/>
        /// Update the agent's identity role management mode and/or roles.<br/>
        /// Setting mode to `manual` freezes the current roles. The platform will no longer recompute roles when the agent's tool configuration changes. This is useful when you need to grant the agent additional permissions beyond what its tools require.<br/>
        /// Setting mode to `auto` resumes platform-managed roles. The platform will immediately resync the roles to match the current tool configuration.
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
        global::System.Threading.Tasks.Task<global::Vectara.AgentIdentity> UpdateIdentityAsync(
            string agentKey,

            global::Vectara.UpdateAgentIdentityRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent identity<br/>
        /// Update the agent's identity role management mode and/or roles.<br/>
        /// Setting mode to `manual` freezes the current roles. The platform will no longer recompute roles when the agent's tool configuration changes. This is useful when you need to grant the agent additional permissions beyond what its tools require.<br/>
        /// Setting mode to `auto` resumes platform-managed roles. The platform will immediately resync the roles to match the current tool configuration.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="mode">
        /// The role management mode of the agent's identity.<br/>
        /// - `auto`: The platform keeps roles in sync with the agent's tool configuration. When tools change, roles are automatically recomputed.<br/>
        /// - `manual`: Roles are user-managed. The platform will not modify roles when the agent is updated.<br/>
        /// Example: auto
        /// </param>
        /// <param name="apiRoles">
        /// Customer-level roles to assign. Only applied in `manual` mode.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific roles to assign. Only applied in `manual` mode.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific roles to assign. Only applied in `manual` mode.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentIdentity> UpdateIdentityAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AgentIdentityMode? mode = default,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles = default,
            global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? corpusRoles = default,
            global::System.Collections.Generic.IList<global::Vectara.AgentRole>? agentRoles = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}