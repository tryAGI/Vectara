
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentConversionToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `document_conversion`.<br/>
        /// Default Value: document_conversion<br/>
        /// Example: document_conversion
        /// </summary>
        /// <default>"document_conversion"</default>
        /// <example>document_conversion</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "document_conversion";

        /// <summary>
        /// Configurable parameters for the document conversion tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.DocumentConversionToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `document_conversion`.<br/>
        /// Default Value: document_conversion<br/>
        /// Example: document_conversion
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the document conversion tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentConversionToolConfigurationVariant2(
            string type,
            global::Vectara.DocumentConversionToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolConfigurationVariant2" /> class.
        /// </summary>
        public DocumentConversionToolConfigurationVariant2()
        {
        }
    }
}