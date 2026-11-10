
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A tool call the platform makes each time the session transitions into a step or starts at it. It names one of the agent's tool configurations and supplies the arguments to invoke it with. The call is recorded in the session as a `tool_input` event followed by a `tool_output` event, the same events a call made by the LLM produces. The LLM does not see the call or its output.
    /// </summary>
    public sealed partial class AgentStepToolCall
    {
        /// <summary>
        /// Name of the tool configuration to call. Must name one of the agent's tool_configurations whose enrichment_only is false and that the step's allowed_tools permits. A later call in the same step references this call's output as `tools.&lt;tool_config_name&gt;.outputs.latest`.<br/>
        /// Example: document_analyze
        /// </summary>
        /// <example>document_analyze</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// Arguments to invoke the tool with. These may set only the parameters that the tool configuration does not already fix through its argument_override. Naming a fixed parameter is rejected when the agent is created or updated. No LLM fills in arguments, so these arguments, together with the parameters the tool configuration fixes, must cover every required parameter of the tool. A call that omits one fails when it runs. Each value is either a literal or a `$ref` object, resolved when the call runs against the same context as a reference in argument_override. That context includes the output of an earlier call in the same step as `tools.&lt;tool_config_name&gt;.outputs.latest`.<br/>
        /// Example: {"artifact_id":"art_pdf_abc123","chunking":{"strategy":"hierarchical"}}
        /// </summary>
        /// <example>{"artifact_id":"art_pdf_abc123","chunking":{"strategy":"hierarchical"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// What a failure of this call does. The failure is recorded as the call's `tool_output`, whose `error` field holds the failure message and which later calls and next_steps conditions read as `tools.&lt;tool_config_name&gt;.outputs.latest`. Defaults to `end_turn`. Session enrichment tool calls use `continue_on_error` instead.<br/>
        /// Default Value: {"type":"end_turn"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_failure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.StepToolCallOnFailureJsonConverter))]
        public global::Vectara.StepToolCallOnFailure? OnFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStepToolCall" /> class.
        /// </summary>
        /// <param name="tool">
        /// Name of the tool configuration to call. Must name one of the agent's tool_configurations whose enrichment_only is false and that the step's allowed_tools permits. A later call in the same step references this call's output as `tools.&lt;tool_config_name&gt;.outputs.latest`.<br/>
        /// Example: document_analyze
        /// </param>
        /// <param name="arguments">
        /// Arguments to invoke the tool with. These may set only the parameters that the tool configuration does not already fix through its argument_override. Naming a fixed parameter is rejected when the agent is created or updated. No LLM fills in arguments, so these arguments, together with the parameters the tool configuration fixes, must cover every required parameter of the tool. A call that omits one fails when it runs. Each value is either a literal or a `$ref` object, resolved when the call runs against the same context as a reference in argument_override. That context includes the output of an earlier call in the same step as `tools.&lt;tool_config_name&gt;.outputs.latest`.<br/>
        /// Example: {"artifact_id":"art_pdf_abc123","chunking":{"strategy":"hierarchical"}}
        /// </param>
        /// <param name="onFailure">
        /// What a failure of this call does. The failure is recorded as the call's `tool_output`, whose `error` field holds the failure message and which later calls and next_steps conditions read as `tools.&lt;tool_config_name&gt;.outputs.latest`. Defaults to `end_turn`. Session enrichment tool calls use `continue_on_error` instead.<br/>
        /// Default Value: {"type":"end_turn"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStepToolCall(
            string tool,
            object? arguments,
            global::Vectara.StepToolCallOnFailure? onFailure)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Arguments = arguments;
            this.OnFailure = onFailure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStepToolCall" /> class.
        /// </summary>
        public AgentStepToolCall()
        {
        }

    }
}