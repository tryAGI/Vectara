
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricDescriptorDiscriminatorKind
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
    public static class MetricDescriptorDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricDescriptorDiscriminatorKind value)
        {
            return value switch
            {
                MetricDescriptorDiscriminatorKind.Counter => "counter",
                MetricDescriptorDiscriminatorKind.Distribution => "distribution",
                MetricDescriptorDiscriminatorKind.Gauge => "gauge",
                MetricDescriptorDiscriminatorKind.Percentiles => "percentiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricDescriptorDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "counter" => MetricDescriptorDiscriminatorKind.Counter,
                "distribution" => MetricDescriptorDiscriminatorKind.Distribution,
                "gauge" => MetricDescriptorDiscriminatorKind.Gauge,
                "percentiles" => MetricDescriptorDiscriminatorKind.Percentiles,
                _ => null,
            };
        }
    }
}