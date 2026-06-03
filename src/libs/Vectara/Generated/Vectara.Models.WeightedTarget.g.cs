
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single option inside a weighted rule. Weight is required and must be a non-negative integer; the resolver normalizes weights across the rule's options at evaluation time.
    /// </summary>
    public sealed partial class WeightedTarget
    {
        /// <summary>
        /// The key of the underlying agent this option routes to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// Weight used when selecting among the weighted options. Absolute non-negative integer, normalized at evaluation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedTarget" /> class.
        /// </summary>
        /// <param name="agentKey">
        /// The key of the underlying agent this option routes to.
        /// </param>
        /// <param name="weight">
        /// Weight used when selecting among the weighted options. Absolute non-negative integer, normalized at evaluation time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WeightedTarget(
            string agentKey,
            int weight)
        {
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedTarget" /> class.
        /// </summary>
        public WeightedTarget()
        {
        }

    }
}