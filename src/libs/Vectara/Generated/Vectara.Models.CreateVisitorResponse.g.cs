
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The minted anonymous visitor identity.
    /// </summary>
    public sealed partial class CreateVisitorResponse
    {
        /// <summary>
        /// The anonymous identity minted for this visitor, presented as the `X-Visitor-Id` header on every end-user session request.<br/>
        /// Scoped to the customer, not the minting widget: it authenticates the same visitor on any of the customer's widgets that admit anonymous visitors.<br/>
        /// Store it durably on the client; it never expires, and it is the only proof of ownership of the sessions it creates.<br/>
        /// Example: vis_lZzE1YTgtNDA1Ni00MmU3LWI5YzMtZTQ4ZDQxN2I5ZTcw
        /// </summary>
        /// <example>vis_lZzE1YTgtNDA1Ni00MmU3LWI5YzMtZTQ4ZDQxN2I5ZTcw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitor_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VisitorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVisitorResponse" /> class.
        /// </summary>
        /// <param name="visitorId">
        /// The anonymous identity minted for this visitor, presented as the `X-Visitor-Id` header on every end-user session request.<br/>
        /// Scoped to the customer, not the minting widget: it authenticates the same visitor on any of the customer's widgets that admit anonymous visitors.<br/>
        /// Store it durably on the client; it never expires, and it is the only proof of ownership of the sessions it creates.<br/>
        /// Example: vis_lZzE1YTgtNDA1Ni00MmU3LWI5YzMtZTQ4ZDQxN2I5ZTcw
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVisitorResponse(
            string visitorId)
        {
            this.VisitorId = visitorId ?? throw new global::System.ArgumentNullException(nameof(visitorId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVisitorResponse" /> class.
        /// </summary>
        public CreateVisitorResponse()
        {
        }

    }
}