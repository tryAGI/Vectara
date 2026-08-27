#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent connector<br/>
        /// Updates an agent connector's configuration, status, or other properties.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="connectorId">
        /// Example: con_slack_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentConnector> UpdateConnectorAsync(
            string agentKey,
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
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="connectorId">
        /// Example: con_slack_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentConnector>> UpdateConnectorAsResponseAsync(
            string agentKey,
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
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="connectorId">
        /// Example: con_slack_support
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
        /// <param name="publicAccess">
        /// Whether the connector admits anonymous visitors. Only accepted for<br/>
        /// `widget` connectors; rejected for other types. Setting it to `false`<br/>
        /// refuses every previously minted visitor id; the change takes effect within a few seconds.<br/>
        /// Example: false
        /// </param>
        /// <param name="configuration">
        /// Write view of a connector's configuration. Used when creating a connector<br/>
        /// and reused when updating one. Carries the secrets and inputs the customer<br/>
        /// must supply. Platform-derived display fields are not accepted here and instead<br/>
        /// appear in the read view:<br/>
        /// - Slack returns `webhook_path`<br/>
        /// - gchat returns `audience_url` and `client_email`<br/>
        /// - zoom returns the generated `connector_token` and `webhook_path`<br/>
        /// - widget returns `bootstrap_path`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentConnector> UpdateConnectorAsync(
            string agentKey,
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            bool? enabled = default,
            bool? publicAccess = default,
            global::Vectara.CreateConnectorConfiguration? configuration = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}