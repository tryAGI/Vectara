
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Replaces the tool's `tool_configurations` map. Omit to leave the existing configurations unchanged; set to `null` to clear them.<br/>
    /// See the `tool_configurations` field on `CreateLambdaToolRequest` for semantics and constraints.<br/>
    /// Example: {"fetch_status":{"type":"web_get","argument_override":{"url":"https://status.example.com/api/health"}}}
    /// </summary>
    public sealed partial class UpdateLambdaToolRequestToolConfigurations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}