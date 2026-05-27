
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common metadata fields shared by every metric descriptor regardless of kind.
    /// </summary>
    public sealed partial class MetricDescriptorBase
    {
        /// <summary>
        /// The unique name of the metric, used as the path parameter to query it.<br/>
        /// Example: agent.trace.duration_ms
        /// </summary>
        /// <example>agent.trace.duration_ms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Top-level grouping for this metric.<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Human-readable description of what the metric measures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Unit of measure for the metric values, when applicable.<br/>
        /// Example: ms
        /// </summary>
        /// <example>ms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Short human-readable name for this metric, suitable as a chart title or list<br/>
        /// label.<br/>
        /// Example: Trace duration percentiles
        /// </summary>
        /// <example>Trace duration percentiles</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Names of labels that can be used to filter this metric.<br/>
        /// Example: [agent_keys]
        /// </summary>
        /// <example>[agent_keys]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDescriptorBase" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique name of the metric, used as the path parameter to query it.<br/>
        /// Example: agent.trace.duration_ms
        /// </param>
        /// <param name="category">
        /// Top-level grouping for this metric.<br/>
        /// Example: agent
        /// </param>
        /// <param name="description">
        /// Human-readable description of what the metric measures.
        /// </param>
        /// <param name="displayName">
        /// Short human-readable name for this metric, suitable as a chart title or list<br/>
        /// label.<br/>
        /// Example: Trace duration percentiles
        /// </param>
        /// <param name="labels">
        /// Names of labels that can be used to filter this metric.<br/>
        /// Example: [agent_keys]
        /// </param>
        /// <param name="unit">
        /// Unit of measure for the metric values, when applicable.<br/>
        /// Example: ms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricDescriptorBase(
            string name,
            string category,
            string description,
            string displayName,
            global::System.Collections.Generic.IList<string> labels,
            string? unit)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Unit = unit;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDescriptorBase" /> class.
        /// </summary>
        public MetricDescriptorBase()
        {
        }

    }
}