
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Outcome of this attempt.<br/>
    /// * `success`: a session was created and the agent ran<br/>
    /// * `error`: the attempt failed, either before a session could be created, for example from an invalid run_condition expression, or while the agent ran<br/>
    /// * `skipped`: run_condition evaluated false, so no session was created<br/>
    /// * `enrichment_failed`: session metadata enrichment failed, so no session was created
    /// </summary>
    public enum AgentScheduleExecutionStatus
    {
        /// <summary>
        /// session metadata enrichment failed, so no session was created
        /// </summary>
        EnrichmentFailed,
        /// <summary>
        /// the attempt failed, either before a session could be created, for example from an invalid run_condition expression, or while the agent ran
        /// </summary>
        Error,
        /// <summary>
        /// run_condition evaluated false, so no session was created
        /// </summary>
        Skipped,
        /// <summary>
        /// a session was created and the agent ran
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentScheduleExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentScheduleExecutionStatus value)
        {
            return value switch
            {
                AgentScheduleExecutionStatus.EnrichmentFailed => "enrichment_failed",
                AgentScheduleExecutionStatus.Error => "error",
                AgentScheduleExecutionStatus.Skipped => "skipped",
                AgentScheduleExecutionStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentScheduleExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "enrichment_failed" => AgentScheduleExecutionStatus.EnrichmentFailed,
                "error" => AgentScheduleExecutionStatus.Error,
                "skipped" => AgentScheduleExecutionStatus.Skipped,
                "success" => AgentScheduleExecutionStatus.Success,
                _ => null,
            };
        }
    }
}