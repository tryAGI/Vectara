
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricSeriesDiscriminatorType
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
    public static class MetricSeriesDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricSeriesDiscriminatorType value)
        {
            return value switch
            {
                MetricSeriesDiscriminatorType.Counter => "counter",
                MetricSeriesDiscriminatorType.Distribution => "distribution",
                MetricSeriesDiscriminatorType.Gauge => "gauge",
                MetricSeriesDiscriminatorType.Percentiles => "percentiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricSeriesDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "counter" => MetricSeriesDiscriminatorType.Counter,
                "distribution" => MetricSeriesDiscriminatorType.Distribution,
                "gauge" => MetricSeriesDiscriminatorType.Gauge,
                "percentiles" => MetricSeriesDiscriminatorType.Percentiles,
                _ => null,
            };
        }
    }
}