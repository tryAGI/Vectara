
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single tool call run during session enrichment. It names one of the agent's enrichment-only tool configurations and supplies the arguments to invoke it with. The tool's own configuration, including its argument defaults and output_transform, lives on the tool configuration rather than on the call. Because enrichment runs with no model to fill arguments in, the arguments must include every required parameter of the called tool, either as a literal value or as a reference to an earlier call's output. A call that omits a required parameter is rejected when the agent is created or updated.
    /// </summary>
    public sealed partial class SessionEnrichmentToolCall
    {
        /// <summary>
        /// Name of the tool configuration to call. Must name one of the agent's tool_configurations whose enrichment_only is true. A later tool call references an earlier call's output as tools.&lt;tool&gt;.outputs.latest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// Arguments to invoke the tool with. These may set only the parameters that the tool definition does not already fix through its own configured argument_override. A parameter fixed by the tool cannot be set per call, so naming one here is rejected when the agent is created or updated. Because enrichment runs with no model to fill arguments in, these arguments together with the parameters fixed by the tool must cover every required parameter of the tool. Each value is either a literal or a $ref object that resolves against session or agent metadata or an earlier call's output as tools.&lt;name&gt;.outputs.latest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Dotted metadata path the tool's output is written to, after the tool's own configured output_transform is applied. Outputs are written to the session metadata in call order. Later writes to a path replaces any value written earlier at that path. A call without a target path is compute only, so later calls can reference its output but nothing is written to the metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_target_path")]
        public string? MetadataTargetPath { get; set; }

        /// <summary>
        /// Seconds the call may run before it is treated as a failed call.<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// When true a failure of this call is ignored and its target is left unset. Otherwise a call failure aborts session creation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_on_error")]
        public bool? ContinueOnError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnrichmentToolCall" /> class.
        /// </summary>
        /// <param name="tool">
        /// Name of the tool configuration to call. Must name one of the agent's tool_configurations whose enrichment_only is true. A later tool call references an earlier call's output as tools.&lt;tool&gt;.outputs.latest.
        /// </param>
        /// <param name="arguments">
        /// Arguments to invoke the tool with. These may set only the parameters that the tool definition does not already fix through its own configured argument_override. A parameter fixed by the tool cannot be set per call, so naming one here is rejected when the agent is created or updated. Because enrichment runs with no model to fill arguments in, these arguments together with the parameters fixed by the tool must cover every required parameter of the tool. Each value is either a literal or a $ref object that resolves against session or agent metadata or an earlier call's output as tools.&lt;name&gt;.outputs.latest.
        /// </param>
        /// <param name="metadataTargetPath">
        /// Dotted metadata path the tool's output is written to, after the tool's own configured output_transform is applied. Outputs are written to the session metadata in call order. Later writes to a path replaces any value written earlier at that path. A call without a target path is compute only, so later calls can reference its output but nothing is written to the metadata.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Seconds the call may run before it is treated as a failed call.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="continueOnError">
        /// When true a failure of this call is ignored and its target is left unset. Otherwise a call failure aborts session creation.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEnrichmentToolCall(
            string tool,
            object? arguments,
            string? metadataTargetPath,
            int? timeoutSeconds,
            bool? continueOnError)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Arguments = arguments;
            this.MetadataTargetPath = metadataTargetPath;
            this.TimeoutSeconds = timeoutSeconds;
            this.ContinueOnError = continueOnError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnrichmentToolCall" /> class.
        /// </summary>
        public SessionEnrichmentToolCall()
        {
        }

    }
}