#nullable enable

namespace Vectara
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Bulk update document metadata<br/>
        /// Initiates an asynchronous bulk metadata update for documents in a corpus.<br/>
        /// Select documents with either `document_ids` or `metadata_filter`. If `document_ids` is provided, `metadata_filter` is ignored.<br/>
        /// The same metadata object (from the request body) is applied to every matched document, using the chosen `strategy`.<br/>
        /// `merge` (default) adds or overwrites only the supplied fields and leaves the rest intact; `replace` overwrites the entire metadata object.<br/>
        /// **Important**: This is a best-effort operation.<br/>
        /// See the response schema documentation for details on the behavior differences between `metadata_filter` and `document_ids` parameters.<br/>
        /// Use the returned `job_id` to track progress via the Jobs API.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadataFilter"></param>
        /// <param name="documentIds"></param>
        /// <param name="async">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.BulkUpdateDocumentMetadataResponse> BulkUpdateMetadataAsync(
            string corpusKey,

            global::Vectara.BulkUpdateDocumentMetadataRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? metadataFilter = default,
            string? documentIds = default,
            bool? async = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update document metadata<br/>
        /// Initiates an asynchronous bulk metadata update for documents in a corpus.<br/>
        /// Select documents with either `document_ids` or `metadata_filter`. If `document_ids` is provided, `metadata_filter` is ignored.<br/>
        /// The same metadata object (from the request body) is applied to every matched document, using the chosen `strategy`.<br/>
        /// `merge` (default) adds or overwrites only the supplied fields and leaves the rest intact; `replace` overwrites the entire metadata object.<br/>
        /// **Important**: This is a best-effort operation.<br/>
        /// See the response schema documentation for details on the behavior differences between `metadata_filter` and `document_ids` parameters.<br/>
        /// Use the returned `job_id` to track progress via the Jobs API.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadataFilter"></param>
        /// <param name="documentIds"></param>
        /// <param name="async">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.BulkUpdateDocumentMetadataResponse>> BulkUpdateMetadataAsResponseAsync(
            string corpusKey,

            global::Vectara.BulkUpdateDocumentMetadataRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? metadataFilter = default,
            string? documentIds = default,
            bool? async = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update document metadata<br/>
        /// Initiates an asynchronous bulk metadata update for documents in a corpus.<br/>
        /// Select documents with either `document_ids` or `metadata_filter`. If `document_ids` is provided, `metadata_filter` is ignored.<br/>
        /// The same metadata object (from the request body) is applied to every matched document, using the chosen `strategy`.<br/>
        /// `merge` (default) adds or overwrites only the supplied fields and leaves the rest intact; `replace` overwrites the entire metadata object.<br/>
        /// **Important**: This is a best-effort operation.<br/>
        /// See the response schema documentation for details on the behavior differences between `metadata_filter` and `document_ids` parameters.<br/>
        /// Use the returned `job_id` to track progress via the Jobs API.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadataFilter"></param>
        /// <param name="documentIds"></param>
        /// <param name="async">
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// The metadata object to apply to every matched document.<br/>
        /// Example: {"status":"archived","reviewed":true,"year":2024}
        /// </param>
        /// <param name="strategy">
        /// How to apply the supplied `metadata` to each matched document.<br/>
        /// - `merge` (default): adds or overwrites only the supplied fields, leaving other existing fields intact.<br/>
        /// - `replace`: replaces the entire existing metadata with the supplied object.<br/>
        /// Default Value: merge
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.BulkUpdateDocumentMetadataResponse> BulkUpdateMetadataAsync(
            string corpusKey,
            object metadata,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? metadataFilter = default,
            string? documentIds = default,
            bool? async = default,
            global::Vectara.BulkUpdateDocumentMetadataRequestStrategy? strategy = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}