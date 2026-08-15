
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunCompletedEventVariant2
    {
        /// <summary>
        /// Default Value: run_completed
        /// </summary>
        /// <default>"run_completed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "run_completed";

        /// <summary>
        /// Terminal status of a pipeline run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RunCompletedEventStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RunCompletedEventStatus Status { get; set; }

        /// <summary>
        /// Total records fetched across the run. Present when the run reported counters. Absent or partial for cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_fetched")]
        public int? RecordsFetched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_processed")]
        public int? RecordsProcessed { get; set; }

        /// <summary>
        /// Records the run neither processed nor failed, because a `run_condition` on the agent or on the judge agent evaluated to false. Disjoint from `records_processed` and `records_failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_skipped")]
        public int? RecordsSkipped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_failed")]
        public int? RecordsFailed { get; set; }

        /// <summary>
        /// Failure message. Present when `status` is not `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCompletedEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: run_completed
        /// </param>
        /// <param name="status">
        /// Terminal status of a pipeline run.
        /// </param>
        /// <param name="recordsFetched">
        /// Total records fetched across the run. Present when the run reported counters. Absent or partial for cancellation.
        /// </param>
        /// <param name="recordsProcessed"></param>
        /// <param name="recordsSkipped">
        /// Records the run neither processed nor failed, because a `run_condition` on the agent or on the judge agent evaluated to false. Disjoint from `records_processed` and `records_failed`.
        /// </param>
        /// <param name="recordsFailed"></param>
        /// <param name="error">
        /// Failure message. Present when `status` is not `completed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunCompletedEventVariant2(
            string type,
            global::Vectara.RunCompletedEventStatus status,
            int? recordsFetched,
            int? recordsProcessed,
            int? recordsSkipped,
            int? recordsFailed,
            string? error)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
            this.RecordsFetched = recordsFetched;
            this.RecordsProcessed = recordsProcessed;
            this.RecordsSkipped = recordsSkipped;
            this.RecordsFailed = recordsFailed;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCompletedEventVariant2" /> class.
        /// </summary>
        public RunCompletedEventVariant2()
        {
        }

    }
}