
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Mutual TLS (client certificate) authentication scheme.
    /// </summary>
    public sealed partial class A2aV03MutualTlsSecurityScheme
    {
        /// <summary>
        /// Human-readable description of the security scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03MutualTlsSecurityScheme" /> class.
        /// </summary>
        /// <param name="description">
        /// Human-readable description of the security scheme.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03MutualTlsSecurityScheme(
            string? description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03MutualTlsSecurityScheme" /> class.
        /// </summary>
        public A2aV03MutualTlsSecurityScheme()
        {
        }

    }
}