
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineGetDocumentTextToolConfigurationVariant2
    {
        /// <summary>
        /// The type of tool configuration, which is always 'get_document_text' for inline get document text tool configurations.<br/>
        /// Default Value: get_document_text
        /// </summary>
        /// <default>"get_document_text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "get_document_text";

        /// <summary>
        /// Configurable parameters for the get document text tool. If not overridden, they will be required by the agent to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.GetDocumentTextParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// User-configurable settings for the get document text tool. These parameters are never exposed to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration")]
        public global::Vectara.GetDocumentTextConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineGetDocumentTextToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'get_document_text' for inline get document text tool configurations.<br/>
        /// Default Value: get_document_text
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the get document text tool. If not overridden, they will be required by the agent to fill in.
        /// </param>
        /// <param name="toolConfiguration">
        /// User-configurable settings for the get document text tool. These parameters are never exposed to the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineGetDocumentTextToolConfigurationVariant2(
            string type,
            global::Vectara.GetDocumentTextParameters? argumentOverride,
            global::Vectara.GetDocumentTextConfiguration? toolConfiguration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
            this.ToolConfiguration = toolConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineGetDocumentTextToolConfigurationVariant2" /> class.
        /// </summary>
        public InlineGetDocumentTextToolConfigurationVariant2()
        {
        }

    }
}