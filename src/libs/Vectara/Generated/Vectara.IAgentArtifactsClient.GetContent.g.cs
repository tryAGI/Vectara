#nullable enable

namespace Vectara
{
    public partial interface IAgentArtifactsClient
    {
        /// <summary>
        /// Get session artifact raw bytes<br/>
        /// Returns the raw bytes of an artifact. Unlike `getSessionArtifact`, which returns a JSON wrapper with base64-encoded data, this endpoint returns the file content as the response body. The response uses the artifact's own `Content-Type`. Use this endpoint to dereference an artifact URL as a binary download, for example with A2A `FilePart.fileWithUri`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="artifactId">
        /// Example: art_report_pdf_a3f2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetContentAsync(
            string agentKey,
            string sessionKey,
            string artifactId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get session artifact raw bytes<br/>
        /// Returns the raw bytes of an artifact. Unlike `getSessionArtifact`, which returns a JSON wrapper with base64-encoded data, this endpoint returns the file content as the response body. The response uses the artifact's own `Content-Type`. Use this endpoint to dereference an artifact URL as a binary download, for example with A2A `FilePart.fileWithUri`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="artifactId">
        /// Example: art_report_pdf_a3f2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetContentAsStreamAsync(
            string agentKey,
            string sessionKey,
            string artifactId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get session artifact raw bytes<br/>
        /// Returns the raw bytes of an artifact. Unlike `getSessionArtifact`, which returns a JSON wrapper with base64-encoded data, this endpoint returns the file content as the response body. The response uses the artifact's own `Content-Type`. Use this endpoint to dereference an artifact URL as a binary download, for example with A2A `FilePart.fileWithUri`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="artifactId">
        /// Example: art_report_pdf_a3f2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<byte[]>> GetContentAsResponseAsync(
            string agentKey,
            string sessionKey,
            string artifactId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}