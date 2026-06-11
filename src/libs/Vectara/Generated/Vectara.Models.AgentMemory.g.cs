
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The agent's accumulated learned memory, exposed as the reserved `_learned_memory` skill plus version metadata.
    /// </summary>
    public sealed partial class AgentMemory
    {
        /// <summary>
        /// A skill that provides progressively disclosed instructions to an agent; it allows the agent to access more instructions without<br/>
        /// always being within the system scope. Additionally, skills are explicitly loaded as an input event rather than normal text input event.<br/>
        /// Skills are defined at the agent level and can be filtered per step via allowed_skills.<br/>
        /// The skill key and description are shown to the agent in its instructions;<br/>
        /// the full content is sent as a user message when the skill is invoked via the invoke_skill tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentSkill Skill { get; set; }

        /// <summary>
        /// Version and audit metadata for the agent's memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentMemoryMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemory" /> class.
        /// </summary>
        /// <param name="skill">
        /// A skill that provides progressively disclosed instructions to an agent; it allows the agent to access more instructions without<br/>
        /// always being within the system scope. Additionally, skills are explicitly loaded as an input event rather than normal text input event.<br/>
        /// Skills are defined at the agent level and can be filtered per step via allowed_skills.<br/>
        /// The skill key and description are shown to the agent in its instructions;<br/>
        /// the full content is sent as a user message when the skill is invoked via the invoke_skill tool.
        /// </param>
        /// <param name="metadata">
        /// Version and audit metadata for the agent's memory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMemory(
            global::Vectara.AgentSkill skill,
            global::Vectara.AgentMemoryMetadata metadata)
        {
            this.Skill = skill ?? throw new global::System.ArgumentNullException(nameof(skill));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemory" /> class.
        /// </summary>
        public AgentMemory()
        {
        }

    }
}