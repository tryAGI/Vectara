
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CounterMetricDescriptorVariant2
    {
        /// <summary>
        /// Example: counter
        /// </summary>
        /// <example>counter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterMetricDescriptorVariant2" /> class.
        /// </summary>
        /// <param name="kind">
        /// Example: counter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CounterMetricDescriptorVariant2(
            string kind)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterMetricDescriptorVariant2" /> class.
        /// </summary>
        public CounterMetricDescriptorVariant2()
        {
        }

    }
}