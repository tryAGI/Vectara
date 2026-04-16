#nullable enable

namespace Vectara
{
    public partial interface IPipelineDeadLetterEntriesClient
    {
        /// <summary>
        /// List dead letters<br/>
        /// List dead letters for a pipeline, with optional filtering by status or run.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="status">
        /// The status of a dead letter entry.
        /// </param>
        /// <param name="lastRunId">
        /// The unique identifier for a pipeline run.<br/>
        /// Example: run_pip_abc_manual_550e8400
        /// </param>
        /// <param name="origin">
        /// How this dead letter was created.
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListPipelineDeadLetterEntriesResponse> ListAsync(
            string pipelineKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.DeadLetterStatus? status = default,
            string? lastRunId = default,
            global::Vectara.DeadLetterOrigin? origin = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}