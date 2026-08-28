
#nullable enable

namespace Vectara
{
    /// <summary>
    /// An agent session owned by an end user, containing the fields that user may read.
    /// </summary>
    public sealed partial class EndUserSession
    {
        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </summary>
        /// <example>Customer Support Session</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A short description of the session's purpose.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </summary>
        /// <example>Helping customer troubleshoot widget installation issues</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the session is currently active and can accept new messages.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Lifecycle status of the session. `unstarted` before the session receives any event, `running` while the agent is producing<br/>
        /// events, and `stopped` when the session is idle with no event in flight.<br/>
        /// Included only in responses<br/>
        /// Example: stopped
        /// </summary>
        /// <example>stopped</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.EndUserSessionStatusJsonConverter))]
        public global::Vectara.EndUserSessionStatus? Status { get; set; }

        /// <summary>
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session is automatically deleted. If set to 0, the session does not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tti_minutes")]
        public long? TtiMinutes { get; set; }

        /// <summary>
        /// Timestamp when the session was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserSession" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="enabled">
        /// Whether the session is currently active and can accept new messages.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the session was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="description">
        /// A short description of the session's purpose.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </param>
        /// <param name="status">
        /// Lifecycle status of the session. `unstarted` before the session receives any event, `running` while the agent is producing<br/>
        /// events, and `stopped` when the session is idle with no event in flight.<br/>
        /// Included only in responses<br/>
        /// Example: stopped
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session is automatically deleted. If set to 0, the session does not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserSession(
            string key,
            string name,
            bool enabled,
            global::System.DateTime createdAt,
            string? description,
            global::Vectara.EndUserSessionStatus? status,
            long? ttiMinutes)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Enabled = enabled;
            this.Status = status;
            this.TtiMinutes = ttiMinutes;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserSession" /> class.
        /// </summary>
        public EndUserSession()
        {
        }

    }
}