
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single term-to-expansion mapping in a glossary.
    /// </summary>
    public sealed partial class GlossaryEntry
    {
        /// <summary>
        /// The term, acronym, or abbreviation to match in user input. Multi-word terms are supported.<br/>
        /// Example: k8s
        /// </summary>
        /// <example>k8s</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Term { get; set; }

        /// <summary>
        /// The expanded form to substitute when the term is matched.<br/>
        /// Example: Kubernetes
        /// </summary>
        /// <example>Kubernetes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expansion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expansion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryEntry" /> class.
        /// </summary>
        /// <param name="term">
        /// The term, acronym, or abbreviation to match in user input. Multi-word terms are supported.<br/>
        /// Example: k8s
        /// </param>
        /// <param name="expansion">
        /// The expanded form to substitute when the term is matched.<br/>
        /// Example: Kubernetes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlossaryEntry(
            string term,
            string expansion)
        {
            this.Term = term ?? throw new global::System.ArgumentNullException(nameof(term));
            this.Expansion = expansion ?? throw new global::System.ArgumentNullException(nameof(expansion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryEntry" /> class.
        /// </summary>
        public GlossaryEntry()
        {
        }
    }
}