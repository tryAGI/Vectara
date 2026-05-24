#nullable enable

namespace Vectara
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// List agent sessions<br/>
        /// List all agent sessions for the specified agent. This endpoint returns high-level information about each session, with optional filtering and pagination. Use this operation to browse existing sessions or to locate a specific session key for further inspection or updates.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="filter">
        /// Example: support.*
        /// </param>
        /// <param name="metadataFilter">
        /// Example: user_role = 'premium' AND tier &gt;= 2
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListAgentSessionsResponse> ListAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            string? metadataFilter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent sessions<br/>
        /// List all agent sessions for the specified agent. This endpoint returns high-level information about each session, with optional filtering and pagination. Use this operation to browse existing sessions or to locate a specific session key for further inspection or updates.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="filter">
        /// Example: support.*
        /// </param>
        /// <param name="metadataFilter">
        /// Example: user_role = 'premium' AND tier &gt;= 2
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListAgentSessionsResponse>> ListAsResponseAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            string? metadataFilter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}