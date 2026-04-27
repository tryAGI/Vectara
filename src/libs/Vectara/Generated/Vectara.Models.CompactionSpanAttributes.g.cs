
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for a compaction span.
    /// </summary>
    public sealed partial class CompactionSpanAttributes
    {
        /// <summary>
        /// Number of conversation turns compacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns_compacted")]
        public long? TurnsCompacted { get; set; }

        /// <summary>
        /// Number of events hidden by compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_compacted")]
        public long? EventsCompacted { get; set; }

        /// <summary>
        /// Key of the summary created by compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_key")]
        public string? SummaryKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSpanAttributes" /> class.
        /// </summary>
        /// <param name="turnsCompacted">
        /// Number of conversation turns compacted.
        /// </param>
        /// <param name="eventsCompacted">
        /// Number of events hidden by compaction.
        /// </param>
        /// <param name="summaryKey">
        /// Key of the summary created by compaction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionSpanAttributes(
            long? turnsCompacted,
            long? eventsCompacted,
            string? summaryKey)
        {
            this.TurnsCompacted = turnsCompacted;
            this.EventsCompacted = eventsCompacted;
            this.SummaryKey = summaryKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSpanAttributes" /> class.
        /// </summary>
        public CompactionSpanAttributes()
        {
        }
    }
}