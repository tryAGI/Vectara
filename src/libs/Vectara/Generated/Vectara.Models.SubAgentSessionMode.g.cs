
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Controls session behavior for sub-agent invocations:<br/>
    /// - llm_controlled: the agent decides whether to create a new session or resume an existing one<br/>
    /// - persistent: Always reuse the same session (created on first invocation)<br/>
    /// - ephemeral: Always create a new session on each invocation<br/>
    /// Default Value: ephemeral<br/>
    /// Example: ephemeral
    /// </summary>
    public enum SubAgentSessionMode
    {
        /// <summary>
        /// Always create a new session on each invocation
        /// </summary>
        Ephemeral,
        /// <summary>
        /// the agent decides whether to create a new session or resume an existing one
        /// </summary>
        LlmControlled,
        /// <summary>
        /// Always reuse the same session (created on first invocation)
        /// </summary>
        Persistent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubAgentSessionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubAgentSessionMode value)
        {
            return value switch
            {
                SubAgentSessionMode.Ephemeral => "ephemeral",
                SubAgentSessionMode.LlmControlled => "llm_controlled",
                SubAgentSessionMode.Persistent => "persistent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubAgentSessionMode? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => SubAgentSessionMode.Ephemeral,
                "llm_controlled" => SubAgentSessionMode.LlmControlled,
                "persistent" => SubAgentSessionMode.Persistent,
                _ => null,
            };
        }
    }
}