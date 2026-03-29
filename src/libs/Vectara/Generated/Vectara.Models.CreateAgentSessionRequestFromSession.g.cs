
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Create a new session by forking an existing one. By default, copies all visible events<br/>
    /// and artifacts from the source session without compaction. Optionally specify exactly one of<br/>
    /// include_up_to_event_id or compact_up_to_event_id to control which events are included<br/>
    /// and whether they are compacted. These two fields are mutually exclusive.
    /// </summary>
    public sealed partial class CreateAgentSessionRequestFromSession
    {
        /// <summary>
        /// Agent key of the source session (defaults to current agent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        public string? AgentKey { get; set; }

        /// <summary>
        /// Session key of the source session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionKey { get; set; }

        /// <summary>
        /// Only include events up to and including this event ID from the source session,<br/>
        /// copying them verbatim. Events after this ID are excluded. If null (the default),<br/>
        /// all visible events are included. Mutually exclusive with compact_up_to_event_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_up_to_event_id")]
        public string? IncludeUpToEventId { get; set; }

        /// <summary>
        /// Compact all source events up to this event ID into a summary instead of<br/>
        /// copying them verbatim. If null (the default), events are copied verbatim.<br/>
        /// Mutually exclusive with include_up_to_event_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_up_to_event_id")]
        public string? CompactUpToEventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequestFromSession" /> class.
        /// </summary>
        /// <param name="sessionKey">
        /// Session key of the source session.
        /// </param>
        /// <param name="agentKey">
        /// Agent key of the source session (defaults to current agent).
        /// </param>
        /// <param name="includeUpToEventId">
        /// Only include events up to and including this event ID from the source session,<br/>
        /// copying them verbatim. Events after this ID are excluded. If null (the default),<br/>
        /// all visible events are included. Mutually exclusive with compact_up_to_event_id.
        /// </param>
        /// <param name="compactUpToEventId">
        /// Compact all source events up to this event ID into a summary instead of<br/>
        /// copying them verbatim. If null (the default), events are copied verbatim.<br/>
        /// Mutually exclusive with include_up_to_event_id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionRequestFromSession(
            string sessionKey,
            string? agentKey,
            string? includeUpToEventId,
            string? compactUpToEventId)
        {
            this.AgentKey = agentKey;
            this.SessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));
            this.IncludeUpToEventId = includeUpToEventId;
            this.CompactUpToEventId = compactUpToEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequestFromSession" /> class.
        /// </summary>
        public CreateAgentSessionRequestFromSession()
        {
        }
    }
}