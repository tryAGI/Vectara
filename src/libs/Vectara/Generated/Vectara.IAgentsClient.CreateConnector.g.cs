#nullable enable

namespace Vectara
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create agent connector<br/>
        /// Create a new connector for an agent to receive events from external platforms like Slack.
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
        global::System.Threading.Tasks.Task<global::Vectara.AgentConnector> CreateConnectorAsync(
            string agentKey,

            global::Vectara.CreateAgentConnectorRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent connector<br/>
        /// Create a new connector for an agent to receive events from external platforms like Slack.
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentConnector>> CreateConnectorAsResponseAsync(
            string agentKey,

            global::Vectara.CreateAgentConnectorRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent connector<br/>
        /// Create a new connector for an agent to receive events from external platforms like Slack.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of the connector.<br/>
        /// Example: Customer Support Slack Channel
        /// </param>
        /// <param name="description">
        /// A detailed description of what this connector does.<br/>
        /// Example: Receives customer support messages from the
        /// </param>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Example: slack
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the connector.<br/>
        /// Default Value: {}<br/>
        /// Example: {"priority":"high","department":"customer_service"}
        /// </param>
        /// <param name="enabled">
        /// Whether the connector should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="configuration">
        /// Configuration for different types of connectors.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentConnector> CreateConnectorAsync(
            string agentKey,
            string name,
            global::Vectara.SlackConnectorConfiguration configuration,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? description = default,
            global::Vectara.CreateAgentConnectorRequestType type = default,
            object? metadata = default,
            bool? enabled = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}