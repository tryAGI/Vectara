
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A customer identity provider whose signed tokens the platform accepts as end-user credentials.<br/>
    /// The registration is a trust anchor: the issuer URL and the JWKS the platform verifies signatures against.<br/>
    /// What a verified token grants is declared on the widget connector that references this registration by id.
    /// </summary>
    public sealed partial class TrustedTokenIssuer
    {
        /// <summary>
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </summary>
        /// <example>tki_9Kx2QpVn4mZr8YbLc5TdWe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// The platform fetches it server-side and refreshes it periodically, so new signing keys become effective on the next refresh.<br/>
        /// A token signed with a key the platform has not yet seen triggers one immediate refresh.<br/>
        /// When a refresh fails, previously fetched keys remain in use until a refresh succeeds.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </summary>
        /// <example>https://acme.okta.com/oauth2/default/v1/keys</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUri { get; set; }

        /// <summary>
        /// Whether the registration currently accepts tokens. Disabling refuses every future sign-in immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The token claims a signed-in end user carries into each input they send, beyond `sub` and `email`.<br/>
        /// When the platform verifies a token from this issuer, it copies each listed claim the token holds, with its JSON type, onto the input that token sends.<br/>
        /// The agent's tools read the latest input's claims as `inputs.user.latest.caller.claims.&lt;name&gt;`, so a refreshed token's claims apply from the next input it sends.<br/>
        /// A name that is not a plain identifier, such as a namespaced URL, is addressed with a quoted bracket key: `inputs.user.latest.caller.claims['https://acme.com/roles']`.<br/>
        /// Input events never return them, though a tool call's `resolved_argument_overrides` shows the values its overrides resolved to. The agent's LLM does not see the argument overrides that read them, but it does see a tool's output, so a tool that echoes a claim reveals it.<br/>
        /// A claim the token does not hold is absent, so a `$ref` to it fails closed unless the reference supplies a `$default`.<br/>
        /// The standard JWT claims (`iss`, `sub`, `aud`, `exp`, `nbf`, `iat`, `jti`) and `email` cannot be listed.<br/>
        /// Each name may appear only once.<br/>
        /// A token whose listed claims exceed 8 KB, serialized as JSON, is rejected with `401` on end-user session requests.<br/>
        /// Example: [entitledProductIDList, isOEM, https://acme.com/roles]
        /// </summary>
        /// <example>[entitledProductIDList, isOEM, https://acme.com/roles]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Claims { get; set; }

        /// <summary>
        /// Timestamp of the most recent successful fetch of the issuer's JWKS. Absent until the first successful fetch.<br/>
        /// Example: 2026-08-12T10:30:00Z
        /// </summary>
        /// <example>2026-08-12T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_jwks_fetch_at")]
        public global::System.DateTime? LastJwksFetchAt { get; set; }

        /// <summary>
        /// The number of signing keys in the most recent successful JWKS fetch.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_key_count")]
        public int? JwksKeyCount { get; set; }

        /// <summary>
        /// The most recent JWKS fetch error, absent while fetching is healthy.<br/>
        /// Example: jwks fetch failed: connection timed out
        /// </summary>
        /// <example>jwks fetch failed: connection timed out</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_fetch_error")]
        public string? JwksFetchError { get; set; }

        /// <summary>
        /// Timestamp when the registration was created.<br/>
        /// Example: 2026-08-07T10:30:00Z
        /// </summary>
        /// <example>2026-08-07T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the registration was last updated.<br/>
        /// Example: 2026-08-07T14:45:00Z
        /// </summary>
        /// <example>2026-08-07T14:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedTokenIssuer" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of a trusted token issuer.<br/>
        /// Example: tki_9Kx2QpVn4mZr8YbLc5TdWe
        /// </param>
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
        /// The platform fetches it server-side and refreshes it periodically, so new signing keys become effective on the next refresh.<br/>
        /// A token signed with a key the platform has not yet seen triggers one immediate refresh.<br/>
        /// When a refresh fails, previously fetched keys remain in use until a refresh succeeds.<br/>
        /// Example: https://acme.okta.com/oauth2/default/v1/keys
        /// </param>
        /// <param name="enabled">
        /// Whether the registration currently accepts tokens. Disabling refuses every future sign-in immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="claims">
        /// The token claims a signed-in end user carries into each input they send, beyond `sub` and `email`.<br/>
        /// When the platform verifies a token from this issuer, it copies each listed claim the token holds, with its JSON type, onto the input that token sends.<br/>
        /// The agent's tools read the latest input's claims as `inputs.user.latest.caller.claims.&lt;name&gt;`, so a refreshed token's claims apply from the next input it sends.<br/>
        /// A name that is not a plain identifier, such as a namespaced URL, is addressed with a quoted bracket key: `inputs.user.latest.caller.claims['https://acme.com/roles']`.<br/>
        /// Input events never return them, though a tool call's `resolved_argument_overrides` shows the values its overrides resolved to. The agent's LLM does not see the argument overrides that read them, but it does see a tool's output, so a tool that echoes a claim reveals it.<br/>
        /// A claim the token does not hold is absent, so a `$ref` to it fails closed unless the reference supplies a `$default`.<br/>
        /// The standard JWT claims (`iss`, `sub`, `aud`, `exp`, `nbf`, `iat`, `jti`) and `email` cannot be listed.<br/>
        /// Each name may appear only once.<br/>
        /// A token whose listed claims exceed 8 KB, serialized as JSON, is rejected with `401` on end-user session requests.<br/>
        /// Example: [entitledProductIDList, isOEM, https://acme.com/roles]
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the registration was created.<br/>
        /// Example: 2026-08-07T10:30:00Z
        /// </param>
        /// <param name="description">
        /// A detailed description of what this trust registration is for.<br/>
        /// Example: Lets Acme portal users chat with the support agent.
        /// </param>
        /// <param name="lastJwksFetchAt">
        /// Timestamp of the most recent successful fetch of the issuer's JWKS. Absent until the first successful fetch.<br/>
        /// Example: 2026-08-12T10:30:00Z
        /// </param>
        /// <param name="jwksKeyCount">
        /// The number of signing keys in the most recent successful JWKS fetch.<br/>
        /// Example: 2
        /// </param>
        /// <param name="jwksFetchError">
        /// The most recent JWKS fetch error, absent while fetching is healthy.<br/>
        /// Example: jwks fetch failed: connection timed out
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the registration was last updated.<br/>
        /// Example: 2026-08-07T14:45:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrustedTokenIssuer(
            string id,
            string name,
            string issuer,
            string jwksUri,
            bool enabled,
            global::System.Collections.Generic.IList<string> claims,
            global::System.DateTime createdAt,
            string? description,
            global::System.DateTime? lastJwksFetchAt,
            int? jwksKeyCount,
            string? jwksFetchError,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.JwksUri = jwksUri ?? throw new global::System.ArgumentNullException(nameof(jwksUri));
            this.Enabled = enabled;
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
            this.LastJwksFetchAt = lastJwksFetchAt;
            this.JwksKeyCount = jwksKeyCount;
            this.JwksFetchError = jwksFetchError;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedTokenIssuer" /> class.
        /// </summary>
        public TrustedTokenIssuer()
        {
        }

    }
}