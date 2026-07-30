
#nullable enable

namespace Vectara
{
    /// <summary>
    /// OAuth 2.0 authentication scheme.
    /// </summary>
    public sealed partial class A2aV03OAuth2SecurityScheme
    {
        /// <summary>
        /// Human-readable description of the security scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Container for the supported OAuth 2.0 flows. Exactly one is populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.A2aV03OAuthFlows Flows { get; set; }

        /// <summary>
        /// URL of the OAuth 2.0 authorization server metadata document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2MetadataUrl")]
        public string? Oauth2MetadataUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03OAuth2SecurityScheme" /> class.
        /// </summary>
        /// <param name="flows">
        /// Container for the supported OAuth 2.0 flows. Exactly one is populated.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the security scheme.
        /// </param>
        /// <param name="oauth2MetadataUrl">
        /// URL of the OAuth 2.0 authorization server metadata document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03OAuth2SecurityScheme(
            global::Vectara.A2aV03OAuthFlows flows,
            string? description,
            string? oauth2MetadataUrl)
        {
            this.Description = description;
            this.Flows = flows ?? throw new global::System.ArgumentNullException(nameof(flows));
            this.Oauth2MetadataUrl = oauth2MetadataUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03OAuth2SecurityScheme" /> class.
        /// </summary>
        public A2aV03OAuth2SecurityScheme()
        {
        }

    }
}