
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Stand-in for the hosting agent's metadata. Each entry resolves a `$ref` of the form `agent.metadata.&lt;key&gt;` in the tool configurations under test; values may be any JSON.
    /// </summary>
    public sealed partial class TestLambdaToolContextAgentMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}