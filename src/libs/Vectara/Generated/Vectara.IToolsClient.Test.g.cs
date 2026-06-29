#nullable enable

namespace Vectara
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test Lambda tool<br/>
        /// Execute a Lambda tool with test inputs to verify it works correctly.<br/>
        /// This endpoint allows users to test their functions before using them with agents.<br/>
        /// Optionally supply a `test_context` to provide stand-in agent metadata, secrets, and session metadata that the `$ref`s in the tool's stored `tool_configurations` resolve against.<br/>
        /// The function is executed in a secure sandbox environment with the same constraints as production.
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
        global::System.Threading.Tasks.Task<global::Vectara.TestToolResponse> TestAsync(
            string toolId,

            global::Vectara.TestToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Lambda tool<br/>
        /// Execute a Lambda tool with test inputs to verify it works correctly.<br/>
        /// This endpoint allows users to test their functions before using them with agents.<br/>
        /// Optionally supply a `test_context` to provide stand-in agent metadata, secrets, and session metadata that the `$ref`s in the tool's stored `tool_configurations` resolve against.<br/>
        /// The function is executed in a secure sandbox environment with the same constraints as production.
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.TestToolResponse>> TestAsResponseAsync(
            string toolId,

            global::Vectara.TestToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Lambda tool<br/>
        /// Execute a Lambda tool with test inputs to verify it works correctly.<br/>
        /// This endpoint allows users to test their functions before using them with agents.<br/>
        /// Optionally supply a `test_context` to provide stand-in agent metadata, secrets, and session metadata that the `$ref`s in the tool's stored `tool_configurations` resolve against.<br/>
        /// The function is executed in a secure sandbox environment with the same constraints as production.
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
        /// Maximum execution time in seconds. If not specified, uses the tool's configured timeout.<br/>
        /// Example: 10
        /// </param>
        /// <param name="testContext">
        /// Stand-in values for the hosting agent and session, used to resolve `agent.*` and `session.*` `$ref`s inside the tool configurations under test. Accepted by both `POST /v2/tools/test` and `POST /v2/tools/{tool_id}/test`.<br/>
        /// Example: {"agent":{"metadata":{"ticket_api_base":"https://tickets.example.com/api/v1/"},"secrets":{"ticket_api_token":"test-token"}},"session":{"metadata":{"tenant_corpus":"kb"}}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.TestToolResponse> TestAsync(
            string toolId,
            object input,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? timeoutSeconds = default,
            global::Vectara.TestLambdaToolContext? testContext = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}