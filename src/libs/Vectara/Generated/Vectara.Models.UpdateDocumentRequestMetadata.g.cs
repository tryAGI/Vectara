
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The metadata for a document as an arbitrary object. Properties of this object can be used by document level filter attributes.
    /// </summary>
    public sealed partial class UpdateDocumentRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}