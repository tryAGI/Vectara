
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
        /// Defines how to verify whether a pipeline record was successfully processed by the<br/>
        /// worker agent. Two strategies are supported: a lightweight condition expression or<br/>
        /// a full judge agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.PipelineVerificationJsonConverter))]
        public global::Vectara.PipelineVerification? Verification { get; set; }

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
        /// <param name="verification">
        /// Defines how to verify whether a pipeline record was successfully processed by the<br/>
        /// worker agent. Two strategies are supported: a lightweight condition expression or<br/>
        /// a full judge agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransformConfiguration(
            string type,
            string agentKey,
            global::Vectara.PipelineVerification? verification)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Verification = verification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransformConfiguration" /> class.
        /// </summary>
        public AgentTransformConfiguration()
        {
        }
    }
}