
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common properties shared by all agent trace span types.
    /// </summary>
    public sealed partial class AgentTraceSpanBase
    {
        /// <summary>
        /// The unique identifier of the span.<br/>
        /// Example: b7ad6b7169203331
        /// </summary>
        /// <example>b7ad6b7169203331</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// The identifier of the parent span, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_span_id")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// The identifier of the trace this span belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// The time this span started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Duration of this span in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public long? DurationMs { get; set; }

        /// <summary>
        /// The status of an agent trace span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentTraceSpanStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentTraceSpanStatus Status { get; set; }

        /// <summary>
        /// Error message if the span status is error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// The name of the agent step active when this span was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_name")]
        public string? StepName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceSpanBase" /> class.
        /// </summary>
        /// <param name="spanId">
        /// The unique identifier of the span.<br/>
        /// Example: b7ad6b7169203331
        /// </param>
        /// <param name="traceId">
        /// The identifier of the trace this span belongs to.
        /// </param>
        /// <param name="startedAt">
        /// The time this span started.
        /// </param>
        /// <param name="status">
        /// The status of an agent trace span.
        /// </param>
        /// <param name="parentSpanId">
        /// The identifier of the parent span, if any.
        /// </param>
        /// <param name="durationMs">
        /// Duration of this span in milliseconds.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the span status is error.
        /// </param>
        /// <param name="stepName">
        /// The name of the agent step active when this span was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTraceSpanBase(
            string spanId,
            string traceId,
            global::System.DateTime startedAt,
            global::Vectara.AgentTraceSpanStatus status,
            string? parentSpanId,
            long? durationMs,
            string? errorMessage,
            string? stepName)
        {
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentSpanId = parentSpanId;
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.StartedAt = startedAt;
            this.DurationMs = durationMs;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.StepName = stepName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceSpanBase" /> class.
        /// </summary>
        public AgentTraceSpanBase()
        {
        }

    }
}