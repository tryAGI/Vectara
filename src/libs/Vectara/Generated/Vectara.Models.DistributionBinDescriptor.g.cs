
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single bin of a distribution metric. The numeric range `[range_min, range_max)` is in the units declared by the metric's `unit` field. The overflow bin (the one covering everything from the largest declared bound upward) omits `range_max`.
    /// </summary>
    public sealed partial class DistributionBinDescriptor
    {
        /// <summary>
        /// Stable identifier for this bin. Referenced from response points by `HistogramBin.label`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Inclusive lower bound of this bin's numeric range, in the metric's `unit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RangeMin { get; set; }

        /// <summary>
        /// Exclusive upper bound of this bin's numeric range, in the metric's `unit`. Omitted for the overflow bin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_max")]
        public double? RangeMax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionBinDescriptor" /> class.
        /// </summary>
        /// <param name="label">
        /// Stable identifier for this bin. Referenced from response points by `HistogramBin.label`.
        /// </param>
        /// <param name="rangeMin">
        /// Inclusive lower bound of this bin's numeric range, in the metric's `unit`.
        /// </param>
        /// <param name="rangeMax">
        /// Exclusive upper bound of this bin's numeric range, in the metric's `unit`. Omitted for the overflow bin.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributionBinDescriptor(
            string label,
            double rangeMin,
            double? rangeMax)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.RangeMin = rangeMin;
            this.RangeMax = rangeMax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionBinDescriptor" /> class.
        /// </summary>
        public DistributionBinDescriptor()
        {
        }

    }
}