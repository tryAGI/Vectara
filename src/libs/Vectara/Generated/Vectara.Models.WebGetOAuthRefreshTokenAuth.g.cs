
#nullable enable

namespace Vectara
{
    /// <summary>
    /// OAuth 2.0 refresh-token grant. The platform exchanges a long-lived refresh token for an<br/>
    /// access token and caches the result until it expires. Supports refresh-token rotation: if<br/>
    /// the IdP returns a new refresh_token, subsequent refreshes use it automatically.
    /// </summary>
    public sealed partial class WebGetOAuthRefreshTokenAuth
    {
        /// <summary>
        /// Default Value: oauth_refresh_token<br/>
        /// Example: oauth_refresh_token
        /// </summary>
        /// <default>"oauth_refresh_token"</default>
        /// <example>oauth_refresh_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "oauth_refresh_token";

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> RefreshToken { get; set; }

        /// <summary>
        /// Example: https://auth.example.com/oauth2/token
        /// </summary>
        /// <example>https://auth.example.com/oauth2/token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetOAuthRefreshTokenAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: oauth_refresh_token<br/>
        /// Example: oauth_refresh_token
        /// </param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="refreshToken"></param>
        /// <param name="tokenEndpoint">
        /// Example: https://auth.example.com/oauth2/token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetOAuthRefreshTokenAuth(
            string type,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> clientId,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> clientSecret,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> refreshToken,
            string tokenEndpoint)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.RefreshToken = refreshToken;
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetOAuthRefreshTokenAuth" /> class.
        /// </summary>
        public WebGetOAuthRefreshTokenAuth()
        {
        }

    }
}