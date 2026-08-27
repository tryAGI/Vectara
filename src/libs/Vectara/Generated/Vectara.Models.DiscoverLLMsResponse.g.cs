
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The model configurations discovered by probing the endpoint, most-likely-to-work first.
    /// </summary>
    public sealed partial class DiscoverLLMsResponse
    {
        /// <summary>
        /// Discovered configurations, one per (provider type, model). Candidates that were successfully live-tested (`verified: true`) are listed first. Submit any candidate's fields — together with the same credential you passed in — to `POST /v2/llms` to create the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.DiscoveredLLM> Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverLLMsResponse" /> class.
        /// </summary>
        /// <param name="candidates">
        /// Discovered configurations, one per (provider type, model). Candidates that were successfully live-tested (`verified: true`) are listed first. Submit any candidate's fields — together with the same credential you passed in — to `POST /v2/llms` to create the LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoverLLMsResponse(
            global::System.Collections.Generic.IList<global::Vectara.DiscoveredLLM> candidates)
        {
            this.Candidates = candidates ?? throw new global::System.ArgumentNullException(nameof(candidates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverLLMsResponse" /> class.
        /// </summary>
        public DiscoverLLMsResponse()
        {
        }

    }
}