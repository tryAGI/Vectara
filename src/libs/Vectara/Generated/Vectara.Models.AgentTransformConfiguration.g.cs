
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Process source data using an agent. Each run creates one or more agent sessions<br/>
    /// and sends source records as input for the agent to act on per its instructions.
    /// </summary>
    public sealed partial class AgentTransformConfiguration
    {
        /// <summary>
        /// Default Value: agent<br/>
        /// Example: agent
        /// </summary>
        /// <default>"agent"</default>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "agent";

        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransformConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: agent<br/>
        /// Example: agent
        /// </param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransformConfiguration(
            string type,
            string agentKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransformConfiguration" /> class.
        /// </summary>
        public AgentTransformConfiguration()
        {
        }
    }
}