
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to partially update an existing pipeline. Omitted fields are preserved.
    /// </summary>
    public sealed partial class UpdatePipelineRequest
    {
        /// <summary>
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </summary>
        /// <example>SharePoint Legal Docs Ingest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The source system to ingest data from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineSourceJsonConverter))]
        public global::Vectara.PipelineSource? Source { get; set; }

        /// <summary>
        /// Defines when the pipeline runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineTriggerJsonConverter))]
        public global::Vectara.PipelineTrigger? Trigger { get; set; }

        /// <summary>
        /// Defines how source data is processed. Currently only agent transforms are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        public global::Vectara.PipelineTransform? Transform { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePipelineRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </param>
        /// <param name="description"></param>
        /// <param name="source">
        /// The source system to ingest data from.
        /// </param>
        /// <param name="trigger">
        /// Defines when the pipeline runs.
        /// </param>
        /// <param name="transform">
        /// Defines how source data is processed. Currently only agent transforms are supported.
        /// </param>
        /// <param name="syncMode">
        /// How the pipeline syncs data from the source.<br/>
        /// - `incremental`: Only process new or changed records since the last watermark.<br/>
        /// - `full_refresh`: Process all records from the source on each run.<br/>
        /// Default Value: incremental
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePipelineRequest(
            string? name,
            string? description,
            global::Vectara.PipelineSource? source,
            global::Vectara.PipelineTrigger? trigger,
            global::Vectara.PipelineTransform? transform,
            global::Vectara.PipelineSyncMode? syncMode,
            bool? enabled,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Source = source;
            this.Trigger = trigger;
            this.Transform = transform;
            this.SyncMode = syncMode;
            this.Enabled = enabled;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePipelineRequest" /> class.
        /// </summary>
        public UpdatePipelineRequest()
        {
        }
    }
}