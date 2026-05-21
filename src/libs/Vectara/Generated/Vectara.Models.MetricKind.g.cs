
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The kind of metric. Determines combine semantics when filtering across multiple label values and the shape of points in the response:<br/>
    /// - `counter`: monotonic count or sum (trace count, error count, token totals). Combined by summing. Returns `ScalarMetricPoint`s.<br/>
    /// - `gauge`: point-in-time value (mean, max, distinct-count). Combined per the underlying aggregate state (weighted mean for averages, max for maxima, distinct-count for uniq metrics). Returns `ScalarMetricPoint`s.<br/>
    /// - `percentiles`: distribution percentiles over a t-digest aggregate. Combined by merging t-digest states. Returns `PercentilesMetricPoint`s.<br/>
    /// - `distribution`: histogram of value-bucketed counts. Combined by summing per-bin counts. Returns `DistributionMetricPoint`s.
    /// </summary>
    public enum MetricKind
    {
        /// <summary>
        /// monotonic count or sum (trace count, error count, token totals). Combined by summing. Returns `ScalarMetricPoint`s.
        /// </summary>
        Counter,
        /// <summary>
        /// distribution percentiles over a t-digest aggregate. Combined by merging t-digest states. Returns `PercentilesMetricPoint`s.
        /// </summary>
        Distribution,
        /// <summary>
        /// point-in-time value (mean, max, distinct-count). Combined per the underlying aggregate state (weighted mean for averages, max for maxima, distinct-count for uniq metrics). Returns `ScalarMetricPoint`s.
        /// </summary>
        Gauge,
        /// <summary>
        /// distribution percentiles over a t-digest aggregate. Combined by merging t-digest states. Returns `PercentilesMetricPoint`s.
        /// </summary>
        Percentiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricKind value)
        {
            return value switch
            {
                MetricKind.Counter => "counter",
                MetricKind.Distribution => "distribution",
                MetricKind.Gauge => "gauge",
                MetricKind.Percentiles => "percentiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricKind? ToEnum(string value)
        {
            return value switch
            {
                "counter" => MetricKind.Counter,
                "distribution" => MetricKind.Distribution,
                "gauge" => MetricKind.Gauge,
                "percentiles" => MetricKind.Percentiles,
                _ => null,
            };
        }
    }
}