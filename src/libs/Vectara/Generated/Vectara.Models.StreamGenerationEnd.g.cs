
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
        public string? Type { get; set; } = "generation_end";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}