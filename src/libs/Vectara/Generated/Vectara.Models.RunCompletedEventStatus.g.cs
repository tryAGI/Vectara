
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Terminal status of a pipeline run.
    /// </summary>
    public enum RunCompletedEventStatus
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
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunCompletedEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunCompletedEventStatus value)
        {
            return value switch
            {
                RunCompletedEventStatus.Cancelled => "cancelled",
                RunCompletedEventStatus.Completed => "completed",
                RunCompletedEventStatus.Failed => "failed",
                RunCompletedEventStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunCompletedEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RunCompletedEventStatus.Cancelled,
                "completed" => RunCompletedEventStatus.Completed,
                "failed" => RunCompletedEventStatus.Failed,
                "timed_out" => RunCompletedEventStatus.TimedOut,
                _ => null,
            };
        }
    }
}