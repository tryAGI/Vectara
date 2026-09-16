
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The sign-in affordance of the public connector view. Identifies the identity provider the widget authenticates users against by its issuer URL — the `iss` claim of the tokens the host page supplies — never by the internal registration id.<br/>
    /// The host page obtains a token from this issuer and the widget presents it as the bearer credential on end-user session requests.
    /// </summary>
    public sealed partial class PublicSignIn
    {
        /// <summary>
        /// The issuer URL of the identity provider, exactly as it appears in the `iss` claim of its tokens.<br/>
        /// Example: https://acme.okta.com/oauth2/default
        /// </summary>
        /// <example>https://acme.okta.com/oauth2/default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSignIn" /> class.
        /// </summary>
        /// <param name="issuer">
        /// The issuer URL of the identity provider, exactly as it appears in the `iss` claim of its tokens.<br/>
        /// Example: https://acme.okta.com/oauth2/default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSignIn(
            string issuer)
        {
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSignIn" /> class.
        /// </summary>
        public PublicSignIn()
        {
        }

    }
}