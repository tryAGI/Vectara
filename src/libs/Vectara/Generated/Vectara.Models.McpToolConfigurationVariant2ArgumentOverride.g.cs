
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The agent will not be able to change the parameters, nor know those values exist within the tool.<br/>
    /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
    /// - Static value: "fixed_value" or 123<br/>
    /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
    /// References are resolved at runtime from context:<br/>
    /// - session.metadata.* - Access session metadata fields<br/>
    /// - agent.metadata.* - Access agent metadata fields<br/>
    /// - agent.secrets.* - Access agent secrets (masked in audit events)<br/>
    /// - tools.* - Access prior tool outputs (resolved after the dependent tool runs)<br/>
    /// - currentDate - The current date/time in ISO 8601 format<br/>
    /// A bracket index may reference another context value, whose resolved value is used as the lookup key. The inner path may optionally carry a leading $ root marker:<br/>
    /// - Indirect reference: `{"$ref": "agent.secrets[session.metadata.user_id]"}` looks up the per-user secret named by `session.metadata.user_id`<br/>
    /// - Equivalent forms: `agent.secrets[$session.metadata.user_id]` and `agent.secrets[$.session.metadata.user_id]`<br/>
    /// Example:<br/>
    ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
    /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
    /// Example: {"custom_param":"value","max_results":10}
    /// </summary>
    public sealed partial class McpToolConfigurationVariant2ArgumentOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}