
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response when async=true. Operation queued, returns immediately (HTTP 202).
    /// </summary>
    public sealed partial class BulkDeleteAsyncResponse
    {
        /// <summary>
        /// Indicates this is an async response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Deprecated alias for `type`; identical value. Use `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BulkDeleteAsyncResponseResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.BulkDeleteAsyncResponseResponseType ResponseType { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteAsyncResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates this is an async response.
        /// </param>
        /// <param name="responseType">
        /// Deprecated alias for `type`; identical value. Use `type`.
        /// </param>
        /// <param name="jobId">
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="cutoffAt">
        /// Instant captured when the operation started. Only documents created or updated before this instant are eligible. Present only when selection uses `metadata_filter`; omitted when `document_ids` is supplied.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkDeleteAsyncResponse(
            string type,
            global::Vectara.BulkDeleteAsyncResponseResponseType responseType,
            string jobId,
            global::System.DateTime? cutoffAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ResponseType = responseType;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CutoffAt = cutoffAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteAsyncResponse" /> class.
        /// </summary>
        public BulkDeleteAsyncResponse()
        {
        }

    }
}