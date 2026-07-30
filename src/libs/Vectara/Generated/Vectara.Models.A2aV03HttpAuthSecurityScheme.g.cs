
#nullable enable

namespace Vectara
{
    /// <summary>
    /// HTTP-based authentication (Basic, Bearer, etc.).
    /// </summary>
    public sealed partial class A2aV03HttpAuthSecurityScheme
    {
        /// <summary>
        /// Human-readable description of the security scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// HTTP authentication scheme name (e.g. `Basic`, `Bearer`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scheme { get; set; }

        /// <summary>
        /// Format of the bearer token, for documentation purposes (e.g. `JWT`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearerFormat")]
        public string? BearerFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03HttpAuthSecurityScheme" /> class.
        /// </summary>
        /// <param name="scheme">
        /// HTTP authentication scheme name (e.g. `Basic`, `Bearer`).
        /// </param>
        /// <param name="description">
        /// Human-readable description of the security scheme.
        /// </param>
        /// <param name="bearerFormat">
        /// Format of the bearer token, for documentation purposes (e.g. `JWT`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03HttpAuthSecurityScheme(
            string scheme,
            string? description,
            string? bearerFormat)
        {
            this.Description = description;
            this.Scheme = scheme ?? throw new global::System.ArgumentNullException(nameof(scheme));
            this.BearerFormat = bearerFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03HttpAuthSecurityScheme" /> class.
        /// </summary>
        public A2aV03HttpAuthSecurityScheme()
        {
        }

    }
}