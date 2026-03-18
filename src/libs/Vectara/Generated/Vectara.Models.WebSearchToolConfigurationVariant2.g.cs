
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `web_search`.<br/>
        /// Default Value: web_search<br/>
        /// Example: web_search
        /// </summary>
        /// <default>"web_search"</default>
        /// <example>web_search</example>
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
        /// Initializes a new instance of the <see cref="WebSearchToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `web_search`.<br/>
        /// Default Value: web_search<br/>
        /// Example: web_search
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the web search tool. If not provided, will be filled in by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolConfigurationVariant2(
            string type,
            global::Vectara.WebSearchToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolConfigurationVariant2" /> class.
        /// </summary>
        public WebSearchToolConfigurationVariant2()
        {
        }
    }
}