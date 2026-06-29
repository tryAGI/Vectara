
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Stand-in values for the hosting agent and session, used to resolve `agent.*` and `session.*` `$ref`s inside the tool configurations under test. Accepted by both `POST /v2/tools/test` and `POST /v2/tools/{tool_id}/test`.<br/>
    /// Example: {"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}
    /// </summary>
    public sealed partial class TestLambdaToolContext
    {
        /// <summary>
        /// Values that substitute for the hosting agent during a lambda test run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Vectara.TestLambdaToolContextAgent? Agent { get; set; }

        /// <summary>
        /// Values that substitute for the hosting session during a lambda test run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::Vectara.TestLambdaToolContextSession? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolContext" /> class.
        /// </summary>
        /// <param name="agent">
        /// Values that substitute for the hosting agent during a lambda test run.
        /// </param>
        /// <param name="session">
        /// Values that substitute for the hosting session during a lambda test run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLambdaToolContext(
            global::Vectara.TestLambdaToolContextAgent? agent,
            global::Vectara.TestLambdaToolContextSession? session)
        {
            this.Agent = agent;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolContext" /> class.
        /// </summary>
        public TestLambdaToolContext()
        {
        }

    }
}