
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Ceilings on the LLM requests and tokens this agent may consume, counted across every LLM the agent calls. A sub-agent is charged to its own quota, not its parent's.<br/>
    /// Each field is optional; an omitted field applies no limit. Day and month windows are UTC calendar windows. Input tokens are the provider's reported prompt tokens, including cached tokens; output tokens are completion plus reasoning tokens. When a limit is reached the agent's next LLM call is refused: a non-streamed `createAgentInput` request answers `429` with a `Retry-After` header, and a streamed one ends with an `error` event naming the exhausted quota and the seconds until it resets.
    /// </summary>
    public sealed partial class LLMQuota
    {
        /// <summary>
        /// Maximum LLM requests per second.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public long? RequestsPerSecond { get; set; }

        /// <summary>
        /// Maximum input tokens per minute.<br/>
        /// Example: 200000
        /// </summary>
        /// <example>200000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_minute")]
        public long? InputTokensPerMinute { get; set; }

        /// <summary>
        /// Maximum output tokens per minute.<br/>
        /// Example: 50000
        /// </summary>
        /// <example>50000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_minute")]
        public long? OutputTokensPerMinute { get; set; }

        /// <summary>
        /// Maximum input tokens per UTC calendar day.<br/>
        /// Example: 2000000
        /// </summary>
        /// <example>2000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_day")]
        public long? InputTokensPerDay { get; set; }

        /// <summary>
        /// Maximum output tokens per UTC calendar day.<br/>
        /// Example: 100000
        /// </summary>
        /// <example>100000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_day")]
        public long? OutputTokensPerDay { get; set; }

        /// <summary>
        /// Maximum input tokens per UTC calendar month.<br/>
        /// Example: 50000000
        /// </summary>
        /// <example>50000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_month")]
        public long? InputTokensPerMonth { get; set; }

        /// <summary>
        /// Maximum output tokens per UTC calendar month.<br/>
        /// Example: 10000000
        /// </summary>
        /// <example>10000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_month")]
        public long? OutputTokensPerMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMQuota" /> class.
        /// </summary>
        /// <param name="requestsPerSecond">
        /// Maximum LLM requests per second.<br/>
        /// Example: 10
        /// </param>
        /// <param name="inputTokensPerMinute">
        /// Maximum input tokens per minute.<br/>
        /// Example: 200000
        /// </param>
        /// <param name="outputTokensPerMinute">
        /// Maximum output tokens per minute.<br/>
        /// Example: 50000
        /// </param>
        /// <param name="inputTokensPerDay">
        /// Maximum input tokens per UTC calendar day.<br/>
        /// Example: 2000000
        /// </param>
        /// <param name="outputTokensPerDay">
        /// Maximum output tokens per UTC calendar day.<br/>
        /// Example: 100000
        /// </param>
        /// <param name="inputTokensPerMonth">
        /// Maximum input tokens per UTC calendar month.<br/>
        /// Example: 50000000
        /// </param>
        /// <param name="outputTokensPerMonth">
        /// Maximum output tokens per UTC calendar month.<br/>
        /// Example: 10000000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMQuota(
            long? requestsPerSecond,
            long? inputTokensPerMinute,
            long? outputTokensPerMinute,
            long? inputTokensPerDay,
            long? outputTokensPerDay,
            long? inputTokensPerMonth,
            long? outputTokensPerMonth)
        {
            this.RequestsPerSecond = requestsPerSecond;
            this.InputTokensPerMinute = inputTokensPerMinute;
            this.OutputTokensPerMinute = outputTokensPerMinute;
            this.InputTokensPerDay = inputTokensPerDay;
            this.OutputTokensPerDay = outputTokensPerDay;
            this.InputTokensPerMonth = inputTokensPerMonth;
            this.OutputTokensPerMonth = outputTokensPerMonth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMQuota" /> class.
        /// </summary>
        public LLMQuota()
        {
        }

    }
}