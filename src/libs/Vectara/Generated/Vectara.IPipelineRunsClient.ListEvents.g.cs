#nullable enable

namespace Vectara
{
    public partial interface IPipelineRunsClient
    {
        /// <summary>
        /// List pipeline run events<br/>
        /// List the timeline of events for a pipeline run, keyed by `run_id`. Events report what the run did — records discovered, records processed, agent sessions created, dead letters, watermark advances, and lifecycle transitions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="runId">
        /// The unique identifier for a pipeline run.<br/>
        /// Example: run_pip_abc_manual_550e8400
        /// </param>
        /// <param name="type"></param>
        /// <param name="sourceRecordId"></param>
        /// <param name="order">
        /// Sort direction for paginated list endpoints.
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListPipelineRunEventsResponse> ListEventsAsync(
            string pipelineKey,
            string runId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<global::Vectara.PipelineRunEventType>? type = default,
            string? sourceRecordId = default,
            global::Vectara.SortOrder? order = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List pipeline run events<br/>
        /// List the timeline of events for a pipeline run, keyed by `run_id`. Events report what the run did — records discovered, records processed, agent sessions created, dead letters, watermark advances, and lifecycle transitions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="runId">
        /// The unique identifier for a pipeline run.<br/>
        /// Example: run_pip_abc_manual_550e8400
        /// </param>
        /// <param name="type"></param>
        /// <param name="sourceRecordId"></param>
        /// <param name="order">
        /// Sort direction for paginated list endpoints.
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ListPipelineRunEventsResponse>> ListEventsAsResponseAsync(
            string pipelineKey,
            string runId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<global::Vectara.PipelineRunEventType>? type = default,
            string? sourceRecordId = default,
            global::Vectara.SortOrder? order = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}