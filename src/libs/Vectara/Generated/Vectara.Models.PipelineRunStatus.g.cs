
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The status of a pipeline run.
    /// </summary>
    public enum PipelineRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineRunStatus value)
        {
            return value switch
            {
                PipelineRunStatus.Queued => "queued",
                PipelineRunStatus.Running => "running",
                PipelineRunStatus.Completed => "completed",
                PipelineRunStatus.Failed => "failed",
                PipelineRunStatus.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => PipelineRunStatus.Queued,
                "running" => PipelineRunStatus.Running,
                "completed" => PipelineRunStatus.Completed,
                "failed" => PipelineRunStatus.Failed,
                "cancelled" => PipelineRunStatus.Cancelled,
                _ => null,
            };
        }
    }
}