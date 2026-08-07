
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `mcp`.<br/>
        /// Default Value: mcp<br/>
        /// Example: mcp
        /// </summary>
        /// <default>"mcp"</default>
        /// <example>mcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "mcp";

        /// <summary>
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>tol_123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        public string? ToolId { get; set; }

        /// <summary>
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to override. The value specifies what to override with. The agent cannot change these parameters and does not know these values exist.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References resolve at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - session.caller.type / .id / .email - The platform-verified identity of the caller who created the session (`user`, `api_key`, or `agent`; `email` is present only for user callers). The platform derives it from the authenticated request. A client cannot set it or shadow it through session metadata. It resolves only during session-creation enrichment (`session_enrichment.tool_calls` and the `enrichment_only` tool configurations they name). A reference to it from a tool the agent calls mid-conversation stays unresolved and that call fails. An absent value (no email on the caller, or no authenticated identity) leaves the $ref unresolved and fails the call closed. In an `input_transform` jq expression the same absent value reads as `null` instead, so guard it there.<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// - agent.secrets.* - Access agent secrets (masked in audit events)<br/>
        /// - tools.* - Access prior tool outputs (resolved after the dependent tool runs)<br/>
        /// - currentDate - The current date/time in ISO 8601 format<br/>
        /// A bracket index may reference another context value. The resolved value becomes the lookup key. The inner path may optionally carry a leading $ root marker:<br/>
        /// - Indirect reference: `{"$ref": "agent.secrets[session.metadata.user_id]"}` looks up the per-user secret named by `session.metadata.user_id`<br/>
        /// - Equivalent forms: `agent.secrets[$session.metadata.user_id]` and `agent.secrets[$.session.metadata.user_id]`<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// To use a literal `"$ref"` value, write `"$$ref"`. The $$ escapes the first $.<br/>
        /// Example: {"custom_param":"value","max_results":10}
        /// </summary>
        /// <example>{"custom_param":"value","max_results":10}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public object? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `mcp`.<br/>
        /// Default Value: mcp<br/>
        /// Example: mcp
        /// </param>
        /// <param name="toolId">
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="argumentOverride">
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to override. The value specifies what to override with. The agent cannot change these parameters and does not know these values exist.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References resolve at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - session.caller.type / .id / .email - The platform-verified identity of the caller who created the session (`user`, `api_key`, or `agent`; `email` is present only for user callers). The platform derives it from the authenticated request. A client cannot set it or shadow it through session metadata. It resolves only during session-creation enrichment (`session_enrichment.tool_calls` and the `enrichment_only` tool configurations they name). A reference to it from a tool the agent calls mid-conversation stays unresolved and that call fails. An absent value (no email on the caller, or no authenticated identity) leaves the $ref unresolved and fails the call closed. In an `input_transform` jq expression the same absent value reads as `null` instead, so guard it there.<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// - agent.secrets.* - Access agent secrets (masked in audit events)<br/>
        /// - tools.* - Access prior tool outputs (resolved after the dependent tool runs)<br/>
        /// - currentDate - The current date/time in ISO 8601 format<br/>
        /// A bracket index may reference another context value. The resolved value becomes the lookup key. The inner path may optionally carry a leading $ root marker:<br/>
        /// - Indirect reference: `{"$ref": "agent.secrets[session.metadata.user_id]"}` looks up the per-user secret named by `session.metadata.user_id`<br/>
        /// - Equivalent forms: `agent.secrets[$session.metadata.user_id]` and `agent.secrets[$.session.metadata.user_id]`<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// To use a literal `"$ref"` value, write `"$$ref"`. The $$ escapes the first $.<br/>
        /// Example: {"custom_param":"value","max_results":10}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpToolConfigurationVariant2(
            string type,
            string? toolId,
            object? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolId = toolId;
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolConfigurationVariant2" /> class.
        /// </summary>
        public McpToolConfigurationVariant2()
        {
        }

    }
}