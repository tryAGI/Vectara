
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineRunEventDiscriminatorType
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
    public static class PipelineRunEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineRunEventDiscriminatorType value)
        {
            return value switch
            {
                PipelineRunEventDiscriminatorType.RecordProcessing => "record_processing",
                PipelineRunEventDiscriminatorType.RunCompleted => "run_completed",
                PipelineRunEventDiscriminatorType.RunStarted => "run_started",
                PipelineRunEventDiscriminatorType.WatermarkAdvanced => "watermark_advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineRunEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "record_processing" => PipelineRunEventDiscriminatorType.RecordProcessing,
                "run_completed" => PipelineRunEventDiscriminatorType.RunCompleted,
                "run_started" => PipelineRunEventDiscriminatorType.RunStarted,
                "watermark_advanced" => PipelineRunEventDiscriminatorType.WatermarkAdvanced,
                _ => null,
            };
        }
    }
}