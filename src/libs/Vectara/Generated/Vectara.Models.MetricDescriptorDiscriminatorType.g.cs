
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricDescriptorDiscriminatorType
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
    public static class MetricDescriptorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricDescriptorDiscriminatorType value)
        {
            return value switch
            {
                MetricDescriptorDiscriminatorType.Counter => "counter",
                MetricDescriptorDiscriminatorType.Distribution => "distribution",
                MetricDescriptorDiscriminatorType.Gauge => "gauge",
                MetricDescriptorDiscriminatorType.Percentiles => "percentiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricDescriptorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "counter" => MetricDescriptorDiscriminatorType.Counter,
                "distribution" => MetricDescriptorDiscriminatorType.Distribution,
                "gauge" => MetricDescriptorDiscriminatorType.Gauge,
                "percentiles" => MetricDescriptorDiscriminatorType.Percentiles,
                _ => null,
            };
        }
    }
}