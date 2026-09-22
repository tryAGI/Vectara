
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single time-bin point for a counter or gauge metric.
    /// </summary>
    public sealed partial class ScalarMetricPoint
    {
        /// <summary>
        /// The start of the time bin in ISO 8601 (UTC). Bins lie on a grid of `bin_size_seconds` anchored at the Unix epoch, except when `max_bins` is 1, where the single bin starts at `start` rounded down to the nearest five-minute boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BinStart { get; set; }

        /// <summary>
        /// The aggregated value for this bin.
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
        /// Initializes a new instance of the <see cref="ScalarMetricPoint" /> class.
        /// </summary>
        /// <param name="binStart">
        /// The start of the time bin in ISO 8601 (UTC). Bins lie on a grid of `bin_size_seconds` anchored at the Unix epoch, except when `max_bins` is 1, where the single bin starts at `start` rounded down to the nearest five-minute boundary.
        /// </param>
        /// <param name="value">
        /// The aggregated value for this bin.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalarMetricPoint(
            global::System.DateTime binStart,
            double value)
        {
            this.BinStart = binStart;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarMetricPoint" /> class.
        /// </summary>
        public ScalarMetricPoint()
        {
        }

    }
}