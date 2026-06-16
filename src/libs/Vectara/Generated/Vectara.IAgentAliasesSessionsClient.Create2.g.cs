#nullable enable

namespace Vectara
{
    public partial interface IAgentAliasesSessionsClient
    {
        /// <summary>
        /// Create session via alias<br/>
        /// Create a new session by routing through an alias. The alias's policy is evaluated to pick the underlying agent that will own the session. Subsequent operations on the session can be addressed via this alias or directly via `/v2/agents/{resolved_agent_key}/sessions/{session_key}`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentSession> Create2Async(
            string aliasKey,

            global::Vectara.CreateAgentSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session via alias<br/>
        /// Create a new session by routing through an alias. The alias's policy is evaluated to pick the underlying agent that will own the session. Subsequent operations on the session can be addressed via this alias or directly via `/v2/agents/{resolved_agent_key}/sessions/{session_key}`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentSession>> Create2AsResponseAsync(
            string aliasKey,

            global::Vectara.CreateAgentSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session via alias<br/>
        /// Create a new session by routing through an alias. The alias's policy is evaluated to pick the underlying agent that will own the session. Subsequent operations on the session can be addressed via this alias or directly via `/v2/agents/{resolved_agent_key}/sessions/{session_key}`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="aliasKey">
        /// The unique key identifying an alias. Alias keys are independent of agent keys — the same string may exist as both an alias and an agent in a customer; calls to `/v2/agent_aliases/{key}/...` target the alias and calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// A short description of the session's purpose. If omitted, one is auto-generated once the session has produced events. Pass an empty string to suppress auto-generation.<br/>
        /// Example: Helping customer troubleshoot issues
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Default Value: {}<br/>
        /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
        /// </param>
        /// <param name="enabled">
        /// Whether the session should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </param>
        /// <param name="secrets">
        /// Session-scoped secrets to store on the new session. Map of secret name to plaintext value.<br/>
        /// Encrypted at rest with the owning agent's encryption key. Referenced from tool `argument_override` via<br/>
        /// `{"$ref": "session.secrets.&lt;name&gt;"}`. Returned masked (`****`) on reads.<br/>
        /// Example: {"slack_user_token":"xoxp-your-token-here"}
        /// </param>
        /// <param name="fromSession">
        /// Create a new session by forking an existing one. By default, copies all visible events<br/>
        /// and artifacts from the source session without compaction. Optionally specify exactly one of<br/>
        /// include_up_to_event_id or compact_up_to_event_id to control which events are included<br/>
        /// and whether they are compacted. These two fields are mutually exclusive.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentSession> Create2Async(
            string aliasKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            bool? enabled = default,
            long? ttiMinutes = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            global::Vectara.CreateAgentSessionRequestFromSession? fromSession = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}