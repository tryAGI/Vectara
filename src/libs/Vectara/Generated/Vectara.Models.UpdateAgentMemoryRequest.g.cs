
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Replace the agent's `_learned_memory` content. The submitted `content` fully replaces the previous memory.
    /// </summary>
    public sealed partial class UpdateAgentMemoryRequest
    {
        /// <summary>
        /// The full memory content to store. Replaces the previous content entirely.<br/>
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
        /// Identifier of who is performing this update (e.g. `query_handler`, `manual_update`).<br/>
        /// Example: query_handler
        /// </summary>
        /// <example>query_handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// The `memory_version` the client last read. If provided and it does not match the current version, the update is<br/>
        /// rejected with `409 Conflict`. Omit to update unconditionally.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_version")]
        public int? ExpectedVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentMemoryRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The full memory content to store. Replaces the previous content entirely.<br/>
        /// Example: - Customer prefers email contact<br/>
        /// - Time zone: PST
        /// </param>
        /// <param name="updatedBy">
        /// Identifier of who is performing this update (e.g. `query_handler`, `manual_update`).<br/>
        /// Example: query_handler
        /// </param>
        /// <param name="expectedVersion">
        /// The `memory_version` the client last read. If provided and it does not match the current version, the update is<br/>
        /// rejected with `409 Conflict`. Omit to update unconditionally.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentMemoryRequest(
            string content,
            string updatedBy,
            int? expectedVersion)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.ExpectedVersion = expectedVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentMemoryRequest" /> class.
        /// </summary>
        public UpdateAgentMemoryRequest()
        {
        }

    }
}