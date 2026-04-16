
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to process dead letters. Filters select which dead letters to process.<br/>
    /// If no filters are provided, all pending dead letters are processed.
    /// </summary>
    public sealed partial class ProcessPipelineDeadLetterEntriesRequest
    {
        /// <summary>
        /// Specific source record IDs to process. If omitted, processes all matching dead letters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_record_ids")]
        public global::System.Collections.Generic.IList<string>? SourceRecordIds { get; set; }

        /// <summary>
        /// Only process dead letters from this specific run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_id")]
        public string? LastRunId { get; set; }

        /// <summary>
        /// How this dead letter was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.DeadLetterOriginJsonConverter))]
        public global::Vectara.DeadLetterOrigin? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPipelineDeadLetterEntriesRequest" /> class.
        /// </summary>
        /// <param name="sourceRecordIds">
        /// Specific source record IDs to process. If omitted, processes all matching dead letters.
        /// </param>
        /// <param name="lastRunId">
        /// Only process dead letters from this specific run.
        /// </param>
        /// <param name="origin">
        /// How this dead letter was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessPipelineDeadLetterEntriesRequest(
            global::System.Collections.Generic.IList<string>? sourceRecordIds,
            string? lastRunId,
            global::Vectara.DeadLetterOrigin? origin)
        {
            this.SourceRecordIds = sourceRecordIds;
            this.LastRunId = lastRunId;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPipelineDeadLetterEntriesRequest" /> class.
        /// </summary>
        public ProcessPipelineDeadLetterEntriesRequest()
        {
        }
    }
}