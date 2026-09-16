#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesClient
    {
        /// <summary>
        /// Update agent connector<br/>
        /// Updates an agent connector's configuration, status, or other properties.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="connectorId">
        /// The globally unique identifier of a connector.<br/>
        /// Example: con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentConnector> UpdateConnectorAsync(
            string aliasKey,
            string connectorId,

            global::Vectara.UpdateAgentConnectorRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent connector<br/>
        /// Updates an agent connector's configuration, status, or other properties.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="connectorId">
        /// The globally unique identifier of a connector.<br/>
        /// Example: con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentConnector>> UpdateConnectorAsResponseAsync(
            string aliasKey,
            string connectorId,

            global::Vectara.UpdateAgentConnectorRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent connector<br/>
        /// Updates an agent connector's configuration, status, or other properties.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="connectorId">
        /// The globally unique identifier of a connector.<br/>
        /// Example: con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8
        /// </param>
        /// <param name="name">
        /// The human-readable name of the connector.<br/>
        /// Example: Updated Customer Support Slack Channel
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Updated description for the Slack connector
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the connector.<br/>
        /// Example: {"priority":"medium","department":"customer_service","last_reviewed":"2024-01-15"}
        /// </param>
        /// <param name="enabled">
        /// Whether the connector is enabled.<br/>
        /// Example: false
        /// </param>
        /// <param name="configuration">
        /// Write view of a connector's configuration, supplied on update. Discriminated by `type`, which must equal the connector's stored type.<br/>
        /// Slack, Google Chat, and Zoom configurations are supplied in full and replace the stored configuration wholesale, exactly as on create; caller-omitted platform-generated fields (such as the Zoom `connector_token`) are preserved.<br/>
        /// A widget configuration is the exception: it updates partially, so a supplied field replaces the stored one while an omitted field keeps it — see `UpdateWidgetConnectorConfiguration`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentConnector> UpdateConnectorAsync(
            string aliasKey,
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            bool? enabled = default,
            global::Vectara.UpdateConnectorConfiguration? configuration = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}