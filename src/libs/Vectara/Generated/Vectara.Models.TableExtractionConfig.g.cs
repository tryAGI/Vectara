
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for table extraction from the document. This is optional and if not provided, the platform does not extract tables from PDF files.
    /// </summary>
    public sealed partial class TableExtractionConfig
    {
        /// <summary>
        /// If set to true, the platform will attempt to extract tables from the document. The tables will be indexed as separate document parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_tables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExtractTables { get; set; }

        /// <summary>
        /// Specification for which table extractor to use. If not specified, the platform uses the default extractor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extractor")]
        public global::Vectara.TableExtractorSpec? Extractor { get; set; }

        /// <summary>
        /// Specification for which generation to use during table summarization. If not specified, the platform uses the default summarizer. All parameters are optional and overrides the default values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::Vectara.TableGenerationSpec? Generation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractionConfig" /> class.
        /// </summary>
        /// <param name="extractTables">
        /// If set to true, the platform will attempt to extract tables from the document. The tables will be indexed as separate document parts.
        /// </param>
        /// <param name="extractor">
        /// Specification for which table extractor to use. If not specified, the platform uses the default extractor.
        /// </param>
        /// <param name="generation">
        /// Specification for which generation to use during table summarization. If not specified, the platform uses the default summarizer. All parameters are optional and overrides the default values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableExtractionConfig(
            bool extractTables,
            global::Vectara.TableExtractorSpec? extractor,
            global::Vectara.TableGenerationSpec? generation)
        {
            this.ExtractTables = extractTables;
            this.Extractor = extractor;
            this.Generation = generation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractionConfig" /> class.
        /// </summary>
        public TableExtractionConfig()
        {
        }
    }
}