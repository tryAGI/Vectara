
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A table extractor extracts tabular data from documents during indexing.
    /// </summary>
    public sealed partial class TableExtractor
    {
        /// <summary>
        /// The name of the table extractor.<br/>
        /// Example: textract
        /// </summary>
        /// <example>textract</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates whether this is the default extractor. The platform uses the default extractor when the indexing request does not specify one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The description of the table extractor.<br/>
        /// Example: Uses the AWS Textract service to extract tables.
        /// </summary>
        /// <example>Uses the AWS Textract service to extract tables.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Specification for the generation settings for table summarization. If not specified, the platform uses the default summarizer. All parameters are optional. Specified parameters override the default values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::Vectara.TableGenerationSpec? Generation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractor" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the table extractor.<br/>
        /// Example: textract
        /// </param>
        /// <param name="isDefault">
        /// Indicates whether this is the default extractor. The platform uses the default extractor when the indexing request does not specify one.
        /// </param>
        /// <param name="description">
        /// The description of the table extractor.<br/>
        /// Example: Uses the AWS Textract service to extract tables.
        /// </param>
        /// <param name="generation">
        /// Specification for the generation settings for table summarization. If not specified, the platform uses the default summarizer. All parameters are optional. Specified parameters override the default values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableExtractor(
            string? name,
            bool? isDefault,
            string? description,
            global::Vectara.TableGenerationSpec? generation)
        {
            this.Name = name;
            this.IsDefault = isDefault;
            this.Description = description;
            this.Generation = generation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractor" /> class.
        /// </summary>
        public TableExtractor()
        {
        }

    }
}