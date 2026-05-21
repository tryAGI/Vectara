
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricSeriesDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Counter,
        /// <summary>
        /// 
        /// </summary>
        Distribution,
        /// <summary>
        /// 
        /// </summary>
        Gauge,
        /// <summary>
        /// 
        /// </summary>
        Percentiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricSeriesDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricSeriesDiscriminatorKind value)
        {
            return value switch
            {
                MetricSeriesDiscriminatorKind.Counter => "counter",
                MetricSeriesDiscriminatorKind.Distribution => "distribution",
                MetricSeriesDiscriminatorKind.Gauge => "gauge",
                MetricSeriesDiscriminatorKind.Percentiles => "percentiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricSeriesDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "counter" => MetricSeriesDiscriminatorKind.Counter,
                "distribution" => MetricSeriesDiscriminatorKind.Distribution,
                "gauge" => MetricSeriesDiscriminatorKind.Gauge,
                "percentiles" => MetricSeriesDiscriminatorKind.Percentiles,
                _ => null,
            };
        }
    }
}