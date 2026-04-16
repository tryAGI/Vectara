#nullable enable

namespace Vectara
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Create pipeline<br/>
        /// Create a new pipeline that continuously ingests data from a source system and sends each record to an agent for processing. A new agent session is created per source record. A pipeline is distinct from an agent schedule (which is a recurring single execution of an agent) and from a connector (which is a bidirectional chat integration like Slack). A pipeline is an automated, one-directional flow of all source data through an agent.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Pipeline> CreateAsync(

            global::Vectara.CreatePipelineRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create pipeline<br/>
        /// Create a new pipeline that continuously ingests data from a source system and sends each record to an agent for processing. A new agent session is created per source record. A pipeline is distinct from an agent schedule (which is a recurring single execution of an agent) and from a connector (which is a bidirectional chat integration like Slack). A pipeline is an automated, one-directional flow of all source data through an agent.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A user-provided key for the pipeline. If omitted, one is auto-generated.
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
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Pipeline> CreateAsync(
            string name,
            global::Vectara.S3SourceConfiguration source,
            global::Vectara.PipelineTrigger trigger,
            global::Vectara.PipelineTransform transform,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            global::Vectara.PipelineSyncMode? syncMode = default,
            bool? enabled = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}