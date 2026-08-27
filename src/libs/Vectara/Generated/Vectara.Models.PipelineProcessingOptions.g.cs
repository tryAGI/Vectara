
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Per-pipeline processing options. Each field overrides the service default for this pipeline<br/>
    /// only. A field that is null or omitted keeps the service default. In an update, a provided<br/>
    /// object replaces the stored options wholesale; it is not merged field-by-field. Send an<br/>
    /// empty object to return to the service defaults.
    /// </summary>
    public sealed partial class PipelineProcessingOptions
    {
        /// <summary>
        /// Maximum time in minutes for a single processing attempt of one record, including the agent session work. Overrides the service default of 30 minutes. The record's total budget across all retry attempts is twice this value.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_timeout_minutes")]
        public int? RecordTimeoutMinutes { get; set; }

        /// <summary>
        /// Maximum number of this pipeline's records processed in parallel within a run. Values above the service's parallelism limit are reduced to that limit.<br/>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_records")]
        public int? MaxConcurrentRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineProcessingOptions" /> class.
        /// </summary>
        /// <param name="recordTimeoutMinutes">
        /// Maximum time in minutes for a single processing attempt of one record, including the agent session work. Overrides the service default of 30 minutes. The record's total budget across all retry attempts is twice this value.<br/>
        /// Example: 60
        /// </param>
        /// <param name="maxConcurrentRecords">
        /// Maximum number of this pipeline's records processed in parallel within a run. Values above the service's parallelism limit are reduced to that limit.<br/>
        /// Example: 6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineProcessingOptions(
            int? recordTimeoutMinutes,
            int? maxConcurrentRecords)
        {
            this.RecordTimeoutMinutes = recordTimeoutMinutes;
            this.MaxConcurrentRecords = maxConcurrentRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineProcessingOptions" /> class.
        /// </summary>
        public PipelineProcessingOptions()
        {
        }

    }
}