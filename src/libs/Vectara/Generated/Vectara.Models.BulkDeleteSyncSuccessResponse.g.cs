
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response when async=false and operation completes successfully (HTTP 200).
    /// </summary>
    public sealed partial class BulkDeleteSyncSuccessResponse
    {
        /// <summary>
        /// Indicates this is a successful sync response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Deprecated alias for `type`; identical value. Use `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BulkDeleteSyncSuccessResponseResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.BulkDeleteSyncSuccessResponseResponseType ResponseType { get; set; }

        /// <summary>
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_3Kx9QpVn2mZr8YbLc5TdWe
        /// </summary>
        /// <example>job_3Kx9QpVn2mZr8YbLc5TdWe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Instant captured when the operation started. Only documents created or updated before this instant are eligible. Present only when selection uses `metadata_filter`; omitted when `document_ids` is supplied.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </summary>
        /// <example>2025-12-18T15:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cutoff_at")]
        public global::System.DateTime? CutoffAt { get; set; }

        /// <summary>
        /// Deprecated alias for `cutoff_at`; identical value and presence rules. Use `cutoff_at`.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </summary>
        /// <example>2025-12-18T15:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cutoff_timestamp")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? CutoffTimestamp { get; set; }

        /// <summary>
        /// Number of documents successfully deleted.<br/>
        /// Example: 1523
        /// </summary>
        /// <example>1523</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DeletedCount { get; set; }

        /// <summary>
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SkippedCount { get; set; }

        /// <summary>
        /// Number of documents that could not be deleted due to a non-retryable error (for example, a document that was not found).<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FailedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteSyncSuccessResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates this is a successful sync response.
        /// </param>
        /// <param name="responseType">
        /// Deprecated alias for `type`; identical value. Use `type`.
        /// </param>
        /// <param name="jobId">
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="deletedCount">
        /// Number of documents successfully deleted.<br/>
        /// Example: 1523
        /// </param>
        /// <param name="skippedCount">
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </param>
        /// <param name="failedCount">
        /// Number of documents that could not be deleted due to a non-retryable error (for example, a document that was not found).<br/>
        /// Example: 0
        /// </param>
        /// <param name="cutoffAt">
        /// Instant captured when the operation started. Only documents created or updated before this instant are eligible. Present only when selection uses `metadata_filter`; omitted when `document_ids` is supplied.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkDeleteSyncSuccessResponse(
            string type,
            global::Vectara.BulkDeleteSyncSuccessResponseResponseType responseType,
            string jobId,
            long deletedCount,
            long skippedCount,
            long failedCount,
            global::System.DateTime? cutoffAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ResponseType = responseType;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CutoffAt = cutoffAt;
            this.DeletedCount = deletedCount;
            this.SkippedCount = skippedCount;
            this.FailedCount = failedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteSyncSuccessResponse" /> class.
        /// </summary>
        public BulkDeleteSyncSuccessResponse()
        {
        }

    }
}