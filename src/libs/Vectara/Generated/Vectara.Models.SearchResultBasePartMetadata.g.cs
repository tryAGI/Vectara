
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The metadata for the document part as attached at indexing time. Filterable using `part.&lt;key&gt;` in metadata filter expressions.<br/>
    /// Example: {"section":"executive_summary"}
    /// </summary>
    public sealed partial class SearchResultBasePartMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}