#nullable enable

namespace Vectara
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Get an API key<br/>
        /// Returns an API key. The response shows the corpora the key can access and with what permissions.<br/>
        /// Users that hold none of the `corpus_administrator`, `administrator`, or `owner` roles can only get their own personal API key; a key that exists but belongs to another user returns a `404` error. Machine credentials — API keys, app clients, and service accounts — without one of those three roles cannot call this operation.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ApiKey> GetAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an API key<br/>
        /// Returns an API key. The response shows the corpora the key can access and with what permissions.<br/>
        /// Users that hold none of the `corpus_administrator`, `administrator`, or `owner` roles can only get their own personal API key; a key that exists but belongs to another user returns a `404` error. Machine credentials — API keys, app clients, and service accounts — without one of those three roles cannot call this operation.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ApiKey>> GetAsResponseAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}