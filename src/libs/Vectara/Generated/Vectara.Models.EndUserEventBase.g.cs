
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all end-user event types.
    /// </summary>
    public sealed partial class EndUserEventBase
    {
        /// <summary>
        /// The unique identifier for the event.<br/>
        /// Example: aev_3Kx9QpVn2mZr8YbLc5TdWe
        /// </summary>
        /// <example>aev_3Kx9QpVn2mZr8YbLc5TdWe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionKey { get; set; }

        /// <summary>
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserEventBase" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the event.<br/>
        /// Example: aev_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserEventBase(
            string id,
            string sessionKey,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserEventBase" /> class.
        /// </summary>
        public EndUserEventBase()
        {
        }

    }
}