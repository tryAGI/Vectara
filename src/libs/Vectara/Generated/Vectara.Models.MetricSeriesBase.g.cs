
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common properties shared by all metric series kinds.
    /// </summary>
    public sealed partial class MetricSeriesBase
    {
        /// <summary>
        /// The name of the metric this series describes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricName { get; set; }

        /// <summary>
        /// The labels matched for this series. Echoes the filter values supplied in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Labels { get; set; }

        /// <summary>
        /// Width of each bucket in the returned series, in seconds. The server chooses this based on the requested time range and `max_buckets`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_size_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BucketSizeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricSeriesBase" /> class.
        /// </summary>
        /// <param name="metricName">
        /// The name of the metric this series describes.
        /// </param>
        /// <param name="labels">
        /// The labels matched for this series. Echoes the filter values supplied in the request.
        /// </param>
        /// <param name="bucketSizeSeconds">
        /// Width of each bucket in the returned series, in seconds. The server chooses this based on the requested time range and `max_buckets`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricSeriesBase(
            string metricName,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> labels,
            int bucketSizeSeconds)
        {
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.BucketSizeSeconds = bucketSizeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricSeriesBase" /> class.
        /// </summary>
        public MetricSeriesBase()
        {
        }

    }
}