
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineTriggerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
        /// <summary>
        /// 
        /// </summary>
        Interval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineTriggerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineTriggerDiscriminatorType value)
        {
            return value switch
            {
                PipelineTriggerDiscriminatorType.Cron => "cron",
                PipelineTriggerDiscriminatorType.Interval => "interval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineTriggerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => PipelineTriggerDiscriminatorType.Cron,
                "interval" => PipelineTriggerDiscriminatorType.Interval,
                _ => null,
            };
        }
    }
}