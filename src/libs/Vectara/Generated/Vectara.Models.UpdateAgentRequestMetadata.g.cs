
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
    /// Example: {"department":"customer_service","version":"2000-01-01T00:00:00.0000000\u002B04:00","owner":"support-team","last_reviewed":"2024-01-15"}
    /// </summary>
    public sealed partial class UpdateAgentRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}