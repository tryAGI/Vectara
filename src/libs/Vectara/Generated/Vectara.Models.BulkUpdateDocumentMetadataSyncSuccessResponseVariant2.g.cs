
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateDocumentMetadataSyncSuccessResponseVariant2
    {
        /// <summary>
        /// Indicates this is a successful sync response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Number of documents successfully updated.<br/>
        /// Example: 1523
        /// </summary>
        /// <example>1523</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UpdatedCount { get; set; }

        /// <summary>
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SkippedCount { get; set; }

        /// <summary>
        /// Number of documents that could not be updated due to a non-retryable error (for example, a document that was not found).<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FailedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataSyncSuccessResponseVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates this is a successful sync response.
        /// </param>
        /// <param name="updatedCount">
        /// Number of documents successfully updated.<br/>
        /// Example: 1523
        /// </param>
        /// <param name="skippedCount">
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </param>
        /// <param name="failedCount">
        /// Number of documents that could not be updated due to a non-retryable error (for example, a document that was not found).<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateDocumentMetadataSyncSuccessResponseVariant2(
            string type,
            long updatedCount,
            long skippedCount,
            long failedCount)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedCount = updatedCount;
            this.SkippedCount = skippedCount;
            this.FailedCount = failedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDocumentMetadataSyncSuccessResponseVariant2" /> class.
        /// </summary>
        public BulkUpdateDocumentMetadataSyncSuccessResponseVariant2()
        {
        }

    }
}