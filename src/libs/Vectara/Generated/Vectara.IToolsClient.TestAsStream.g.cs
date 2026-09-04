#nullable enable

namespace Vectara
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test Lambda tool<br/>
        /// Tests an existing Lambda tool by executing it with test inputs.<br/>
        /// Use this to verify a function works correctly before agents use it.<br/>
        /// Optionally supply a `test_context` with stand-in agent metadata, secrets, and session metadata. The `$ref`s in the tool's stored `tool_configurations` resolve against these values.<br/>
        /// The function runs in a secure sandbox environment with the same constraints as production.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_python_function_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vectara.TestToolStreamedResponse> TestAsStreamAsync(
            string toolId,

            global::Vectara.TestToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Lambda tool<br/>
        /// Tests an existing Lambda tool by executing it with test inputs.<br/>
        /// Use this to verify a function works correctly before agents use it.<br/>
        /// Optionally supply a `test_context` with stand-in agent metadata, secrets, and session metadata. The `$ref`s in the tool's stored `tool_configurations` resolve against these values.<br/>
        /// The function runs in a secure sandbox environment with the same constraints as production.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_python_function_123
        /// </param>
        /// <param name="input">
        /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
        /// Example: {"number":42,"text":"Hello, world!"}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds for this test. Overrides `execution_configuration` if specified. When omitted, the tool's stored `execution_configuration` timeout applies in full — up to 21600 seconds — and a tool with none runs at 30 seconds. A budget longer than 300 seconds requires `stream_response` to be true; a non-streaming request with a larger budget is rejected.<br/>
        /// Example: 10
        /// </param>
        /// <param name="streamResponse">
        /// When true, the response is streamed as Server-sent Events. While the test runs the platform sends zero or more `heartbeat` events, then exactly one terminal `result` event carrying the same object the non-streaming response returns. A platform failure after the stream has started closes the connection without a `result`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="testContext">
        /// Stand-in values for the hosting agent and session, used to resolve `agent.*` and `session.*` `$ref`s inside the tool configurations under test. Accepted by both `POST /v2/tools/test` and `POST /v2/tools/{tool_id}/test`.<br/>
        /// Example: {"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vectara.TestToolStreamedResponse> TestAsStreamAsync(
            string toolId,
            object input,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? timeoutSeconds = default,
            bool? streamResponse = default,
            global::Vectara.TestLambdaToolContext? testContext = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}