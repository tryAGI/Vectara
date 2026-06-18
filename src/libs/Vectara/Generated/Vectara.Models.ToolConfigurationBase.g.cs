
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all tool configuration types.<br/>
    /// The identity properties (`key`, `name`, `description`, `enabled`, `metadata`) apply to reusable configurations managed via the `/v2/tool_configurations` endpoints; they are ignored when the configuration is defined inline in an agent's `tool_configurations` map, where the map key is the tool's name.
    /// </summary>
    public sealed partial class ToolConfigurationBase
    {
        /// <summary>
        /// A unique key that identifies a reusable tool configuration within a customer account.<br/>
        /// Customer-provided; if omitted when creating a configuration, one is generated from the name.<br/>
        /// Example: customer_support_search
        /// </summary>
        /// <example>customer_support_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The human-readable name of a tool configuration.<br/>
        /// Example: Customer Support Search Config
        /// </summary>
        /// <example>Customer Support Search Config</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A detailed description of what this tool configuration is for and how it should be used.<br/>
        /// Ignored for configurations defined inline on an agent.<br/>
        /// Example: Configuration for searching customer support documentation with optimized parameters
        /// </summary>
        /// <example>Configuration for searching customer support documentation with optimized parameters</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_template")]
        public string? DescriptionTemplate { get; set; }

        /// <summary>
        /// Whether the tool configuration is currently enabled and available for use.<br/>
        /// Ignored for configurations defined inline on an agent, which are always enabled.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional metadata associated with this tool configuration. Ignored for configurations defined inline on an agent.<br/>
        /// Example: {"tags":["production","v2"],"owner":"team-platform"}
        /// </summary>
        /// <example>{"tags":["production","v2"],"owner":"team-platform"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Timestamp when the tool configuration was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the tool configuration was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// An optional jq expression applied to the tool's JSON output before it is returned to the agent.<br/>
        /// Use this to project, filter, or summarize tool output to keep responses concise and on-topic.<br/>
        /// The expression operates on the tool's response JSON and the result replaces the original output.<br/>
        /// If the expression fails to compile or evaluate at runtime, the tool call is reported to the agent as an error so the agent can react.<br/>
        /// Examples:<br/>
        ///   - `.results | map({title, url})` — keep only title/url for each result<br/>
        ///   - `.items[0:5]` — first 5 items<br/>
        ///   - `del(.debug)` — drop a noisy field<br/>
        /// Example: .results | map({title, url})
        /// </summary>
        /// <example>.results | map({title, url})</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_transform")]
        public string? OutputTransform { get; set; }

        /// <summary>
        /// An optional jq expression applied to the tool's input after argument overrides have been merged with the agent's arguments and before the tool is invoked.<br/>
        /// Use this to inject server-side context (session metadata, agent secrets) into the tool input, or to reshape the agent's arguments.<br/>
        /// The expression receives the standard runtime context — the same `agent`, `session`, `tools`, and `currentDate` values exposed to `argument_override` `$ref`s (see `ArgumentOverrideDescription`), plus an `args` field containing the merged tool input.<br/>
        /// The output of the expression replaces `args` as the tool input.<br/>
        /// The pre-transform `args` is what appears in audit events (with secrets masked); the post-transform value goes only to the tool.<br/>
        /// If the expression fails to compile or evaluate, the tool call is reported to the agent as an error.<br/>
        /// Examples:<br/>
        ///   - `.args + { auth: ("Bearer " + .agent.secrets.token) }` — inject a bearer header<br/>
        ///   - `.args | .corpus_key = .session.metadata.corpus_key` — pull a corpus key from session metadata<br/>
        ///   - `.args | .query = (.args.query + " " + .session.metadata.query_suffix)` — augment the agent's query<br/>
        /// Example: .args + { auth: ("Bearer " + .agent.secrets.token) }
        /// </summary>
        /// <example>.args + { auth: ("Bearer " + .agent.secrets.token) }</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_transform")]
        public string? InputTransform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfigurationBase" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies a reusable tool configuration within a customer account.<br/>
        /// Customer-provided; if omitted when creating a configuration, one is generated from the name.<br/>
        /// Example: customer_support_search
        /// </param>
        /// <param name="name">
        /// The human-readable name of a tool configuration.<br/>
        /// Example: Customer Support Search Config
        /// </param>
        /// <param name="description">
        /// A detailed description of what this tool configuration is for and how it should be used.<br/>
        /// Ignored for configurations defined inline on an agent.<br/>
        /// Example: Configuration for searching customer support documentation with optimized parameters
        /// </param>
        /// <param name="descriptionTemplate">
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </param>
        /// <param name="enabled">
        /// Whether the tool configuration is currently enabled and available for use.<br/>
        /// Ignored for configurations defined inline on an agent, which are always enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with this tool configuration. Ignored for configurations defined inline on an agent.<br/>
        /// Example: {"tags":["production","v2"],"owner":"team-platform"}
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the tool configuration was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the tool configuration was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputTransform">
        /// An optional jq expression applied to the tool's JSON output before it is returned to the agent.<br/>
        /// Use this to project, filter, or summarize tool output to keep responses concise and on-topic.<br/>
        /// The expression operates on the tool's response JSON and the result replaces the original output.<br/>
        /// If the expression fails to compile or evaluate at runtime, the tool call is reported to the agent as an error so the agent can react.<br/>
        /// Examples:<br/>
        ///   - `.results | map({title, url})` — keep only title/url for each result<br/>
        ///   - `.items[0:5]` — first 5 items<br/>
        ///   - `del(.debug)` — drop a noisy field<br/>
        /// Example: .results | map({title, url})
        /// </param>
        /// <param name="inputTransform">
        /// An optional jq expression applied to the tool's input after argument overrides have been merged with the agent's arguments and before the tool is invoked.<br/>
        /// Use this to inject server-side context (session metadata, agent secrets) into the tool input, or to reshape the agent's arguments.<br/>
        /// The expression receives the standard runtime context — the same `agent`, `session`, `tools`, and `currentDate` values exposed to `argument_override` `$ref`s (see `ArgumentOverrideDescription`), plus an `args` field containing the merged tool input.<br/>
        /// The output of the expression replaces `args` as the tool input.<br/>
        /// The pre-transform `args` is what appears in audit events (with secrets masked); the post-transform value goes only to the tool.<br/>
        /// If the expression fails to compile or evaluate, the tool call is reported to the agent as an error.<br/>
        /// Examples:<br/>
        ///   - `.args + { auth: ("Bearer " + .agent.secrets.token) }` — inject a bearer header<br/>
        ///   - `.args | .corpus_key = .session.metadata.corpus_key` — pull a corpus key from session metadata<br/>
        ///   - `.args | .query = (.args.query + " " + .session.metadata.query_suffix)` — augment the agent's query<br/>
        /// Example: .args + { auth: ("Bearer " + .agent.secrets.token) }
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolConfigurationBase(
            string? key,
            string? name,
            string? description,
            string? descriptionTemplate,
            bool? enabled,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? outputTransform,
            string? inputTransform)
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.DescriptionTemplate = descriptionTemplate;
            this.Enabled = enabled;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OutputTransform = outputTransform;
            this.InputTransform = inputTransform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfigurationBase" /> class.
        /// </summary>
        public ToolConfigurationBase()
        {
        }

    }
}