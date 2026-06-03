
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The values the tool configuration's argument overrides contributed to this call, keyed by the paths in<br/>
    /// `ToolInputEvent.argument_override_paths`. `$ref` overrides are resolved against the session — agent secrets,<br/>
    /// session metadata, and prior tool outputs — with secret values masked as `****`. Literal overrides appear as-is.<br/>
    /// Overlay these onto `ToolInputEvent.tool_input` at the matching paths to see exactly what the tool received.<br/>
    /// Absent when the tool short-circuits before running (for example, malformed arguments from the agent or an<br/>
    /// unresolved dependency).<br/>
    /// Example: {"api_key":"****","base_url":"https://api.example.com"}
    /// </summary>
    public sealed partial class ToolOutputEventVariant2ResolvedArgumentOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}