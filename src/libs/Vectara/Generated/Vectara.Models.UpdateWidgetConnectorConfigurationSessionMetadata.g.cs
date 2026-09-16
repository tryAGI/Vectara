
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Written into every session created through this widget connector, under `metadata.connector.&lt;connector_id&gt;`.<br/>
    /// Example: {"instance":"conversational-ai"}
    /// </summary>
    public sealed partial class UpdateWidgetConnectorConfigurationSessionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}