
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request body for a bulk document metadata update.<br/>
    /// The same `metadata` object is applied to every document matched by the `metadata_filter` and/or `document_ids` query parameters, using the chosen `strategy`.
    /// </summary>
    public sealed partial class BulkUpdateDocumentMetadataRequest
    {
        /// <summary>
        /// The metadata object to apply to every matched document.<br/>
        /// Example: {"status":"archived","reviewed":true,"year":2024}
        /// </summary>
        /// <example>{"status":"archived","reviewed":true,"year":2024}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// How to apply the supplied `metadata` to each matched document.<br/>
        /// - `merge` (default): adds or overwrites only the supplied fields, leaving other existing fields intact.<br/>
        /// - `replace`: replaces the entire existing metadata with the supplied object.<br/>
        /// Default Value: merge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BulkUpdateDocumentMetadataRequestStrategyJsonConverter))]
        public global::Vectara.BulkUpdateDocumentMetadataRequestStrategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// The metadata object to apply to every matched document.<br/>
        /// Example: {"status":"archived","reviewed":true,"year":2024}
        /// </param>
        /// <param name="strategy">
        /// How to apply the supplied `metadata` to each matched document.<br/>
        /// - `merge` (default): adds or overwrites only the supplied fields, leaving other existing fields intact.<br/>
        /// - `replace`: replaces the entire existing metadata with the supplied object.<br/>
        /// Default Value: merge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateDocumentMetadataRequest(
            object metadata,
            global::Vectara.BulkUpdateDocumentMetadataRequestStrategy? strategy)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataRequest" /> class.
        /// </summary>
        public BulkUpdateDocumentMetadataRequest()
        {
        }

    }
}