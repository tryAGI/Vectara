
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arbitrary metadata associated with the connector.<br/>
    /// Example: {"priority":"high","department":"customer_service"}
    /// </summary>
    public sealed partial class AgentConnectorMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}