
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to manually add a source record to the dead letter queue. The next retry run<br/>
    /// processes the record with the given `operation`. `upsert`, the default, forces the record<br/>
    /// through the pipeline again, for example when the agent or judge made an incorrect<br/>
    /// decision. `delete` runs the agent's delete handling for a record the source removed. If<br/>
    /// the record already has a dead letter, the entry replaces it, operation included.
    /// </summary>
    public sealed partial class CreatePipelineDeadLetterEntryRequest
    {
        /// <summary>
        /// The identifier for the source record to add. Format depends on connector type:<br/>
        /// - S3: the object key (e.g. `legal/contracts/doc.pdf`)<br/>
        /// - SharePoint: the drive item ID<br/>
        /// - Google Drive: the file ID<br/>
        /// - Box: the file ID (e.g. `1422162456741`)<br/>
        /// - Wolken: the article number (e.g. `345678`)<br/>
        /// - Confluence: the page ID (e.g. `123456789`)<br/>
        /// - Web: the canonicalized URL (e.g. `https://docs.example.com/page`)
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
        /// The operation the next retry runs for this record.<br/>
        /// Default Value: upsert
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RecordOperationJsonConverter))]
        public global::Vectara.RecordOperation? Operation { get; set; }

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
        /// - SharePoint: the drive item ID<br/>
        /// - Google Drive: the file ID<br/>
        /// - Box: the file ID (e.g. `1422162456741`)<br/>
        /// - Wolken: the article number (e.g. `345678`)<br/>
        /// - Confluence: the page ID (e.g. `123456789`)<br/>
        /// - Web: the canonicalized URL (e.g. `https://docs.example.com/page`)
        /// </param>
        /// <param name="errorMessage">
        /// Optional reason for manually adding this record.
        /// </param>
        /// <param name="operation">
        /// The operation the next retry runs for this record.<br/>
        /// Default Value: upsert
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePipelineDeadLetterEntryRequest(
            string sourceRecordId,
            string? errorMessage,
            global::Vectara.RecordOperation? operation)
        {
            this.SourceRecordId = sourceRecordId ?? throw new global::System.ArgumentNullException(nameof(sourceRecordId));
            this.ErrorMessage = errorMessage;
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipelineDeadLetterEntryRequest" /> class.
        /// </summary>
        public CreatePipelineDeadLetterEntryRequest()
        {
        }

    }
}