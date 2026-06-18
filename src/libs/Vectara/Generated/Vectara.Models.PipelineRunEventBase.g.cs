
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Common fields shared by all pipeline run events.
    /// </summary>
    public sealed partial class PipelineRunEventBase
    {
        /// <summary>
        /// Monotonic, unique-per-run identifier for this event.<br/>
        /// Example: evt_42
        /// </summary>
        /// <example>evt_42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the event occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurred_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime OccurredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRunEventBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Monotonic, unique-per-run identifier for this event.<br/>
        /// Example: evt_42
        /// </param>
        /// <param name="occurredAt">
        /// When the event occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineRunEventBase(
            string id,
            global::System.DateTime occurredAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OccurredAt = occurredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRunEventBase" /> class.
        /// </summary>
        public PipelineRunEventBase()
        {
        }

    }
}