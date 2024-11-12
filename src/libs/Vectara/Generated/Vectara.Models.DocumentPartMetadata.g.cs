
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.
    /// </summary>
    public sealed partial class DocumentPartMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPartMetadata" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DocumentPartMetadata(
 )
        {
        }
    }
}