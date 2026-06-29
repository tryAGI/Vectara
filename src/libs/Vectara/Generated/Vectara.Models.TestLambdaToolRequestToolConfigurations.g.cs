
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Named configurations of other tools the code under test may invoke through its built-in `tool` module.<br/>
    /// See the `tool_configurations` field on `CreateLambdaToolRequest` for semantics and constraints.
    /// </summary>
    public sealed partial class TestLambdaToolRequestToolConfigurations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}