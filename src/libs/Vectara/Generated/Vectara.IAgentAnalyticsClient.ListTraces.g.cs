#nullable enable

namespace Vectara
{
    public partial interface IAgentAnalyticsClient
    {
        /// <summary>
        /// List agent traces<br/>
        /// List agent traces with optional filtering by agent, session, status, and time range.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey"></param>
        /// <param name="sessionKey"></param>
        /// <param name="status"></param>
        /// <param name="errorType"></param>
        /// <param name="operation"></param>
        /// <param name="toolName"></param>
        /// <param name="toolErrorType"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="minDurationMs"></param>
        /// <param name="maxDurationMs"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListAgentTracesResponse> ListTracesAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? agentKey = default,
            string? sessionKey = default,
            global::Vectara.ListTracesStatus? status = default,
            global::Vectara.ListTracesErrorType? errorType = default,
            global::Vectara.ListTracesOperation? operation = default,
            string? toolName = default,
            global::Vectara.ListTracesToolErrorType? toolErrorType = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            long? minDurationMs = default,
            long? maxDurationMs = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}