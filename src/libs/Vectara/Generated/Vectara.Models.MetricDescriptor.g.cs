
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Metadata about a registered metric available for querying.
    /// </summary>
    public sealed partial class MetricDescriptor
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
        /// The kind of metric. Determines combine semantics when filtering across multiple label values and the shape of points in the response:<br/>
        /// - `counter`: monotonic count or sum (trace count, error count, token totals). Combined by summing. Returns `ScalarMetricPoint`s.<br/>
        /// - `gauge`: point-in-time value (mean, max, distinct-count). Combined per the underlying aggregate state (weighted mean for averages, max for maxima, distinct-count for uniq metrics). Returns `ScalarMetricPoint`s.<br/>
        /// - `percentiles`: distribution percentiles over a t-digest aggregate. Combined by merging t-digest states. Returns `PercentilesMetricPoint`s.<br/>
        /// - `distribution`: histogram of value-bucketed counts. Combined by summing per-bin counts. Returns `DistributionMetricPoint`s.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.MetricKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.MetricKind Kind { get; set; }

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
        /// Initializes a new instance of the <see cref="MetricDescriptor" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique name of the metric, used as the path parameter to query it.<br/>
        /// Example: agent.trace.duration_ms
        /// </param>
        /// <param name="description">
        /// Human-readable description of what the metric measures.
        /// </param>
        /// <param name="kind">
        /// The kind of metric. Determines combine semantics when filtering across multiple label values and the shape of points in the response:<br/>
        /// - `counter`: monotonic count or sum (trace count, error count, token totals). Combined by summing. Returns `ScalarMetricPoint`s.<br/>
        /// - `gauge`: point-in-time value (mean, max, distinct-count). Combined per the underlying aggregate state (weighted mean for averages, max for maxima, distinct-count for uniq metrics). Returns `ScalarMetricPoint`s.<br/>
        /// - `percentiles`: distribution percentiles over a t-digest aggregate. Combined by merging t-digest states. Returns `PercentilesMetricPoint`s.<br/>
        /// - `distribution`: histogram of value-bucketed counts. Combined by summing per-bin counts. Returns `DistributionMetricPoint`s.
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
        public MetricDescriptor(
            string name,
            string description,
            global::Vectara.MetricKind kind,
            global::System.Collections.Generic.IList<string> labels,
            string? unit)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Unit = unit;
            this.Kind = kind;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDescriptor" /> class.
        /// </summary>
        public MetricDescriptor()
        {
        }

    }
}