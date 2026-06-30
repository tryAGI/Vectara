
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The metadata object to apply to every matched document.<br/>
    /// Example: {"status":"archived","reviewed":true,"year":2024}
    /// </summary>
    public sealed partial class BulkUpdateDocumentMetadataRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}