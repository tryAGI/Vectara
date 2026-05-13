
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
        /// Total records fetched across the run. Present when the run reported counters; absent for cancellation or timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_fetched")]
        public int? RecordsFetched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_processed")]
        public int? RecordsProcessed { get; set; }

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
        /// Total records fetched across the run. Present when the run reported counters; absent for cancellation or timeout.
        /// </param>
        /// <param name="recordsProcessed"></param>
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
            int? recordsFailed,
            string? error)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
            this.RecordsFetched = recordsFetched;
            this.RecordsProcessed = recordsProcessed;
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