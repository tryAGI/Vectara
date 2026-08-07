
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Live progress of a running job.<br/>
    /// Present only while the job is running, and only when retrieving a single job by ID; `listJobs` never populates it. Absence does not indicate failure — read `state` for job health. The counters describe the corpus rebuild the job runs, so a job that drives no rebuild reports nothing here.<br/>
    /// `pages_pending_import`, `imports_in_flight` and `import_batches_submitted` describe incremental import, which is not enabled for every rebuild. When it is not in use all three report 0 for the whole rebuild, which means "not applicable" rather than "nothing left to do".
    /// </summary>
    public sealed partial class JobProgress
    {
        /// <summary>
        /// The stage of the rebuild that is currently running. A rebuild scans the corpus and imports it into the new indices, then cuts the corpus over to them and replays everything written while it ran. New phases may be added; treat unrecognized values as opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.JobProgressPhaseJsonConverter))]
        public global::Vectara.JobProgressPhase? Phase { get; set; }

        /// <summary>
        /// The number of documents the rebuild has processed out of the corpus so far, counting towards `documents_expected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents_indexed")]
        public long? DocumentsIndexed { get; set; }

        /// <summary>
        /// The number of documents the corpus held when the rebuild started, and the total that `documents_indexed` runs towards. Absent when the corpus size could not be determined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents_expected")]
        public long? DocumentsExpected { get; set; }

        /// <summary>
        /// The number of shards the corpus is being scanned in, all read concurrently.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_shards")]
        public int? ScanShards { get; set; }

        /// <summary>
        /// How many of the corpus's scan shards have been read to the end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_shards_finished")]
        public int? ScanShardsFinished { get; set; }

        /// <summary>
        /// Staged scan batches waiting to be imported. Bounded by the rebuild's own backpressure, so this does not grow with the size of the corpus. Reports 0 when incremental import is not in use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_pending_import")]
        public int? PagesPendingImport { get; set; }

        /// <summary>
        /// Import batches handed to the vector store over the rebuild's lifetime. It only ever climbs. Reports 0 when incremental import is not in use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_batches_submitted")]
        public int? ImportBatchesSubmitted { get; set; }

        /// <summary>
        /// Import batches submitted to the vector store and still being waited on. Reports 0 when incremental import is not in use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imports_in_flight")]
        public int? ImportsInFlight { get; set; }

        /// <summary>
        /// How many times the rebuild has had to discard and replay a failed import. A nonzero value means imports are being retried, not that the rebuild has failed. Unlike `import_batches_submitted`, this counts only the rebuild's current stretch of work and restarts at 0 if the rebuild continues past an internal checkpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_recovery_attempts")]
        public int? ImportRecoveryAttempts { get; set; }

        /// <summary>
        /// When the rebuild these counters describe began, and the instant they are all measured from. It is reported by the rebuild itself, so it is present whenever this object is and does not move for the rebuild's lifetime, whereas `Job.started_at` is recorded on the job and may be absent or differ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobProgress" /> class.
        /// </summary>
        /// <param name="phase">
        /// The stage of the rebuild that is currently running. A rebuild scans the corpus and imports it into the new indices, then cuts the corpus over to them and replays everything written while it ran. New phases may be added; treat unrecognized values as opaque.
        /// </param>
        /// <param name="documentsIndexed">
        /// The number of documents the rebuild has processed out of the corpus so far, counting towards `documents_expected`.
        /// </param>
        /// <param name="documentsExpected">
        /// The number of documents the corpus held when the rebuild started, and the total that `documents_indexed` runs towards. Absent when the corpus size could not be determined.
        /// </param>
        /// <param name="scanShards">
        /// The number of shards the corpus is being scanned in, all read concurrently.
        /// </param>
        /// <param name="scanShardsFinished">
        /// How many of the corpus's scan shards have been read to the end.
        /// </param>
        /// <param name="pagesPendingImport">
        /// Staged scan batches waiting to be imported. Bounded by the rebuild's own backpressure, so this does not grow with the size of the corpus. Reports 0 when incremental import is not in use.
        /// </param>
        /// <param name="importBatchesSubmitted">
        /// Import batches handed to the vector store over the rebuild's lifetime. It only ever climbs. Reports 0 when incremental import is not in use.
        /// </param>
        /// <param name="importsInFlight">
        /// Import batches submitted to the vector store and still being waited on. Reports 0 when incremental import is not in use.
        /// </param>
        /// <param name="importRecoveryAttempts">
        /// How many times the rebuild has had to discard and replay a failed import. A nonzero value means imports are being retried, not that the rebuild has failed. Unlike `import_batches_submitted`, this counts only the rebuild's current stretch of work and restarts at 0 if the rebuild continues past an internal checkpoint.
        /// </param>
        /// <param name="startedAt">
        /// When the rebuild these counters describe began, and the instant they are all measured from. It is reported by the rebuild itself, so it is present whenever this object is and does not move for the rebuild's lifetime, whereas `Job.started_at` is recorded on the job and may be absent or differ.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobProgress(
            global::Vectara.JobProgressPhase? phase,
            long? documentsIndexed,
            long? documentsExpected,
            int? scanShards,
            int? scanShardsFinished,
            int? pagesPendingImport,
            int? importBatchesSubmitted,
            int? importsInFlight,
            int? importRecoveryAttempts,
            global::System.DateTime? startedAt)
        {
            this.Phase = phase;
            this.DocumentsIndexed = documentsIndexed;
            this.DocumentsExpected = documentsExpected;
            this.ScanShards = scanShards;
            this.ScanShardsFinished = scanShardsFinished;
            this.PagesPendingImport = pagesPendingImport;
            this.ImportBatchesSubmitted = importBatchesSubmitted;
            this.ImportsInFlight = importsInFlight;
            this.ImportRecoveryAttempts = importRecoveryAttempts;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobProgress" /> class.
        /// </summary>
        public JobProgress()
        {
        }

    }
}