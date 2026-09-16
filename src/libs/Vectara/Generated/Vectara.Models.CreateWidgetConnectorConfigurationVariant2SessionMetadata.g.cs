
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Written into every session created through this widget connector, anonymous or signed-in, under `metadata.connector.&lt;connector_id&gt;` — namespaced by the connector's id, so connector-written values never collide with metadata from other writers and expressions can address the entry connector explicitly (e.g. `$.session.metadata.connector.con_abc123.instance`).<br/>
    /// Readable wherever session metadata is readable: instruction templates, `run_condition`, `session_enrichment` references, alias routing rules, and tool `argument_override` expressions.<br/>
    /// Not served by the public connector view and not returned on the end-user session object, though values reach the agent's context and may surface in its replies.<br/>
    /// Omitted or empty writes no session metadata.<br/>
    /// Default Value: {}<br/>
    /// Example: {"instance":"conversational-ai"}
    /// </summary>
    public sealed partial class CreateWidgetConnectorConfigurationVariant2SessionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}