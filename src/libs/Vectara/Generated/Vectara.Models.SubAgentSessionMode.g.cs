
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Controls session behavior for sub-agent invocations:<br/>
    /// - `ephemeral`: Creates a new session on every invocation. Never resumes.<br/>
    /// - `persistent`: Reuses one session per (parent session, tool configuration) pair, created on first invocation. Two `persistent` configurations on the same agent keep separate sessions.<br/>
    /// - `session_scoped`: Resumes the session named by `session_key`, if provided; otherwise creates a new one. Only the parent session that originally created the named session may resume it. Scope is enforced by parent session and target sub-agent, not by tool configuration.<br/>
    /// - `agent_scoped`: Like `session_scoped`, but any session of the creating agent may resume the named session. Scope is enforced by creating agent and target sub-agent.<br/>
    /// - `llm_controlled`: Deprecated alias for `session_scoped`. Use `session_scoped` for new agents.<br/>
    /// Default Value: ephemeral<br/>
    /// Example: ephemeral
    /// </summary>
    public enum SubAgentSessionMode
    {
        /// <summary>
        /// Like `session_scoped`, but any session of the creating agent may resume the named session. Scope is enforced by creating agent and target sub-agent.
        /// </summary>
        AgentScoped,
        /// <summary>
        /// Creates a new session on every invocation. Never resumes.
        /// </summary>
        Ephemeral,
        /// <summary>
        /// Deprecated alias for `session_scoped`. Use `session_scoped` for new agents.
        /// </summary>
        LlmControlled,
        /// <summary>
        /// Reuses one session per (parent session, tool configuration) pair, created on first invocation. Two `persistent` configurations on the same agent keep separate sessions.
        /// </summary>
        Persistent,
        /// <summary>
        /// Resumes the session named by `session_key`, if provided; otherwise creates a new one. Only the parent session that originally created the named session may resume it. Scope is enforced by parent session and target sub-agent, not by tool configuration.
        /// </summary>
        SessionScoped,
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
                SubAgentSessionMode.AgentScoped => "agent_scoped",
                SubAgentSessionMode.Ephemeral => "ephemeral",
                SubAgentSessionMode.LlmControlled => "llm_controlled",
                SubAgentSessionMode.Persistent => "persistent",
                SubAgentSessionMode.SessionScoped => "session_scoped",
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
                "agent_scoped" => SubAgentSessionMode.AgentScoped,
                "ephemeral" => SubAgentSessionMode.Ephemeral,
                "llm_controlled" => SubAgentSessionMode.LlmControlled,
                "persistent" => SubAgentSessionMode.Persistent,
                "session_scoped" => SubAgentSessionMode.SessionScoped,
                _ => null,
            };
        }
    }
}