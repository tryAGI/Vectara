
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to upsert entries into a glossary in bulk. Entries with existing terms are updated; new terms are inserted.<br/>
    /// The platform rebuilds the glossary index after the upsert. Agents use the updated glossary after the rebuild completes.
    /// </summary>
    public sealed partial class UpsertGlossaryEntriesRequest
    {
        /// <summary>
        /// A map of terms to their expanded forms. Keys are terms (1–200 characters);<br/>
        /// values are expansions (1–1000 characters).<br/>
        /// Example: {"k8s":"Kubernetes","tf":"Terraform"}
        /// </summary>
        /// <example>{"k8s":"Kubernetes","tf":"Terraform"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGlossaryEntriesRequest" /> class.
        /// </summary>
        /// <param name="entries">
        /// A map of terms to their expanded forms. Keys are terms (1–200 characters);<br/>
        /// values are expansions (1–1000 characters).<br/>
        /// Example: {"k8s":"Kubernetes","tf":"Terraform"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGlossaryEntriesRequest(
            global::System.Collections.Generic.Dictionary<string, string> entries)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGlossaryEntriesRequest" /> class.
        /// </summary>
        public UpsertGlossaryEntriesRequest()
        {
        }

    }
}