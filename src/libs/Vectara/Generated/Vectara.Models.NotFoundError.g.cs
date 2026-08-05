
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Error returned when a requested resource does not exist.
    /// </summary>
    public sealed partial class NotFoundError
    {
        /// <summary>
        /// The ID that cannot be found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// The ID of the request. Provide this ID to Vectara support to help debug the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID that cannot be found.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="requestId">
        /// The ID of the request. Provide this ID to Vectara support to help debug the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotFoundError(
            string? id,
            global::System.Collections.Generic.IList<string>? messages,
            string? requestId)
        {
            this.Id = id;
            this.Messages = messages;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        public NotFoundError()
        {
        }

    }
}