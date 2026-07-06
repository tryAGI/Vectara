
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Metadata the source system manages, such as size, timestamps, or eTag.
    /// </summary>
    public sealed partial class SourceRecordMetadataSystemMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}