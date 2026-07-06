
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Metadata the owner of the source object attached, such as S3 object tags or SharePoint custom columns.
    /// </summary>
    public sealed partial class SourceRecordMetadataUserMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}