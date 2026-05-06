
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineWebSearchToolConfigurationVariant2
    {
        /// <summary>
        /// The type of tool configuration, which is always 'web_search' for inline web search tool configurations.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>"web_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "web_search";

        /// <summary>
        /// Configurable parameters for the web search tool. If not provided, will be filled in by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.WebSearchToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineWebSearchToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'web_search' for inline web search tool configurations.<br/>
        /// Default Value: web_search
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the web search tool. If not provided, will be filled in by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineWebSearchToolConfigurationVariant2(
            string type,
            global::Vectara.WebSearchToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineWebSearchToolConfigurationVariant2" /> class.
        /// </summary>
        public InlineWebSearchToolConfigurationVariant2()
        {
        }
    }
}