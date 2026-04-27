#nullable enable

namespace Vectara
{
    public partial interface IAgentAnalyticsClient
    {
        /// <summary>
        /// Get span in a trace<br/>
        /// Retrieve the details of a specific span within a trace.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="includeContent">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentTraceSpan> GetTraceSpanAsync(
            string traceId,
            string spanId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? includeContent = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}