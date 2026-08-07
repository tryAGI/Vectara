
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arguments to invoke the tool with. These may set only the parameters that the tool definition does not already fix through its own configured argument_override. A parameter fixed by the tool cannot be set per call, so naming one here is rejected when the agent is created or updated. Enrichment runs with no LLM to fill arguments in. These arguments, together with the parameters fixed by the tool, must cover every required parameter of the tool. Each value is either a literal or a `$ref` object that resolves against session or agent metadata, the agent's secrets as `agent.secrets.&lt;name&gt;`, the session secrets supplied on the create request as `session.secrets.&lt;name&gt;`, or an earlier call's output as `tools.&lt;tool&gt;.outputs.latest`. Session creation fails with 422 if a `$ref` names a secret that is not on the agent or in the create request, unless the `$ref` supplies a `$default`, in which case the default value is used instead.
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