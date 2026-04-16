
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Verify the worker agent's output using a separate judge agent. The judge agent receives<br/>
    /// a summary of the worker agent's session and must produce a structured output with<br/>
    /// `{ "success": boolean, "reason": string }`. The judge agent must be configured with a<br/>
    /// structured output parser matching this schema.
    /// </summary>
    public sealed partial class AgentVerification
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
        /// Initializes a new instance of the <see cref="AgentVerification" /> class.
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
        public AgentVerification(
            string type,
            string agentKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVerification" /> class.
        /// </summary>
        public AgentVerification()
        {
        }
    }
}