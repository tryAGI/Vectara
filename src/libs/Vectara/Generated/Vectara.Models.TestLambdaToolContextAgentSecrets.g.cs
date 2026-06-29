
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Stand-in for the hosting agent's secrets. Each entry resolves a `$ref` of the form `agent.secrets.&lt;key&gt;`; values must be strings.
    /// </summary>
    public sealed partial class TestLambdaToolContextAgentSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}