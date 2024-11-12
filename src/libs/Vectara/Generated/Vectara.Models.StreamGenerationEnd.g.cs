
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The end of generation. There may still be more information such as the<br/>
    /// factual consistency score, but generation has stopped.
    /// </summary>
    public sealed partial class StreamGenerationEnd
    {
        /// <summary>
        /// Then end of generation will be denoted with an object<br/>
        /// with the type `generation_end`.<br/>
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
        /// Then end of generation will be denoted with an object<br/>
        /// with the type `generation_end`.<br/>
        /// Default Value: generation_end
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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