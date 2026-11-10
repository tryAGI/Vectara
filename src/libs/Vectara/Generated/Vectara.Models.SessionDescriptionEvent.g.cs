
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The current description of the session (SSE only, not stored).<br/>
    /// The stream carries this event when the platform generates a description, and when a stream opens on a session that already has one.<br/>
    /// The event can repeat. Each occurrence replaces the previous value.
    /// </summary>
    public sealed partial class SessionDescriptionEvent
    {
        /// <summary>
        /// The type of streaming event.<br/>
        /// Default Value: session_description<br/>
        /// Example: session_description
        /// </summary>
        /// <default>"session_description"</default>
        /// <example>session_description</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "session_description";

        /// <summary>
        /// The session's description.<br/>
        /// Example: Troubleshooting widget installation
        /// </summary>
        /// <example>Troubleshooting widget installation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionDescriptionEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: session_description<br/>
        /// Example: session_description
        /// </param>
        /// <param name="description">
        /// The session's description.<br/>
        /// Example: Troubleshooting widget installation
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionDescriptionEvent(
            string type,
            string description,
            global::System.DateTime createdAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDescriptionEvent" /> class.
        /// </summary>
        public SessionDescriptionEvent()
        {
        }

    }
}