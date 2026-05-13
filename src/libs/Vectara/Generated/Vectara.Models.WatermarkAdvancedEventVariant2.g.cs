
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatermarkAdvancedEventVariant2
    {
        /// <summary>
        /// Default Value: watermark_advanced
        /// </summary>
        /// <default>"watermark_advanced"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "watermark_advanced";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Watermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkAdvancedEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: watermark_advanced
        /// </param>
        /// <param name="watermark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkAdvancedEventVariant2(
            string type,
            string watermark)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Watermark = watermark ?? throw new global::System.ArgumentNullException(nameof(watermark));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkAdvancedEventVariant2" /> class.
        /// </summary>
        public WatermarkAdvancedEventVariant2()
        {
        }

    }
}