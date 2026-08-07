#nullable enable

namespace Vectara
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete an API key<br/>
        /// Deletes an API key. Delete a key when it is no longer needed or when it is compromised.<br/>
        /// Users that hold none of the `corpus_administrator`, `administrator`, or `owner` roles can only delete their own personal API key; a key that exists but belongs to another user returns a `404` error. Machine credentials — API keys, app clients, and service accounts — without one of those three roles cannot call this operation.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an API key<br/>
        /// Deletes an API key. Delete a key when it is no longer needed or when it is compromised.<br/>
        /// Users that hold none of the `corpus_administrator`, `administrator`, or `owner` roles can only delete their own personal API key; a key that exists but belongs to another user returns a `404` error. Machine credentials — API keys, app clients, and service accounts — without one of those three roles cannot call this operation.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string apiKeyId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}