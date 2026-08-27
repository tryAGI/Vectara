
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The A2A v0.3 task lifecycle state. `TASK_STATE_CANCELLED` uses the UK spelling, as defined in the A2A v0.3 specification.
    /// </summary>
    public enum A2aV03TaskState
    {
        /// <summary>
        ///
        /// </summary>
        TaskStateAuthRequired,
        /// <summary>
        ///
        /// </summary>
        TaskStateCancelled,
        /// <summary>
        ///
        /// </summary>
        TaskStateCompleted,
        /// <summary>
        ///
        /// </summary>
        TaskStateFailed,
        /// <summary>
        ///
        /// </summary>
        TaskStateInputRequired,
        /// <summary>
        ///
        /// </summary>
        TaskStateRejected,
        /// <summary>
        ///
        /// </summary>
        TaskStateSubmitted,
        /// <summary>
        ///
        /// </summary>
        TaskStateUnspecified,
        /// <summary>
        ///
        /// </summary>
        TaskStateWorking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class A2aV03TaskStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this A2aV03TaskState value)
        {
            return value switch
            {
                A2aV03TaskState.TaskStateAuthRequired => "TASK_STATE_AUTH_REQUIRED",
                A2aV03TaskState.TaskStateCancelled => "TASK_STATE_CANCELLED",
                A2aV03TaskState.TaskStateCompleted => "TASK_STATE_COMPLETED",
                A2aV03TaskState.TaskStateFailed => "TASK_STATE_FAILED",
                A2aV03TaskState.TaskStateInputRequired => "TASK_STATE_INPUT_REQUIRED",
                A2aV03TaskState.TaskStateRejected => "TASK_STATE_REJECTED",
                A2aV03TaskState.TaskStateSubmitted => "TASK_STATE_SUBMITTED",
                A2aV03TaskState.TaskStateUnspecified => "TASK_STATE_UNSPECIFIED",
                A2aV03TaskState.TaskStateWorking => "TASK_STATE_WORKING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static A2aV03TaskState? ToEnum(string value)
        {
            return value switch
            {
                "TASK_STATE_AUTH_REQUIRED" => A2aV03TaskState.TaskStateAuthRequired,
                "TASK_STATE_CANCELLED" => A2aV03TaskState.TaskStateCancelled,
                "TASK_STATE_COMPLETED" => A2aV03TaskState.TaskStateCompleted,
                "TASK_STATE_FAILED" => A2aV03TaskState.TaskStateFailed,
                "TASK_STATE_INPUT_REQUIRED" => A2aV03TaskState.TaskStateInputRequired,
                "TASK_STATE_REJECTED" => A2aV03TaskState.TaskStateRejected,
                "TASK_STATE_SUBMITTED" => A2aV03TaskState.TaskStateSubmitted,
                "TASK_STATE_UNSPECIFIED" => A2aV03TaskState.TaskStateUnspecified,
                "TASK_STATE_WORKING" => A2aV03TaskState.TaskStateWorking,
                _ => null,
            };
        }
    }
}