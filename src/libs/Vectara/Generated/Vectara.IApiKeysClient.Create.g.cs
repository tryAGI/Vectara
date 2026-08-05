#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create an API key<br/>
        /// Creates an API key. You can bind the key to one or more corpora. Each key has one of these access levels:<br/>
        /// - Personal: the key has the same permissions as your user account.<br/>
        /// - Query only (read-only).<br/>
        /// - Query and index (read-write).<br/>
        /// For example, create a read-only key for an application that only queries data.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/deploy-and-scale/authentication/api-key-management).<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ApiKey> CreateAsync(

            global::Vectara.CreateApiKeyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key<br/>
        /// Creates an API key. You can bind the key to one or more corpora. Each key has one of these access levels:<br/>
        /// - Personal: the key has the same permissions as your user account.<br/>
        /// - Query only (read-only).<br/>
        /// - Query and index (read-write).<br/>
        /// For example, create a read-only key for an application that only queries data.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/deploy-and-scale/authentication/api-key-management).<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.ApiKey>> CreateAsResponseAsync(

            global::Vectara.CreateApiKeyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key<br/>
        /// Creates an API key. You can bind the key to one or more corpora. Each key has one of these access levels:<br/>
        /// - Personal: the key has the same permissions as your user account.<br/>
        /// - Query only (read-only).<br/>
        /// - Query and index (read-write).<br/>
        /// For example, create a read-only key for an application that only queries data.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/deploy-and-scale/authentication/api-key-management).<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="name">
        /// The human-readable name of the API key.
        /// </param>
        /// <param name="apiRoles">
        /// Customer-level roles for this API key.
        /// </param>
        /// <param name="apiKeyRole">
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific role assignments for this API key.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific role assignments for this API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ApiKey> CreateAsync(
            string name,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles = default,
            global::Vectara.ApiKeyRole? apiKeyRole = default,
            global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? corpusRoles = default,
            global::System.Collections.Generic.IList<global::Vectara.AgentRole>? agentRoles = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}