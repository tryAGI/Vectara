
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredIndexingToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `structured_indexing`.<br/>
        /// Default Value: structured_indexing<br/>
        /// Example: structured_indexing
        /// </summary>
        /// <default>"structured_indexing"</default>
        /// <example>structured_indexing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "structured_indexing";

        /// <summary>
        /// LLM-exposed parameters for the structured indexing tool that indexes documents into the Vectara platform and can be filled in during execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.StructuredIndexingToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredIndexingToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `structured_indexing`.<br/>
        /// Default Value: structured_indexing<br/>
        /// Example: structured_indexing
        /// </param>
        /// <param name="argumentOverride">
        /// LLM-exposed parameters for the structured indexing tool that indexes documents into the Vectara platform and can be filled in during execution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredIndexingToolConfigurationVariant2(
            string type,
            global::Vectara.StructuredIndexingToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredIndexingToolConfigurationVariant2" /> class.
        /// </summary>
        public StructuredIndexingToolConfigurationVariant2()
        {
        }
    }
}