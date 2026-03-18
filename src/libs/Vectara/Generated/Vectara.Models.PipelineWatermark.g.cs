
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Tracks incremental sync progress. The value is opaque and source-specific (e.g. a timestamp or change token).<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class PipelineWatermark
    {
        /// <summary>
        /// The current watermark value.<br/>
        /// Example: 2026-02-19T08:00:00Z
        /// </summary>
        /// <example>2026-02-19T08:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// When the watermark was last advanced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineWatermark" /> class.
        /// </summary>
        /// <param name="value">
        /// The current watermark value.<br/>
        /// Example: 2026-02-19T08:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// When the watermark was last advanced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineWatermark(
            string value,
            global::System.DateTime updatedAt)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineWatermark" /> class.
        /// </summary>
        public PipelineWatermark()
        {
        }
    }
}