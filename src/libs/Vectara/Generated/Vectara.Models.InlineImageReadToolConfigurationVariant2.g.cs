
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineImageReadToolConfigurationVariant2
    {
        /// <summary>
        /// The type of tool configuration, which is always 'image_read' for inline image read tool configurations.<br/>
        /// Default Value: image_read
        /// </summary>
        /// <default>"image_read"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "image_read";

        /// <summary>
        /// Configurable parameters for the image read tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.ImageReadToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineImageReadToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'image_read' for inline image read tool configurations.<br/>
        /// Default Value: image_read
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the image read tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineImageReadToolConfigurationVariant2(
            string type,
            global::Vectara.ImageReadToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineImageReadToolConfigurationVariant2" /> class.
        /// </summary>
        public InlineImageReadToolConfigurationVariant2()
        {
        }

    }
}