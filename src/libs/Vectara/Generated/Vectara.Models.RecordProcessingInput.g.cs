
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The text input a pipeline run sends into each record's agent session: the source record's id and the operation the source performed on it.<br/>
    /// On `upsert` the session also receives the record's content as an uploaded file.<br/>
    /// On `delete` there is no file, and the agent acts on the input according to its configuration.
    /// </summary>
    public sealed partial class RecordProcessingInput
    {
        /// <summary>
        /// The identifier of the record in the source system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_record_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceRecordId { get; set; }

        /// <summary>
        /// The operation the source performed on a record. `upsert` when the record was added or changed, `delete` when the source reported it deleted. New values may be added; treat unrecognized values as opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RecordOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RecordOperation Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordProcessingInput" /> class.
        /// </summary>
        /// <param name="sourceRecordId">
        /// The identifier of the record in the source system.
        /// </param>
        /// <param name="operation">
        /// The operation the source performed on a record. `upsert` when the record was added or changed, `delete` when the source reported it deleted. New values may be added; treat unrecognized values as opaque.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordProcessingInput(
            string sourceRecordId,
            global::Vectara.RecordOperation operation)
        {
            this.SourceRecordId = sourceRecordId ?? throw new global::System.ArgumentNullException(nameof(sourceRecordId));
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordProcessingInput" /> class.
        /// </summary>
        public RecordProcessingInput()
        {
        }

    }
}