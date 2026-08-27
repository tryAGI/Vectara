
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to partially update an existing pipeline. Omitted fields keep their current values.
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
        /// Source configuration for partial updates. Only provided fields are changed. Credentials are optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.UpdatePipelineSourceJsonConverter))]
        public global::Vectara.UpdatePipelineSource? Source { get; set; }

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
        /// Per-pipeline processing options. Each field overrides the service default for this pipeline<br/>
        /// only. A field that is null or omitted keeps the service default. In an update, a provided<br/>
        /// object replaces the stored options wholesale; it is not merged field-by-field. Send an<br/>
        /// empty object to return to the service defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_options")]
        public global::Vectara.PipelineProcessingOptions? ProcessingOptions { get; set; }

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
        /// Source configuration for partial updates. Only provided fields are changed. Credentials are optional.
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
        /// <param name="processingOptions">
        /// Per-pipeline processing options. Each field overrides the service default for this pipeline<br/>
        /// only. A field that is null or omitted keeps the service default. In an update, a provided<br/>
        /// object replaces the stored options wholesale; it is not merged field-by-field. Send an<br/>
        /// empty object to return to the service defaults.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePipelineRequest(
            string? name,
            string? description,
            global::Vectara.UpdatePipelineSource? source,
            global::Vectara.PipelineTrigger? trigger,
            global::Vectara.PipelineTransform? transform,
            global::Vectara.PipelineSyncMode? syncMode,
            global::Vectara.PipelineProcessingOptions? processingOptions,
            bool? enabled,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Source = source;
            this.Trigger = trigger;
            this.Transform = transform;
            this.SyncMode = syncMode;
            this.ProcessingOptions = processingOptions;
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