
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The operations the API role allows. Each operation may allow only certain resources, described by a map of resource path to resource values. If the value is null, the operation allows any resource.
    /// </summary>
    public sealed partial class ApiPolicyAllowedOperations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}