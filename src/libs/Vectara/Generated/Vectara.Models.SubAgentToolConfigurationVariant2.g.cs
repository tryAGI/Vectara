
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubAgentToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `sub_agent`.<br/>
        /// Default Value: sub_agent<br/>
        /// Example: sub_agent
        /// </summary>
        /// <default>"sub_agent"</default>
        /// <example>sub_agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "sub_agent";

        /// <summary>
        /// Configurable parameters for the sub-agent tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::Vectara.SubAgentToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// User-configurable settings for the sub-agent tool. These parameters are never exposed to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_agent_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.SubAgentConfiguration SubAgentConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `sub_agent`.<br/>
        /// Default Value: sub_agent<br/>
        /// Example: sub_agent
        /// </param>
        /// <param name="subAgentConfiguration">
        /// User-configurable settings for the sub-agent tool. These parameters are never exposed to the agent.
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the sub-agent tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubAgentToolConfigurationVariant2(
            string type,
            global::Vectara.SubAgentConfiguration subAgentConfiguration,
            global::Vectara.SubAgentToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
            this.SubAgentConfiguration = subAgentConfiguration ?? throw new global::System.ArgumentNullException(nameof(subAgentConfiguration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolConfigurationVariant2" /> class.
        /// </summary>
        public SubAgentToolConfigurationVariant2()
        {
        }
    }
}