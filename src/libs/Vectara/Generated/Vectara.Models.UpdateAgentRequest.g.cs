
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for updating an existing agent. Omitted fields are preserved.<br/>
    /// Nullable fields (description, tool_configurations, metadata, enabled, guardrails)<br/>
    /// can be set to null to clear them.
    /// </summary>
    public sealed partial class UpdateAgentRequest
    {
        /// <summary>
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </summary>
        /// <example>Customer Support Agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A detailed description of the agent's purpose and capabilities. Set to null to clear.<br/>
        /// Example: An enhanced AI agent specialized in handling customer support inquiries.
        /// </summary>
        /// <example>An enhanced AI agent specialized in handling customer support inquiries.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A map of tool configurations available to the agent. Set to null to clear all tools.<br/>
        /// Individual map values set to null will delete that tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </summary>
        /// <example>{"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configurations")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? ToolConfigurations { get; set; }

        /// <summary>
        /// A map of skills available to the agent. Set to null to clear all skills.<br/>
        /// Individual map values set to null will delete that skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? Skills { get; set; }

        /// <summary>
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Vectara.AgentModel? Model { get; set; }

        /// <summary>
        /// Partial update for the first (entry point) step. Omitted fields are preserved.<br/>
        /// Includes an optional name field to rename the first step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_step")]
        public global::Vectara.UpdateFirstAgentStep? FirstStep { get; set; }

        /// <summary>
        /// Reassign the entry point to an existing step by name. This is the preferred way<br/>
        /// to change the entry point. The named step must exist in the steps map.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_step_name")]
        public string? FirstStepName { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
        /// Example: {"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}
        /// </summary>
        /// <example>{"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the agent is enabled. Set to null to reset to default (true).<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Configuration for automatic context compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction")]
        public global::Vectara.CompactionConfig? Compaction { get; set; }

        /// <summary>
        /// Controls how large tool outputs are kept from overwhelming the agent context window.<br/>
        /// Tool outputs are inspected as they are produced. A small output is always passed through<br/>
        /// unchanged. A larger output is handled in one of two cases: when the output on its own is<br/>
        /// big enough to dominate the context, or when adding it to the conversation would leave<br/>
        /// too little room for the agent to continue. In either case the output is handled according<br/>
        /// to `mode` — stored as an artifact and replaced with a compact reference, or truncated in<br/>
        /// place with the head and tail preserved and the middle omitted. When stored as an artifact,<br/>
        /// the agent is expected to have artifact_read, artifact_grep, or artifact_jq configured so<br/>
        /// it can retrieve the full content on demand.<br/>
        /// All fields are optional; omitted fields fall back to defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_output_offloading")]
        public global::Vectara.ToolOutputOffloadingConfiguration? ToolOutputOffloading { get; set; }

        /// <summary>
        /// A map of additional named steps keyed by step name for partial update.<br/>
        /// Only provided keys are modified; missing keys are preserved.<br/>
        /// Set a key's value to null to delete that step.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}
        /// </summary>
        /// <example>{"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities. Set to null to clear.<br/>
        /// Example: An enhanced AI agent specialized in handling customer support inquiries.
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. Set to null to clear all tools.<br/>
        /// Individual map values set to null will delete that tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent. Set to null to clear all skills.<br/>
        /// Individual map values set to null will delete that skill.
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="firstStep">
        /// Partial update for the first (entry point) step. Omitted fields are preserved.<br/>
        /// Includes an optional name field to rename the first step.
        /// </param>
        /// <param name="firstStepName">
        /// Reassign the entry point to an existing step by name. This is the preferred way<br/>
        /// to change the entry point. The named step must exist in the steps map.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
        /// Example: {"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent is enabled. Set to null to reset to default (true).<br/>
        /// Example: true
        /// </param>
        /// <param name="compaction">
        /// Configuration for automatic context compaction.
        /// </param>
        /// <param name="toolOutputOffloading">
        /// Controls how large tool outputs are kept from overwhelming the agent context window.<br/>
        /// Tool outputs are inspected as they are produced. A small output is always passed through<br/>
        /// unchanged. A larger output is handled in one of two cases: when the output on its own is<br/>
        /// big enough to dominate the context, or when adding it to the conversation would leave<br/>
        /// too little room for the agent to continue. In either case the output is handled according<br/>
        /// to `mode` — stored as an artifact and replaced with a compact reference, or truncated in<br/>
        /// place with the head and tail preserved and the middle omitted. When stored as an artifact,<br/>
        /// the agent is expected to have artifact_read, artifact_grep, or artifact_jq configured so<br/>
        /// it can retrieve the full content on demand.<br/>
        /// All fields are optional; omitted fields fall back to defaults.
        /// </param>
        /// <param name="steps">
        /// A map of additional named steps keyed by step name for partial update.<br/>
        /// Only provided keys are modified; missing keys are preserved.<br/>
        /// Set a key's value to null to delete that step.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? toolConfigurations,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentSkill>? skills,
            global::Vectara.AgentModel? model,
            global::Vectara.UpdateFirstAgentStep? firstStep,
            string? firstStepName,
            object? metadata,
            bool? enabled,
            global::Vectara.CompactionConfig? compaction,
            global::Vectara.ToolOutputOffloadingConfiguration? toolOutputOffloading,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.UpdateAgentStep>? steps)
        {
            this.Name = name;
            this.Description = description;
            this.ToolConfigurations = toolConfigurations;
            this.Skills = skills;
            this.Model = model;
            this.FirstStep = firstStep;
            this.FirstStepName = firstStepName;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Compaction = compaction;
            this.ToolOutputOffloading = toolOutputOffloading;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        public UpdateAgentRequest()
        {
        }

    }
}