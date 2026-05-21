
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Decrypted content of a thinking span.
    /// </summary>
    public sealed partial class ThinkingSpanContent
    {
        /// <summary>
        /// Extended thinking content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingSpanContent" /> class.
        /// </summary>
        /// <param name="thinking">
        /// Extended thinking content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingSpanContent(
            string? thinking)
        {
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingSpanContent" /> class.
        /// </summary>
        public ThinkingSpanContent()
        {
        }

    }
}