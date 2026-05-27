
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributionMetricDescriptorVariant2
    {
        /// <summary>
        /// Example: distribution
        /// </summary>
        /// <example>distribution</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Bins that this distribution may emit, in canonical order. Each bin has a stable label, an inclusive lower bound, and an exclusive upper bound (omitted for the overflow bin).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.DistributionBinDescriptor> Bins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionMetricDescriptorVariant2" /> class.
        /// </summary>
        /// <param name="kind">
        /// Example: distribution
        /// </param>
        /// <param name="bins">
        /// Bins that this distribution may emit, in canonical order. Each bin has a stable label, an inclusive lower bound, and an exclusive upper bound (omitted for the overflow bin).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributionMetricDescriptorVariant2(
            string kind,
            global::System.Collections.Generic.IList<global::Vectara.DistributionBinDescriptor> bins)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Bins = bins ?? throw new global::System.ArgumentNullException(nameof(bins));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionMetricDescriptorVariant2" /> class.
        /// </summary>
        public DistributionMetricDescriptorVariant2()
        {
        }

    }
}