
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new pipeline.
    /// </summary>
    public sealed partial class CreatePipelineRequest
    {
        /// <summary>
        /// A user-provided key for the pipeline. If omitted, one is auto-generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </summary>
        /// <example>SharePoint Legal Docs Ingest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The source system to ingest data from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.S3SourceConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.S3SourceConfiguration Source { get; set; }

        /// <summary>
        /// Defines when the pipeline runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineTriggerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineTrigger Trigger { get; set; }

        /// <summary>
        /// Defines how source data is processed. Currently only agent transforms are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineTransform Transform { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipelineRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </param>
        /// <param name="source">
        /// The source system to ingest data from.
        /// </param>
        /// <param name="trigger">
        /// Defines when the pipeline runs.
        /// </param>
        /// <param name="transform">
        /// Defines how source data is processed. Currently only agent transforms are supported.
        /// </param>
        /// <param name="key">
        /// A user-provided key for the pipeline. If omitted, one is auto-generated.
        /// </param>
        /// <param name="description"></param>
        /// <param name="syncMode">
        /// How the pipeline syncs data from the source.<br/>
        /// - `incremental`: Only process new or changed records since the last watermark.<br/>
        /// - `full_refresh`: Process all records from the source on each run.<br/>
        /// Default Value: incremental
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePipelineRequest(
            string name,
            global::Vectara.S3SourceConfiguration source,
            global::Vectara.PipelineTrigger trigger,
            global::Vectara.PipelineTransform transform,
            string? key,
            string? description,
            global::Vectara.PipelineSyncMode? syncMode,
            bool? enabled,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Key = key;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Source = source;
            this.Trigger = trigger;
            this.Transform = transform ?? throw new global::System.ArgumentNullException(nameof(transform));
            this.SyncMode = syncMode;
            this.Enabled = enabled;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipelineRequest" /> class.
        /// </summary>
        public CreatePipelineRequest()
        {
        }
    }
}