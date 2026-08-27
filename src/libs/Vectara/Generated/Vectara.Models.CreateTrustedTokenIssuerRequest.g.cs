
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for registering a trusted token issuer.
    /// </summary>
    public sealed partial class CreateTrustedTokenIssuerRequest
    {
        /// <summary>
        /// The human-readable name of the trusted issuer.<br/>
        /// Example: Acme Okta production
        /// </summary>
        /// <example>Acme Okta production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A detailed description of what this trust registration is for.<br/>
        /// Example: Lets Acme portal users chat with the support agent.
        /// </summary>
        /// <example>Lets Acme portal users chat with the support agent.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The issuer URL exactly as it appears in the `iss` claim of the identity provider's tokens. Immutable after creation.<br/>
        /// A customer may register an issuer once; a duplicate registration returns `409`.<br/>
        /// Example: https://acme.okta.com/oauth2/default
        /// </summary>
        /// <example>https://acme.okta.com/oauth2/default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        /// The HTTPS URL of the issuer's JSON Web Key Set.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </summary>
        /// <example>https://acme.okta.com/oauth2/default/v1/keys</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUri { get; set; }

        /// <summary>
        /// Whether the registration accepts tokens upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrustedTokenIssuerRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the trusted issuer.<br/>
        /// Example: Acme Okta production
        /// </param>
        /// <param name="issuer">
        /// The issuer URL exactly as it appears in the `iss` claim of the identity provider's tokens. Immutable after creation.<br/>
        /// A customer may register an issuer once; a duplicate registration returns `409`.<br/>
        /// Example: https://acme.okta.com/oauth2/default
        /// </param>
        /// <param name="jwksUri">
        /// The HTTPS URL of the issuer's JSON Web Key Set.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </param>
        /// <param name="description">
        /// A detailed description of what this trust registration is for.<br/>
        /// Example: Lets Acme portal users chat with the support agent.
        /// </param>
        /// <param name="enabled">
        /// Whether the registration accepts tokens upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrustedTokenIssuerRequest(
            string name,
            string issuer,
            string jwksUri,
            string? description,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.JwksUri = jwksUri ?? throw new global::System.ArgumentNullException(nameof(jwksUri));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrustedTokenIssuerRequest" /> class.
        /// </summary>
        public CreateTrustedTokenIssuerRequest()
        {
        }

    }
}