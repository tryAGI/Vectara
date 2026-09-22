
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common properties shared by all metric series types.
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
        /// The dimension values identifying this series, keyed by dimension name. Echoes the `dimensions` filter supplied in the request. A dimension absent from the map was not filtered, so the series merges every value of it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> DimensionValues { get; set; }

        /// <summary>
        /// Deprecated alias for `dimension_values`; identical value. Use `dimension_values`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Labels { get; set; }

        /// <summary>
        /// The width of each time bin in the returned series, in seconds. The platform chooses it from the requested time range and `max_bins`. When `max_bins` is 1, it is the width of the requested window after rounding `start` down and `end` up to the nearest five-minute boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin_size_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BinSizeSeconds { get; set; }

        /// <summary>
        /// The descriptor of the metric this series describes, as listed in the catalog. Carries the unit, the dimension names, and the percentile ranks or bin ranges needed to interpret the points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.MetricDescriptorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.MetricDescriptor Metric { get; set; }

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
        /// <param name="dimensionValues">
        /// The dimension values identifying this series, keyed by dimension name. Echoes the `dimensions` filter supplied in the request. A dimension absent from the map was not filtered, so the series merges every value of it.
        /// </param>
        /// <param name="labels">
        /// Deprecated alias for `dimension_values`; identical value. Use `dimension_values`.
        /// </param>
        /// <param name="binSizeSeconds">
        /// The width of each time bin in the returned series, in seconds. The platform chooses it from the requested time range and `max_bins`. When `max_bins` is 1, it is the width of the requested window after rounding `start` down and `end` up to the nearest five-minute boundary.
        /// </param>
        /// <param name="metric">
        /// The descriptor of the metric this series describes, as listed in the catalog. Carries the unit, the dimension names, and the percentile ranks or bin ranges needed to interpret the points.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricSeriesBase(
            string metricName,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> dimensionValues,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> labels,
            int binSizeSeconds,
            global::Vectara.MetricDescriptor metric)
        {
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.DimensionValues = dimensionValues ?? throw new global::System.ArgumentNullException(nameof(dimensionValues));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.BinSizeSeconds = binSizeSeconds;
            this.Metric = metric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricSeriesBase" /> class.
        /// </summary>
        public MetricSeriesBase()
        {
        }

    }
}