
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PercentilesMetricDescriptorVariant2
    {
        /// <summary>
        /// Example: percentiles
        /// </summary>
        /// <example>percentiles</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Percentile entries returned by this metric, in canonical order. Each entry's `label` matches a corresponding entry in every response point's `percentiles` array; `value` is the percentile rank (e.g. `0.5` for p50).<br/>
        /// Example: [{"label":"p50","value":0.5}, {"label":"p90","value":0.9}, {"label":"p95","value":0.95}, {"label":"p99","value":0.99}]
        /// </summary>
        /// <example>[{"label":"p50","value":0.5}, {"label":"p90","value":0.9}, {"label":"p95","value":0.95}, {"label":"p99","value":0.99}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.PercentileEntry> Percentiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentilesMetricDescriptorVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: percentiles
        /// </param>
        /// <param name="percentiles">
        /// Percentile entries returned by this metric, in canonical order. Each entry's `label` matches a corresponding entry in every response point's `percentiles` array; `value` is the percentile rank (e.g. `0.5` for p50).<br/>
        /// Example: [{"label":"p50","value":0.5}, {"label":"p90","value":0.9}, {"label":"p95","value":0.95}, {"label":"p99","value":0.99}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentilesMetricDescriptorVariant2(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.PercentileEntry> percentiles)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Percentiles = percentiles ?? throw new global::System.ArgumentNullException(nameof(percentiles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentilesMetricDescriptorVariant2" /> class.
        /// </summary>
        public PercentilesMetricDescriptorVariant2()
        {
        }

    }
}