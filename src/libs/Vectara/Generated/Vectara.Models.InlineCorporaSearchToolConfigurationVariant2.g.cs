
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineCorporaSearchToolConfigurationVariant2
    {
        /// <summary>
        /// The type of tool configuration, which is always 'corpora_search' for inline corpora search tool configurations.<br/>
        /// Default Value: corpora_search
        /// </summary>
        /// <default>"corpora_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "corpora_search";

        /// <summary>
        /// LLM-exposed parameters for the corpora search tool that can be filled in during execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.CorporaSearchToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Agent-specific query configuration that supports eager references. Use this in agent tool configurations when turn-start resolution is needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentCorporaSearchQueryConfiguration QueryConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineCorporaSearchToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'corpora_search' for inline corpora search tool configurations.<br/>
        /// Default Value: corpora_search
        /// </param>
        /// <param name="queryConfiguration">
        /// Agent-specific query configuration that supports eager references. Use this in agent tool configurations when turn-start resolution is needed.
        /// </param>
        /// <param name="argumentOverride">
        /// LLM-exposed parameters for the corpora search tool that can be filled in during execution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineCorporaSearchToolConfigurationVariant2(
            string type,
            global::Vectara.AgentCorporaSearchQueryConfiguration queryConfiguration,
            global::Vectara.CorporaSearchToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
            this.QueryConfiguration = queryConfiguration ?? throw new global::System.ArgumentNullException(nameof(queryConfiguration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineCorporaSearchToolConfigurationVariant2" /> class.
        /// </summary>
        public InlineCorporaSearchToolConfigurationVariant2()
        {
        }

    }
}