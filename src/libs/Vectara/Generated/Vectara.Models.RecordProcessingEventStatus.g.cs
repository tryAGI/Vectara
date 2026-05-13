
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Lifecycle status of a single source record within a run.
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
                "failed" => RecordProcessingEventStatus.Failed,
                "started" => RecordProcessingEventStatus.Started,
                _ => null,
            };
        }
    }
}