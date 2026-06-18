
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Input token usage details.
    /// </summary>
    public sealed partial class InputTokens
    {
        /// <summary>
        /// Number of input tokens consumed by the most recent agent call, including cached tokens.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// Subset of count served from the prompt cache. Omitted when no input tokens were served from the cache.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public long? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokens" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of input tokens consumed by the most recent agent call, including cached tokens.<br/>
        /// Example: 120
        /// </param>
        /// <param name="cachedTokens">
        /// Subset of count served from the prompt cache. Omitted when no input tokens were served from the cache.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputTokens(
            long? count,
            long? cachedTokens)
        {
            this.Count = count;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokens" /> class.
        /// </summary>
        public InputTokens()
        {
        }

    }
}