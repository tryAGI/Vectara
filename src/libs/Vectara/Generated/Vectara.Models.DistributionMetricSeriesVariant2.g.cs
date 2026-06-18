
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributionMetricSeriesVariant2
    {
        /// <summary>
        /// Example: distribution
        /// </summary>
        /// <example>distribution</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint> Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionMetricSeriesVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: distribution
        /// </param>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributionMetricSeriesVariant2(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint> points)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionMetricSeriesVariant2" /> class.
        /// </summary>
        public DistributionMetricSeriesVariant2()
        {
        }

    }
}