#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesClient
    {
        /// <summary>
        /// Update an alias's metadata<br/>
        /// Updates an alias's metadata fields (name, description, enabled, metadata). Setting `enabled` to false on a platform-generated alias fronted by a widget connector is rejected with `409`; disable the connector instead. To replace the routing policy, use `PUT /v2/agent_aliases/{alias_key}/policy`. Policies are atomic and do not support partial updates.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentAlias> UpdateAsync(
            string aliasKey,

            global::Vectara.UpdateAgentAliasRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an alias's metadata<br/>
        /// Updates an alias's metadata fields (name, description, enabled, metadata). Setting `enabled` to false on a platform-generated alias fronted by a widget connector is rejected with `409`; disable the connector instead. To replace the routing policy, use `PUT /v2/agent_aliases/{alias_key}/policy`. Policies are atomic and do not support partial updates.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentAlias>> UpdateAsResponseAsync(
            string aliasKey,

            global::Vectara.UpdateAgentAliasRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an alias's metadata<br/>
        /// Updates an alias's metadata fields (name, description, enabled, metadata). Setting `enabled` to false on a platform-generated alias fronted by a widget connector is rejected with `409`; disable the connector instead. To replace the routing policy, use `PUT /v2/agent_aliases/{alias_key}/policy`. Policies are atomic and do not support partial updates.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentAlias> UpdateAsync(
            string aliasKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            bool? enabled = default,
            object? metadata = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}