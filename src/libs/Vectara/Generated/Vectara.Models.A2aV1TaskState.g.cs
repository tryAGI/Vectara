
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A2A v1 task lifecycle state. Note `TASK_STATE_CANCELED` uses the US spelling per the v1 proto (one L).
    /// </summary>
    public enum A2aV1TaskState
    {
        /// <summary>
        /// 
        /// </summary>
        TaskStateAuthRequired,
        /// <summary>
        /// 
        /// </summary>
        TaskStateCanceled,
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
    public static class A2aV1TaskStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this A2aV1TaskState value)
        {
            return value switch
            {
                A2aV1TaskState.TaskStateAuthRequired => "TASK_STATE_AUTH_REQUIRED",
                A2aV1TaskState.TaskStateCanceled => "TASK_STATE_CANCELED",
                A2aV1TaskState.TaskStateCompleted => "TASK_STATE_COMPLETED",
                A2aV1TaskState.TaskStateFailed => "TASK_STATE_FAILED",
                A2aV1TaskState.TaskStateInputRequired => "TASK_STATE_INPUT_REQUIRED",
                A2aV1TaskState.TaskStateRejected => "TASK_STATE_REJECTED",
                A2aV1TaskState.TaskStateSubmitted => "TASK_STATE_SUBMITTED",
                A2aV1TaskState.TaskStateUnspecified => "TASK_STATE_UNSPECIFIED",
                A2aV1TaskState.TaskStateWorking => "TASK_STATE_WORKING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static A2aV1TaskState? ToEnum(string value)
        {
            return value switch
            {
                "TASK_STATE_AUTH_REQUIRED" => A2aV1TaskState.TaskStateAuthRequired,
                "TASK_STATE_CANCELED" => A2aV1TaskState.TaskStateCanceled,
                "TASK_STATE_COMPLETED" => A2aV1TaskState.TaskStateCompleted,
                "TASK_STATE_FAILED" => A2aV1TaskState.TaskStateFailed,
                "TASK_STATE_INPUT_REQUIRED" => A2aV1TaskState.TaskStateInputRequired,
                "TASK_STATE_REJECTED" => A2aV1TaskState.TaskStateRejected,
                "TASK_STATE_SUBMITTED" => A2aV1TaskState.TaskStateSubmitted,
                "TASK_STATE_UNSPECIFIED" => A2aV1TaskState.TaskStateUnspecified,
                "TASK_STATE_WORKING" => A2aV1TaskState.TaskStateWorking,
                _ => null,
            };
        }
    }
}