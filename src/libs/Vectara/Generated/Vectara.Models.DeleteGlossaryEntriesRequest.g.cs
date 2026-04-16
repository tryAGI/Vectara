
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Bulk delete entries from a glossary by term.
    /// </summary>
    public sealed partial class DeleteGlossaryEntriesRequest
    {
        /// <summary>
        /// The terms to remove from the glossary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Terms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGlossaryEntriesRequest" /> class.
        /// </summary>
        /// <param name="terms">
        /// The terms to remove from the glossary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteGlossaryEntriesRequest(
            global::System.Collections.Generic.IList<string> terms)
        {
            this.Terms = terms ?? throw new global::System.ArgumentNullException(nameof(terms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGlossaryEntriesRequest" /> class.
        /// </summary>
        public DeleteGlossaryEntriesRequest()
        {
        }
    }
}