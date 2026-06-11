#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent memory<br/>
        /// Replace the agent's `_learned_memory` skill content. The submitted `content` fully replaces the previous memory — the API does not append.<br/>
        /// Each successful update increments `memory_version` and records a full snapshot in the memory history.<br/>
        /// To guard against concurrent updates, pass `expected_version` equal to the `memory_version` you last read.<br/>
        /// If it no longer matches the current version, the update is rejected with `409 Conflict`; re-read the memory and retry.<br/>
        /// Omit `expected_version` to update unconditionally.
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
        global::System.Threading.Tasks.Task<global::Vectara.AgentMemory> UpdateMemoryAsync(
            string agentKey,

            global::Vectara.UpdateAgentMemoryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent memory<br/>
        /// Replace the agent's `_learned_memory` skill content. The submitted `content` fully replaces the previous memory — the API does not append.<br/>
        /// Each successful update increments `memory_version` and records a full snapshot in the memory history.<br/>
        /// To guard against concurrent updates, pass `expected_version` equal to the `memory_version` you last read.<br/>
        /// If it no longer matches the current version, the update is rejected with `409 Conflict`; re-read the memory and retry.<br/>
        /// Omit `expected_version` to update unconditionally.
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentMemory>> UpdateMemoryAsResponseAsync(
            string agentKey,

            global::Vectara.UpdateAgentMemoryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent memory<br/>
        /// Replace the agent's `_learned_memory` skill content. The submitted `content` fully replaces the previous memory — the API does not append.<br/>
        /// Each successful update increments `memory_version` and records a full snapshot in the memory history.<br/>
        /// To guard against concurrent updates, pass `expected_version` equal to the `memory_version` you last read.<br/>
        /// If it no longer matches the current version, the update is rejected with `409 Conflict`; re-read the memory and retry.<br/>
        /// Omit `expected_version` to update unconditionally.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="content">
        /// The full memory content to store. Replaces the previous content entirely.<br/>
        /// Example: - Customer prefers email contact<br/>
        /// - Time zone: PST
        /// </param>
        /// <param name="updatedBy">
        /// Identifier of who is performing this update (e.g. `query_handler`, `manual_update`).<br/>
        /// Example: query_handler
        /// </param>
        /// <param name="expectedVersion">
        /// The `memory_version` the client last read. If provided and it does not match the current version, the update is<br/>
        /// rejected with `409 Conflict`. Omit to update unconditionally.<br/>
        /// Example: 2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentMemory> UpdateMemoryAsync(
            string agentKey,
            string content,
            string updatedBy,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? expectedVersion = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}