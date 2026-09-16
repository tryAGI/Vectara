
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common metadata fields shared by every metric descriptor regardless of type.
    /// </summary>
    public sealed partial class MetricDescriptorBase
    {
        /// <summary>
        /// The unique name of the metric, used as the path parameter to query it. Custom metric names start with `custom.`.<br/>
        /// Example: agent.trace.duration_ms
        /// </summary>
        /// <example>agent.trace.duration_ms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The top-level grouping for this metric.<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// A human-readable description of what the metric measures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The unit of measure for the metric values, when applicable.<br/>
        /// Example: ms
        /// </summary>
        /// <example>ms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// A short human-readable name for this metric, suitable as a chart title or list<br/>
        /// label.<br/>
        /// Example: Agent turn duration percentiles
        /// </summary>
        /// <example>Agent turn duration percentiles</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The names of the dimensions this metric is broken down by. Filter on them with the `dimensions` query parameter when querying the metric. On a custom metric these are the dimension names declared in its definition.<br/>
        /// Example: [agent_keys]
        /// </summary>
        /// <example>[agent_keys]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// Deprecated alias for `dimensions`; identical value. Use `dimensions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Who provides the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.MetricOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.MetricOrigin Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDescriptorBase" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique name of the metric, used as the path parameter to query it. Custom metric names start with `custom.`.<br/>
        /// Example: agent.trace.duration_ms
        /// </param>
        /// <param name="category">
        /// The top-level grouping for this metric.<br/>
        /// Example: agent
        /// </param>
        /// <param name="description">
        /// A human-readable description of what the metric measures.
        /// </param>
        /// <param name="displayName">
        /// A short human-readable name for this metric, suitable as a chart title or list<br/>
        /// label.<br/>
        /// Example: Agent turn duration percentiles
        /// </param>
        /// <param name="dimensions">
        /// The names of the dimensions this metric is broken down by. Filter on them with the `dimensions` query parameter when querying the metric. On a custom metric these are the dimension names declared in its definition.<br/>
        /// Example: [agent_keys]
        /// </param>
        /// <param name="labels">
        /// Deprecated alias for `dimensions`; identical value. Use `dimensions`.
        /// </param>
        /// <param name="origin">
        /// Who provides the metric.
        /// </param>
        /// <param name="unit">
        /// The unit of measure for the metric values, when applicable.<br/>
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
            global::System.Collections.Generic.IList<string> dimensions,
            global::System.Collections.Generic.IList<string> labels,
            global::Vectara.MetricOrigin origin,
            string? unit)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Unit = unit;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDescriptorBase" /> class.
        /// </summary>
        public MetricDescriptorBase()
        {
        }

    }
}