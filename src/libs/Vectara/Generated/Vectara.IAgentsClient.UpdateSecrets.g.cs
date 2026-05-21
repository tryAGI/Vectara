#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent secrets<br/>
        /// Patch the agent's secrets. Names present in the map are added or replaced; names absent from the map are left unchanged.<br/>
        /// A name mapped to `null` is removed.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentSecrets> UpdateSecretsAsync(
            string agentKey,

            global::Vectara.UpdateAgentSecretsRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent secrets<br/>
        /// Patch the agent's secrets. Names present in the map are added or replaced; names absent from the map are left unchanged.<br/>
        /// A name mapped to `null` is removed.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentSecrets>> UpdateSecretsAsResponseAsync(
            string agentKey,

            global::Vectara.UpdateAgentSecretsRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent secrets<br/>
        /// Patch the agent's secrets. Names present in the map are added or replaced; names absent from the map are left unchanged.<br/>
        /// A name mapped to `null` is removed.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="secrets">
        /// Map of secret name to plaintext value (or `null` to remove). Names not in the map are not touched.<br/>
        /// Example: {"jira_api_token":"ATATT3xFf...","old_token_to_remove":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentSecrets> UpdateSecretsAsync(
            string agentKey,
            global::System.Collections.Generic.Dictionary<string, string?> secrets,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}