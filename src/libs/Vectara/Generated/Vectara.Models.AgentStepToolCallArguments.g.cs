
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arguments to invoke the tool with. These may set only the parameters that the tool configuration does not already fix through its argument_override. Naming a fixed parameter is rejected when the agent is created or updated. No LLM fills in arguments, so these arguments, together with the parameters the tool configuration fixes, must cover every required parameter of the tool. A call that omits one fails when it runs. Each value is either a literal or a `$ref` object, resolved when the call runs against the same context as a reference in argument_override. That context includes the output of an earlier call in the same step as `tools.&lt;tool_config_name&gt;.outputs.latest`.<br/>
    /// Example: {"artifact_id":"art_pdf_abc123","chunking":{"strategy":"hierarchical"}}
    /// </summary>
    public sealed partial class AgentStepToolCallArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}