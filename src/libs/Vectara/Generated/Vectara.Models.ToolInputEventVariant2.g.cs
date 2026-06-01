
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolInputEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: tool_input
        /// </summary>
        /// <default>"tool_input"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "tool_input";

        /// <summary>
        /// The identifier for the tool call.<br/>
        /// Example: call_tool_search_001
        /// </summary>
        /// <example>call_tool_search_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </summary>
        /// <example>customer_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolConfigurationName { get; set; }

        /// <summary>
        /// Name of the tool being called.<br/>
        /// Example: web_search
        /// </summary>
        /// <example>web_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Input data for the tool.<br/>
        /// Example: {"query":"weather in San Francisco"}
        /// </summary>
        /// <example>{"query":"weather in San Francisco"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolInput { get; set; }

        /// <summary>
        /// Dot-notation leaf paths supplied by the tool configuration's argument overrides rather than by the agent — for example `api_key`,<br/>
        /// `config.auth.token`, or `items[0]`. These paths are frozen on the input event so that the agent's view of its own past tool calls stays<br/>
        /// stable when the tool configuration changes: overrides are excluded from replayed calls regardless of how the override has evolved since.<br/>
        /// Only the paths are frozen here; the resolved values at those paths are not — they are recomputed against the live session at each launch<br/>
        /// and recorded on the corresponding `ToolOutputEvent.resolved_argument_overrides`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override_paths")]
        public global::System.Collections.Generic.IList<string>? ArgumentOverridePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolInputEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: tool_input
        /// </param>
        /// <param name="toolCallId">
        /// The identifier for the tool call.<br/>
        /// Example: call_tool_search_001
        /// </param>
        /// <param name="toolConfigurationName">
        /// The name of the tool configuration being invoked, as defined in the agent's tool_configurations map.<br/>
        /// Example: customer_search
        /// </param>
        /// <param name="toolName">
        /// Name of the tool being called.<br/>
        /// Example: web_search
        /// </param>
        /// <param name="toolInput">
        /// Input data for the tool.<br/>
        /// Example: {"query":"weather in San Francisco"}
        /// </param>
        /// <param name="argumentOverridePaths">
        /// Dot-notation leaf paths supplied by the tool configuration's argument overrides rather than by the agent — for example `api_key`,<br/>
        /// `config.auth.token`, or `items[0]`. These paths are frozen on the input event so that the agent's view of its own past tool calls stays<br/>
        /// stable when the tool configuration changes: overrides are excluded from replayed calls regardless of how the override has evolved since.<br/>
        /// Only the paths are frozen here; the resolved values at those paths are not — they are recomputed against the live session at each launch<br/>
        /// and recorded on the corresponding `ToolOutputEvent.resolved_argument_overrides`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolInputEventVariant2(
            string type,
            string toolCallId,
            string toolConfigurationName,
            string toolName,
            object toolInput,
            global::System.Collections.Generic.IList<string>? argumentOverridePaths)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolConfigurationName = toolConfigurationName ?? throw new global::System.ArgumentNullException(nameof(toolConfigurationName));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolInput = toolInput ?? throw new global::System.ArgumentNullException(nameof(toolInput));
            this.ArgumentOverridePaths = argumentOverridePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolInputEventVariant2" /> class.
        /// </summary>
        public ToolInputEventVariant2()
        {
        }

    }
}