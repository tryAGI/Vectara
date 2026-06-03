
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Default value when none is provided.
    /// </summary>
    public sealed partial class JsonSchemaDefinitionDefault
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}