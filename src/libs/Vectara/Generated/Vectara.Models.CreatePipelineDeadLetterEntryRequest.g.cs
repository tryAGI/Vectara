
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to manually add a source record to the dead letter queue for reprocessing.<br/>
    /// Use this when you want to force a record through the pipeline again, for example<br/>
    /// when the agent or judge made an incorrect decision.
    /// </summary>
    public sealed partial class CreatePipelineDeadLetterEntryRequest
    {
        /// <summary>
        /// The identifier for the source record to add. Format depends on connector type:<br/>
        /// - S3: the object key (e.g. `legal/contracts/doc.pdf`)<br/>
        /// - SharePoint: the drive item ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_record_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceRecordId { get; set; }

        /// <summary>
        /// Optional reason for manually adding this record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipelineDeadLetterEntryRequest" /> class.
        /// </summary>
        /// <param name="sourceRecordId">
        /// The identifier for the source record to add. Format depends on connector type:<br/>
        /// - S3: the object key (e.g. `legal/contracts/doc.pdf`)<br/>
        /// - SharePoint: the drive item ID
        /// </param>
        /// <param name="errorMessage">
        /// Optional reason for manually adding this record.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePipelineDeadLetterEntryRequest(
            string sourceRecordId,
            string? errorMessage)
        {
            this.SourceRecordId = sourceRecordId ?? throw new global::System.ArgumentNullException(nameof(sourceRecordId));
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipelineDeadLetterEntryRequest" /> class.
        /// </summary>
        public CreatePipelineDeadLetterEntryRequest()
        {
        }
    }
}