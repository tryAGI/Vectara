
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Restricts ingestion to records matching the given Fluid Topics metadata, as a map of metadata<br/>
    /// key to the list of accepted values. For example `{"Disclosure": ["Public"]}` ingests only<br/>
    /// public content. When unset, no metadata filter is applied. Under `content_scope: maps` the<br/>
    /// reserved key `id` matches the map's own identifier, so `{"id": ["&lt;map_id&gt;"]}` restricts a run<br/>
    /// to a single map.<br/>
    /// Example: {"Disclosure":["Public"]}
    /// </summary>
    public sealed partial class BaseFluidtopicsSourceConfigurationFilters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}