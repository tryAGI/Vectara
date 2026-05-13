
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStartedEventVariant2
    {
        /// <summary>
        /// Default Value: run_started
        /// </summary>
        /// <default>"run_started"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "run_started";

        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        public string? AgentKey { get; set; }

        /// <summary>
        /// What initiated the pipeline run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineRunTriggerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineRunTriggerType TriggerType { get; set; }

        /// <summary>
        /// How the pipeline syncs data from the source.<br/>
        /// - `incremental`: Only process new or changed records since the last watermark.<br/>
        /// - `full_refresh`: Process all records from the source on each run.<br/>
        /// Default Value: incremental
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineSyncModeJsonConverter))]
        public global::Vectara.PipelineSyncMode? SyncMode { get; set; }

        /// <summary>
        /// Source watermark this run starts from. Null on full refresh or first run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_watermark")]
        public string? StartWatermark { get; set; }

        /// <summary>
        /// Upper bound watermark this run will not cross.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_watermark")]
        public string? EndWatermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStartedEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: run_started
        /// </param>
        /// <param name="triggerType">
        /// What initiated the pipeline run.
        /// </param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="syncMode">
        /// How the pipeline syncs data from the source.<br/>
        /// - `incremental`: Only process new or changed records since the last watermark.<br/>
        /// - `full_refresh`: Process all records from the source on each run.<br/>
        /// Default Value: incremental
        /// </param>
        /// <param name="startWatermark">
        /// Source watermark this run starts from. Null on full refresh or first run.
        /// </param>
        /// <param name="endWatermark">
        /// Upper bound watermark this run will not cross.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStartedEventVariant2(
            string type,
            global::Vectara.PipelineRunTriggerType triggerType,
            string? agentKey,
            global::Vectara.PipelineSyncMode? syncMode,
            string? startWatermark,
            string? endWatermark)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AgentKey = agentKey;
            this.TriggerType = triggerType;
            this.SyncMode = syncMode;
            this.StartWatermark = startWatermark;
            this.EndWatermark = endWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStartedEventVariant2" /> class.
        /// </summary>
        public RunStartedEventVariant2()
        {
        }

    }
}