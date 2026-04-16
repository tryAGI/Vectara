
#nullable enable

namespace Vectara
{
    /// <summary>
    /// What initiated the pipeline run.
    /// </summary>
    public enum PipelineRunTriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Retry,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineRunTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineRunTriggerType value)
        {
            return value switch
            {
                PipelineRunTriggerType.Manual => "manual",
                PipelineRunTriggerType.Retry => "retry",
                PipelineRunTriggerType.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineRunTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => PipelineRunTriggerType.Manual,
                "retry" => PipelineRunTriggerType.Retry,
                "scheduled" => PipelineRunTriggerType.Scheduled,
                _ => null,
            };
        }
    }
}