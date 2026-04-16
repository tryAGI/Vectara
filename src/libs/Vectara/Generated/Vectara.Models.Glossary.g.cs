
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A glossary is a reusable mapping of terms to their expanded forms. Agents are reminded by<br/>
    /// glossaries to automatically expand abbreviations, acronyms, and domain-specific<br/>
    /// shorthand in user messages before they reach the agent.
    /// </summary>
    public sealed partial class Glossary
    {
        /// <summary>
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </summary>
        /// <example>eng-acronyms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable name for the glossary.<br/>
        /// Example: Engineering Acronyms
        /// </summary>
        /// <example>Engineering Acronyms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what this glossary covers.<br/>
        /// Example: Common engineering and infrastructure acronyms used by the platform team.
        /// </summary>
        /// <example>Common engineering and infrastructure acronyms used by the platform team.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The number of entries currently in the glossary.<br/>
        /// Example: 142
        /// </summary>
        /// <example>142</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_entries")]
        public long? NumEntries { get; set; }

        /// <summary>
        /// Timestamp when the glossary was created.<br/>
        /// Example: 2026-03-01T10:00:00Z
        /// </summary>
        /// <example>2026-03-01T10:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the glossary was last updated.<br/>
        /// Example: 2026-03-15T14:30:00Z
        /// </summary>
        /// <example>2026-03-15T14:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Glossary" /> class.
        /// </summary>
        /// <param name="key">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="name">
        /// Human-readable name for the glossary.<br/>
        /// Example: Engineering Acronyms
        /// </param>
        /// <param name="description">
        /// A description of what this glossary covers.<br/>
        /// Example: Common engineering and infrastructure acronyms used by the platform team.
        /// </param>
        /// <param name="numEntries">
        /// The number of entries currently in the glossary.<br/>
        /// Example: 142
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the glossary was created.<br/>
        /// Example: 2026-03-01T10:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the glossary was last updated.<br/>
        /// Example: 2026-03-15T14:30:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Glossary(
            string key,
            string name,
            string? description,
            long? numEntries,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.NumEntries = numEntries;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Glossary" /> class.
        /// </summary>
        public Glossary()
        {
        }
    }
}