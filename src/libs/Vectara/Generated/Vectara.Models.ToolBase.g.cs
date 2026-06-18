
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all tool types.
    /// </summary>
    public sealed partial class ToolBase
    {
        /// <summary>
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>tol_123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable title of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description provided to the agent to guide tool selection.<br/>
        /// This is what the agent sees when deciding which tool to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

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
        /// User-facing documentation describing the tool and how to configure it for an agent.<br/>
        /// Intended for developers and administrators browsing the tool catalog.<br/>
        /// Defaults to the agent-facing description if not explicitly set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation")]
        public string? Documentation { get; set; }

        /// <summary>
        /// Whether the tool is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether this tool is experimental and may change or be removed without notice.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public bool? Experimental { get; set; }

        /// <summary>
        /// Timestamp when the tool was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the tool was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The schema that defines the expected input structure for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// The JSON schema that describes the structure of the tool's output. May be used by clients to<br/>
        /// understand the shape of tool responses and to author `default_output_transform` jq expressions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("default_output_transform")]
        public string? DefaultOutputTransform { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("default_input_transform")]
        public string? DefaultInputTransform { get; set; }

        /// <summary>
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The agent will not be able to change the parameters, nor know those values exist within the tool.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References are resolved at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// - agent.secrets.* - Access agent secrets (masked in audit events)<br/>
        /// - tools.* - Access prior tool outputs (resolved after the dependent tool runs)<br/>
        /// - currentDate - The current date/time in ISO 8601 format<br/>
        /// A bracket index may reference another context value, whose resolved value is used as the lookup key. The inner path may optionally carry a leading $ root marker:<br/>
        /// - Indirect reference: `{"$ref": "agent.secrets[session.metadata.user_id]"}` looks up the per-user secret named by `session.metadata.user_id`<br/>
        /// - Equivalent forms: `agent.secrets[$session.metadata.user_id]` and `agent.secrets[$.session.metadata.user_id]`<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
        /// Example: {"max_results":10}
        /// </summary>
        /// <example>{"max_results":10}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_argument_override")]
        public object? DefaultArgumentOverride { get; set; }

        /// <summary>
        /// Functional category of the tool (e.g., retrieval, artifacts, indexing, utilities, orchestration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// The base tool name without version suffix. Groups versioned variants of the same tool together.<br/>
        /// Example: corpora_search
        /// </summary>
        /// <example>corpora_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineage")]
        public string? Lineage { get; set; }

        /// <summary>
        /// Date-based version identifier in YYYY-MM-DD format. Null for unversioned tools.<br/>
        /// Example: 2026-02-23
        /// </summary>
        /// <example>2026-02-23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Groups this tool belongs to. Tools in the same group form a functional set and should be added or removed together by default.<br/>
        /// Example: [document_ingestion]
        /// </summary>
        /// <example>[document_ingestion]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_groups")]
        public global::System.Collections.Generic.IList<string>? ToolGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="name">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="description">
        /// The description provided to the agent to guide tool selection.<br/>
        /// This is what the agent sees when deciding which tool to use.
        /// </param>
        /// <param name="enabled">
        /// Whether the tool is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="inputSchema">
        /// The schema that defines the expected input structure for the tool.
        /// </param>
        /// <param name="title">
        /// Human-readable title of the tool.
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
        /// <param name="documentation">
        /// User-facing documentation describing the tool and how to configure it for an agent.<br/>
        /// Intended for developers and administrators browsing the tool catalog.<br/>
        /// Defaults to the agent-facing description if not explicitly set.
        /// </param>
        /// <param name="experimental">
        /// Whether this tool is experimental and may change or be removed without notice.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the tool was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the tool was last updated.
        /// </param>
        /// <param name="outputSchema">
        /// The JSON schema that describes the structure of the tool's output. May be used by clients to<br/>
        /// understand the shape of tool responses and to author `default_output_transform` jq expressions.
        /// </param>
        /// <param name="defaultOutputTransform">
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
        /// <param name="defaultInputTransform">
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
        /// <param name="defaultArgumentOverride">
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The agent will not be able to change the parameters, nor know those values exist within the tool.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References are resolved at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// - agent.secrets.* - Access agent secrets (masked in audit events)<br/>
        /// - tools.* - Access prior tool outputs (resolved after the dependent tool runs)<br/>
        /// - currentDate - The current date/time in ISO 8601 format<br/>
        /// A bracket index may reference another context value, whose resolved value is used as the lookup key. The inner path may optionally carry a leading $ root marker:<br/>
        /// - Indirect reference: `{"$ref": "agent.secrets[session.metadata.user_id]"}` looks up the per-user secret named by `session.metadata.user_id`<br/>
        /// - Equivalent forms: `agent.secrets[$session.metadata.user_id]` and `agent.secrets[$.session.metadata.user_id]`<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
        /// Example: {"max_results":10}
        /// </param>
        /// <param name="category">
        /// Functional category of the tool (e.g., retrieval, artifacts, indexing, utilities, orchestration).
        /// </param>
        /// <param name="lineage">
        /// The base tool name without version suffix. Groups versioned variants of the same tool together.<br/>
        /// Example: corpora_search
        /// </param>
        /// <param name="version">
        /// Date-based version identifier in YYYY-MM-DD format. Null for unversioned tools.<br/>
        /// Example: 2026-02-23
        /// </param>
        /// <param name="toolGroups">
        /// Groups this tool belongs to. Tools in the same group form a functional set and should be added or removed together by default.<br/>
        /// Example: [document_ingestion]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolBase(
            string id,
            string name,
            string description,
            bool enabled,
            object inputSchema,
            string? title,
            string? descriptionTemplate,
            string? documentation,
            bool? experimental,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            object? outputSchema,
            string? defaultOutputTransform,
            string? defaultInputTransform,
            object? defaultArgumentOverride,
            string? category,
            string? lineage,
            string? version,
            global::System.Collections.Generic.IList<string>? toolGroups)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DescriptionTemplate = descriptionTemplate;
            this.Documentation = documentation;
            this.Enabled = enabled;
            this.Experimental = experimental;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.DefaultOutputTransform = defaultOutputTransform;
            this.DefaultInputTransform = defaultInputTransform;
            this.DefaultArgumentOverride = defaultArgumentOverride;
            this.Category = category;
            this.Lineage = lineage;
            this.Version = version;
            this.ToolGroups = toolGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBase" /> class.
        /// </summary>
        public ToolBase()
        {
        }

    }
}