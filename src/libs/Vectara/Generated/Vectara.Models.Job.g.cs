
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A background job for processing long-running operations on the platform.
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// The ID of the job.<br/>
        /// Example: job_1234
        /// </summary>
        /// <example>job_1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.JobTypeJsonConverter))]
        public global::Vectara.JobType? Type { get; set; }

        /// <summary>
        /// The corpora that this job belongs to. Some jobs do not belong to any corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_keys")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

        /// <summary>
        /// The state of a background job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.JobStateJsonConverter))]
        public global::Vectara.JobState? State { get; set; }

        /// <summary>
        /// When the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the job was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the job was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The username of the user who created the job. This property can be absent, for example when the platform created the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_username")]
        public string? CreatedByUsername { get; set; }

        /// <summary>
        /// A human-readable explanation of the job's current status. The format and content depend on the job type. On failure, this property contains the error message. This property can be absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Live progress of a running job.<br/>
        /// Present only while the job is running, and only when retrieving a single job by ID; `listJobs` never populates it. Absence does not indicate failure — read `state` for job health. The counters describe the corpus rebuild the job runs, so a job that drives no rebuild reports nothing here.<br/>
        /// `pages_pending_import`, `imports_in_flight` and `import_batches_submitted` describe incremental import, which is not enabled for every rebuild. When it is not in use all three report 0 for the whole rebuild, which means "not applicable" rather than "nothing left to do".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Vectara.JobProgress? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job.<br/>
        /// Example: job_1234
        /// </param>
        /// <param name="type">
        /// The type of job.
        /// </param>
        /// <param name="corpusKeys">
        /// The corpora that this job belongs to. Some jobs do not belong to any corpus.
        /// </param>
        /// <param name="state">
        /// The state of a background job.
        /// </param>
        /// <param name="createdAt">
        /// When the job was created.
        /// </param>
        /// <param name="startedAt">
        /// When the job was started.
        /// </param>
        /// <param name="completedAt">
        /// When the job was completed.
        /// </param>
        /// <param name="createdByUsername">
        /// The username of the user who created the job. This property can be absent, for example when the platform created the job.
        /// </param>
        /// <param name="comment">
        /// A human-readable explanation of the job's current status. The format and content depend on the job type. On failure, this property contains the error message. This property can be absent.
        /// </param>
        /// <param name="progress">
        /// Live progress of a running job.<br/>
        /// Present only while the job is running, and only when retrieving a single job by ID; `listJobs` never populates it. Absence does not indicate failure — read `state` for job health. The counters describe the corpus rebuild the job runs, so a job that drives no rebuild reports nothing here.<br/>
        /// `pages_pending_import`, `imports_in_flight` and `import_batches_submitted` describe incremental import, which is not enabled for every rebuild. When it is not in use all three report 0 for the whole rebuild, which means "not applicable" rather than "nothing left to do".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            string id,
            global::Vectara.JobType? type,
            global::System.Collections.Generic.IList<string>? corpusKeys,
            global::Vectara.JobState? state,
            global::System.DateTime? createdAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            string? createdByUsername,
            string? comment,
            global::Vectara.JobProgress? progress)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.CorpusKeys = corpusKeys;
            this.State = state;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.CreatedByUsername = createdByUsername;
            this.Comment = comment;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }

    }
}