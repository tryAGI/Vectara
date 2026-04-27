
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for a chat (LLM completion) span.
    /// </summary>
    public sealed partial class ChatSpanAttributes
    {
        /// <summary>
        /// The LLM model used for this completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Number of input tokens in this completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public long? InputTokens { get; set; }

        /// <summary>
        /// Number of output tokens in this completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// Number of input tokens read from cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public long? CacheReadInputTokens { get; set; }

        /// <summary>
        /// The reasons the LLM generation finished, one per returned completion. Typically a single-element array<br/>
        /// (e.g., `["stop"]`), but providers may return multiple entries when batching completions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reasons")]
        public global::System.Collections.Generic.IList<string>? FinishReasons { get; set; }

        /// <summary>
        /// The temperature parameter used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum tokens parameter used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public long? MaxTokens { get; set; }

        /// <summary>
        /// The LLM provider name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// The provider response identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSpanAttributes" /> class.
        /// </summary>
        /// <param name="model">
        /// The LLM model used for this completion.
        /// </param>
        /// <param name="inputTokens">
        /// Number of input tokens in this completion.
        /// </param>
        /// <param name="outputTokens">
        /// Number of output tokens in this completion.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Number of input tokens read from cache.
        /// </param>
        /// <param name="finishReasons">
        /// The reasons the LLM generation finished, one per returned completion. Typically a single-element array<br/>
        /// (e.g., `["stop"]`), but providers may return multiple entries when batching completions.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter used for generation.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum tokens parameter used for generation.
        /// </param>
        /// <param name="providerName">
        /// The LLM provider name.
        /// </param>
        /// <param name="responseId">
        /// The provider response identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSpanAttributes(
            string? model,
            long? inputTokens,
            long? outputTokens,
            long? cacheReadInputTokens,
            global::System.Collections.Generic.IList<string>? finishReasons,
            double? temperature,
            long? maxTokens,
            string? providerName,
            string? responseId)
        {
            this.Model = model;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.FinishReasons = finishReasons;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ProviderName = providerName;
            this.ResponseId = responseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSpanAttributes" /> class.
        /// </summary>
        public ChatSpanAttributes()
        {
        }
    }
}