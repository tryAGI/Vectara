
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single bin's count within a distribution response point. The bin's numeric range is declared on the metric's descriptor under `bins[].range_min` / `bins[].range_max`, keyed by `label`. Only bins with non-zero counts are included; descriptor bins absent from a response point have a count of zero.
    /// </summary>
    public sealed partial class HistogramBin
    {
        /// <summary>
        /// Bin label matching one of the labels declared on the metric's descriptor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Count of observations whose value fell in this bin for this time window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramBin" /> class.
        /// </summary>
        /// <param name="label">
        /// Bin label matching one of the labels declared on the metric's descriptor.
        /// </param>
        /// <param name="value">
        /// Count of observations whose value fell in this bin for this time window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistogramBin(
            string label,
            long value)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramBin" /> class.
        /// </summary>
        public HistogramBin()
        {
        }

    }
}