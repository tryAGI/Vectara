
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Token usage of the session's most recent agent call, reflecting current context window consumption. Not a running total across calls.
    /// </summary>
    public sealed partial class SessionContextUsage
    {
        /// <summary>
        /// Input token usage details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public global::Vectara.InputTokens? InputTokens { get; set; }

        /// <summary>
        /// Output token usage details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public global::Vectara.OutputTokens? OutputTokens { get; set; }

        /// <summary>
        /// Input plus output tokens of the most recent agent call. Can be used with model_context_window to calculate context utilization percentage.<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// Maximum context window size in tokens for the model used by this session. Can be used with total_tokens to calculate context utilization percentage.<br/>
        /// Example: 200000
        /// </summary>
        /// <example>200000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_context_window")]
        public long? ModelContextWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionContextUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Input token usage details.
        /// </param>
        /// <param name="outputTokens">
        /// Output token usage details.
        /// </param>
        /// <param name="totalTokens">
        /// Input plus output tokens of the most recent agent call. Can be used with model_context_window to calculate context utilization percentage.<br/>
        /// Example: 150
        /// </param>
        /// <param name="modelContextWindow">
        /// Maximum context window size in tokens for the model used by this session. Can be used with total_tokens to calculate context utilization percentage.<br/>
        /// Example: 200000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionContextUsage(
            global::Vectara.InputTokens? inputTokens,
            global::Vectara.OutputTokens? outputTokens,
            long? totalTokens,
            long? modelContextWindow)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.ModelContextWindow = modelContextWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionContextUsage" /> class.
        /// </summary>
        public SessionContextUsage()
        {
        }

    }
}