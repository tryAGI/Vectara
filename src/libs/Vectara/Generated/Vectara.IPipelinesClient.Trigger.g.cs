#nullable enable

namespace Vectara
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Trigger pipeline<br/>
        /// Manually trigger a pipeline run outside of the normal schedule. The pipeline will fetch new data from the source and process it through the agent. Returns the created run.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.PipelineRun> TriggerAsync(
            string pipelineKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}