
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A skill that provides progressively disclosed instructions to an agent; it allows the agent to access more instructions without<br/>
    /// always being within the system scope. Additionally, skills are explicitly loaded as an input event rather than normal text input event.<br/>
    /// Skills are defined at the agent level and can be filtered per step via allowed_skills.<br/>
    /// The skill key and description are shown to the agent in its instructions;<br/>
    /// the full content is sent as a user message when the skill is invoked via the invoke_skill tool.
    /// </summary>
    public sealed partial class AgentSkill
    {
        /// <summary>
        /// A brief description of what the skill does, shown to the agent in its instructions.<br/>
        /// Example: Reviews code for best practices, bugs, and security issues.
        /// </summary>
        /// <example>Reviews code for best practices, bugs, and security issues.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Trigger conditions describing when the agent should invoke this skill, such as concrete user situations or<br/>
        /// phrases that should cause the skill to load. Used alongside the description when the agent decides which<br/>
        /// skill to invoke.<br/>
        /// Example: Use when the user asks to review, audit, or check code, or mentions "bugs", "security", or "best practices".
        /// </summary>
        /// <example>Use when the user asks to review, audit, or check code, or mentions "bugs", "security", or "best practices".</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("when_to_use")]
        public string? WhenToUse { get; set; }

        /// <summary>
        /// The full instruction content for this skill.<br/>
        /// This is NOT shown in the instructions by default; it is loaded when the skill is invoked.<br/>
        /// Example: When reviewing code, check for security vulnerabilities, performance issues, and adherence to best practices...
        /// </summary>
        /// <example>When reviewing code, check for security vulnerabilities, performance issues, and adherence to best practices...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        /// <param name="description">
        /// A brief description of what the skill does, shown to the agent in its instructions.<br/>
        /// Example: Reviews code for best practices, bugs, and security issues.
        /// </param>
        /// <param name="content">
        /// The full instruction content for this skill.<br/>
        /// This is NOT shown in the instructions by default; it is loaded when the skill is invoked.<br/>
        /// Example: When reviewing code, check for security vulnerabilities, performance issues, and adherence to best practices...
        /// </param>
        /// <param name="whenToUse">
        /// Trigger conditions describing when the agent should invoke this skill, such as concrete user situations or<br/>
        /// phrases that should cause the skill to load. Used alongside the description when the agent decides which<br/>
        /// skill to invoke.<br/>
        /// Example: Use when the user asks to review, audit, or check code, or mentions "bugs", "security", or "best practices".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSkill(
            string description,
            string content,
            string? whenToUse)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.WhenToUse = whenToUse;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        public AgentSkill()
        {
        }

    }
}