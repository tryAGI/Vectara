
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all inline tool configurations on an agent.
    /// </summary>
    public sealed partial class AgentToolConfigurationBase
    {
        /// <summary>
        /// Optional override for the tool's description shown to the LLM. When set, replaces the description from the underlying tool definition.<br/>
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
        /// An optional jq expression applied to the tool's JSON output before it is returned to the LLM.<br/>
        /// Use this to project, filter, or summarize tool output to keep responses concise and on-topic.<br/>
        /// The expression operates on the tool's response JSON and the result replaces the original output.<br/>
        /// If the expression fails to compile or evaluate at runtime, the tool call is reported to the LLM as<br/>
        /// an error so the agent can react.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigurationBase" /> class.
        /// </summary>
        /// <param name="description">
        /// Optional override for the tool's description shown to the LLM. When set, replaces the description from the underlying tool definition.<br/>
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
        /// An optional jq expression applied to the tool's JSON output before it is returned to the LLM.<br/>
        /// Use this to project, filter, or summarize tool output to keep responses concise and on-topic.<br/>
        /// The expression operates on the tool's response JSON and the result replaces the original output.<br/>
        /// If the expression fails to compile or evaluate at runtime, the tool call is reported to the LLM as<br/>
        /// an error so the agent can react.<br/>
        /// Examples:<br/>
        ///   - `.results | map({title, url})` — keep only title/url for each result<br/>
        ///   - `.items[0:5]` — first 5 items<br/>
        ///   - `del(.debug)` — drop a noisy field<br/>
        /// Example: .results | map({title, url})
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolConfigurationBase(
            string? description,
            string? descriptionTemplate,
            string? outputTransform)
        {
            this.Description = description;
            this.DescriptionTemplate = descriptionTemplate;
            this.OutputTransform = outputTransform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolConfigurationBase" /> class.
        /// </summary>
        public AgentToolConfigurationBase()
        {
        }
    }
}