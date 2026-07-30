
#nullable enable

namespace Vectara
{
    /// <summary>
    /// API key passed via header, query parameter, or cookie.
    /// </summary>
    public sealed partial class A2aV03ApiKeySecurityScheme
    {
        /// <summary>
        /// Human-readable description of the security scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// One of `query`, `header`, or `cookie`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Name of the header, query parameter, or cookie carrying the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03ApiKeySecurityScheme" /> class.
        /// </summary>
        /// <param name="location">
        /// One of `query`, `header`, or `cookie`.
        /// </param>
        /// <param name="name">
        /// Name of the header, query parameter, or cookie carrying the API key.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the security scheme.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03ApiKeySecurityScheme(
            string location,
            string name,
            string? description)
        {
            this.Description = description;
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03ApiKeySecurityScheme" /> class.
        /// </summary>
        public A2aV03ApiKeySecurityScheme()
        {
        }

    }
}