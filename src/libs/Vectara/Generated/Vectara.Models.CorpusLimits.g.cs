
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorpusLimits
    {
        /// <summary>
        /// The number of documents contained in the corpus.<br/>
        /// Example: 8L
        /// </summary>
        /// <example>8L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_docs")]
        public long? UsedDocs { get; set; }

        /// <summary>
        /// The number of document parts contained in the corpus.<br/>
        /// Example: 3748L
        /// </summary>
        /// <example>3748L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_parts")]
        public long? UsedParts { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system. The number of bytes contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 795790L
        /// </summary>
        /// <example>795790L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        public long? UsedBytes { get; set; }

        /// <summary>
        /// The number of characters contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 1839847L
        /// </summary>
        /// <example>1839847L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_characters")]
        public long? UsedCharacters { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system. The maximum number of bytes the corpus can be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_bytes")]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// The maximum size that metadata can be on documents.<br/>
        /// Example: 10485760L
        /// </summary>
        /// <example>10485760L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_metadata_bytes")]
        public long? MaxMetadataBytes { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system. The maximum per-second addition of new documents to corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_rate")]
        public long? IndexRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusLimits" /> class.
        /// </summary>
        /// <param name="usedDocs">
        /// The number of documents contained in the corpus.<br/>
        /// Example: 8L
        /// </param>
        /// <param name="usedParts">
        /// The number of document parts contained in the corpus.<br/>
        /// Example: 3748L
        /// </param>
        /// <param name="usedBytes">
        /// NOTE: This field is currently not populated by the system. The number of bytes contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 795790L
        /// </param>
        /// <param name="usedCharacters">
        /// The number of characters contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 1839847L
        /// </param>
        /// <param name="maxBytes">
        /// NOTE: This field is currently not populated by the system. The maximum number of bytes the corpus can be.
        /// </param>
        /// <param name="maxMetadataBytes">
        /// The maximum size that metadata can be on documents.<br/>
        /// Example: 10485760L
        /// </param>
        /// <param name="indexRate">
        /// NOTE: This field is currently not populated by the system. The maximum per-second addition of new documents to corpus.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusLimits(
            long? usedDocs,
            long? usedParts,
            long? usedBytes,
            long? usedCharacters,
            long? maxBytes,
            long? maxMetadataBytes,
            long? indexRate)
        {
            this.UsedDocs = usedDocs;
            this.UsedParts = usedParts;
            this.UsedBytes = usedBytes;
            this.UsedCharacters = usedCharacters;
            this.MaxBytes = maxBytes;
            this.MaxMetadataBytes = maxMetadataBytes;
            this.IndexRate = indexRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusLimits" /> class.
        /// </summary>
        public CorpusLimits()
        {
        }
    }
}