
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The entry in a step's tool_calls that a tool call was made from. Set on a `tool_input` event when the platform made the call for a step rather than the LLM; the LLM does not see such a call or its output.
    /// </summary>
    public sealed partial class StepToolCallSource
    {
        /// <summary>
        /// Name of the step whose tool_calls contains the call.<br/>
        /// Example: ingest
        /// </summary>
        /// <example>ingest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepName { get; set; }

        /// <summary>
        /// Position of the call in the step's tool_calls, starting at 0.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallSource" /> class.
        /// </summary>
        /// <param name="stepName">
        /// Name of the step whose tool_calls contains the call.<br/>
        /// Example: ingest
        /// </param>
        /// <param name="callIndex">
        /// Position of the call in the step's tool_calls, starting at 0.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepToolCallSource(
            string stepName,
            int callIndex)
        {
            this.StepName = stepName ?? throw new global::System.ArgumentNullException(nameof(stepName));
            this.CallIndex = callIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallSource" /> class.
        /// </summary>
        public StepToolCallSource()
        {
        }

    }
}