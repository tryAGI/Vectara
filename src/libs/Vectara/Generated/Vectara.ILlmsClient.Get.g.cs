#nullable enable

namespace Vectara
{
    public partial interface ILlmsClient
    {
        /// <summary>
        /// Get an LLM<br/>
        /// Returns the details of a Large Language Model (LLM) configured within the platform. The details include the name, description, model type, API endpoint, and authentication method.<br/>
        /// Use this endpoint to verify model configurations and confirm connectivity details.<br/>
        /// ## Authentication methods<br/>
        /// The LLM's authentication is configured either as a Bearer token or as custom header-based authentication.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Llm> GetAsync(
            string llmId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an LLM<br/>
        /// Returns the details of a Large Language Model (LLM) configured within the platform. The details include the name, description, model type, API endpoint, and authentication method.<br/>
        /// Use this endpoint to verify model configurations and confirm connectivity details.<br/>
        /// ## Authentication methods<br/>
        /// The LLM's authentication is configured either as a Bearer token or as custom header-based authentication.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.Llm>> GetAsResponseAsync(
            string llmId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}