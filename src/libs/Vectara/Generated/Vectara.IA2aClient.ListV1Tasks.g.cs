#nullable enable

namespace Vectara
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// List A2A v1 tasks<br/>
        /// List the agent's tasks, with pagination and optional filtering by conversation context and lifecycle state.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="contextId"></param>
        /// <param name="status">
        /// A2A v1 task lifecycle state. Note `TASK_STATE_CANCELED` uses the US spelling per the v1 proto (one L).
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken"></param>
        /// <param name="historyLength">
        /// Default Value: 0
        /// </param>
        /// <param name="statusTimestampAfter"></param>
        /// <param name="includeArtifacts">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.A2aV1ListTasksResponse> ListV1TasksAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? contextId = default,
            global::Vectara.A2aV1TaskState? status = default,
            int? pageSize = default,
            string? pageToken = default,
            int? historyLength = default,
            global::System.DateTime? statusTimestampAfter = default,
            bool? includeArtifacts = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List A2A v1 tasks<br/>
        /// List the agent's tasks, with pagination and optional filtering by conversation context and lifecycle state.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="contextId"></param>
        /// <param name="status">
        /// A2A v1 task lifecycle state. Note `TASK_STATE_CANCELED` uses the US spelling per the v1 proto (one L).
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken"></param>
        /// <param name="historyLength">
        /// Default Value: 0
        /// </param>
        /// <param name="statusTimestampAfter"></param>
        /// <param name="includeArtifacts">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.A2aV1ListTasksResponse>> ListV1TasksAsResponseAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? contextId = default,
            global::Vectara.A2aV1TaskState? status = default,
            int? pageSize = default,
            string? pageToken = default,
            int? historyLength = default,
            global::System.DateTime? statusTimestampAfter = default,
            bool? includeArtifacts = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}