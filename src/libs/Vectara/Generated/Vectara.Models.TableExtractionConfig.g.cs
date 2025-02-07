
#nullable enable

namespace Vectara
{
    /// <summary>
    /// (Optional) Configuration for table extraction from the document.
    /// </summary>
    public sealed partial class TableExtractionConfig
    {
        /// <summary>
        /// If set to true, the platform will attempt to extract tables from the document.<br/>
        /// The tables will be indexed as separate document parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_tables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExtractTables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractionConfig" /> class.
        /// </summary>
        /// <param name="extractTables">
        /// If set to true, the platform will attempt to extract tables from the document.<br/>
        /// The tables will be indexed as separate document parts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableExtractionConfig(
            bool extractTables)
        {
            this.ExtractTables = extractTables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractionConfig" /> class.
        /// </summary>
        public TableExtractionConfig()
        {
        }
    }
}