
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single entry in a percentiles array. On a metric descriptor, `value` is the percentile rank (a fraction in [0, 1], e.g. `0.95` for p95). On a response point, `value` is the aggregated metric value at that percentile (e.g. duration in ms). The `label` is the stable key matching descriptor and point entries.
    /// </summary>
    public sealed partial class PercentileEntry
    {
        /// <summary>
        /// Stable identifier for this percentile (e.g. `p50`, `p99`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Numeric value — the percentile rank on the descriptor, the aggregated value on a response point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileEntry" /> class.
        /// </summary>
        /// <param name="label">
        /// Stable identifier for this percentile (e.g. `p50`, `p99`).
        /// </param>
        /// <param name="value">
        /// Numeric value — the percentile rank on the descriptor, the aggregated value on a response point.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentileEntry(
            string label,
            double value)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileEntry" /> class.
        /// </summary>
        public PercentileEntry()
        {
        }

    }
}