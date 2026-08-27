
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a list of trusted token issuers.
    /// </summary>
    public sealed partial class ListTrustedTokenIssuersResponse
    {
        /// <summary>
        /// List of trusted token issuers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted_token_issuers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.TrustedTokenIssuer> TrustedTokenIssuers { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ListMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrustedTokenIssuersResponse" /> class.
        /// </summary>
        /// <param name="trustedTokenIssuers">
        /// List of trusted token issuers.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTrustedTokenIssuersResponse(
            global::System.Collections.Generic.IList<global::Vectara.TrustedTokenIssuer> trustedTokenIssuers,
            global::Vectara.ListMetadata metadata)
        {
            this.TrustedTokenIssuers = trustedTokenIssuers ?? throw new global::System.ArgumentNullException(nameof(trustedTokenIssuers));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrustedTokenIssuersResponse" /> class.
        /// </summary>
        public ListTrustedTokenIssuersResponse()
        {
        }

    }
}