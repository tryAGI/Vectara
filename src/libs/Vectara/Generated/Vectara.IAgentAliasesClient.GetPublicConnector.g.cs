#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesClient
    {
        /// <summary>
        /// Get public connector<br/>
        /// The public view of a connector, served unauthenticated to the embed snippet. The snippet carries the alias key and the connector's globally unique id, which expose no agent or customer identifier.<br/>
        /// Returns the `customer_id` visitor minting is addressed to, the `presentation` to render, whether anonymous visitors are admitted (`public_access`), and the sign-in configuration when the widget offers one.<br/>
        /// A read with no side effects: minting an anonymous visitor id is a separate call, `POST /v2/visitors`, so a returning visitor who already holds an id only reads this view.<br/>
        /// The view tells the client how to authenticate: `public_access` true — mint or present a visitor id; `end_user_sign_in` present — sign the user in through the referenced issuer. A widget may offer both, and the two follow-up calls do not depend on each other.<br/>
        /// This operation serves only the public projection; operators read the full connector, configuration included, from the connector list.<br/>
        /// Serves connectors that front an end-user surface — today, widget connectors. Returns `404` if the connector does not exist on the addressed alias, is a channel connector with no end-user surface (Slack, Google Chat, or Zoom), is disabled, or belongs to a disabled customer.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.PublicConnector> GetPublicConnectorAsync(
            string aliasKey,
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public connector<br/>
        /// The public view of a connector, served unauthenticated to the embed snippet. The snippet carries the alias key and the connector's globally unique id, which expose no agent or customer identifier.<br/>
        /// Returns the `customer_id` visitor minting is addressed to, the `presentation` to render, whether anonymous visitors are admitted (`public_access`), and the sign-in configuration when the widget offers one.<br/>
        /// A read with no side effects: minting an anonymous visitor id is a separate call, `POST /v2/visitors`, so a returning visitor who already holds an id only reads this view.<br/>
        /// The view tells the client how to authenticate: `public_access` true — mint or present a visitor id; `end_user_sign_in` present — sign the user in through the referenced issuer. A widget may offer both, and the two follow-up calls do not depend on each other.<br/>
        /// This operation serves only the public projection; operators read the full connector, configuration included, from the connector list.<br/>
        /// Serves connectors that front an end-user surface — today, widget connectors. Returns `404` if the connector does not exist on the addressed alias, is a channel connector with no end-user surface (Slack, Google Chat, or Zoom), is disabled, or belongs to a disabled customer.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.PublicConnector>> GetPublicConnectorAsResponseAsync(
            string aliasKey,
            string connectorId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}