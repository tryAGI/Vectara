
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A point in a distribution metric series — a histogram of value-bucketed counts at a time bucket. Only bins with non-zero counts appear.
    /// </summary>
    public sealed partial class DistributionMetricPoint
    {
        /// <summary>
        /// Start of the bucket window in ISO 8601 (UTC). End-time aligned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BucketStart { get; set; }

        /// <summary>
        /// Histogram bins, sorted by `lower_ms` ascending.
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
        /// <param name="bucketStart">
        /// Start of the bucket window in ISO 8601 (UTC). End-time aligned.
        /// </param>
        /// <param name="bins">
        /// Histogram bins, sorted by `lower_ms` ascending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributionMetricPoint(
            global::System.DateTime bucketStart,
            global::System.Collections.Generic.IList<global::Vectara.HistogramBin> bins)
        {
            this.BucketStart = bucketStart;
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