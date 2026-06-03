#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesSessionsClient
    {
        /// <summary>
        /// List sessions routed via this alias<br/>
        /// List sessions that were originally created via this alias (sessions whose `alias_key` matches). Sessions are also reachable under their resolved agent's URL; this endpoint is the alias-scoped view.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListAgentSessionsResponse> List2Async(
            string aliasKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List sessions routed via this alias<br/>
        /// List sessions that were originally created via this alias (sessions whose `alias_key` matches). Sessions are also reachable under their resolved agent's URL; this endpoint is the alias-scoped view.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListAgentSessionsResponse>> List2AsResponseAsync(
            string aliasKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}