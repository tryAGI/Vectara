
#nullable enable

namespace Vectara
{
    /// <summary>
    /// OpenID Connect authentication scheme.
    /// </summary>
    public sealed partial class A2aV03OpenIdConnectSecurityScheme
    {
        /// <summary>
        /// Human-readable description of the security scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the OpenID Connect discovery document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openIdConnectUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenIdConnectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03OpenIdConnectSecurityScheme" /> class.
        /// </summary>
        /// <param name="openIdConnectUrl">
        /// URL of the OpenID Connect discovery document.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the security scheme.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03OpenIdConnectSecurityScheme(
            string openIdConnectUrl,
            string? description)
        {
            this.Description = description;
            this.OpenIdConnectUrl = openIdConnectUrl ?? throw new global::System.ArgumentNullException(nameof(openIdConnectUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03OpenIdConnectSecurityScheme" /> class.
        /// </summary>
        public A2aV03OpenIdConnectSecurityScheme()
        {
        }

    }
}