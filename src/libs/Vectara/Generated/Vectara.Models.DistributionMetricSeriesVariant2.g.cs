
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributionMetricSeriesVariant2
    {
        /// <summary>
        /// Default Value: distribution<br/>
        /// Example: distribution
        /// </summary>
        /// <default>"distribution"</default>
        /// <example>distribution</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; } = "distribution";

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
        /// <param name="kind">
        /// Default Value: distribution<br/>
        /// Example: distribution
        /// </param>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributionMetricSeriesVariant2(
            string kind,
            global::System.Collections.Generic.IList<global::Vectara.DistributionMetricPoint> points)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
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