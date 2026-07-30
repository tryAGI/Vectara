
#nullable enable

namespace Vectara
{
    /// <summary>
    /// OAuth 2.0 client credentials flow configuration.
    /// </summary>
    public sealed partial class A2aV03ClientCredentialsOAuthFlow
    {
        /// <summary>
        /// Token endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// Token refresh endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshUrl")]
        public string? RefreshUrl { get; set; }

        /// <summary>
        /// Available scopes mapped to their human-readable descriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03ClientCredentialsOAuthFlow" /> class.
        /// </summary>
        /// <param name="tokenUrl">
        /// Token endpoint URL.
        /// </param>
        /// <param name="scopes">
        /// Available scopes mapped to their human-readable descriptions.
        /// </param>
        /// <param name="refreshUrl">
        /// Token refresh endpoint URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03ClientCredentialsOAuthFlow(
            string tokenUrl,
            global::System.Collections.Generic.Dictionary<string, string> scopes,
            string? refreshUrl)
        {
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.RefreshUrl = refreshUrl;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03ClientCredentialsOAuthFlow" /> class.
        /// </summary>
        public A2aV03ClientCredentialsOAuthFlow()
        {
        }

    }
}