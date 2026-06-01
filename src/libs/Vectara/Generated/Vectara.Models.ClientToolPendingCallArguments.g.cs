
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The fully materialized arguments for this call: the agent-supplied arguments merged with the tool<br/>
    /// configuration's argument overrides and literals, with `$ref`s resolved against the session. Secret-derived<br/>
    /// values are delivered unmasked because the client needs them to execute the tool. This is exactly what the<br/>
    /// client should execute the tool with.<br/>
    /// Example: {"channel":"support","message":"Ticket escalated"}
    /// </summary>
    public sealed partial class ClientToolPendingCallArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}