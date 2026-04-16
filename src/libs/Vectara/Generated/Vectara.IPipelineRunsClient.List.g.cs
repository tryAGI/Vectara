#nullable enable

namespace Vectara
{
    public partial interface IPipelineRunsClient
    {
        /// <summary>
        /// List pipeline runs<br/>
        /// List execution runs for a pipeline, with optional filtering by status.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="status">
        /// The status of a pipeline run.
        /// </param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListPipelineRunsResponse> ListAsync(
            string pipelineKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.PipelineRunStatus? status = default,
            global::System.DateTime? after = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}