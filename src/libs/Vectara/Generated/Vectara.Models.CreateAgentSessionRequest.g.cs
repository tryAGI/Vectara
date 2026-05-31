
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a new agent session.
    /// </summary>
    public sealed partial class CreateAgentSessionRequest
    {
        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </summary>
        /// <example>Customer Support Session</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot issues
        /// </summary>
        /// <example>Helping customer troubleshoot issues</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the session.<br/>
        /// Default Value: {}<br/>
        /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
        /// </summary>
        /// <example>{"customer_id":"12345","priority":"medium","channel":"web_chat"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the session should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tti_minutes")]
        public long? TtiMinutes { get; set; }

        /// <summary>
        /// Session-scoped secrets to store on the new session. Map of secret name to plaintext value.<br/>
        /// Encrypted at rest with the owning agent's encryption key. Referenced from tool `argument_override` via<br/>
        /// `{"$ref": "session.secrets.&lt;name&gt;"}`. Returned masked (`****`) on reads.<br/>
        /// Example: {"slack_user_token":"xoxp-your-token-here"}
        /// </summary>
        /// <example>{"slack_user_token":"xoxp-your-token-here"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        /// Create a new session by forking an existing one. By default, copies all visible events<br/>
        /// and artifacts from the source session without compaction. Optionally specify exactly one of<br/>
        /// include_up_to_event_id or compact_up_to_event_id to control which events are included<br/>
        /// and whether they are compacted. These two fields are mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_session")]
        public global::Vectara.CreateAgentSessionRequestFromSession? FromSession { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionRequest(
            string? key,
            string? name,
            string? description,
            object? metadata,
            bool? enabled,
            long? ttiMinutes,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            global::Vectara.CreateAgentSessionRequestFromSession? fromSession)
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.TtiMinutes = ttiMinutes;
            this.Secrets = secrets;
            this.FromSession = fromSession;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequest" /> class.
        /// </summary>
        public CreateAgentSessionRequest()
        {
        }

    }
}