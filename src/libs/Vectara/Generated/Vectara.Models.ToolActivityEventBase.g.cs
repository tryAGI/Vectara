
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all tool activity event types.
    /// </summary>
    public sealed partial class ToolActivityEventBase
    {
        /// <summary>
        /// The type of streaming event.<br/>
        /// Default Value: tool_activity<br/>
        /// Example: tool_activity
        /// </summary>
        /// <default>"tool_activity"</default>
        /// <example>tool_activity</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "tool_activity";

        /// <summary>
        /// The tool_call_id of the tool invocation this activity belongs to. Matches tool_input/tool_output.<br/>
        /// Example: call_tool_search_001
        /// </summary>
        /// <example>call_tool_search_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The name of the tool configuration emitting the activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration_name")]
        public string? ToolConfigurationName { get; set; }

        /// <summary>
        /// Name of the tool emitting the activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolActivityEventBase" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: tool_activity<br/>
        /// Example: tool_activity
        /// </param>
        /// <param name="toolCallId">
        /// The tool_call_id of the tool invocation this activity belongs to. Matches tool_input/tool_output.<br/>
        /// Example: call_tool_search_001
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        /// <param name="toolConfigurationName">
        /// The name of the tool configuration emitting the activity.
        /// </param>
        /// <param name="toolName">
        /// Name of the tool emitting the activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolActivityEventBase(
            string type,
            string toolCallId,
            global::System.DateTime createdAt,
            string? toolConfigurationName,
            string? toolName)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolConfigurationName = toolConfigurationName;
            this.ToolName = toolName;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolActivityEventBase" /> class.
        /// </summary>
        public ToolActivityEventBase()
        {
        }

    }
}