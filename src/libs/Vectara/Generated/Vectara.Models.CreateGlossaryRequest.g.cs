
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new glossary.
    /// </summary>
    public sealed partial class CreateGlossaryRequest
    {
        /// <summary>
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </summary>
        /// <example>eng-acronyms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGlossaryRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the glossary.<br/>
        /// Example: Engineering Acronyms
        /// </param>
        /// <param name="key">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="description">
        /// A description of what this glossary covers.<br/>
        /// Example: Common engineering and infrastructure acronyms used by the platform team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGlossaryRequest(
            string name,
            string? key,
            string? description)
        {
            this.Key = key;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGlossaryRequest" /> class.
        /// </summary>
        public CreateGlossaryRequest()
        {
        }
    }
}