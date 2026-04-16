#nullable enable

namespace Vectara
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// List pipelines<br/>
        /// List all pipelines with optional filtering by source type, status, or enabled state.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="sourceType"></param>
        /// <param name="status">
        /// The current operational status of the pipeline.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListPipelinesResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.ListPipelinesSourceType? sourceType = default,
            global::Vectara.PipelineStatus? status = default,
            bool? enabled = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}