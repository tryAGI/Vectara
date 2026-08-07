#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vectara
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create an API key<br/>
        /// Creates an API key. You can bind the key to one or more corpora. A `personal` key has the same permissions as its owner; any other key carries exactly the roles assigned to it with `api_roles`, `corpus_roles`, and `agent_roles`.<br/>
        /// Callers with the `corpus_administrator`, `administrator`, or `owner` role create any API key. Callers holding only other roles must set `api_key_role` to `personal`. Only a user can create a personal API key; a request authenticated with a machine credential — an API key, app client, or service account — receives a `403` error.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/security/authentication/api-key-management).<br/>
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
        /// Creates an API key. You can bind the key to one or more corpora. A `personal` key has the same permissions as its owner; any other key carries exactly the roles assigned to it with `api_roles`, `corpus_roles`, and `agent_roles`.<br/>
        /// Callers with the `corpus_administrator`, `administrator`, or `owner` role create any API key. Callers holding only other roles must set `api_key_role` to `personal`. Only a user can create a personal API key; a request authenticated with a machine credential — an API key, app client, or service account — receives a `403` error.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/security/authentication/api-key-management).<br/>
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
        /// Creates an API key. You can bind the key to one or more corpora. A `personal` key has the same permissions as its owner; any other key carries exactly the roles assigned to it with `api_roles`, `corpus_roles`, and `agent_roles`.<br/>
        /// Callers with the `corpus_administrator`, `administrator`, or `owner` role create any API key. Callers holding only other roles must set `api_key_role` to `personal`. Only a user can create a personal API key; a request authenticated with a machine credential — an API key, app client, or service account — receives a `403` error.<br/>
        /// :::note<br/>
        /// For more information about the different types of API keys, see [API Key Management](/docs/security/authentication/api-key-management).<br/>
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
        /// Set to `personal` to create a personal API key. The `serving` and `serving_and_indexing` values are deprecated: use `api_roles` instead.
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