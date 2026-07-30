
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v0.3 security scheme entry. Exactly one of the scheme fields is populated.
    /// </summary>
    public sealed partial class A2aV03SecurityScheme
    {
        /// <summary>
        /// API key passed via header, query parameter, or cookie.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeySecurityScheme")]
        public global::Vectara.A2aV03ApiKeySecurityScheme? ApiKeySecurityScheme { get; set; }

        /// <summary>
        /// HTTP-based authentication (Basic, Bearer, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpAuthSecurityScheme")]
        public global::Vectara.A2aV03HttpAuthSecurityScheme? HttpAuthSecurityScheme { get; set; }

        /// <summary>
        /// OAuth 2.0 authentication scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2SecurityScheme")]
        public global::Vectara.A2aV03OAuth2SecurityScheme? Oauth2SecurityScheme { get; set; }

        /// <summary>
        /// OpenID Connect authentication scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openIdConnectSecurityScheme")]
        public global::Vectara.A2aV03OpenIdConnectSecurityScheme? OpenIdConnectSecurityScheme { get; set; }

        /// <summary>
        /// Mutual TLS (client certificate) authentication scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mtlsSecurityScheme")]
        public global::Vectara.A2aV03MutualTlsSecurityScheme? MtlsSecurityScheme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03SecurityScheme" /> class.
        /// </summary>
        /// <param name="apiKeySecurityScheme">
        /// API key passed via header, query parameter, or cookie.
        /// </param>
        /// <param name="httpAuthSecurityScheme">
        /// HTTP-based authentication (Basic, Bearer, etc.).
        /// </param>
        /// <param name="oauth2SecurityScheme">
        /// OAuth 2.0 authentication scheme.
        /// </param>
        /// <param name="openIdConnectSecurityScheme">
        /// OpenID Connect authentication scheme.
        /// </param>
        /// <param name="mtlsSecurityScheme">
        /// Mutual TLS (client certificate) authentication scheme.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03SecurityScheme(
            global::Vectara.A2aV03ApiKeySecurityScheme? apiKeySecurityScheme,
            global::Vectara.A2aV03HttpAuthSecurityScheme? httpAuthSecurityScheme,
            global::Vectara.A2aV03OAuth2SecurityScheme? oauth2SecurityScheme,
            global::Vectara.A2aV03OpenIdConnectSecurityScheme? openIdConnectSecurityScheme,
            global::Vectara.A2aV03MutualTlsSecurityScheme? mtlsSecurityScheme)
        {
            this.ApiKeySecurityScheme = apiKeySecurityScheme;
            this.HttpAuthSecurityScheme = httpAuthSecurityScheme;
            this.Oauth2SecurityScheme = oauth2SecurityScheme;
            this.OpenIdConnectSecurityScheme = openIdConnectSecurityScheme;
            this.MtlsSecurityScheme = mtlsSecurityScheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03SecurityScheme" /> class.
        /// </summary>
        public A2aV03SecurityScheme()
        {
        }

    }
}