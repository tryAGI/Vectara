
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The type of a pipeline run event. Used as the discriminator on<br/>
    /// `PipelineRunEvent`. New types may be added over time; clients should<br/>
    /// treat unknown types as informational and ignore them.
    /// </summary>
    public enum PipelineRunEventType
    {
        /// <summary>
        /// 
        /// </summary>
        RecordProcessing,
        /// <summary>
        /// 
        /// </summary>
        RunCompleted,
        /// <summary>
        /// 
        /// </summary>
        RunStarted,
        /// <summary>
        /// 
        /// </summary>
        WatermarkAdvanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineRunEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineRunEventType value)
        {
            return value switch
            {
                PipelineRunEventType.RecordProcessing => "record_processing",
                PipelineRunEventType.RunCompleted => "run_completed",
                PipelineRunEventType.RunStarted => "run_started",
                PipelineRunEventType.WatermarkAdvanced => "watermark_advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineRunEventType? ToEnum(string value)
        {
            return value switch
            {
                "record_processing" => PipelineRunEventType.RecordProcessing,
                "run_completed" => PipelineRunEventType.RunCompleted,
                "run_started" => PipelineRunEventType.RunStarted,
                "watermark_advanced" => PipelineRunEventType.WatermarkAdvanced,
                _ => null,
            };
        }
    }
}