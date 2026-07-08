
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arguments to invoke the tool with. These may set only the parameters that the tool definition does not already fix through its own configured argument_override. A parameter fixed by the tool cannot be set per call, so naming one here is rejected when the agent is created or updated. Because enrichment runs with no model to fill arguments in, these arguments together with the parameters fixed by the tool must cover every required parameter of the tool. Each value is either a literal or a $ref object that resolves against session or agent metadata or an earlier call's output as tools.&lt;name&gt;.outputs.latest.
    /// </summary>
    public sealed partial class SessionEnrichmentToolCallArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}