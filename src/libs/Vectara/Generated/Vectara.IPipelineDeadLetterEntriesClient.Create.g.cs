#nullable enable

namespace Vectara
{
    public partial interface IPipelineDeadLetterEntriesClient
    {
        /// <summary>
        /// Create dead letter<br/>
        /// Manually add a source record to the dead letter queue for reprocessing. Use this when you want to force a record through the pipeline again, for example when the agent or judge made an incorrect decision.
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
        global::System.Threading.Tasks.Task<global::Vectara.PipelineDeadLetterEntry> CreateAsync(
            string pipelineKey,

            global::Vectara.CreatePipelineDeadLetterEntryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dead letter<br/>
        /// Manually add a source record to the dead letter queue for reprocessing. Use this when you want to force a record through the pipeline again, for example when the agent or judge made an incorrect decision.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="sourceRecordId">
        /// The identifier for the source record to add. Format depends on connector type:<br/>
        /// - S3: the object key (e.g. `legal/contracts/doc.pdf`)<br/>
        /// - SharePoint: the drive item ID
        /// </param>
        /// <param name="errorMessage">
        /// Optional reason for manually adding this record.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.PipelineDeadLetterEntry> CreateAsync(
            string pipelineKey,
            string sourceRecordId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? errorMessage = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}