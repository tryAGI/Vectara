
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The metadata for a document part. Attributes matching corpus document part filter attributes are used as document part filter attributes.
    /// </summary>
    public sealed partial class CoreDocumentPartMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}