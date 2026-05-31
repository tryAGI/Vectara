#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesClient
    {
        /// <summary>
        /// Create an alias<br/>
        /// Create a new alias. Aliases are routing primitives that map a public name to one or more underlying agents under a configurable policy. When a session is created through an alias (via `POST /v2/agent_aliases/{alias_key}/sessions`), the alias's policy decides which underlying agent runs that session.<br/>
        /// Common patterns:<br/>
        /// - **Direct alias** — a `routed` policy with one rule and one target. Identical in behavior to invoking the agent directly.<br/>
        /// - **Canary rollout** — a `routed` policy with one rule and multiple weighted targets (e.g. 90% v1, 10% v2).<br/>
        /// - **Tenant routing** — a `routed` policy with multiple rules, each matching on session metadata (e.g. `session.metadata.tenant`).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentAlias> CreateAsync(

            global::Vectara.CreateAgentAliasRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an alias<br/>
        /// Create a new alias. Aliases are routing primitives that map a public name to one or more underlying agents under a configurable policy. When a session is created through an alias (via `POST /v2/agent_aliases/{alias_key}/sessions`), the alias's policy decides which underlying agent runs that session.<br/>
        /// Common patterns:<br/>
        /// - **Direct alias** — a `routed` policy with one rule and one target. Identical in behavior to invoking the agent directly.<br/>
        /// - **Canary rollout** — a `routed` policy with one rule and multiple weighted targets (e.g. 90% v1, 10% v2).<br/>
        /// - **Tenant routing** — a `routed` policy with multiple rules, each matching on session metadata (e.g. `session.metadata.tenant`).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentAlias>> CreateAsResponseAsync(

            global::Vectara.CreateAgentAliasRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an alias<br/>
        /// Create a new alias. Aliases are routing primitives that map a public name to one or more underlying agents under a configurable policy. When a session is created through an alias (via `POST /v2/agent_aliases/{alias_key}/sessions`), the alias's policy decides which underlying agent runs that session.<br/>
        /// Common patterns:<br/>
        /// - **Direct alias** — a `routed` policy with one rule and one target. Identical in behavior to invoking the agent directly.<br/>
        /// - **Canary rollout** — a `routed` policy with one rule and multiple weighted targets (e.g. 90% v1, 10% v2).<br/>
        /// - **Tenant routing** — a `routed` policy with multiple rules, each matching on session metadata (e.g. `session.metadata.tenant`).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="policy">
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluate ordered rules; the first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). Rules with omitted `match` are catch-all rules (typically last).<br/>
        /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentAlias> CreateAsync(
            string key,
            string name,
            global::Vectara.RoutedAliasPolicy policy,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? description = default,
            bool? enabled = default,
            object? metadata = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}