
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
        Scheduled,
        /// <summary>
        /// 
        /// </summary>
        Manual,
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
                PipelineRunTriggerType.Scheduled => "scheduled",
                PipelineRunTriggerType.Manual => "manual",
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
                "scheduled" => PipelineRunTriggerType.Scheduled,
                "manual" => PipelineRunTriggerType.Manual,
                _ => null,
            };
        }
    }
}