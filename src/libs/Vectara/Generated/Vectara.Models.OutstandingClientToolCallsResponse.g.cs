
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The client tool calls a session is currently waiting on the caller to fulfill, re-materialized from persisted history. Empty when the session is not parked on a client tool.
    /// </summary>
    public sealed partial class OutstandingClientToolCallsResponse
    {
        /// <summary>
        /// The outstanding client tool calls, one entry per `tool_input` event still awaiting a `tool_output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall> ClientToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutstandingClientToolCallsResponse" /> class.
        /// </summary>
        /// <param name="clientToolCalls">
        /// The outstanding client tool calls, one entry per `tool_input` event still awaiting a `tool_output`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutstandingClientToolCallsResponse(
            global::System.Collections.Generic.IList<global::Vectara.ClientToolPendingCall> clientToolCalls)
        {
            this.ClientToolCalls = clientToolCalls ?? throw new global::System.ArgumentNullException(nameof(clientToolCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutstandingClientToolCallsResponse" /> class.
        /// </summary>
        public OutstandingClientToolCallsResponse()
        {
        }

    }
}