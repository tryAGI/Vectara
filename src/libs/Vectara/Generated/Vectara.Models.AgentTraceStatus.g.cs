
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The final status of the trace.
    /// </summary>
    public enum AgentTraceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTraceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTraceStatus value)
        {
            return value switch
            {
                AgentTraceStatus.Error => "error",
                AgentTraceStatus.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTraceStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentTraceStatus.Error,
                "ok" => AgentTraceStatus.Ok,
                _ => null,
            };
        }
    }
}