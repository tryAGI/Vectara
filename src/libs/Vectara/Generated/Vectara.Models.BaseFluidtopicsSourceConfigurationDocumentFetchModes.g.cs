
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How document bodies are fetched in the `documents` scope, as a map of MIME type to fetch<br/>
    /// mode. Keys match a document's MIME type (`ft:mimeType`) exactly (`application/pdf`), by<br/>
    /// prefix (`image/*`), or `*` as the catch-all default. Types matching no key use<br/>
    /// `extracted_text`, the behavior when this map is unset. Ignored when `content_scope` is<br/>
    /// `topics`.<br/>
    /// Example: {"application/pdf":"original_file","video/*":"metadata_only"}
    /// </summary>
    public sealed partial class BaseFluidtopicsSourceConfigurationDocumentFetchModes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}