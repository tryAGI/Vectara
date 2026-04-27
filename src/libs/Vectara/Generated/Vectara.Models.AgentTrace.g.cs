
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A summary of an agent trace representing one complete agent invocation.
    /// </summary>
    public sealed partial class AgentTrace
    {
        /// <summary>
        /// The unique identifier of the trace.<br/>
        /// Example: 0af7651916cd43dd8448eb211c80319c
        /// </summary>
        /// <example>0af7651916cd43dd8448eb211c80319c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        public string? AgentKey { get; set; }

        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// The time the trace started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Total duration of the trace in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public long? DurationMs { get; set; }

        /// <summary>
        /// The final status of the trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentTraceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentTraceStatus Status { get; set; }

        /// <summary>
        /// Total input tokens consumed across all spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public long? InputTokens { get; set; }

        /// <summary>
        /// Total output tokens produced across all spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTrace" /> class.
        /// </summary>
        /// <param name="traceId">
        /// The unique identifier of the trace.<br/>
        /// Example: 0af7651916cd43dd8448eb211c80319c
        /// </param>
        /// <param name="startedAt">
        /// The time the trace started.
        /// </param>
        /// <param name="status">
        /// The final status of the trace.
        /// </param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="durationMs">
        /// Total duration of the trace in milliseconds.
        /// </param>
        /// <param name="inputTokens">
        /// Total input tokens consumed across all spans.
        /// </param>
        /// <param name="outputTokens">
        /// Total output tokens produced across all spans.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTrace(
            string traceId,
            global::System.DateTime startedAt,
            global::Vectara.AgentTraceStatus status,
            string? agentKey,
            string? sessionKey,
            long? durationMs,
            long? inputTokens,
            long? outputTokens)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.AgentKey = agentKey;
            this.SessionKey = sessionKey;
            this.StartedAt = startedAt;
            this.DurationMs = durationMs;
            this.Status = status;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTrace" /> class.
        /// </summary>
        public AgentTrace()
        {
        }
    }
}