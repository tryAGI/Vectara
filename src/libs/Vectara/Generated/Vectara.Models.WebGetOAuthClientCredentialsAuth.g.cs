
#nullable enable

namespace Vectara
{
    /// <summary>
    /// OAuth 2.0 client-credentials grant.<br/>
    /// The platform fetches an access token from the token endpoint and caches it until it expires.
    /// </summary>
    public sealed partial class WebGetOAuthClientCredentialsAuth
    {
        /// <summary>
        /// Default Value: oauth_client_credentials<br/>
        /// Example: oauth_client_credentials
        /// </summary>
        /// <default>"oauth_client_credentials"</default>
        /// <example>oauth_client_credentials</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "oauth_client_credentials";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> ClientSecret { get; set; }

        /// <summary>
        /// Example: https://auth.example.com/oauth2/token
        /// </summary>
        /// <example>https://auth.example.com/oauth2/token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenEndpoint { get; set; }

        /// <summary>
        /// Example: [read:items]
        /// </summary>
        /// <example>[read:items]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Optional. Sent as the OAuth `audience` form parameter so the IdP mints a token scoped to this audience.<br/>
        /// Required by IdPs like Ory Hydra to issue a token whose `aud` claim targets an external service (e.g. an STS).<br/>
        /// Example: https://sts.example.com
        /// </summary>
        /// <example>https://sts.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetOAuthClientCredentialsAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: oauth_client_credentials<br/>
        /// Example: oauth_client_credentials
        /// </param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tokenEndpoint">
        /// Example: https://auth.example.com/oauth2/token
        /// </param>
        /// <param name="scopes">
        /// Example: [read:items]
        /// </param>
        /// <param name="audience">
        /// Optional. Sent as the OAuth `audience` form parameter so the IdP mints a token scoped to this audience.<br/>
        /// Required by IdPs like Ory Hydra to issue a token whose `aud` claim targets an external service (e.g. an STS).<br/>
        /// Example: https://sts.example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetOAuthClientCredentialsAuth(
            string type,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> clientId,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> clientSecret,
            string tokenEndpoint,
            global::System.Collections.Generic.IList<string>? scopes,
            string? audience)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
            this.Scopes = scopes;
            this.Audience = audience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetOAuthClientCredentialsAuth" /> class.
        /// </summary>
        public WebGetOAuthClientCredentialsAuth()
        {
        }

    }
}