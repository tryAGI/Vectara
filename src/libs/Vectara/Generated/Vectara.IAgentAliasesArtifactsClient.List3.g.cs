#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesArtifactsClient
    {
        /// <summary>
        /// List artifacts on alias-routed session<br/>
        /// List artifacts stored in a session originally created via this alias. Artifacts are files either uploaded by the user, or generated within the session.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="orderBy">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListSessionArtifactsResponse> List3Async(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.ListAliasRoutedSessionArtifactsSortBy? sortBy = default,
            global::Vectara.ListAliasRoutedSessionArtifactsOrderBy? orderBy = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List artifacts on alias-routed session<br/>
        /// List artifacts stored in a session originally created via this alias. Artifacts are files either uploaded by the user, or generated within the session.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="orderBy">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListSessionArtifactsResponse>> List3AsResponseAsync(
            string aliasKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.ListAliasRoutedSessionArtifactsSortBy? sortBy = default,
            global::Vectara.ListAliasRoutedSessionArtifactsOrderBy? orderBy = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}