
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional parameters for the specified model used when generating the table summary.
    /// </summary>
    public sealed partial class TableGenerationSpecModelParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}