
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Values that substitute for the hosting agent during a lambda test run.
    /// </summary>
    public sealed partial class TestLambdaToolContextAgent
    {
        /// <summary>
        /// Stand-in for the hosting agent's metadata. Each entry resolves a `$ref` of the form `agent.metadata.&lt;key&gt;` in the tool configurations under test; values may be any JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Stand-in for the hosting agent's secrets. Each entry resolves a `$ref` of the form `agent.secrets.&lt;key&gt;`; values must be strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolContextAgent" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Stand-in for the hosting agent's metadata. Each entry resolves a `$ref` of the form `agent.metadata.&lt;key&gt;` in the tool configurations under test; values may be any JSON.
        /// </param>
        /// <param name="secrets">
        /// Stand-in for the hosting agent's secrets. Each entry resolves a `$ref` of the form `agent.secrets.&lt;key&gt;`; values must be strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLambdaToolContextAgent(
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, string>? secrets)
        {
            this.Metadata = metadata;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolContextAgent" /> class.
        /// </summary>
        public TestLambdaToolContextAgent()
        {
        }

    }
}