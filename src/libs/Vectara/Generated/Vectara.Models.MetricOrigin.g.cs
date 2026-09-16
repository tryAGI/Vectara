
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Who provides a metric. New values may be added; treat unknown values as opaque.<br/>
    /// * `system`: the platform provides the metric. It cannot be updated or deleted.<br/>
    /// * `custom`: the account created the metric from its agent traces.<br/>
    /// Example: system
    /// </summary>
    public enum MetricOrigin
    {
        /// <summary>
        /// the account created the metric from its agent traces.
        /// </summary>
        Custom,
        /// <summary>
        /// the platform provides the metric. It cannot be updated or deleted.
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricOrigin value)
        {
            return value switch
            {
                MetricOrigin.Custom => "custom",
                MetricOrigin.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricOrigin? ToEnum(string value)
        {
            return value switch
            {
                "custom" => MetricOrigin.Custom,
                "system" => MetricOrigin.System,
                _ => null,
            };
        }
    }
}