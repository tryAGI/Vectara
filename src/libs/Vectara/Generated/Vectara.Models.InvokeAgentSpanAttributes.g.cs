
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for an invoke_agent span.
    /// </summary>
    public sealed partial class InvokeAgentSpanAttributes
    {
        /// <summary>
        /// The LLM model used in this invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Total input tokens consumed across all LLM calls in this invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public long? InputTokens { get; set; }

        /// <summary>
        /// Total output tokens produced across all LLM calls in this invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// Number of input tokens read from cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public long? CacheReadInputTokens { get; set; }

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
        /// The name of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// The description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_description")]
        public string? AgentDescription { get; set; }

        /// <summary>
        /// The requested output format of the agent invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.InvokeAgentSpanAttributesOutputTypeJsonConverter))]
        public global::Vectara.InvokeAgentSpanAttributesOutputType? OutputType { get; set; }

        /// <summary>
        /// The event ID of the input message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_event_id")]
        public string? InputEventId { get; set; }

        /// <summary>
        /// The event ID of the output message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_event_id")]
        public string? OutputEventId { get; set; }

        /// <summary>
        /// Metadata for files uploaded with the input, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_files")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentTraceInputFile>? InputFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAgentSpanAttributes" /> class.
        /// </summary>
        /// <param name="model">
        /// The LLM model used in this invocation.
        /// </param>
        /// <param name="inputTokens">
        /// Total input tokens consumed across all LLM calls in this invocation.
        /// </param>
        /// <param name="outputTokens">
        /// Total output tokens produced across all LLM calls in this invocation.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Number of input tokens read from cache.
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
        /// <param name="agentName">
        /// The name of the agent.
        /// </param>
        /// <param name="agentDescription">
        /// The description of the agent.
        /// </param>
        /// <param name="outputType">
        /// The requested output format of the agent invocation.
        /// </param>
        /// <param name="inputEventId">
        /// The event ID of the input message.
        /// </param>
        /// <param name="outputEventId">
        /// The event ID of the output message.
        /// </param>
        /// <param name="inputFiles">
        /// Metadata for files uploaded with the input, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvokeAgentSpanAttributes(
            string? model,
            long? inputTokens,
            long? outputTokens,
            long? cacheReadInputTokens,
            double? temperature,
            long? maxTokens,
            string? providerName,
            string? agentName,
            string? agentDescription,
            global::Vectara.InvokeAgentSpanAttributesOutputType? outputType,
            string? inputEventId,
            string? outputEventId,
            global::System.Collections.Generic.IList<global::Vectara.AgentTraceInputFile>? inputFiles)
        {
            this.Model = model;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ProviderName = providerName;
            this.AgentName = agentName;
            this.AgentDescription = agentDescription;
            this.OutputType = outputType;
            this.InputEventId = inputEventId;
            this.OutputEventId = outputEventId;
            this.InputFiles = inputFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeAgentSpanAttributes" /> class.
        /// </summary>
        public InvokeAgentSpanAttributes()
        {
        }
    }
}