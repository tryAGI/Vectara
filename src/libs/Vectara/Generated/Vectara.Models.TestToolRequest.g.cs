
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to test a Lambda tool with sample input.
    /// </summary>
    public sealed partial class TestToolRequest
    {
        /// <summary>
        /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
        /// Example: {"number":42,"text":"Hello, world!"}
        /// </summary>
        /// <example>{"number":42,"text":"Hello, world!"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Maximum execution time in seconds. If not specified, uses the tool's configured timeout.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Stand-in values for the hosting agent and session, used to resolve `agent.*` and `session.*` `$ref`s inside the tool configurations under test. Accepted by both `POST /v2/tools/test` and `POST /v2/tools/{tool_id}/test`.<br/>
        /// Example: {"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}
        /// </summary>
        /// <example>{"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_context")]
        public global::Vectara.TestLambdaToolContext? TestContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
        /// Example: {"number":42,"text":"Hello, world!"}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds. If not specified, uses the tool's configured timeout.<br/>
        /// Example: 10
        /// </param>
        /// <param name="testContext">
        /// Stand-in values for the hosting agent and session, used to resolve `agent.*` and `session.*` `$ref`s inside the tool configurations under test. Accepted by both `POST /v2/tools/test` and `POST /v2/tools/{tool_id}/test`.<br/>
        /// Example: {"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestToolRequest(
            object input,
            int? timeoutSeconds,
            global::Vectara.TestLambdaToolContext? testContext)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.TimeoutSeconds = timeoutSeconds;
            this.TestContext = testContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolRequest" /> class.
        /// </summary>
        public TestToolRequest()
        {
        }

    }
}