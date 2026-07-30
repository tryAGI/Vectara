
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A JWS-style signature over the v1 agent card.
    /// </summary>
    public sealed partial class A2aV1AgentCardSignature
    {
        /// <summary>
        /// Base64url-encoded protected JOSE header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Protected { get; set; }

        /// <summary>
        /// Base64url-encoded signature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Unprotected JOSE header (free-form object).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public object? Header { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentCardSignature" /> class.
        /// </summary>
        /// <param name="protected">
        /// Base64url-encoded protected JOSE header.
        /// </param>
        /// <param name="signature">
        /// Base64url-encoded signature.
        /// </param>
        /// <param name="header">
        /// Unprotected JOSE header (free-form object).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentCardSignature(
            string @protected,
            string signature,
            object? header)
        {
            this.Protected = @protected ?? throw new global::System.ArgumentNullException(nameof(@protected));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Header = header;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentCardSignature" /> class.
        /// </summary>
        public A2aV1AgentCardSignature()
        {
        }

    }
}