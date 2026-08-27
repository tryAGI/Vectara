
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single likely-working LLM configuration discovered by probing an endpoint.
    /// </summary>
    public sealed partial class DiscoveredLLM
    {
        /// <summary>
        /// The provider type to use when creating this LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.LLMTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.LLMType Type { get; set; }

        /// <summary>
        /// The endpoint URI to use when creating this LLM, normalized and rebuilt for this candidate's dialect (for example `…/v1/chat/completions` for `openai-compatible` and `…/v1/responses` for `openai-responses`). Absent for providers whose endpoint is derived from the credential rather than a URL — Anthropic on Bedrock (region-derived) and, where no base URI was supplied, Vertex.<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.openai.com/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// The provider-specific model identifier this candidate configures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Capabilities inferred for `model` from its name and provider type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vectara.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Whether a live generation round-trip against this exact `model` succeeded. At most three models per detected endpoint are live-tested; other candidates sharing a healthy endpoint are returned with `verified` false and no `verification_error`, and are expected to work.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// When `verified` is false, the reason this model's live test failed. When every live test against the candidate's endpoint failed, the endpoint-wide failure is reported instead. Null for an untested candidate on a healthy endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_error")]
        public string? VerificationError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredLLM" /> class.
        /// </summary>
        /// <param name="type">
        /// The provider type to use when creating this LLM.
        /// </param>
        /// <param name="model">
        /// The provider-specific model identifier this candidate configures.
        /// </param>
        /// <param name="verified">
        /// Whether a live generation round-trip against this exact `model` succeeded. At most three models per detected endpoint are live-tested; other candidates sharing a healthy endpoint are returned with `verified` false and no `verification_error`, and are expected to work.
        /// </param>
        /// <param name="uri">
        /// The endpoint URI to use when creating this LLM, normalized and rebuilt for this candidate's dialect (for example `…/v1/chat/completions` for `openai-compatible` and `…/v1/responses` for `openai-responses`). Absent for providers whose endpoint is derived from the credential rather than a URL — Anthropic on Bedrock (region-derived) and, where no base URI was supplied, Vertex.<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </param>
        /// <param name="capabilities">
        /// Capabilities inferred for `model` from its name and provider type.
        /// </param>
        /// <param name="verificationError">
        /// When `verified` is false, the reason this model's live test failed. When every live test against the candidate's endpoint failed, the endpoint-wide failure is reported instead. Null for an untested candidate on a healthy endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoveredLLM(
            global::Vectara.LLMType type,
            string model,
            bool verified,
            string? uri,
            global::Vectara.LLMCapabilities? capabilities,
            string? verificationError)
        {
            this.Type = type;
            this.Uri = uri;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Capabilities = capabilities;
            this.Verified = verified;
            this.VerificationError = verificationError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredLLM" /> class.
        /// </summary>
        public DiscoveredLLM()
        {
        }

    }
}