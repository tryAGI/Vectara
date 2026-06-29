
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Named configurations of other tools this lambda may invoke from its Python code through the built-in `tool` module. Each entry is exposed as<br/>
    /// `tool.&lt;name&gt;(param=value)`; `tool.list()` returns their names and schemas, and failures raise `tool.ToolError`.<br/>
    /// `$ref` values inside `argument_override` resolve against the hosting agent and session at execution time — `agent.metadata.*`, `agent.secrets.*`, and<br/>
    /// `session.metadata.*` only. These configurations are private to the tool: they never appear on the hosting agent's callable tools, and their calls produce<br/>
    /// no session events.<br/>
    /// A configured tool may itself be a lambda with its own `tool_configurations`, nested up to three levels deep.<br/>
    /// Each configuration name is how the code calls it (`tool.&lt;name&gt;`), so it must be a valid identifier: a letter followed by letters, digits, or<br/>
    /// underscores.<br/>
    /// See `POST /v2/tools/test` for exercising these calls without persisting the tool.<br/>
    /// Example: {"fetch_status":{"type":"web_get","argument_override":{"url":"https://status.example.com/api/health"}}}
    /// </summary>
    public sealed partial class CreateLambdaToolRequestToolConfigurations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}