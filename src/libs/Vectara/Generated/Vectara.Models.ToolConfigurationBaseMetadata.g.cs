
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional metadata associated with this tool configuration.<br/>
    /// Example: {"tags":["production","v2"],"owner":"team-platform"}
    /// </summary>
    public sealed partial class ToolConfigurationBaseMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}