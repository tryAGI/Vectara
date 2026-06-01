
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single client tool call awaiting output, with its fully materialized arguments.
    /// </summary>
    public sealed partial class ClientToolPendingCall
    {
        /// <summary>
        /// The `tool_input` event this call corresponds to. Submit the matching `tool_output` with this `event_id`.<br/>
        /// Example: aev_3Kx9QpVn2mZr8YbLc5TdWe
        /// </summary>
        /// <example>aev_3Kx9QpVn2mZr8YbLc5TdWe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: notify_slack
        /// </summary>
        /// <example>notify_slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolConfigurationName { get; set; }

        /// <summary>
        /// Name of the tool being called.<br/>
        /// Example: notify_slack
        /// </summary>
        /// <example>notify_slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// The fully materialized arguments for this call: the agent-supplied arguments merged with the tool<br/>
        /// configuration's argument overrides and literals, with `$ref`s resolved against the session. Secret-derived<br/>
        /// values are delivered unmasked because the client needs them to execute the tool. This is exactly what the<br/>
        /// client should execute the tool with.<br/>
        /// Example: {"channel":"support","message":"Ticket escalated"}
        /// </summary>
        /// <example>{"channel":"support","message":"Ticket escalated"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolPendingCall" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The `tool_input` event this call corresponds to. Submit the matching `tool_output` with this `event_id`.<br/>
        /// Example: aev_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="toolConfigurationName">
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: notify_slack
        /// </param>
        /// <param name="toolName">
        /// Name of the tool being called.<br/>
        /// Example: notify_slack
        /// </param>
        /// <param name="arguments">
        /// The fully materialized arguments for this call: the agent-supplied arguments merged with the tool<br/>
        /// configuration's argument overrides and literals, with `$ref`s resolved against the session. Secret-derived<br/>
        /// values are delivered unmasked because the client needs them to execute the tool. This is exactly what the<br/>
        /// client should execute the tool with.<br/>
        /// Example: {"channel":"support","message":"Ticket escalated"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolPendingCall(
            string eventId,
            string toolConfigurationName,
            string toolName,
            object arguments)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ToolConfigurationName = toolConfigurationName ?? throw new global::System.ArgumentNullException(nameof(toolConfigurationName));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolPendingCall" /> class.
        /// </summary>
        public ClientToolPendingCall()
        {
        }

    }
}