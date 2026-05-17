#nullable enable

namespace Vectara
{
    public partial interface IAgentAnalyticsClient
    {
        /// <summary>
        /// List spans in a trace<br/>
        /// Retrieve the flat list of spans for a given trace, each with its parent_span_id for reconstructing the tree.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="traceId"></param>
        /// <param name="includeContent">
        /// Default Value: false
        /// </param>
        /// <param name="operation"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="excludeSubagents">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListAgentTraceSpansResponse> ListTraceSpansAsync(
            string traceId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? includeContent = default,
            global::Vectara.ListTraceSpansOperation? operation = default,
            string? parentSpanId = default,
            bool? excludeSubagents = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List spans in a trace<br/>
        /// Retrieve the flat list of spans for a given trace, each with its parent_span_id for reconstructing the tree.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="traceId"></param>
        /// <param name="includeContent">
        /// Default Value: false
        /// </param>
        /// <param name="operation"></param>
        /// <param name="parentSpanId"></param>
        /// <param name="excludeSubagents">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListAgentTraceSpansResponse>> ListTraceSpansAsResponseAsync(
            string traceId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? includeContent = default,
            global::Vectara.ListTraceSpansOperation? operation = default,
            string? parentSpanId = default,
            bool? excludeSubagents = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}