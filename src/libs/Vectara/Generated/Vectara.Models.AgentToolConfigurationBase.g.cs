
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all inline tool configurations on an agent.
    /// </summary>
    public sealed partial class AgentToolConfigurationBase
    {
        /// <summary>
        /// Optional override for the tool's description shown to the agent. When set, replaces the description from the underlying tool definition.<br/>
        /// Example: Search the customer support knowledge base
        /// </summary>
        /// <example>Search the customer support knowledge base</example>
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
        /// An optional jq expression applied to the tool's JSON output before it is returned to the agent.<br/>
        /// Use this to project, filter, or summarize tool output to keep responses concise and on-topic.<br/>
        /// The expression operates on the tool's response JSON and the result replaces the original output.<br/>
        /// If the expression fails to compile or evaluate at runtime, the tool call is reported to the agent<br/>
        /// as an error so the agent can react.<br/>
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
        /// An optional jq expression applied to the tool's input after argument overrides have been merged<br/>
        /// with the agent's arguments and before the tool is invoked. Use this to inject server-side<br/>
        /// context (session metadata, agent secrets) into the tool input, or to reshape the agent's<br/>
        /// arguments.<br/>
        /// The expression receives the standard runtime context — the same `agent`, `session`, `tools`,<br/>
        /// and `currentDate` values exposed to `argument_override` `$ref`s (see `ArgumentOverrideDescription`),<br/>
        /// plus an `args` field containing the merged tool input. The output of the expression replaces<br/>
        /// `args` as the tool input. The pre-transform `args` is what appears in audit events (with<br/>
        /// secrets masked); the post-transform value goes only to the tool. If the expression fails to<br/>
        /// compile or evaluate, the tool call is reported to the agent as an error.<br/>
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
        /// Initializes a new instance of the <see cref="AgentToolConfigurationBase" /> class.
        /// </summary>
        /// <param name="description">
        /// Optional override for the tool's description shown to the agent. When set, replaces the description from the underlying tool definition.<br/>
        /// Example: Search the customer support knowledge base
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
        /// <param name="outputTransform">
        /// An optional jq expression applied to the tool's JSON output before it is returned to the agent.<br/>
        /// Use this to project, filter, or summarize tool output to keep responses concise and on-topic.<br/>
        /// The expression operates on the tool's response JSON and the result replaces the original output.<br/>
        /// If the expression fails to compile or evaluate at runtime, the tool call is reported to the agent<br/>
        /// as an error so the agent can react.<br/>
        /// Examples:<br/>
        ///   - `.results | map({title, url})` — keep only title/url for each result<br/>
        ///   - `.items[0:5]` — first 5 items<br/>
        ///   - `del(.debug)` — drop a noisy field<br/>
        /// Example: .results | map({title, url})
        /// </param>
        /// <param name="inputTransform">
        /// An optional jq expression applied to the tool's input after argument overrides have been merged<br/>
        /// with the agent's arguments and before the tool is invoked. Use this to inject server-side<br/>
        /// context (session metadata, agent secrets) into the tool input, or to reshape the agent's<br/>
        /// arguments.<br/>
        /// The expression receives the standard runtime context — the same `agent`, `session`, `tools`,<br/>
        /// and `currentDate` values exposed to `argument_override` `$ref`s (see `ArgumentOverrideDescription`),<br/>
        /// plus an `args` field containing the merged tool input. The output of the expression replaces<br/>
        /// `args` as the tool input. The pre-transform `args` is what appears in audit events (with<br/>
        /// secrets masked); the post-transform value goes only to the tool. If the expression fails to<br/>
        /// compile or evaluate, the tool call is reported to the agent as an error.<br/>
        /// Examples:<br/>
        ///   - `.args + { auth: ("Bearer " + .agent.secrets.token) }` — inject a bearer header<br/>
        ///   - `.args | .corpus_key = .session.metadata.corpus_key` — pull a corpus key from session metadata<br/>
        ///   - `.args | .query = (.args.query + " " + .session.metadata.query_suffix)` — augment the agent's query<br/>
        /// Example: .args + { auth: ("Bearer " + .agent.secrets.token) }
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolConfigurationBase(
            string? description,
            string? descriptionTemplate,
            string? outputTransform,
            string? inputTransform)
        {
            this.Description = description;
            this.DescriptionTemplate = descriptionTemplate;
            this.OutputTransform = outputTransform;
            this.InputTransform = inputTransform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigurationBase" /> class.
        /// </summary>
        public AgentToolConfigurationBase()
        {
        }

    }
}