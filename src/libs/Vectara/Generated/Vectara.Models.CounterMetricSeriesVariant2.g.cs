
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CounterMetricSeriesVariant2
    {
        /// <summary>
        /// Default Value: counter<br/>
        /// Example: counter
        /// </summary>
        /// <default>"counter"</default>
        /// <example>counter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; } = "counter";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.ScalarMetricPoint> Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterMetricSeriesVariant2" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: counter<br/>
        /// Example: counter
        /// </param>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CounterMetricSeriesVariant2(
            string kind,
            global::System.Collections.Generic.IList<global::Vectara.ScalarMetricPoint> points)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterMetricSeriesVariant2" /> class.
        /// </summary>
        public CounterMetricSeriesVariant2()
        {
        }

    }
}