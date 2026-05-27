
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A point in a distribution metric series. Bin labels match those declared on the metric's descriptor. Only bins with non-zero counts appear.
    /// </summary>
    public sealed partial class DistributionMetricPoint
    {
        /// <summary>
        /// Start of the time bin in ISO 8601 (UTC). End-time aligned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BinStart { get; set; }

        /// <summary>
        /// Per-bin counts for this time bin, sorted by the descriptor's canonical bin order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.HistogramBin> Bins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionMetricPoint" /> class.
        /// </summary>
        /// <param name="binStart">
        /// Start of the time bin in ISO 8601 (UTC). End-time aligned.
        /// </param>
        /// <param name="bins">
        /// Per-bin counts for this time bin, sorted by the descriptor's canonical bin order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributionMetricPoint(
            global::System.DateTime binStart,
            global::System.Collections.Generic.IList<global::Vectara.HistogramBin> bins)
        {
            this.BinStart = binStart;
            this.Bins = bins ?? throw new global::System.ArgumentNullException(nameof(bins));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionMetricPoint" /> class.
        /// </summary>
        public DistributionMetricPoint()
        {
        }

    }
}