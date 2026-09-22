
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single time-bin point for a percentiles metric.
    /// </summary>
    public sealed partial class PercentilesMetricPoint
    {
        /// <summary>
        /// The start of the time bin in ISO 8601 (UTC). Bins lie on a grid of `bin_size_seconds` anchored at the Unix epoch, except when `max_bins` is 1, where the single bin starts at `start` rounded down to the nearest five-minute boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BinStart { get; set; }

        /// <summary>
        /// Percentile values for this time bin. Entries appear in the same order and with the same labels as the descriptor's `percentiles` array.
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
        /// The start of the time bin in ISO 8601 (UTC). Bins lie on a grid of `bin_size_seconds` anchored at the Unix epoch, except when `max_bins` is 1, where the single bin starts at `start` rounded down to the nearest five-minute boundary.
        /// </param>
        /// <param name="percentiles">
        /// Percentile values for this time bin. Entries appear in the same order and with the same labels as the descriptor's `percentiles` array.
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