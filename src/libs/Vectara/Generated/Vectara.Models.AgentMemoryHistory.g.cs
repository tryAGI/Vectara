
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The full version history of the agent's memory, ordered by version ascending.
    /// </summary>
    public sealed partial class AgentMemoryHistory
    {
        /// <summary>
        /// The name of the memory skill (always `_learned_memory`).<br/>
        /// Example: _learned_memory
        /// </summary>
        /// <example>_learned_memory</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillName { get; set; }

        /// <summary>
        /// The memory snapshots, ordered by version ascending. Empty if the agent has no memory history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentMemoryVersion> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryHistory" /> class.
        /// </summary>
        /// <param name="skillName">
        /// The name of the memory skill (always `_learned_memory`).<br/>
        /// Example: _learned_memory
        /// </param>
        /// <param name="versions">
        /// The memory snapshots, ordered by version ascending. Empty if the agent has no memory history.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMemoryHistory(
            string skillName,
            global::System.Collections.Generic.IList<global::Vectara.AgentMemoryVersion> versions)
        {
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryHistory" /> class.
        /// </summary>
        public AgentMemoryHistory()
        {
        }

    }
}