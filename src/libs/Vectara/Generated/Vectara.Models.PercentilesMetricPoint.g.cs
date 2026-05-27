
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A point in a percentiles metric series. Entries correspond by `label` to the descriptor's `percentiles` array, in the same canonical order.
    /// </summary>
    public sealed partial class PercentilesMetricPoint
    {
        /// <summary>
        /// Start of the time bin in ISO 8601 (UTC). End-time aligned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BinStart { get; set; }

        /// <summary>
        /// Per-percentile aggregated values for this time bin. Each entry's `value` is the metric's aggregated value at the percentile identified by `label`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.PercentileEntry> Percentiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentilesMetricPoint" /> class.
        /// </summary>
        /// <param name="binStart">
        /// Start of the time bin in ISO 8601 (UTC). End-time aligned.
        /// </param>
        /// <param name="percentiles">
        /// Per-percentile aggregated values for this time bin. Each entry's `value` is the metric's aggregated value at the percentile identified by `label`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentilesMetricPoint(
            global::System.DateTime binStart,
            global::System.Collections.Generic.IList<global::Vectara.PercentileEntry> percentiles)
        {
            this.BinStart = binStart;
            this.Percentiles = percentiles ?? throw new global::System.ArgumentNullException(nameof(percentiles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentilesMetricPoint" /> class.
        /// </summary>
        public PercentilesMetricPoint()
        {
        }

    }
}