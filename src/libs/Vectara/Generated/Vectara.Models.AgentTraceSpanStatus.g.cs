
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The status of an agent trace span.
    /// </summary>
    public enum AgentTraceSpanStatus
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
    public static class AgentTraceSpanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTraceSpanStatus value)
        {
            return value switch
            {
                AgentTraceSpanStatus.Error => "error",
                AgentTraceSpanStatus.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTraceSpanStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentTraceSpanStatus.Error,
                "ok" => AgentTraceSpanStatus.Ok,
                _ => null,
            };
        }
    }
}