
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Direct route to a single agent. The `agent_key` must reference an existing agent owned by the same customer.
    /// </summary>
    public sealed partial class SingleRuleTargets
    {
        /// <summary>
        /// Default Value: single
        /// </summary>
        /// <default>"single"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "single";

        /// <summary>
        /// The key of the underlying agent this rule routes to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleRuleTargets" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: single
        /// </param>
        /// <param name="agentKey">
        /// The key of the underlying agent this rule routes to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleRuleTargets(
            string type,
            string agentKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleRuleTargets" /> class.
        /// </summary>
        public SingleRuleTargets()
        {
        }

    }
}