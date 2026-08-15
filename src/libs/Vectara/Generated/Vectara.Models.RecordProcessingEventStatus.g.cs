
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Lifecycle status of a single source record within a run. `started` when processing begins, `completed` when the record succeeded or was skipped without processing, `failed` for a failed processing attempt, and `dead_lettered` when the record exhausted its retries and was written to, or in a retry run updated in, the dead letter queue.
    /// </summary>
    public enum RecordProcessingEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        DeadLettered,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordProcessingEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordProcessingEventStatus value)
        {
            return value switch
            {
                RecordProcessingEventStatus.Completed => "completed",
                RecordProcessingEventStatus.DeadLettered => "dead_lettered",
                RecordProcessingEventStatus.Failed => "failed",
                RecordProcessingEventStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordProcessingEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RecordProcessingEventStatus.Completed,
                "dead_lettered" => RecordProcessingEventStatus.DeadLettered,
                "failed" => RecordProcessingEventStatus.Failed,
                "started" => RecordProcessingEventStatus.Started,
                _ => null,
            };
        }
    }
}