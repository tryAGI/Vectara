
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single bin in a distribution histogram. `upper_ms` is null for the overflow bin (everything ≥ the lower bound).
    /// </summary>
    public sealed partial class HistogramBin
    {
        /// <summary>
        /// Inclusive lower bound of the bin in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LowerMs { get; set; }

        /// <summary>
        /// Exclusive upper bound of the bin in milliseconds. Null for the overflow bin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper_ms")]
        public double? UpperMs { get; set; }

        /// <summary>
        /// Number of observations whose duration fell in `[lower_ms, upper_ms)`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramBin" /> class.
        /// </summary>
        /// <param name="lowerMs">
        /// Inclusive lower bound of the bin in milliseconds.
        /// </param>
        /// <param name="count">
        /// Number of observations whose duration fell in `[lower_ms, upper_ms)`.
        /// </param>
        /// <param name="upperMs">
        /// Exclusive upper bound of the bin in milliseconds. Null for the overflow bin.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistogramBin(
            double lowerMs,
            long count,
            double? upperMs)
        {
            this.LowerMs = lowerMs;
            this.UpperMs = upperMs;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramBin" /> class.
        /// </summary>
        public HistogramBin()
        {
        }

    }
}