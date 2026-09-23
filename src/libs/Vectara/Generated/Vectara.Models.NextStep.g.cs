
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A conditional transition to another step.
    /// </summary>
    public sealed partial class NextStep
    {
        /// <summary>
        /// UserFn expression evaluating to boolean.<br/>
        /// Uses the `get()` function with JSONPath to access the step transition context.<br/>
        /// See https://docs.vectara.com/docs/reference/userfn-language for the UserFn language reference.<br/>
        /// Omit for catch-all/default routing.<br/>
        /// The context available to `get()` has the following shape:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "agent": {<br/>
        ///     "name": "...",<br/>
        ///     "key": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "session": {<br/>
        ///     "key": "...",<br/>
        ///     "name": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "currentDate": "2024-01-15T10:35:00Z",<br/>
        ///   "tools": {<br/>
        ///     "&lt;tool_config_name&gt;": {<br/>
        ///       "outputs": {<br/>
        ///         "latest": { ... }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "output": { "text": "..." }<br/>
        /// }<br/>
        /// ```<br/>
        /// - `$.agent.key`, `$.agent.name`, `$.agent.description`, `$.agent.metadata.&lt;key&gt;` — the agent<br/>
        /// - `$.session.key`, `$.session.name`, `$.session.description`, `$.session.metadata.&lt;key&gt;` — the session<br/>
        /// - `$.currentDate` — the evaluation time, ISO 8601<br/>
        /// - `$.tools.&lt;tool_config_name&gt;.outputs.latest.&lt;field&gt;` — latest tool output fields, present only for tools that produced output<br/>
        /// - `$.output.text` — agent text output (when output_parser is `default`)<br/>
        /// - `$.output.&lt;field&gt;` — agent structured output fields (when output_parser is `structured`)<br/>
        /// Example: get('$.output.intent') == 'sales'
        /// </summary>
        /// <example>get('$.output.intent') == 'sales'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// Name of the step to transition to.<br/>
        /// Must reference a step defined in the agent's steps list.<br/>
        /// Example: sales_handler
        /// </summary>
        /// <example>sales_handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NextStep" /> class.
        /// </summary>
        /// <param name="stepName">
        /// Name of the step to transition to.<br/>
        /// Must reference a step defined in the agent's steps list.<br/>
        /// Example: sales_handler
        /// </param>
        /// <param name="condition">
        /// UserFn expression evaluating to boolean.<br/>
        /// Uses the `get()` function with JSONPath to access the step transition context.<br/>
        /// See https://docs.vectara.com/docs/reference/userfn-language for the UserFn language reference.<br/>
        /// Omit for catch-all/default routing.<br/>
        /// The context available to `get()` has the following shape:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "agent": {<br/>
        ///     "name": "...",<br/>
        ///     "key": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "session": {<br/>
        ///     "key": "...",<br/>
        ///     "name": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "currentDate": "2024-01-15T10:35:00Z",<br/>
        ///   "tools": {<br/>
        ///     "&lt;tool_config_name&gt;": {<br/>
        ///       "outputs": {<br/>
        ///         "latest": { ... }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "output": { "text": "..." }<br/>
        /// }<br/>
        /// ```<br/>
        /// - `$.agent.key`, `$.agent.name`, `$.agent.description`, `$.agent.metadata.&lt;key&gt;` — the agent<br/>
        /// - `$.session.key`, `$.session.name`, `$.session.description`, `$.session.metadata.&lt;key&gt;` — the session<br/>
        /// - `$.currentDate` — the evaluation time, ISO 8601<br/>
        /// - `$.tools.&lt;tool_config_name&gt;.outputs.latest.&lt;field&gt;` — latest tool output fields, present only for tools that produced output<br/>
        /// - `$.output.text` — agent text output (when output_parser is `default`)<br/>
        /// - `$.output.&lt;field&gt;` — agent structured output fields (when output_parser is `structured`)<br/>
        /// Example: get('$.output.intent') == 'sales'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NextStep(
            string stepName,
            string? condition)
        {
            this.Condition = condition;
            this.StepName = stepName ?? throw new global::System.ArgumentNullException(nameof(stepName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NextStep" /> class.
        /// </summary>
        public NextStep()
        {
        }

    }
}