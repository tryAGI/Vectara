
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Container for the supported OAuth 2.0 flows. Exactly one is populated.
    /// </summary>
    public sealed partial class A2aV03OAuthFlows
    {
        /// <summary>
        /// OAuth 2.0 authorization code flow configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationCode")]
        public global::Vectara.A2aV03AuthorizationCodeOAuthFlow? AuthorizationCode { get; set; }

        /// <summary>
        /// OAuth 2.0 client credentials flow configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientCredentials")]
        public global::Vectara.A2aV03ClientCredentialsOAuthFlow? ClientCredentials { get; set; }

        /// <summary>
        /// OAuth 2.0 implicit flow configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("implicit")]
        public global::Vectara.A2aV03ImplicitOAuthFlow? Implicit { get; set; }

        /// <summary>
        /// OAuth 2.0 resource owner password flow configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public global::Vectara.A2aV03PasswordOAuthFlow? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03OAuthFlows" /> class.
        /// </summary>
        /// <param name="authorizationCode">
        /// OAuth 2.0 authorization code flow configuration.
        /// </param>
        /// <param name="clientCredentials">
        /// OAuth 2.0 client credentials flow configuration.
        /// </param>
        /// <param name="implicit">
        /// OAuth 2.0 implicit flow configuration.
        /// </param>
        /// <param name="password">
        /// OAuth 2.0 resource owner password flow configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03OAuthFlows(
            global::Vectara.A2aV03AuthorizationCodeOAuthFlow? authorizationCode,
            global::Vectara.A2aV03ClientCredentialsOAuthFlow? clientCredentials,
            global::Vectara.A2aV03ImplicitOAuthFlow? @implicit,
            global::Vectara.A2aV03PasswordOAuthFlow? password)
        {
            this.AuthorizationCode = authorizationCode;
            this.ClientCredentials = clientCredentials;
            this.Implicit = @implicit;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03OAuthFlows" /> class.
        /// </summary>
        public A2aV03OAuthFlows()
        {
        }

    }
}