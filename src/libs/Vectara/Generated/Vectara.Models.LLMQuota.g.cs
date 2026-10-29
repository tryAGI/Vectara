
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Ceilings on the LLM requests and tokens this agent may consume, counted across every LLM the agent calls. A sub-agent is charged to its own quota, not its parent's.<br/>
    /// Each field is optional; an omitted field sets no limit of its own. The platform may also apply its own limits. Day and month windows are UTC calendar windows. Input tokens are the provider's reported prompt tokens, including cached tokens; output tokens are completion plus reasoning tokens. When a limit is reached the agent's next LLM call is refused: a non-streamed `createAgentInput` request answers `429` with a `Retry-After` header, and a streamed one ends with an `error` event naming the exhausted quota and the seconds until it resets.
    /// </summary>
    public sealed partial class LLMQuota
    {
        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum LLM requests per second.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? RequestsPerSecond { get; set; }

        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum input tokens per minute.<br/>
        /// Example: 200000
        /// </summary>
        /// <example>200000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_minute")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? InputTokensPerMinute { get; set; }

        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum output tokens per minute.<br/>
        /// Example: 50000
        /// </summary>
        /// <example>50000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_minute")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? OutputTokensPerMinute { get; set; }

        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum input tokens per UTC calendar day.<br/>
        /// Example: 2000000
        /// </summary>
        /// <example>2000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_day")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? InputTokensPerDay { get; set; }

        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum output tokens per UTC calendar day.<br/>
        /// Example: 100000
        /// </summary>
        /// <example>100000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_day")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? OutputTokensPerDay { get; set; }

        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum input tokens per UTC calendar month.<br/>
        /// Example: 50000000
        /// </summary>
        /// <example>50000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_month")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? InputTokensPerMonth { get; set; }

        /// <summary>
        /// Deprecated. This field will be removed in a future release. The platform still enforces it until then. Contact Vectara support to set LLM request and token limits. Maximum output tokens per UTC calendar month.<br/>
        /// Example: 10000000
        /// </summary>
        /// <example>10000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_month")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public long? OutputTokensPerMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}