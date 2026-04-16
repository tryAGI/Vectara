
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a list of glossaries.
    /// </summary>
    public sealed partial class ListGlossariesResponse
    {
        /// <summary>
        /// The glossaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.Glossary> Glossaries { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ListMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossariesResponse" /> class.
        /// </summary>
        /// <param name="glossaries">
        /// The glossaries.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGlossariesResponse(
            global::System.Collections.Generic.IList<global::Vectara.Glossary> glossaries,
            global::Vectara.ListMetadata metadata)
        {
            this.Glossaries = glossaries ?? throw new global::System.ArgumentNullException(nameof(glossaries));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossariesResponse" /> class.
        /// </summary>
        public ListGlossariesResponse()
        {
        }
    }
}