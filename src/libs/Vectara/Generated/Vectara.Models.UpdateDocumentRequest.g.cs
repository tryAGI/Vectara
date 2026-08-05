
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update a document. A PUT request replaces the existing metadata with the request body metadata. A PATCH request merges the request body metadata into the existing metadata, adding or modifying only the specified fields.
    /// </summary>
    public sealed partial class UpdateDocumentRequest
    {
        /// <summary>
        /// The metadata for a document as an arbitrary object. Properties of this object can be used by document level filter attributes.<br/>
        /// Example: {"title":"2024 ESG Annual Report \u2013 EuroBank","region":"EU","industry":"banking","year":2024}
        /// </summary>
        /// <example>{"title":"2024 ESG Annual Report \u2013 EuroBank","region":"EU","industry":"banking","year":2024}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// The metadata for a document as an arbitrary object. Properties of this object can be used by document level filter attributes.<br/>
        /// Example: {"title":"2024 ESG Annual Report \u2013 EuroBank","region":"EU","industry":"banking","year":2024}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDocumentRequest(
            object? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        public UpdateDocumentRequest()
        {
        }

    }
}