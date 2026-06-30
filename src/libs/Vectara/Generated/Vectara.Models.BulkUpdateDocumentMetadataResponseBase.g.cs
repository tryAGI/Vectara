
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Fields common to every bulk metadata update response variant.
    /// </summary>
    public sealed partial class BulkUpdateDocumentMetadataResponseBase
    {
        /// <summary>
        /// Job ID to track the bulk metadata update via the Jobs API.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataResponseBase" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Job ID to track the bulk metadata update via the Jobs API.<br/>
        /// Example: job_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="cutoffAt">
        /// Instant captured when the operation started. Only documents created or updated before this instant are eligible. Present only when selection uses `metadata_filter`; omitted when `document_ids` is supplied.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateDocumentMetadataResponseBase(
            string jobId,
            global::System.DateTime? cutoffAt)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CutoffAt = cutoffAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataResponseBase" /> class.
        /// </summary>
        public BulkUpdateDocumentMetadataResponseBase()
        {
        }

    }
}