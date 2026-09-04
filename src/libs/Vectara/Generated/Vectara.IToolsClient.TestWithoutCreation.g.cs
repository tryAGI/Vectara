#nullable enable

namespace Vectara
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test Lambda tool without creation<br/>
        /// Tests a Lambda tool without creating it.<br/>
        /// Use this to:<br/>
        /// - Validate Python code syntax and security constraints<br/>
        /// - Discover input/output schemas from type annotations<br/>
        /// - Test execution with sample input<br/>
        /// - Verify schema compatibility<br/>
        /// - Exercise the lambda tool's `tool_configurations` with a stand-in `test_context` that supplies the agent metadata, secrets, and session metadata its `$ref`s resolve against<br/>
        /// The function runs in the same secure sandbox environment as production tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TestLambdaToolResponse> TestWithoutCreationAsync(

            global::Vectara.TestLambdaToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Lambda tool without creation<br/>
        /// Tests a Lambda tool without creating it.<br/>
        /// Use this to:<br/>
        /// - Validate Python code syntax and security constraints<br/>
        /// - Discover input/output schemas from type annotations<br/>
        /// - Test execution with sample input<br/>
        /// - Verify schema compatibility<br/>
        /// - Exercise the lambda tool's `tool_configurations` with a stand-in `test_context` that supplies the agent metadata, secrets, and session metadata its `$ref`s resolve against<br/>
        /// The function runs in the same secure sandbox environment as production tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.TestLambdaToolResponse>> TestWithoutCreationAsResponseAsync(

            global::Vectara.TestLambdaToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Lambda tool without creation<br/>
        /// Tests a Lambda tool without creating it.<br/>
        /// Use this to:<br/>
        /// - Validate Python code syntax and security constraints<br/>
        /// - Discover input/output schemas from type annotations<br/>
        /// - Test execution with sample input<br/>
        /// - Verify schema compatibility<br/>
        /// - Exercise the lambda tool's `tool_configurations` with a stand-in `test_context` that supplies the agent metadata, secrets, and session metadata its `$ref`s resolve against<br/>
        /// The function runs in the same secure sandbox environment as production tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="language">
        /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </param>
        /// <param name="code">
        /// The Python 3.12 code for the function. Must define a `process()` entry point.<br/>
        /// Object parameters must use `TypedDict`; validation rejects bare `dict` and `Dict[K, V]` parameters.<br/>
        /// See the `code` field on `CreateLambdaToolRequest` for full details and examples.<br/>
        /// Example: def process(order_count: int, total_revenue: float) -&gt; dict:<br/>
        ///     score = order_count * 10 + total_revenue * 0.1<br/>
        ///     return {'score': round(score, 2)}
        /// </param>
        /// <param name="executionConfiguration">
        /// Execution configuration for the function.
        /// </param>
        /// <param name="testInput">
        /// The input parameters to test the function with. The platform validates them against the discovered input schema.<br/>
        /// Example: {"order_count":10,"total_revenue":500}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds for this test. Overrides `execution_configuration` if specified. When omitted, the supplied `execution_configuration` timeout applies in full — up to 21600 seconds — and a request with none runs at 30 seconds. A budget longer than 300 seconds requires `stream_response` to be true; a non-streaming request with a larger budget is rejected.<br/>
        /// Example: 10
        /// </param>
        /// <param name="streamResponse">
        /// When true, the response is streamed as Server-sent Events. While the test runs the platform sends zero or more `heartbeat` events, then exactly one terminal `result` event carrying the same object the non-streaming response returns. A platform failure after the stream has started closes the connection without a `result`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolConfigurations">
        /// Named configurations of other tools the code under test may invoke through its built-in `tool` module.<br/>
        /// See the `tool_configurations` field on `CreateLambdaToolRequest` for semantics and constraints.
        /// </param>
        /// <param name="testContext">
        /// Stand-in values for the hosting agent and session, used to resolve `agent.*` and `session.*` `$ref`s inside the tool configurations under test. Accepted by both `POST /v2/tools/test` and `POST /v2/tools/{tool_id}/test`.<br/>
        /// Example: {"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TestLambdaToolResponse> TestWithoutCreationAsync(
            string code,
            object testInput,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.TestLambdaToolRequestLanguage? language = default,
            global::Vectara.ExecutionConfiguration? executionConfiguration = default,
            int? timeoutSeconds = default,
            bool? streamResponse = default,
            global::System.Collections.Generic.Dictionary<string, global::Vectara.AgentToolConfiguration>? toolConfigurations = default,
            global::Vectara.TestLambdaToolContext? testContext = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}