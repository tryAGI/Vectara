
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The JSON schema that describes the structure of the tool's output. May be used by clients to<br/>
    /// understand the shape of tool responses and to author `default_output_transform` jq expressions.
    /// </summary>
    public sealed partial class ToolBaseOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}