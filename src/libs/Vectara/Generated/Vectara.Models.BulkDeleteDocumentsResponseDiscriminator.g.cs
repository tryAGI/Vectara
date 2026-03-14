
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkDeleteDocumentsResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeJsonConverter))]
        public global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType? ResponseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteDocumentsResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="responseType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkDeleteDocumentsResponseDiscriminator(
            global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType? responseType)
        {
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteDocumentsResponseDiscriminator" /> class.
        /// </summary>
        public BulkDeleteDocumentsResponseDiscriminator()
        {
        }
    }
}