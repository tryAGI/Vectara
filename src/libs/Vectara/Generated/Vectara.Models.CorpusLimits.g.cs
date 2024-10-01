
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorpusLimits
    {
        /// <summary>
        /// The number of bytes contained in the corpus. This includes the document metadata,<br/>
        /// document part metadata, and document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        public long? UsedBytes { get; set; }

        /// <summary>
        /// The number of characters contained in the corpus. This includes the document metadata,<br/>
        /// document part metadata, and document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_characters")]
        public long? UsedCharacters { get; set; }

        /// <summary>
        /// The maximum number of bytes the corpus can be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_bytes")]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// The maximum size that metadata can be on documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_metadata_bytes")]
        public long? MaxMetadataBytes { get; set; }

        /// <summary>
        /// The maximum per-second addition of new documents to corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_rate")]
        public long? IndexRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}