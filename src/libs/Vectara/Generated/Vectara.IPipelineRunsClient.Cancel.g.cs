#nullable enable

namespace Vectara
{
    public partial interface IPipelineRunsClient
    {
        /// <summary>
        /// Cancel pipeline run<br/>
        /// Request cancellation of an in-progress pipeline run. The run is asked to stop at the next checkpoint; it may take a moment to transition to the cancelled state. Runs that have already completed, failed, or been cancelled cannot be cancelled again.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelAsync(
            string pipelineKey,
            string runId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel pipeline run<br/>
        /// Request cancellation of an in-progress pipeline run. The run is asked to stop at the next checkpoint; it may take a moment to transition to the cancelled state. Runs that have already completed, failed, or been cancelled cannot be cancelled again.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse> CancelAsResponseAsync(
            string pipelineKey,
            string runId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}