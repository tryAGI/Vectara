
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A point in a counter or gauge metric series — a single scalar value at a time bucket.
    /// </summary>
    public sealed partial class ScalarMetricPoint
    {
        /// <summary>
        /// Start of the bucket window in ISO 8601 (UTC). End-time aligned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BucketStart { get; set; }

        /// <summary>
        /// The aggregated value for this bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarMetricPoint" /> class.
        /// </summary>
        /// <param name="bucketStart">
        /// Start of the bucket window in ISO 8601 (UTC). End-time aligned.
        /// </param>
        /// <param name="value">
        /// The aggregated value for this bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalarMetricPoint(
            global::System.DateTime bucketStart,
            double value)
        {
            this.BucketStart = bucketStart;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarMetricPoint" /> class.
        /// </summary>
        public ScalarMetricPoint()
        {
        }

    }
}