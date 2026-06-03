#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesClient
    {
        /// <summary>
        /// Replace an alias's routing policy<br/>
        /// Atomically replace the alias's routing policy and stickiness configuration. Replacement is whole-object; partial merging is not supported.<br/>
        /// Use this endpoint to flip canary weights, change tenant routing, etc. The change is atomic: in-flight sessions resolved before the change keep their resolved agent (resolution is once-at-creation).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentAlias> ReplacePolicyAsync(
            string aliasKey,

            global::Vectara.ReplaceAliasPolicyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace an alias's routing policy<br/>
        /// Atomically replace the alias's routing policy and stickiness configuration. Replacement is whole-object; partial merging is not supported.<br/>
        /// Use this endpoint to flip canary weights, change tenant routing, etc. The change is atomic: in-flight sessions resolved before the change keep their resolved agent (resolution is once-at-creation).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentAlias>> ReplacePolicyAsResponseAsync(
            string aliasKey,

            global::Vectara.ReplaceAliasPolicyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace an alias's routing policy<br/>
        /// Atomically replace the alias's routing policy and stickiness configuration. Replacement is whole-object; partial merging is not supported.<br/>
        /// Use this endpoint to flip canary weights, change tenant routing, etc. The change is atomic: in-flight sessions resolved before the change keep their resolved agent (resolution is once-at-creation).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="policy">
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluate ordered rules; the first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). A rule with omitted `match` is a catch-all that always matches; it must be the last rule, and any rule placed after it is rejected as unreachable.<br/>
        /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentAlias> ReplacePolicyAsync(
            string aliasKey,
            global::Vectara.RoutedAliasPolicy policy,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}