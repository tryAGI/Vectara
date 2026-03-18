
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A pipeline is an automated data flow that sends all data from a source system to an agent<br/>
    /// for the agent to act on per its instructions. A new agent session is created for each source<br/>
    /// record, giving the agent full autonomy to decide what to do with each piece of data — index it<br/>
    /// into a corpus, extract structured information, route it, or discard it.<br/>
    /// This is distinct from an **agent schedule**, which is a recurring single execution of an<br/>
    /// agent with a fixed message. A schedule creates one session per trigger; a pipeline creates<br/>
    /// a session per source record.<br/>
    /// This is also distinct from an **agent connector** (e.g. Slack), which is a bidirectional<br/>
    /// integration for interactive chat with an agent. A pipeline is a one-directional automated<br/>
    /// flow of all data through an agent.
    /// </summary>
    public sealed partial class Pipeline
    {
        /// <summary>
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </summary>
        /// <example>sharepoint-legal-ingest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </summary>
        /// <example>SharePoint Legal Docs Ingest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what this pipeline does.<br/>
        /// Example: Ingests legal contracts from SharePoint and indexes them into the legal corpus.
        /// </summary>
        /// <example>Ingests legal contracts from SharePoint and indexes them into the legal corpus.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The source system to ingest data from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineSource Source { get; set; }

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
        /// <default>global::Vectara.PipelineSyncMode.Incremental</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineSyncModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineSyncMode SyncMode { get; set; } = global::Vectara.PipelineSyncMode.Incremental;

        /// <summary>
        /// The current incremental sync watermark. Null if the pipeline has never run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public global::Vectara.PipelineWatermark? Watermark { get; set; }

        /// <summary>
        /// The current operational status of the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.PipelineStatus Status { get; set; }

        /// <summary>
        /// Human-readable status details, such as an error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Whether the pipeline is enabled. Disabled pipelines do not run on their trigger schedule.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata for the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// When the pipeline was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the pipeline was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        /// <param name="key">
        /// The unique key for the pipeline. Can be user-provided or auto-generated.<br/>
        /// Example: sharepoint-legal-ingest
        /// </param>
        /// <param name="name">
        /// The human-readable name of the pipeline.<br/>
        /// Example: SharePoint Legal Docs Ingest
        /// </param>
        /// <param name="description">
        /// A description of what this pipeline does.<br/>
        /// Example: Ingests legal contracts from SharePoint and indexes them into the legal corpus.
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
        /// <param name="syncMode">
        /// How the pipeline syncs data from the source.<br/>
        /// - `incremental`: Only process new or changed records since the last watermark.<br/>
        /// - `full_refresh`: Process all records from the source on each run.<br/>
        /// Default Value: incremental
        /// </param>
        /// <param name="watermark">
        /// The current incremental sync watermark. Null if the pipeline has never run.
        /// </param>
        /// <param name="status">
        /// The current operational status of the pipeline.
        /// </param>
        /// <param name="statusMessage">
        /// Human-readable status details, such as an error description.
        /// </param>
        /// <param name="enabled">
        /// Whether the pipeline is enabled. Disabled pipelines do not run on their trigger schedule.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata for the pipeline.
        /// </param>
        /// <param name="createdAt">
        /// When the pipeline was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the pipeline was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pipeline(
            string key,
            string name,
            global::Vectara.PipelineSource source,
            global::Vectara.PipelineTrigger trigger,
            global::Vectara.PipelineTransform transform,
            global::Vectara.PipelineSyncMode syncMode,
            global::Vectara.PipelineStatus status,
            bool enabled,
            global::System.DateTime createdAt,
            string? description,
            global::Vectara.PipelineWatermark? watermark,
            string? statusMessage,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? updatedAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.Trigger = trigger;
            this.Transform = transform ?? throw new global::System.ArgumentNullException(nameof(transform));
            this.SyncMode = syncMode;
            this.Status = status;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Watermark = watermark;
            this.StatusMessage = statusMessage;
            this.Metadata = metadata;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline" /> class.
        /// </summary>
        public Pipeline()
        {
        }
    }
}