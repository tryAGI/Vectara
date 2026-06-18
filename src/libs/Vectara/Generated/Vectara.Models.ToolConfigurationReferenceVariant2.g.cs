
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolConfigurationReferenceVariant2
    {
        /// <summary>
        /// The type of tool configuration, which is always 'reference' for referenced configurations.<br/>
        /// Default Value: reference
        /// </summary>
        /// <default>"reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "reference";

        /// <summary>
        /// A unique key that identifies a reusable tool configuration within a customer account.<br/>
        /// Customer-provided; if omitted when creating a configuration, one is generated from the name.<br/>
        /// Example: customer_support_search
        /// </summary>
        /// <example>customer_support_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolConfigurationKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfigurationReferenceVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'reference' for referenced configurations.<br/>
        /// Default Value: reference
        /// </param>
        /// <param name="toolConfigurationKey">
        /// A unique key that identifies a reusable tool configuration within a customer account.<br/>
        /// Customer-provided; if omitted when creating a configuration, one is generated from the name.<br/>
        /// Example: customer_support_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolConfigurationReferenceVariant2(
            string type,
            string toolConfigurationKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolConfigurationKey = toolConfigurationKey ?? throw new global::System.ArgumentNullException(nameof(toolConfigurationKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfigurationReferenceVariant2" /> class.
        /// </summary>
        public ToolConfigurationReferenceVariant2()
        {
        }

    }
}