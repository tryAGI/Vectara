
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Marks the end of generation. Later events, such as the factual consistency score, may still follow.
    /// </summary>
    public sealed partial class StreamGenerationEnd
    {
        /// <summary>
        /// An object with type `generation_end` marks the end of generation.<br/>
        /// Default Value: generation_end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamGenerationEnd" /> class.
        /// </summary>
        /// <param name="type">
        /// An object with type `generation_end` marks the end of generation.<br/>
        /// Default Value: generation_end
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamGenerationEnd(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamGenerationEnd" /> class.
        /// </summary>
        public StreamGenerationEnd()
        {
        }

    }
}