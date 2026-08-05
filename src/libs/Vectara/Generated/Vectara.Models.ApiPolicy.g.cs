
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The actions a principal can take on the Vectara platform.
    /// </summary>
    public sealed partial class ApiPolicy
    {
        /// <summary>
        /// The name of the API role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The operations the API role allows. Each operation may allow only certain resources, described by a map of resource path to resource values. If the value is null, the operation allows any resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vectara.ApiOperationPolicy> AllowedOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPolicy" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the API role.
        /// </param>
        /// <param name="allowedOperations">
        /// The operations the API role allows. Each operation may allow only certain resources, described by a map of resource path to resource values. If the value is null, the operation allows any resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiPolicy(
            string name,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.ApiOperationPolicy> allowedOperations)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AllowedOperations = allowedOperations ?? throw new global::System.ArgumentNullException(nameof(allowedOperations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPolicy" /> class.
        /// </summary>
        public ApiPolicy()
        {
        }

    }
}