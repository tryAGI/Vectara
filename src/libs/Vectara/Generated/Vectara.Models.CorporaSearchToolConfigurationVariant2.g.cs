
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorporaSearchToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `corpora_search`.<br/>
        /// Default Value: corpora_search<br/>
        /// Example: corpora_search
        /// </summary>
        /// <default>"corpora_search"</default>
        /// <example>corpora_search</example>
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
        /// Initializes a new instance of the <see cref="CorporaSearchToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `corpora_search`.<br/>
        /// Default Value: corpora_search<br/>
        /// Example: corpora_search
        /// </param>
        /// <param name="argumentOverride">
        /// LLM-exposed parameters for the corpora search tool that can be filled in during execution.
        /// </param>
        /// <param name="queryConfiguration">
        /// Agent-specific query configuration that supports eager references. Use this in agent tool configurations when turn-start resolution is needed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorporaSearchToolConfigurationVariant2(
            string type,
            global::Vectara.AgentCorporaSearchQueryConfiguration queryConfiguration,
            global::Vectara.CorporaSearchToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.QueryConfiguration = queryConfiguration ?? throw new global::System.ArgumentNullException(nameof(queryConfiguration));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolConfigurationVariant2" /> class.
        /// </summary>
        public CorporaSearchToolConfigurationVariant2()
        {
        }
    }
}