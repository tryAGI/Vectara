#nullable enable

namespace Vectara
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Replace pipeline<br/>
        /// Replaces a pipeline's configuration. Provide the full pipeline definition.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. You can provide the key, or the platform generates one.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Pipeline> ReplaceAsync(
            string pipelineKey,

            global::Vectara.CreatePipelineRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace pipeline<br/>
        /// Replaces a pipeline's configuration. Provide the full pipeline definition.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. You can provide the key, or the platform generates one.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Pipeline>> ReplaceAsResponseAsync(
            string pipelineKey,

            global::Vectara.CreatePipelineRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace pipeline<br/>
        /// Replaces a pipeline's configuration. Provide the full pipeline definition.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. You can provide the key, or the platform generates one.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="key">
        /// A user-provided key for the pipeline. If omitted, the platform generates one.
        /// </param>
        /// <param name="name">
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </param>
        /// <param name="description"></param>
        /// <param name="source">
        /// The source system to ingest data from.
        /// </param>
        /// <param name="trigger">
        /// Defines when the pipeline runs.
        /// </param>
        /// <param name="transform">
        /// Defines how source data is processed. Currently only agent transforms are supported.
        /// </param>
        /// <param name="syncMode">
        /// How the pipeline syncs data from the source.<br/>
        /// - `incremental`: Only process new or changed records since the last watermark.<br/>
        /// - `full_refresh`: Process all records from the source on each run.<br/>
        /// Default Value: incremental
        /// </param>
        /// <param name="processingOptions">
        /// Per-pipeline overrides of the service processing defaults. Omit to use the defaults.
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Pipeline> ReplaceAsync(
            string pipelineKey,
            string name,
            global::Vectara.PipelineSource source,
            global::Vectara.PipelineTrigger trigger,
            global::Vectara.PipelineTransform transform,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            global::Vectara.PipelineSyncMode? syncMode = default,
            global::Vectara.PipelineProcessingOptions? processingOptions = default,
            bool? enabled = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}