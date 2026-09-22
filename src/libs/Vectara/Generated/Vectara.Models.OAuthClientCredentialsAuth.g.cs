
#nullable enable

namespace Vectara
{
    /// <summary>
    /// OAuth 2.0 client credentials authentication. The platform acquires an access token from the token endpoint before connecting to the remote service.
    /// </summary>
    public sealed partial class OAuthClientCredentialsAuth
    {
        /// <summary>
        /// Must be "oauth_client_credentials" for OAuth client credentials auth.<br/>
        /// Default Value: oauth_client_credentials<br/>
        /// Example: oauth_client_credentials
        /// </summary>
        /// <default>"oauth_client_credentials"</default>
        /// <example>oauth_client_credentials</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "oauth_client_credentials";

        /// <summary>
        /// The OAuth2 client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The OAuth2 client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// The OAuth2 token endpoint URL where the platform exchanges credentials for an access token.<br/>
        /// Example: https://auth.example.com/oauth2/token
        /// </summary>
        /// <example>https://auth.example.com/oauth2/token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenEndpoint { get; set; }

        /// <summary>
        /// OAuth2 scopes to request when acquiring the access token.<br/>
        /// Example: [read:jira-work, write:jira-work]
        /// </summary>
        /// <example>[read:jira-work, write:jira-work]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Sent as the OAuth `audience` form parameter so the identity provider mints a token whose `aud` claim targets this value. Required by some identity providers, such as Ory Hydra and Auth0.<br/>
        /// Example: https://api.example.com
        /// </summary>
        /// <example>https://api.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// How the platform presents the client ID and secret to the token endpoint, named after the OAuth `token_endpoint_auth_method` registry. `client_secret_basic` sends them in an HTTP Basic `Authorization` header. `client_secret_post` sends them as `client_id` and `client_secret` form fields in the request body. Set this to the method the client application is registered with at the identity provider.<br/>
        /// Default Value: client_secret_basic<br/>
        /// Example: client_secret_post
        /// </summary>
        /// <example>client_secret_post</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OAuthClientCredentialsAuthClientAuthMethodJsonConverter))]
        public global::Vectara.OAuthClientCredentialsAuthClientAuthMethod? ClientAuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClientCredentialsAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "oauth_client_credentials" for OAuth client credentials auth.<br/>
        /// Default Value: oauth_client_credentials<br/>
        /// Example: oauth_client_credentials
        /// </param>
        /// <param name="clientId">
        /// The OAuth2 client ID.
        /// </param>
        /// <param name="clientSecret">
        /// The OAuth2 client secret.
        /// </param>
        /// <param name="tokenEndpoint">
        /// The OAuth2 token endpoint URL where the platform exchanges credentials for an access token.<br/>
        /// Example: https://auth.example.com/oauth2/token
        /// </param>
        /// <param name="scopes">
        /// OAuth2 scopes to request when acquiring the access token.<br/>
        /// Example: [read:jira-work, write:jira-work]
        /// </param>
        /// <param name="audience">
        /// Sent as the OAuth `audience` form parameter so the identity provider mints a token whose `aud` claim targets this value. Required by some identity providers, such as Ory Hydra and Auth0.<br/>
        /// Example: https://api.example.com
        /// </param>
        /// <param name="clientAuthMethod">
        /// How the platform presents the client ID and secret to the token endpoint, named after the OAuth `token_endpoint_auth_method` registry. `client_secret_basic` sends them in an HTTP Basic `Authorization` header. `client_secret_post` sends them as `client_id` and `client_secret` form fields in the request body. Set this to the method the client application is registered with at the identity provider.<br/>
        /// Default Value: client_secret_basic<br/>
        /// Example: client_secret_post
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthClientCredentialsAuth(
            string type,
            string clientId,
            string clientSecret,
            string tokenEndpoint,
            global::System.Collections.Generic.IList<string>? scopes,
            string? audience,
            global::Vectara.OAuthClientCredentialsAuthClientAuthMethod? clientAuthMethod)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
            this.Scopes = scopes;
            this.Audience = audience;
            this.ClientAuthMethod = clientAuthMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClientCredentialsAuth" /> class.
        /// </summary>
        public OAuthClientCredentialsAuth()
        {
        }

    }
}