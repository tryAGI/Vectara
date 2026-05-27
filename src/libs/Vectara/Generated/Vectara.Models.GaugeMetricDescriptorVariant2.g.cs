
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GaugeMetricDescriptorVariant2
    {
        /// <summary>
        /// Example: gauge
        /// </summary>
        /// <example>gauge</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GaugeMetricDescriptorVariant2" /> class.
        /// </summary>
        /// <param name="kind">
        /// Example: gauge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GaugeMetricDescriptorVariant2(
            string kind)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GaugeMetricDescriptorVariant2" /> class.
        /// </summary>
        public GaugeMetricDescriptorVariant2()
        {
        }

    }
}