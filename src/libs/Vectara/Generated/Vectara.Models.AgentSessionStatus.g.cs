
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Lifecycle status of the session. `unstarted` before any event has been submitted, `running` while the agent is producing events, and `stopped` when the session is idle with no event in flight. `stopped` implies no terminating action — the session returns to `running` on the next request.<br/>
    /// Included only in responses<br/>
    /// Example: stopped
    /// </summary>
    public enum AgentSessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Unstarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionStatus value)
        {
            return value switch
            {
                AgentSessionStatus.Running => "running",
                AgentSessionStatus.Stopped => "stopped",
                AgentSessionStatus.Unstarted => "unstarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => AgentSessionStatus.Running,
                "stopped" => AgentSessionStatus.Stopped,
                "unstarted" => AgentSessionStatus.Unstarted,
                _ => null,
            };
        }
    }
}