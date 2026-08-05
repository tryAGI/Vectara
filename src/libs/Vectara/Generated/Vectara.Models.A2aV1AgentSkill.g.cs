
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A discrete capability the v1 agent advertises.
    /// </summary>
    public sealed partial class A2aV1AgentSkill
    {
        /// <summary>
        /// Unique identifier of the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name of the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable description of what the skill does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Tags categorizing the skill for discovery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Example prompts or inputs demonstrating the skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<string>? Examples { get; set; }

        /// <summary>
        /// Media types the skill accepts as input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputModes")]
        public global::System.Collections.Generic.IList<string>? InputModes { get; set; }

        /// <summary>
        /// Media types the skill produces as output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputModes")]
        public global::System.Collections.Generic.IList<string>? OutputModes { get; set; }

        /// <summary>
        /// Security requirements for the skill. Each entry maps scheme names to scope lists. Entries are alternatives. All schemes in one entry apply together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityRequirements")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? SecurityRequirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentSkill" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the skill.
        /// </param>
        /// <param name="name">
        /// Human-readable name of the skill.
        /// </param>
        /// <param name="description">
        /// Human-readable description of what the skill does.
        /// </param>
        /// <param name="tags">
        /// Tags categorizing the skill for discovery.
        /// </param>
        /// <param name="examples">
        /// Example prompts or inputs demonstrating the skill.
        /// </param>
        /// <param name="inputModes">
        /// Media types the skill accepts as input.
        /// </param>
        /// <param name="outputModes">
        /// Media types the skill produces as output.
        /// </param>
        /// <param name="securityRequirements">
        /// Security requirements for the skill. Each entry maps scheme names to scope lists. Entries are alternatives. All schemes in one entry apply together.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentSkill(
            string id,
            string name,
            string description,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<string>? examples,
            global::System.Collections.Generic.IList<string>? inputModes,
            global::System.Collections.Generic.IList<string>? outputModes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? securityRequirements)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Examples = examples;
            this.InputModes = inputModes;
            this.OutputModes = outputModes;
            this.SecurityRequirements = securityRequirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentSkill" /> class.
        /// </summary>
        public A2aV1AgentSkill()
        {
        }

    }
}