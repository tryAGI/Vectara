
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordProcessingEventVariant2
    {
        /// <summary>
        /// Default Value: record_processing
        /// </summary>
        /// <default>"record_processing"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "record_processing";

        /// <summary>
        /// Lifecycle status of a single source record within a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RecordProcessingEventStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RecordProcessingEventStatus Status { get; set; }

        /// <summary>
        /// The identifier of the source record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_record_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceRecordId { get; set; }

        /// <summary>
        /// The agent session created to process this record. Always present on `completed`;<br/>
        /// may be present on `failed` if a session was created before the failure; null on `started`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// True if a `completed` record was skipped because a prior successful session already exists at the same watermark. Only meaningful when `status` is `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public bool? Skipped { get; set; }

        /// <summary>
        /// Failure message. Present when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Whether a `failed` record resulted in a dead-letter write or update. Only meaningful when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dead_lettered")]
        public bool? DeadLettered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordProcessingEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: record_processing
        /// </param>
        /// <param name="status">
        /// Lifecycle status of a single source record within a run.
        /// </param>
        /// <param name="sourceRecordId">
        /// The identifier of the source record.
        /// </param>
        /// <param name="sessionKey">
        /// The agent session created to process this record. Always present on `completed`;<br/>
        /// may be present on `failed` if a session was created before the failure; null on `started`.
        /// </param>
        /// <param name="skipped">
        /// True if a `completed` record was skipped because a prior successful session already exists at the same watermark. Only meaningful when `status` is `completed`.
        /// </param>
        /// <param name="error">
        /// Failure message. Present when `status` is `failed`.
        /// </param>
        /// <param name="deadLettered">
        /// Whether a `failed` record resulted in a dead-letter write or update. Only meaningful when `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordProcessingEventVariant2(
            string type,
            global::Vectara.RecordProcessingEventStatus status,
            string sourceRecordId,
            string? sessionKey,
            bool? skipped,
            string? error,
            bool? deadLettered)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
            this.SourceRecordId = sourceRecordId ?? throw new global::System.ArgumentNullException(nameof(sourceRecordId));
            this.SessionKey = sessionKey;
            this.Skipped = skipped;
            this.Error = error;
            this.DeadLettered = deadLettered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordProcessingEventVariant2" /> class.
        /// </summary>
        public RecordProcessingEventVariant2()
        {
        }

    }
}