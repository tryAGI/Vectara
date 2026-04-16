
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reminder that expands terms, acronyms, and abbreviations in user messages using a glossary.<br/>
    /// When attached to a step, user input is run through the glossary's lookup index and matching<br/>
    /// terms are expanded before the message reaches the LLM.
    /// </summary>
    public sealed partial class GlossaryExpansionReminder
    {
        /// <summary>
        /// The type of reminder.<br/>
        /// Default Value: glossary_expansion<br/>
        /// Example: glossary_expansion
        /// </summary>
        /// <default>"glossary_expansion"</default>
        /// <example>glossary_expansion</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "glossary_expansion";

        /// <summary>
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </summary>
        /// <example>eng-acronyms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GlossaryKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryExpansionReminder" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reminder.<br/>
        /// Default Value: glossary_expansion<br/>
        /// Example: glossary_expansion
        /// </param>
        /// <param name="glossaryKey">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlossaryExpansionReminder(
            string type,
            string glossaryKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.GlossaryKey = glossaryKey ?? throw new global::System.ArgumentNullException(nameof(glossaryKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryExpansionReminder" /> class.
        /// </summary>
        public GlossaryExpansionReminder()
        {
        }
    }
}