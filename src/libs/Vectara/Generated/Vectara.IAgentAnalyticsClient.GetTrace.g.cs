#nullable enable

namespace Vectara
{
    public partial interface IAgentAnalyticsClient
    {
        /// <summary>
        /// Get agent trace<br/>
        /// Retrieve the summary of a specific agent trace by its trace ID.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="traceId">
        /// Example: 0af7651916cd43dd8448eb211c80319c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentTrace> GetTraceAsync(
            string traceId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get agent trace<br/>
        /// Retrieve the summary of a specific agent trace by its trace ID.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="traceId">
        /// Example: 0af7651916cd43dd8448eb211c80319c
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentTrace>> GetTraceAsResponseAsync(
            string traceId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}