
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single snapshot of the agent's memory at a specific version.
    /// </summary>
    public sealed partial class AgentMemoryVersion
    {
        /// <summary>
        /// The version number of this snapshot.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The full memory content at this version.<br/>
        /// Example: - Customer prefers email contact<br/>
        /// - Time zone: PST
        /// </summary>
        /// <example>
        /// - Customer prefers email contact<br/>
        /// - Time zone: PST
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The time this version was recorded.<br/>
        /// Example: 2026-05-29T18:00:00Z
        /// </summary>
        /// <example>2026-05-29T18:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The identifier of whoever recorded this version.<br/>
        /// Example: query_handler
        /// </summary>
        /// <example>query_handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryVersion" /> class.
        /// </summary>
        /// <param name="version">
        /// The version number of this snapshot.<br/>
        /// Example: 2
        /// </param>
        /// <param name="content">
        /// The full memory content at this version.<br/>
        /// Example: - Customer prefers email contact<br/>
        /// - Time zone: PST
        /// </param>
        /// <param name="timestamp">
        /// The time this version was recorded.<br/>
        /// Example: 2026-05-29T18:00:00Z
        /// </param>
        /// <param name="updatedBy">
        /// The identifier of whoever recorded this version.<br/>
        /// Example: query_handler
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMemoryVersion(
            int version,
            string content,
            global::System.DateTime timestamp,
            string updatedBy)
        {
            this.Version = version;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Timestamp = timestamp;
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryVersion" /> class.
        /// </summary>
        public AgentMemoryVersion()
        {
        }

    }
}