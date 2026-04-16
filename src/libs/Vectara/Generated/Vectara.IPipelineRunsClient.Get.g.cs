#nullable enable

namespace Vectara
{
    public partial interface IPipelineRunsClient
    {
        /// <summary>
        /// Get pipeline run<br/>
        /// Retrieve details of a specific pipeline run including record counts, session keys, and status.
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
        global::System.Threading.Tasks.Task<global::Vectara.PipelineRun> GetAsync(
            string pipelineKey,
            string runId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}