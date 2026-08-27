
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Lifecycle status of the session. `unstarted` before the session receives any event, `running` while the agent is producing<br/>
    /// events, and `stopped` when the session is idle with no event in flight.<br/>
    /// Included only in responses<br/>
    /// Example: stopped
    /// </summary>
    public enum EndUserSessionStatus
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
    public static class EndUserSessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserSessionStatus value)
        {
            return value switch
            {
                EndUserSessionStatus.Running => "running",
                EndUserSessionStatus.Stopped => "stopped",
                EndUserSessionStatus.Unstarted => "unstarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserSessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => EndUserSessionStatus.Running,
                "stopped" => EndUserSessionStatus.Stopped,
                "unstarted" => EndUserSessionStatus.Unstarted,
                _ => null,
            };
        }
    }
}