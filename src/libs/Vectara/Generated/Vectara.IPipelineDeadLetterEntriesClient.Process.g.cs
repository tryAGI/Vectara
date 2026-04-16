#nullable enable

namespace Vectara
{
    public partial interface IPipelineDeadLetterEntriesClient
    {
        /// <summary>
        /// Process dead letters<br/>
        /// Process dead letters by creating a new pipeline run that re-fetches the specified records from source and sends them through the agent. If no filters are provided, all pending dead letters are processed.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.PipelineRun> ProcessAsync(
            string pipelineKey,

            global::Vectara.ProcessPipelineDeadLetterEntriesRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process dead letters<br/>
        /// Process dead letters by creating a new pipeline run that re-fetches the specified records from source and sends them through the agent. If no filters are provided, all pending dead letters are processed.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="sourceRecordIds">
        /// Specific source record IDs to process. If omitted, processes all matching dead letters.
        /// </param>
        /// <param name="lastRunId">
        /// Only process dead letters from this specific run.
        /// </param>
        /// <param name="origin">
        /// How this dead letter was created.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.PipelineRun> ProcessAsync(
            string pipelineKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<string>? sourceRecordIds = default,
            string? lastRunId = default,
            global::Vectara.DeadLetterOrigin? origin = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}