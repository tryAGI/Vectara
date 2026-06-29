
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Named tool configurations private to this lambda tool, each callable from the tool's code as `tool.&lt;name&gt;(...)`. They do not appear on<br/>
    /// the hosting agent's tool surface, and their calls produce no session events. `$ref`s in `argument_override` resolve against the hosting<br/>
    /// agent and session at execution time.<br/>
    /// Example: {"fetch_status":{"type":"web_get","argument_override":{"url":"https://status.example.com/api/health"}}}
    /// </summary>
    public sealed partial class LambdaToolVariant2ToolConfigurations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}