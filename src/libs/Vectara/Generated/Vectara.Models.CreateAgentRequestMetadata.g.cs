
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
    /// Example: {"department":"customer_service","version":"1.0.0","owner":"support-team"}
    /// </summary>
    public sealed partial class CreateAgentRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}