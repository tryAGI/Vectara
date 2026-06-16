
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Version and audit metadata for the agent's memory.
    /// </summary>
    public sealed partial class AgentMemoryMetadata
    {
        /// <summary>
        /// The current memory version. `0` means the agent has no memory yet; each update increments it by one.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryVersion { get; set; }

        /// <summary>
        /// The time of the most recent memory update, or `null` if the memory has never been updated.<br/>
        /// Example: 2026-05-29T18:30:00Z
        /// </summary>
        /// <example>2026-05-29T18:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_last_updated")]
        public global::System.DateTime? MemoryLastUpdated { get; set; }

        /// <summary>
        /// The identifier of whoever performed the most recent update, or `null` if never updated.<br/>
        /// Example: query_handler
        /// </summary>
        /// <example>query_handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_last_updated_by")]
        public string? MemoryLastUpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryMetadata" /> class.
        /// </summary>
        /// <param name="memoryVersion">
        /// The current memory version. `0` means the agent has no memory yet; each update increments it by one.<br/>
        /// Example: 3
        /// </param>
        /// <param name="memoryLastUpdated">
        /// The time of the most recent memory update, or `null` if the memory has never been updated.<br/>
        /// Example: 2026-05-29T18:30:00Z
        /// </param>
        /// <param name="memoryLastUpdatedBy">
        /// The identifier of whoever performed the most recent update, or `null` if never updated.<br/>
        /// Example: query_handler
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMemoryMetadata(
            int memoryVersion,
            global::System.DateTime? memoryLastUpdated,
            string? memoryLastUpdatedBy)
        {
            this.MemoryVersion = memoryVersion;
            this.MemoryLastUpdated = memoryLastUpdated;
            this.MemoryLastUpdatedBy = memoryLastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryMetadata" /> class.
        /// </summary>
        public AgentMemoryMetadata()
        {
        }

    }
}