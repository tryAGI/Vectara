
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientToolPendingEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: client_tool_pending
        /// </summary>
        /// <default>"client_tool_pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "client_tool_pending";

        /// <summary>
        /// The client tool calls awaiting output, one entry per outstanding call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall> PendingCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolPendingEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: client_tool_pending
        /// </param>
        /// <param name="pendingCalls">
        /// The client tool calls awaiting output, one entry per outstanding call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolPendingEventVariant2(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall> pendingCalls)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PendingCalls = pendingCalls ?? throw new global::System.ArgumentNullException(nameof(pendingCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolPendingEventVariant2" /> class.
        /// </summary>
        public ClientToolPendingEventVariant2()
        {
        }

    }
}