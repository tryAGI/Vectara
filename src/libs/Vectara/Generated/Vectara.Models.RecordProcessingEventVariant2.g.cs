
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// Lifecycle status of a single source record within a run. `started` when processing begins, `completed` when the record succeeded or was skipped without processing, `failed` for a failed processing attempt, and `dead_lettered` when the record exhausted its retries and was written to, or in a retry run updated in, the dead letter queue.
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
        /// The agent session created to process this record. Present on `completed`, except for a record the agent's `run_condition` evaluated to false for, which has no session. May be present on `failed` if a session was created before the failure. Null on `started` and `dead_lettered`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// True if a `completed` record was skipped. A prior successful session already exists at the same watermark, the agent's `run_condition` evaluated to false, or the judge agent's `run_condition` evaluated to false. `reason` distinguishes them. Only meaningful when `status` is `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public bool? Skipped { get; set; }

        /// <summary>
        /// Deprecated: superseded by `reason`. Populated with the failure message on `failed` and<br/>
        /// `dead_lettered` events; null on `started` and `completed`. Prefer `reason`, which additionally<br/>
        /// explains successful outcomes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Error { get; set; }

        /// <summary>
        /// Human-readable explanation of the record's outcome. On `failed` and `dead_lettered` this is the failure reason, the same text as the deprecated `error`. On `completed` it is the verification reason, which is the judge agent's reason, a condition's evaluated `reason_expression`, or a statement that verification did not run because the judge agent's own `run_condition` evaluated false. On a `completed` record with `skipped` true it is the literal string `run_condition` when the agent's condition evaluated to false. Null on `started`, and may be null on any status when no reason was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Deprecated: use the `dead_lettered` status on `record_processing` instead. Set to `true` when the<br/>
        /// record was written to the dead letter queue; null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dead_lettered")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DeadLettered { get; set; }

        /// <summary>
        /// Which processing attempt produced this event, starting at 1. A record that fails is retried, so<br/>
        /// the same record can emit `started` and `failed` events for several attempts before it emits<br/>
        /// `completed`. Null on `dead_lettered`, which is a terminal marker not tied to a single attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        public int? Attempt { get; set; }

        /// <summary>
        /// Wall-clock time in milliseconds this processing attempt took. Populated on `completed` and `failed`<br/>
        /// events when the attempt was timed; null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

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
        /// Lifecycle status of a single source record within a run. `started` when processing begins, `completed` when the record succeeded or was skipped without processing, `failed` for a failed processing attempt, and `dead_lettered` when the record exhausted its retries and was written to, or in a retry run updated in, the dead letter queue.
        /// </param>
        /// <param name="sourceRecordId">
        /// The identifier of the source record.
        /// </param>
        /// <param name="sessionKey">
        /// The agent session created to process this record. Present on `completed`, except for a record the agent's `run_condition` evaluated to false for, which has no session. May be present on `failed` if a session was created before the failure. Null on `started` and `dead_lettered`.
        /// </param>
        /// <param name="skipped">
        /// True if a `completed` record was skipped. A prior successful session already exists at the same watermark, the agent's `run_condition` evaluated to false, or the judge agent's `run_condition` evaluated to false. `reason` distinguishes them. Only meaningful when `status` is `completed`.
        /// </param>
        /// <param name="reason">
        /// Human-readable explanation of the record's outcome. On `failed` and `dead_lettered` this is the failure reason, the same text as the deprecated `error`. On `completed` it is the verification reason, which is the judge agent's reason, a condition's evaluated `reason_expression`, or a statement that verification did not run because the judge agent's own `run_condition` evaluated false. On a `completed` record with `skipped` true it is the literal string `run_condition` when the agent's condition evaluated to false. Null on `started`, and may be null on any status when no reason was recorded.
        /// </param>
        /// <param name="attempt">
        /// Which processing attempt produced this event, starting at 1. A record that fails is retried, so<br/>
        /// the same record can emit `started` and `failed` events for several attempts before it emits<br/>
        /// `completed`. Null on `dead_lettered`, which is a terminal marker not tied to a single attempt.
        /// </param>
        /// <param name="durationMs">
        /// Wall-clock time in milliseconds this processing attempt took. Populated on `completed` and `failed`<br/>
        /// events when the attempt was timed; null otherwise.
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
            string? reason,
            int? attempt,
            int? durationMs)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
            this.SourceRecordId = sourceRecordId ?? throw new global::System.ArgumentNullException(nameof(sourceRecordId));
            this.SessionKey = sessionKey;
            this.Skipped = skipped;
            this.Reason = reason;
            this.Attempt = attempt;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordProcessingEventVariant2" /> class.
        /// </summary>
        public RecordProcessingEventVariant2()
        {
        }

    }
}