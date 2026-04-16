
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
        Cancelled,
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
        Running,
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
                PipelineRunStatus.Cancelled => "cancelled",
                PipelineRunStatus.Completed => "completed",
                PipelineRunStatus.Failed => "failed",
                PipelineRunStatus.Running => "running",
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
                "cancelled" => PipelineRunStatus.Cancelled,
                "completed" => PipelineRunStatus.Completed,
                "failed" => PipelineRunStatus.Failed,
                "running" => PipelineRunStatus.Running,
                _ => null,
            };
        }
    }
}