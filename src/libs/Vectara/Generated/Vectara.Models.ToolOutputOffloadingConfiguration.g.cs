
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Controls how large tool outputs are kept from overwhelming the agent context window.<br/>
    /// Tool outputs are inspected as they are produced. A small output is always passed through<br/>
    /// unchanged. A larger output is handled in one of two cases: when the output on its own is<br/>
    /// big enough to dominate the context, or when adding it to the conversation would leave<br/>
    /// too little room for the agent to continue. In either case the output is handled according<br/>
    /// to `mode` — stored as an artifact and replaced with a compact reference, or truncated in<br/>
    /// place with the head and tail preserved and the middle omitted. When stored as an artifact,<br/>
    /// the agent is expected to have artifact_read, artifact_grep, or artifact_jq configured so<br/>
    /// it can retrieve the full content on demand.<br/>
    /// All fields are optional; omitted fields fall back to defaults.
    /// </summary>
    public sealed partial class ToolOutputOffloadingConfiguration
    {
        /// <summary>
        /// Whether tool output offloading is active. Defaults to true. When disabled, tool<br/>
        /// outputs are always passed through to the agent verbatim.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// How a large tool output is handled once it has been selected for offloading.<br/>
        /// In `artifact` mode, the full output is stored as a session artifact and replaced in<br/>
        /// the conversation with a compact reference containing the artifact id, size, shape,<br/>
        /// and hints for the available artifact tools. The agent can then use artifact_read,<br/>
        /// artifact_grep, or artifact_jq to retrieve just the parts it needs.<br/>
        /// In `truncate` mode, the output is shortened in place to fit within the target size.<br/>
        /// The head and tail are preserved and the middle is replaced with a short notice<br/>
        /// explaining that content was omitted. No artifact is created.<br/>
        /// When unset, the default is `artifact` if the agent has any of artifact_read,<br/>
        /// artifact_grep, or artifact_jq configured, and `truncate` otherwise.<br/>
        /// Example: artifact
        /// </summary>
        /// <example>artifact</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ToolOutputOffloadingConfigurationModeJsonConverter))]
        public global::Vectara.ToolOutputOffloadingConfigurationMode? Mode { get; set; }

        /// <summary>
        /// The fraction of the model's context window that a single tool output is allowed to<br/>
        /// occupy before it is considered large enough to offload on its own, estimated at four<br/>
        /// characters per token. The resulting byte threshold is clamped between<br/>
        /// `min_threshold_bytes` and `max_threshold_bytes`, so for very large context models<br/>
        /// this percentage is usually dominated by `max_threshold_bytes`, and for very small<br/>
        /// context models it is dominated by `min_threshold_bytes`.<br/>
        /// Default Value: 0.25<br/>
        /// Example: 0.25
        /// </summary>
        /// <example>0.25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_percentage")]
        public double? ContextPercentage { get; set; }

        /// <summary>
        /// An absolute ceiling on single-output size. Any output above this many bytes is<br/>
        /// considered large enough to offload on its own, regardless of the model's context<br/>
        /// window. This prevents unusually large outputs from slipping through on models with<br/>
        /// very large context windows.<br/>
        /// Example: 1048576
        /// </summary>
        /// <example>1048576</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_threshold_bytes")]
        public long? MaxThresholdBytes { get; set; }

        /// <summary>
        /// A hard floor on offloading. Tool outputs below this size are always passed through<br/>
        /// to the agent unchanged, even when cumulative context usage is high. This ensures that<br/>
        /// short, useful outputs are never unnecessarily truncated or replaced with a reference.<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_threshold_bytes")]
        public long? MinThresholdBytes { get; set; }

        /// <summary>
        /// The fraction of the model's context window at which offloading becomes sensitive to<br/>
        /// cumulative usage. When adding a tool output would push total input tokens above this<br/>
        /// fraction of the context window (estimated at four characters per token), the output<br/>
        /// is offloaded even if it would otherwise be considered small enough to pass through.<br/>
        /// This is independent of the compaction `threshold_percent`: both can be configured on<br/>
        /// the same agent and both can apply. In practice it is often useful to set this below<br/>
        /// the compaction threshold so that large tool outputs are offloaded before compaction<br/>
        /// is triggered, avoiding the case where a large tool result is immediately summarized<br/>
        /// away. Setting this to 1.0 effectively disables the headroom behavior, leaving only<br/>
        /// the per-output size thresholds in effect.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headroom_percentage")]
        public double? HeadroomPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputOffloadingConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether tool output offloading is active. Defaults to true. When disabled, tool<br/>
        /// outputs are always passed through to the agent verbatim.<br/>
        /// Example: true
        /// </param>
        /// <param name="mode">
        /// How a large tool output is handled once it has been selected for offloading.<br/>
        /// In `artifact` mode, the full output is stored as a session artifact and replaced in<br/>
        /// the conversation with a compact reference containing the artifact id, size, shape,<br/>
        /// and hints for the available artifact tools. The agent can then use artifact_read,<br/>
        /// artifact_grep, or artifact_jq to retrieve just the parts it needs.<br/>
        /// In `truncate` mode, the output is shortened in place to fit within the target size.<br/>
        /// The head and tail are preserved and the middle is replaced with a short notice<br/>
        /// explaining that content was omitted. No artifact is created.<br/>
        /// When unset, the default is `artifact` if the agent has any of artifact_read,<br/>
        /// artifact_grep, or artifact_jq configured, and `truncate` otherwise.<br/>
        /// Example: artifact
        /// </param>
        /// <param name="contextPercentage">
        /// The fraction of the model's context window that a single tool output is allowed to<br/>
        /// occupy before it is considered large enough to offload on its own, estimated at four<br/>
        /// characters per token. The resulting byte threshold is clamped between<br/>
        /// `min_threshold_bytes` and `max_threshold_bytes`, so for very large context models<br/>
        /// this percentage is usually dominated by `max_threshold_bytes`, and for very small<br/>
        /// context models it is dominated by `min_threshold_bytes`.<br/>
        /// Default Value: 0.25<br/>
        /// Example: 0.25
        /// </param>
        /// <param name="maxThresholdBytes">
        /// An absolute ceiling on single-output size. Any output above this many bytes is<br/>
        /// considered large enough to offload on its own, regardless of the model's context<br/>
        /// window. This prevents unusually large outputs from slipping through on models with<br/>
        /// very large context windows.<br/>
        /// Example: 1048576
        /// </param>
        /// <param name="minThresholdBytes">
        /// A hard floor on offloading. Tool outputs below this size are always passed through<br/>
        /// to the agent unchanged, even when cumulative context usage is high. This ensures that<br/>
        /// short, useful outputs are never unnecessarily truncated or replaced with a reference.<br/>
        /// Example: 4096
        /// </param>
        /// <param name="headroomPercentage">
        /// The fraction of the model's context window at which offloading becomes sensitive to<br/>
        /// cumulative usage. When adding a tool output would push total input tokens above this<br/>
        /// fraction of the context window (estimated at four characters per token), the output<br/>
        /// is offloaded even if it would otherwise be considered small enough to pass through.<br/>
        /// This is independent of the compaction `threshold_percent`: both can be configured on<br/>
        /// the same agent and both can apply. In practice it is often useful to set this below<br/>
        /// the compaction threshold so that large tool outputs are offloaded before compaction<br/>
        /// is triggered, avoiding the case where a large tool result is immediately summarized<br/>
        /// away. Setting this to 1.0 effectively disables the headroom behavior, leaving only<br/>
        /// the per-output size thresholds in effect.<br/>
        /// Default Value: 0.7<br/>
        /// Example: 0.7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolOutputOffloadingConfiguration(
            bool? enabled,
            global::Vectara.ToolOutputOffloadingConfigurationMode? mode,
            double? contextPercentage,
            long? maxThresholdBytes,
            long? minThresholdBytes,
            double? headroomPercentage)
        {
            this.Enabled = enabled;
            this.Mode = mode;
            this.ContextPercentage = contextPercentage;
            this.MaxThresholdBytes = maxThresholdBytes;
            this.MinThresholdBytes = minThresholdBytes;
            this.HeadroomPercentage = headroomPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputOffloadingConfiguration" /> class.
        /// </summary>
        public ToolOutputOffloadingConfiguration()
        {
        }
    }
}