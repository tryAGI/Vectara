#nullable enable

namespace Vectara
{
    public partial interface IA2aClient
    {
        /// <summary>
        /// Get A2A v1 task<br/>
        /// Fetch the current state of an A2A task in the v1 wire format — including its status, conversation history, and any produced artifacts.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="historyLength">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.A2aV1Task> GetV1TaskAsync(
            string agentKey,
            string taskId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? historyLength = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get A2A v1 task<br/>
        /// Fetch the current state of an A2A task in the v1 wire format — including its status, conversation history, and any produced artifacts.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="historyLength">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.A2aV1Task>> GetV1TaskAsResponseAsync(
            string agentKey,
            string taskId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? historyLength = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}