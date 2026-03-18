
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single execution of a pipeline. Each run fetches data from the source and creates one<br/>
    /// agent session per record. Each record is mapped 1:1 to a session.
    /// </summary>
    public sealed partial class PipelineRun
    {
        /// <summary>
        /// The unique identifier for a pipeline run.<br/>
        /// Example: run_20260219_001
        /// </summary>
        /// <example>run_20260219_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </summary>
        /// <example>sharepoint-legal-ingest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineKey { get; set; }

        /// <summary>
        /// The status of a pipeline run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineRunStatus Status { get; set; }

        /// <summary>
        /// What initiated the pipeline run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineRunTriggerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineRunTriggerType TriggerType { get; set; }

        /// <summary>
        /// Number of records discovered from the source in this run.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_fetched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecordsFetched { get; set; }

        /// <summary>
        /// Number of records successfully processed by the agent.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecordsProcessed { get; set; }

        /// <summary>
        /// Number of records that failed processing.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecordsFailed { get; set; }

        /// <summary>
        /// The agent sessions created during this run, one per source record processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SessionKeys { get; set; }

        /// <summary>
        /// Error details if the run failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// When the run started executing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the run finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// When the run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for a pipeline run.<br/>
        /// Example: run_20260219_001
        /// </param>
        /// <param name="pipelineKey">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="status">
        /// The status of a pipeline run.
        /// </param>
        /// <param name="triggerType">
        /// What initiated the pipeline run.
        /// </param>
        /// <param name="recordsFetched">
        /// Number of records discovered from the source in this run.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="recordsProcessed">
        /// Number of records successfully processed by the agent.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="recordsFailed">
        /// Number of records that failed processing.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="sessionKeys">
        /// The agent sessions created during this run, one per source record processed.
        /// </param>
        /// <param name="error">
        /// Error details if the run failed.
        /// </param>
        /// <param name="startedAt">
        /// When the run started executing.
        /// </param>
        /// <param name="completedAt">
        /// When the run finished.
        /// </param>
        /// <param name="createdAt">
        /// When the run was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineRun(
            string id,
            string pipelineKey,
            global::Vectara.PipelineRunStatus status,
            global::Vectara.PipelineRunTriggerType triggerType,
            int recordsFetched,
            int recordsProcessed,
            int recordsFailed,
            global::System.Collections.Generic.IList<string> sessionKeys,
            global::System.DateTime createdAt,
            string? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PipelineKey = pipelineKey ?? throw new global::System.ArgumentNullException(nameof(pipelineKey));
            this.Status = status;
            this.TriggerType = triggerType;
            this.RecordsFetched = recordsFetched;
            this.RecordsProcessed = recordsProcessed;
            this.RecordsFailed = recordsFailed;
            this.SessionKeys = sessionKeys ?? throw new global::System.ArgumentNullException(nameof(sessionKeys));
            this.CreatedAt = createdAt;
            this.Error = error;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun" /> class.
        /// </summary>
        public PipelineRun()
        {
        }
    }
}