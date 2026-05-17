
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A point in a percentiles metric series.
    /// </summary>
    public sealed partial class PercentilesMetricPoint
    {
        /// <summary>
        /// Start of the bucket window in ISO 8601 (UTC). End-time aligned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BucketStart { get; set; }

        /// <summary>
        /// Map of percentile label to value. Keys follow the `p&lt;N&gt;` convention (e.g. `p50`, `p99`, `p99_9` for the 99.9th percentile).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Percentiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentilesMetricPoint" /> class.
        /// </summary>
        /// <param name="bucketStart">
        /// Start of the bucket window in ISO 8601 (UTC). End-time aligned.
        /// </param>
        /// <param name="percentiles">
        /// Map of percentile label to value. Keys follow the `p&lt;N&gt;` convention (e.g. `p50`, `p99`, `p99_9` for the 99.9th percentile).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentilesMetricPoint(
            global::System.DateTime bucketStart,
            global::System.Collections.Generic.Dictionary<string, double> percentiles)
        {
            this.BucketStart = bucketStart;
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