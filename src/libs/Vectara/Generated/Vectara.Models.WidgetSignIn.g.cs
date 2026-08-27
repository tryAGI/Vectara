
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Enables the widget's sign-in affordance and names the identity provider it authenticates users against.<br/>
    /// The host page supplies a token minted by the referenced trusted token issuer, and the widget presents it as the bearer credential on end-user session requests.<br/>
    /// The platform verifies the token by its `iss` claim against the globally-unique issuer registration — never against this connector — so the token stands on its own: it signs the caller in as an end user across the customer's aliases, not this widget's alone.<br/>
    /// The platform accepts the token when its signature verifies against the issuer's JWKS and it carries an `email` claim.<br/>
    /// The referenced registration must exist, or the connector write is rejected with `400`.
    /// </summary>
    public sealed partial class WidgetSignIn
    {
        /// <summary>
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </summary>
        /// <example>tki_9Kx2QpVn4mZr8YbLc5TdWe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted_token_issuer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrustedTokenIssuerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetSignIn" /> class.
        /// </summary>
        /// <param name="trustedTokenIssuerId">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetSignIn(
            string trustedTokenIssuerId)
        {
            this.TrustedTokenIssuerId = trustedTokenIssuerId ?? throw new global::System.ArgumentNullException(nameof(trustedTokenIssuerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetSignIn" /> class.
        /// </summary>
        public WidgetSignIn()
        {
        }

    }
}