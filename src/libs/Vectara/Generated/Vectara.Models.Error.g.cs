
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A general error response with an error code and message.
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// The messages describing why the error occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// The ID of the request. Provide this ID to Vectara support to help debug the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Names the reason for the error when a client may act on it, so the client does not have to read `messages`. Absent for most errors. New values may be added, so clients must treat a value they do not know as if it were absent. Today:<br/>
        /// * `storage_allowance_used`: the account has used its storage allowance, so the request would add data and was refused with a `403`. Delete documents or agent data, or ask for a larger allowance. Retrying does not help until then.<br/>
        /// Example: storage_allowance_used
        /// </summary>
        /// <example>storage_allowance_used</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

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
        /// The ID of the request. Provide this ID to Vectara support to help debug the request.
        /// </param>
        /// <param name="code">
        /// Names the reason for the error when a client may act on it, so the client does not have to read `messages`. Absent for most errors. New values may be added, so clients must treat a value they do not know as if it were absent. Today:<br/>
        /// * `storage_allowance_used`: the account has used its storage allowance, so the request would add data and was refused with a `403`. Delete documents or agent data, or ask for a larger allowance. Retrying does not help until then.<br/>
        /// Example: storage_allowance_used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            global::System.Collections.Generic.IList<string>? messages,
            string? requestId,
            string? code)
        {
            this.Messages = messages;
            this.RequestId = requestId;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }

    }
}