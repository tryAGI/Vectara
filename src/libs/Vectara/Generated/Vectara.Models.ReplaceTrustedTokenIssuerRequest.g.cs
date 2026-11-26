
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for replacing a trusted token issuer registration.<br/>
    /// The registration is fully replaced by this request; an omitted `description` clears it, an omitted `enabled` resets it to `true`, and an omitted `claims` carries none.<br/>
    /// The `issuer` is immutable and is not part of this request.
    /// </summary>
    public sealed partial class ReplaceTrustedTokenIssuerRequest
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
        /// The HTTPS URL of the issuer's JSON Web Key Set.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </summary>
        /// <example>https://acme.okta.com/oauth2/default/v1/keys</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUri { get; set; }

        /// <summary>
        /// Whether the registration accepts tokens. Disabling refuses every future sign-in immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The token claims a signed-in end user carries into each input they send as `inputs.user.latest.caller.claims.&lt;name&gt;`, beyond `sub` and `email`. When omitted, no claims are carried.<br/>
        /// A request that names a standard JWT claim (`iss`, `sub`, `aud`, `exp`, `nbf`, `iat`, `jti`) or `email`, or repeats a name, is rejected with `400`.<br/>
        /// A token whose listed claims exceed 8 KB, serialized as JSON, is rejected with `401` on end-user session requests.<br/>
        /// Example: [entitledProductIDList, isOEM, https://acme.com/roles]
        /// </summary>
        /// <example>[entitledProductIDList, isOEM, https://acme.com/roles]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public global::System.Collections.Generic.IList<string>? Claims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceTrustedTokenIssuerRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the trusted issuer.<br/>
        /// Example: Acme Okta production
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
        /// Whether the registration accepts tokens. Disabling refuses every future sign-in immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="claims">
        /// The token claims a signed-in end user carries into each input they send as `inputs.user.latest.caller.claims.&lt;name&gt;`, beyond `sub` and `email`. When omitted, no claims are carried.<br/>
        /// A request that names a standard JWT claim (`iss`, `sub`, `aud`, `exp`, `nbf`, `iat`, `jti`) or `email`, or repeats a name, is rejected with `400`.<br/>
        /// A token whose listed claims exceed 8 KB, serialized as JSON, is rejected with `401` on end-user session requests.<br/>
        /// Example: [entitledProductIDList, isOEM, https://acme.com/roles]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceTrustedTokenIssuerRequest(
            string name,
            string jwksUri,
            string? description,
            bool? enabled,
            global::System.Collections.Generic.IList<string>? claims)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.JwksUri = jwksUri ?? throw new global::System.ArgumentNullException(nameof(jwksUri));
            this.Enabled = enabled;
            this.Claims = claims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceTrustedTokenIssuerRequest" /> class.
        /// </summary>
        public ReplaceTrustedTokenIssuerRequest()
        {
        }

    }
}