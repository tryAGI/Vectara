
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A record that failed processing during a pipeline run. Dead letters are pipeline-scoped:<br/>
    /// if the same source record fails across multiple runs, it is upserted (not duplicated).<br/>
    /// Resolved dead letters are deleted from the table.
    /// </summary>
    public sealed partial class PipelineDeadLetterEntry
    {
        /// <summary>
        /// The unique identifier for this dead letter entry.<br/>
        /// Included only in responses<br/>
        /// Example: pdl_a1b2c3d4-e5f6-7890-abcd-ef0123456789
        /// </summary>
        /// <default>default!</default>
        /// <example>pdl_a1b2c3d4-e5f6-7890-abcd-ef0123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The identifier for the source record. Format depends on connector type:<br/>
        /// - S3: the object key (e.g. `legal/contracts/doc.pdf`)<br/>
        /// - SharePoint: the drive item ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_record_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceRecordId { get; set; }

        /// <summary>
        /// The status of a dead letter entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.DeadLetterStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.DeadLetterStatus Status { get; set; }

        /// <summary>
        /// The error message from the most recent failed processing attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the pipeline run that most recently processed (or failed) this record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_id")]
        public string? LastRunId { get; set; }

        /// <summary>
        /// The number of times this record has been attempted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttemptCount { get; set; }

        /// <summary>
        /// How this dead letter was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.DeadLetterOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.DeadLetterOrigin Origin { get; set; }

        /// <summary>
        /// When this dead letter was first recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When this dead letter was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDeadLetterEntry" /> class.
        /// </summary>
        /// <param name="sourceRecordId">
        /// The identifier for the source record. Format depends on connector type:<br/>
        /// - S3: the object key (e.g. `legal/contracts/doc.pdf`)<br/>
        /// - SharePoint: the drive item ID
        /// </param>
        /// <param name="status">
        /// The status of a dead letter entry.
        /// </param>
        /// <param name="attemptCount">
        /// The number of times this record has been attempted.
        /// </param>
        /// <param name="origin">
        /// How this dead letter was created.
        /// </param>
        /// <param name="createdAt">
        /// When this dead letter was first recorded.
        /// </param>
        /// <param name="errorMessage">
        /// The error message from the most recent failed processing attempt.
        /// </param>
        /// <param name="lastRunId">
        /// The ID of the pipeline run that most recently processed (or failed) this record.
        /// </param>
        /// <param name="updatedAt">
        /// When this dead letter was last updated.
        /// </param>
        /// <param name="id">
        /// The unique identifier for this dead letter entry.<br/>
        /// Included only in responses<br/>
        /// Example: pdl_a1b2c3d4-e5f6-7890-abcd-ef0123456789
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineDeadLetterEntry(
            string sourceRecordId,
            global::Vectara.DeadLetterStatus status,
            int attemptCount,
            global::Vectara.DeadLetterOrigin origin,
            global::System.DateTime createdAt,
            string? errorMessage,
            string? lastRunId,
            global::System.DateTime? updatedAt,
            string id = default!)
        {
            this.Id = id;
            this.SourceRecordId = sourceRecordId ?? throw new global::System.ArgumentNullException(nameof(sourceRecordId));
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.LastRunId = lastRunId;
            this.AttemptCount = attemptCount;
            this.Origin = origin;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDeadLetterEntry" /> class.
        /// </summary>
        public PipelineDeadLetterEntry()
        {
        }
    }
}