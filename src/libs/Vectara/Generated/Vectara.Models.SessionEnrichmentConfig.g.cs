
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Tool calls run at session creation to populate the new session's metadata before the agent's first turn. Each call invokes one of the agent's enrichment-only tool configurations and writes its output into the session metadata. The agent, run conditions, and routing can then read values fetched or computed at session start. Enrichment tools are ordinary entries in the agent's tool_configurations marked enrichment_only, so they are never exposed to the agent's LLM. Enrichment runs for every session the agent creates regardless of trigger, including the API, chat connectors, and schedules. Independent calls run in parallel and a call may consume an earlier call's output. Enrichment is fail-closed: unless a call sets continue_on_error, a failed call aborts session creation and no session is created. The abort status names the failure: 422 for an invalid configuration or a failed transform, 502 for a tool failure, and 504 for a timeout. A jq error raised by the called tool configuration's input_transform or output_transform is a call failure like any other: continue_on_error skips it, and otherwise its message is returned in the error response's messages array.
    /// </summary>
    public sealed partial class SessionEnrichmentConfig
    {
        /// <summary>
        /// When false, enrichment does not run and sessions are created with the metadata provided by the caller.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Ordered tool calls run at session creation. Independent calls run in parallel. A call that references another call's output runs after it.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Vectara.SessionEnrichmentToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnrichmentConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When false, enrichment does not run and sessions are created with the metadata provided by the caller.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="toolCalls">
        /// Ordered tool calls run at session creation. Independent calls run in parallel. A call that references another call's output runs after it.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEnrichmentConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<global::Vectara.SessionEnrichmentToolCall>? toolCalls)
        {
            this.Enabled = enabled;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnrichmentConfig" /> class.
        /// </summary>
        public SessionEnrichmentConfig()
        {
        }

    }
}