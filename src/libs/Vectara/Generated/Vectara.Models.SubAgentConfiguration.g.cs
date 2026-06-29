
#nullable enable

namespace Vectara
{
    /// <summary>
    /// User-configurable settings for the sub-agent tool. These parameters are never exposed to the agent.
    /// </summary>
    public sealed partial class SubAgentConfiguration
    {
        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

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
        /// <example>ephemeral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.SubAgentSessionModeJsonConverter))]
        public global::Vectara.SubAgentSessionMode? SessionMode { get; set; }

        /// <summary>
        /// Optional metadata to associate with the sub-agent session. Can contain any key-value pairs.<br/>
        /// Default Value: {}<br/>
        /// Example: {"source":"parent_agent","task_type":"code_review"}
        /// </summary>
        /// <example>{"source":"parent_agent","task_type":"code_review"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentConfiguration" /> class.
        /// </summary>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionMode">
        /// Controls session behavior for sub-agent invocations:<br/>
        /// - `ephemeral`: Creates a new session on every invocation. Never resumes.<br/>
        /// - `persistent`: Reuses one session per (parent session, tool configuration) pair, created on first invocation. Two `persistent` configurations on the same agent keep separate sessions.<br/>
        /// - `session_scoped`: Resumes the session named by `session_key`, if provided; otherwise creates a new one. Only the parent session that originally created the named session may resume it. Scope is enforced by parent session and target sub-agent, not by tool configuration.<br/>
        /// - `agent_scoped`: Like `session_scoped`, but any session of the creating agent may resume the named session. Scope is enforced by creating agent and target sub-agent.<br/>
        /// - `llm_controlled`: Deprecated alias for `session_scoped`. Use `session_scoped` for new agents.<br/>
        /// Default Value: ephemeral<br/>
        /// Example: ephemeral
        /// </param>
        /// <param name="sessionMetadata">
        /// Optional metadata to associate with the sub-agent session. Can contain any key-value pairs.<br/>
        /// Default Value: {}<br/>
        /// Example: {"source":"parent_agent","task_type":"code_review"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubAgentConfiguration(
            string agentKey,
            global::Vectara.SubAgentSessionMode? sessionMode,
            object? sessionMetadata)
        {
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.SessionMode = sessionMode;
            this.SessionMetadata = sessionMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentConfiguration" /> class.
        /// </summary>
        public SubAgentConfiguration()
        {
        }

    }
}