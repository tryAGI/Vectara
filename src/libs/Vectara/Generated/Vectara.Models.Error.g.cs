
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// The messages describing why the error occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// The ID of the request that can be used to help Vectara support debug what went wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="messages">
        /// The messages describing why the error occurred.
        /// </param>
        /// <param name="requestId">
        /// The ID of the request that can be used to help Vectara support debug what went wrong.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            global::System.Collections.Generic.IList<string>? messages,
            string? requestId)
        {
            this.Messages = messages;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}